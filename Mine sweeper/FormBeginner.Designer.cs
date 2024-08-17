namespace MayinTarlasi
{
    partial class FormBeginner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeginner));
            this.pbMayin2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBasla = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.pbBayrak = new System.Windows.Forms.PictureBox();
            this.pbSoruIsareti = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bayrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruIsaretiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMayin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBayrak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoruIsareti)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMayin2
            // 
            this.pbMayin2.Image = ((System.Drawing.Image)(resources.GetObject("pbMayin2.Image")));
            this.pbMayin2.Location = new System.Drawing.Point(764, 3);
            this.pbMayin2.Name = "pbMayin2";
            this.pbMayin2.Size = new System.Drawing.Size(35, 35);
            this.pbMayin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMayin2.TabIndex = 3;
            this.pbMayin2.TabStop = false;
            this.pbMayin2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(452, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Süre:";
            // 
            // tBasla
            // 
            this.tBasla.Enabled = true;
            this.tBasla.Interval = 1000;
            this.tBasla.Tick += new System.EventHandler(this.tBasla_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(516, 13);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 20);
            this.lblZaman.TabIndex = 5;
            // 
            // pbBayrak
            // 
            this.pbBayrak.Image = ((System.Drawing.Image)(resources.GetObject("pbBayrak.Image")));
            this.pbBayrak.Location = new System.Drawing.Point(762, 47);
            this.pbBayrak.Name = "pbBayrak";
            this.pbBayrak.Size = new System.Drawing.Size(35, 35);
            this.pbBayrak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBayrak.TabIndex = 6;
            this.pbBayrak.TabStop = false;
            this.pbBayrak.Visible = false;
            // 
            // pbSoruIsareti
            // 
            this.pbSoruIsareti.Image = ((System.Drawing.Image)(resources.GetObject("pbSoruIsareti.Image")));
            this.pbSoruIsareti.Location = new System.Drawing.Point(762, 88);
            this.pbSoruIsareti.Name = "pbSoruIsareti";
            this.pbSoruIsareti.Size = new System.Drawing.Size(35, 35);
            this.pbSoruIsareti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSoruIsareti.TabIndex = 7;
            this.pbSoruIsareti.TabStop = false;
            this.pbSoruIsareti.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bayrakToolStripMenuItem,
            this.soruIsaretiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // bayrakToolStripMenuItem
            // 
            this.bayrakToolStripMenuItem.Name = "bayrakToolStripMenuItem";
            this.bayrakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bayrakToolStripMenuItem.Text = "Bayrak";
            // 
            // soruIsaretiToolStripMenuItem
            // 
            this.soruIsaretiToolStripMenuItem.Name = "soruIsaretiToolStripMenuItem";
            this.soruIsaretiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soruIsaretiToolStripMenuItem.Text = "Soru İşareti";
            // 
            // FormBeginner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pbSoruIsareti);
            this.Controls.Add(this.pbBayrak);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMayin2);
            this.Name = "FormBeginner";
            this.Text = "FormBeginner";
            this.Load += new System.EventHandler(this.FormBeginner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMayin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBayrak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoruIsareti)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMayin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tBasla;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.PictureBox pbBayrak;
        private System.Windows.Forms.PictureBox pbSoruIsareti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bayrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruIsaretiToolStripMenuItem;
    }
}