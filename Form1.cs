using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\h p\source\repos\project\project\Database1.mdf"";Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into EmployeeTb1 values('" + EmpIdTb.Text + "','" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpDob.Value.Date + "','" + EmpPhoneTb.Text + "','" + EmpEduCb.SelectedItem.ToString() + "','" + EmpGenCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select* from EmployeeTb1";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter The  Employee  Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = " delete from EmployeeTb1 where Empid ='" + EmpIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully ");

                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {

                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    String query = " Update EmployeeTb1 set Empname ='" + EmpNameTb.Text + "',empadd='" + EmpAddTb.Text + "',emppos='" + EmpPosCb.SelectedItem.ToString() + "',empdop='" + EmpDob.Value.Date + "',empphone='" + EmpPhoneTb.Text + "',empedu='" + EmpEduCb.SelectedItem.ToString() + "',empgen='" + EmpGenCb.SelectedItem.ToString() + "' where Empid ='" + EmpIdTb.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully ");
                    con.Close();
                    populate();

                }
                catch (Exception Ex)
                {

                }
            }
        }
    }
}
