namespace blocNotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.bgColor = new System.Windows.Forms.Button();
            this.alignRight = new System.Windows.Forms.Button();
            this.alignLeft = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.bold = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.erase);
            this.panel1.Controls.Add(this.bgColor);
            this.panel1.Controls.Add(this.alignRight);
            this.panel1.Controls.Add(this.alignLeft);
            this.panel1.Controls.Add(this.underline);
            this.panel1.Controls.Add(this.cut);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.bold);
            this.panel1.Controls.Add(this.font);
            this.panel1.Controls.Add(this.paste);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 55);
            this.panel1.TabIndex = 0;
            // 
            // save
            // 
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(123, 7);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(42, 40);
            this.save.TabIndex = 2;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // erase
            // 
            this.erase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("erase.BackgroundImage")));
            this.erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.erase.FlatAppearance.BorderSize = 0;
            this.erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erase.Location = new System.Drawing.Point(790, 7);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(42, 40);
            this.erase.TabIndex = 3;
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // bgColor
            // 
            this.bgColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgColor.BackgroundImage")));
            this.bgColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bgColor.FlatAppearance.BorderSize = 0;
            this.bgColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgColor.Location = new System.Drawing.Point(732, 9);
            this.bgColor.Name = "bgColor";
            this.bgColor.Size = new System.Drawing.Size(42, 40);
            this.bgColor.TabIndex = 4;
            this.bgColor.UseVisualStyleBackColor = true;
            this.bgColor.Click += new System.EventHandler(this.bgColor_Click);
            // 
            // alignRight
            // 
            this.alignRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alignRight.BackgroundImage")));
            this.alignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alignRight.FlatAppearance.BorderSize = 0;
            this.alignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignRight.Location = new System.Drawing.Point(673, 7);
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(42, 40);
            this.alignRight.TabIndex = 5;
            this.alignRight.UseVisualStyleBackColor = true;
            this.alignRight.Click += new System.EventHandler(this.alignRight_Click);
            // 
            // alignLeft
            // 
            this.alignLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alignLeft.BackgroundImage")));
            this.alignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alignLeft.FlatAppearance.BorderSize = 0;
            this.alignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignLeft.Location = new System.Drawing.Point(618, 7);
            this.alignLeft.Name = "alignLeft";
            this.alignLeft.Size = new System.Drawing.Size(42, 40);
            this.alignLeft.TabIndex = 8;
            this.alignLeft.UseVisualStyleBackColor = true;
            this.alignLeft.Click += new System.EventHandler(this.alignLeft_Click);
            // 
            // underline
            // 
            this.underline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("underline.BackgroundImage")));
            this.underline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.underline.FlatAppearance.BorderSize = 0;
            this.underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underline.Location = new System.Drawing.Point(563, 7);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(42, 40);
            this.underline.TabIndex = 7;
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // cut
            // 
            this.cut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cut.BackgroundImage")));
            this.cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cut.FlatAppearance.BorderSize = 0;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Location = new System.Drawing.Point(343, 7);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(42, 40);
            this.cut.TabIndex = 6;
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // print
            // 
            this.print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print.BackgroundImage")));
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(398, 7);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(42, 40);
            this.print.TabIndex = 5;
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // bold
            // 
            this.bold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bold.BackgroundImage")));
            this.bold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bold.FlatAppearance.BorderSize = 0;
            this.bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bold.Location = new System.Drawing.Point(508, 7);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(42, 40);
            this.bold.TabIndex = 4;
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // font
            // 
            this.font.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("font.BackgroundImage")));
            this.font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.font.FlatAppearance.BorderSize = 0;
            this.font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.font.Location = new System.Drawing.Point(453, 7);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(42, 40);
            this.font.TabIndex = 3;
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // paste
            // 
            this.paste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paste.BackgroundImage")));
            this.paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paste.FlatAppearance.BorderSize = 0;
            this.paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paste.Location = new System.Drawing.Point(288, 7);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(42, 40);
            this.paste.TabIndex = 2;
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // copy
            // 
            this.copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copy.BackgroundImage")));
            this.copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Location = new System.Drawing.Point(233, 7);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(42, 40);
            this.copy.TabIndex = 1;
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // upload
            // 
            this.upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload.BackgroundImage")));
            this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Location = new System.Drawing.Point(178, 7);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(42, 40);
            this.upload.TabIndex = 0;
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bunifuSlider1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 288);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.AutoSize = true;
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(3, 3);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(723, 30);
            this.bunifuSlider1.TabIndex = 0;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(894, 233);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 332);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bloc-Notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button alignLeft;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button bgColor;
        private System.Windows.Forms.Button alignRight;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

