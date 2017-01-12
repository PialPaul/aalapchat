namespace aalapChat
{
    partial class MainChatBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChatBox));
            this.contactPanel = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.deactiveButton = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.newPassCheckLabel = new System.Windows.Forms.Label();
            this.newPassCheckBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.oldPassBox = new System.Windows.Forms.TextBox();
            this.nameEditLabel = new System.Windows.Forms.Label();
            this.nameEditBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.add_frd = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.myProfile = new System.Windows.Forms.Button();
            this.searchLebel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoOnTop = new System.Windows.Forms.PictureBox();
            this.ShowOldMsg = new System.Windows.Forms.Button();
            this.StartChat = new System.Windows.Forms.Button();
            this.messagePanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnTop)).BeginInit();
            this.SuspendLayout();
            // 
            // contactPanel
            // 
            this.contactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.contactPanel.Location = new System.Drawing.Point(14, 100);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(342, 337);
            this.contactPanel.TabIndex = 0;
            this.contactPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contactPanel_Paint);
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.messagePanel.Controls.Add(this.editPanel);
            this.messagePanel.Controls.Add(this.chatListBox);
            this.messagePanel.Controls.Add(this.sendButton);
            this.messagePanel.Controls.Add(this.msgBox);
            this.messagePanel.Controls.Add(this.StartChat);
            this.messagePanel.Controls.Add(this.ShowOldMsg);
            this.messagePanel.Location = new System.Drawing.Point(362, 12);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(614, 425);
            this.messagePanel.TabIndex = 1;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editPanel.Controls.Add(this.deactiveButton);
            this.editPanel.Controls.Add(this.footer);
            this.editPanel.Controls.Add(this.labelEdit);
            this.editPanel.Controls.Add(this.newPassCheckLabel);
            this.editPanel.Controls.Add(this.newPassCheckBox);
            this.editPanel.Controls.Add(this.newPassLabel);
            this.editPanel.Controls.Add(this.newPassBox);
            this.editPanel.Controls.Add(this.oldPassLabel);
            this.editPanel.Controls.Add(this.oldPassBox);
            this.editPanel.Controls.Add(this.nameEditLabel);
            this.editPanel.Controls.Add(this.nameEditBox);
            this.editPanel.Controls.Add(this.updateButton);
            this.editPanel.Controls.Add(this.cancelButton);
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(614, 425);
            this.editPanel.TabIndex = 3;
            this.editPanel.Visible = false;
            // 
            // deactiveButton
            // 
            this.deactiveButton.BackColor = System.Drawing.Color.Red;
            this.deactiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactiveButton.Location = new System.Drawing.Point(103, 345);
            this.deactiveButton.Name = "deactiveButton";
            this.deactiveButton.Size = new System.Drawing.Size(381, 38);
            this.deactiveButton.TabIndex = 12;
            this.deactiveButton.Text = "Deactive My Account";
            this.deactiveButton.UseVisualStyleBackColor = false;
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Location = new System.Drawing.Point(184, 399);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(208, 13);
            this.footer.TabIndex = 11;
            this.footer.Text = "All rights reserved to Aalap I.T. Corporation";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(55, 59);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(473, 20);
            this.labelEdit.TabIndex = 10;
            this.labelEdit.Text = "keep Name field blank if do not want to change your name";
            // 
            // newPassCheckLabel
            // 
            this.newPassCheckLabel.AutoSize = true;
            this.newPassCheckLabel.Location = new System.Drawing.Point(100, 253);
            this.newPassCheckLabel.Name = "newPassCheckLabel";
            this.newPassCheckLabel.Size = new System.Drawing.Size(117, 13);
            this.newPassCheckLabel.TabIndex = 9;
            this.newPassCheckLabel.Text = "Re-type Password :";
            // 
            // newPassCheckBox
            // 
            this.newPassCheckBox.Location = new System.Drawing.Point(226, 250);
            this.newPassCheckBox.Name = "newPassCheckBox";
            this.newPassCheckBox.Size = new System.Drawing.Size(258, 20);
            this.newPassCheckBox.TabIndex = 8;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Location = new System.Drawing.Point(100, 202);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(98, 13);
            this.newPassLabel.TabIndex = 7;
            this.newPassLabel.Text = "New Password :";
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(226, 199);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(258, 20);
            this.newPassBox.TabIndex = 6;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Location = new System.Drawing.Point(100, 157);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(69, 13);
            this.oldPassLabel.TabIndex = 5;
            this.oldPassLabel.Text = "Password :";
            // 
            // oldPassBox
            // 
            this.oldPassBox.Location = new System.Drawing.Point(226, 154);
            this.oldPassBox.Name = "oldPassBox";
            this.oldPassBox.Size = new System.Drawing.Size(258, 20);
            this.oldPassBox.TabIndex = 4;
            // 
            // nameEditLabel
            // 
            this.nameEditLabel.AutoSize = true;
            this.nameEditLabel.Location = new System.Drawing.Point(100, 105);
            this.nameEditLabel.Name = "nameEditLabel";
            this.nameEditLabel.Size = new System.Drawing.Size(47, 13);
            this.nameEditLabel.TabIndex = 3;
            this.nameEditLabel.Text = "Name :";
            // 
            // nameEditBox
            // 
            this.nameEditBox.Location = new System.Drawing.Point(226, 102);
            this.nameEditBox.Name = "nameEditBox";
            this.nameEditBox.Size = new System.Drawing.Size(258, 20);
            this.nameEditBox.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(370, 292);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 38);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(104, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chatListBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.ItemHeight = 15;
            this.chatListBox.Location = new System.Drawing.Point(16, 44);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(580, 259);
            this.chatListBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.GreenYellow;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(509, 345);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 43);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(16, 324);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(485, 88);
            this.msgBox.TabIndex = 0;
            this.msgBox.TextChanged += new System.EventHandler(this.msgBox_TextChanged);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.upperPanel.Controls.Add(this.add_frd);
            this.upperPanel.Controls.Add(this.editProfile);
            this.upperPanel.Controls.Add(this.myProfile);
            this.upperPanel.Controls.Add(this.searchLebel);
            this.upperPanel.Controls.Add(this.textBox1);
            this.upperPanel.Controls.Add(this.logoOnTop);
            this.upperPanel.Location = new System.Drawing.Point(14, 12);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(342, 82);
            this.upperPanel.TabIndex = 2;
            // 
            // add_frd
            // 
            this.add_frd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_frd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_frd.Location = new System.Drawing.Point(244, 56);
            this.add_frd.Margin = new System.Windows.Forms.Padding(0);
            this.add_frd.Name = "add_frd";
            this.add_frd.Size = new System.Drawing.Size(63, 23);
            this.add_frd.TabIndex = 5;
            this.add_frd.Text = "Add";
            this.add_frd.UseVisualStyleBackColor = false;
            this.add_frd.Click += new System.EventHandler(this.add_frd_Click);
            // 
            // editProfile
            // 
            this.editProfile.BackColor = System.Drawing.Color.SkyBlue;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(123, 7);
            this.editProfile.Margin = new System.Windows.Forms.Padding(0);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(87, 23);
            this.editProfile.TabIndex = 4;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.UseVisualStyleBackColor = false;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // myProfile
            // 
            this.myProfile.BackColor = System.Drawing.Color.SkyBlue;
            this.myProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfile.Location = new System.Drawing.Point(229, 7);
            this.myProfile.Margin = new System.Windows.Forms.Padding(0);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(87, 23);
            this.myProfile.TabIndex = 3;
            this.myProfile.Text = "My Profile";
            this.myProfile.UseVisualStyleBackColor = false;
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // searchLebel
            // 
            this.searchLebel.AutoSize = true;
            this.searchLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLebel.Location = new System.Drawing.Point(110, 37);
            this.searchLebel.Name = "searchLebel";
            this.searchLebel.Size = new System.Drawing.Size(54, 16);
            this.searchLebel.TabIndex = 2;
            this.searchLebel.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(166, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // logoOnTop
            // 
            this.logoOnTop.Image = global::aalapChat.Properties.Resources.Logo_PNG_File;
            this.logoOnTop.Location = new System.Drawing.Point(3, 3);
            this.logoOnTop.Name = "logoOnTop";
            this.logoOnTop.Size = new System.Drawing.Size(100, 76);
            this.logoOnTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoOnTop.TabIndex = 0;
            this.logoOnTop.TabStop = false;
            // 
            // ShowOldMsg
            // 
            this.ShowOldMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowOldMsg.Location = new System.Drawing.Point(85, 15);
            this.ShowOldMsg.Name = "ShowOldMsg";
            this.ShowOldMsg.Size = new System.Drawing.Size(200, 23);
            this.ShowOldMsg.TabIndex = 4;
            this.ShowOldMsg.Text = "Show old Messages";
            this.ShowOldMsg.UseVisualStyleBackColor = false;
            this.ShowOldMsg.Click += new System.EventHandler(this.ShowOldMsg_Click);
            // 
            // StartChat
            // 
            this.StartChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StartChat.Location = new System.Drawing.Point(301, 15);
            this.StartChat.Name = "StartChat";
            this.StartChat.Size = new System.Drawing.Size(200, 23);
            this.StartChat.TabIndex = 5;
            this.StartChat.Text = "Start Chat";
            this.StartChat.UseVisualStyleBackColor = false;
            this.StartChat.Click += new System.EventHandler(this.StartChat_Click);
            // 
            // MainChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 449);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.contactPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainChatBox";
            this.Text = "Aalap";
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox logoOnTop;
        private System.Windows.Forms.Label searchLebel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.ListBox chatListBox;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button myProfile;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label newPassCheckLabel;
        private System.Windows.Forms.TextBox newPassCheckBox;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.TextBox oldPassBox;
        private System.Windows.Forms.Label nameEditLabel;
        private System.Windows.Forms.TextBox nameEditBox;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button add_frd;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Button deactiveButton;
        private System.Windows.Forms.Button StartChat;
        private System.Windows.Forms.Button ShowOldMsg;

    }
}