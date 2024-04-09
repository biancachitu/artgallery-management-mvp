using System;

namespace ArtGalleryMng.Model
{
    public enum AccessType
    {
        Admin = 1,
        Employee = 2
    }

    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public AccessType AccessType { get; set; }  

        public User(int id, string fullName, string email, string password, int accessType)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Pass = password;
            AccessType = GetAccessTypeFromId(accessType);
        }

        public User(string fullName, string email, string password, int accessType)
        {
            FullName = fullName;
            Email = email;
            Pass = password;
            AccessType = GetAccessTypeFromId(accessType);
        }

        public User() { }

        public int GetAccessTypeId()
        {
            return (int)AccessType;
        }


        public static AccessType GetAccessTypeFromId(int typeId)
        {
            switch (typeId)
            {
                case 1:
                    return AccessType.Admin;
                case 2:
                    return AccessType.Employee;
                
                default:
                    throw new ArgumentException("Invalid AccessTyoeId value: " + typeId);
            }
        }
    }
}
