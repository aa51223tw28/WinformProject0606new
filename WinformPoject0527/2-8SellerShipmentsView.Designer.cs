﻿namespace WinformPoject0527
{
    partial class SellerShipmentsView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCompletion = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnTimeorder = new System.Windows.Forms.Button();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "出貨單檢視表";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "出貨單號:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(383, 100);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 22);
            this.txtSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(500, 93);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 29);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCompletion
            // 
            this.btnCompletion.Location = new System.Drawing.Point(237, 93);
            this.btnCompletion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompletion.Name = "btnCompletion";
            this.btnCompletion.Size = new System.Drawing.Size(69, 29);
            this.btnCompletion.TabIndex = 35;
            this.btnCompletion.Text = "完成狀況";
            this.btnCompletion.UseVisualStyleBackColor = true;
            this.btnCompletion.Click += new System.EventHandler(this.btnCompletion_Click);
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(159, 93);
            this.btnShip.Margin = new System.Windows.Forms.Padding(2);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(69, 29);
            this.btnShip.TabIndex = 34;
            this.btnShip.Text = "出貨狀況";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnTimeorder
            // 
            this.btnTimeorder.Location = new System.Drawing.Point(81, 93);
            this.btnTimeorder.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeorder.Name = "btnTimeorder";
            this.btnTimeorder.Size = new System.Drawing.Size(69, 29);
            this.btnTimeorder.TabIndex = 33;
            this.btnTimeorder.Text = "時間排序";
            this.btnTimeorder.UseVisualStyleBackColor = true;
            this.btnTimeorder.Click += new System.EventHandler(this.btnTimeorder_Click);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonrefresh.Location = new System.Drawing.Point(573, 344);
            this.buttonrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(56, 29);
            this.buttonrefresh.TabIndex = 32;
            this.buttonrefresh.Text = "重整";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.Location = new System.Drawing.Point(573, 56);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 29);
            this.btnback.TabIndex = 31;
            this.btnback.Text = "回主頁";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(472, 237);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SellerShipmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCompletion);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnTimeorder);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SellerShipmentsView";
            this.Text = "SellerShipmentsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCompletion;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnTimeorder;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}