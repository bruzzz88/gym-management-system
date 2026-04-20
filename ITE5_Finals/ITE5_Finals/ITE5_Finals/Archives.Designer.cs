namespace ITE5_Finals
{
    partial class Archives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archives));
            btnRestore = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.FromArgb(43, 94, 94);
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(151, 412);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(164, 56);
            btnRestore.TabIndex = 6;
            btnRestore.Text = "Restore Member";
            btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(101, 36, 36);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(46, 412);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 56);
            btnBack.TabIndex = 5;
            btnBack.Text = "Remove";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(43, 94, 94);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(605, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(231, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(356, 23);
            txtSearch.TabIndex = 7;
            // 
            // Archives
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 490);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRestore);
            Controls.Add(btnBack);
            Name = "Archives";
            Text = "Archives";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRestore;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}