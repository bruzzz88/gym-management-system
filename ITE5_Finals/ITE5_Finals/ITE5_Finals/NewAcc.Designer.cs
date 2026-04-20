namespace ITE5_Finals
{
    partial class NewAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAcc));
            txtNAuser = new TextBox();
            txtNApass = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtNAuser
            // 
            txtNAuser.Location = new Point(430, 141);
            txtNAuser.Multiline = true;
            txtNAuser.Name = "txtNAuser";
            txtNAuser.Size = new Size(331, 29);
            txtNAuser.TabIndex = 0;
            // 
            // txtNApass
            // 
            txtNApass.Location = new Point(430, 227);
            txtNApass.Multiline = true;
            txtNApass.Name = "txtNApass";
            txtNApass.Size = new Size(331, 29);
            txtNApass.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(101, 36, 36);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(592, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(691, 296);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(70, 38);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // NewAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(txtNApass);
            Controls.Add(txtNAuser);
            Name = "NewAcc";
            Text = "NewAcc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNAuser;
        private TextBox txtNApass;
        private Button btnCancel;
        private Button btnCreate;
    }
}