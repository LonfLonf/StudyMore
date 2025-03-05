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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuizForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            ThemeQuizComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            DescriptioQuizTextBox = new TextBox();
            label1 = new Label();
            TitleOfQuizTextBox = new TextBox();
            CreateQuiz = new Button();
            label6 = new Label();
            SelectimageQuizButton = new Button();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            ThemeLabel = new TableLayoutPanel();
            ImagePathQuestion = new Button();
            DifficultyComboBox = new ComboBox();
            ThemeQuestionComboBox = new ComboBox();
            DifficultLabel = new Label();
            ThemeOfQuestionTextBox = new Label();
            CorrectOptionLabel = new Label();
            OptionDLabel = new Label();
            OptionDTextBox = new TextBox();
            OptionCLabel = new Label();
            OptionCTextBox = new TextBox();
            OptionBLabel = new Label();
            OptionBTextBox = new TextBox();
            OptionALabel = new Label();
            OptionATextBox = new TextBox();
            AuxiliarImageLabel = new Label();
            DescriptionQuestionLabel = new Label();
            DescriptionQuestionTextBox = new TextBox();
            TitleOfQuestionLabel = new Label();
            TitleOfQuestionTextBox = new TextBox();
            AddQuestion = new Button();
            label5 = new Label();
            label7 = new Label();
            CorrectionOptionComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ThemeLabel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0489979F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.951004F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Controls.Add(ThemeQuizComboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(DescriptioQuizTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(TitleOfQuizTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(CreateQuiz, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(SelectimageQuizButton, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(649, 180);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // ThemeQuizComboBox
            // 
            ThemeQuizComboBox.FormattingEnabled = true;
            ThemeQuizComboBox.Items.AddRange(new object[] { " Mathematics", " History", " ComputerScience", " Philosophy", " Programming", " MalwareDevelopment", " CyberSecurity", " OtherStuff" });
            ThemeQuizComboBox.Location = new Point(97, 111);
            ThemeQuizComboBox.Name = "ThemeQuizComboBox";
            ThemeQuizComboBox.Size = new Size(219, 23);
            ThemeQuizComboBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(5, 108);
            label4.Name = "label4";
            label4.Size = new Size(86, 36);
            label4.TabIndex = 6;
            label4.Text = "Theme Of Quiz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(27, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 36);
            label3.TabIndex = 4;
            label3.Text = "URL Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(24, 36);
            label2.Name = "label2";
            label2.Size = new Size(67, 36);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // DescriptioQuizTextBox
            // 
            DescriptioQuizTextBox.Location = new Point(97, 39);
            DescriptioQuizTextBox.Name = "DescriptioQuizTextBox";
            DescriptioQuizTextBox.Size = new Size(219, 23);
            DescriptioQuizTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(19, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 36);
            label1.TabIndex = 0;
            label1.Text = "Title Of Quiz";
            // 
            // TitleOfQuizTextBox
            // 
            TitleOfQuizTextBox.Location = new Point(97, 3);
            TitleOfQuizTextBox.Name = "TitleOfQuizTextBox";
            TitleOfQuizTextBox.Size = new Size(219, 23);
            TitleOfQuizTextBox.TabIndex = 1;
            // 
            // CreateQuiz
            // 
            CreateQuiz.Dock = DockStyle.Right;
            CreateQuiz.Location = new Point(3, 147);
            CreateQuiz.Name = "CreateQuiz";
            CreateQuiz.Size = new Size(88, 30);
            CreateQuiz.TabIndex = 8;
            CreateQuiz.Text = "Create Quiz";
            CreateQuiz.UseVisualStyleBackColor = true;
            CreateQuiz.Click += CreateQuiz_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(431, 72);
            label6.Name = "label6";
            label6.Size = new Size(215, 36);
            label6.TabIndex = 12;
            // 
            // SelectimageQuizButton
            // 
            SelectimageQuizButton.Location = new Point(97, 75);
            SelectimageQuizButton.Name = "SelectimageQuizButton";
            SelectimageQuizButton.Size = new Size(219, 23);
            SelectimageQuizButton.TabIndex = 11;
            SelectimageQuizButton.Text = "Select Image For Quiz";
            SelectimageQuizButton.UseVisualStyleBackColor = true;
            SelectimageQuizButton.Click += SelectimageQuizButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 144);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 13;
            label8.Text = "label8";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // ThemeLabel
            // 
            ThemeLabel.BackColor = SystemColors.Control;
            ThemeLabel.ColumnCount = 3;
            ThemeLabel.ColumnStyles.Add(new ColumnStyle());
            ThemeLabel.ColumnStyles.Add(new ColumnStyle());
            ThemeLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ThemeLabel.Controls.Add(ImagePathQuestion, 1, 2);
            ThemeLabel.Controls.Add(DifficultyComboBox, 1, 9);
            ThemeLabel.Controls.Add(ThemeQuestionComboBox, 1, 8);
            ThemeLabel.Controls.Add(DifficultLabel, 0, 9);
            ThemeLabel.Controls.Add(ThemeOfQuestionTextBox, 0, 8);
            ThemeLabel.Controls.Add(CorrectOptionLabel, 0, 7);
            ThemeLabel.Controls.Add(OptionDLabel, 0, 6);
            ThemeLabel.Controls.Add(OptionDTextBox, 1, 6);
            ThemeLabel.Controls.Add(OptionCLabel, 0, 5);
            ThemeLabel.Controls.Add(OptionCTextBox, 1, 5);
            ThemeLabel.Controls.Add(OptionBLabel, 0, 4);
            ThemeLabel.Controls.Add(OptionBTextBox, 1, 4);
            ThemeLabel.Controls.Add(OptionALabel, 0, 3);
            ThemeLabel.Controls.Add(OptionATextBox, 1, 3);
            ThemeLabel.Controls.Add(AuxiliarImageLabel, 0, 2);
            ThemeLabel.Controls.Add(DescriptionQuestionLabel, 0, 1);
            ThemeLabel.Controls.Add(DescriptionQuestionTextBox, 1, 1);
            ThemeLabel.Controls.Add(TitleOfQuestionLabel, 0, 0);
            ThemeLabel.Controls.Add(TitleOfQuestionTextBox, 1, 0);
            ThemeLabel.Controls.Add(AddQuestion, 0, 10);
            ThemeLabel.Controls.Add(label5, 1, 10);
            ThemeLabel.Controls.Add(label7, 2, 2);
            ThemeLabel.Controls.Add(CorrectionOptionComboBox, 1, 7);
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
            ThemeLabel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            ThemeLabel.Size = new Size(651, 494);
            ThemeLabel.TabIndex = 0;
            // 
            // ImagePathQuestion
            // 
            ImagePathQuestion.Location = new Point(141, 95);
            ImagePathQuestion.Name = "ImagePathQuestion";
            ImagePathQuestion.Size = new Size(186, 23);
            ImagePathQuestion.TabIndex = 24;
            ImagePathQuestion.Text = "Select Image For Question";
            ImagePathQuestion.UseVisualStyleBackColor = true;
            ImagePathQuestion.Click += ImagePathQuestion_Click;
            // 
            // DifficultyComboBox
            // 
            DifficultyComboBox.FormattingEnabled = true;
            DifficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Master" });
            DifficultyComboBox.Location = new Point(141, 417);
            DifficultyComboBox.Name = "DifficultyComboBox";
            DifficultyComboBox.Size = new Size(186, 23);
            DifficultyComboBox.TabIndex = 23;
            // 
            // ThemeQuestionComboBox
            // 
            ThemeQuestionComboBox.FormattingEnabled = true;
            ThemeQuestionComboBox.Items.AddRange(new object[] { " Mathematics", " History", " ComputerScience", " Philosophy", " Programming", " MalwareDevelopment", " CyberSecurity", " OtherStuff" });
            ThemeQuestionComboBox.Location = new Point(141, 371);
            ThemeQuestionComboBox.Name = "ThemeQuestionComboBox";
            ThemeQuestionComboBox.Size = new Size(186, 23);
            ThemeQuestionComboBox.TabIndex = 22;
            // 
            // DifficultLabel
            // 
            DifficultLabel.AutoSize = true;
            DifficultLabel.Location = new Point(3, 414);
            DifficultLabel.Name = "DifficultLabel";
            DifficultLabel.Size = new Size(116, 15);
            DifficultLabel.TabIndex = 18;
            DifficultLabel.Text = "Difficult Of Question";
            // 
            // ThemeOfQuestionTextBox
            // 
            ThemeOfQuestionTextBox.AutoSize = true;
            ThemeOfQuestionTextBox.Location = new Point(3, 368);
            ThemeOfQuestionTextBox.Name = "ThemeOfQuestionTextBox";
            ThemeOfQuestionTextBox.Size = new Size(104, 15);
            ThemeOfQuestionTextBox.TabIndex = 16;
            ThemeOfQuestionTextBox.Text = "ThemeOfQuestion";
            // 
            // CorrectOptionLabel
            // 
            CorrectOptionLabel.AutoSize = true;
            CorrectOptionLabel.Location = new Point(3, 322);
            CorrectOptionLabel.Name = "CorrectOptionLabel";
            CorrectOptionLabel.Size = new Size(83, 15);
            CorrectOptionLabel.TabIndex = 14;
            CorrectOptionLabel.Text = "CorrectOption";
            // 
            // OptionDLabel
            // 
            OptionDLabel.AutoSize = true;
            OptionDLabel.Location = new Point(3, 276);
            OptionDLabel.Name = "OptionDLabel";
            OptionDLabel.Size = new Size(57, 15);
            OptionDLabel.TabIndex = 12;
            OptionDLabel.Text = "Option_D";
            // 
            // OptionDTextBox
            // 
            OptionDTextBox.Location = new Point(141, 279);
            OptionDTextBox.Name = "OptionDTextBox";
            OptionDTextBox.Size = new Size(186, 23);
            OptionDTextBox.TabIndex = 13;
            // 
            // OptionCLabel
            // 
            OptionCLabel.AutoSize = true;
            OptionCLabel.Location = new Point(3, 230);
            OptionCLabel.Name = "OptionCLabel";
            OptionCLabel.Size = new Size(57, 15);
            OptionCLabel.TabIndex = 10;
            OptionCLabel.Text = "Option_C";
            // 
            // OptionCTextBox
            // 
            OptionCTextBox.Location = new Point(141, 233);
            OptionCTextBox.Name = "OptionCTextBox";
            OptionCTextBox.Size = new Size(186, 23);
            OptionCTextBox.TabIndex = 11;
            // 
            // OptionBLabel
            // 
            OptionBLabel.AutoSize = true;
            OptionBLabel.Location = new Point(3, 184);
            OptionBLabel.Name = "OptionBLabel";
            OptionBLabel.Size = new Size(56, 15);
            OptionBLabel.TabIndex = 8;
            OptionBLabel.Text = "Option_B";
            // 
            // OptionBTextBox
            // 
            OptionBTextBox.Location = new Point(141, 187);
            OptionBTextBox.Name = "OptionBTextBox";
            OptionBTextBox.Size = new Size(186, 23);
            OptionBTextBox.TabIndex = 9;
            // 
            // OptionALabel
            // 
            OptionALabel.AutoSize = true;
            OptionALabel.Location = new Point(3, 138);
            OptionALabel.Name = "OptionALabel";
            OptionALabel.Size = new Size(57, 15);
            OptionALabel.TabIndex = 6;
            OptionALabel.Text = "Option_A";
            // 
            // OptionATextBox
            // 
            OptionATextBox.Location = new Point(141, 141);
            OptionATextBox.Name = "OptionATextBox";
            OptionATextBox.Size = new Size(186, 23);
            OptionATextBox.TabIndex = 7;
            // 
            // AuxiliarImageLabel
            // 
            AuxiliarImageLabel.AutoSize = true;
            AuxiliarImageLabel.Location = new Point(3, 92);
            AuxiliarImageLabel.Name = "AuxiliarImageLabel";
            AuxiliarImageLabel.Size = new Size(80, 15);
            AuxiliarImageLabel.TabIndex = 4;
            AuxiliarImageLabel.Text = "AuxiliarImage";
            // 
            // DescriptionQuestionLabel
            // 
            DescriptionQuestionLabel.AutoSize = true;
            DescriptionQuestionLabel.Location = new Point(3, 46);
            DescriptionQuestionLabel.Name = "DescriptionQuestionLabel";
            DescriptionQuestionLabel.Size = new Size(132, 15);
            DescriptionQuestionLabel.TabIndex = 2;
            DescriptionQuestionLabel.Text = "Description of Question";
            // 
            // DescriptionQuestionTextBox
            // 
            DescriptionQuestionTextBox.Location = new Point(141, 49);
            DescriptionQuestionTextBox.Name = "DescriptionQuestionTextBox";
            DescriptionQuestionTextBox.Size = new Size(186, 23);
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
            TitleOfQuestionTextBox.Size = new Size(186, 23);
            TitleOfQuestionTextBox.TabIndex = 1;
            // 
            // AddQuestion
            // 
            AddQuestion.Location = new Point(3, 463);
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
            label5.Location = new Point(141, 460);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 92);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 25;
            // 
            // CorrectionOptionComboBox
            // 
            CorrectionOptionComboBox.FormattingEnabled = true;
            CorrectionOptionComboBox.Items.AddRange(new object[] { "A", "B", "C", "D" });
            CorrectionOptionComboBox.Location = new Point(141, 325);
            CorrectionOptionComboBox.Name = "CorrectionOptionComboBox";
            CorrectionOptionComboBox.Size = new Size(186, 23);
            CorrectionOptionComboBox.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ThemeLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 235);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1116, 596);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(6, 187);
            label9.Name = "label9";
            label9.Size = new Size(292, 47);
            label9.TabIndex = 16;
            label9.Text = "First Create a Question after create a Quiz\r\nThis form is Ugly\r\nIn Question put a Question A and B, it's required BRO!\r\n";
            // 
            // CreateQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 731);
            Controls.Add(label9);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateQuizForm";
            Text = "CreateQuizForm";
            Load += CreateQuizForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ThemeLabel.ResumeLayout(false);
            ThemeLabel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox DescriptioQuizTextBox;
        private Label label1;
        private TextBox TitleOfQuizTextBox;
        private OpenFileDialog openFileDialog1;
        private Button CreateQuiz;
        private ComboBox ThemeQuizComboBox;
        private Button SelectimageQuizButton;
        private OpenFileDialog openFileDialog2;
        private Label label6;
        private TableLayoutPanel ThemeLabel;
        private Button ImagePathQuestion;
        private ComboBox DifficultyComboBox;
        private ComboBox ThemeQuestionComboBox;
        private Label DifficultLabel;
        private Label ThemeOfQuestionTextBox;
        private Label CorrectOptionLabel;
        private Label OptionDLabel;
        private TextBox OptionDTextBox;
        private Label OptionCLabel;
        private TextBox OptionCTextBox;
        private Label OptionBLabel;
        private TextBox OptionBTextBox;
        private Label OptionALabel;
        private TextBox OptionATextBox;
        private Label AuxiliarImageLabel;
        private Label DescriptionQuestionLabel;
        private TextBox DescriptionQuestionTextBox;
        private Label TitleOfQuestionLabel;
        private TextBox TitleOfQuestionTextBox;
        private Button AddQuestion;
        private Label label5;
        private Label label7;
        private ComboBox CorrectionOptionComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label9;
        private Label label8;
    }
}