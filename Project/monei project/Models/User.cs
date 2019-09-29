using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class User
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _forename;

        public string Forename
        {
            get { return _forename; }
            set { _forename = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private int _securityQuestion;

        public int SecurityQuestion
        {
            get { return _securityQuestion; }
            set { _securityQuestion = value; }
        }

        private string _answerToSecurityQuestion;

        public string AnswerToSecurityQuestion
        {
            get { return _answerToSecurityQuestion; }
            set { _answerToSecurityQuestion = value; }
        }

        public User()
        {

        }
        public User(string username, string forename, string lastName, string password, int securityQuestion, string answerToSecurityQuestion)
        {
            Username = username;
            Forename = forename;
            LastName = lastName;
            Password = password;
            SecurityQuestion = securityQuestion;
            AnswerToSecurityQuestion = answerToSecurityQuestion;
        }

        public User(int id, string username, string forename, string lastName, string password, int securityQuestion, string answerToSecurityQuestion)
        {
            Id = id;
            Username = username;
            Forename = forename;
            LastName = lastName;
            Password = password;
            SecurityQuestion = securityQuestion;
            AnswerToSecurityQuestion = answerToSecurityQuestion;
        }
    }
}
