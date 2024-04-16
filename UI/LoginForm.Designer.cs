namespace warehouse_management.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            labelUsername = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            textUsername = new TextBox();
            textPassword = new TextBox();
            labelPassword = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Transparent;
            labelUsername.Location = new Point(33, 55);
            labelUsername.Margin = new Padding(6, 0, 6, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(106, 28);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(279, 300);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 57);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(33, 300);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(177, 57);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(33, 99);
            textUsername.Margin = new Padding(6);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(422, 34);
            textUsername.TabIndex = 8;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(33, 207);
            textPassword.Margin = new Padding(6);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(422, 34);
            textPassword.TabIndex = 10;
            textPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Transparent;
            labelPassword.Location = new Point(33, 162);
            labelPassword.Margin = new Padding(6, 0, 6, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 28);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(labelUsername);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(textUsername);
            groupBox1.Location = new Point(196, 261);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(532, 419);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(196, 165);
            label1.Name = "label1";
            label1.Size = new Size(957, 83);
            label1.TabIndex = 13;
            label1.Text = "Warehouse Management System";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnExit;
            ClientSize = new Size(1396, 825);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Button btnLogin;
        private Button btnExit;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label labelPassword;
        private GroupBox groupBox1;
        private Label label1;
    }
}