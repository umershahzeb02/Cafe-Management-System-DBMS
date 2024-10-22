namespace dbProj
{
    partial class inventoryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryManagerForm));
            dataGridView1 = new DataGridView();
            addItem = new Button();
            removeItem = new Button();
            updateItem = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(334, 421);
            dataGridView1.TabIndex = 0;
            // 
            // addItem
            // 
            addItem.Location = new Point(408, 74);
            addItem.Name = "addItem";
            addItem.Size = new Size(125, 29);
            addItem.TabIndex = 1;
            addItem.Text = "Add Item";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
            // 
            // removeItem
            // 
            removeItem.Location = new Point(408, 130);
            removeItem.Name = "removeItem";
            removeItem.Size = new Size(125, 29);
            removeItem.TabIndex = 2;
            removeItem.Text = "Remove Item";
            removeItem.UseVisualStyleBackColor = true;
            removeItem.Click += removeItem_Click;
            // 
            // updateItem
            // 
            updateItem.Location = new Point(408, 193);
            updateItem.Name = "updateItem";
            updateItem.Size = new Size(125, 29);
            updateItem.TabIndex = 3;
            updateItem.Text = "Update An Item";
            updateItem.UseVisualStyleBackColor = true;
            updateItem.Click += updateItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Inventory:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-246, -51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 687);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // inventoryManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 513);
            Controls.Add(label1);
            Controls.Add(updateItem);
            Controls.Add(removeItem);
            Controls.Add(addItem);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "inventoryManagerForm";
            Text = "inventoryManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addItem;
        private Button removeItem;
        private Button updateItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}