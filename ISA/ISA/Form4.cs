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
    public partial class Form4 : Form
    {

        public Form4(string inString)
        {
            InitializeComponent();
            //sets the variable for the database connection in this form.
            Connstring = inString;
            //loads up the columns in the Account ID datatable.
            columns(dtAccounts);
        }

        //Creates a new connection for SQlite.
        SQLiteConnection Conn = new SQLiteConnection();
        //Allows commands to be transfered to the SQlite Database.
        SQLiteDataAdapter daCustomerID; //For the customer ID combobox.
        SQLiteDataAdapter daAccounts; //For the Data grid view .
        
        //Used for altering the database or showing certain details in the form.
        DataTable dtCustomerID = new DataTable(); //For the Customer ID combobox.
        DataTable dtAccounts = new DataTable(); //For the data grid view.

        string Connstring;

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                //sets a connection with the sqlite database which was set when the database was tested in the Main Menu..
                using (Conn = new SQLiteConnection(Connstring))
                {
                    string Accounts = "Select * from account;"; //SQL code for selecting all accounts.
                    string ID = "Select custid, lastname || ' ' || firstname AS name from customer"; //SQL code for displaying the first name and last name in the customer ID combobox.


                    Conn.ConnectionString = Connstring;

                    //Sets a connection between the SQL code and the Database for the Customer ID combobox.
                    daCustomerID = new SQLiteDataAdapter(ID, Conn);
                    //Fills the Customer ID datatable.
                    daCustomerID.Fill(dtCustomerID);

                    //Fills up the combobox from the Datatable.
                    cbAccount.DataSource = dtCustomerID;
                    cbAccount.DisplayMember = "name";
                    cbAccount.ValueMember = "custid";
                    cbAccount.SelectedIndex = -1;

                    //Fills up the data grid view with the accounts datatable.
                    dataGridView1.DataSource = dtAccounts;
                    //Sets a connection between the SQL code and the Database for the Account ID combobox.
                    daAccounts = new SQLiteDataAdapter(Accounts, Conn);
                    //Fills up the Account ID datatable.
                    daAccounts.Fill(dtAccounts);

                }
            }
            //Shows a exception in a messagebox for the user.
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        //Used to set the names of each column.
        private void columns(DataTable myTbl)
        {
            dtAccounts.Columns.Add(new DataColumn("custid"));
            dtAccounts.Columns.Add(new DataColumn("accid"));
        }

        //Filters the data grid view which depends on what the value of the Customer ID is.
        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the filter variable for the Customer ID datatable.
            DataView dv = dtAccounts.DefaultView;
            try
            {
                //Uses the combobox's value for the sql code which will filter any records that does not have the Combobox's value.
                dv.RowFilter = string.Format("custid LIKE '%{0}%'", cbAccount.SelectedValue.ToString());
                //Fills up the data grid view depending on the value of the Customer ID combobox.
                dataGridView1.DataSource = dv;
            }
            catch
            {
                dataGridView1.DataSource = dtAccounts;
            }
        }
        //Closes the form.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
