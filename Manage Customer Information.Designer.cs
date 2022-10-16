namespace ProjectBontodev1
{
    partial class Manage_Customer_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labCustomer_id = new System.Windows.Forms.Label();
            this.labFName = new System.Windows.Forms.Label();
            this.labLname = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(647, 242);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(97, 25);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "เพิ่ม";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSearch.Location = new System.Drawing.Point(12, 22);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(423, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(750, 242);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(846, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labCustomer_id
            // 
            this.labCustomer_id.AutoSize = true;
            this.labCustomer_id.Location = new System.Drawing.Point(643, 53);
            this.labCustomer_id.Name = "labCustomer_id";
            this.labCustomer_id.Size = new System.Drawing.Size(74, 13);
            this.labCustomer_id.TabIndex = 7;
            this.labCustomer_id.Text = "Customer_id : ";
            // 
            // labFName
            // 
            this.labFName.AutoSize = true;
            this.labFName.Location = new System.Drawing.Point(651, 78);
            this.labFName.Name = "labFName";
            this.labFName.Size = new System.Drawing.Size(66, 13);
            this.labFName.TabIndex = 8;
            this.labFName.Text = "First Name : ";
            // 
            // labLname
            // 
            this.labLname.AutoSize = true;
            this.labLname.Location = new System.Drawing.Point(650, 104);
            this.labLname.Name = "labLname";
            this.labLname.Size = new System.Drawing.Size(67, 13);
            this.labLname.TabIndex = 9;
            this.labLname.Text = "Last Name : ";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(663, 130);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(54, 13);
            this.labAddress.TabIndex = 10;
            this.labAddress.Text = "Address : ";
            // 
            // labTel
            // 
            this.labTel.AutoSize = true;
            this.labTel.Location = new System.Drawing.Point(686, 204);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(31, 13);
            this.labTel.TabIndex = 11;
            this.labTel.Text = "Tel : ";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(676, 177);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 13);
            this.labEmail.TabIndex = 12;
            this.labEmail.Text = "Email : ";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(723, 50);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(171, 20);
            this.txtCustomerID.TabIndex = 13;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(723, 75);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(171, 20);
            this.txtFName.TabIndex = 14;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(723, 101);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(171, 20);
            this.txtLName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(723, 127);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 41);
            this.txtAddress.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(723, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(723, 200);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(171, 20);
            this.txtTel.TabIndex = 18;
            // 
            // Manage_Customer_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 289);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labTel);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labLname);
            this.Controls.Add(this.labFName);
            this.Controls.Add(this.labCustomer_id);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Manage_Customer_Information";
            this.Text = "Manage_Customer_Information";
            this.Load += new System.EventHandler(this.Manage_Customer_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labCustomer_id;
        private System.Windows.Forms.Label labFName;
        private System.Windows.Forms.Label labLname;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
    }
}