
namespace MyFirstWinFormsApp
{
    partial class Result
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
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.resultText = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.resultWord = new System.Windows.Forms.Label();
            this.goHomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultPictureBox.Location = new System.Drawing.Point(304, 55);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(304, 239);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 0;
            this.resultPictureBox.TabStop = false;
            // 
            // resultText
            // 
            this.resultText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultText.Location = new System.Drawing.Point(291, 341);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(338, 37);
            this.resultText.TabIndex = 1;
            this.resultText.Text = "label1";
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play.BackColor = System.Drawing.Color.Teal;
            this.play.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play.Location = new System.Drawing.Point(304, 391);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(119, 45);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // quit
            // 
            this.quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quit.BackColor = System.Drawing.Color.Firebrick;
            this.quit.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quit.Location = new System.Drawing.Point(489, 391);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(119, 45);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // resultWord
            // 
            this.resultWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultWord.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultWord.Location = new System.Drawing.Point(304, 297);
            this.resultWord.Name = "resultWord";
            this.resultWord.Size = new System.Drawing.Size(304, 44);
            this.resultWord.TabIndex = 4;
            this.resultWord.Text = "label1";
            this.resultWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goHomeBtn
            // 
            this.goHomeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goHomeBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.goHomeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goHomeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goHomeBtn.Location = new System.Drawing.Point(398, 454);
            this.goHomeBtn.Name = "goHomeBtn";
            this.goHomeBtn.Size = new System.Drawing.Size(119, 45);
            this.goHomeBtn.TabIndex = 5;
            this.goHomeBtn.Text = "Home";
            this.goHomeBtn.UseVisualStyleBackColor = false;
            this.goHomeBtn.Click += new System.EventHandler(this.goHomeBtn_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.goHomeBtn);
            this.Controls.Add(this.resultWord);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.play);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.resultPictureBox);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label resultWord;
        private System.Windows.Forms.Button goHomeBtn;
    }
}