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
    public partial class Form3 : Form
    {
        public Form3(string instring)
        {
            InitializeComponent();
            //sets the variable for the database connection in this form.
            Connstring = instring;
            //loads up the columns in the Display datatable.
            columns(dtDisplay);
        }
        string Connstring;
        //Creates a new connection for SQlite.
        SQLiteConnection Conn;
        //Creates communication between all datatables and the databases.
        SQLiteDataAdapter daDisplay; //For Displaying the account details.
        SQLiteDataAdapter daAccID; //For the Account ID combobox.

        DataTable dtAccID = new DataTable();//For the Account ID combobox.
        DataTable dtDisplay = new DataTable(); //For Displaying the account details.

        //Used to set the names of each column.
        private void columns(DataTable myTbl)
        {
            dtDisplay.Columns.Add(new DataColumn("accid"));

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                //Sets a connection with the sqlite database which was set when the database was tested in the Main menu.
                using (Conn = new SQLiteConnection(Connstring))
                {
                    //Sets the connection string to the SqliteConnection
                    Conn.ConnectionString = Connstring;
                    //SQl Code for the Overnight Calculation.
                    string Command = @"select accid, round(accrued,3) as accrued, ROUND(accrued +(balance*intrate/365.0),3) AS overnight from account left join product on account.prodid = product.prodid";
                    //SQL code for account details.
                    string Accounts = @"Select * from account;";

                    //Sets a connection between the SQL code and the Database for the Account ID combobox.
                    daAccID = new SQLiteDataAdapter(Accounts, Conn);
                    //Fills the accounts datatable.
                    daAccID.Fill(dtAccID);

                    //Fills up the combobox's from the Datatable .
                    cbAccID.DataSource = dtAccID;
                    cbAccID.DisplayMember = "Account ID";
                    cbAccID.ValueMember = "accid";
                    cbAccID.SelectedIndex = -1;

                    //Sets a connection between the SQL code and the Database for the Display datatable.
                    daDisplay = new SQLiteDataAdapter(Command, Conn);
                    daDisplay.Fill(dtDisplay);
                    //Sets the label to show the current date and time.
                    tsslTime.Text = DateTime.Now.ToString();


                }

            }
            //Shows a exception in a messagebox for the user.
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Filters the Display datatable depending on the value of the Account ID combobox.
        private void cbAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the filter variable for the accounts datatable.
            DataView dv = dtDisplay.DefaultView;
            try
            {
                //Uses the combobox's value for the sql code which will filter any records that does not have the Combobox's value.
                dv.RowFilter = string.Format("accid = " + cbAccID.SelectedValue.ToString());
                //Shows the Account details depending on the Account ID combobox value.
                lblAccID.Text = "Account ID :" + dv[0]["accid"].ToString();
                lblCurrent.Text = "Current Accrued Rate :" + dv[0]["accrued"].ToString() + "%";
                lblNew.Text = "New Accrued Rate :" + dv[0]["overnight"].ToString() + "%";

            }
            catch
            {


            }
        }
        //Changes values in the database involved in the Overnight Calculation.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conn = new SQLiteConnection(Connstring))
                {
                    //Opens the connection to the database.
                    Conn.Open();

                    using (SQLiteCommand cmdSubmit = Conn.CreateCommand())
                    {
                        //Runs the sql code which updates details according to the overnight calculation.
                        cmdSubmit.CommandText = @"update account set accrued = (select ROUND(accrued +(balance*p.intrate/365.0),3) from product as p)";

                        //Executes the command and makes the changes to the database.
                        cmdSubmit.ExecuteNonQuery();

                        //After the command has been executed a messagebox will appear to notify that the database has been updated and the form will close.
                        MessageBox.Show("Accrued value has been updated");
                        Conn.Close();
                        this.Close();
                    }
                }
            }

            catch(Exception ex)

            {
                MessageBox.Show("Error: " + ex.Message);
            }
  
        }
        //Goes to the form where the user can view the customer details .
        private void tsmCustView_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form2 form2 = new Form2(Connstring);
            form2.ShowDialog();
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
            this.Close();
            this.Dispose();
            Form5 form5 = new Form5(Connstring);
            form5.ShowDialog();
        }

        //Closes the form.
        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
