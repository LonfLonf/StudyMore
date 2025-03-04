namespace QuizForMe
{
    partial class CreateQuizForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ThemeQuizComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            URLQuizTextBox = new TextBox();
            label2 = new Label();
            DescriptioQuizTextBox = new TextBox();
            label1 = new Label();
            TitleOfQuizTextBox = new TextBox();
            CreateQuiz = new Button();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel2 = new TableLayoutPanel();
            ThemeLabel = new TableLayoutPanel();
            DifficultyComboBox = new ComboBox();
            ThemeQuestionComboBox = new ComboBox();
            DifficultLabel = new Label();
            ThemeOfQuestionTextBox = new Label();
            CorrectOptionLabel = new Label();
            CorrectOptionTextBox = new TextBox();
            OptionDLabel = new Label();
            OptionDTextBox = new TextBox();
            OptionCLabel = new Label();
            OptionCTextBox = new TextBox();
            OptionBLabel = new Label();
            OptionBTextBox = new TextBox();
            OptionALabel = new Label();
            OptionATextBox = new TextBox();
            AuxiliarImageLabel = new Label();
            AuxiliarImageTextBox = new TextBox();
            DescriptionQuestionLabel = new Label();
            DescriptionQuestionTextBox = new TextBox();
            TitleOfQuestionLabel = new Label();
            TitleOfQuestionTextBox = new TextBox();
            AddQuestion = new Button();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ThemeLabel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5304661F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.4695358F));
            tableLayoutPanel1.Controls.Add(ThemeQuizComboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(URLQuizTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(DescriptioQuizTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(TitleOfQuizTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(CreateQuiz, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Size = new Size(1116, 325);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ThemeQuizComboBox
            // 
            ThemeQuizComboBox.FormattingEnabled = true;
            ThemeQuizComboBox.Items.AddRange(new object[] { " Mathematics", " History", " ComputerScience", " Philosophy", " Programming", " MalwareDevelopment", " CyberSecurity", " OtherStuff" });
            ThemeQuizComboBox.Location = new Point(154, 198);
            ThemeQuizComboBox.Name = "ThemeQuizComboBox";
            ThemeQuizComboBox.Size = new Size(121, 23);
            ThemeQuizComboBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 195);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 6;
            label4.Text = "Theme Of Quiz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 130);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "URL Image";
            // 
            // URLQuizTextBox
            // 
            URLQuizTextBox.Location = new Point(154, 133);
            URLQuizTextBox.Name = "URLQuizTextBox";
            URLQuizTextBox.Size = new Size(100, 23);
            URLQuizTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // DescriptioQuizTextBox
            // 
            DescriptioQuizTextBox.Location = new Point(154, 68);
            DescriptioQuizTextBox.Name = "DescriptioQuizTextBox";
            DescriptioQuizTextBox.Size = new Size(100, 23);
            DescriptioQuizTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Title Of Quiz";
            // 
            // TitleOfQuizTextBox
            // 
            TitleOfQuizTextBox.Location = new Point(154, 3);
            TitleOfQuizTextBox.Name = "TitleOfQuizTextBox";
            TitleOfQuizTextBox.Size = new Size(100, 23);
            TitleOfQuizTextBox.TabIndex = 1;
            // 
            // CreateQuiz
            // 
            CreateQuiz.Location = new Point(3, 263);
            CreateQuiz.Name = "CreateQuiz";
            CreateQuiz.Size = new Size(143, 39);
            CreateQuiz.TabIndex = 8;
            CreateQuiz.Text = "Create Quiz";
            CreateQuiz.UseVisualStyleBackColor = true;
            CreateQuiz.Click += CreateQuiz_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ThemeLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 331);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1116, 405);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ThemeLabel
            // 
            ThemeLabel.BackColor = SystemColors.ScrollBar;
            ThemeLabel.ColumnCount = 2;
            ThemeLabel.ColumnStyles.Add(new ColumnStyle());
            ThemeLabel.ColumnStyles.Add(new ColumnStyle());
            ThemeLabel.Controls.Add(DifficultyComboBox, 1, 9);
            ThemeLabel.Controls.Add(ThemeQuestionComboBox, 1, 8);
            ThemeLabel.Controls.Add(DifficultLabel, 0, 9);
            ThemeLabel.Controls.Add(ThemeOfQuestionTextBox, 0, 8);
            ThemeLabel.Controls.Add(CorrectOptionLabel, 0, 7);
            ThemeLabel.Controls.Add(CorrectOptionTextBox, 1, 7);
            ThemeLabel.Controls.Add(OptionDLabel, 0, 6);
            ThemeLabel.Controls.Add(OptionDTextBox, 1, 6);
            ThemeLabel.Controls.Add(OptionCLabel, 0, 5);
            ThemeLabel.Controls.Add(OptionCTextBox, 1, 5);
            ThemeLabel.Controls.Add(OptionBLabel, 0, 4);
            ThemeLabel.Controls.Add(OptionBTextBox, 1, 4);
            ThemeLabel.Controls.Add(OptionALabel, 0, 3);
            ThemeLabel.Controls.Add(OptionATextBox, 1, 3);
            ThemeLabel.Controls.Add(AuxiliarImageLabel, 0, 2);
            ThemeLabel.Controls.Add(AuxiliarImageTextBox, 1, 2);
            ThemeLabel.Controls.Add(DescriptionQuestionLabel, 0, 1);
            ThemeLabel.Controls.Add(DescriptionQuestionTextBox, 1, 1);
            ThemeLabel.Controls.Add(TitleOfQuestionLabel, 0, 0);
            ThemeLabel.Controls.Add(TitleOfQuestionTextBox, 1, 0);
            ThemeLabel.Controls.Add(AddQuestion, 0, 10);
            ThemeLabel.Controls.Add(label5, 1, 10);
            ThemeLabel.Dock = DockStyle.Fill;
            ThemeLabel.Location = new Point(3, 3);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.RowCount = 11;
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ThemeLabel.Size = new Size(1110, 399);
            ThemeLabel.TabIndex = 0;
            // 
            // DifficultyComboBox
            // 
            DifficultyComboBox.FormattingEnabled = true;
            DifficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Master" });
            DifficultyComboBox.Location = new Point(141, 336);
            DifficultyComboBox.Name = "DifficultyComboBox";
            DifficultyComboBox.Size = new Size(121, 23);
            DifficultyComboBox.TabIndex = 23;
            // 
            // ThemeQuestionComboBox
            // 
            ThemeQuestionComboBox.FormattingEnabled = true;
            ThemeQuestionComboBox.Items.AddRange(new object[] { " Mathematics", " History", " ComputerScience", " Philosophy", " Programming", " MalwareDevelopment", " CyberSecurity", " OtherStuff" });
            ThemeQuestionComboBox.Location = new Point(141, 299);
            ThemeQuestionComboBox.Name = "ThemeQuestionComboBox";
            ThemeQuestionComboBox.Size = new Size(121, 23);
            ThemeQuestionComboBox.TabIndex = 22;
            // 
            // DifficultLabel
            // 
            DifficultLabel.AutoSize = true;
            DifficultLabel.Location = new Point(3, 333);
            DifficultLabel.Name = "DifficultLabel";
            DifficultLabel.Size = new Size(116, 15);
            DifficultLabel.TabIndex = 18;
            DifficultLabel.Text = "Difficult Of Question";
            // 
            // ThemeOfQuestionTextBox
            // 
            ThemeOfQuestionTextBox.AutoSize = true;
            ThemeOfQuestionTextBox.Location = new Point(3, 296);
            ThemeOfQuestionTextBox.Name = "ThemeOfQuestionTextBox";
            ThemeOfQuestionTextBox.Size = new Size(104, 15);
            ThemeOfQuestionTextBox.TabIndex = 16;
            ThemeOfQuestionTextBox.Text = "ThemeOfQuestion";
            // 
            // CorrectOptionLabel
            // 
            CorrectOptionLabel.AutoSize = true;
            CorrectOptionLabel.Location = new Point(3, 259);
            CorrectOptionLabel.Name = "CorrectOptionLabel";
            CorrectOptionLabel.Size = new Size(83, 15);
            CorrectOptionLabel.TabIndex = 14;
            CorrectOptionLabel.Text = "CorrectOption";
            // 
            // CorrectOptionTextBox
            // 
            CorrectOptionTextBox.Location = new Point(141, 262);
            CorrectOptionTextBox.Name = "CorrectOptionTextBox";
            CorrectOptionTextBox.Size = new Size(100, 23);
            CorrectOptionTextBox.TabIndex = 15;
            // 
            // OptionDLabel
            // 
            OptionDLabel.AutoSize = true;
            OptionDLabel.Location = new Point(3, 222);
            OptionDLabel.Name = "OptionDLabel";
            OptionDLabel.Size = new Size(57, 15);
            OptionDLabel.TabIndex = 12;
            OptionDLabel.Text = "Option_D";
            // 
            // OptionDTextBox
            // 
            OptionDTextBox.Location = new Point(141, 225);
            OptionDTextBox.Name = "OptionDTextBox";
            OptionDTextBox.Size = new Size(100, 23);
            OptionDTextBox.TabIndex = 13;
            // 
            // OptionCLabel
            // 
            OptionCLabel.AutoSize = true;
            OptionCLabel.Location = new Point(3, 185);
            OptionCLabel.Name = "OptionCLabel";
            OptionCLabel.Size = new Size(57, 15);
            OptionCLabel.TabIndex = 10;
            OptionCLabel.Text = "Option_C";
            // 
            // OptionCTextBox
            // 
            OptionCTextBox.Location = new Point(141, 188);
            OptionCTextBox.Name = "OptionCTextBox";
            OptionCTextBox.Size = new Size(100, 23);
            OptionCTextBox.TabIndex = 11;
            // 
            // OptionBLabel
            // 
            OptionBLabel.AutoSize = true;
            OptionBLabel.Location = new Point(3, 148);
            OptionBLabel.Name = "OptionBLabel";
            OptionBLabel.Size = new Size(56, 15);
            OptionBLabel.TabIndex = 8;
            OptionBLabel.Text = "Option_B";
            // 
            // OptionBTextBox
            // 
            OptionBTextBox.Location = new Point(141, 151);
            OptionBTextBox.Name = "OptionBTextBox";
            OptionBTextBox.Size = new Size(100, 23);
            OptionBTextBox.TabIndex = 9;
            // 
            // OptionALabel
            // 
            OptionALabel.AutoSize = true;
            OptionALabel.Location = new Point(3, 111);
            OptionALabel.Name = "OptionALabel";
            OptionALabel.Size = new Size(57, 15);
            OptionALabel.TabIndex = 6;
            OptionALabel.Text = "Option_A";
            // 
            // OptionATextBox
            // 
            OptionATextBox.Location = new Point(141, 114);
            OptionATextBox.Name = "OptionATextBox";
            OptionATextBox.Size = new Size(100, 23);
            OptionATextBox.TabIndex = 7;
            // 
            // AuxiliarImageLabel
            // 
            AuxiliarImageLabel.AutoSize = true;
            AuxiliarImageLabel.Location = new Point(3, 74);
            AuxiliarImageLabel.Name = "AuxiliarImageLabel";
            AuxiliarImageLabel.Size = new Size(80, 15);
            AuxiliarImageLabel.TabIndex = 4;
            AuxiliarImageLabel.Text = "AuxiliarImage";
            // 
            // AuxiliarImageTextBox
            // 
            AuxiliarImageTextBox.Location = new Point(141, 77);
            AuxiliarImageTextBox.Name = "AuxiliarImageTextBox";
            AuxiliarImageTextBox.Size = new Size(100, 23);
            AuxiliarImageTextBox.TabIndex = 5;
            // 
            // DescriptionQuestionLabel
            // 
            DescriptionQuestionLabel.AutoSize = true;
            DescriptionQuestionLabel.Location = new Point(3, 37);
            DescriptionQuestionLabel.Name = "DescriptionQuestionLabel";
            DescriptionQuestionLabel.Size = new Size(132, 15);
            DescriptionQuestionLabel.TabIndex = 2;
            DescriptionQuestionLabel.Text = "Description of Question";
            // 
            // DescriptionQuestionTextBox
            // 
            DescriptionQuestionTextBox.Location = new Point(141, 40);
            DescriptionQuestionTextBox.Name = "DescriptionQuestionTextBox";
            DescriptionQuestionTextBox.Size = new Size(100, 23);
            DescriptionQuestionTextBox.TabIndex = 3;
            // 
            // TitleOfQuestionLabel
            // 
            TitleOfQuestionLabel.AutoSize = true;
            TitleOfQuestionLabel.Location = new Point(3, 0);
            TitleOfQuestionLabel.Name = "TitleOfQuestionLabel";
            TitleOfQuestionLabel.Size = new Size(94, 15);
            TitleOfQuestionLabel.TabIndex = 0;
            TitleOfQuestionLabel.Text = "Title of Question";
            // 
            // TitleOfQuestionTextBox
            // 
            TitleOfQuestionTextBox.Location = new Point(141, 3);
            TitleOfQuestionTextBox.Name = "TitleOfQuestionTextBox";
            TitleOfQuestionTextBox.Size = new Size(100, 23);
            TitleOfQuestionTextBox.TabIndex = 1;
            // 
            // AddQuestion
            // 
            AddQuestion.Location = new Point(3, 373);
            AddQuestion.Name = "AddQuestion";
            AddQuestion.Size = new Size(132, 23);
            AddQuestion.TabIndex = 20;
            AddQuestion.Text = "Add Question";
            AddQuestion.UseVisualStyleBackColor = true;
            AddQuestion.Click += CreateQuiz_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 370);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 21;
            label5.Text = "label5";
            // 
            // CreateQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1116, 761);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateQuizForm";
            Text = "CreateQuizForm";
            Load += CreateQuizForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ThemeLabel.ResumeLayout(false);
            ThemeLabel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private TextBox URLQuizTextBox;
        private Label label2;
        private TextBox DescriptioQuizTextBox;
        private Label label1;
        private TextBox TitleOfQuizTextBox;
        private OpenFileDialog openFileDialog1;
        private Button CreateQuiz;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel ThemeLabel;
        private Label ThemeOfQuestionTextBox;
        private Label CorrectOptionLabel;
        private Label OptionDLabel;
        private Label OptionCLabel;
        private Label OptionBLabel;
        private Label OptionALabel;
        private Label AuxiliarImageLabel;
        private Label DescriptionQuestionLabel;
        private Label TitleOfQuestionLabel;
        private Label DifficultLabel;
        private TextBox CorrectOptionTextBox;
        private TextBox OptionDTextBox;
        private TextBox OptionCTextBox;
        private TextBox OptionBTextBox;
        private TextBox OptionATextBox;
        private TextBox AuxiliarImageTextBox;
        private TextBox DescriptionQuestionTextBox;
        private TextBox TitleOfQuestionTextBox;
        private Button AddQuestion;
        private Label label5;
        private ComboBox ThemeQuizComboBox;
        private ComboBox DifficultyComboBox;
        private ComboBox ThemeQuestionComboBox;
    }
}