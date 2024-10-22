namespace dbProj
{
    partial class reportsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportsform));
            StaffPerfReport = new Button();
            SalesAndRevreport = new Button();
            transacReport = new Button();
            custLoyality = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mostOrdered = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StaffPerfReport
            // 
            StaffPerfReport.Location = new Point(44, 61);
            StaffPerfReport.Name = "StaffPerfReport";
            StaffPerfReport.Size = new Size(197, 61);
            StaffPerfReport.TabIndex = 0;
            StaffPerfReport.Text = "Staff Performance Report";
            StaffPerfReport.UseVisualStyleBackColor = true;
            StaffPerfReport.Click += StaffPerfReport_Click;
            // 
            // SalesAndRevreport
            // 
            SalesAndRevreport.Location = new Point(44, 143);
            SalesAndRevreport.Name = "SalesAndRevreport";
            SalesAndRevreport.Size = new Size(197, 66);
            SalesAndRevreport.TabIndex = 1;
            SalesAndRevreport.Text = "Sales And Revenue Report";
            SalesAndRevreport.UseVisualStyleBackColor = true;
            SalesAndRevreport.Click += SalesAndRevreport_Click;
            // 
            // transacReport
            // 
            transacReport.Location = new Point(44, 230);
            transacReport.Name = "transacReport";
            transacReport.Size = new Size(197, 53);
            transacReport.TabIndex = 2;
            transacReport.Text = "Transactions Reports";
            transacReport.UseVisualStyleBackColor = true;
            transacReport.Click += transacReport_Click;
            // 
            // custLoyality
            // 
            custLoyality.Location = new Point(44, 308);
            custLoyality.Name = "custLoyality";
            custLoyality.Size = new Size(197, 56);
            custLoyality.TabIndex = 3;
            custLoyality.Text = "Customer Loyality Report";
            custLoyality.UseVisualStyleBackColor = true;
            custLoyality.Click += custLoyality_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 4;
            label1.Text = "Reports:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // mostOrdered
            // 
            mostOrdered.Location = new Point(44, 381);
            mostOrdered.Name = "mostOrdered";
            mostOrdered.Size = new Size(197, 57);
            mostOrdered.TabIndex = 16;
            mostOrdered.Text = "Most Ordered Item";
            mostOrdered.UseVisualStyleBackColor = true;
            mostOrdered.Click += mostOrdered_Click;
            // 
            // reportsform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(mostOrdered);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(custLoyality);
            Controls.Add(transacReport);
            Controls.Add(SalesAndRevreport);
            Controls.Add(StaffPerfReport);
            Name = "reportsform";
            Text = "reportsform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StaffPerfReport;
        private Button SalesAndRevreport;
        private Button transacReport;
        private Button custLoyality;
        private Label label1;
        private PictureBox pictureBox1;
        private Button mostOrdered;
    }
}