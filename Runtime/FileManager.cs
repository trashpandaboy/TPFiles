using System;
using System.IO;
using UnityEngine;

namespace com.trashpandaboy.files
{
    public static class FileManager
    {
        /// <summary>
        /// Write specified content on a file
        /// </summary>
        /// <param name="a_FileName">File name that will be put in persistentDataPath</param>
        /// <param name="a_FileContents">String content of file</param>
        /// <returns></returns>
        public static bool WriteToFile(string a_FileName, string a_FileContents)
        {
            var fullPath = Path.Combine(Application.persistentDataPath, a_FileName);

            try
            {
                File.WriteAllText(fullPath, a_FileContents);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to write to {fullPath} with exception {e}");
                return false;
            }
        }

        /// <summary>
        /// Load the content of the specified file
        /// </summary>
        /// <param name="a_FileName">fileName to load</param>
        /// <param name="result">out variable which will store the file content</param>
        /// <returns></returns>
        public static bool LoadFromFile(string a_FileName, out string result)
        {
            var fullPath = Path.Combine(Application.persistentDataPath, a_FileName);

            try
            {
                result = File.ReadAllText(fullPath);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to read from {fullPath} with exception {e}");
                result = "";
                return false;
            }
        }
    }
}
