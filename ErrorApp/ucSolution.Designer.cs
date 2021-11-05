namespace ErrorApp
{
    partial class ucSolution
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
            this.components = new System.ComponentModel.Container();
            this.pnlSolutionDialog = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblSolutionDesc = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvSolution = new System.Windows.Forms.DataGridView();
            this.errorSolution = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearchSolution = new System.Windows.Forms.TextBox();
            this.txtSearchError = new System.Windows.Forms.TextBox();
            this.lblSearchSolution = new System.Windows.Forms.Label();
            this.lblSearchError = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.pnlSolutionDialog.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSolutionDialog
            // 
            this.pnlSolutionDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlSolutionDialog.Controls.Add(this.btnClose);
            this.pnlSolutionDialog.Controls.Add(this.lblDesc);
            this.pnlSolutionDialog.Controls.Add(this.txtDesc);
            this.pnlSolutionDialog.Controls.Add(this.lblSolutionDesc);
            this.pnlSolutionDialog.Controls.Add(this.lblSolution);
            this.pnlSolutionDialog.Controls.Add(this.btnSubmit);
            this.pnlSolutionDialog.Location = new System.Drawing.Point(269, 270);
            this.pnlSolutionDialog.Name = "pnlSolutionDialog";
            this.pnlSolutionDialog.Size = new System.Drawing.Size(420, 197);
            this.pnlSolutionDialog.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(39)))), ((int)(((byte)(29)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(374, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(18, 89);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(101, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Solution Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(19, 105);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(367, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblSolutionDesc
            // 
            this.lblSolutionDesc.AutoSize = true;
            this.lblSolutionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionDesc.ForeColor = System.Drawing.Color.White;
            this.lblSolutionDesc.Location = new System.Drawing.Point(18, 51);
            this.lblSolutionDesc.Name = "lblSolutionDesc";
            this.lblSolutionDesc.Size = new System.Drawing.Size(196, 18);
            this.lblSolutionDesc.TabIndex = 2;
            this.lblSolutionDesc.Text = "Please enter solution details:";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.ForeColor = System.Drawing.Color.White;
            this.lblSolution.Location = new System.Drawing.Point(13, 16);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(191, 33);
            this.lblSolution.TabIndex = 1;
            this.lblSolution.Text = "Edit Solution";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(244)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(311, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlDelete);
            this.pnlButtons.Controls.Add(this.pnlUpdate);
            this.pnlButtons.Location = new System.Drawing.Point(19, 9);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(305, 60);
            this.pnlButtons.TabIndex = 8;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDelete.Location = new System.Drawing.Point(137, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(137, 60);
            this.pnlDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Solution";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpdate.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(137, 60);
            this.pnlUpdate.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(15, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Solution";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvSolution
            // 
            this.dgvSolution.AllowUserToAddRows = false;
            this.dgvSolution.AllowUserToDeleteRows = false;
            this.dgvSolution.AllowUserToResizeColumns = false;
            this.dgvSolution.AllowUserToResizeRows = false;
            this.dgvSolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolution.Location = new System.Drawing.Point(19, 156);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.ReadOnly = true;
            this.dgvSolution.RowHeadersVisible = false;
            this.dgvSolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolution.Size = new System.Drawing.Size(914, 489);
            this.dgvSolution.TabIndex = 9;
            this.dgvSolution.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSolution_DataBindingComplete);
            this.dgvSolution.SelectionChanged += new System.EventHandler(this.dgvSolution_SelectionChanged);
            // 
            // errorSolution
            // 
            this.errorSolution.ContainerControl = this;
            // 
            // txtSearchSolution
            // 
            this.txtSearchSolution.Location = new System.Drawing.Point(723, 47);
            this.txtSearchSolution.Name = "txtSearchSolution";
            this.txtSearchSolution.Size = new System.Drawing.Size(210, 20);
            this.txtSearchSolution.TabIndex = 10;
            this.txtSearchSolution.TextChanged += new System.EventHandler(this.txtSearchSolution_TextChanged);
            // 
            // txtSearchError
            // 
            this.txtSearchError.Location = new System.Drawing.Point(723, 21);
            this.txtSearchError.Name = "txtSearchError";
            this.txtSearchError.Size = new System.Drawing.Size(210, 20);
            this.txtSearchError.TabIndex = 11;
            this.txtSearchError.TextChanged += new System.EventHandler(this.txtSearchError_TextChanged);
            // 
            // lblSearchSolution
            // 
            this.lblSearchSolution.AutoSize = true;
            this.lblSearchSolution.ForeColor = System.Drawing.Color.White;
            this.lblSearchSolution.Location = new System.Drawing.Point(561, 50);
            this.lblSearchSolution.Name = "lblSearchSolution";
            this.lblSearchSolution.Size = new System.Drawing.Size(87, 13);
            this.lblSearchSolution.TabIndex = 10;
            this.lblSearchSolution.Text = "Search Solutions";
            // 
            // lblSearchError
            // 
            this.lblSearchError.AutoSize = true;
            this.lblSearchError.ForeColor = System.Drawing.Color.White;
            this.lblSearchError.Location = new System.Drawing.Point(561, 24);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(71, 13);
            this.lblSearchError.TabIndex = 11;
            this.lblSearchError.Text = "Search Errors";
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(723, 73);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(210, 21);
            this.cmbModule.TabIndex = 13;
            this.cmbModule.SelectedIndexChanged += new System.EventHandler(this.cmbModule_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(561, 76);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(80, 13);
            this.lblModule.TabIndex = 14;
            this.lblModule.Text = "Filter by module";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(698, 103);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(23, 13);
            this.lbTo.TabIndex = 22;
            this.lbTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(435, 103);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 21;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(470, 100);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(210, 20);
            this.dtpFrom.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(592, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnFilterDate.FlatAppearance.BorderSize = 0;
            this.btnFilterDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnFilterDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDate.ForeColor = System.Drawing.Color.White;
            this.btnFilterDate.Location = new System.Drawing.Point(704, 126);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(106, 23);
            this.btnFilterDate.TabIndex = 17;
            this.btnFilterDate.Text = "Filter Date";
            this.btnFilterDate.UseVisualStyleBackColor = false;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(723, 100);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(210, 20);
            this.dtpTo.TabIndex = 18;
            // 
            // ucSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.lblSearchSolution);
            this.Controls.Add(this.lblSearchError);
            this.Controls.Add(this.txtSearchError);
            this.Controls.Add(this.txtSearchSolution);
            this.Controls.Add(this.pnlSolutionDialog);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvSolution);
            this.Name = "ucSolution";
            this.Size = new System.Drawing.Size(958, 665);
            this.Load += new System.EventHandler(this.ucSolution_Load);
            this.pnlSolutionDialog.ResumeLayout(false);
            this.pnlSolutionDialog.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSolutionDialog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblSolutionDesc;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSolution;
        private System.Windows.Forms.ErrorProvider errorSolution;
        private System.Windows.Forms.TextBox txtSearchError;
        private System.Windows.Forms.TextBox txtSearchSolution;
        private System.Windows.Forms.Label lblSearchSolution;
        private System.Windows.Forms.Label lblSearchError;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}
