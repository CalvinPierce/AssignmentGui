namespace AssignmentGui
{
    partial class AddEventForm
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
            this.btnExitAdd = new System.Windows.Forms.Button();
            this.txtGetDay = new System.Windows.Forms.TextBox();
            this.txtGetVenue = new System.Windows.Forms.TextBox();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.lblAddOutcome = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblGetDay = new System.Windows.Forms.Label();
            this.lblGetVenu = new System.Windows.Forms.Label();
            this.lblGetName = new System.Windows.Forms.Label();
            this.txtGetMonth = new System.Windows.Forms.TextBox();
            this.lblGetMonth = new System.Windows.Forms.Label();
            this.txtGetYear = new System.Windows.Forms.TextBox();
            this.lblGetYear = new System.Windows.Forms.Label();
            this.txtGetHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGetMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            // btnExitAdd
            // 
            this.btnExitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAdd.Location = new System.Drawing.Point(264, 410);
            this.btnExitAdd.Name = "btnExitAdd";
            this.btnExitAdd.Size = new System.Drawing.Size(256, 28);
            this.btnExitAdd.TabIndex = 21;
            this.btnExitAdd.Text = "Return To Event Menu";
            this.btnExitAdd.UseVisualStyleBackColor = true;
            this.btnExitAdd.Click += new System.EventHandler(this.btnExitAdd_Click);
            // 
            // txtGetDay
            // 
            this.txtGetDay.Location = new System.Drawing.Point(328, 100);
            this.txtGetDay.Name = "txtGetDay";
            this.txtGetDay.Size = new System.Drawing.Size(204, 20);
            this.txtGetDay.TabIndex = 20;
            // 
            // txtGetVenue
            // 
            this.txtGetVenue.Location = new System.Drawing.Point(328, 65);
            this.txtGetVenue.Name = "txtGetVenue";
            this.txtGetVenue.Size = new System.Drawing.Size(204, 20);
            this.txtGetVenue.TabIndex = 19;
            // 
            // txtGetName
            // 
            this.txtGetName.Location = new System.Drawing.Point(328, 34);
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(204, 20);
            this.txtGetName.TabIndex = 18;
            // 
            // lblAddOutcome
            // 
            this.lblAddOutcome.AutoSize = true;
            this.lblAddOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOutcome.Location = new System.Drawing.Point(199, 379);
            this.lblAddOutcome.Name = "lblAddOutcome";
            this.lblAddOutcome.Size = new System.Drawing.Size(0, 20);
            this.lblAddOutcome.TabIndex = 17;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(328, 338);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(96, 30);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblGetDay
            // 
            this.lblGetDay.AutoSize = true;
            this.lblGetDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetDay.Location = new System.Drawing.Point(12, 98);
            this.lblGetDay.Name = "lblGetDay";
            this.lblGetDay.Size = new System.Drawing.Size(293, 40);
            this.lblGetDay.TabIndex = 15;
            this.lblGetDay.Text = "Please Enter The Day Of The Event\r\n(As An Integer)\r\n";
            // 
            // lblGetVenu
            // 
            this.lblGetVenu.AutoSize = true;
            this.lblGetVenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetVenu.Location = new System.Drawing.Point(12, 65);
            this.lblGetVenu.Name = "lblGetVenu";
            this.lblGetVenu.Size = new System.Drawing.Size(264, 20);
            this.lblGetVenu.TabIndex = 14;
            this.lblGetVenu.Text = "Please Enter The Events Venue";
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetName.Location = new System.Drawing.Point(12, 34);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(258, 20);
            this.lblGetName.TabIndex = 13;
            this.lblGetName.Text = "Please Enter The Events Name";
            // 
            // txtGetMonth
            // 
            this.txtGetMonth.Location = new System.Drawing.Point(328, 140);
            this.txtGetMonth.Name = "txtGetMonth";
            this.txtGetMonth.Size = new System.Drawing.Size(204, 20);
            this.txtGetMonth.TabIndex = 23;
            // 
            // lblGetMonth
            // 
            this.lblGetMonth.AutoSize = true;
            this.lblGetMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetMonth.Location = new System.Drawing.Point(12, 138);
            this.lblGetMonth.Name = "lblGetMonth";
            this.lblGetMonth.Size = new System.Drawing.Size(312, 40);
            this.lblGetMonth.TabIndex = 22;
            this.lblGetMonth.Text = "Please Enter The Month Of The Event\r\n(As An Integer)";
            // 
            // txtGetYear
            // 
            this.txtGetYear.Location = new System.Drawing.Point(328, 181);
            this.txtGetYear.Name = "txtGetYear";
            this.txtGetYear.Size = new System.Drawing.Size(204, 20);
            this.txtGetYear.TabIndex = 25;
            // 
            // lblGetYear
            // 
            this.lblGetYear.AutoSize = true;
            this.lblGetYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetYear.Location = new System.Drawing.Point(12, 181);
            this.lblGetYear.Name = "lblGetYear";
            this.lblGetYear.Size = new System.Drawing.Size(300, 20);
            this.lblGetYear.TabIndex = 24;
            this.lblGetYear.Text = "Please Enter The Year Of The Event";
            // 
            // txtGetHour
            // 
            this.txtGetHour.Location = new System.Drawing.Point(328, 223);
            this.txtGetHour.Name = "txtGetHour";
            this.txtGetHour.Size = new System.Drawing.Size(204, 20);
            this.txtGetHour.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "Please Enter The Hour The Event\r\nStarts In 24 Hour Format";
            // 
            // txtGetMinute
            // 
            this.txtGetMinute.Location = new System.Drawing.Point(328, 261);
            this.txtGetMinute.Name = "txtGetMinute";
            this.txtGetMinute.Size = new System.Drawing.Size(204, 20);
            this.txtGetMinute.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 40);
            this.label4.TabIndex = 28;
            this.label4.Text = "Please Enter The Minute\r\nThe Event Starts\r\n";
            // 
            // txtGetMax
            // 
            this.txtGetMax.Location = new System.Drawing.Point(328, 301);
            this.txtGetMax.Name = "txtGetMax";
            this.txtGetMax.Size = new System.Drawing.Size(204, 20);
            this.txtGetMax.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Please Enter The Maximum Attendees";
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGetMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGetMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGetHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGetYear);
            this.Controls.Add(this.lblGetYear);
            this.Controls.Add(this.txtGetMonth);
            this.Controls.Add(this.lblGetMonth);
            this.Controls.Add(this.btnExitAdd);
            this.Controls.Add(this.txtGetDay);
            this.Controls.Add(this.txtGetVenue);
            this.Controls.Add(this.txtGetName);
            this.Controls.Add(this.lblAddOutcome);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lblGetDay);
            this.Controls.Add(this.lblGetVenu);
            this.Controls.Add(this.lblGetName);
            this.Controls.Add(this.menuStripEventHome);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
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
        private System.Windows.Forms.Button btnExitAdd;
        private System.Windows.Forms.TextBox txtGetDay;
        private System.Windows.Forms.TextBox txtGetVenue;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.Label lblAddOutcome;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label lblGetDay;
        private System.Windows.Forms.Label lblGetVenu;
        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.TextBox txtGetMonth;
        private System.Windows.Forms.Label lblGetMonth;
        private System.Windows.Forms.TextBox txtGetYear;
        private System.Windows.Forms.Label lblGetYear;
        private System.Windows.Forms.TextBox txtGetHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGetMax;
        private System.Windows.Forms.Label label5;
    }
}