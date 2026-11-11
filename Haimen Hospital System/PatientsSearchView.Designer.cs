namespace Haimen_Hospital_System
{
    partial class PatientsSearchView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPageTitle = new Label();
            pnldivider = new Panel();
            lblSearchCaption = new Label();
            lblNationalIdCaption = new Label();
            textNationalId = new TextBox();
            btnSearch = new Button();
            identityBlockResult = new IdentityBlockView();
            btnViewRecord = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblPageTitle.ForeColor = SystemColors.ActiveCaption;
            lblPageTitle.Location = new Point(24, 16);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(205, 38);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Search Patient";
            // 
            // pnldivider
            // 
            pnldivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnldivider.BackColor = Color.FromArgb(200, 209, 218);
            pnldivider.ForeColor = Color.White;
            pnldivider.Location = new Point(24, 60);
            pnldivider.MinimumSize = new Size(400, 1);
            pnldivider.Name = "pnldivider";
            pnldivider.Size = new Size(1464, 10);
            pnldivider.TabIndex = 5;
            // 
            // lblSearchCaption
            // 
            lblSearchCaption.AutoSize = true;
            lblSearchCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblSearchCaption.Location = new Point(24, 76);
            lblSearchCaption.Name = "lblSearchCaption";
            lblSearchCaption.Size = new Size(248, 25);
            lblSearchCaption.TabIndex = 6;
            lblSearchCaption.Text = "Find a patient by national ID";
            // 
            // lblNationalIdCaption
            // 
            lblNationalIdCaption.AutoSize = true;
            lblNationalIdCaption.Font = new Font("Segoe UI", 10.5F);
            lblNationalIdCaption.Location = new Point(24, 112);
            lblNationalIdCaption.Name = "lblNationalIdCaption";
            lblNationalIdCaption.Size = new Size(81, 19);
            lblNationalIdCaption.TabIndex = 7;
            lblNationalIdCaption.Text = "National ID:";
            // 
            // textNationalId
            // 
            textNationalId.Font = new Font("Segoe UI", 10.5F);
            textNationalId.Location = new Point(116, 108);
            textNationalId.Name = "textNationalId";
            textNationalId.PlaceholderText = "241-21443553423-11212-42";
            textNationalId.Size = new Size(240, 26);
            textNationalId.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSearch.Location = new Point(368, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // identityBlockResult
            // 
            identityBlockResult.Age = "22";
            identityBlockResult.Birthday = "04/07/2004";
            identityBlockResult.Email = "passproperty@gmail.com";
            identityBlockResult.Ethnicity = "Iraqi";
            identityBlockResult.Gender = "Male";
            identityBlockResult.Location = new Point(24, 152);
            identityBlockResult.Name = "identityBlockResult";
            identityBlockResult.NationalID = "241-21443553423-11212-44";
            identityBlockResult.Size = new Size(1464, 266);
            identityBlockResult.TabIndex = 10;
            identityBlockResult.UserId = new Guid("17ce8eec-9dd1-4b57-af50-595eccc339e1");
            identityBlockResult.UserImage = Properties.Resources.Gemini_Generated_Image_5o38gp5o38gp5o38;
            identityBlockResult.UserName = "S. A";
            // 
            // btnViewRecord
            // 
            btnViewRecord.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnViewRecord.Location = new Point(1348, 434);
            btnViewRecord.Name = "btnViewRecord";
            btnViewRecord.Size = new Size(140, 37);
            btnViewRecord.TabIndex = 2;
            btnViewRecord.Text = "View Record";
            btnViewRecord.UseVisualStyleBackColor = true;
            // 
            // PatientsSearchView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnViewRecord);
            Controls.Add(identityBlockResult);
            Controls.Add(btnSearch);
            Controls.Add(textNationalId);
            Controls.Add(lblNationalIdCaption);
            Controls.Add(lblSearchCaption);
            Controls.Add(pnldivider);
            Controls.Add(lblPageTitle);
            Name = "PatientsSearchView";
            Size = new Size(1512, 712);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private Label lblSearchCaption;
        private Label lblNationalIdCaption;
        private TextBox textNationalId;
        private Button btnSearch;
        private IdentityBlockView identityBlockResult;
        private Button btnViewRecord;
        private ToolTip toolTip1;
    }
}
