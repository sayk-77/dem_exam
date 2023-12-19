namespace DemExam
{
    partial class Authorization
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
            this.title = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.lableUserLogin = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(299, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(185, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Авторизация";
            // 
            // UserPassword
            // 
            this.UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPassword.Location = new System.Drawing.Point(318, 217);
            this.UserPassword.Multiline = true;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(166, 30);
            this.UserPassword.TabIndex = 1;
            // 
            // lableUserLogin
            // 
            this.lableUserLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableUserLogin.Location = new System.Drawing.Point(352, 107);
            this.lableUserLogin.Name = "lableUserLogin";
            this.lableUserLogin.Size = new System.Drawing.Size(97, 23);
            this.lableUserLogin.TabIndex = 2;
            this.lableUserLogin.Text = "Ваш логин:";
            // 
            // UserLogin
            // 
            this.UserLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserLogin.Location = new System.Drawing.Point(318, 133);
            this.UserLogin.Multiline = true;
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(166, 30);
            this.UserLogin.TabIndex = 1;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserPassword.Location = new System.Drawing.Point(350, 191);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(104, 23);
            this.labelUserPassword.TabIndex = 2;
            this.labelUserPassword.Text = "Ваш пароль:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(342, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginGuest
            // 
            this.btnLoginGuest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginGuest.Location = new System.Drawing.Point(331, 317);
            this.btnLoginGuest.Name = "btnLoginGuest";
            this.btnLoginGuest.Size = new System.Drawing.Size(150, 30);
            this.btnLoginGuest.TabIndex = 3;
            this.btnLoginGuest.Text = "Войти как гость";
            this.btnLoginGuest.UseVisualStyleBackColor = true;
            this.btnLoginGuest.Click += new System.EventHandler(this.btnLoginGuest_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginGuest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.lableUserLogin);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLoginGuest;

        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label labelUserPassword;

        private System.Windows.Forms.Label lableUserLogin;

        private System.Windows.Forms.TextBox UserLogin;

        private System.Windows.Forms.Label title;

        #endregion
    }
}