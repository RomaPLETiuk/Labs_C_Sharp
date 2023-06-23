using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BusST
{
    internal class DataModule
    {

       

        public static void ClearFileName(string path)
        {
            int i, len, pos = -1;
            len = path.Length;
            for (i = 0; i < len; i++)
            {
                if (path[i] == '\\')
                {
                    pos = i;
                }
            }
            if (pos != -1)
            {
                path = path.Substring(0, pos);
            }
        }

        public static bool GetAppPath(out string path)
        {
            try
            {
                path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                return true;
            }
            catch
            {
                path = null;
                return false;
            }
        }
        public static bool GetConnectionString(ref string cs)
        {
            string fileName = "";
            if (!GetAppPath(out fileName))
            {
                cs = "";
                return false;
            }
            fileName += "\\DBConnectionString";
            if (!File.Exists(fileName))
            {
                cs = "";
                return false;
            }
            else
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length == 0)
                {
                    cs = "";
                    return false;
                }
                else
                {
                    cs = lines[0];
                    return true;
                }
            }
        }



        

        SqlConnection sqlConnection;

       
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }


    }
}
