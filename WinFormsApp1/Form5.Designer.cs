namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lblTitle = new Label();
            btnEasy = new Button();
            btnNormal = new Button();
            btnHard = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Papyrus", 65.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(48, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(715, 139);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Select Difficulty";
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.Transparent;
            btnEasy.FlatAppearance.BorderSize = 0;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEasy.ForeColor = Color.White;
            btnEasy.Location = new Point(368, 223);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(129, 43);
            btnEasy.TabIndex = 1;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnNormal
            // 
            btnNormal.BackColor = Color.Transparent;
            btnNormal.FlatAppearance.BorderSize = 0;
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnNormal.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNormal.ForeColor = Color.White;
            btnNormal.Location = new Point(359, 272);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(140, 42);
            btnNormal.TabIndex = 2;
            btnNormal.Text = "Normal";
            btnNormal.UseVisualStyleBackColor = false;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.Transparent;
            btnHard.FlatAppearance.BorderSize = 0;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHard.ForeColor = Color.White;
            btnHard.Location = new Point(359, 311);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(140, 47);
            btnHard.TabIndex = 3;
            btnHard.Text = "Hard";
            btnHard.UseVisualStyleBackColor = false;
            btnHard.Click += btnHard_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(368, 441);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 572);
            Controls.Add(btnBack);
            Controls.Add(btnHard);
            Controls.Add(btnNormal);
            Controls.Add(btnEasy);
            Controls.Add(lblTitle);
            Font = new Font("Papyrus", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Red;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape ComLab";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnEasy;
        private Button btnNormal;
        private Button btnHard;
        private Button btnBack;
    }
}