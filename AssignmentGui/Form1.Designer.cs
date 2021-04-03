namespace AssignmentGui
{
    partial class Form1
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
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHomeMessage = new System.Windows.Forms.Label();
            this.btnCustMenu = new System.Windows.Forms.Button();
            this.btnEventMenu = new System.Windows.Forms.Button();
            this.btnRegMenu = new System.Windows.Forms.Button();
            this.btnHomeExit = new System.Windows.Forms.Button();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(800, 24);
            this.menuStripHome.TabIndex = 0;
            this.menuStripHome.Text = "menuStrip1";
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
            // lblHomeMessage
            // 
            this.lblHomeMessage.AutoSize = true;
            this.lblHomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeMessage.Location = new System.Drawing.Point(170, 76);
            this.lblHomeMessage.Name = "lblHomeMessage";
            this.lblHomeMessage.Size = new System.Drawing.Size(426, 40);
            this.lblHomeMessage.TabIndex = 1;
            this.lblHomeMessage.Text = "Welcome To Group Event Mangement Limited\r\nPlease Click One Of The Buttons Below T" +
    "o Continue";
            // 
            // btnCustMenu
            // 
            this.btnCustMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustMenu.Location = new System.Drawing.Point(268, 160);
            this.btnCustMenu.Name = "btnCustMenu";
            this.btnCustMenu.Size = new System.Drawing.Size(207, 34);
            this.btnCustMenu.TabIndex = 2;
            this.btnCustMenu.Text = "Customer Options";
            this.btnCustMenu.UseVisualStyleBackColor = true;
            this.btnCustMenu.Click += new System.EventHandler(this.btnCustMenu_Click);
            // 
            // btnEventMenu
            // 
            this.btnEventMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventMenu.Location = new System.Drawing.Point(268, 211);
            this.btnEventMenu.Name = "btnEventMenu";
            this.btnEventMenu.Size = new System.Drawing.Size(207, 34);
            this.btnEventMenu.TabIndex = 3;
            this.btnEventMenu.Text = "Event Options";
            this.btnEventMenu.UseVisualStyleBackColor = true;
            this.btnEventMenu.Click += new System.EventHandler(this.btnEventMenu_Click);
            // 
            // btnRegMenu
            // 
            this.btnRegMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegMenu.Location = new System.Drawing.Point(268, 262);
            this.btnRegMenu.Name = "btnRegMenu";
            this.btnRegMenu.Size = new System.Drawing.Size(207, 34);
            this.btnRegMenu.TabIndex = 4;
            this.btnRegMenu.Text = "Registration Options";
            this.btnRegMenu.UseVisualStyleBackColor = true;
            this.btnRegMenu.Click += new System.EventHandler(this.btnRegMenu_Click);
            // 
            // btnHomeExit
            // 
            this.btnHomeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeExit.Location = new System.Drawing.Point(268, 312);
            this.btnHomeExit.Name = "btnHomeExit";
            this.btnHomeExit.Size = new System.Drawing.Size(207, 34);
            this.btnHomeExit.TabIndex = 5;
            this.btnHomeExit.Text = "Exit";
            this.btnHomeExit.UseVisualStyleBackColor = true;
            this.btnHomeExit.Click += new System.EventHandler(this.btnHomeExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomeExit);
            this.Controls.Add(this.btnRegMenu);
            this.Controls.Add(this.btnEventMenu);
            this.Controls.Add(this.btnCustMenu);
            this.Controls.Add(this.lblHomeMessage);
            this.Controls.Add(this.menuStripHome);
            this.MainMenuStrip = this.menuStripHome;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Label lblHomeMessage;
        private System.Windows.Forms.Button btnCustMenu;
        private System.Windows.Forms.Button btnEventMenu;
        private System.Windows.Forms.Button btnRegMenu;
        private System.Windows.Forms.Button btnHomeExit;
    }
}

