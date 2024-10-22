namespace dbProj
{
    partial class updateInventory
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
            dataGridView1 = new DataGridView();
            newQuant = new TextBox();
            label1 = new Label();
            update = new Button();
            idtext = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(346, 392);
            dataGridView1.TabIndex = 0;
            // 
            // newQuant
            // 
            newQuant.Location = new Point(496, 100);
            newQuant.Name = "newQuant";
            newQuant.Size = new Size(125, 27);
            newQuant.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 103);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "New Quantity:";
            // 
            // update
            // 
            update.Location = new Point(388, 170);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 3;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // idtext
            // 
            idtext.Location = new Point(496, 57);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 64);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // updateInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(idtext);
            Controls.Add(update);
            Controls.Add(label1);
            Controls.Add(newQuant);
            Controls.Add(dataGridView1);
            Name = "updateInventory";
            Text = "updateInventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox newQuant;
        private Label label1;
        private Button update;
        private TextBox idtext;
        private Label label2;
    }
}