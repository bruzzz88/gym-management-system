namespace ITE5_Finals
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnLogOut = new Button();
            btnRemove = new Button();
            btnArchive = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(233, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(356, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(43, 94, 94);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(607, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(43, 94, 94);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(708, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(72, 33);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(101, 36, 36);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(47, 414);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(82, 56);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.FromArgb(43, 94, 94);
            btnArchive.FlatAppearance.BorderSize = 0;
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArchive.ForeColor = Color.White;
            btnArchive.Location = new Point(156, 412);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(82, 56);
            btnArchive.TabIndex = 4;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(43, 94, 94);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(261, 412);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 56);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(43, 94, 94);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(681, 412);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 56);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnRegister);
            Controls.Add(btnUpdate);
            Controls.Add(btnArchive);
            Controls.Add(btnRemove);
            Controls.Add(btnLogOut);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "MainPage";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLogOut;
        private Button btnRemove;
        private Button btnArchive;
        private Button btnUpdate;
        private Button btnRegister;
    }
}