namespace dbProj
{
    partial class addStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStaff));
            firstName = new TextBox();
            lastName = new TextBox();
            contact = new TextBox();
            address = new TextBox();
            salary = new TextBox();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            rolechecklistbox = new CheckedListBox();
            label9 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(147, 70);
            firstName.Name = "firstName";
            firstName.Size = new Size(125, 27);
            firstName.TabIndex = 0;
            // 
            // lastName
            // 
            lastName.Location = new Point(147, 133);
            lastName.Name = "lastName";
            lastName.Size = new Size(125, 27);
            lastName.TabIndex = 1;
            // 
            // contact
            // 
            contact.Location = new Point(147, 185);
            contact.Name = "contact";
            contact.Size = new Size(125, 27);
            contact.TabIndex = 2;
            // 
            // address
            // 
            address.Location = new Point(147, 238);
            address.Name = "address";
            address.Size = new Size(125, 27);
            address.TabIndex = 3;
            // 
            // salary
            // 
            salary.Location = new Point(147, 301);
            salary.Name = "salary";
            salary.Size = new Size(125, 27);
            salary.TabIndex = 4;
            // 
            // username
            // 
            username.Location = new Point(458, 74);
            username.Name = "username";
            username.Size = new Size(125, 27);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Location = new Point(458, 129);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 77);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 7;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 188);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 245);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 308);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 11;
            label5.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 81);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 12;
            label6.Text = "Set Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 136);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 13;
            label7.Text = "Set Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 365);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 14;
            label8.Text = "Role:";
            // 
            // rolechecklistbox
            // 
            rolechecklistbox.FormattingEnabled = true;
            rolechecklistbox.Items.AddRange(new object[] { "Cashier", "InventoryManager" });
            rolechecklistbox.Location = new Point(147, 365);
            rolechecklistbox.Name = "rolechecklistbox";
            rolechecklistbox.Size = new Size(150, 48);
            rolechecklistbox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(43, 27);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 16;
            label9.Text = "Enter Details:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(43, 449);
            button1.Name = "button1";
            button1.Size = new Size(125, 49);
            button1.TabIndex = 17;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(589, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(646, 704);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // addStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 597);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(rolechecklistbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(salary);
            Controls.Add(address);
            Controls.Add(contact);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(pictureBox1);
            Name = "addStaff";
            Text = "addStaff";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private TextBox lastName;
        private TextBox contact;
        private TextBox address;
        private TextBox salary;
        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckedListBox rolechecklistbox;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox1;
    }
}