using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WCM_Log_Generator
{
    class Util
    {
        /// <summary>
        /// Allow Multiple files to be passed to Directory.Getfiles()
        /// </summary>
        /// <param name="path">Path from which to retrieve file names</param>
        /// <param name="filter">String filter(s) containing '*' or '?' to filter file names by</param>
        /// <returns>List of strings of filenames</returns>
        public static List<string> GetFiles(string path) => GetFiles(path, new string[] { "*" });
        public static List<string> GetFiles(string path, String extensionFilter) => GetFiles(path, new string[] { extensionFilter });
        public static List<string> GetFiles(string path, String[] extensionFilter)
        {
            List<string> files = new List<string> { };

            if (extensionFilter == null)
                extensionFilter = new string[] { "*" };

            foreach (string ext in extensionFilter)
            {
                files.AddRange(Directory.GetFiles(path, ext));
            }

            return files;
        }

        public static string ChooseDirectory()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath) && Directory.Exists(fbd.SelectedPath))
                    return fbd.SelectedPath;
                return null;
            }
        }

        /// <summary>
        /// Generate A Simian Log File
        /// </summary>
        /// <returns>True if successful, False otherwise</returns>        
        public static bool GenerateLog(List<string> fileList, string outputDirectory, string outputFileName, string outputFileExtension = ".txt")
        {
            // TODO: Make time configurable
            const int DAY = 86400;
            
            // total time, in seconds, of current log file
            double totalTime = 0.0;
            // List containing lists of the contents for each log file
            List<List<string>> logs = new List<List<string>> { new List<string> { } };
            // Current Log File number
            int currentLog = 0;

            foreach(string file in fileList)
            {
                // TODO: get play time from file
                int playTime = 1000;
                totalTime += playTime;
                if (totalTime > DAY)
                {
                    currentLog += 1;
                    totalTime = playTime;
                    logs.Add(new List<string> { });
                }

                logs[currentLog].Add(file);
            }

            for(int i = 0; i < logs.Count; i++)
            {
                string filepath = Path.Combine(outputDirectory, outputFileName + "-" + (i + 1).ToString() + outputFileExtension);
                File.WriteAllLines(filepath, logs[i]);
            }

            return true;
        }
    }
}
