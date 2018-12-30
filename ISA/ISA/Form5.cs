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
    public partial class Form5 : Form
    {
        public Form5(string instring)
        {
            InitializeComponent();
            //sets the variable for the database connection in this form.
            Connstring = instring;
        }
        string Connstring;


        //Creates a new connection for SQlite.
        SQLiteConnection Conn = new SQLiteConnection();

        //Creates communication between all datatables and databases.
        SQLiteDataAdapter daAccounts; //For the Account ID combobox.
        SQLiteDataAdapter daYear;

        //Used for altering the database or showing certain details in the form.
        DataTable dtAccounts = new DataTable(); //For the Account ID combobox.
        DataTable dtYear = new DataTable();



        private void Form9_Load(object sender, EventArgs e)
        {
            //sets a connection with the sqlite database which was set when the database was tested in the Main Menu.
            using (Conn = new SQLiteConnection(Connstring))
                {
                    //Sets the connection string to the SqliteConnection
                    Conn.ConnectionString = Connstring;
                    //SQL code for selecting all accounts.
                    string Accounts = "Select * from account";

                    //SQL code for showing all details linked with the end of year calculation.
                    string EndOfYear = "Select accid, accrued, allowance , round((balance-accrued),3) as new , balance  from account as a left join customer as c on a.custid = c.custid group by a.accid";

                    //Sets a connection between the SQL code and the Database for the Account ID combobox.
                    daAccounts = new SQLiteDataAdapter(Accounts, Conn);
                    //Fills up the Accounts ID datatable.
                    daAccounts.Fill(dtAccounts);

                    //Fills up the combobox from the Datatable.
                    cbAccID.DataSource = dtAccounts;
                    cbAccID.DisplayMember = "Account ID";
                    cbAccID.ValueMember = "accid";
                    cbAccID.SelectedIndex = -1;
                    

                    daYear = new SQLiteDataAdapter(EndOfYear, Conn);
                    daYear.Fill(dtYear);


                }

        }
        //Filters the data table which depends on what the value of the Account ID value is.
        private void cbAccID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the filter variable for the accounts datatable.
            DataView dv = dtYear.DefaultView;
            try
            {

                //Uses the combobox's value for the sql code which will filter any records that do not have the Combobox's value.
                dv.RowFilter = string.Format("accid = " + cbAccID.SelectedValue.ToString());
               
                //Shows the Account details depending on the what the selected value of the combobox is.
                lblAccID.Text = "Account ID :" + dv[0]["accid"].ToString();
                lblAccrued.Text = "Annual Rate :" + dv[0]["accrued"].ToString() + "%";
                lblDep.Text = "Deposit :" + dv[0]["allowance"].ToString();
                lblCurrBal.Text = "Current Balance: £" + dv[0]["balance"].ToString();
                lblNewBal.Text = "New Balance: £" + dv[0]["new"].ToString();
            }
            //Avoids the program from throwing a exception everytime the form is loaded.
            catch
            {

            }

        }
        //Changes values in the database involved in the End of Year Calculation.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //sets a connection with the sqlite database which was set when the database was tested in the Main Menu.
                using (Conn = new SQLiteConnection(Connstring))
                {
                    //Opens the connection for the database to be edited.
                    Conn.Open();
                    using (SQLiteCommand cmdSubmit = Conn.CreateCommand())
                    {
                        //Runs the sql code which updates details according to the End of Year calculation.
                        cmdSubmit.CommandText = @"update account set balance = round((balance-accrued),3), accrued = 0;
                        update customer set allowance = 0";
                        //Executes the sql code and makes changes to the database based on the SQL code.
                        cmdSubmit.ExecuteNonQuery();
                        //Closes the connection to stop any other changes from happening.
                        Conn.Close();
                        //A messagebox will appear which would notify that the database has been updated .
                        MessageBox.Show("Records have been updated.");
                        //Closes the form
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
              MessageBox.Show("Error: " + ex.Message);
            }
   

        }
        //Closes the Form.
        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        //Goes to the form where the user can view all accounts and it is used for running the overnight calculations.
        private void tssmChangeOver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form3 form3 = new Form3(Connstring);
            form3.ShowDialog();

        }
        //Goes to the form where the user can view the customer details.
        private void tsmCustView_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form2 form2 = new Form2(Connstring);
            form2.ShowDialog();
;       }
        //Displays a data grid view of the customers form.
        private void tsmGrid_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(Connstring);
            form4.ShowDialog();
        }
    }
}
