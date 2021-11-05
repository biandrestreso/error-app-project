namespace ErrorApp
{
    partial class ucError
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
            this.btnError = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.pnlErrorDialog = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cmbProgLang = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.btnSolution = new System.Windows.Forms.Button();
            this.cmbViewProgLang = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlButtons.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlInsert.SuspendLayout();
            this.pnlErrorDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnError.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnError.Location = new System.Drawing.Point(16, 14);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(106, 38);
            this.btnError.TabIndex = 2;
            this.btnError.Text = "Insert Error";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnUpdate.Location = new System.Drawing.Point(16, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Error";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlDelete);
            this.pnlButtons.Controls.Add(this.pnlUpdate);
            this.pnlButtons.Controls.Add(this.pnlInsert);
            this.pnlButtons.Location = new System.Drawing.Point(19, 15);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(493, 63);
            this.pnlButtons.TabIndex = 5;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDelete.Location = new System.Drawing.Point(274, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(137, 63);
            this.pnlDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDelete.Location = new System.Drawing.Point(21, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Error";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpdate.Location = new System.Drawing.Point(137, 0);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(137, 63);
            this.pnlUpdate.TabIndex = 1;
            // 
            // pnlInsert
            // 
            this.pnlInsert.Controls.Add(this.btnError);
            this.pnlInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInsert.Location = new System.Drawing.Point(0, 0);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(137, 63);
            this.pnlInsert.TabIndex = 0;
            // 
            // pnlErrorDialog
            // 
            this.pnlErrorDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlErrorDialog.Controls.Add(this.btnClose);
            this.pnlErrorDialog.Controls.Add(this.lblTopic);
            this.pnlErrorDialog.Controls.Add(this.cmbTopic);
            this.pnlErrorDialog.Controls.Add(this.lblLanguage);
            this.pnlErrorDialog.Controls.Add(this.lblDesc);
            this.pnlErrorDialog.Controls.Add(this.cmbProgLang);
            this.pnlErrorDialog.Controls.Add(this.txtDesc);
            this.pnlErrorDialog.Controls.Add(this.lblSubHeading);
            this.pnlErrorDialog.Controls.Add(this.lblHeading);
            this.pnlErrorDialog.Controls.Add(this.btnSubmit);
            this.pnlErrorDialog.Location = new System.Drawing.Point(293, 184);
            this.pnlErrorDialog.Name = "pnlErrorDialog";
            this.pnlErrorDialog.Size = new System.Drawing.Size(395, 226);
            this.pnlErrorDialog.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(39)))), ((int)(((byte)(29)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(349, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.Color.White;
            this.lblTopic.Location = new System.Drawing.Point(18, 156);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(59, 13);
            this.lblTopic.TabIndex = 8;
            this.lblTopic.Text = "Error Topic";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(196, 153);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(190, 21);
            this.cmbTopic.TabIndex = 7;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(18, 129);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(119, 13);
            this.lblLanguage.TabIndex = 6;
            this.lblLanguage.Text = "Programming Language";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(18, 82);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Error Description";
            // 
            // cmbProgLang
            // 
            this.cmbProgLang.FormattingEnabled = true;
            this.cmbProgLang.Location = new System.Drawing.Point(196, 126);
            this.cmbProgLang.Name = "cmbProgLang";
            this.cmbProgLang.Size = new System.Drawing.Size(190, 21);
            this.cmbProgLang.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(21, 100);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(365, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(18, 51);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(176, 18);
            this.lblSubHeading.TabIndex = 2;
            this.lblSubHeading.Text = "Please enter error details:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(13, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(173, 33);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Insert Error";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(244)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(311, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToAddRows = false;
            this.dgvError.AllowUserToDeleteRows = false;
            this.dgvError.AllowUserToResizeRows = false;
            this.dgvError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Location = new System.Drawing.Point(19, 177);
            this.dgvError.Name = "dgvError";
            this.dgvError.ReadOnly = true;
            this.dgvError.RowHeadersVisible = false;
            this.dgvError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvError.Size = new System.Drawing.Size(861, 386);
            this.dgvError.TabIndex = 6;
            this.dgvError.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvError_DataBindingComplete);
            this.dgvError.SelectionChanged += new System.EventHandler(this.dgvError_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSolution);
            this.panel1.Location = new System.Drawing.Point(19, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 63);
            this.panel1.TabIndex = 6;
            // 
            // pnlSolution
            // 
            this.pnlSolution.Controls.Add(this.btnSolution);
            this.pnlSolution.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolution.Location = new System.Drawing.Point(0, 0);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(137, 63);
            this.pnlSolution.TabIndex = 0;
            // 
            // btnSolution
            // 
            this.btnSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnSolution.FlatAppearance.BorderSize = 0;
            this.btnSolution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnSolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnSolution.Location = new System.Drawing.Point(16, 12);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(106, 38);
            this.btnSolution.TabIndex = 2;
            this.btnSolution.Text = "Add Solution";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnAddSolution_Click);
            // 
            // cmbViewProgLang
            // 
            this.cmbViewProgLang.FormattingEnabled = true;
            this.cmbViewProgLang.Location = new System.Drawing.Point(670, 57);
            this.cmbViewProgLang.Name = "cmbViewProgLang";
            this.cmbViewProgLang.Size = new System.Drawing.Size(210, 21);
            this.cmbViewProgLang.TabIndex = 7;
            this.cmbViewProgLang.SelectedIndexChanged += new System.EventHandler(this.cmbViewProgLang_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(670, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ucError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbViewProgLang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlErrorDialog);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvError);
            this.Name = "ucError";
            this.Size = new System.Drawing.Size(911, 581);
            this.Load += new System.EventHandler(this.ucError_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlInsert.ResumeLayout(false);
            this.pnlErrorDialog.ResumeLayout(false);
            this.pnlErrorDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSolution.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlErrorDialog;
        private System.Windows.Forms.ComboBox cmbProgLang;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.ComboBox cmbViewProgLang;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
