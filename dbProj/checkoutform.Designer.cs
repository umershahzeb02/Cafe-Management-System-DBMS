namespace dbProj
{
    partial class checkoutform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutform));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            amounttxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstNametxt = new TextBox();
            lastNametxt = new TextBox();
            contacttxt = new TextBox();
            cash = new CheckBox();
            credit = new CheckBox();
            label6 = new Label();
            checkoutComplete = new Button();
            label7 = new Label();
            label8 = new Label();
            cstIDtxt = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(340, 366);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(397, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // amounttxt
            // 
            amounttxt.Location = new Point(497, 80);
            amounttxt.Name = "amounttxt";
            amounttxt.Size = new Size(125, 27);
            amounttxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(397, 218);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(625, 218);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(397, 270);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(397, 312);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 6;
            label5.Text = "Payment Method:";
            // 
            // firstNametxt
            // 
            firstNametxt.Location = new Point(486, 215);
            firstNametxt.Name = "firstNametxt";
            firstNametxt.Size = new Size(125, 27);
            firstNametxt.TabIndex = 7;
            // 
            // lastNametxt
            // 
            lastNametxt.Location = new Point(715, 215);
            lastNametxt.Name = "lastNametxt";
            lastNametxt.Size = new Size(125, 27);
            lastNametxt.TabIndex = 8;
            // 
            // contacttxt
            // 
            contacttxt.Location = new Point(480, 267);
            contacttxt.Name = "contacttxt";
            contacttxt.Size = new Size(125, 27);
            contacttxt.TabIndex = 9;
            // 
            // cash
            // 
            cash.AutoSize = true;
            cash.Location = new Point(534, 311);
            cash.Name = "cash";
            cash.Size = new Size(62, 24);
            cash.TabIndex = 10;
            cash.Text = "Cash";
            cash.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Location = new Point(602, 311);
            credit.Name = "credit";
            credit.Size = new Size(149, 24);
            credit.TabIndex = 11;
            credit.Text = "Credit/Debit Card";
            credit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 37);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 12;
            label6.Text = "Your Order:";
            // 
            // checkoutComplete
            // 
            checkoutComplete.Location = new Point(404, 393);
            checkoutComplete.Name = "checkoutComplete";
            checkoutComplete.Size = new Size(94, 29);
            checkoutComplete.TabIndex = 13;
            checkoutComplete.Text = "Done";
            checkoutComplete.UseVisualStyleBackColor = true;
            checkoutComplete.Click += checkoutComplete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 181);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 14;
            label7.Text = "OR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(397, 131);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 15;
            label8.Text = "Costumer ID:";
            // 
            // cstIDtxt
            // 
            cstIDtxt.Location = new Point(497, 128);
            cstIDtxt.Name = "cstIDtxt";
            cstIDtxt.Size = new Size(125, 27);
            cstIDtxt.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-224, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // checkoutform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(919, 450);
            Controls.Add(cstIDtxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkoutComplete);
            Controls.Add(label6);
            Controls.Add(credit);
            Controls.Add(cash);
            Controls.Add(contacttxt);
            Controls.Add(lastNametxt);
            Controls.Add(firstNametxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(amounttxt);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "checkoutform";
            Text = "checkoutform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox amounttxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstNametxt;
        private TextBox lastNametxt;
        private TextBox contacttxt;
        private CheckBox cash;
        private CheckBox credit;
        private Label label6;
        private Button checkoutComplete;
        private Label label7;
        private Label label8;
        private TextBox cstIDtxt;
        private PictureBox pictureBox1;
    }
}