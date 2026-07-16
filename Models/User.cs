
using System;

namespace SmartMed.Models
{
    internal abstract class User
    {
        // =====================================================
        // Private Fields
        // =====================================================
        private int userID;
        private string username;
        private string password;
        private string fullName;
        private string email;

        // =====================================================
        // Public Properties
        // =====================================================
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // =====================================================
        // Constructors
        // =====================================================
        public User()
        {
            userID = 0;
            username = string.Empty;
            password = string.Empty;
            fullName = string.Empty;
            email = string.Empty;
        }

        public User(int userID, string username, string password, string fullName, string email)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.email = email;
        }

        // =====================================================
        // Abstract Authentication Methods (must be overridden)
        // =====================================================
        public abstract bool Login();
        public abstract void Logout();
    }
}