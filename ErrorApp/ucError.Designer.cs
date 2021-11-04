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
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.btnErrorAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDeleteBtn = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.pnlInsertBtn = new System.Windows.Forms.Panel();
            this.pnlErrorDialog = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cmbProgLang = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblErrorDesc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlDeleteBtn.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlInsertBtn.SuspendLayout();
            this.pnlErrorDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToAddRows = false;
            this.dgvError.AllowUserToDeleteRows = false;
            this.dgvError.AllowUserToResizeColumns = false;
            this.dgvError.AllowUserToResizeRows = false;
            this.dgvError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvError.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(74)))));
            this.dgvError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvError.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Location = new System.Drawing.Point(19, 150);
            this.dgvError.Name = "dgvError";
            this.dgvError.ReadOnly = true;
            this.dgvError.Size = new System.Drawing.Size(864, 381);
            this.dgvError.TabIndex = 0;
            this.dgvError.Click += new System.EventHandler(this.dgvError_Click);
            // 
            // btnErrorAdd
            // 
            this.btnErrorAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnErrorAdd.FlatAppearance.BorderSize = 0;
            this.btnErrorAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnErrorAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnErrorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnErrorAdd.Location = new System.Drawing.Point(15, 29);
            this.btnErrorAdd.Name = "btnErrorAdd";
            this.btnErrorAdd.Size = new System.Drawing.Size(106, 38);
            this.btnErrorAdd.TabIndex = 2;
            this.btnErrorAdd.Text = "Insert Error";
            this.btnErrorAdd.UseVisualStyleBackColor = false;
            this.btnErrorAdd.Click += new System.EventHandler(this.btnErrorAdd_Click);
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
            this.btnUpdate.Text = "Update Error";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDeleteBtn);
            this.panel2.Controls.Add(this.pnlUpdateBtn);
            this.panel2.Controls.Add(this.pnlInsertBtn);
            this.panel2.Location = new System.Drawing.Point(19, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 100);
            this.panel2.TabIndex = 5;
            // 
            // pnlDeleteBtn
            // 
            this.pnlDeleteBtn.Controls.Add(this.btnDelete);
            this.pnlDeleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDeleteBtn.Location = new System.Drawing.Point(274, 0);
            this.pnlDeleteBtn.Name = "pnlDeleteBtn";
            this.pnlDeleteBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlDeleteBtn.TabIndex = 3;
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
            this.btnDelete.Text = "Delete Error";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.Controls.Add(this.btnUpdate);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(137, 0);
            this.pnlUpdateBtn.Name = "pnlUpdateBtn";
            this.pnlUpdateBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlUpdateBtn.TabIndex = 1;
            // 
            // pnlInsertBtn
            // 
            this.pnlInsertBtn.Controls.Add(this.btnErrorAdd);
            this.pnlInsertBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInsertBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlInsertBtn.Name = "pnlInsertBtn";
            this.pnlInsertBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlInsertBtn.TabIndex = 0;
            // 
            // pnlErrorDialog
            // 
            this.pnlErrorDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlErrorDialog.Controls.Add(this.lblStatus);
            this.pnlErrorDialog.Controls.Add(this.lblTopic);
            this.pnlErrorDialog.Controls.Add(this.cmbStatus);
            this.pnlErrorDialog.Controls.Add(this.cmbTopic);
            this.pnlErrorDialog.Controls.Add(this.lblLanguage);
            this.pnlErrorDialog.Controls.Add(this.lblDesc);
            this.pnlErrorDialog.Controls.Add(this.cmbProgLang);
            this.pnlErrorDialog.Controls.Add(this.txtDesc);
            this.pnlErrorDialog.Controls.Add(this.lblErrorDesc);
            this.pnlErrorDialog.Controls.Add(this.lblError);
            this.pnlErrorDialog.Controls.Add(this.btnSubmit);
            this.pnlErrorDialog.Location = new System.Drawing.Point(293, 184);
            this.pnlErrorDialog.Name = "pnlErrorDialog";
            this.pnlErrorDialog.Size = new System.Drawing.Size(395, 226);
            this.pnlErrorDialog.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(18, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Error Status";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.Color.White;
            this.lblTopic.Location = new System.Drawing.Point(18, 162);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(59, 13);
            this.lblTopic.TabIndex = 8;
            this.lblTopic.Text = "Error Topic";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(196, 105);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(196, 159);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(190, 21);
            this.cmbTopic.TabIndex = 7;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(18, 135);
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
            this.cmbProgLang.Location = new System.Drawing.Point(196, 132);
            this.cmbProgLang.Name = "cmbProgLang";
            this.cmbProgLang.Size = new System.Drawing.Size(190, 21);
            this.cmbProgLang.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(196, 79);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(190, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblErrorDesc
            // 
            this.lblErrorDesc.AutoSize = true;
            this.lblErrorDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDesc.ForeColor = System.Drawing.Color.White;
            this.lblErrorDesc.Location = new System.Drawing.Point(18, 51);
            this.lblErrorDesc.Name = "lblErrorDesc";
            this.lblErrorDesc.Size = new System.Drawing.Size(176, 18);
            this.lblErrorDesc.TabIndex = 2;
            this.lblErrorDesc.Text = "Please enter error details:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(13, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(173, 33);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Insert Error";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(244)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(311, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ucError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pnlErrorDialog);
            this.Controls.Add(this.dgvError);
            this.Controls.Add(this.panel2);
            this.Name = "ucError";
            this.Size = new System.Drawing.Size(1020, 581);
            this.Load += new System.EventHandler(this.ucError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlDeleteBtn.ResumeLayout(false);
            this.pnlUpdateBtn.ResumeLayout(false);
            this.pnlInsertBtn.ResumeLayout(false);
            this.pnlErrorDialog.ResumeLayout(false);
            this.pnlErrorDialog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Button btnErrorAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Panel pnlInsertBtn;
        private System.Windows.Forms.Panel pnlDeleteBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlErrorDialog;
        private System.Windows.Forms.ComboBox cmbProgLang;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblErrorDesc;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
