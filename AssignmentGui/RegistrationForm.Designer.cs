namespace AssignmentGui
{
    partial class RegistrationForm
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
            this.lblRegHome = new System.Windows.Forms.Label();
            this.btnHomeMenuReg = new System.Windows.Forms.Button();
            this.btnViewRegs = new System.Windows.Forms.Button();
            this.btnRegEvent = new System.Windows.Forms.Button();
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
            this.menuStripRegHome.TabIndex = 1;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // lblRegHome
            // 
            this.lblRegHome.AutoSize = true;
            this.lblRegHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegHome.Location = new System.Drawing.Point(264, 108);
            this.lblRegHome.Name = "lblRegHome";
            this.lblRegHome.Size = new System.Drawing.Size(282, 40);
            this.lblRegHome.TabIndex = 19;
            this.lblRegHome.Text = "Group Event Management Limited\r\n             Registration Menu";
            // 
            // btnHomeMenuReg
            // 
            this.btnHomeMenuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuReg.Location = new System.Drawing.Point(254, 238);
            this.btnHomeMenuReg.Name = "btnHomeMenuReg";
            this.btnHomeMenuReg.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuReg.TabIndex = 18;
            this.btnHomeMenuReg.Text = "Return To Main Menu";
            this.btnHomeMenuReg.UseVisualStyleBackColor = true;
            this.btnHomeMenuReg.Click += new System.EventHandler(this.btnHomeMenuReg_Click);
            // 
            // btnViewRegs
            // 
            this.btnViewRegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRegs.Location = new System.Drawing.Point(254, 204);
            this.btnViewRegs.Name = "btnViewRegs";
            this.btnViewRegs.Size = new System.Drawing.Size(292, 28);
            this.btnViewRegs.TabIndex = 15;
            this.btnViewRegs.Text = "View Registrations";
            this.btnViewRegs.UseVisualStyleBackColor = true;
            this.btnViewRegs.Click += new System.EventHandler(this.btnViewRegs_Click);
            // 
            // btnRegEvent
            // 
            this.btnRegEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEvent.Location = new System.Drawing.Point(254, 169);
            this.btnRegEvent.Name = "btnRegEvent";
            this.btnRegEvent.Size = new System.Drawing.Size(292, 29);
            this.btnRegEvent.TabIndex = 14;
            this.btnRegEvent.Text = "RSVP For Event";
            this.btnRegEvent.UseVisualStyleBackColor = true;
            this.btnRegEvent.Click += new System.EventHandler(this.btnRegEvent_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegHome);
            this.Controls.Add(this.btnHomeMenuReg);
            this.Controls.Add(this.btnViewRegs);
            this.Controls.Add(this.btnRegEvent);
            this.Controls.Add(this.menuStripRegHome);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
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
        private System.Windows.Forms.Label lblRegHome;
        private System.Windows.Forms.Button btnHomeMenuReg;
        private System.Windows.Forms.Button btnViewRegs;
        private System.Windows.Forms.Button btnRegEvent;
    }
}