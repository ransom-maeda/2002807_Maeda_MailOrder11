namespace _2002807_Maeda_MailOrder11
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
            this.catalogList = new System.Windows.Forms.ComboBox();
            this.labelCatalogList = new System.Windows.Forms.Label();
            this.addCatalog = new System.Windows.Forms.Button();
            this.deleteCatalog = new System.Windows.Forms.Button();
            this.catalogAmount = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogList
            // 
            this.catalogList.FormattingEnabled = true;
            this.catalogList.Location = new System.Drawing.Point(80, 17);
            this.catalogList.Name = "catalogList";
            this.catalogList.Size = new System.Drawing.Size(121, 21);
            this.catalogList.TabIndex = 0;
            // 
            // labelCatalogList
            // 
            this.labelCatalogList.AutoSize = true;
            this.labelCatalogList.Location = new System.Drawing.Point(12, 20);
            this.labelCatalogList.Name = "labelCatalogList";
            this.labelCatalogList.Size = new System.Drawing.Size(62, 13);
            this.labelCatalogList.TabIndex = 1;
            this.labelCatalogList.Text = "Catalog List";
            // 
            // addCatalog
            // 
            this.addCatalog.Location = new System.Drawing.Point(277, 20);
            this.addCatalog.Name = "addCatalog";
            this.addCatalog.Size = new System.Drawing.Size(158, 29);
            this.addCatalog.TabIndex = 2;
            this.addCatalog.Text = "Add Catalog";
            this.addCatalog.UseVisualStyleBackColor = true;
            this.addCatalog.Click += new System.EventHandler(this.addCatalog_Click);
            // 
            // deleteCatalog
            // 
            this.deleteCatalog.Location = new System.Drawing.Point(277, 55);
            this.deleteCatalog.Name = "deleteCatalog";
            this.deleteCatalog.Size = new System.Drawing.Size(158, 29);
            this.deleteCatalog.TabIndex = 3;
            this.deleteCatalog.Text = "Delete Catalog";
            this.deleteCatalog.UseVisualStyleBackColor = true;
            this.deleteCatalog.Click += new System.EventHandler(this.deleteCatalog_Click);
            // 
            // catalogAmount
            // 
            this.catalogAmount.Location = new System.Drawing.Point(277, 90);
            this.catalogAmount.Name = "catalogAmount";
            this.catalogAmount.Size = new System.Drawing.Size(158, 29);
            this.catalogAmount.TabIndex = 4;
            this.catalogAmount.Text = "Amount of Catalogs";
            this.catalogAmount.UseVisualStyleBackColor = true;
            this.catalogAmount.Click += new System.EventHandler(this.catalogAmount_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(277, 125);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(158, 29);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear Catalog List";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(277, 160);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 29);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(55, 160);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(158, 29);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 207);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.catalogAmount);
            this.Controls.Add(this.deleteCatalog);
            this.Controls.Add(this.addCatalog);
            this.Controls.Add(this.labelCatalogList);
            this.Controls.Add(this.catalogList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catalogList;
        private System.Windows.Forms.Label labelCatalogList;
        private System.Windows.Forms.Button addCatalog;
        private System.Windows.Forms.Button deleteCatalog;
        private System.Windows.Forms.Button catalogAmount;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
    }
}

