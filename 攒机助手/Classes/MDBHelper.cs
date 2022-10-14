using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public class MDBHelper
    {

        //public static string SellDb = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;

        public static bool CreateField(string mdbPath, ArrayList mdbHead)
        {
            //1、建立连接   
            string strConn
                = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            //2、打开连接   
            odcConnection.Open();
            //////////////////////////////////////////////
            string sql;
            int size = mdbHead.Count;
            for (int i = 0; i < size; i++)
            {
                sql = "ALTER TABLE cuanji ADD " + mdbHead[i].ToString() + " VARCHAR(20) NULL";
                OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                cmd.ExecuteNonQuery();
            }
            odcConnection.Close();
            return true;
            //ALTER TABLE doc_exa ADD column_b VARCHAR(20) NULL
        }
        public static bool CreateMDBTable(string mdbPath, string tableName, ArrayList mdbHead)
        {

            string heads = "";
            for (int i = 0; i < mdbHead.Count; i++)
            {
                if (i == mdbHead.Count - 1)
                {
                    heads += mdbHead[i].ToString() + " varchar(255)";
                }
                else
                {
                    heads += mdbHead[i].ToString() + " varchar(255),";
                }
            }
            string strConn
    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            //2、打开连接   
            odcConnection.Open();
            //////////////////////////////////////////////
            string sql;
            sql = "CREATE TABLE " + tableName + "(" + heads + ")";

            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
            cmd.ExecuteNonQuery();
            odcConnection.Close();

            return true;
        }
        #region access数据库操作 之 判断数据库中是否存在某表
        public static bool GetTables(string conStr, string name)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {

                conn.Open();
                int result = 0;
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                                 new object[] { null, null, null, "TABLE" });

                if (schemaTable != null)
                {
                    for (Int32 row = 0; row < schemaTable.Rows.Count; row++)
                    {
                        string col_name = schemaTable.Rows[row]["TABLE_NAME"].ToString();
                        if (col_name == name)
                        {
                            result++;
                        }
                    }
                }
                if (result == 0)
                { return false; }
                else { return true; }
            }
        }
        #endregion

        public static OleDbConnection OpenConnection(string conStr)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            return con;
        }
        public static int ExecuteNonQuery(OleDbConnection con, string sql, params OleDbParameter[] pms)
        {

            using (OleDbCommand cmd = new OleDbCommand(sql, con))
            {
                if (pms != null)
                { cmd.Parameters.AddRange(pms); }

                return cmd.ExecuteNonQuery();

            }

        }
        public static int ExecuteNonQuery(string conStr, string sql, params OleDbParameter[] pms)
        {
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    if (pms != null)
                    { cmd.Parameters.AddRange(pms); }

                    return cmd.ExecuteNonQuery();

                }
            }
        }

        public static void CloseConnection(OleDbConnection con)
        {
            con.Close();
            con.Dispose();
        }

        public static object ExecuteScalar(string conStr, string sql, params OleDbParameter[] pms)
        {
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);

                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        public static OleDbDataReader ExecuteReader(string conStr, string sql, params OleDbParameter[] pms)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            using (OleDbCommand cmd = new OleDbCommand(sql, con))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);

                }
                try
                {
                    con.Open();

                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }



        }
    }
}
