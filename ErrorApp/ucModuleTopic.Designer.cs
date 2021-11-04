namespace ErrorApp
{
    partial class ucModuleTopic
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
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.pnlModuleDialog = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblAddDesc = new System.Windows.Forms.Label();
            this.lblModuleTopic = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDeleteBtn = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.pnlInsertBtn = new System.Windows.Forms.Panel();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.dgvTopic = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModuleTopic = new System.Windows.Forms.Button();
            this.pnlModuleTopic = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvModuleTopic = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddTopicModule = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDeleteTopicModule = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnUpdateTopicModule = new System.Windows.Forms.Button();
            this.pnlModuleTopicDialog = new System.Windows.Forms.Panel();
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitModuleTopic = new System.Windows.Forms.Button();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.pnlModuleDialog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDeleteBtn.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlInsertBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlModuleTopic.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleTopic)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlModuleTopicDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.AllowUserToDeleteRows = false;
            this.dgvModule.AllowUserToResizeRows = false;
            this.dgvModule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Location = new System.Drawing.Point(17, 172);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.ReadOnly = true;
            this.dgvModule.RowHeadersVisible = false;
            this.dgvModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModule.Size = new System.Drawing.Size(435, 382);
            this.dgvModule.TabIndex = 1;
            this.dgvModule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvModule_DataBindingComplete);
            this.dgvModule.SelectionChanged += new System.EventHandler(this.dgvModule_SelectionChanged);
            // 
            // pnlModuleDialog
            // 
            this.pnlModuleDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlModuleDialog.Controls.Add(this.lblYear);
            this.pnlModuleDialog.Controls.Add(this.cmbYear);
            this.pnlModuleDialog.Controls.Add(this.lblDesc);
            this.pnlModuleDialog.Controls.Add(this.txtDesc);
            this.pnlModuleDialog.Controls.Add(this.lblAddDesc);
            this.pnlModuleDialog.Controls.Add(this.lblModuleTopic);
            this.pnlModuleDialog.Controls.Add(this.btnSubmit);
            this.pnlModuleDialog.Location = new System.Drawing.Point(261, 194);
            this.pnlModuleDialog.Name = "pnlModuleDialog";
            this.pnlModuleDialog.Size = new System.Drawing.Size(402, 207);
            this.pnlModuleDialog.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(18, 131);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(196, 128);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(190, 21);
            this.cmbYear.TabIndex = 7;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(18, 105);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(98, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Module Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(196, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(190, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblAddDesc
            // 
            this.lblAddDesc.AutoSize = true;
            this.lblAddDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc.ForeColor = System.Drawing.Color.White;
            this.lblAddDesc.Location = new System.Drawing.Point(18, 51);
            this.lblAddDesc.Name = "lblAddDesc";
            this.lblAddDesc.Size = new System.Drawing.Size(193, 18);
            this.lblAddDesc.TabIndex = 2;
            this.lblAddDesc.Text = "Please enter module details:";
            // 
            // lblModuleTopic
            // 
            this.lblModuleTopic.AutoSize = true;
            this.lblModuleTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleTopic.ForeColor = System.Drawing.Color.White;
            this.lblModuleTopic.Location = new System.Drawing.Point(13, 16);
            this.lblModuleTopic.Name = "lblModuleTopic";
            this.lblModuleTopic.Size = new System.Drawing.Size(204, 33);
            this.lblModuleTopic.TabIndex = 1;
            this.lblModuleTopic.Text = "Insert Module";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(244)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(311, 164);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDeleteBtn);
            this.panel2.Controls.Add(this.pnlUpdateBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlInsertBtn);
            this.panel2.Location = new System.Drawing.Point(17, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 100);
            this.panel2.TabIndex = 6;
            // 
            // pnlDeleteBtn
            // 
            this.pnlDeleteBtn.Controls.Add(this.btnDelete);
            this.pnlDeleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDeleteBtn.Location = new System.Drawing.Point(411, 0);
            this.pnlDeleteBtn.Name = "pnlDeleteBtn";
            this.pnlDeleteBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlDeleteBtn.TabIndex = 6;
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
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.Controls.Add(this.btnUpdate);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(274, 0);
            this.pnlUpdateBtn.Name = "pnlUpdateBtn";
            this.pnlUpdateBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlUpdateBtn.TabIndex = 5;
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
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddTopic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(137, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 100);
            this.panel3.TabIndex = 4;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnAddTopic.FlatAppearance.BorderSize = 0;
            this.btnAddTopic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnAddTopic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnAddTopic.Location = new System.Drawing.Point(15, 29);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(106, 38);
            this.btnAddTopic.TabIndex = 2;
            this.btnAddTopic.Text = "Insert Topic";
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // pnlInsertBtn
            // 
            this.pnlInsertBtn.Controls.Add(this.btnAddModule);
            this.pnlInsertBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInsertBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlInsertBtn.Name = "pnlInsertBtn";
            this.pnlInsertBtn.Size = new System.Drawing.Size(137, 100);
            this.pnlInsertBtn.TabIndex = 0;
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnAddModule.FlatAppearance.BorderSize = 0;
            this.btnAddModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnAddModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnAddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnAddModule.Location = new System.Drawing.Point(15, 29);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(106, 38);
            this.btnAddModule.TabIndex = 2;
            this.btnAddModule.Text = "Insert Module";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // dgvTopic
            // 
            this.dgvTopic.AllowUserToAddRows = false;
            this.dgvTopic.AllowUserToDeleteRows = false;
            this.dgvTopic.AllowUserToResizeRows = false;
            this.dgvTopic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic.Location = new System.Drawing.Point(467, 172);
            this.dgvTopic.Name = "dgvTopic";
            this.dgvTopic.ReadOnly = true;
            this.dgvTopic.RowHeadersVisible = false;
            this.dgvTopic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopic.Size = new System.Drawing.Size(435, 382);
            this.dgvTopic.TabIndex = 7;
            this.dgvTopic.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTopic_DataBindingComplete);
            this.dgvTopic.SelectionChanged += new System.EventHandler(this.dgvTopic_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(753, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 100);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnModuleTopic);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 100);
            this.panel5.TabIndex = 0;
            // 
            // btnModuleTopic
            // 
            this.btnModuleTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnModuleTopic.FlatAppearance.BorderSize = 0;
            this.btnModuleTopic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnModuleTopic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnModuleTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnModuleTopic.Location = new System.Drawing.Point(15, 29);
            this.btnModuleTopic.Name = "btnModuleTopic";
            this.btnModuleTopic.Size = new System.Drawing.Size(106, 38);
            this.btnModuleTopic.TabIndex = 2;
            this.btnModuleTopic.Text = "Add Topic to Module";
            this.btnModuleTopic.UseVisualStyleBackColor = false;
            this.btnModuleTopic.Click += new System.EventHandler(this.btnModuleTopic_Click);
            // 
            // pnlModuleTopic
            // 
            this.pnlModuleTopic.Controls.Add(this.pnlModuleTopicDialog);
            this.pnlModuleTopic.Controls.Add(this.panel7);
            this.pnlModuleTopic.Controls.Add(this.panel4);
            this.pnlModuleTopic.Controls.Add(this.dgvModuleTopic);
            this.pnlModuleTopic.Location = new System.Drawing.Point(0, 0);
            this.pnlModuleTopic.Name = "pnlModuleTopic";
            this.pnlModuleTopic.Size = new System.Drawing.Size(914, 575);
            this.pnlModuleTopic.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(753, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 100);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBack);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 100);
            this.panel6.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnBack.Location = new System.Drawing.Point(15, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvModuleTopic
            // 
            this.dgvModuleTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleTopic.Location = new System.Drawing.Point(20, 145);
            this.dgvModuleTopic.Name = "dgvModuleTopic";
            this.dgvModuleTopic.Size = new System.Drawing.Size(873, 409);
            this.dgvModuleTopic.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAddTopicModule);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(137, 100);
            this.panel8.TabIndex = 0;
            // 
            // btnAddTopicModule
            // 
            this.btnAddTopicModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnAddTopicModule.FlatAppearance.BorderSize = 0;
            this.btnAddTopicModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnAddTopicModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnAddTopicModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopicModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnAddTopicModule.Location = new System.Drawing.Point(15, 29);
            this.btnAddTopicModule.Name = "btnAddTopicModule";
            this.btnAddTopicModule.Size = new System.Drawing.Size(106, 38);
            this.btnAddTopicModule.TabIndex = 2;
            this.btnAddTopicModule.Text = "Add Topic to Module";
            this.btnAddTopicModule.UseVisualStyleBackColor = false;
            this.btnAddTopicModule.Click += new System.EventHandler(this.btnAddTopicModule_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(20, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(498, 100);
            this.panel7.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnDeleteTopicModule);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(274, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(137, 100);
            this.panel9.TabIndex = 8;
            // 
            // btnDeleteTopicModule
            // 
            this.btnDeleteTopicModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnDeleteTopicModule.FlatAppearance.BorderSize = 0;
            this.btnDeleteTopicModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTopicModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDeleteTopicModule.Location = new System.Drawing.Point(21, 29);
            this.btnDeleteTopicModule.Name = "btnDeleteTopicModule";
            this.btnDeleteTopicModule.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteTopicModule.TabIndex = 4;
            this.btnDeleteTopicModule.Text = "Delete";
            this.btnDeleteTopicModule.UseVisualStyleBackColor = false;
            this.btnDeleteTopicModule.Click += new System.EventHandler(this.btnDeleteModuleTopic_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnUpdateTopicModule);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(137, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(137, 100);
            this.panel10.TabIndex = 7;
            // 
            // btnUpdateTopicModule
            // 
            this.btnUpdateTopicModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.btnUpdateTopicModule.FlatAppearance.BorderSize = 0;
            this.btnUpdateTopicModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTopicModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.btnUpdateTopicModule.Location = new System.Drawing.Point(17, 29);
            this.btnUpdateTopicModule.Name = "btnUpdateTopicModule";
            this.btnUpdateTopicModule.Size = new System.Drawing.Size(105, 38);
            this.btnUpdateTopicModule.TabIndex = 3;
            this.btnUpdateTopicModule.Text = "Update";
            this.btnUpdateTopicModule.UseVisualStyleBackColor = false;
            this.btnUpdateTopicModule.Click += new System.EventHandler(this.btnUpdateModuleTopic_Click);
            // 
            // pnlModuleTopicDialog
            // 
            this.pnlModuleTopicDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlModuleTopicDialog.Controls.Add(this.cmbModule);
            this.pnlModuleTopicDialog.Controls.Add(this.lblTopic);
            this.pnlModuleTopicDialog.Controls.Add(this.cmbTopic);
            this.pnlModuleTopicDialog.Controls.Add(this.lblModule);
            this.pnlModuleTopicDialog.Controls.Add(this.label3);
            this.pnlModuleTopicDialog.Controls.Add(this.label4);
            this.pnlModuleTopicDialog.Controls.Add(this.btnSubmitModuleTopic);
            this.pnlModuleTopicDialog.Location = new System.Drawing.Point(258, 191);
            this.pnlModuleTopicDialog.Name = "pnlModuleTopicDialog";
            this.pnlModuleTopicDialog.Size = new System.Drawing.Size(402, 207);
            this.pnlModuleTopicDialog.TabIndex = 10;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.Color.White;
            this.lblTopic.Location = new System.Drawing.Point(18, 131);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(34, 13);
            this.lblTopic.TabIndex = 8;
            this.lblTopic.Text = "Topic";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(196, 128);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(190, 21);
            this.cmbTopic.TabIndex = 7;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(18, 105);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(42, 13);
            this.lblModule.TabIndex = 5;
            this.lblModule.Text = "Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter module details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Insert Module";
            // 
            // btnSubmitModuleTopic
            // 
            this.btnSubmitModuleTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(244)))));
            this.btnSubmitModuleTopic.FlatAppearance.BorderSize = 0;
            this.btnSubmitModuleTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitModuleTopic.Location = new System.Drawing.Point(311, 164);
            this.btnSubmitModuleTopic.Name = "btnSubmitModuleTopic";
            this.btnSubmitModuleTopic.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitModuleTopic.TabIndex = 0;
            this.btnSubmitModuleTopic.Text = "Add";
            this.btnSubmitModuleTopic.UseVisualStyleBackColor = false;
            this.btnSubmitModuleTopic.Click += new System.EventHandler(this.btnSubmitModuleTopic_Click);
            // 
            // cmbModule
            // 
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(196, 102);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(190, 21);
            this.cmbModule.TabIndex = 9;
            // 
            // ucModuleTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pnlModuleTopic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlModuleDialog);
            this.Controls.Add(this.dgvTopic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvModule);
            this.Name = "ucModuleTopic";
            this.Size = new System.Drawing.Size(914, 575);
            this.Load += new System.EventHandler(this.ucModuleTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.pnlModuleDialog.ResumeLayout(false);
            this.pnlModuleDialog.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDeleteBtn.ResumeLayout(false);
            this.pnlUpdateBtn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlInsertBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlModuleTopic.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleTopic)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.pnlModuleTopicDialog.ResumeLayout(false);
            this.pnlModuleTopicDialog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.Panel pnlModuleDialog;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblAddDesc;
        private System.Windows.Forms.Label lblModuleTopic;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlInsertBtn;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.DataGridView dgvTopic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnModuleTopic;
        private System.Windows.Forms.Panel pnlDeleteBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Panel pnlModuleTopic;
        private System.Windows.Forms.DataGridView dgvModuleTopic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnDeleteTopicModule;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnUpdateTopicModule;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddTopicModule;
        private System.Windows.Forms.Panel pnlModuleTopicDialog;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitModuleTopic;
    }
}
