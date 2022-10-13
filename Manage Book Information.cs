using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBontodev1
{
    public partial class Manage_Book_Information : Form
    {
        SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Manage_Book_Information()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            condb.Open();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(@"select * from tb_Books", condb);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();
        }

        private void ClearData()
        {
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void Manage_Book_Information_Load(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter(@"select * from tb_Books", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            condb.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter("select * from tb_Books where (ISBN like '%" + txtSearch.Text.Trim() + "%' or Title like '%" + txtSearch.Text.Trim() + "%' or Price like '%" + txtSearch.Text.Trim() + "%' or Description like '%" + txtSearch.Text.Trim() + "%')  ", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Description = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtISBN.Text = isbn;
            txtTitle.Text = title;
            txtPrice.Text = price;
            txtDescription.Text = Description;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtISBN.Text == "" )
            {
                MessageBox.Show("กรุณาใส่หมายเลขหนังสือ", "คำเตือน",MessageBoxButtons.OK);
            }
            else if(txtTitle.Text == "")
            {
                MessageBox.Show("กรุณาใส่ Title หนังสือ", "คำเตือน", MessageBoxButtons.OK);
            }
            else if(txtPrice.Text == "")
            {
                MessageBox.Show("กรุณาใส่ราคาหนังสือ", "คำเตือน", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into tb_Books(ISBN,Title,Description,Price) values (@ISBN,@Title,@Description,@Price)", condb);
                condb.Open();
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                condb.Close();
                MessageBox.Show("Record Inserted Successfully", "MessageBox");
                DisplayData();
                ClearData();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "")
            {
                SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete tb_Books where ISBN=@ISBN", condb);
                condb.Open();
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.ExecuteNonQuery();
                condb.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" && txtTitle.Text != "" && txtPrice.Text != "" && txtDescription.Text != "")
            {
                SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update tb_Books set ISBN=@ISBN,Title=@Title, Description=@Description, Price=@Price  where ISBN=@ISBN", condb);
                condb.Open();
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
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
    }
}
