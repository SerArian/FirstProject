namespace FirstProject
{
    partial class frmMain
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
            lblID = new Label();
            lblName = new Label();
            lblMUnit = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            btnExit = new Button();
            panel1 = new Panel();
            cmbMUnit = new ComboBox();
            groupBox1 = new GroupBox();
            rbDatabase = new RadioButton();
            rbMemory = new RadioButton();
            panel2 = new Panel();
            btnInsert = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(12, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 30);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 30);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblMUnit
            // 
            lblMUnit.AutoSize = true;
            lblMUnit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblMUnit.Location = new Point(12, 62);
            lblMUnit.Name = "lblMUnit";
            lblMUnit.Size = new Size(206, 30);
            lblMUnit.TabIndex = 2;
            lblMUnit.Text = "Measurement Unit";
            // 
            // txtID
            // 
            txtID.Location = new Point(224, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(153, 23);
            txtID.TabIndex = 0;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(224, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 23);
            txtName.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(725, 15);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = "BACK";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMUnit);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblMUnit);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 100);
            panel1.TabIndex = 5;
            // 
            // cmbMUnit
            // 
            cmbMUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMUnit.FormattingEnabled = true;
            cmbMUnit.Items.AddRange(new object[] { "TEM", "KG", "LT", "MET", "ΚΙΒ" });
            cmbMUnit.Location = new Point(224, 68);
            cmbMUnit.Name = "cmbMUnit";
            cmbMUnit.Size = new Size(153, 23);
            cmbMUnit.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDatabase);
            groupBox1.Controls.Add(rbMemory);
            groupBox1.Location = new Point(423, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbDatabase
            // 
            rbDatabase.AutoSize = true;
            rbDatabase.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rbDatabase.Location = new Point(153, 33);
            rbDatabase.Name = "rbDatabase";
            rbDatabase.Size = new Size(109, 29);
            rbDatabase.TabIndex = 5;
            rbDatabase.TabStop = true;
            rbDatabase.Text = "Database";
            rbDatabase.UseVisualStyleBackColor = true;
            // 
            // rbMemory
            // 
            rbMemory.AutoSize = true;
            rbMemory.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rbMemory.Location = new Point(34, 33);
            rbMemory.Name = "rbMemory";
            rbMemory.Size = new Size(102, 29);
            rbMemory.TabIndex = 6;
            rbMemory.TabStop = true;
            rbMemory.Text = "Memory";
            rbMemory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 100);
            panel2.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(24, 15);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(136, 60);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(548, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(195, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 60);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(370, 15);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 60);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(865, 297);
            dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "MeasurementUnit";
            dataGridViewTextBoxColumn3.HeaderText = "Measurement Unit";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 497);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblID;
        private Label lblName;
        private Label lblMUnit;
        private TextBox txtID;
        private TextBox txtName;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton rbDatabase;
        private RadioButton rbMemory;
        private Button btnInsert;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnSave;
        private ComboBox cmbMUnit;
    }
}