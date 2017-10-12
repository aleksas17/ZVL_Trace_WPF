using System;
using System.Collections.Generic;
using System.IO;

namespace Charts_MVVM
{
    public class FileSourceStructure
    {
        /// <summary>
        /// Create blank list for folder items
        /// </summary>
        public static List<SourceItem> folderItems = new List<SourceItem>();

        #region Helper Metahods

        /// <summary>
        /// Put all folder items to list
        /// </summary>
        /// <param name="fullPath">Path to folder</param>
        public static void GetFileNames(string fullPath)
        {
            var s1pFilesDirectory = new DirectoryInfo(fullPath);
            // Exstracting all item from folder by type
            FileInfo[] Files = s1pFilesDirectory.GetFiles("*.s1p");
            // Sorting list 
            Array.Sort(Files, new NumberTextSort());
            foreach (FileInfo file in Files)
            {
                folderItems.Add(new SourceItem { Fullpath = file.FullName, name = Path.GetFileNameWithoutExtension(file.Name) });
            }
            ChartControlViewModel.AddItemsToCombobox(folderItems);
        }

        #endregion
    }
}
