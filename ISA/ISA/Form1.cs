    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Dogbytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Creates a new connection for SQlite.
        SQLiteConnection Conn = new SQLiteConnection();
        //Allows commands to be transfered to the SQlite Database.
        SQLiteCommand Comm;
        //Sets the connection variable as a a string that will be used as the connection in the other forms.
        string Connstring ;
        

        //This will be used for selecting a database for the status bar and also the 'Find Database' button.
        private void tsbSelData_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your DB File";
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database Files (*.db)|*.db";
            openFileDialog1.FileName = "";

            //When a database is selected the 'Test Database; button and the status menu item 'Test Connection' will be enabled.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                Connstring = @"Data Source =" + openFileDialog1.FileName;
                tsbTest.Enabled = true;
                tsmTestConn.Enabled = true;
                tsslStatus.Text = "Set to " + openFileDialog1.FileName;
            }
            
                else
                {
                tsbTest.Enabled = false;
                tsmTestConn.Enabled = false;
                }
        }
        //Replicates the tool strip button 'Find Database' event for the tool strip item 'Select Database'.
        private void tsmSelData_Click(object sender, EventArgs e)
        {
            tsbSelData_Click(sender, e);
        }
        //Exits out of the Program with a message box to make sure that the user wants to exit out of the program.
        private void tsbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)

               {
                Application.Exit();
               }
          
        }
        //Replicates the tool strip button 'Exit' event for the tool strip item 'Close'.
        private void tsmClose_Click(object sender, EventArgs e)
        {
            tsbExit_Click(sender, e);
        }
        //Tests out the database which would open the connection and allow the database to be used in the other forms for viewing or editing. 
        private void tsbTest_Click(object sender, EventArgs e)
        {
            //Creates a delay while testing the database
            timer1.Interval = 2000;
            timer1.Start();
            tsslStatus.Text = "Testing Database";
            Conn.ConnectionString = Connstring;//This variable will be used in the other forms as a connection to the database.
            Comm = Conn.CreateCommand();
            Conn.Open();
            tsbTest.Enabled = false;
            tsmTestConn.Enabled = false;

        }
        //Replicates the tool strip button 'Test Database' for the tool strip item 'Test Connection'.
        private void tsmTestConn_Click(object sender, EventArgs e)
        {
            tsbTest_Click(sender, e);
        }
        //After the delay the tool strip status label will show the file name of the database and also show a image of a green light to signify that the database is connected with the program.
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslStatus.Text = "Using " + openFileDialog1.SafeFileName;
            tsslStatus.Image = Properties.Resources.grn;

        }
        //Goes to the form where the user can view all accounts and it is used for running the overnight calculations.
        private void tsmOverChange_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(Connstring);
            form3.ShowDialog();
        }


        //Goes to the form where the user can view the customer details. 
        private void tsmCustView_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Connstring);
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Displayes the current time and date.
            tsslDate.Text = DateTime.Now.ToString();
        }
        //Displays a data grid view of the customers form.
        private void tsmGrid_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(Connstring);
            form4.ShowDialog();
        }
        //Goes to the form where the user can view all of the accounts and can run the end of taxes updates.
        private void tssmChangeEOY_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(Connstring);
            form5.ShowDialog();
        }
    }
}

