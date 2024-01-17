
namespace cukraszda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMegnyitas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSutemenyek = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNevjegy = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.menuSutemenyek,
            this.menuNevjegy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMegnyitas,
            this.menuKilep});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // menuMegnyitas
            // 
            this.menuMegnyitas.Name = "menuMegnyitas";
            this.menuMegnyitas.Size = new System.Drawing.Size(224, 26);
            this.menuMegnyitas.Text = "Megnyitás...";
            this.menuMegnyitas.Click += new System.EventHandler(this.menuMegnyitas_Click);
            // 
            // menuKilep
            // 
            this.menuKilep.Name = "menuKilep";
            this.menuKilep.Size = new System.Drawing.Size(169, 26);
            this.menuKilep.Text = "Kilépés";
            this.menuKilep.Click += new System.EventHandler(this.menuKilep_Click);
            // 
            // menuSutemenyek
            // 
            this.menuSutemenyek.Enabled = false;
            this.menuSutemenyek.Name = "menuSutemenyek";
            this.menuSutemenyek.Size = new System.Drawing.Size(103, 24);
            this.menuSutemenyek.Text = "Sütemények";
            this.menuSutemenyek.Click += new System.EventHandler(this.sütenényekToolStripMenuItem_Click);
            // 
            // menuNevjegy
            // 
            this.menuNevjegy.Name = "menuNevjegy";
            this.menuNevjegy.Size = new System.Drawing.Size(77, 24);
            this.menuNevjegy.Text = "Névjegy";
            this.menuNevjegy.Click += new System.EventHandler(this.menuNevjegy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "haha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Setemény";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMegnyitas;
        private System.Windows.Forms.ToolStripMenuItem menuKilep;
        private System.Windows.Forms.ToolStripMenuItem menuSutemenyek;
        private System.Windows.Forms.ToolStripMenuItem menuNevjegy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

