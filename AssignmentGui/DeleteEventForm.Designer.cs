namespace AssignmentGui
{
    partial class DeleteEventForm
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
            this.menuStripEventHome = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnHomeMenuCust = new System.Windows.Forms.Button();
            this.txtGetId = new System.Windows.Forms.TextBox();
            this.lblGetEventId = new System.Windows.Forms.Label();
            this.txtViewEvent = new System.Windows.Forms.TextBox();
            this.menuStripEventHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripEventHome
            // 
            this.menuStripEventHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripEventHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripEventHome.Name = "menuStripEventHome";
            this.menuStripEventHome.Size = new System.Drawing.Size(800, 24);
            this.menuStripEventHome.TabIndex = 2;
            this.menuStripEventHome.Text = "menuStrip1";
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
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.Location = new System.Drawing.Point(250, 355);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(292, 30);
            this.btnDeleteEvent.TabIndex = 21;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnHomeMenuCust
            // 
            this.btnHomeMenuCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuCust.Location = new System.Drawing.Point(250, 391);
            this.btnHomeMenuCust.Name = "btnHomeMenuCust";
            this.btnHomeMenuCust.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuCust.TabIndex = 20;
            this.btnHomeMenuCust.Text = "Return To Event Menu";
            this.btnHomeMenuCust.UseVisualStyleBackColor = true;
            this.btnHomeMenuCust.Click += new System.EventHandler(this.btnHomeMenuCust_Click);
            // 
            // txtGetId
            // 
            this.txtGetId.Location = new System.Drawing.Point(492, 312);
            this.txtGetId.Name = "txtGetId";
            this.txtGetId.Size = new System.Drawing.Size(204, 20);
            this.txtGetId.TabIndex = 19;
            // 
            // lblGetEventId
            // 
            this.lblGetEventId.AutoSize = true;
            this.lblGetEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetEventId.Location = new System.Drawing.Point(104, 312);
            this.lblGetEventId.Name = "lblGetEventId";
            this.lblGetEventId.Size = new System.Drawing.Size(314, 40);
            this.lblGetEventId.TabIndex = 18;
            this.lblGetEventId.Text = "Please Enter The Events ID To Delete\r\n\r\n";
            // 
            // txtViewEvent
            // 
            this.txtViewEvent.Location = new System.Drawing.Point(155, 38);
            this.txtViewEvent.Multiline = true;
            this.txtViewEvent.Name = "txtViewEvent";
            this.txtViewEvent.ReadOnly = true;
            this.txtViewEvent.Size = new System.Drawing.Size(480, 241);
            this.txtViewEvent.TabIndex = 22;
            // 
            // DeleteEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViewEvent);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnHomeMenuCust);
            this.Controls.Add(this.txtGetId);
            this.Controls.Add(this.lblGetEventId);
            this.Controls.Add(this.menuStripEventHome);
            this.Name = "DeleteEventForm";
            this.Text = "DeleteEventForm";
            this.Load += new System.EventHandler(this.DeleteEventForm_Load);
            this.menuStripEventHome.ResumeLayout(false);
            this.menuStripEventHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripEventHome;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnHomeMenuCust;
        private System.Windows.Forms.TextBox txtGetId;
        private System.Windows.Forms.Label lblGetEventId;
        private System.Windows.Forms.TextBox txtViewEvent;
    }
}