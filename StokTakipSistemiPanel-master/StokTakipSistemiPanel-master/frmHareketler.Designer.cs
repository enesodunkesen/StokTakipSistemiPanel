namespace StokTakipSistemiPanel
{
    partial class frmHareketler
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
            treeViewHareketler = new TreeView();
            labelHareket = new Label();
            SuspendLayout();
            // 
            // treeViewHareketler
            // 
            treeViewHareketler.Anchor = AnchorStyles.None;
            treeViewHareketler.BackColor = Color.FromArgb(20, 35, 54);
            treeViewHareketler.Location = new Point(12, 160);
            treeViewHareketler.Name = "treeViewHareketler";
            treeViewHareketler.Size = new Size(949, 427);
            treeViewHareketler.TabIndex = 0;
            // 
            // labelHareket
            // 
            labelHareket.Anchor = AnchorStyles.None;
            labelHareket.AutoSize = true;
            labelHareket.Font = new Font("Segoe UI", 20F);
            labelHareket.ForeColor = Color.FromArgb(41, 243, 155);
            labelHareket.Location = new Point(12, 67);
            labelHareket.Name = "labelHareket";
            labelHareket.Size = new Size(191, 37);
            labelHareket.TabIndex = 1;
            labelHareket.Text = "Son Hareketler";
            // 
            // frmHareketler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 35, 54);
            ClientSize = new Size(973, 599);
            Controls.Add(labelHareket);
            Controls.Add(treeViewHareketler);
            Name = "frmHareketler";
            Text = "frmHareketler";
            Load += frmHareketler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewHareketler;
        private Label labelHareket;
    }
}