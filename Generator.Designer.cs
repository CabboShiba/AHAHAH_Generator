namespace AHAHAH_Generator
{
    partial class Generator
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.generatedtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.charslenght = new System.Windows.Forms.TextBox();
            this.upper = new System.Windows.Forms.RadioButton();
            this.lower = new System.Windows.Forms.RadioButton();
            this.mix = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.copyclip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generatedtext
            // 
            this.generatedtext.Location = new System.Drawing.Point(241, 15);
            this.generatedtext.Multiline = true;
            this.generatedtext.Name = "generatedtext";
            this.generatedtext.ReadOnly = true;
            this.generatedtext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generatedtext.Size = new System.Drawing.Size(422, 333);
            this.generatedtext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose how many characters generate:";
            // 
            // charslenght
            // 
            this.charslenght.Location = new System.Drawing.Point(15, 41);
            this.charslenght.Name = "charslenght";
            this.charslenght.Size = new System.Drawing.Size(100, 20);
            this.charslenght.TabIndex = 3;
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Location = new System.Drawing.Point(15, 79);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(102, 17);
            this.upper.TabIndex = 4;
            this.upper.TabStop = true;
            this.upper.Text = "Only UpperCase";
            this.upper.UseVisualStyleBackColor = true;
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Location = new System.Drawing.Point(15, 102);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(102, 17);
            this.lower.TabIndex = 5;
            this.lower.TabStop = true;
            this.lower.Text = "Only LowerCase";
            this.lower.UseVisualStyleBackColor = true;
            // 
            // mix
            // 
            this.mix.AutoSize = true;
            this.mix.Location = new System.Drawing.Point(15, 125);
            this.mix.Name = "mix";
            this.mix.Size = new System.Drawing.Size(111, 17);
            this.mix.TabIndex = 6;
            this.mix.TabStop = true;
            this.mix.Text = "Mix [Upper-Lower]";
            this.mix.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contact me:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 317);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 378);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GitHub";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(12, 348);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(51, 13);
            this.linkLabel3.TabIndex = 10;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Telegram";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "FreeCabbo10#6558";
            // 
            // copyclip
            // 
            this.copyclip.AutoSize = true;
            this.copyclip.Location = new System.Drawing.Point(12, 234);
            this.copyclip.Name = "copyclip";
            this.copyclip.Size = new System.Drawing.Size(0, 13);
            this.copyclip.TabIndex = 12;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.copyclip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mix);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.charslenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatedtext);
            this.Controls.Add(this.button1);
            this.Name = "Generator";
            this.Text = "AHAHAH_Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generator_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox generatedtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox charslenght;
        private System.Windows.Forms.RadioButton upper;
        private System.Windows.Forms.RadioButton lower;
        private System.Windows.Forms.RadioButton mix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label copyclip;
    }
}

