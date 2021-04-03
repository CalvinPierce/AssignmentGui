namespace AssignmentGui
{
    partial class AddRegistrationForm
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
            this.txtGetEventId = new System.Windows.Forms.TextBox();
            this.txtGetCustId = new System.Windows.Forms.TextBox();
            this.lblGetEventId = new System.Windows.Forms.Label();
            this.lblGetCustId = new System.Windows.Forms.Label();
            this.btnExitAdd = new System.Windows.Forms.Button();
            this.lblAddOutcome = new System.Windows.Forms.Label();
            this.btnAddReg = new System.Windows.Forms.Button();
            this.txtInfoList = new System.Windows.Forms.TextBox();
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
            this.menuStripRegHome.TabIndex = 3;
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
            // txtGetEventId
            // 
            this.txtGetEventId.Location = new System.Drawing.Point(395, 287);
            this.txtGetEventId.Name = "txtGetEventId";
            this.txtGetEventId.Size = new System.Drawing.Size(204, 20);
            this.txtGetEventId.TabIndex = 14;
            // 
            // txtGetCustId
            // 
            this.txtGetCustId.Location = new System.Drawing.Point(395, 249);
            this.txtGetCustId.Name = "txtGetCustId";
            this.txtGetCustId.Size = new System.Drawing.Size(204, 20);
            this.txtGetCustId.TabIndex = 13;
            // 
            // lblGetEventId
            // 
            this.lblGetEventId.AutoSize = true;
            this.lblGetEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetEventId.Location = new System.Drawing.Point(12, 287);
            this.lblGetEventId.Name = "lblGetEventId";
            this.lblGetEventId.Size = new System.Drawing.Size(228, 20);
            this.lblGetEventId.TabIndex = 12;
            this.lblGetEventId.Text = "Please Enter The Events Id";
            // 
            // lblGetCustId
            // 
            this.lblGetCustId.AutoSize = true;
            this.lblGetCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCustId.Location = new System.Drawing.Point(12, 249);
            this.lblGetCustId.Name = "lblGetCustId";
            this.lblGetCustId.Size = new System.Drawing.Size(263, 20);
            this.lblGetCustId.TabIndex = 11;
            this.lblGetCustId.Text = "Please Enter The Customer\'s Id";
            // 
            // btnExitAdd
            // 
            this.btnExitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAdd.Location = new System.Drawing.Point(248, 410);
            this.btnExitAdd.Name = "btnExitAdd";
            this.btnExitAdd.Size = new System.Drawing.Size(256, 28);
            this.btnExitAdd.TabIndex = 17;
            this.btnExitAdd.Text = "Return To Registration Menu";
            this.btnExitAdd.UseVisualStyleBackColor = true;
            this.btnExitAdd.Click += new System.EventHandler(this.btnExitAdd_Click);
            // 
            // lblAddOutcome
            // 
            this.lblAddOutcome.AutoSize = true;
            this.lblAddOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOutcome.Location = new System.Drawing.Point(232, 379);
            this.lblAddOutcome.Name = "lblAddOutcome";
            this.lblAddOutcome.Size = new System.Drawing.Size(0, 20);
            this.lblAddOutcome.TabIndex = 16;
            // 
            // btnAddReg
            // 
            this.btnAddReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReg.Location = new System.Drawing.Point(312, 323);
            this.btnAddReg.Name = "btnAddReg";
            this.btnAddReg.Size = new System.Drawing.Size(96, 30);
            this.btnAddReg.TabIndex = 15;
            this.btnAddReg.Text = "Add";
            this.btnAddReg.UseVisualStyleBackColor = true;
            this.btnAddReg.Click += new System.EventHandler(this.btnAddReg_Click);
            // 
            // txtInfoList
            // 
            this.txtInfoList.Location = new System.Drawing.Point(163, 27);
            this.txtInfoList.Multiline = true;
            this.txtInfoList.Name = "txtInfoList";
            this.txtInfoList.ReadOnly = true;
            this.txtInfoList.Size = new System.Drawing.Size(425, 200);
            this.txtInfoList.TabIndex = 18;
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInfoList);
            this.Controls.Add(this.btnExitAdd);
            this.Controls.Add(this.lblAddOutcome);
            this.Controls.Add(this.btnAddReg);
            this.Controls.Add(this.txtGetEventId);
            this.Controls.Add(this.txtGetCustId);
            this.Controls.Add(this.lblGetEventId);
            this.Controls.Add(this.lblGetCustId);
            this.Controls.Add(this.menuStripRegHome);
            this.Name = "AddRegistrationForm";
            this.Text = "AddRegistrationForm";
            this.Load += new System.EventHandler(this.AddRegistrationForm_Load);
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
        private System.Windows.Forms.TextBox txtGetEventId;
        private System.Windows.Forms.TextBox txtGetCustId;
        private System.Windows.Forms.Label lblGetEventId;
        private System.Windows.Forms.Label lblGetCustId;
        private System.Windows.Forms.Button btnExitAdd;
        private System.Windows.Forms.Label lblAddOutcome;
        private System.Windows.Forms.Button btnAddReg;
        private System.Windows.Forms.TextBox txtInfoList;
    }
}