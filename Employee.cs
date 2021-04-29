using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalendarProject
{
    class Employee
    {
        int userID = 0;
        int managerID = -1;

        public Employee (int num)//password
        {

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM teammmlemployee WHERE password=@myPASS";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@myPASS", num);
                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    userID = (int) myReader["userID"];
                    managerID = (int)myReader["managerID"];
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine(num);
            Console.WriteLine("Done.");
            //id = num;
            if (userID <= 0)
            {
                userID = 0;
            }
            Console.WriteLine(userID);
            Console.WriteLine(managerID);
           
        }

        ~Employee()
        {
            Console.WriteLine("id = " + userID + " has been destroyed");
            Console.WriteLine("id = " + managerID + " has been destroyed");
        }


        public int getID()
        {
            return userID;
        }

        public int getManagerID()
        {
            return managerID;
        }
       
    }
}
