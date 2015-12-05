namespace FridgeMilestone3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerBar = new System.Windows.Forms.Panel();
            this.EditFridgeView = new System.Windows.Forms.Button();
            this.editFridgeDetails = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.headerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBar
            // 
            this.headerBar.Controls.Add(this.EditFridgeView);
            this.headerBar.Controls.Add(this.editFridgeDetails);
            this.headerBar.Controls.Add(this.addItem);
            this.headerBar.Location = new System.Drawing.Point(1, 0);
            this.headerBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(312, 45);
            this.headerBar.TabIndex = 0;
            // 
            // EditFridgeView
            // 
            this.EditFridgeView.Image = ((System.Drawing.Image)(resources.GetObject("EditFridgeView.Image")));
            this.EditFridgeView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditFridgeView.Location = new System.Drawing.Point(217, 1);
            this.EditFridgeView.Name = "EditFridgeView";
            this.EditFridgeView.Size = new System.Drawing.Size(85, 42);
            this.EditFridgeView.TabIndex = 2;
            this.EditFridgeView.Text = "Fridge View";
            this.EditFridgeView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditFridgeView.UseVisualStyleBackColor = true;
            this.EditFridgeView.Click += new System.EventHandler(this.EditFridgeView_Click);
            // 
            // editFridgeDetails
            // 
            this.editFridgeDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editFridgeDetails.Location = new System.Drawing.Point(102, 1);
            this.editFridgeDetails.Name = "editFridgeDetails";
            this.editFridgeDetails.Size = new System.Drawing.Size(109, 42);
            this.editFridgeDetails.TabIndex = 1;
            this.editFridgeDetails.Text = "Edit Fridge Details";
            this.editFridgeDetails.UseVisualStyleBackColor = true;
            // 
            // addItem
            // 
            this.addItem.Image = ((System.Drawing.Image)(resources.GetObject("addItem.Image")));
            this.addItem.Location = new System.Drawing.Point(11, 1);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(85, 42);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "Add Item";
            this.addItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items in <Fridge Name Here>";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 342);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 426);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button EditFridgeView;
        private System.Windows.Forms.Button editFridgeDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

