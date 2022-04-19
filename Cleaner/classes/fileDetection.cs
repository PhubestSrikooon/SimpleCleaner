using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Cleaner.classes
{
    internal class fileDetection
    {
        static classes.fileDetection _obj;
        public static classes.fileDetection Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new classes.fileDetection();
                }
                return _obj;
            }
        }
        static string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public string[] nonactionPath = new string[] {
            Path.GetTempPath(),
            $"{userFolder}\\AppData\\Local\\Microsoft\\Windows\\Explorer",
            $"{userFolder}\\AppData\\Local\\NVIDIA\\DXCache"
        };

        public long totalSize;
        public string curentScaning;
        public int progress;

        /// <summary>
        /// A browser cache folder path
        /// </summary>
        public string[,] browserCache = new string[,] {
            {
                "OperaStable",
                 $"{userFolder}\\AppData\\Local\\Opera Software\\Opera Stable\\Cache\\Cache_Data",
                 "opera.exe"
            },
            { 
                "EdgeStable",
                $"{userFolder}\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Cache\\Cache_Data",
                "edge.exe"
            }
        };


        /// <summary>
        /// Unnecessary function this function is for GetFiles() only 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool isFileAccessible(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                return false;
            }

            if (!File.Exists(filename))
            {
                return false;
            }

            try
            {
                File.GetAccessControl(filename, System.Security.AccessControl.AccessControlSections.Access);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool isDirectoryAccessible(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!Directory.Exists(path))
            {
                return false;
            }

            try
            {
                Directory.GetAccessControl(path, System.Security.AccessControl.AccessControlSections.Access);
            }
            catch
            {
                return false;
            }

            return true;
        }


        String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return $"{(Math.Sign(byteCount) * num).ToString()} {suf[place]}";
        }
        public List<string> GetFiles(string path, string pattern)
        {
            List<string> fileList = new List<string>();
            List<string> directoryList = new List<string>();

            directoryList.Add(path);

            while (true)
            {
                if (directoryList.Count <= 0)
                {
                    break;
                }

                string directory = directoryList.First();
                directoryList.RemoveAt(0);

                if (!isDirectoryAccessible(directory))
                {
                    continue;
                }

                foreach (string item in Directory.EnumerateDirectories(directory, "*", SearchOption.TopDirectoryOnly))
                {
                    if (!isDirectoryAccessible(item))
                    {
                        continue;
                    }

                    directoryList.Add(item);
                }

                foreach (string item in Directory.EnumerateFiles(directory, pattern, SearchOption.TopDirectoryOnly))
                {
                    if (!isFileAccessible(item))
                    {
                        continue;
                    }
                    fileList.Add(item);
                    totalSize += new FileInfo(item).Length;
                    curentScaning = item;
                }
            }

            return fileList;
        }

        public void scan()
        {
            bool IsProcessRunning(string processName)
            {
                if (Process.GetProcessesByName(processName).Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            string[] noaction_files()
            {
                string[] files = { };
                foreach (string path in nonactionPath)
                {
                    files.Union(GetFiles(path, "*"));
                }
                return files;
            }
            string[] action_files()
            {
                string[] files = {};
                for (int x = 0; x < browserCache.GetLength(0); x++)
                {
                    for (int y = 0; y < browserCache.GetLength(1); y++)
                    {
                        files.Union(GetFiles(browserCache[x, 2], "*")).ToArray();
                    }
                }
                return files;
            }

            action_files();
            noaction_files();
        }
    }
}
