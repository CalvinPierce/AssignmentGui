namespace AssignmentGui
{
    partial class CustomerForm
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
            this.menuStripCustomer = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustHome = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnViewCust = new System.Windows.Forms.Button();
            this.btnViewCustDetails = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnHomeMenuCust = new System.Windows.Forms.Button();
            this.menuStripCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCustomer
            // 
            this.menuStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripCustomer.Name = "menuStripCustomer";
            this.menuStripCustomer.Size = new System.Drawing.Size(800, 24);
            this.menuStripCustomer.TabIndex = 1;
            this.menuStripCustomer.Text = "menuStrip1";
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
            // lblCustHome
            // 
            this.lblCustHome.AutoSize = true;
            this.lblCustHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustHome.Location = new System.Drawing.Point(220, 81);
            this.lblCustHome.Name = "lblCustHome";
            this.lblCustHome.Size = new System.Drawing.Size(282, 40);
            this.lblCustHome.TabIndex = 2;
            this.lblCustHome.Text = "Group Event Management Limited\r\n               Customer Menu";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(224, 159);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(292, 29);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnViewCust
            // 
            this.btnViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCust.Location = new System.Drawing.Point(224, 194);
            this.btnViewCust.Name = "btnViewCust";
            this.btnViewCust.Size = new System.Drawing.Size(292, 28);
            this.btnViewCust.TabIndex = 4;
            this.btnViewCust.Text = "View Customers";
            this.btnViewCust.UseVisualStyleBackColor = true;
            this.btnViewCust.Click += new System.EventHandler(this.btnViewCust_Click);
            // 
            // btnViewCustDetails
            // 
            this.btnViewCustDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustDetails.Location = new System.Drawing.Point(224, 228);
            this.btnViewCustDetails.Name = "btnViewCustDetails";
            this.btnViewCustDetails.Size = new System.Drawing.Size(292, 31);
            this.btnViewCustDetails.TabIndex = 5;
            this.btnViewCustDetails.Text = "View Customer Details";
            this.btnViewCustDetails.UseVisualStyleBackColor = true;
            this.btnViewCustDetails.Click += new System.EventHandler(this.btnViewCustDetails_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Location = new System.Drawing.Point(224, 265);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(292, 31);
            this.btnDeleteCust.TabIndex = 6;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnHomeMenuCust
            // 
            this.btnHomeMenuCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuCust.Location = new System.Drawing.Point(224, 302);
            this.btnHomeMenuCust.Name = "btnHomeMenuCust";
            this.btnHomeMenuCust.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuCust.TabIndex = 7;
            this.btnHomeMenuCust.Text = "Return To Main Menu";
            this.btnHomeMenuCust.UseVisualStyleBackColor = true;
            this.btnHomeMenuCust.Click += new System.EventHandler(this.btnHomeMenuCust_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomeMenuCust);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnViewCustDetails);
            this.Controls.Add(this.btnViewCust);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.lblCustHome);
            this.Controls.Add(this.menuStripCustomer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.menuStripCustomer.ResumeLayout(false);
            this.menuStripCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Label lblCustHome;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnViewCust;
        private System.Windows.Forms.Button btnViewCustDetails;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnHomeMenuCust;
    }
}