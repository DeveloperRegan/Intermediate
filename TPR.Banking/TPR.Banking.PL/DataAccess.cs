using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace TPR.Banking.PL
{
    public static class DataAccess
    {
        #region XMLSerialering
        public static void SaveToXml(string filepath, object obj, Type type)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filepath);
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
                writer.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static object LoadFromXml(string filepath, Type type)
        {
            try
            {
                StreamReader reader = new StreamReader(filepath);
                XmlSerializer serializer = new XmlSerializer(type);
                object obj = serializer.Deserialize(reader);
                reader.Close();
                return obj;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
        #region DataBase
        private static SqlConnection connection;

        public static string ConnectionString { get; set; }

        private static void openConnection()
        {
            if (ConnectionString == null || ConnectionString.Length == 0)
            {
                throw new Exception("The connection string was never set.");
            }

            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            connection?.Close();
        }


        public static DataTable RunSelect(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                openConnection();

                SqlCommand command = new SqlCommand(sql, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static int RunSQL(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                openConnection();

                SqlCommand command = new SqlCommand(sql, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}
