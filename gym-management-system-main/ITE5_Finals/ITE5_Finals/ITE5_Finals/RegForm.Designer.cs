namespace ITE5_Finals
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            txtUserID = new TextBox();
            txtName = new TextBox();
            txtNumber = new TextBox();
            cbType = new ComboBox();
            cbStatus = new ComboBox();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(171, 99);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(280, 29);
            txtUserID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 152);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 29);
            txtName.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(171, 205);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(280, 29);
            txtNumber.TabIndex = 2;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(171, 258);
            cbType.Name = "cbType";
            cbType.Size = new Size(150, 29);
            cbType.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(171, 311);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(150, 29);
            cbStatus.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(101, 36, 36);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(563, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(43, 94, 94);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(687, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 42);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(cbStatus);
            Controls.Add(cbType);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(txtUserID);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserID;
        private TextBox txtName;
        private TextBox txtNumber;
        private ComboBox cbType;
        private ComboBox cbStatus;
        private Button btnCancel;
        private Button btnAdd;
    }
}