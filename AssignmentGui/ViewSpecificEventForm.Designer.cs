namespace AssignmentGui
{
    partial class ViewSpecificEventForm
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
            this.btnHomeMenuEvent = new System.Windows.Forms.Button();
            this.txtGetId = new System.Windows.Forms.TextBox();
            this.lblGetId = new System.Windows.Forms.Label();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.txtViewEvents = new System.Windows.Forms.TextBox();
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
            this.menuStripEventHome.TabIndex = 4;
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
            // btnHomeMenuEvent
            // 
            this.btnHomeMenuEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuEvent.Location = new System.Drawing.Point(277, 385);
            this.btnHomeMenuEvent.Name = "btnHomeMenuEvent";
            this.btnHomeMenuEvent.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuEvent.TabIndex = 12;
            this.btnHomeMenuEvent.Text = "Return To Events Menu";
            this.btnHomeMenuEvent.UseVisualStyleBackColor = true;
            this.btnHomeMenuEvent.Click += new System.EventHandler(this.btnHomeMenuEvent_Click);
            // 
            // txtGetId
            // 
            this.txtGetId.Location = new System.Drawing.Point(348, 295);
            this.txtGetId.Name = "txtGetId";
            this.txtGetId.Size = new System.Drawing.Size(203, 20);
            this.txtGetId.TabIndex = 15;
            // 
            // lblGetId
            // 
            this.lblGetId.AutoSize = true;
            this.lblGetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetId.Location = new System.Drawing.Point(12, 295);
            this.lblGetId.Name = "lblGetId";
            this.lblGetId.Size = new System.Drawing.Size(279, 20);
            this.lblGetId.TabIndex = 14;
            this.lblGetId.Text = "Please Enter An Event Id To View";
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvent.Location = new System.Drawing.Point(277, 349);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(292, 30);
            this.btnViewEvent.TabIndex = 16;
            this.btnViewEvent.Text = "View Event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // txtViewEvents
            // 
            this.txtViewEvents.Location = new System.Drawing.Point(138, 35);
            this.txtViewEvents.Multiline = true;
            this.txtViewEvents.Name = "txtViewEvents";
            this.txtViewEvents.ReadOnly = true;
            this.txtViewEvents.Size = new System.Drawing.Size(480, 241);
            this.txtViewEvents.TabIndex = 17;
            // 
            // ViewSpecificEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViewEvents);
            this.Controls.Add(this.btnViewEvent);
            this.Controls.Add(this.txtGetId);
            this.Controls.Add(this.lblGetId);
            this.Controls.Add(this.btnHomeMenuEvent);
            this.Controls.Add(this.menuStripEventHome);
            this.Name = "ViewSpecificEventForm";
            this.Text = "ViewSpecificEventForm";
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
        private System.Windows.Forms.Button btnHomeMenuEvent;
        private System.Windows.Forms.TextBox txtGetId;
        private System.Windows.Forms.Label lblGetId;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.TextBox txtViewEvents;
    }
}