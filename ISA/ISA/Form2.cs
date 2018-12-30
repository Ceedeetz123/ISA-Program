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
    public partial class Form2 : Form
    {
        public Form2(string inString)
        {
            InitializeComponent();
            //sets the variable for the database connection in this form.
            Connstring = inString;
            //loads up the columns in the Account ID datatable.
            columns(dtAccounts);
        }

        //Creates a new connection for SQlite.
        SQLiteConnection Conn = new SQLiteConnection();

        //Creates communication between all datatables and databases.
        SQLiteDataAdapter daCustomerID; //For the customer ID combobox.
        SQLiteDataAdapter daAccounts; //For the Account ID combobox.
        SQLiteDataAdapter daDisplay; //For displaying the customers details.

        //Used for altering the database or showing certain details in the form.
        DataTable dtCustomerID = new DataTable(); //For the customer ID Combobox.
        DataTable dtAccounts = new DataTable(); //For the Account ID combobox.
        DataTable dtDisplay = new DataTable(); //For displaying the customers details.
    
        string Connstring;

        //Closes the accounts form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Sets a connection with the sqlite database which was set when the database was tested in the main menu.
                using (Conn= new SQLiteConnection(Connstring))
                {

                    //Selects the customers first name and last name concatenated from the customer table.
                    string ID = @"Select custid, lastname || ' ' || firstname AS name from customer"; //For the customer ID Combobox


                    //SQL code that shows details from the account table.
                    string Accounts = @"Select * from account;";


                    //Sets a connection between the SQL code and the Database for the Customer ID combobox.
                    daCustomerID = new SQLiteDataAdapter(ID, Conn);
                    //Fills up the datatable from the data adapter .
                    daCustomerID.Fill(dtCustomerID);
                    //Fills up the combobox's from the Datatable.
                    cbCustomerID.DataSource = dtCustomerID;
                    cbCustomerID.DisplayMember = "name";
                    cbCustomerID.ValueMember = "custid";
                    cbCustomerID.SelectedIndex = -1;
      
                    cbAcc.DataSource = dtAccounts;
                    cbAcc.DisplayMember = "Account ID";
                    cbAcc.ValueMember = "accid";
                    cbAcc.SelectedIndex = -1;

                    //Sets a connection between the SQL code and the Database for the Account ID combobox.
                    daAccounts = new SQLiteDataAdapter(Accounts, Conn);
                    //Fills up the Accounts ID datatable.
                    daAccounts.Fill(dtAccounts);

                    //Sets a connection between the SQL code and the Database for the Display datatable.
                    daDisplay = new SQLiteDataAdapter(Accounts, Conn);
                    daDisplay.Fill(dtDisplay);
                    //Sets the label to show the current date and time.
                    tsslTimes.Text = DateTime.Now.ToString();
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
            dtAccounts.Columns.Add(new DataColumn("prodid"));
            dtAccounts.Columns.Add(new DataColumn("accrued"));
            dtAccounts.Columns.Add(new DataColumn("active"));
            dtAccounts.Columns.Add(new DataColumn("balance"));
        }



        //Filters the Account ID combobox which depends on what the value of the Customer ID is.
        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Sets the filter variable for the accounts ID datatable.
            DataView dv = dtAccounts.DefaultView;
            try
            { 
               //Uses the combobox's value for the sql code which will filter any records that does not have the Combobox's value.
                dv.RowFilter = string.Format("custid LIKE '%{0}%'", cbCustomerID.SelectedValue.ToString());
                //Shows the Account details depending on the Customer ID combobox value.
                lblAccID.Text = "Account ID :" + dv[0]["accid"].ToString(); 
                lblCustID.Text = "Customer ID :" + dv[0]["custid"].ToString();
                lblProdID.Text = "Product ID :" + dv[0]["prodid"].ToString();
                lblAccrued.Text = "Accrued :" + dv[0]["accrued"].ToString() + "%";
                lblBalance.Text = "Balance :" + dv[0]["balance"].ToString();
                lblActive.Text = "Active :" + dv[0]["active"].ToString();
            }
            //Avoids the program from throwing a exception everytime the form is loaded.
            catch
            {
 

            }

        }


        //Filters the display datatable depending on the value of the Account ID combobox.
        private void cbAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the filter variable for the display ID datatable.
            DataView dv = dtDisplay.DefaultView;
            try
            {
                //Uses the combobox's value for the sql code which will filter any records that does not have the Combobox's value.
                dv.RowFilter = string.Format("accid = " + cbAcc.SelectedValue.ToString());
                //Shows the Account details depending on the Account ID combobox value.
                lblAccID.Text = "Account ID :" + dv[0]["accid"].ToString();
                lblCustID.Text = "Customer ID :" + dv[0]["custid"].ToString();
                lblProdID.Text = "Product ID :" + dv[0]["prodid"].ToString();
                lblAccrued.Text = "Accrued :" + dv[0]["accrued"].ToString() +"%";
                lblBalance.Text = "Balance :" + dv[0]["balance"].ToString();
                lblActive.Text = "Active :" + dv[0]["active"].ToString();


            }
            catch
            {
               
            }
        }
        //Closes the form.
        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Goes to the form where the user can view all accounts and it is used for running the overnight calculations.
        private void tsmOverView_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form3 form3 = new Form3(Connstring);
            form3.ShowDialog();


        }
        //Goes to the form where the user can view all of the accounts and can run the end of taxes updates.
        private void tsmChange_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form5 form5 = new Form5(Connstring);
            form5.ShowDialog();
        }
        //Displays a data grid view of the customers form.
        private void tsmGrid_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(Connstring);
            form4.ShowDialog();
        }
    }
}






