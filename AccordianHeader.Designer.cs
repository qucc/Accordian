namespace Accordian
{
    partial class AccordianHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccordianHeader));
            this.label1 = new System.Windows.Forms.Label();
            this.imageView1 = new Accordian.ImageView();
            ((System.ComponentModel.ISupportInitialize)(this.imageView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // imageView1
            // 
            this.imageView1.DownImage = ((System.Drawing.Image)(resources.GetObject("imageView1.DownImage")));
            this.imageView1.Enabled = false;
            this.imageView1.Image = ((System.Drawing.Image)(resources.GetObject("imageView1.Image")));
            this.imageView1.Location = new System.Drawing.Point(3, 3);
            this.imageView1.Name = "imageView1";
            this.imageView1.Size = new System.Drawing.Size(48, 48);
            this.imageView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageView1.TabIndex = 1;
            this.imageView1.TabStop = false;
            this.imageView1.UpImage = ((System.Drawing.Image)(resources.GetObject("imageView1.UpImage")));
            // 
            // AccordianHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.imageView1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(153, 54);
            this.Name = "AccordianHeader";
            this.Size = new System.Drawing.Size(153, 54);
            ((System.ComponentModel.ISupportInitialize)(this.imageView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ImageView imageView1;


    }
}
