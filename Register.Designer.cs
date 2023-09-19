namespace LMS
{
    partial class Register
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
            this.firstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.age = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegisterAs = new System.Windows.Forms.ComboBox();
            this.RegisterBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.phoneNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Depth = 0;
            this.firstName.Hint = "First-name";
            this.firstName.Location = new System.Drawing.Point(20, 223);
            this.firstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.Size = new System.Drawing.Size(514, 41);
            this.firstName.TabIndex = 0;
            this.firstName.UseSystemPasswordChar = false;
            this.firstName.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // lastName
            // 
            this.lastName.Depth = 0;
            this.lastName.Hint = "Last-name";
            this.lastName.Location = new System.Drawing.Point(20, 323);
            this.lastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.Size = new System.Drawing.Size(514, 41);
            this.lastName.TabIndex = 1;
            this.lastName.UseSystemPasswordChar = false;
            // 
            // userName
            // 
            this.userName.Depth = 0;
            this.userName.Hint = "User-name ";
            this.userName.Location = new System.Drawing.Point(20, 414);
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.Size = new System.Drawing.Size(514, 41);
            this.userName.TabIndex = 2;
            this.userName.UseSystemPasswordChar = false;
            // 
            // age
            // 
            this.age.Depth = 0;
            this.age.Hint = "Age";
            this.age.Location = new System.Drawing.Point(20, 741);
            this.age.MouseState = MaterialSkin.MouseState.HOVER;
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.SelectedText = "";
            this.age.SelectionLength = 0;
            this.age.SelectionStart = 0;
            this.age.Size = new System.Drawing.Size(309, 41);
            this.age.TabIndex = 3;
            this.age.UseSystemPasswordChar = false;
            // 
            // email
            // 
            this.email.Depth = 0;
            this.email.Hint = "Email";
            this.email.Location = new System.Drawing.Point(20, 523);
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(514, 41);
            this.email.TabIndex = 4;
            this.email.UseSystemPasswordChar = false;
            // 
            // RegisterAs
            // 
            this.RegisterAs.FormattingEnabled = true;
            this.RegisterAs.Items.AddRange(new object[] {
            "Student",
            "Librarian"});
            this.RegisterAs.Location = new System.Drawing.Point(812, 274);
            this.RegisterAs.Name = "RegisterAs";
            this.RegisterAs.Size = new System.Drawing.Size(154, 33);
            this.RegisterAs.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Depth = 0;
            this.RegisterBtn.Location = new System.Drawing.Point(720, 375);
            this.RegisterBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Primary = true;
            this.RegisterBtn.Size = new System.Drawing.Size(176, 52);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register as";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(602, 103);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 759);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // phoneNo
            // 
            this.phoneNo.Depth = 0;
            this.phoneNo.Hint = "Phone-no";
            this.phoneNo.Location = new System.Drawing.Point(20, 602);
            this.phoneNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.PasswordChar = '\0';
            this.phoneNo.SelectedText = "";
            this.phoneNo.SelectionLength = 0;
            this.phoneNo.SelectionStart = 0;
            this.phoneNo.Size = new System.Drawing.Size(514, 41);
            this.phoneNo.TabIndex = 10;
            this.phoneNo.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(20, 672);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(514, 41);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 874);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.RegisterAs);
            this.Controls.Add(this.email);
            this.Controls.Add(this.age);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register (Library Management System)";
            this.Load += new System.EventHandler(this.Blah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField firstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField userName;
        private MaterialSkin.Controls.MaterialSingleLineTextField age;
        private MaterialSkin.Controls.MaterialSingleLineTextField email;
        private System.Windows.Forms.ComboBox RegisterAs;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterBtn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField phoneNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
    }
}