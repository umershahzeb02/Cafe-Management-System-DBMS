namespace dbProj
{
    partial class updatestaff
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
            idtext = new TextBox();
            salarytext = new TextBox();
            label1 = new Label();
            label2 = new Label();
            update = new Button();
            label3 = new Label();
            rolecheckboxlist = new CheckedListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // idtext
            // 
            idtext.Location = new Point(93, 156);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 0;
            // 
            // salarytext
            // 
            salarytext.Location = new Point(93, 201);
            salarytext.Name = "salarytext";
            salarytext.Size = new Size(125, 27);
            salarytext.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 162);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 208);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Salary:";
            // 
            // update
            // 
            update.Location = new Point(29, 349);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 4;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 25);
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 5;
            label3.Text = "Update the Staff Role:";
            // 
            // rolecheckboxlist
            // 
            rolecheckboxlist.FormattingEnabled = true;
            rolecheckboxlist.Items.AddRange(new object[] { "Cashier", "InventoryManager" });
            rolecheckboxlist.Location = new Point(93, 251);
            rolecheckboxlist.Name = "rolecheckboxlist";
            rolecheckboxlist.Size = new Size(150, 48);
            rolecheckboxlist.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 251);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "Role:";
            // 
            // updatestaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(347, 450);
            Controls.Add(label4);
            Controls.Add(rolecheckboxlist);
            Controls.Add(label3);
            Controls.Add(update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salarytext);
            Controls.Add(idtext);
            Name = "updatestaff";
            Text = "updatestaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idtext;
        private TextBox salarytext;
        private Label label1;
        private Label label2;
        private Button update;
        private Label label3;
        private CheckedListBox rolecheckboxlist;
        private Label label4;
    }
}