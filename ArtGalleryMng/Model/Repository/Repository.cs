using System;
using System.Data;
using System.Xml.Linq;
using System.Configuration;
using Npgsql;

namespace ArtGalleryMng.Model.Repository
{
    public class Repository 
    {
        protected NpgsqlConnection connection { get; set; }

        public Repository()
        {
            string connStr = "Server=127.0.0.1;Port=5432;Database=artgallery;User Id=postgres;Password=admin;";
            this.connection = new NpgsqlConnection(connStr);
        }

        public void OpeningConnection()
        {
            try
            {
                if (this.connection.State != ConnectionState.Open)
                {
                    this.connection.Open();
                    Console.WriteLine("Connection opened successfully.\n");
                }
                else
                {
                    Console.WriteLine("Connection already open.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
                throw; 
            }
        }

        public void ClosingConnection()
        {
            if (this.connection.State == ConnectionState.Closed)
            {
                this.connection.Close();
                Console.WriteLine("Connection closed.\n");
            }
        }

        public bool CommandSql(string commandSQL)
        {
            bool result = true;
            try
            {
                this.OpeningConnection();
                using (NpgsqlCommand command = new NpgsqlCommand(commandSQL, connection))
                {
                    if (command.ExecuteNonQuery() == 0)
                        result = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                this.ClosingConnection();
            }
            return result;
        }

        public DataTable GetTable(string commandSQL)
        {
            DataTable result = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(commandSQL, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching data from database: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return result;
        }


    }
}
