using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBontodev1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True";
        SqlConnection conObj = new SqlConnection();
        SqlDataAdapter da;
        //DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {

            if(conObj.State == ConnectionState.Open)
            {
                conObj.Close();
            }
            else
            {
                conObj.ConnectionString = strCon;
                conObj.Open();
            }


            //string strSQLShow = "select * from tb_CustomerID";
            //da = new SqlDataAdapter(strSQLShow, conObj);

            //ds.Tables.Clear();
            //da.Fill(ds, "MyQuery");
            //dataGridView1.DataSource = ds.Tables["MyQuery"];


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string strSQL = "select * from tb_CutomerLogin where Username = '" + txtUser.Text.Trim() + "' and Password = '"+txtPassword.Text.Trim()+"'";
            da = new SqlDataAdapter(strSQL, conObj);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            if(dtbl.Rows.Count > 0)
            {
                main showmain = new main();
                this.Hide();
                showmain.Show();
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Enter The Username", "Login");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter The Password", "Login");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }
            else
            {
                MessageBox.Show("กรุณาติดต่อผู้พัฒนาโปรแกรม", "Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            //string username, password;
            //username = txtUser.Text;
            //password = txtPassword.Text;

            //string strSQL = "select * from CustomerID where Username = '" + txtUser.Text + "' and '" + txtPassword.Text + "' ";
            //SqlDataAdapter qu = new SqlDataAdapter(strSQL,strCon);
            //DataTable dt = new DataTable();
            //qu.Fill(dt);

            //if(dt.Rows.Count>0)
            //{
            //    MessageBox.Show("เข้าสู่ระบบเรียบร้อย", "Login");
            //}
            //else
            //{
            //    MessageBox.Show("กรุณาตรวจสอบ User และ Password", "Login");
            //}
            
        }
    }
}
