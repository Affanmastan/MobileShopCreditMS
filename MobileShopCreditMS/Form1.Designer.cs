namespace MobileShopCreditMS
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pCat = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pId = new TextBox();
            pName = new TextBox();
            pDes = new TextBox();
            pPrice = new TextBox();
            pBrand = new TextBox();
            pStock = new TextBox();
            panel1 = new Panel();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DelBtn = new Button();
            label11 = new Label();
            Stock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Stock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(284, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 33);
            label1.TabIndex = 0;
            label1.Text = "PHONE LINK";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 18);
            label2.TabIndex = 1;
            label2.Text = "Manage Inventory\r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(780, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 18);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 125);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 3;
            label4.Text = "Catergory";
            // 
            // pCat
            // 
            pCat.FormattingEnabled = true;
            pCat.Items.AddRange(new object[] { "Mobile", "Accessories" });
            pCat.Location = new Point(136, 125);
            pCat.Margin = new Padding(4, 3, 4, 3);
            pCat.Name = "pCat";
            pCat.Size = new Size(140, 23);
            pCat.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 16);
            label5.TabIndex = 5;
            label5.Text = "Product ID";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(593, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 16);
            label6.TabIndex = 6;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 196);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 16);
            label7.TabIndex = 7;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(335, 196);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 16);
            label8.TabIndex = 8;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(593, 196);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 9;
            label9.Text = "Brand";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 264);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 16);
            label10.TabIndex = 10;
            label10.Text = "Stock";
            // 
            // pId
            // 
            pId.Location = new Point(434, 126);
            pId.Margin = new Padding(4, 3, 4, 3);
            pId.Name = "pId";
            pId.Size = new Size(116, 23);
            pId.TabIndex = 11;
            // 
            // pName
            // 
            pName.Location = new Point(656, 126);
            pName.Margin = new Padding(4, 3, 4, 3);
            pName.Name = "pName";
            pName.Size = new Size(116, 23);
            pName.TabIndex = 12;
            // 
            // pDes
            // 
            pDes.Location = new Point(149, 192);
            pDes.Margin = new Padding(4, 3, 4, 3);
            pDes.Name = "pDes";
            pDes.Size = new Size(116, 23);
            pDes.TabIndex = 13;
            // 
            // pPrice
            // 
            pPrice.Location = new Point(434, 195);
            pPrice.Margin = new Padding(4, 3, 4, 3);
            pPrice.Name = "pPrice";
            pPrice.Size = new Size(116, 23);
            pPrice.TabIndex = 14;
            // 
            // pBrand
            // 
            pBrand.Location = new Point(656, 196);
            pBrand.Margin = new Padding(4, 3, 4, 3);
            pBrand.Name = "pBrand";
            pBrand.Size = new Size(116, 23);
            pBrand.TabIndex = 15;
            // 
            // pStock
            // 
            pStock.Location = new Point(149, 264);
            pStock.Margin = new Padding(4, 3, 4, 3);
            pStock.Name = "pStock";
            pStock.Size = new Size(116, 23);
            pStock.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(1, 316);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 12);
            panel1.TabIndex = 17;
            // 
            // AddBtn
            // 
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(326, 256);
            AddBtn.Margin = new Padding(4, 3, 4, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(88, 27);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(489, 256);
            UpdateBtn.Margin = new Padding(4, 3, 4, 3);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(88, 27);
            UpdateBtn.TabIndex = 19;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(630, 256);
            DelBtn.Margin = new Padding(4, 3, 4, 3);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(88, 27);
            DelBtn.TabIndex = 20;
            DelBtn.Text = "CLEAR";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(749, 554);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(20, 16);
            label11.TabIndex = 21;
            label11.Text = "->";
            label11.Click += label11_Click;
            // 
            // Stock
            // 
            Stock.BackgroundColor = Color.Gray;
            Stock.BorderStyle = BorderStyle.Fixed3D;
            Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Stock.GridColor = SystemColors.ActiveCaption;
            Stock.Location = new Point(1, 335);
            Stock.Margin = new Padding(4, 3, 4, 3);
            Stock.Name = "Stock";
            Stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Stock.Size = new Size(802, 173);
            Stock.TabIndex = 22;
            Stock.CellContentClick += Stock_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(817, 577);
            Controls.Add(Stock);
            Controls.Add(label11);
            Controls.Add(DelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(panel1);
            Controls.Add(pStock);
            Controls.Add(pBrand);
            Controls.Add(pPrice);
            Controls.Add(pDes);
            Controls.Add(pName);
            Controls.Add(pId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pCat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pId;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.TextBox pDes;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.TextBox pBrand;
        private System.Windows.Forms.TextBox pStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Stock;
    }
}

