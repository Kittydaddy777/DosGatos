using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace StopwatchPlus
{
    public class DataAccess
    {
        Logger logger = new Logger();
        //Get the person info based on the password
        public List<Person> GetPerson(string password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Luna")))
            {
                var output = connection.Query<Person>($"select first_name as FirstName, last_name as LastName, stop_time as StopTime," +
                                                      $"run_date as RunDate, password as Password from stopwatch where password = '{password}'").ToList();
                return output;
            }
        }

        //Enters new info to database
        internal void InsertPerson(string firstName, string lastName, string password, string time, string date)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Luna")))
            {
                try
                {
                    connection.Execute($"insert into stopwatch values ('{firstName}','{lastName}','{time}','{date}','{password}');");
                   
                    logger.Log(firstName, lastName, date);   //Any new person added will be logged
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Password may already be in use");               //Try/Catch is to look out for duplicate passwords                    
                }
            }  
        }

        //Updates time and date based on the password
        internal void LatestTimeInsert(string time, string date, string password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Luna")))
            {
                try
                {
                    connection.Execute($"update stopwatch set stop_time = '{time}', run_date = '{date}' where password = '{password}';");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Was stopwatch ran?");   //Try/Catch is to look out for no time ran
                    
                }               
            }
        }
    }
}
