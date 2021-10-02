
namespace MyFirstWinFormsApp
{
    partial class Preload
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
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twoPlayersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yesBtn.AutoSize = true;
            this.yesBtn.BackColor = System.Drawing.Color.Teal;
            this.yesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yesBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yesBtn.Location = new System.Drawing.Point(272, 339);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yesBtn.Size = new System.Drawing.Size(151, 51);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noBtn.BackColor = System.Drawing.Color.Firebrick;
            this.noBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noBtn.Location = new System.Drawing.Point(476, 339);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(149, 51);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::MyFirstWinFormsApp.Properties.Resources.hangmanBg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(272, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(272, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wanna Play Hangman?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoPlayersBtn
            // 
            this.twoPlayersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoPlayersBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.twoPlayersBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoPlayersBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.twoPlayersBtn.Location = new System.Drawing.Point(381, 406);
            this.twoPlayersBtn.Name = "twoPlayersBtn";
            this.twoPlayersBtn.Size = new System.Drawing.Size(138, 49);
            this.twoPlayersBtn.TabIndex = 4;
            this.twoPlayersBtn.Text = "2 Players";
            this.twoPlayersBtn.UseVisualStyleBackColor = false;
            this.twoPlayersBtn.Click += new System.EventHandler(this.twoPlayers_Click);
            // 
            // Preload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 492);
            this.Controls.Add(this.twoPlayersBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Preload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preload";
            this.Load += new System.EventHandler(this.Preload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button twoPlayersBtn;
    }
}

