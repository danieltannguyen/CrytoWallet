namespace CrytoWallet
{
    partial class frmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserError = new System.Windows.Forms.Label();
            this.textEmailError = new System.Windows.Forms.Label();
            this.txtPasswordError = new System.Windows.Forms.Label();
            this.txtConfirmPassError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConformationPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassRestriction = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtUserError);
            this.panel1.Controls.Add(this.textEmailError);
            this.panel1.Controls.Add(this.txtPasswordError);
            this.panel1.Controls.Add(this.txtConfirmPassError);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConformationPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(67, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 268);
            this.panel1.TabIndex = 4;
            // 
            // txtUserError
            // 
            this.txtUserError.AutoSize = true;
            this.txtUserError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserError.ForeColor = System.Drawing.Color.Red;
            this.txtUserError.Location = new System.Drawing.Point(138, 55);
            this.txtUserError.Name = "txtUserError";
            this.txtUserError.Size = new System.Drawing.Size(87, 9);
            this.txtUserError.TabIndex = 15;
            this.txtUserError.Text = "Your username is taken.";
            this.txtUserError.Visible = false;
            // 
            // textEmailError
            // 
            this.textEmailError.AutoSize = true;
            this.textEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailError.ForeColor = System.Drawing.Color.Red;
            this.textEmailError.Location = new System.Drawing.Point(139, 108);
            this.textEmailError.Name = "textEmailError";
            this.textEmailError.Size = new System.Drawing.Size(82, 9);
            this.textEmailError.TabIndex = 14;
            this.textEmailError.Text = "Your email is not valid.";
            this.textEmailError.Visible = false;
            // 
            // txtPasswordError
            // 
            this.txtPasswordError.AutoSize = true;
            this.txtPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordError.ForeColor = System.Drawing.Color.Red;
            this.txtPasswordError.Location = new System.Drawing.Point(139, 158);
            this.txtPasswordError.Name = "txtPasswordError";
            this.txtPasswordError.Size = new System.Drawing.Size(97, 9);
            this.txtPasswordError.TabIndex = 13;
            this.txtPasswordError.Text = "Your password is too short.";
            this.txtPasswordError.Visible = false;
            // 
            // txtConfirmPassError
            // 
            this.txtConfirmPassError.AutoSize = true;
            this.txtConfirmPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassError.ForeColor = System.Drawing.Color.Red;
            this.txtConfirmPassError.Location = new System.Drawing.Point(138, 202);
            this.txtConfirmPassError.Name = "txtConfirmPassError";
            this.txtConfirmPassError.Size = new System.Drawing.Size(107, 9);
            this.txtConfirmPassError.TabIndex = 12;
            this.txtConfirmPassError.Text = "Your password doesn\'t match.";
            this.txtConfirmPassError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirm Password";
            // 
            // txtConformationPassword
            // 
            this.txtConformationPassword.Location = new System.Drawing.Point(141, 179);
            this.txtConformationPassword.Name = "txtConformationPassword";
            this.txtConformationPassword.Size = new System.Drawing.Size(128, 20);
            this.txtConformationPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreate.Location = new System.Drawing.Point(168, 225);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(141, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(294, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Create a New Account !";
            // 
            // txtPassRestriction
            // 
            this.txtPassRestriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassRestriction.Location = new System.Drawing.Point(393, 98);
            this.txtPassRestriction.Name = "txtPassRestriction";
            this.txtPassRestriction.Size = new System.Drawing.Size(395, 268);
            this.txtPassRestriction.TabIndex = 5;
            this.txtPassRestriction.Text = resources.GetString("txtPassRestriction.Text");
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassRestriction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frmSignup";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.frmSignup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConformationPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPassRestriction;
        private System.Windows.Forms.Label txtUserError;
        private System.Windows.Forms.Label textEmailError;
        private System.Windows.Forms.Label txtPasswordError;
        private System.Windows.Forms.Label txtConfirmPassError;
    }
}