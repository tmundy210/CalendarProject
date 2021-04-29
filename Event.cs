using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalendarProject
{
    class Event
    {
        int eventNum;
        string eventName;
        string description;
        DateTime startTime;
        DateTime endTime;
        Boolean managerEvent;

        public Event(int evNum, string evName, string desc, DateTime start, DateTime end, Boolean man)
        {
            eventNum = evNum;
            eventName = evName;
            description = desc;
            startTime = start;
            endTime = end;
            managerEvent = man;
        }

        public void saveEvent()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM teammmlevent;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    eventNum = (int)myReader["eventNum"];
                    eventName = (string)myReader["eventName"];
                    description = (string)myReader["description"];
                    startTime = (DateTime)myReader["startTime"];
                    endTime = (DateTime)myReader["endTime"];

                    //No boolean type in MySQL, so if the int is 0 store false, else store true.
                    int tempManager = (int)myReader["managerEvent"];
                    if (tempManager == 0)
                        managerEvent = false;
                    else
                        managerEvent = true;
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        ~Event()
        {
            Console.WriteLine("event #" + eventNum + " - " + eventName + " has been destroyed");

        }

        public String getEventName()
        {
            return eventName;
        }


    }
}
