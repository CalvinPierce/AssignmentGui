namespace AssignmentGui
{
    partial class ViewRegistrationsForm
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
            this.menuStripRegHome = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHomeMenuReg = new System.Windows.Forms.Button();
            this.txtViewReg = new System.Windows.Forms.TextBox();
            this.menuStripRegHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripRegHome
            // 
            this.menuStripRegHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripRegHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripRegHome.Name = "menuStripRegHome";
            this.menuStripRegHome.Size = new System.Drawing.Size(800, 24);
            this.menuStripRegHome.TabIndex = 2;
            this.menuStripRegHome.Text = "menuStripRegistration";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerOptionsToolStripMenuItem
            // 
            this.customerOptionsToolStripMenuItem.Name = "customerOptionsToolStripMenuItem";
            this.customerOptionsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.customerOptionsToolStripMenuItem.Text = "Customer Options";
            this.customerOptionsToolStripMenuItem.Click += new System.EventHandler(this.customerOptionsToolStripMenuItem_Click);
            // 
            // eventOptionsToolStripMenuItem
            // 
            this.eventOptionsToolStripMenuItem.Name = "eventOptionsToolStripMenuItem";
            this.eventOptionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.eventOptionsToolStripMenuItem.Text = "Event Options";
            this.eventOptionsToolStripMenuItem.Click += new System.EventHandler(this.eventOptionsToolStripMenuItem_Click);
            // 
            // registrationOptionsToolStripMenuItem
            // 
            this.registrationOptionsToolStripMenuItem.Name = "registrationOptionsToolStripMenuItem";
            this.registrationOptionsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.registrationOptionsToolStripMenuItem.Text = "Registration Options";
            this.registrationOptionsToolStripMenuItem.Click += new System.EventHandler(this.registrationOptionsToolStripMenuItem_Click);
            // 
            // btnHomeMenuReg
            // 
            this.btnHomeMenuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuReg.Location = new System.Drawing.Point(258, 371);
            this.btnHomeMenuReg.Name = "btnHomeMenuReg";
            this.btnHomeMenuReg.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuReg.TabIndex = 19;
            this.btnHomeMenuReg.Text = "Return To Registration Menu";
            this.btnHomeMenuReg.UseVisualStyleBackColor = true;
            this.btnHomeMenuReg.Click += new System.EventHandler(this.btnHomeMenuReg_Click);
            // 
            // txtViewReg
            // 
            this.txtViewReg.Location = new System.Drawing.Point(149, 60);
            this.txtViewReg.Multiline = true;
            this.txtViewReg.Name = "txtViewReg";
            this.txtViewReg.ReadOnly = true;
            this.txtViewReg.Size = new System.Drawing.Size(480, 241);
            this.txtViewReg.TabIndex = 20;
            // 
            // ViewRegistrationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViewReg);
            this.Controls.Add(this.btnHomeMenuReg);
            this.Controls.Add(this.menuStripRegHome);
            this.Name = "ViewRegistrationsForm";
            this.Text = "ViewRegistrationsForm";
            this.Load += new System.EventHandler(this.ViewRegistrationsForm_Load);
            this.menuStripRegHome.ResumeLayout(false);
            this.menuStripRegHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRegHome;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Button btnHomeMenuReg;
        private System.Windows.Forms.TextBox txtViewReg;
    }
}