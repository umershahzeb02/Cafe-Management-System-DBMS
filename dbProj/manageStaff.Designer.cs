namespace dbProj
{
    partial class manageStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageStaff));
            dataGridView1 = new DataGridView();
            addstaff = new Button();
            removestaff = new Button();
            updateStaff = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(409, 385);
            dataGridView1.TabIndex = 0;
            // 
            // addstaff
            // 
            addstaff.Location = new Point(464, 63);
            addstaff.Name = "addstaff";
            addstaff.Size = new Size(113, 29);
            addstaff.TabIndex = 1;
            addstaff.Text = "Add Staff";
            addstaff.UseVisualStyleBackColor = true;
            addstaff.Click += addstaff_Click;
            // 
            // removestaff
            // 
            removestaff.Location = new Point(464, 126);
            removestaff.Name = "removestaff";
            removestaff.Size = new Size(113, 29);
            removestaff.TabIndex = 2;
            removestaff.Text = "Remove Staff";
            removestaff.UseVisualStyleBackColor = true;
            removestaff.Click += removestaff_Click;
            // 
            // updateStaff
            // 
            updateStaff.Location = new Point(464, 197);
            updateStaff.Name = "updateStaff";
            updateStaff.Size = new Size(113, 29);
            updateStaff.TabIndex = 3;
            updateStaff.Text = "Update Staff";
            updateStaff.UseVisualStyleBackColor = true;
            updateStaff.Click += updateStaff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 4;
            label1.Text = "Staff:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-42, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // manageStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(updateStaff);
            Controls.Add(removestaff);
            Controls.Add(addstaff);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "manageStaff";
            Text = "manageStaff";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addstaff;
        private Button removestaff;
        private Button updateStaff;
        private Label label1;
        private PictureBox pictureBox1;
    }
}