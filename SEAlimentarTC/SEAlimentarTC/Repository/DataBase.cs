using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEAlimentarTC.Repository
{
    public static class DataBase
    {
        public const string DataBaseName = "SEAlimentarDB.db3";

        /**
         * Caminho do DataBase
         * **/
        public static string DBPath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DataBaseName);
            }
        }
    }
}
