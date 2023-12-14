using System.ComponentModel;

namespace DemExam
{
    partial class Captcha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pictureCaptcha = new System.Windows.Forms.PictureBox();
            this.sendCaptcha = new System.Windows.Forms.Button();
            this.userTextCaptcha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCaptcha
            // 
            this.pictureCaptcha.Location = new System.Drawing.Point(43, 12);
            this.pictureCaptcha.Name = "pictureCaptcha";
            this.pictureCaptcha.Size = new System.Drawing.Size(200, 50);
            this.pictureCaptcha.TabIndex = 0;
            this.pictureCaptcha.TabStop = false;
            // 
            // sendCaptcha
            // 
            this.sendCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendCaptcha.Location = new System.Drawing.Point(82, 119);
            this.sendCaptcha.Name = "sendCaptcha";
            this.sendCaptcha.Size = new System.Drawing.Size(120, 30);
            this.sendCaptcha.TabIndex = 1;
            this.sendCaptcha.Text = "Отправить";
            this.sendCaptcha.UseVisualStyleBackColor = true;
            this.sendCaptcha.Click += new System.EventHandler(this.sendCaptcha_Click);
            // 
            // userTextCaptcha
            // 
            this.userTextCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTextCaptcha.Location = new System.Drawing.Point(76, 75);
            this.userTextCaptcha.MaxLength = 5;
            this.userTextCaptcha.Multiline = true;
            this.userTextCaptcha.Name = "userTextCaptcha";
            this.userTextCaptcha.Size = new System.Drawing.Size(133, 29);
            this.userTextCaptcha.TabIndex = 2;
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.userTextCaptcha);
            this.Controls.Add(this.sendCaptcha);
            this.Controls.Add(this.pictureCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox userTextCaptcha;

        private System.Windows.Forms.Button sendCaptcha;

        private System.Windows.Forms.PictureBox pictureCaptcha;

        #endregion
    }
}