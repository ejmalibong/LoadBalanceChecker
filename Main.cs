using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LoadBalanceChecker
{
    public partial class Main : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        public string query = string.Empty;
        private bool Resizing = false;

        public Main()
        {
            InitializeComponent();
            this.lsvItem.SizeChanged += new EventHandler(ListView_SizeChanged);
        }

        private void GetCurrentCutoff()
        {
            DateTime dateTime1 = dtStart.Value;
            int num1 = dateTime1.Day >= 6 ? 1 : 0;
            dateTime1 = this.dtStart.Value;
            int num2 = dateTime1.Day <= 20 ? 1 : 0;

            if ((num1 & num2) != 0)
            {
                DateTimePicker dtStart = this.dtStart;
                DateTime dateTime2 = this.dtStart.Value;
                int year1 = dateTime2.Year;
                dateTime2 = this.dtStart.Value;
                int month1 = dateTime2.Month;
                DateTime dateTime3 = new DateTime(year1, month1, 6);
                dtStart.Value = dateTime3;
                DateTimePicker dtEnd = this.dtEnd;
                DateTime dateTime4 = this.dtStart.Value;
                int year2 = dateTime4.Year;
                dateTime4 = this.dtStart.Value;
                int month2 = dateTime4.Month;
                DateTime dateTime5 = new DateTime(year2, month2, 20);
                dtEnd.Value = dateTime5;
            }
            else
            {
                DateTime dateTime6 = this.dtStart.Value;
                if (dateTime6.Day >= 21)
                {
                    dateTime6 = this.dtStart.Value;
                    if (dateTime6.Month == 12)
                    {
                        DateTimePicker dtStart = this.dtStart;
                        dateTime6 = this.dtStart.Value;
                        int year = dateTime6.Year;
                        dateTime6 = this.dtStart.Value;
                        int month = dateTime6.Month;
                        DateTime dateTime7 = new DateTime(year, month, 21);
                        dtStart.Value = dateTime7;
                        DateTimePicker dtEnd = this.dtEnd;
                        dateTime6 = this.dtStart.Value;
                        DateTime dateTime8 = new DateTime(dateTime6.Year, 1, 5);
                        dtEnd.Value = dateTime8;
                        return;
                    }
                    DateTimePicker dtStart_1 = this.dtStart;
                    dateTime6 = this.dtStart.Value;
                    int year3 = dateTime6.Year;
                    dateTime6 = this.dtStart.Value;
                    int month3 = dateTime6.Month;
                    DateTime dateTime9 = new DateTime(year3, month3, 21);
                    dtStart_1.Value = dateTime9;
                    DateTimePicker dtEnd_1 = this.dtEnd;
                    dateTime6 = this.dtStart.Value;
                    int year4 = dateTime6.Year;
                    dateTime6 = this.dtStart.Value;
                    int month4 = checked((int)Math.Round(unchecked((double)dateTime6.Month + Conversions.ToDouble("1"))));
                    DateTime dateTime10 = new DateTime(year4, month4, 5);
                    dtEnd_1.Value = dateTime10;
                }
                else
                {
                    dateTime6 = this.dtStart.Value;
                    if (dateTime6.Day <= 5)
                    {
                        dateTime6 = this.dtStart.Value;
                        if ((double)dateTime6.Month == Conversions.ToDouble("1"))
                        {
                            DateTimePicker dtStart = this.dtStart;
                            dateTime6 = this.dtStart.Value;
                            DateTime dateTime11 = new DateTime(checked((int)Math.Round(unchecked((double)dateTime6.Year - Conversions.ToDouble("1")))), 12, 21);
                            dtStart.Value = dateTime11;
                            DateTimePicker dtEnd = this.dtEnd;
                            dateTime6 = this.dtStart.Value;
                            DateTime dateTime12 = new DateTime(checked((int)Math.Round(unchecked((double)dateTime6.Year + Conversions.ToDouble("1")))), 1, 5);
                            dtEnd.Value = dateTime12;
                        }
                        else
                        {
                            DateTimePicker dtStart = this.dtStart;
                            dateTime6 = this.dtStart.Value;
                            int year5 = dateTime6.Year;
                            dateTime6 = this.dtStart.Value;
                            int month5 = checked((int)Math.Round(unchecked((double)dateTime6.Month - Conversions.ToDouble("1"))));
                            DateTime dateTime13 = new DateTime(year5, month5, 21);
                            dtStart.Value = dateTime13;
                            DateTimePicker dtEnd = this.dtEnd;
                            dateTime6 = this.dtStart.Value;
                            int year6 = dateTime6.Year;
                            dateTime6 = this.dtStart.Value;
                            int month6 = checked((int)Math.Round(unchecked((double)dateTime6.Month + Conversions.ToDouble("1"))));
                            DateTime dateTime14 = new DateTime(year6, month6, 5);
                            dtEnd.Value = dateTime14;
                        }
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //nbcp-lt-043 (ej)
                //con = new MySqlConnection("server=localhost;port=3306;database=nbc;uid=root;charset=utf8;");
                con = new MySqlConnection("server=192.168.23.64;port=3306;database=nbc;uid=root;charset=utf8;");
                this.con.Open();
            }
            catch(MySqlException ex)
            {
               MessageBox.Show(ex.Message);
            }

            GetCurrentCutoff();

            txtQrCodeInput.Focus();
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 163; // define doubleclick event
            const int WM_NCLBUTTONDOWN = 161; // define leftbuttondown event
            const int WM_SYSCOMMAND = 274; // define move action
            const int HTCAPTION = 2; // define that the WM_NCLBUTTONDOWN is at titlebar
            const int SC_MOVE = 61456; // trap move action
                                       // disable moving of titlebar
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
                return;
            // track whether clicked on title bar
            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
                return;
            // disable double click on title bar
            if ((m.Msg == WM_NCLBUTTONDBLCLK))
                return;

            base.WndProc(ref m);
        }

        private DateTime ServerDate()
        {
            DateTime curDate;

            this.cmd = new MySqlCommand("SELECT CURDATE();", this.con);
            curDate = Convert.ToDateTime(cmd.ExecuteScalar());

            return curDate;
        }


        private void Search()
        {
            if (dtStart.Value > dtEnd.Value)
            {
                MessageBox.Show("Start date is later than end date.");
                return;
            }

            this.lsvItem.Items.Clear();
            this.txtCurBalance.Text = "0.00";
            this.txtDeduction.Text = "0.00";
            this.txtUseLoad.Text = "0.00";
            this.txtPurchase.Text = "0.00";

            DateTime dateTime1 = Convert.ToDateTime(this.dtStart.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtEnd.Text);
            this.query = "SELECT * FROM transactions WHERE rfid_no='" + this.txtQrCodeInput.Text + "' and dttm BETWEEN '" + dateTime1.ToString("yyyy-MM-dd") + "' AND '" + dateTime2.ToString("yyyy-MM-dd") + "' and active='2' and product_name <> 'BREAKFAST' AND product_name <> 'LUNCH' order by dttm desc";

            try
            {
                this.cmd = new MySqlCommand(this.query, this.con);
                this.reader = this.cmd.ExecuteReader();
                while (this.reader.Read())
                {
                    ListViewItem listViewItem = this.lsvItem.Items.Add(this.reader["dttm"].ToString());
                    listViewItem.SubItems.Add(this.reader["member_name"].ToString());
                    listViewItem.SubItems.Add(this.reader["receipt"].ToString());
                    listViewItem.SubItems.Add(this.reader["product_name"].ToString());
                    listViewItem.SubItems.Add(this.reader["price"].ToString());
                    listViewItem.SubItems.Add(this.reader["qty"].ToString());
                    listViewItem.SubItems.Add(String.Format("{0:#,##0.00}", Convert.ToDecimal(this.reader["amount"].ToString())));

                    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.reader["isload"].ToString(), "0", false) == 0)
                    {
                        listViewItem.SubItems.Add("Salary Deduction");
                        this.txtDeduction.Text = Strings.Format((object)(Conversions.ToDouble(this.txtDeduction.Text) + Conversions.ToDouble(this.reader["amount"].ToString())), "###,##0.00");
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Load");
                        this.txtUseLoad.Text = Strings.Format((object)(Conversions.ToDouble(this.txtUseLoad.Text) + Conversions.ToDouble(this.reader["amount"].ToString())), "###,##0.00");
                    }

                    this.txtPurchase.Text = Strings.Format((object)(Conversions.ToDouble(this.txtPurchase.Text) + Conversions.ToDouble(this.reader["amount"].ToString())), "###,##0.00");
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Problem loading data: " + ex.Message.ToString()));
                ProjectData.ClearProjectError();
            }

            //show load balance
            this.reader.Close();
            this.query = "SELECT balance FROM members WHERE rfid_no='" + this.txtQrCodeInput.Text + "'";
            this.cmd = new MySqlCommand(this.query, this.con);
            this.reader = this.cmd.ExecuteReader();

            try
            {
                while (this.reader.Read())
                    this.txtCurBalance.Text = Strings.Format((object)Conversions.ToDouble(this.reader["balance"].ToString()), "###,##0.00");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }

            this.reader.Close();
            this.txtQrCodeInput.Text = "";
            this.txtQrCodeInput.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        } 

        private void txtQrCodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            //this.btnSearch.PerformClick();
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lsvItem.Items.Clear();
            this.txtCurBalance.Text = "0.00";
            this.txtDeduction.Text = "0.00";
            this.txtUseLoad.Text = "0.00";
            this.txtPurchase.Text = "0.00";
            this.txtQrCodeInput.Focus();
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDateRange.Checked)
            {
                this.dtStart.Enabled = true;
                this.dtEnd.Enabled = true;
            }
            else
            {
                GetCurrentCutoff();
                this.dtStart.Enabled = false;
                this.dtEnd.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
        {
            // Don't allow overlapping of SizeChanged calls
            if (!Resizing)
            {
                // Set the resizing flag
                Resizing = true;

                ListView listView = sender as ListView;
                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    // Get the sum of all column tags
                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    // Calculate the percentage of space each column should 
                    // occupy in reference to the other columns and then set the 
                    // width of the column to that percentage of the visible space.
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            // Clear the resizing flag
            Resizing = false;
        }
    }

}
