namespace ShopMVP.Views
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            this.shopListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopListBox
            // 
            this.shopListBox.ContextMenuStrip = this.removeContextMenuStrip;
            this.shopListBox.FormattingEnabled = true;
            this.shopListBox.ItemHeight = 16;
            this.shopListBox.Location = new System.Drawing.Point(13, 33);
            this.shopListBox.Name = "shopListBox";
            this.shopListBox.Size = new System.Drawing.Size(316, 372);
            this.shopListBox.TabIndex = 0;
            this.shopListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shopListBox_MouseDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(316, 30);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "New Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products:";
            // 
            // removeContextMenuStrip
            // 
            this.removeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.removeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.removeContextMenuStrip.Name = "removeContextMenuStrip";
            this.removeContextMenuStrip.Size = new System.Drawing.Size(133, 28);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.shopListBox);
            this.Name = "ShopForm";
            this.Text = "Bravo Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.removeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shopListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip removeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}