namespace FridgeMilestone3
{
    partial class FridgeView
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnReMove = new System.Windows.Forms.Button();
            this.btnEditFridgeDetails = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(78, 23);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnReMove
            // 
            this.btnReMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReMove.AutoSize = true;
            this.btnReMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReMove.Location = new System.Drawing.Point(87, 3);
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Size = new System.Drawing.Size(117, 23);
            this.btnReMove.TabIndex = 1;
            this.btnReMove.Text = "Move/Remove Items";
            this.btnReMove.UseVisualStyleBackColor = true;
            // 
            // btnEditFridgeDetails
            // 
            this.btnEditFridgeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFridgeDetails.AutoSize = true;
            this.btnEditFridgeDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditFridgeDetails.Location = new System.Drawing.Point(210, 3);
            this.btnEditFridgeDetails.Name = "btnEditFridgeDetails";
            this.btnEditFridgeDetails.Size = new System.Drawing.Size(102, 23);
            this.btnEditFridgeDetails.TabIndex = 2;
            this.btnEditFridgeDetails.Text = "Edit Fridge Details";
            this.btnEditFridgeDetails.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.AutoSize = true;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Image = global::FridgeMilestone3.Properties.Resources.Home;
            this.btnHome.Location = new System.Drawing.Point(3, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.Controls.Add(this.btnAddItem);
            this.pnlTop.Controls.Add(this.btnReMove);
            this.pnlTop.Controls.Add(this.btnEditFridgeDetails);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(315, 29);
            this.pnlTop.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 42);
            this.panel1.TabIndex = 5;
            // 
            // FridgeView
            // 
            this.ClientSize = new System.Drawing.Size(315, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "FridgeView";
            this.Text = "FridgeView";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnReMove;
        private System.Windows.Forms.Button btnEditFridgeDetails;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
    }
}