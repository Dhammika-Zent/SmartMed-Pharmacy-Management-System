using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMed.Helpers
{
    // Simple session holder – stores logged‑in user info so other forms can access it
    internal class SessionManager
    {
        // Private fields
        private int _userID;
        private string _username;
        private string _fullName;
        private string _role;          // "Admin" or "Customer"

        // ====================================================================
        // NEW: Static property to make the current session globally accessible
        // ====================================================================
        public static SessionManager CurrentSession { get; private set; }

        // Public properties
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        // Default constructor – all fields start empty
        public SessionManager()
        {
            _userID = 0;
            _username = string.Empty;
            _fullName = string.Empty;
            _role = string.Empty;
        }

        // Parameterized constructor – directly stores the user’s details
        public SessionManager(int userID, string username, string fullName, string role)
        {
            _userID = userID;
            _username = username;
            _fullName = fullName;
            _role = role;
        }

        // StartSession assigns the values (alternative to the parameterized constructor)
        public void StartSession(int userID, string username, string fullName, string role)
        {
            _userID = userID;
            _username = username;
            _fullName = fullName;
            _role = role;

            // Make this session available to all forms in the application
            CurrentSession = this;
        }

        // EndSession clears all stored information back to defaults
        public void EndSession()
        {
            _userID = 0;
            _username = string.Empty;
            _fullName = string.Empty;
            _role = string.Empty;

            // Remove the global session reference so no other form can use it
            CurrentSession = null;
        }
    }
}