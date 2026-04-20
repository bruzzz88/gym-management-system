namespace ITE5_Finals
{
    partial class LogInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnEnter = new Button();
            btnCreateAcc = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(431, 143);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(330, 28);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(430, 226);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 28);
            txtPassword.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.White;
            btnEnter.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.Black;
            btnEnter.Location = new Point(563, 276);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(61, 38);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.Location = new Point(507, 331);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(172, 38);
            btnCreateAcc.TabIndex = 3;
            btnCreateAcc.Text = "CREATE NEW ACCOUNT";
            btnCreateAcc.UseVisualStyleBackColor = true;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnCreateAcc);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "LogInPage";
            Text = "LogInPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnEnter;
        private Button btnCreateAcc;
    }
}
