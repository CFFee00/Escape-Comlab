namespace WinFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            lblDifficulty = new Label();
            lblTimer = new Label();
            lblQuestionNumber = new Label();
            lblQuestion = new Label();
            btnAnswerA = new Button();
            btnAnswerB = new Button();
            btnAnswerC = new Button();
            btnAnswerD = new Button();
            btnHint = new Button();
            btnPause = new Button();
            btnBack = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.BackColor = Color.LightYellow;
            lblDifficulty.FlatStyle = FlatStyle.Flat;
            lblDifficulty.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(12, 9);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(124, 21);
            lblDifficulty.TabIndex = 0;
            lblDifficulty.Text = "Difficulty: Easy";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.LightYellow;
            lblTimer.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Black;
            lblTimer.Location = new Point(381, 42);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(82, 21);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "Time: 4:00";
            lblTimer.Click += lblTimer_Click;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.BackColor = Color.LightYellow;
            lblQuestionNumber.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuestionNumber.Location = new Point(364, 11);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(113, 21);
            lblQuestionNumber.TabIndex = 2;
            lblQuestionNumber.Text = "Question 1 / 5";
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.LightYellow;
            lblQuestion.Font = new Font("Papyrus", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(201, 157);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(443, 146);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "What does CPU stand for?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnswerA
            // 
            btnAnswerA.BackColor = Color.LightYellow;
            btnAnswerA.FlatAppearance.BorderSize = 0;
            btnAnswerA.FlatStyle = FlatStyle.Flat;
            btnAnswerA.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnswerA.Location = new Point(201, 357);
            btnAnswerA.Name = "btnAnswerA";
            btnAnswerA.Size = new Size(443, 33);
            btnAnswerA.TabIndex = 4;
            btnAnswerA.Text = "A. Central Processing Unit";
            btnAnswerA.UseVisualStyleBackColor = false;
            // 
            // btnAnswerB
            // 
            btnAnswerB.BackColor = Color.LightYellow;
            btnAnswerB.FlatAppearance.BorderSize = 0;
            btnAnswerB.FlatStyle = FlatStyle.Flat;
            btnAnswerB.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnswerB.Location = new Point(201, 396);
            btnAnswerB.Name = "btnAnswerB";
            btnAnswerB.Size = new Size(443, 33);
            btnAnswerB.TabIndex = 5;
            btnAnswerB.Text = "B. Computer Personal Unit";
            btnAnswerB.UseVisualStyleBackColor = false;
            // 
            // btnAnswerC
            // 
            btnAnswerC.BackColor = Color.LightYellow;
            btnAnswerC.FlatAppearance.BorderSize = 0;
            btnAnswerC.FlatStyle = FlatStyle.Flat;
            btnAnswerC.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnswerC.Location = new Point(201, 435);
            btnAnswerC.Name = "btnAnswerC";
            btnAnswerC.Size = new Size(443, 33);
            btnAnswerC.TabIndex = 6;
            btnAnswerC.Text = "C. Central Program Utility";
            btnAnswerC.UseVisualStyleBackColor = false;
            // 
            // btnAnswerD
            // 
            btnAnswerD.BackColor = Color.LightYellow;
            btnAnswerD.FlatAppearance.BorderSize = 0;
            btnAnswerD.FlatStyle = FlatStyle.Flat;
            btnAnswerD.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnswerD.Location = new Point(201, 474);
            btnAnswerD.Name = "btnAnswerD";
            btnAnswerD.Size = new Size(443, 33);
            btnAnswerD.TabIndex = 7;
            btnAnswerD.Text = "D. Control Processing User";
            btnAnswerD.UseVisualStyleBackColor = false;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.LightYellow;
            btnHint.Location = new Point(630, 12);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(75, 26);
            btnHint.TabIndex = 8;
            btnHint.Text = "Hint";
            btnHint.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.LightYellow;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Location = new Point(713, 12);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(87, 26);
            btnPause.TabIndex = 9;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightYellow;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Papyrus", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(725, 44);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 25);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 240;
            gameTimer.Tick += lblTimer_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources._911686030_1108018942284669_6784569145412171582_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 572);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBack);
            Controls.Add(btnPause);
            Controls.Add(btnHint);
            Controls.Add(btnAnswerD);
            Controls.Add(btnAnswerC);
            Controls.Add(btnAnswerB);
            Controls.Add(btnAnswerA);
            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionNumber);
            Controls.Add(lblTimer);
            Controls.Add(lblDifficulty);
            Font = new Font("Papyrus", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape Comlab";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDifficulty;
        private Label lblTimer;
        private Label lblQuestionNumber;
        private Label lblQuestion;
        private Button btnAnswerA;
        private Button btnAnswerB;
        private Button btnAnswerC;
        private Button btnAnswerD;
        private Button btnHint;
        private Button btnPause;
        private Button btnBack;
        private System.Windows.Forms.Timer gameTimer;
        private DateTimePicker dateTimePicker1;
    }
}