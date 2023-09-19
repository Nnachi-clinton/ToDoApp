namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tittleTextbox = new TextBox();
            label3 = new Label();
            descriptionTextBox = new TextBox();
            AddButton = new Button();
            SearchButton = new Button();
            NewButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            SearchTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dateTimePicker1 = new DateTimePicker();
            DeleteAllButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, -1);
            label1.Name = "label1";
            label1.Size = new Size(1370, 74);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(1021, 25);
            label2.TabIndex = 1;
            label2.Text = "Task:";
            label2.Click += label2_Click;
            // 
            // tittleTextbox
            // 
            tittleTextbox.Location = new Point(2, 115);
            tittleTextbox.Name = "tittleTextbox";
            tittleTextbox.Size = new Size(1021, 27);
            tittleTextbox.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 157);
            label3.Name = "label3";
            label3.Size = new Size(1021, 25);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(2, 185);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1021, 27);
            descriptionTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(1426, 162);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(268, 50);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(192, 192, 0);
            SearchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1046, 162);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(335, 50);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.FromArgb(255, 128, 128);
            NewButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NewButton.Location = new Point(1426, -1);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(268, 50);
            NewButton.TabIndex = 7;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(192, 0, 0);
            DeleteButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(1426, 55);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 50);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Yellow;
            EditButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Location = new Point(1426, 111);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(268, 50);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(1046, 129);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(326, 27);
            SearchTextBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1735, 472);
            dataGridView1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1046, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(326, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.BackColor = Color.FromArgb(192, 0, 0);
            DeleteAllButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAllButton.Location = new Point(1552, 55);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(142, 50);
            DeleteAllButton.TabIndex = 15;
            DeleteAllButton.Text = "Delete All";
            DeleteAllButton.UseVisualStyleBackColor = false;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1759, 698);
            Controls.Add(DeleteAllButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(SearchTextBox);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(NewButton);
            Controls.Add(SearchButton);
            Controls.Add(AddButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(label3);
            Controls.Add(tittleTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "To Do List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tittleTextbox;
        private Label label3;
        private TextBox descriptionTextBox;
        private Button AddButton;
        private Button SearchButton;
        private Button NewButton;
        private Button DeleteButton;
        private Button EditButton;
        private TextBox SearchTextBox;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateTimePicker1;
        private Button DeleteAllButton;
    }
}