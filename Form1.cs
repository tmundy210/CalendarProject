using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//tableLayoutpanel1 is the main menu with calendar 
//tableLayoutpanel2 is the pin menu

namespace CalendarProject
{
    public partial class Form1 : Form
    {
        Employee currentEmployee;

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel2.BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        
        private void deleteEventButton_Click(object sender, EventArgs e)
        {

        }

        private void viewEventButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            viewEventTableLayoutPanel.Visible = true;

            //Fill viewEventListBox
            viewEventListBox.Items.Clear();
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM teammmlevent WHERE userNum = @currEmp";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@currEmp", currentEmployee.getID());
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                MySqlDataReader myReader = cmd.ExecuteReader();
               
                while (myReader.Read())
                {
                    Boolean tempMan = true;
                    if ((int)myReader["managerEvent"] == 0)
                        tempMan = false;
                    var eTemp = new Event((int)myReader["eventNum"], (string)myReader["eventName"], (string)myReader["description"], (DateTime)myReader["startTime"], (DateTime)myReader["endTime"], tempMan);
                    viewEventListBox.Items.Add(eTemp.getEventName());
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

        private void addEventButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "1";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "1";
        }

        private void button2Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "2";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "2";
        }

        private void button3Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "3";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "3";
        }

        private void button4Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "4";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "4";
        }

        private void button5Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "5";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "5";
        }

        private void button6Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "6";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "6";
        }

        private void button7Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "7";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "7";
        }

        private void button8Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "8";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "8";
        }

        private void button9Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "9";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "9";
        }

        private void button0Pin_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Pin")
                label2.Text = "0";
            else if (label2.Text.Length <= 3)
                label2.Text = label2.Text + "0";
        }

        private void buttonDeletePin_Click(object sender, EventArgs e)
        {
            if (label2.Text.Length == 1)
                label2.Text = "Pin";
            else if (label2.Text.Length > 0)
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
        }

        private void buttonClearPin_Click(object sender, EventArgs e)
        {
            label2.Text = "Pin";
        }

        private void buttonProcessPin_Click(object sender, EventArgs e) //process button!!
        {
            // 0 means they are manager in managerID
            //-1 means they are not manager 
            int pin = 0;
            if (label2.Text.Equals("Pin"))
            {
                //label1.Text = "Please Input a Pin!";
            }
            else
                pin = int.Parse(label2.Text);

            currentEmployee = new Employee(pin);
            if (currentEmployee.getID() == 0) //password doesn't match any ID
            {
                //this is the code for when it goes wrong!!!!

                errorTableLayoutPanel.Visible = true;
                tableLayoutPanel2.Visible = false;
                errorLabel.Text = "You enter the wrong pin try again";

            }
            if (currentEmployee.getManagerID() == 0)//is a manager
            {
                
            }
            else
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = true;
            label2.Text = "Pin";

        }

        private void buttonCancelPin_Click(object sender, EventArgs e)
        {
            //not correct yet just to get to main menu
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = true; 
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            errorTableLayoutPanel.Visible = false;
            tableLayoutPanel2.Visible = true;
        }

        private void viewEventSubmitButton_Click(object sender, EventArgs e)
        {
            //submit only works if item is selected
            if(viewEventListBox.SelectedIndex >= 0)
            {
                viewEventTableLayoutPanel.Visible = false;
                viewEvent2TableLayoutPanel.Visible = true;
                String name = (string)viewEventListBox.SelectedItem;

                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    string sql = "SELECT * FROM teammmlevent where eventName=@name";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if(myReader.Read())
                    {
                        viewEventLabelName.Text = "Event name: "+name;
                        viewEventLabelDesc.Text = "Description: " + (string)myReader["description"];
                        viewEventLabelStart.Text = "Start time: " + myReader["startTime"].ToString();
                        viewEventLabelEnd.Text = "End time: " + myReader["endTime"].ToString();
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
        }

        private void viewEventBackButton_Click(object sender, EventArgs e)
        {
            viewEventTableLayoutPanel.Visible = false;
            tableLayoutPanel1.Visible = true;
        }

        private void viewAnotherEventButton_Click(object sender, EventArgs e)
        {
            viewEvent2TableLayoutPanel.Visible = false;
            viewEventTableLayoutPanel.Visible = true;
        }

        private void viewEventReturnMenuButton_Click(object sender, EventArgs e)
        {
            viewEvent2TableLayoutPanel.Visible = false;
            tableLayoutPanel1.Visible = true;
        }
    }
}
