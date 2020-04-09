namespace JoshuaGaldamez.VISTA
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTUDIANTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDIANTESToolStripMenuItem,
            this.mATERIASToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // eSTUDIANTESToolStripMenuItem
            // 
            this.eSTUDIANTESToolStripMenuItem.Name = "eSTUDIANTESToolStripMenuItem";
            this.eSTUDIANTESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eSTUDIANTESToolStripMenuItem.Text = "ESTUDIANTES";
            this.eSTUDIANTESToolStripMenuItem.Click += new System.EventHandler(this.eSTUDIANTESToolStripMenuItem_Click);
            // 
            // mATERIASToolStripMenuItem
            // 
            this.mATERIASToolStripMenuItem.Name = "mATERIASToolStripMenuItem";
            this.mATERIASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mATERIASToolStripMenuItem.Text = "MATERIAS";
            this.mATERIASToolStripMenuItem.Click += new System.EventHandler(this.mATERIASToolStripMenuItem_Click);
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            this.nOTASToolStripMenuItem.Click += new System.EventHandler(this.nOTASToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIANTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATERIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
    }
}