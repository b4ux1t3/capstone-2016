using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace capstone
{
    class DBConnector
    {
        internal MySqlConnection connection;
        private string Server;
        private string Database;
        private string Password;
        private string UserName;

        // Just in case we need this for testing.
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

        public DBConnector(string server, string database, string username, string password)
        {
            this.Server = server;
            this.Database = database;
            this.UserName = username;
            this.Password = password;
        }

        private void Initialize()
        {
            Console.WriteLine("Entered Initialize");
            
            string connectionString = "SERVER=" + this.Server + ";" + "DATABASE=" +
        this.Database + ";" + "UID=" + this.UserName + ";" + "PASSWORD=" + this.Password + ";";

            try
            {
                Console.WriteLine(connectionString);
                connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Exiting Initialize");
        }
        
        #region Open/Close/Send
        private bool OpenConnection()
        {
            try
            {
                Initialize();
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
            } catch(NullReferenceException ex)
            {
                Console.WriteLine("Well, something borked");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                Initialize();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Well, something borked");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        private bool SendNonQuery(string nonQuery)
        {
            bool outcome;

            // Open connection returns a boolean, so we can instantly check if the connection was successful
            if (this.OpenConnection())
            {
                // Create command and assign the nonquery and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(nonQuery, connection);

                // Execute command, store result in success.
                // Since ExecuteNonQuery returns the number of rows affected, we can check if anything was change in the database by testing if success is greater than 0 
                int success = cmd.ExecuteNonQuery();

                if (success > 0)
                {
                    outcome = true;
                }
                else
                {
                    outcome = false;
                }
            }
            else // If the connection was not successful, we want to be sure we return false.
            {
                outcome = false;
            }

            // Close connection
            this.CloseConnection();


            return outcome;
        }
        
        internal DataTable SendQuery(string query)
        {
            DataTable result = new DataTable("Results");
            if (this.OpenConnection())
            { 
                // Create command and assign the query and connection from the constructor
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, connection);

                //Create a reader to get the data from the database
                cmd.Fill(result);

                Console.WriteLine(result.ToString());

                this.CloseConnection();
            }

            return result;
        }
        #endregion

        #region Database Query Methods
        /// <summary>
        /// Since inheritance doe snot work the way I expected it to, I need to create multiple methods for both Insertion and deletion.
        /// I don't think I will need aseparate one for selection. We'll see.
        /// Boy was I wrong. It looks like we're going to need a bunch of different selection methods.
        /// Note to self: Look up how to use DataTables
        /// </summary>
        /// <param name="entry">This is a DBObject object, to be created by the calling window.</param>
        /// <returns>Returns whether or not the query was successful</returns>
        
        #region Insert
        internal bool Insert(Patient entry)
        {
            
            // Create the query to send to the database
            string query = String.Format("INSERT INTO patients VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}', '{7}', '{8}');", entry.firstName, entry.lastName, entry.phone, entry.gender, entry.dateEntered, entry.id, entry.insurance, entry.birthdate, entry.address);

            Console.WriteLine(query);

            // SendNonQuery returns a boolean, so we can check if it was successful
            return SendNonQuery(query);
        }

        internal bool Insert(Staff entry)
        {
            // Create the query to send to the database
            string query = String.Format("INSERT INTO staff VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5});", entry.firstName, entry.lastName, entry.phone, entry.admin, entry.dateEntered, entry.id);

            Console.WriteLine(query);

            // SendNonQuery returns a boolean, so we can check if it was successful
            return SendNonQuery(query);
            
        }

        internal bool Insert(Appointment entry)
        {
            // Create the query to send to the database
            string query = String.Format("INSERT INTO appointment VALUES({0}, {1}, {2}, {3}, {4}, {5});", entry.appointmentDate, entry.patientID, entry.staffID, entry.treatmentID, entry.dateEntered, entry.id);

            Console.WriteLine(query);

            // SendNonQuery returns a boolean, so we can check if it was successful
            return SendNonQuery(query);
        }

        internal bool Insert(Treatment entry)
        {
            // Create the query to send to the database
            string query = string.Format("INSERT INTO treatments VALUES('{0}', '{1}', {2}, {3});", entry.treatmentTitle, entry.treatmentDescription,  entry.dateEntered, entry.id);

            Console.WriteLine(query);

            // SendNonQuery returns a boolean, so we can check if it was successful
            return SendNonQuery(query);
            
        }
        #endregion
        #region Delete
        /// <summary>
        /// Deletes an entry froma table.
        /// </summary>
        /// <param name="id">The ID for the entry that we want to delete</param>
        /// <param name="table">The table from which we would like to delete the entry</param>
        /// <param name="idField">The primary key for the table</param>
        /// <returns>Whether the deletion was successful</returns>
        internal bool Delete(string id, string table, string idField)
        {
            string query = string.Format("DELETE FROM {0} WHERE {1} = {2};", table, idField, id);

            Console.WriteLine(query);

            // SendNonQuery returns a boolean, so we can check if it was successful
            return SendNonQuery(query);
        }
        #endregion

        // This simply checks if the log in provided in the LogInWIndow is a valid entry
        //Todo: Make this return some way to tell if the user is an admin
        internal int CheckLogIn(string ID)
        {
            int result = 0;
            if (this.OpenConnection())
            {

                try
                {
                    string query = string.Format("SELECT COUNT(*) FROM staff WHERE staff_ID = {0};", ID);
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a reader to get the data from the database
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    result = Convert.ToInt32(reader["COUNT(*)"].ToString());
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return 0;
                }

                this.CloseConnection();
            }
            else
            {
                result = -1;
            }
            return result;
        }

        internal bool CheckAdminStatus(string ID)
        {
            if (this.OpenConnection())
            {

                try
                {
                    string query = string.Format("SELECT admin FROM staff WHERE staff_ID = {0};", ID);

                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a reader to get the data from the database
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int result = Convert.ToInt32(reader["admin"]);

                    if (result == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return false;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            return false;
        }
        #endregion

        /// <summary>
        /// This is specifically so I can get the number of rows returned from SQL queries
        /// </summary>
        internal class dataCount
        {
            internal string data;
            internal int count;

            internal dataCount(string data, int count)
            {
                this.data = data;
                this.count = count;
            }

            internal void changeData(string moreData)
            {
                this.data += moreData;
            }

            internal void incrementCount()
            {
                this.count++;
            }
        }
        #region DB Objects   
        /// <summary>
        /// These classes will be C# representations of the MySQL data structures. They are meant to make it easy to insert and delete entries in each of the tables within the database.
        /// 
        /// The first class is just a superclass to make sure that all of the subsequent classes are of the same type.
        /// 
        /// The Person class is to group Patients and Staff together for the purpose of security and ease.
        /// </summary>
        /// 
        internal class DBObject
        {
            internal string id = "NULL";
            internal string dateEntered = "NULL";
        }

        internal class Person : DBObject
        {
            internal string firstName;
            internal string lastName;
            internal string phone;

            public Person(string firstName, string lastName, string phone)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.phone = phone;
            }
        }

        internal class Patient : Person
        {
            internal string gender;
            internal string insurance;
            internal string birthdate;
            internal string address;

            public Patient(string gender, string firstName, string lastName, string phone, string insurance, string birthdate, string address) : base(firstName, lastName, phone)
            {
                this.gender = gender;
                this.insurance = insurance;
                this.birthdate = birthdate;
                this.address = address;
            }
        }

        internal class Staff : Person
        {
            internal string admin;

            public Staff(string admin, string firstName, string lastName, string phone) : base(firstName, lastName, phone)
            {
                this.admin = admin;
            }
        }

        internal class Appointment : DBObject
        {
            internal string appointmentDate;
            internal string patientID;
            internal string staffID;
            internal string treatmentID;
            
            public Appointment(string appointmentDate, string patientID, string staffID, string treatmentID)
            {
                this.appointmentDate = appointmentDate;
                this.patientID = patientID;
                this.staffID = staffID;
                this.treatmentID = treatmentID;
            }    
        }

        internal class Treatment : DBObject
        {
            internal string treatmentTitle;
            internal string treatmentDescription;

            public Treatment(string treatmentTitle, string treatmentDescription)
            {
                this.treatmentTitle = treatmentTitle;
                this.treatmentDescription = treatmentDescription;
            }
        }
        #endregion
    }
}
