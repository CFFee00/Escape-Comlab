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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnStart = new Button();
            btnOption = new Button();
            btnExit = new Button();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Papyrus", 65.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(745, 139);
            label1.TabIndex = 0;
            label1.Text = "Escape ComLab";
            label1.Click += label1_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(373, 224);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 36);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.Transparent;
            btnOption.FlatAppearance.BorderSize = 0;
            btnOption.FlatStyle = FlatStyle.Flat;
            btnOption.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOption.Location = new Point(366, 286);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(97, 35);
            btnOption.TabIndex = 3;
            btnOption.Text = "Option";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(373, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 38);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAbout.Location = new Point(12, 524);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(94, 36);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 572);
            Controls.Add(btnAbout);
            Controls.Add(btnExit);
            Controls.Add(btnOption);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Font = new Font("Papyrus", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape Comlab";
            Load += Form1_Load;
            Click += btnOption_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnOption;
        private Button btnExit;
        private Button btnAbout;
    }
}
