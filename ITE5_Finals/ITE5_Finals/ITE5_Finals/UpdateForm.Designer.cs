namespace ITE5_Finals
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            cbStatus = new ComboBox();
            cbType = new ComboBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            txtUserID = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(172, 312);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(150, 29);
            cbStatus.TabIndex = 9;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(172, 259);
            cbType.Name = "cbType";
            cbType.Size = new Size(150, 29);
            cbType.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(172, 206);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(280, 29);
            txtNumber.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 153);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 29);
            txtName.TabIndex = 6;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(172, 100);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(280, 29);
            txtUserID.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(43, 94, 94);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(687, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(101, 36, 36);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(564, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 42);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(cbStatus);
            Controls.Add(cbType);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(txtUserID);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private ComboBox cbType;
        private TextBox txtNumber;
        private TextBox txtName;
        private TextBox txtUserID;
        private Button btnUpdate;
        private Button btnCancel;
    }
}