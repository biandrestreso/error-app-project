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
            this.pnlSolutionDialog.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
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
            this.pnlSolutionDialog.Location = new System.Drawing.Point(283, 165);
            this.pnlSolutionDialog.Name = "pnlSolutionDialog";
            this.pnlSolutionDialog.Size = new System.Drawing.Size(395, 197);
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
            this.btnClose.Location = new System.Drawing.Point(349, 0);
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
            this.pnlButtons.Location = new System.Drawing.Point(19, 11);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(343, 100);
            this.pnlButtons.TabIndex = 8;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDelete.Location = new System.Drawing.Point(137, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(137, 100);
            this.pnlDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDelete.Location = new System.Drawing.Point(21, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
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
            this.pnlUpdate.Size = new System.Drawing.Size(137, 100);
            this.pnlUpdate.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnUpdate.Location = new System.Drawing.Point(17, 29);
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
            this.dgvSolution.Location = new System.Drawing.Point(19, 126);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.ReadOnly = true;
            this.dgvSolution.RowHeadersVisible = false;
            this.dgvSolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolution.Size = new System.Drawing.Size(861, 419);
            this.dgvSolution.TabIndex = 9;
            this.dgvSolution.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSolution_DataBindingComplete);
            this.dgvSolution.SelectionChanged += new System.EventHandler(this.dgvSolution_SelectionChanged);
            // 
            // ucSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pnlSolutionDialog);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvSolution);
            this.Name = "ucSolution";
            this.Size = new System.Drawing.Size(906, 572);
            this.Load += new System.EventHandler(this.ucSolution_Load);
            this.pnlSolutionDialog.ResumeLayout(false);
            this.pnlSolutionDialog.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
            this.ResumeLayout(false);

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
    }
}
