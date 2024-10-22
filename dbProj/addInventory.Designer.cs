namespace dbProj
{
    partial class addInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addInventory));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nametxt = new TextBox();
            desctxt = new TextBox();
            quanttxt = new TextBox();
            categorytxt = new TextBox();
            unitPricetxt = new TextBox();
            pointstxt = new TextBox();
            addItem = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(301, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(348, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(348, 86);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 172);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(348, 130);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(348, 223);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 5;
            label5.Text = "Price per Unit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(348, 275);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Points:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(455, 40);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(125, 27);
            nametxt.TabIndex = 7;
            // 
            // desctxt
            // 
            desctxt.Location = new Point(453, 86);
            desctxt.Name = "desctxt";
            desctxt.Size = new Size(264, 27);
            desctxt.TabIndex = 8;
            // 
            // quanttxt
            // 
            quanttxt.Location = new Point(453, 130);
            quanttxt.Name = "quanttxt";
            quanttxt.Size = new Size(125, 27);
            quanttxt.TabIndex = 9;
            // 
            // categorytxt
            // 
            categorytxt.Location = new Point(453, 172);
            categorytxt.Name = "categorytxt";
            categorytxt.Size = new Size(125, 27);
            categorytxt.TabIndex = 10;
            // 
            // unitPricetxt
            // 
            unitPricetxt.Location = new Point(455, 223);
            unitPricetxt.Name = "unitPricetxt";
            unitPricetxt.Size = new Size(125, 27);
            unitPricetxt.TabIndex = 11;
            // 
            // pointstxt
            // 
            pointstxt.Location = new Point(453, 275);
            pointstxt.Name = "pointstxt";
            pointstxt.Size = new Size(125, 27);
            pointstxt.TabIndex = 12;
            // 
            // addItem
            // 
            addItem.Location = new Point(348, 373);
            addItem.Name = "addItem";
            addItem.Size = new Size(94, 29);
            addItem.TabIndex = 13;
            addItem.Text = "Add Item";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-144, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // addInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(addItem);
            Controls.Add(pointstxt);
            Controls.Add(unitPricetxt);
            Controls.Add(categorytxt);
            Controls.Add(quanttxt);
            Controls.Add(desctxt);
            Controls.Add(nametxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "addInventory";
            Text = "addInventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nametxt;
        private TextBox desctxt;
        private TextBox quanttxt;
        private TextBox categorytxt;
        private TextBox unitPricetxt;
        private TextBox pointstxt;
        private Button addItem;
        private PictureBox pictureBox1;
    }
}