namespace aalapChat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userNameIn = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.nameTextIn = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.unTextBoxIn = new System.Windows.Forms.TextBox();
            this.passTextBoxIn = new System.Windows.Forms.TextBox();
            this.emailIn = new System.Windows.Forms.Label();
            this.unIn = new System.Windows.Forms.Label();
            this.passIn = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.regWarning = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.warningText = new System.Windows.Forms.Label();
            this.unTextBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.motto = new System.Windows.Forms.Label();
            this.registrationPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameIn
            // 
            this.userNameIn.AutoSize = true;
            this.userNameIn.Location = new System.Drawing.Point(54, 87);
            this.userNameIn.Name = "userNameIn";
            this.userNameIn.Size = new System.Drawing.Size(44, 13);
            this.userNameIn.TabIndex = 6;
            this.userNameIn.Text = " Name :";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.register.Location = new System.Drawing.Point(185, 320);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(156, 23);
            this.register.TabIndex = 4;
            this.register.Text = "Register Now!";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // nameTextIn
            // 
            this.nameTextIn.Location = new System.Drawing.Point(125, 84);
            this.nameTextIn.Name = "nameTextIn";
            this.nameTextIn.Size = new System.Drawing.Size(216, 20);
            this.nameTextIn.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(125, 141);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(216, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged_1);
            // 
            // unTextBoxIn
            // 
            this.unTextBoxIn.Location = new System.Drawing.Point(125, 190);
            this.unTextBoxIn.Name = "unTextBoxIn";
            this.unTextBoxIn.Size = new System.Drawing.Size(216, 20);
            this.unTextBoxIn.TabIndex = 2;
            this.unTextBoxIn.TextChanged += new System.EventHandler(this.emailTextBoxIn_TextChanged);
            // 
            // passTextBoxIn
            // 
            this.passTextBoxIn.Location = new System.Drawing.Point(125, 248);
            this.passTextBoxIn.Name = "passTextBoxIn";
            this.passTextBoxIn.Size = new System.Drawing.Size(216, 20);
            this.passTextBoxIn.TabIndex = 3;
            this.passTextBoxIn.TextChanged += new System.EventHandler(this.passTextBoxIn_TextChanged_1);
            this.passTextBoxIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBoxIn_KeyPress);
            // 
            // emailIn
            // 
            this.emailIn.AutoSize = true;
            this.emailIn.Location = new System.Drawing.Point(54, 148);
            this.emailIn.Name = "emailIn";
            this.emailIn.Size = new System.Drawing.Size(36, 13);
            this.emailIn.TabIndex = 7;
            this.emailIn.Text = "E-Mail";
            // 
            // unIn
            // 
            this.unIn.AutoSize = true;
            this.unIn.Location = new System.Drawing.Point(54, 197);
            this.unIn.Name = "unIn";
            this.unIn.Size = new System.Drawing.Size(66, 13);
            this.unIn.TabIndex = 8;
            this.unIn.Text = "User Name: ";
            // 
            // passIn
            // 
            this.passIn.AutoSize = true;
            this.passIn.Location = new System.Drawing.Point(54, 255);
            this.passIn.Name = "passIn";
            this.passIn.Size = new System.Drawing.Size(53, 13);
            this.passIn.TabIndex = 9;
            this.passIn.Text = "Password";
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registrationPanel.Controls.Add(this.regWarning);
            this.registrationPanel.Controls.Add(this.nameTextIn);
            this.registrationPanel.Controls.Add(this.passIn);
            this.registrationPanel.Controls.Add(this.userNameIn);
            this.registrationPanel.Controls.Add(this.unIn);
            this.registrationPanel.Controls.Add(this.register);
            this.registrationPanel.Controls.Add(this.emailIn);
            this.registrationPanel.Controls.Add(this.emailTextBox);
            this.registrationPanel.Controls.Add(this.passTextBoxIn);
            this.registrationPanel.Controls.Add(this.unTextBoxIn);
            this.registrationPanel.Location = new System.Drawing.Point(12, 78);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(396, 359);
            this.registrationPanel.TabIndex = 9;
            // 
            // regWarning
            // 
            this.regWarning.AutoSize = true;
            this.regWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regWarning.Location = new System.Drawing.Point(54, 43);
            this.regWarning.Name = "regWarning";
            this.regWarning.Size = new System.Drawing.Size(111, 16);
            this.regWarning.TabIndex = 5;
            this.regWarning.Text = "Enter your info.";
            this.regWarning.Click += new System.EventHandler(this.regWarning_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginPanel.Controls.Add(this.warningText);
            this.loginPanel.Controls.Add(this.unTextBox);
            this.loginPanel.Controls.Add(this.userName);
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.passTextBox);
            this.loginPanel.Location = new System.Drawing.Point(442, 78);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(396, 359);
            this.loginPanel.TabIndex = 10;
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningText.Location = new System.Drawing.Point(77, 84);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(261, 16);
            this.warningText.TabIndex = 3;
            this.warningText.Text = "Enter Valid Username and Password";
            this.warningText.Click += new System.EventHandler(this.warningText_Click_1);
            // 
            // unTextBox
            // 
            this.unTextBox.Location = new System.Drawing.Point(138, 137);
            this.unTextBox.Name = "unTextBox";
            this.unTextBox.Size = new System.Drawing.Size(216, 20);
            this.unTextBox.TabIndex = 0;
            this.unTextBox.TextChanged += new System.EventHandler(this.unTextBox_TextChanged_1);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(67, 140);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(66, 13);
            this.userName.TabIndex = 4;
            this.userName.Text = "User Name :";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login.Location = new System.Drawing.Point(252, 320);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(102, 23);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            this.login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(67, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(59, 13);
            this.password.TabIndex = 5;
            this.password.Text = "Password :";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(138, 198);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(216, 20);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged_1);
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBox_KeyPress);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::aalapChat.Properties.Resources.Logo_PNG_File;
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(108, 60);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 11;
            this.logoBox.TabStop = false;
            // 
            // motto
            // 
            this.motto.AutoSize = true;
            this.motto.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motto.Location = new System.Drawing.Point(126, 37);
            this.motto.Name = "motto";
            this.motto.Size = new System.Drawing.Size(350, 25);
            this.motto.TabIndex = 12;
            this.motto.Text = "A secure, fast and desirable way to communicate.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 449);
            this.Controls.Add(this.motto);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.registrationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Aalap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameIn;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox nameTextIn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox unTextBoxIn;
        private System.Windows.Forms.TextBox passTextBoxIn;
        private System.Windows.Forms.Label emailIn;
        private System.Windows.Forms.Label unIn;
        private System.Windows.Forms.Label passIn;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox unTextBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Label regWarning;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label motto;
    }
}

