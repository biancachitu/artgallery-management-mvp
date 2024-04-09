using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;


namespace ArtGalleryMng.Model.Repository
{
    public class UserRepository : IUserRepository
    {
        public Repository Repository { get; set; }

        public UserRepository()
        {
            this.Repository = new Repository();
        }

        private User ConvertToUser(DataRow dataRow)
        {
            int Id = (int)dataRow["Id"];
            string FullName = (string)dataRow["FullName"];
            string Email = (string)dataRow["Email"];
            string Password = (string)dataRow["Pass"];
            int AccessType_id = (int)dataRow["AccessTypeId"];

            return new User(Id, FullName, Email, Password, AccessType_id);
        }

        public virtual User GetUserByEmail(string email)
        {
            try
            {
                string commandSql = "SELECT * FROM userlogin WHERE Email = '" + email + "'";
                DataTable dataTable = Repository.GetTable(commandSql);
                if(dataTable != null)
                {
                    DataRow row = dataTable.Rows[0];
                    return ConvertToUser(row);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }

        public DataTable UserTable()
        {
            string commandSQL = "SELECT * FROM userlogin ORDER BY Id";
            DataTable dt = Repository.GetTable(commandSQL);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public bool InsertUser(User user)
        {
            try
            {
                int accessID = user.GetAccessTypeId();
                string commandSQL = "INSERT INTO userlogin ( FullName, Email, Pass, AccessTypeId ) VALUES ( ";
                commandSQL += "'" + user.FullName + "', '"
                            + user.Email + "', '"
                            + user.Pass + "', "
                            + accessID + " )";
                return this.Repository.CommandSql(commandSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                string commandSQL = "DELETE FROM userlogin WHERE Id = '" + id + "'";
                return this.Repository.CommandSql(commandSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                string commandSQL = "UPDATE userlogin SET FullName = '" + user.FullName;
                commandSQL += "', Email = '" + user.Email + "', ";
                commandSQL += "Pass = '" + user.Pass + "', ";
                commandSQL += "AccessTypeId = " + user.GetAccessTypeId();
                commandSQL += " WHERE Id = " + user.Id;

                return this.Repository.CommandSql(commandSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return false;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                string commandSql = "SELECT * FROM userlogin WHERE Id = " + id;
                DataTable dt = Repository.GetTable(commandSql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ConvertToUser(dt.Rows[0]);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }

        public bool IsValidEmail(string email)
        {
            string regex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, regex);
        }
    }
}
