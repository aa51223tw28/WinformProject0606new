﻿namespace WinformPoject0527
{
    partial class BuyerList
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxaccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxship = new System.Windows.Forms.TextBox();
            this.textBoxpay = new System.Windows.Forms.TextBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonbaclshoppingcart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(44, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "付款方式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(44, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "物流方式：";
            // 
            // textBoxaccount
            // 
            this.textBoxaccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxaccount.Location = new System.Drawing.Point(179, 108);
            this.textBoxaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxaccount.Name = "textBoxaccount";
            this.textBoxaccount.ReadOnly = true;
            this.textBoxaccount.Size = new System.Drawing.Size(325, 34);
            this.textBoxaccount.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "帳號：";
            // 
            // textBoxship
            // 
            this.textBoxship.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxship.Location = new System.Drawing.Point(179, 159);
            this.textBoxship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxship.Name = "textBoxship";
            this.textBoxship.ReadOnly = true;
            this.textBoxship.Size = new System.Drawing.Size(325, 34);
            this.textBoxship.TabIndex = 35;
            // 
            // textBoxpay
            // 
            this.textBoxpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxpay.Location = new System.Drawing.Point(179, 214);
            this.textBoxpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpay.Name = "textBoxpay";
            this.textBoxpay.ReadOnly = true;
            this.textBoxpay.Size = new System.Drawing.Size(325, 34);
            this.textBoxpay.TabIndex = 35;
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsubmit.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonsubmit.Location = new System.Drawing.Point(1276, 686);
            this.buttonsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(165, 48);
            this.buttonsubmit.TabIndex = 38;
            this.buttonsubmit.Text = "送出訂單";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 42);
            this.label4.TabIndex = 39;
            this.label4.Text = "確認訂單";
            // 
            // buttonbaclshoppingcart
            // 
            this.buttonbaclshoppingcart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbaclshoppingcart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonbaclshoppingcart.Location = new System.Drawing.Point(1276, 14);
            this.buttonbaclshoppingcart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonbaclshoppingcart.Name = "buttonbaclshoppingcart";
            this.buttonbaclshoppingcart.Size = new System.Drawing.Size(165, 48);
            this.buttonbaclshoppingcart.TabIndex = 38;
            this.buttonbaclshoppingcart.Text = "回購物車";
            this.buttonbaclshoppingcart.UseVisualStyleBackColor = true;
            this.buttonbaclshoppingcart.Click += new System.EventHandler(this.buttonbaclshoppingcart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(555, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(887, 588);
            this.dataGridView1.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CartID";
            this.Column1.HeaderText = "購物車編號";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductId";
            this.Column2.HeaderText = "商品編號";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductName";
            this.Column3.HeaderText = "商品名稱";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "購買數量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ProductPrice";
            this.Column6.HeaderText = "單價";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TotalProductPrice";
            this.Column4.HeaderText = "價格小計";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // BuyerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 760);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonbaclshoppingcart);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxpay);
            this.Controls.Add(this.textBoxship);
            this.Controls.Add(this.textBoxaccount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuyerList";
            this.Text = "BuyerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxship;
        private System.Windows.Forms.TextBox textBoxpay;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonbaclshoppingcart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}