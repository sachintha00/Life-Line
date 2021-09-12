using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace LifeLine
{
    public class DBManager
    {
        public static MySqlConnection msqlCon;
        private static MySqlCommand msqlCmd;
        private static MySqlDataAdapter msqlDa;
        private static MySqlDataReader msqlDreader;
        private static string lastIndex;

        public static MySqlConnection getSqlConnection()
        {
            msqlCon = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=lifeline;UID=root;PASSWORD=;");
            return msqlCon;
        }

        public static MySqlDataReader ReadAndGet(string cmnd)
        {
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(cmnd, msqlCon);
                msqlDreader = msqlCmd.ExecuteReader();
                //msqlDreader.Close();
                return msqlDreader;
            }
            catch (MySqlException)
            {
                //
            }

            return null;

        }

        public static string getValue(string comd, string txt, int i, int j)
        {
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(comd, msqlCon);
                msqlDreader = msqlCmd.ExecuteReader();
                string value = null;

                if (msqlDreader.HasRows)
                {
                    while (msqlDreader.Read())
                    {
                        if (msqlDreader[i].ToString() == txt)
                        {
                            value = msqlDreader[j].ToString();
                            break;
                        }
                    }
                }
                msqlDreader.Close();
                return value;
            }
            catch (MySqlException)
            {
                //
            }

            return null;
        }

        public static string ReadValue(string command,int columnNumber)
        {
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(command, msqlCon);
                msqlDreader = msqlCmd.ExecuteReader();

                string value = null;

                if (msqlDreader.HasRows)
                {
                    msqlDreader.Read();
                    value = msqlDreader[columnNumber].ToString();
                }
                else
                {
                    value = "Error";
                }
                msqlDreader.Close();
                return value;
            }
            catch (MySqlException)
            {
                //
            }

            return null;


        }

        public static int insrtUpdteDelt(string command)
        {
            int i = 0;
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(command, msqlCon);
                i = msqlCmd.ExecuteNonQuery();
                msqlCon.Close();
                return i;
            }
            catch (MySqlException)
            {
                //
            }

            return i;
        }

        public static string lastRecord(string command)
        {
            lastIndex = null;
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(command, msqlCon); /*"; " + "SELECT last_insert_id()"*/
                lastIndex = msqlCmd.ExecuteScalar().ToString();
                msqlCmd.Dispose();
                msqlCon.Close();
                return lastIndex;
            }
            catch (MySqlException)
            {
                //
            }

            return lastIndex;
        }

        //[Obsolete]
        public static int insrtUpdteDelt(string command, string parameter, byte[] arr)
        {
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlCmd = new MySqlCommand(command, msqlCon);
                msqlCmd.Parameters.AddWithValue(parameter, arr);
                int i = msqlCmd.ExecuteNonQuery();
                msqlCon.Close();
                return i;
            }
            catch (MySqlException)
            {
                //
            }

            return 0;
        }

        public static int chek(string command)
        {
            int i = 0;
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlDa = new MySqlDataAdapter(command, msqlCon);
                DataTable dt = new DataTable();
                msqlDa.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }
                msqlCon.Close();
                return i;
            }
            catch (MySqlException)
            {
                //
            }

            return i;
        }

        public static DataTable getdata(string cmd)
        {
            try
            {
                getSqlConnection();
                msqlCon.Open();
                msqlDa = new MySqlDataAdapter(cmd, msqlCon);
                DataTable dt = new DataTable();
                msqlDa.Fill(dt);
                msqlCon.Close();
                return dt;
            }
            catch (MySqlException)
            {
                //
            }

            return null;
        }
    }
}
