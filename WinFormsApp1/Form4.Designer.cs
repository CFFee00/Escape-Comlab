namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lblTitle = new Label();
            lblGameName = new Label();
            label1 = new Label();
            lblDescription = new Label();
            lblObjective = new Label();
            lblObjectiveText = new Label();
            lblDevelopers = new Label();
            lblMembers = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Papyrus", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(216, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ABOUT THE GAME";
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.BackColor = Color.Transparent;
            lblGameName.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGameName.ForeColor = Color.Transparent;
            lblGameName.Location = new Point(287, 84);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(258, 31);
            lblGameName.TabIndex = 1;
            lblGameName.Text = "ESCAPE COMLAB";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 186);
            label1.Name = "label1";
            label1.Size = new Size(330, 191);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Papyrus", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Transparent;
            lblDescription.Location = new Point(42, 140);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(256, 42);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Game description: ";
            // 
            // lblObjective
            // 
            lblObjective.AutoSize = true;
            lblObjective.BackColor = Color.Transparent;
            lblObjective.Font = new Font("Papyrus", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblObjective.ForeColor = Color.White;
            lblObjective.Location = new Point(477, 140);
            lblObjective.Name = "lblObjective";
            lblObjective.Size = new Size(230, 42);
            lblObjective.TabIndex = 4;
            lblObjective.Text = "Game Objective";
            lblObjective.Click += lblObjective_Click;
            // 
            // lblObjectiveText
            // 
            lblObjectiveText.BackColor = Color.Transparent;
            lblObjectiveText.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblObjectiveText.ForeColor = Color.Transparent;
            lblObjectiveText.Location = new Point(477, 186);
            lblObjectiveText.Name = "lblObjectiveText";
            lblObjectiveText.Size = new Size(305, 209);
            lblObjectiveText.TabIndex = 5;
            lblObjectiveText.Text = "• Answer the questions correctly.\n\n• Test your knowledge and problem-solving skills.\n\n• Complete the challenges.\n\n• Escape the computer laboratory!";
            // 
            // lblDevelopers
            // 
            lblDevelopers.AutoSize = true;
            lblDevelopers.BackColor = Color.Transparent;
            lblDevelopers.Font = new Font("Papyrus", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDevelopers.ForeColor = Color.Transparent;
            lblDevelopers.Location = new Point(124, 410);
            lblDevelopers.Name = "lblDevelopers";
            lblDevelopers.Size = new Size(190, 42);
            lblDevelopers.TabIndex = 6;
            lblDevelopers.Text = "Develop By: ";
            // 
            // lblMembers
            // 
            lblMembers.BackColor = Color.Transparent;
            lblMembers.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMembers.ForeColor = Color.Transparent;
            lblMembers.Location = new Point(320, 421);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(186, 131);
            lblMembers.TabIndex = 7;
            lblMembers.Text = "CJ Garay\n\nCarl John Liwanagan\n\nJessa Miranda";
            lblMembers.Click += lblMembers_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(699, 517);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 43);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Neon_Hacker_in_the_Midnight_ComLab;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 572);
            Controls.Add(btnBack);
            Controls.Add(lblMembers);
            Controls.Add(lblDevelopers);
            Controls.Add(lblObjectiveText);
            Controls.Add(lblObjective);
            Controls.Add(label1);
            Controls.Add(lblDescription);
            Controls.Add(lblGameName);
            Controls.Add(lblTitle);
            Font = new Font("Papyrus", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape ComLab";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblGameName;
        private Label label1;
        private Label lblDescription;
        private Label lblObjective;
        private Label lblObjectiveText;
        private Label lblDevelopers;
        private Label lblMembers;
        private Button btnBack;
    }
}