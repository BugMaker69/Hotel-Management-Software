using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Hotel_System.User_Control
{
    public partial class UserControlBooking : UserControl
    {
        public UserControlBooking()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection();
        public void clear()
        {
            txtUser.Clear();
            txtName.Clear();
            txtUser.Clear();
            txtAddress.Clear();
            txtCity.Clear();

            tabControl1.SelectedTab = tabReserv;
        }
        private void tabView_Enter(object sender, EventArgs e)
        {
            Search.Clear();
        }
        private void tabView_Leave(object sender, EventArgs e)
        {
            Search.Clear();
        }

        private void DGVcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //code for disply from database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //here is the code for submit after connect the database :)
        }

        private void DGVcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = DGVcust.Rows[e.RowIndex];
                txtUser.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                comRoom.Text = row.Cells[2].Value.ToString();
                dateIn.Text = row.Cells[3].Value.ToString();
                dateOut.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            //disply from database
        }

        private void tabReserv_Leave(object sender, EventArgs e)
        {
            clear();
        }
    }
}
