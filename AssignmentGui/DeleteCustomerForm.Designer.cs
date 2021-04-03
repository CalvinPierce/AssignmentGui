namespace AssignmentGui
{
    partial class DeleteCustomerForm
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
            this.txtGetId = new System.Windows.Forms.TextBox();
            this.lblGetCustId = new System.Windows.Forms.Label();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnHomeMenuCust = new System.Windows.Forms.Button();
            this.txtViewCustomers = new System.Windows.Forms.TextBox();
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
            this.menuStripAddCustomer.TabIndex = 3;
            this.menuStripAddCustomer.Text = "menuStripDeleteCust";
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
            // txtGetId
            // 
            this.txtGetId.Location = new System.Drawing.Point(400, 329);
            this.txtGetId.Name = "txtGetId";
            this.txtGetId.Size = new System.Drawing.Size(204, 20);
            this.txtGetId.TabIndex = 14;
            // 
            // lblGetCustId
            // 
            this.lblGetCustId.AutoSize = true;
            this.lblGetCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCustId.Location = new System.Drawing.Point(12, 329);
            this.lblGetCustId.Name = "lblGetCustId";
            this.lblGetCustId.Size = new System.Drawing.Size(349, 40);
            this.lblGetCustId.TabIndex = 12;
            this.lblGetCustId.Text = "Please Enter The Customer\'s ID To Delete\r\n\r\n";
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Location = new System.Drawing.Point(232, 372);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(292, 30);
            this.btnDeleteCust.TabIndex = 16;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnHomeMenuCust
            // 
            this.btnHomeMenuCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuCust.Location = new System.Drawing.Point(232, 408);
            this.btnHomeMenuCust.Name = "btnHomeMenuCust";
            this.btnHomeMenuCust.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuCust.TabIndex = 15;
            this.btnHomeMenuCust.Text = "Return To Customer Menu";
            this.btnHomeMenuCust.UseVisualStyleBackColor = true;
            this.btnHomeMenuCust.Click += new System.EventHandler(this.btnHomeMenuCust_Click);
            // 
            // txtViewCustomers
            // 
            this.txtViewCustomers.Location = new System.Drawing.Point(146, 52);
            this.txtViewCustomers.Multiline = true;
            this.txtViewCustomers.Name = "txtViewCustomers";
            this.txtViewCustomers.ReadOnly = true;
            this.txtViewCustomers.Size = new System.Drawing.Size(480, 241);
            this.txtViewCustomers.TabIndex = 18;
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViewCustomers);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnHomeMenuCust);
            this.Controls.Add(this.txtGetId);
            this.Controls.Add(this.lblGetCustId);
            this.Controls.Add(this.menuStripAddCustomer);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
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
        private System.Windows.Forms.TextBox txtGetId;
        private System.Windows.Forms.Label lblGetCustId;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnHomeMenuCust;
        private System.Windows.Forms.TextBox txtViewCustomers;
    }
}