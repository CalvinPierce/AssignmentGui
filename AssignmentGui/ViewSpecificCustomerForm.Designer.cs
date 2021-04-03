namespace AssignmentGui
{
    partial class ViewSpecificCustomerForm
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
            this.btnHomeMenuCust = new System.Windows.Forms.Button();
            this.menuStripViewCustomer = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetId = new System.Windows.Forms.TextBox();
            this.btnViewCust = new System.Windows.Forms.Button();
            this.txtViewCustomers = new System.Windows.Forms.TextBox();
            this.menuStripViewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHomeMenuCust
            // 
            this.btnHomeMenuCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenuCust.Location = new System.Drawing.Point(236, 405);
            this.btnHomeMenuCust.Name = "btnHomeMenuCust";
            this.btnHomeMenuCust.Size = new System.Drawing.Size(292, 31);
            this.btnHomeMenuCust.TabIndex = 11;
            this.btnHomeMenuCust.Text = "Return To Customer Menu";
            this.btnHomeMenuCust.UseVisualStyleBackColor = true;
            this.btnHomeMenuCust.Click += new System.EventHandler(this.btnHomeMenuCust_Click);
            // 
            // menuStripViewCustomer
            // 
            this.menuStripViewCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerOptionsToolStripMenuItem,
            this.eventOptionsToolStripMenuItem,
            this.registrationOptionsToolStripMenuItem});
            this.menuStripViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripViewCustomer.Name = "menuStripViewCustomer";
            this.menuStripViewCustomer.Size = new System.Drawing.Size(800, 24);
            this.menuStripViewCustomer.TabIndex = 9;
            this.menuStripViewCustomer.Text = "menuStripDeleteCust";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please Enter A Customer Id To View";
            // 
            // txtGetId
            // 
            this.txtGetId.Location = new System.Drawing.Point(348, 279);
            this.txtGetId.Name = "txtGetId";
            this.txtGetId.Size = new System.Drawing.Size(203, 20);
            this.txtGetId.TabIndex = 13;
            // 
            // btnViewCust
            // 
            this.btnViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCust.Location = new System.Drawing.Point(236, 369);
            this.btnViewCust.Name = "btnViewCust";
            this.btnViewCust.Size = new System.Drawing.Size(292, 30);
            this.btnViewCust.TabIndex = 14;
            this.btnViewCust.Text = "View Customer";
            this.btnViewCust.UseVisualStyleBackColor = true;
            this.btnViewCust.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtViewCustomers
            // 
            this.txtViewCustomers.Location = new System.Drawing.Point(155, 41);
            this.txtViewCustomers.Multiline = true;
            this.txtViewCustomers.Name = "txtViewCustomers";
            this.txtViewCustomers.ReadOnly = true;
            this.txtViewCustomers.Size = new System.Drawing.Size(461, 218);
            this.txtViewCustomers.TabIndex = 15;
            // 
            // ViewSpecificCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViewCustomers);
            this.Controls.Add(this.btnViewCust);
            this.Controls.Add(this.txtGetId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHomeMenuCust);
            this.Controls.Add(this.menuStripViewCustomer);
            this.Name = "ViewSpecificCustomerForm";
            this.Text = "ViewSpecificCustomerForm";
            this.Load += new System.EventHandler(this.ViewSpecificCustomerForm_Load);
            this.menuStripViewCustomer.ResumeLayout(false);
            this.menuStripViewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomeMenuCust;
        private System.Windows.Forms.MenuStrip menuStripViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationOptionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetId;
        private System.Windows.Forms.Button btnViewCust;
        private System.Windows.Forms.TextBox txtViewCustomers;
    }
}