namespace dbProj
{
    partial class makeMenu
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
            dataGridView2 = new DataGridView();
            add = new TextBox();
            remove = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addbt = new Button();
            removebt = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(390, 457);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(438, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(467, 257);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // add
            // 
            add.Location = new Point(484, 339);
            add.Name = "add";
            add.Size = new Size(125, 27);
            add.TabIndex = 2;
            // 
            // remove
            // 
            remove.Location = new Point(727, 341);
            remove.Name = "remove";
            remove.Size = new Size(125, 27);
            remove.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 344);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(684, 344);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // addbt
            // 
            addbt.Location = new Point(484, 398);
            addbt.Name = "addbt";
            addbt.Size = new Size(94, 29);
            addbt.TabIndex = 6;
            addbt.Text = "Add";
            addbt.UseVisualStyleBackColor = true;
            addbt.Click += addbt_Click;
            // 
            // removebt
            // 
            removebt.Location = new Point(727, 398);
            removebt.Name = "removebt";
            removebt.Size = new Size(94, 29);
            removebt.TabIndex = 7;
            removebt.Text = "Remove";
            removebt.UseVisualStyleBackColor = true;
            removebt.Click += removebt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Inventory:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(438, 18);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Menu:";
            // 
            // makeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(917, 525);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(removebt);
            Controls.Add(addbt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "makeMenu";
            Text = "makeMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox add;
        private TextBox remove;
        private Label label1;
        private Label label2;
        private Button addbt;
        private Button removebt;
        private Label label3;
        private Label label4;
    }
}