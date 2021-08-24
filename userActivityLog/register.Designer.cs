
namespace userActivityLog
{
    partial class register
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
            this.userName = new System.Windows.Forms.TextBox();
            this.employeeId = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.backToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(164, 104);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(76, 20);
            this.userName.TabIndex = 0;
            // 
            // employeeId
            // 
            this.employeeId.Location = new System.Drawing.Point(164, 136);
            this.employeeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(76, 20);
            this.employeeId.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(164, 171);
            this.pwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(76, 20);
            this.pwd.TabIndex = 2;
            this.pwd.UseSystemPasswordChar = true;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(164, 201);
            this.type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(76, 20);
            this.type.TabIndex = 3;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Location = new System.Drawing.Point(101, 106);
            this.uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(35, 13);
            this.uname.TabIndex = 5;
            this.uname.Text = "Name";
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(84, 136);
            this.empID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(66, 13);
            this.empID.TabIndex = 6;
            this.empID.Text = "employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "type";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(164, 266);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(56, 19);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backToLogin
            // 
            this.backToLogin.Location = new System.Drawing.Point(72, 266);
            this.backToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(70, 19);
            this.backToLogin.TabIndex = 10;
            this.backToLogin.Text = "<- login";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 354);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox employeeId;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backToLogin;
    }
}