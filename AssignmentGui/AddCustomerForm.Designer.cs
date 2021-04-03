namespace AssignmentGui
{
    partial class AddCustomerForm
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
            this.menuStripAddCustomer = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddCustHome = new System.Windows.Forms.Label();
            this.lblGetFirstName = new System.Windows.Forms.Label();
            this.lblGetLastName = new System.Windows.Forms.Label();
            this.lblGetPhone = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblAddOutcome = new System.Windows.Forms.Label();
            this.txtGetFirstName = new System.Windows.Forms.TextBox();
            this.txtGetLastName = new System.Windows.Forms.TextBox();
            this.txtGetPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnExitAdd = new System.Windows.Forms.Button();
            this.menuStripAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAddCustomer
            // 
            this.menuStripAddCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripAddCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripAddCustomer.Name = "menuStripAddCustomer";
            this.menuStripAddCustomer.Size = new System.Drawing.Size(800, 24);
            this.menuStripAddCustomer.TabIndex = 2;
            this.menuStripAddCustomer.Text = "menuStrip1";
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
            // lblAddCustHome
            // 
            this.lblAddCustHome.AutoSize = true;
            this.lblAddCustHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustHome.Location = new System.Drawing.Point(220, 85);
            this.lblAddCustHome.Name = "lblAddCustHome";
            this.lblAddCustHome.Size = new System.Drawing.Size(282, 40);
            this.lblAddCustHome.TabIndex = 3;
            this.lblAddCustHome.Text = "Group Event Management Limited\r\n                 Add Customer";
            // 
            // lblGetFirstName
            // 
            this.lblGetFirstName.AutoSize = true;
            this.lblGetFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetFirstName.Location = new System.Drawing.Point(12, 176);
            this.lblGetFirstName.Name = "lblGetFirstName";
            this.lblGetFirstName.Size = new System.Drawing.Size(334, 20);
            this.lblGetFirstName.TabIndex = 4;
            this.lblGetFirstName.Text = "Please Enter The Customer\'s First Name\r\n";
            // 
            // lblGetLastName
            // 
            this.lblGetLastName.AutoSize = true;
            this.lblGetLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetLastName.Location = new System.Drawing.Point(12, 214);
            this.lblGetLastName.Name = "lblGetLastName";
            this.lblGetLastName.Size = new System.Drawing.Size(333, 20);
            this.lblGetLastName.TabIndex = 5;
            this.lblGetLastName.Text = "Please Enter The Customer\'s Last Name\r\n";
            // 
            // lblGetPhone
            // 
            this.lblGetPhone.AutoSize = true;
            this.lblGetPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetPhone.Location = new System.Drawing.Point(12, 255);
            this.lblGetPhone.Name = "lblGetPhone";
            this.lblGetPhone.Size = new System.Drawing.Size(365, 40);
            this.lblGetPhone.TabIndex = 6;
            this.lblGetPhone.Text = "Please Enter The Customer\'s Phone Number\r\n\r\n";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(300, 298);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(96, 30);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblAddOutcome
            // 
            this.lblAddOutcome.AutoSize = true;
            this.lblAddOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOutcome.Location = new System.Drawing.Point(242, 367);
            this.lblAddOutcome.Name = "lblAddOutcome";
            this.lblAddOutcome.Size = new System.Drawing.Size(0, 20);
            this.lblAddOutcome.TabIndex = 8;
            // 
            // txtGetFirstName
            // 
            this.txtGetFirstName.Location = new System.Drawing.Point(395, 176);
            this.txtGetFirstName.Name = "txtGetFirstName";
            this.txtGetFirstName.Size = new System.Drawing.Size(204, 20);
            this.txtGetFirstName.TabIndex = 9;
            // 
            // txtGetLastName
            // 
            this.txtGetLastName.Location = new System.Drawing.Point(395, 214);
            this.txtGetLastName.Name = "txtGetLastName";
            this.txtGetLastName.Size = new System.Drawing.Size(204, 20);
            this.txtGetLastName.TabIndex = 10;
            // 
            // txtGetPhoneNumber
            // 
            this.txtGetPhoneNumber.Location = new System.Drawing.Point(395, 255);
            this.txtGetPhoneNumber.Name = "txtGetPhoneNumber";
            this.txtGetPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtGetPhoneNumber.TabIndex = 11;
            // 
            // btnExitAdd
            // 
            this.btnExitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAdd.Location = new System.Drawing.Point(234, 421);
            this.btnExitAdd.Name = "btnExitAdd";
            this.btnExitAdd.Size = new System.Drawing.Size(256, 28);
            this.btnExitAdd.TabIndex = 12;
            this.btnExitAdd.Text = "Return To Customer Menu";
            this.btnExitAdd.UseVisualStyleBackColor = true;
            this.btnExitAdd.Click += new System.EventHandler(this.btnExitAdd_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitAdd);
            this.Controls.Add(this.txtGetPhoneNumber);
            this.Controls.Add(this.txtGetLastName);
            this.Controls.Add(this.txtGetFirstName);
            this.Controls.Add(this.lblAddOutcome);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblGetPhone);
            this.Controls.Add(this.lblGetLastName);
            this.Controls.Add(this.lblGetFirstName);
            this.Controls.Add(this.lblAddCustHome);
            this.Controls.Add(this.menuStripAddCustomer);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.menuStripAddCustomer.ResumeLayout(false);
            this.menuStripAddCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Label lblAddCustHome;
        private System.Windows.Forms.Label lblGetFirstName;
        private System.Windows.Forms.Label lblGetLastName;
        private System.Windows.Forms.Label lblGetPhone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblAddOutcome;
        private System.Windows.Forms.TextBox txtGetFirstName;
        private System.Windows.Forms.TextBox txtGetLastName;
        private System.Windows.Forms.TextBox txtGetPhoneNumber;
        private System.Windows.Forms.Button btnExitAdd;
    }
}