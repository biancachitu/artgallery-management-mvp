using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ArtGalleryMng.Model.Repository
{
    public class ArtworkRepository : IArtworkRepository
    {
        public Repository Repository { get; set; }

        public ArtworkRepository()
        {
            this.Repository = new Repository();
        }

        private Artwork ConvertToArtwork(DataRow dataRow)
        {
            int id = (int)dataRow["Id"];
            string title = (string)dataRow["Title"];
            string artist = (string)dataRow["Artist"];
            int year_made = (int)dataRow["Year_made"];
            int type_id = (int)dataRow["Type_id"];
            int gallery_id = (int)dataRow["Gallery_id"];

            //Type type = Artwork.GetTypeFromId(type_id);
            return new Artwork(id, title, artist, year_made, type_id, gallery_id);
        }

        private List<Artwork> ConvertDataTableToArtworksList(DataTable dataTable)
        {
            List<Artwork> artworks = new List<Artwork>();
            foreach(DataRow row in dataTable.Rows)
            {
                artworks.Add(ConvertToArtwork(row));
            }
            return artworks;
        }

        public DataTable ArtworkTable(int galleryId)
        {
            string commandSQL = "SELECT * FROM artwork WHERE Gallery_id = " + galleryId + " ORDER BY Year_made";
            DataTable artTable = Repository.GetTable(commandSQL);
            if (artTable == null || artTable.Rows.Count == 0)
            {
                return null;
            }
            return artTable;
        }

        public bool InsertArtwork(Artwork artwork)
        {
            int typeId = artwork.GetTypeId();
            string commandSQL = "INSERT INTO artwork (Title, Artist, Year_made, Type_id, Gallery_id) VALUES (";
            commandSQL += "'" + artwork.Title + "', '"
                        + artwork.Artist + "', "
                        + artwork.Year_made + ", "
                        + typeId + ", "
                        + artwork.Gallery_id + ")";
            return this.Repository.CommandSql(commandSQL);
        }

        public bool DeleteArtwork(int id)
        {
            string commandSQL = "DELETE FROM artwork WHERE Id = '" + id + "'";
            return this.Repository.CommandSql(commandSQL);
        }   

        public bool UpdateArtwork(Artwork artwork)
        {
            try
            {
                string commandSQL = "UPDATE artwork SET Title = '" + artwork.Title + "', Artist = '" + artwork.Artist + "', ";
                commandSQL += "Year_made = " + artwork.Year_made + ", ";
                commandSQL += "Type_id = " + artwork.GetTypeId() + ", ";
                commandSQL += "Gallery_id = " + artwork.Gallery_id;
                commandSQL += " WHERE Id = " + artwork.Id;

                return this.Repository.CommandSql(commandSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return false;
            }
        }

        public Artwork GetArtworkById(int id)
        {
            try
            {
                string commandSql = "SELECT * FROM artwork WHERE Id = " + id;
                DataTable dt = Repository.GetTable(commandSql);
                if(dt != null && dt.Rows.Count > 0)
                {
                    return ConvertToArtwork(dt.Rows[0]);
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

        public List<Artwork> GetArtworksByArtist(string artist, int galleryId)
        {
            try
            {
                string commandSql = "SELECT * FROM artwork WHERE Artist LIKE '%" + artist + "%' AND Gallery_id = " + galleryId + " ORDER BY Year_made";
                DataTable artTable = Repository.GetTable(commandSql);
                return ConvertDataTableToArtworksList(artTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }

        public List<Artwork> GetArtworksByType(int type_id, int galleryId)
        {
            try
            { 
                string commandSql = "SELECT * FROM artwork WHERE Type_id = " + type_id + " AND Gallery_id = " + galleryId + " ORDER BY Year_made";

                DataTable artTable = Repository.GetTable(commandSql);
                return ConvertDataTableToArtworksList(artTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }

        public bool DoesGalleryExist(int galleryId)
        {
            string commandSql = "SELECT Id FROM gallery WHERE Id = " + galleryId;
            DataTable dt = Repository.GetTable(commandSql);
            return dt != null && dt.Rows.Count > 0;
        }

        public bool DoesArtworkExist(string title, int galleryId)
        {
            string commandSql = "SELECT Id FROM artwork WHERE Title = '" + title + "' AND Gallery_id = " + galleryId;
            DataTable dt = Repository.GetTable(commandSql);
            return dt != null && dt.Rows.Count > 0;
        }

        public int GetGalleryIdFromName(string galleryName)
        {
            try
            {
                string commandSql = "SELECT Id FROM gallery WHERE Name = '" + galleryName + "'";
                DataTable dt = Repository.GetTable(commandSql);

                if(dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["Id"]);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
                return -1;
            }
        }

        public List<string> GetGalleryNames()
        {
            try
            {
                List<string> names = new List<string>();
                string commandSql = "SELECT Name FROM gallery";
                DataTable dt = Repository.GetTable(commandSql);
                if(dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        names.Add(row["Name"].ToString());  
                    }
                }
                return names;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
