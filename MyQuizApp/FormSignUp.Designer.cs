namespace MyQuizApp
{
    partial class FormSignUp
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
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtConfirm2 = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblConfirmPW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(263, 47);
            this.txtName2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName2.Multiline = true;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(264, 30);
            this.txtName2.TabIndex = 0;
            this.txtName2.TextChanged += new System.EventHandler(this.txtName2_TextChanged);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(266, 136);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(261, 22);
            this.txtPassword2.TabIndex = 1;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // txtConfirm2
            // 
            this.txtConfirm2.Location = new System.Drawing.Point(266, 93);
            this.txtConfirm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirm2.Name = "txtConfirm2";
            this.txtConfirm2.PasswordChar = '*';
            this.txtConfirm2.Size = new System.Drawing.Size(261, 22);
            this.txtConfirm2.TabIndex = 2;
            this.txtConfirm2.UseSystemPasswordChar = true;
            this.txtConfirm2.TextChanged += new System.EventHandler(this.txtConfirm2_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 13.14783F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(436, 233);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(122, 52);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign up ";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPassWord.Font = new System.Drawing.Font("Segoe UI", 13.14783F, System.Drawing.FontStyle.Bold);
            this.lblPassWord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPassWord.Location = new System.Drawing.Point(12, 93);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(130, 30);
            this.lblPassWord.TabIndex = 4;
            this.lblPassWord.Text = "Password : ";
            this.lblPassWord.Click += new System.EventHandler(this.lblPassWord_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.14783F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(12, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "User Name : ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblConfirmPW
            // 
            this.lblConfirmPW.AutoSize = true;
            this.lblConfirmPW.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblConfirmPW.Font = new System.Drawing.Font("Segoe UI", 13.14783F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPW.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConfirmPW.Location = new System.Drawing.Point(12, 136);
            this.lblConfirmPW.Name = "lblConfirmPW";
            this.lblConfirmPW.Size = new System.Drawing.Size(219, 30);
            this.lblConfirmPW.TabIndex = 6;
            this.lblConfirmPW.Text = "Confirm Password : ";
            this.lblConfirmPW.Click += new System.EventHandler(this.lblConfirmPW_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 296);
            this.Controls.Add(this.lblConfirmPW);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtConfirm2);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtName2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSignUp";
            this.Text = "Sign_Up";
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtConfirm2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblConfirmPW;
    }
}

        