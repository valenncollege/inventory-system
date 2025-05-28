namespace Inventory_System
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataToolStripMenuItem
            // 
            this.inputDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.productToolStripMenuItem,
            this.productImageToolStripMenuItem,
            this.productSupplierToolStripMenuItem});
            this.inputDataToolStripMenuItem.Name = "inputDataToolStripMenuItem";
            this.inputDataToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.inputDataToolStripMenuItem.Text = "Data Entry";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // productImageToolStripMenuItem
            // 
            this.productImageToolStripMenuItem.Name = "productImageToolStripMenuItem";
            this.productImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productImageToolStripMenuItem.Text = "Product Image";
            this.productImageToolStripMenuItem.Click += new System.EventHandler(this.productImageToolStripMenuItem_Click);
            // 
            // productSupplierToolStripMenuItem
            // 
            this.productSupplierToolStripMenuItem.Name = "productSupplierToolStripMenuItem";
            this.productSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productSupplierToolStripMenuItem.Text = "Product - Supplier";
            this.productSupplierToolStripMenuItem.Click += new System.EventHandler(this.productSupplierToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySupplierToolStripMenuItem,
            this.displayProductToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // displaySupplierToolStripMenuItem
            // 
            this.displaySupplierToolStripMenuItem.Name = "displaySupplierToolStripMenuItem";
            this.displaySupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displaySupplierToolStripMenuItem.Text = "Display Supplier";
            this.displaySupplierToolStripMenuItem.Click += new System.EventHandler(this.displaySupplierToolStripMenuItem_Click);
            // 
            // displayProductToolStripMenuItem
            // 
            this.displayProductToolStripMenuItem.Name = "displayProductToolStripMenuItem";
            this.displayProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayProductToolStripMenuItem.Text = "Display Product";
            this.displayProductToolStripMenuItem.Click += new System.EventHandler(this.displayProductToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 188);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

