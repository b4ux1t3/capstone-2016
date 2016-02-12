using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace capstone
{
    class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string password;
        private string userName;

        //static void Main(string[] args)
        //{
        //    DBConnector x = new DBConnector();
        //    x.Initialize();

        //    if (x.OpenConnection())
        //    {
        //        Console.WriteLine("Yay, it worked!\nPress any key to finish test.");
        //        Console.Read();
        //        x.CloseConnection();
        //    }
        //    Console.WriteLine("Reached end of main, press any key to exit program.");
        //    Console.Read();
        //}

        private void Initialize()
        {
            Console.WriteLine("Entered Initialize");
            server = "192.168.1.4";
            database = "capstone";
            password = "this password is very long and complicated and pretty easy to remember";
            userName = "application";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + userName + ";" + "PASSWORD=" + password + ";";

            try
            {
                connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Exiting Initialize");
        }

        private bool OpenConnection()
        {
            try
            {
                Console.WriteLine("Trying to open connection.");
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect. That sucks.\nError Unknown: Ask Chris what went wrong.");
                        break;

                    case 1045:
                        Console.WriteLine("Cannot connect. That sucks.\nError 1045: Ask Chris what went wrong.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #region DB Objects   
        /// <summary>
        /// These classes will be C# representations of the MySQL data structures. They are meant to make it easy to insert and delete entries in each of the tables within the database.
        /// 
        /// The first class is just a superclass to make sure that all of the subsequent classes are of the same type.
        /// 
        /// The Personclass is to group Patients and Staff together for the purpose of security and ease.
        /// </summary>
        /// 
        private class DBObject
        {
            internal string id = "NULL";
            internal string dateEntered;
        }

        private class Person : DBObject
        {
            internal string firstName;
            internal string LastName;
            internal string phone;
        }

        private class Patient : Person
        {
            internal enum gender
            {
                Male,
                Female
            }
        }

        private class Staff : Person
        {
            internal string admin;
        }

        private class Appointment : DBObject
        {
            internal string appointmentDate;
            internal string patientID;
            internal string staffID;
            internal string treatmentID;           
        }

        private class Treatment : DBObject
        {
            internal string treatmentTitle;
            internal string treatmentDescription;
        }
        #endregion
    }
}
