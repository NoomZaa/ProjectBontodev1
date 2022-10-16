namespace ProjectBontodev1
{
    partial class Order_Book
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
            this.labSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labPriceSum = new System.Windows.Forms.Label();
            this.txtPriceSum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labPriceUnit = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(356, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(12, 21);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(41, 13);
            this.labSearch.TabIndex = 1;
            this.labSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Location = new System.Drawing.Point(76, 287);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(49, 13);
            this.labQuantity.TabIndex = 4;
            this.labQuantity.Text = "จำนวน : ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(131, 285);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // labPriceSum
            // 
            this.labPriceSum.AutoSize = true;
            this.labPriceSum.Location = new System.Drawing.Point(67, 316);
            this.labPriceSum.Name = "labPriceSum";
            this.labPriceSum.Size = new System.Drawing.Size(58, 13);
            this.labPriceSum.TabIndex = 6;
            this.labPriceSum.Text = "ราคารวม : ";
            // 
            // txtPriceSum
            // 
            this.txtPriceSum.Location = new System.Drawing.Point(131, 313);
            this.txtPriceSum.Name = "txtPriceSum";
            this.txtPriceSum.Size = new System.Drawing.Size(92, 20);
            this.txtPriceSum.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(273, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "สั่งซื้อ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ยกเลิก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(131, 232);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(92, 20);
            this.txtISBN.TabIndex = 11;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ระบุหมายเลข ISBN  : ";
            // 
            // labPriceUnit
            // 
            this.labPriceUnit.AutoSize = true;
            this.labPriceUnit.Location = new System.Drawing.Point(53, 258);
            this.labPriceUnit.Name = "labPriceUnit";
            this.labPriceUnit.Size = new System.Drawing.Size(68, 13);
            this.labPriceUnit.TabIndex = 13;
            this.labPriceUnit.Text = "ราคาหนังสือ :";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(162, 260);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(10, 13);
            this.labPrice.TabIndex = 14;
            this.labPrice.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "รหัสสมาชิก : ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(131, 204);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(92, 20);
            this.txtCode.TabIndex = 17;
            // 
            // Order_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 354);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labPriceUnit);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPriceSum);
            this.Controls.Add(this.labPriceSum);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.labQuantity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order_Book";
            this.Text = "Order_Book";
            this.Load += new System.EventHandler(this.Order_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labPriceSum;
        private System.Windows.Forms.TextBox txtPriceSum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPriceUnit;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
    }
}