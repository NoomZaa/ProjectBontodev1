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

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strSQL = "select * from tb_CutomerLogin where Username = '" + txtUser.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
                da = new SqlDataAdapter(strSQL, conObj);
                DataTable dt = new DataTable();
                da.Fill(dt);





                if (dt.Rows.Count > 0)
                {
                    string status = "select status from tb_CutomerLogin where Username = '" + txtUser.Text.Trim() + "'";
                    SqlDataAdapter dastatus = new SqlDataAdapter(status, conObj);
                    DataTable dtstatus = new DataTable();
                    dastatus.Fill(dtstatus);

                    string statusUser = dtstatus.Rows[0]["status"].ToString();

                    if (statusUser == "admin")
                    {
                        main showmain = new main();
                        this.Hide();
                        showmain.Show();
                    }
                    else if (statusUser == "user")
                    {
                        MainUser showmainuser = new MainUser();
                        this.Hide();
                        showmainuser.Show();

                    }
                }
                else if (txtUser.Text == "")
                {
                    MessageBox.Show("Enter The Username", "Login");
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter The Password", "Login");
                    txtPassword.Focus();
                }
                else
                {
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                    MessageBox.Show("กรุณาตรวจสอบ User และ Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            string strSQL = "select * from tb_CutomerLogin where Username = '" + txtUser.Text.Trim() + "' and Password = '"+txtPassword.Text.Trim()+"'";
            da = new SqlDataAdapter(strSQL, conObj);
            DataTable dt = new DataTable();
            da.Fill(dt);

            



            if (dt.Rows.Count > 0)
            {
                string status = "select status from tb_CutomerLogin where Username = '" + txtUser.Text.Trim() + "'";
                SqlDataAdapter dastatus = new SqlDataAdapter(status, conObj);
                DataTable dtstatus = new DataTable();
                dastatus.Fill(dtstatus);

                string statusUser = dtstatus.Rows[0]["status"].ToString();

                if (statusUser == "admin")
                {
                    main showmain = new main();
                    this.Hide();
                    showmain.Show();
                }
                else if(statusUser == "user")
                {
                    MainUser showmainuser = new MainUser();
                    this.Hide();
                    showmainuser.Show();
                   
                }
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Enter The Username", "Login");
                txtPassword.Text = "";
                txtUser.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter The Password", "Login");
                txtPassword.Focus();
            }
            else
            {
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                MessageBox.Show("กรุณาตรวจสอบ User และ Password", "Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }



    }
}
