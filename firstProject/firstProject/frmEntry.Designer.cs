namespace FirstProject
{
    partial class frmEntry
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
            btnEnter = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.AccessibleRole = AccessibleRole.IpAddress;
            btnEnter.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.Location = new Point(61, 84);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(137, 60);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(253, 84);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 60);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 204);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Name = "frmEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntry";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnter;
        private Button btnExit;
    }
}