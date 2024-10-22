namespace dbProj
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            label1 = new Label();
            label2 = new Label();
            staff = new Button();
            menu = new Button();
            inventory = new Button();
            reports = new Button();
            pictureBox1 = new PictureBox();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "CampusBites ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 24);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "| Manager";
            // 
            // staff
            // 
            staff.Location = new Point(42, 83);
            staff.Name = "staff";
            staff.Size = new Size(154, 29);
            staff.TabIndex = 2;
            staff.Text = "Manage Staff";
            staff.UseVisualStyleBackColor = true;
            staff.Click += staff_Click;
            // 
            // menu
            // 
            menu.Location = new Point(42, 187);
            menu.Name = "menu";
            menu.Size = new Size(154, 29);
            menu.TabIndex = 3;
            menu.Text = "Make Menu";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // inventory
            // 
            inventory.Location = new Point(42, 137);
            inventory.Name = "inventory";
            inventory.Size = new Size(154, 29);
            inventory.TabIndex = 4;
            inventory.Text = "Manage Inventory";
            inventory.UseVisualStyleBackColor = true;
            inventory.Click += inventory_Click;
            // 
            // reports
            // 
            reports.Location = new Point(42, 245);
            reports.Name = "reports";
            reports.Size = new Size(154, 29);
            reports.TabIndex = 5;
            reports.Text = "Check Reports";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new Point(66, 390);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 16;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Controls.Add(reports);
            Controls.Add(inventory);
            Controls.Add(menu);
            Controls.Add(staff);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManagerForm";
            Text = "Form2";
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button staff;
        private Button menu;
        private Button inventory;
        private Button reports;
        private PictureBox pictureBox1;
        private Button logout;
    }
}