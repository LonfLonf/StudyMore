namespace QuizForMe
{
    partial class CreateQuizButton
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            quizIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quizTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quizDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            themeOfQuizDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            DeleteButtonQuiz = new DataGridViewButtonColumn();
            PlayQuizButton = new DataGridViewButtonColumn();
            quizBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            RefreshTable = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quizBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(3, 555);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Create Quiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.33333349F));
            tableLayoutPanel1.Size = new Size(1184, 596);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { quizIdDataGridViewTextBoxColumn, quizTitleDataGridViewTextBoxColumn, quizDescriptionDataGridViewTextBoxColumn, themeOfQuizDataGridViewTextBoxColumn, CreatedAt, DeleteButtonQuiz, PlayQuizButton });
            dataGridView1.DataSource = quizBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(898, 546);
            dataGridView1.TabIndex = 1;
            // 
            // quizIdDataGridViewTextBoxColumn
            // 
            quizIdDataGridViewTextBoxColumn.DataPropertyName = "QuizId";
            quizIdDataGridViewTextBoxColumn.HeaderText = "QuizId";
            quizIdDataGridViewTextBoxColumn.Name = "quizIdDataGridViewTextBoxColumn";
            // 
            // quizTitleDataGridViewTextBoxColumn
            // 
            quizTitleDataGridViewTextBoxColumn.DataPropertyName = "QuizTitle";
            quizTitleDataGridViewTextBoxColumn.HeaderText = "QuizTitle";
            quizTitleDataGridViewTextBoxColumn.Name = "quizTitleDataGridViewTextBoxColumn";
            // 
            // quizDescriptionDataGridViewTextBoxColumn
            // 
            quizDescriptionDataGridViewTextBoxColumn.DataPropertyName = "QuizDescription";
            quizDescriptionDataGridViewTextBoxColumn.HeaderText = "QuizDescription";
            quizDescriptionDataGridViewTextBoxColumn.Name = "quizDescriptionDataGridViewTextBoxColumn";
            // 
            // themeOfQuizDataGridViewTextBoxColumn
            // 
            themeOfQuizDataGridViewTextBoxColumn.DataPropertyName = "ThemeOfQuiz";
            themeOfQuizDataGridViewTextBoxColumn.HeaderText = "ThemeOfQuiz";
            themeOfQuizDataGridViewTextBoxColumn.Name = "themeOfQuizDataGridViewTextBoxColumn";
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "CreatedAt";
            CreatedAt.Name = "CreatedAt";
            // 
            // DeleteButtonQuiz
            // 
            DeleteButtonQuiz.HeaderText = "Delete Button";
            DeleteButtonQuiz.Name = "DeleteButtonQuiz";
            // 
            // PlayQuizButton
            // 
            PlayQuizButton.HeaderText = "Play Quiz";
            PlayQuizButton.Name = "PlayQuizButton";
            PlayQuizButton.Resizable = DataGridViewTriState.True;
            PlayQuizButton.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // quizBindingSource
            // 
            quizBindingSource.DataSource = typeof(Models.Quiz);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(RefreshTable, 0, 0);
            tableLayoutPanel2.Location = new Point(907, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.1638412F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 76.83616F));
            tableLayoutPanel2.Size = new Size(274, 177);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // RefreshTable
            // 
            RefreshTable.Location = new Point(3, 3);
            RefreshTable.Name = "RefreshTable";
            RefreshTable.Size = new Size(103, 23);
            RefreshTable.TabIndex = 0;
            RefreshTable.Text = "Refresh Table";
            RefreshTable.UseVisualStyleBackColor = true;
            RefreshTable.Click += RefreshTable_Click;
            // 
            // CreateQuizButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 596);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateQuizButton";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)quizBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private BindingSource quizBindingSource;
        private DataGridViewTextBoxColumn quizIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quizTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quizDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn themeOfQuizDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewButtonColumn DeleteButtonQuiz;
        private DataGridViewButtonColumn PlayQuizButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RefreshTable;
    }
}
