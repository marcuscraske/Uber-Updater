/*
 * UBERMEAT FOSS
 * ****************************************************************************************
 * License:                 Creative Commons Attribution-ShareAlike 3.0 unported
 *                          http://creativecommons.org/licenses/by-sa/3.0/
 * 
 * Project:                 Uber Updater
 * File:                    /Main.cs
 * Author(s):               limpygnome						limpygnome@gmail.com
 *                          DotNetZip library               http://dotnetzip.codeplex.com/
 * To-do/bugs:              none
 * 
 * Responsible for interacting with the user and updating an application.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;
using Ionic.Zip;
using System.Xml;

namespace Updater
{
    public partial class Main : Form
    {
        #region "Variables"
        /// <summary>
        /// Used to store the settings for the current version of the application.
        /// </summary>
        private XmlDocument settings;
        #endregion

        #region "Constructors"
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region "Methods - Events"
        private void Main_Load(object sender, EventArgs e)
        {
            // Load the configuration
            settings = new XmlDocument();
            try
            { settings.Load("Updater.xml"); }
            catch (FileNotFoundException)
            { throwError(this, "Settings file not found or inaccessible (Updater.xml)!"); }
            catch (Exception ex)
            { throwError(this, "Unknown error - " + ex.Message); }
            // Check the updater is enabled, else terminate
            if (settings["update"]["enabled"].InnerText == "0")
                Environment.Exit(1);
            // Grab the latest version information
            WebClient wc = new WebClient();
            StreamReader sw = null;
            // This may error due to e.g. the resource being unavailable, so this isn't a critical error and we can just exit
            try
            {
                sw = new StreamReader(wc.OpenRead(settings["update"]["urlVersionCheck"].InnerText));
            }
            catch (Exception)
            { Environment.Exit(1); }
            // Get the current version
            int currVersionMajor = int.Parse(sw.ReadLine());
            int currVersionMin = int.Parse(sw.ReadLine());
            int currVersionBuild = int.Parse(sw.ReadLine());
            sw.Close();
            wc.Dispose();
            // Decide if to update - we dont care if it's less, the user may be behind a proxy with a cache of some kind
            if (currVersionMajor <= int.Parse(settings["update"]["version"]["major"].InnerText)
                && currVersionMin <= int.Parse(settings["update"]["version"]["minor"].InnerText)
                && currVersionBuild <= int.Parse(settings["update"]["version"]["build"].InnerText)
                )
            {
                // Exit the application - nothing to update
                Environment.Exit(1);
            }
            else
            {
                try
                {
                    // Grab the changelog
                    sw = new StreamReader(wc.OpenRead(settings["update"]["urlChangelog"].InnerText));
                    txtChangelog.Text = sw.ReadToEnd().Replace("\r\n", "\n").Replace("\n", "\r\n");
                }
                catch(Exception ex)
                // An error will only occur if the resource could not be read (e.g. network connection issue, Github down etc)
                // -- ... so we'll just exit
                { txtChangelog.Text = "Failed to retrieve change-log:\r\n" + ex.Message; }
                // Set application title
                txtApplication.Text = settings["update"]["title"].InnerText;
                // Set version current
                txtVersionCurrent.Text =
                    settings["update"]["version"]["major"].InnerText + "." +
                    settings["update"]["version"]["minor"].InnerText + "." +
                    settings["update"]["version"]["build"].InnerText;
                // Set version new
                txtVersionNew.Text = currVersionMajor + "." + currVersionMin + "." + currVersionBuild;
                // Set icon
                try
                {
                    Bitmap b = Icon.ExtractAssociatedIcon(Environment.CurrentDirectory + "\\" + settings["update"]["executeFile"].InnerText).ToBitmap();
                    b.MakeTransparent();
                    pbIcon.Image = b;
                }
                catch { }
            }
            // Focus attention on the update button
            buttUpdate.Select();
        }
        /// <summary>
        /// Invoked wehn the user presses the button "Update".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            // Focus attention on the progressbar
            progressBar.Select();
            // Begin the update
            beginUpdate();
        }
        #endregion

        #region "Methods - Updater"
        /// <summary>
        /// Starts the update process.
        /// </summary>
        public void beginUpdate()
        {
            panelUpdate.Visible = true;
            buttUpdate.Visible = false;
            status(this, "Downloading the latest binary...");
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadFileAsync(new System.Uri(settings["update"]["urlBinary"].InnerText), AppDomain.CurrentDomain.BaseDirectory + "\\Update.zip");
        }
        /// <summary>
        /// Invoked when the progress of the binary download has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar
            statusBar(this, e.ProgressPercentage);
            status(this, "Downloading: " + e.ProgressPercentage + "% (" + e.BytesReceived + "/" + e.TotalBytesToReceive + " bytes)");
        }
        /// <summary>
        /// Invoked when the download of the binary has been completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Launch the secondary thread responsible for the rest of the process
            Thread t = new Thread(new ParameterizedThreadStart(threadUpdate));
            t.Start(this);
        }
        /// <summary>
        /// Responsible for the rest of the installation (unzipping the binary etc).
        /// </summary>
        /// <param name="o"></param>
        public static void threadUpdate(object o)
        {
            Main m = (Main)o;
            // Ensure no processes are running
            Process[] processes;
            while (true)
            {
                bool found = false;
                foreach(XmlNode app in m.settings["update"]["processFileNames"].ChildNodes)
                {
                    processes = Process.GetProcessesByName(app.InnerText.Remove(app.InnerText.Length - 4, 4));
                    if (app.InnerText.Length > 4 && processes.Length != 0)
                    {
                        found = true;
                        status(m, "Waiting for application '" + app.InnerText + "' to close...");
                        foreach (Process p in processes)
                            p.CloseMainWindow();
                        break;
                    }
                }
                // No conflicting processes were found, we can continue - break the loop!
                if (!found) break;
                Thread.Sleep(200); // To reduce processing during this period
            }
            // Create temp directory for unzip
            status(m, "Creating temp directory for download...");
            statusBar(m, 30);
            string tempFolder = AppDomain.CurrentDomain.BaseDirectory + "\\__temp";
            if (Directory.Exists(tempFolder))
                try
                { Directory.Delete(tempFolder, true); }
                catch (Exception ex) { throwError(m, ex.Message); Environment.Exit(1); }
            Directory.CreateDirectory(tempFolder);
            // Unzip the downloaded data
            status(m, "Unzipping downloaded data...");
            statusBar(m, 70);
            ZipFile f = new ZipFile(Environment.CurrentDirectory + "\\Update.zip");
            try
            { f.ExtractAll(tempFolder); }
            catch (Exception ex)
            { throwError(m, "Failed to extract data - " + ex.Message); Environment.Exit(1); }
            f.Dispose();
            // Build list of blacklisted files
            List<string> blacklist = new List<string>();
            foreach (XmlNode file in m.settings["update"]["excludedFiles"].ChildNodes)
                blacklist.Add(file.InnerText);
            // Copy each file except the excluded files
            int removeLength = tempFolder.Length;
            string newFileName, newFilePath, newDirectory;
            statusBar(m, 80);
            foreach (string file in Directory.GetFiles(tempFolder))
            {
                newFilePath = AppDomain.CurrentDomain.BaseDirectory + file.Remove(0, removeLength);
                newFileName = Path.GetFileName(newFilePath);
                if (!blacklist.Contains(newFileName)) // Check if the file is blacklisted and to be ignored
                {
                    status(m, "Extracting " + newFileName);
                    newDirectory = Path.GetDirectoryName(newFilePath);
                    // Check the directory exists
                    try
                    {
                        if (!Directory.Exists(newDirectory))
                            Directory.CreateDirectory(newDirectory);
                    }
                    catch (Exception ex)
                    { throwError(m, ex.Message); Environment.Exit(1); }
                    // Copy the file
                    try
                    { File.Copy(file, newFilePath, true); }
                    catch (Exception ex) { throwError(m, ex.Message); Environment.Exit(1); }
                }
            }
            // Delete temp directory
            statusBar(m, 90);
            status(m, "Deleting temp directory...");
            try
            { Directory.Delete(tempFolder, true); }
            catch (Exception ex) { throwError(m, ex.Message); }
            // Delete downloaded data
            status(m, "Deleting downloaded data...");
            statusBar(m, 95);
            try
            { File.Delete(Environment.CurrentDirectory + "\\Update.zip"); }
            catch (Exception ex) { throwError(m, ex.Message); Environment.Exit(1); }
            // Launch the application
            if (m.settings["update"]["executeFile"] != null)
            {
                status(m, "Update complete, launching application!");
                statusBar(m, 100);
                try
                { Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\" + m.settings["update"]["executeFile"].InnerText); }
                catch
                { throwError(m, "Failed to launch updated application."); }
            }
            else
            {
                status(m, "Update complete, exiting!");
                statusBar(m, 100);
            }
            // Exit
            Environment.Exit(1);
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Updates the status text to inform the user of what is going on.
        /// </summary>
        /// <param name="main"></param>
        /// <param name="text"></param>
        static void status(Main main, string text)
        {
            main.Invoke((MethodInvoker)delegate()
            {
                main.txtStatus.Text = text;
            });
        }
        /// <summary>
        /// Updates the progress-bar.
        /// </summary>
        /// <param name="main"></param>
        /// <param name="amount">Value should be inclusive of 0.0 to 1.0.</param>
        static void statusBar(Main main, float amount)
        {
            main.Invoke((MethodInvoker)delegate()
            {
                main.progressBar.Value = amount / 100;
            });
        }
        /// <summary>
        /// Thrown if the update process fails.
        /// </summary>
        /// <param name="text"></param>
        static void throwError(Main m, string text)
        {
            string contactWebsite = "- unknown -";
            string contactEmail = "- unknown -";
            // We'll attempt to load the contact information safely - we dont want an error within the method responsible for handling them
            try
            {
                contactWebsite = m.settings["update"]["contact"]["website"].InnerText;
                contactEmail = m.settings["update"]["contact"]["email"].InnerText;
            }
            catch { }
            // Minimize the main form
            m.Invoke((MethodInvoker)delegate()
            {
                m.WindowState = FormWindowState.Minimized;
            });
            // Inform the user of what happened and what to do...
            MessageBox.Show("An error occurred:\n\n" + text + "\n\nIt is recommended you back-up any settings files and reinstall the application, apologies! Please do contact us at:\n\nE-mail: \t" + contactEmail + "\nWebsite:\t" + contactWebsite, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
