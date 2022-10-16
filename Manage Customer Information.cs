using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectBontodev1
{
    public partial class Manage_Customer_Information : Form
    {
        SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Manage_Customer_Information()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            condb.Open();
            dt = new DataTable();
            sda = new SqlDataAdapter(@"select * from tb_Customers", condb);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();
        }

        private void ClearData()
        {
            txtCustomerID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
        }

        private void Manage_Customer_Information_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string Customer_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string FName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string LName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Address = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Tel = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtCustomerID.Text = Customer_id;
            txtFName.Text = FName;
            txtLName.Text = LName;
            txtAddress.Text = Address;
            txtEmail.Text = Email;
            txtTel.Text = Tel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //scb = new SqlCommandBuilder(sda);
            //sda.Update(dt);

            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("กรุณาใส่ User ID", "คำเตือน", MessageBoxButtons.OK);
            }
            else if (txtFName.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Fist Name ", "คำเตือน", MessageBoxButtons.OK);
            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Last Name", "คำเตือน", MessageBoxButtons.OK);
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Address", "คำเตือน", MessageBoxButtons.OK);
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Tel", "คำเตือน", MessageBoxButtons.OK);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Email", "คำเตือน", MessageBoxButtons.OK);
            }
            else
            {
                condb.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_Customers(Customer_id,FName,LName,Address,Email,Tel) values (@Customer_id,@FName,@LName,@Address,@Email,@Tel)", condb);
                cmd.Parameters.AddWithValue("@Customer_id", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmd.ExecuteNonQuery();
                condb.Close();
                MessageBox.Show("Record Inserted Successfully", "MessageBox");
                DisplayData();
                ClearData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from tb_Customers where (FName like '%" + txtSearch.Text.Trim() + "%' or LName like '%" + txtSearch.Text.Trim() + "%' or Customer_id like '%" + txtSearch.Text.Trim() + "%' or Email like '%" + txtSearch.Text.Trim() + "%' or Tel like '%" + txtSearch.Text.Trim() + "%' )  ", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "" && txtFName.Text != "" && txtLName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtTel.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update tb_Customers set Customer_id=@Customer_id,FName=@FName, LName=@LName, Address=@Address , Email=@Email , Tel=@Tel  where Customer_id=@Customer_id", condb);
                condb.Open();
                cmd.Parameters.AddWithValue("@Customer_id", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                cmd.Parameters.AddWithValue("@LName", txtLName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                condb.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("delete tb_Customers where Customer_id=@Customer_id", condb);
                condb.Open();
                cmd.Parameters.AddWithValue("@Customer_id", txtCustomerID.Text);
                cmd.ExecuteNonQuery();
                condb.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please DoubleClick Select Record to Delete");
            }
        }
    }
}
