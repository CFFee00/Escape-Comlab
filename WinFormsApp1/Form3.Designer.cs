namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblTitle = new Label();
            lblMusic = new Label();
            lblSFX = new Label();
            trackMusic = new TrackBar();
            trackSfx = new TrackBar();
            btnBack = new Label();
            ((System.ComponentModel.ISupportInitialize)trackMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackSfx).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Papyrus", 65.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(214, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 137);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Options";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.BackColor = Color.Transparent;
            lblMusic.FlatStyle = FlatStyle.Flat;
            lblMusic.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMusic.Location = new Point(174, 249);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(74, 31);
            lblMusic.TabIndex = 1;
            lblMusic.Text = "Music";
            // 
            // lblSFX
            // 
            lblSFX.AutoSize = true;
            lblSFX.BackColor = Color.Transparent;
            lblSFX.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSFX.Location = new Point(174, 315);
            lblSFX.Name = "lblSFX";
            lblSFX.Size = new Size(57, 31);
            lblSFX.TabIndex = 2;
            lblSFX.Text = "Sfx ";
            // 
            // trackMusic
            // 
            trackMusic.Location = new Point(254, 249);
            trackMusic.Maximum = 100;
            trackMusic.Name = "trackMusic";
            trackMusic.Size = new Size(350, 45);
            trackMusic.TabIndex = 3;
            trackMusic.TickFrequency = 10;
            trackMusic.Value = 70;
            // 
            // trackSfx
            // 
            trackSfx.Location = new Point(254, 315);
            trackSfx.Maximum = 100;
            trackSfx.Name = "trackSfx";
            trackSfx.Size = new Size(350, 45);
            trackSfx.TabIndex = 4;
            trackSfx.TickFrequency = 10;
            trackSfx.Value = 70;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.Transparent;
            btnBack.Font = new Font("Papyrus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(374, 437);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 31);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MArsu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 572);
            Controls.Add(btnBack);
            Controls.Add(trackSfx);
            Controls.Add(trackMusic);
            Controls.Add(lblSFX);
            Controls.Add(lblMusic);
            Controls.Add(lblTitle);
            Font = new Font("Papyrus", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape ComLab";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)trackMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackSfx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMusic;
        private Label lblSFX;
        private TrackBar trackMusic;
        private TrackBar trackSfx;
        private Label btnBack;
    }
}