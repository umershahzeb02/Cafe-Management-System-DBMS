namespace dbProj
{
    partial class removeStaff
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
            idtextbox = new TextBox();
            label1 = new Label();
            remove = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // idtextbox
            // 
            idtextbox.Location = new Point(62, 116);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(125, 27);
            idtextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 119);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // remove
            // 
            remove.Location = new Point(19, 189);
            remove.Name = "remove";
            remove.Size = new Size(94, 29);
            remove.TabIndex = 2;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(251, 28);
            label2.TabIndex = 3;
            label2.Text = "Remove A Staff Member:";
            // 
            // removeStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(314, 270);
            Controls.Add(label2);
            Controls.Add(remove);
            Controls.Add(label1);
            Controls.Add(idtextbox);
            Name = "removeStaff";
            Text = "removeStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idtextbox;
        private Label label1;
        private Button remove;
        private Label label2;
    }
}