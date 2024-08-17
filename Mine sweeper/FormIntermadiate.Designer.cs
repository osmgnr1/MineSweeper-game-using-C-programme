namespace MayinTarlasi
{
    partial class FormIntermadiate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntermadiate));
            this.label2 = new System.Windows.Forms.Label();
            this.pbMayin2 = new System.Windows.Forms.PictureBox();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tBasla = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMayin2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(421, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Süre:";
            // 
            // pbMayin2
            // 
            this.pbMayin2.Image = ((System.Drawing.Image)(resources.GetObject("pbMayin2.Image")));
            this.pbMayin2.Location = new System.Drawing.Point(762, 4);
            this.pbMayin2.Name = "pbMayin2";
            this.pbMayin2.Size = new System.Drawing.Size(37, 38);
            this.pbMayin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMayin2.TabIndex = 7;
            this.pbMayin2.TabStop = false;
            this.pbMayin2.Visible = false;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(476, 11);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 20);
            this.lblZaman.TabIndex = 8;
            // 
            // tBasla
            // 
            this.tBasla.Interval = 1000;
            this.tBasla.Tick += new System.EventHandler(this.tBasla_Tick);
            // 
            // FormIntermadiate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.pbMayin2);
            this.Controls.Add(this.label2);
            this.Name = "FormIntermadiate";
            this.Text = "FormIntermadiate";
            this.Load += new System.EventHandler(this.FormIntermadiate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMayin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMayin2;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tBasla;
    }
}