namespace PAMProject
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddImg = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.delImg = new System.Windows.Forms.Button();
            this.sepiaBtn = new System.Windows.Forms.Button();
            this.saveImg = new System.Windows.Forms.Button();
            this.bwBtn = new System.Windows.Forms.Button();
            this.negBtn = new System.Windows.Forms.Button();
            this.delfilterBtn = new System.Windows.Forms.Button();
            this.grnscrBtn = new System.Windows.Forms.Button();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContrastValue = new System.Windows.Forms.Label();
            this.trcBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // AddImg
            // 
            this.AddImg.Location = new System.Drawing.Point(9, 10);
            this.AddImg.Margin = new System.Windows.Forms.Padding(2);
            this.AddImg.Name = "AddImg";
            this.AddImg.Size = new System.Drawing.Size(83, 27);
            this.AddImg.TabIndex = 0;
            this.AddImg.Text = "Add image";
            this.AddImg.UseVisualStyleBackColor = true;
            this.AddImg.Click += new System.EventHandler(this.addImg_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(97, 10);
            this.imgBox.Margin = new System.Windows.Forms.Padding(2);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(767, 455);
            this.imgBox.TabIndex = 1;
            this.imgBox.TabStop = false;
            // 
            // delImg
            // 
            this.delImg.Location = new System.Drawing.Point(9, 49);
            this.delImg.Margin = new System.Windows.Forms.Padding(2);
            this.delImg.Name = "delImg";
            this.delImg.Size = new System.Drawing.Size(83, 28);
            this.delImg.TabIndex = 2;
            this.delImg.Text = "Delete image";
            this.delImg.UseVisualStyleBackColor = true;
            this.delImg.Click += new System.EventHandler(this.delImg_Click);
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Location = new System.Drawing.Point(9, 475);
            this.sepiaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(80, 27);
            this.sepiaBtn.TabIndex = 3;
            this.sepiaBtn.Text = "Sepia";
            this.sepiaBtn.UseVisualStyleBackColor = true;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // saveImg
            // 
            this.saveImg.Location = new System.Drawing.Point(9, 90);
            this.saveImg.Margin = new System.Windows.Forms.Padding(2);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(83, 27);
            this.saveImg.TabIndex = 4;
            this.saveImg.Text = "Save image";
            this.saveImg.UseVisualStyleBackColor = true;
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // bwBtn
            // 
            this.bwBtn.Location = new System.Drawing.Point(93, 475);
            this.bwBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bwBtn.Name = "bwBtn";
            this.bwBtn.Size = new System.Drawing.Size(80, 27);
            this.bwBtn.TabIndex = 5;
            this.bwBtn.Text = "Black\'n\'White";
            this.bwBtn.UseVisualStyleBackColor = true;
            this.bwBtn.Click += new System.EventHandler(this.bwBtn_Click);
            // 
            // negBtn
            // 
            this.negBtn.Location = new System.Drawing.Point(177, 476);
            this.negBtn.Margin = new System.Windows.Forms.Padding(2);
            this.negBtn.Name = "negBtn";
            this.negBtn.Size = new System.Drawing.Size(82, 26);
            this.negBtn.TabIndex = 6;
            this.negBtn.Text = "Negative";
            this.negBtn.UseVisualStyleBackColor = true;
            this.negBtn.Click += new System.EventHandler(this.negBtn_Click);
            // 
            // delfilterBtn
            // 
            this.delfilterBtn.Location = new System.Drawing.Point(9, 437);
            this.delfilterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delfilterBtn.Name = "delfilterBtn";
            this.delfilterBtn.Size = new System.Drawing.Size(80, 28);
            this.delfilterBtn.TabIndex = 7;
            this.delfilterBtn.Text = "No filter";
            this.delfilterBtn.UseVisualStyleBackColor = true;
            this.delfilterBtn.Click += new System.EventHandler(this.delfilterBtn_Click);
            // 
            // grnscrBtn
            // 
            this.grnscrBtn.Location = new System.Drawing.Point(263, 474);
            this.grnscrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.grnscrBtn.Name = "grnscrBtn";
            this.grnscrBtn.Size = new System.Drawing.Size(88, 27);
            this.grnscrBtn.TabIndex = 8;
            this.grnscrBtn.Text = "ChromaKey\'d";
            this.grnscrBtn.UseVisualStyleBackColor = true;
            this.grnscrBtn.Click += new System.EventHandler(this.grnscrBtn_Click);
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.Color.LightGray;
            this.trcThreshold.Location = new System.Drawing.Point(12, 524);
            this.trcThreshold.Maximum = 100;
            this.trcThreshold.Minimum = -100;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(314, 23);
            this.trcThreshold.TabIndex = 24;
            this.trcThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.TrcThreshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contrast";
            // 
            // lblContrastValue
            // 
            this.lblContrastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrastValue.Location = new System.Drawing.Point(332, 520);
            this.lblContrastValue.Name = "lblContrastValue";
            this.lblContrastValue.Size = new System.Drawing.Size(57, 30);
            this.lblContrastValue.TabIndex = 26;
            this.lblContrastValue.Text = "0";
            this.lblContrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcBrightness
            // 
            this.trcBrightness.AutoSize = false;
            this.trcBrightness.BackColor = System.Drawing.Color.LightGray;
            this.trcBrightness.Location = new System.Drawing.Point(395, 524);
            this.trcBrightness.Maximum = 100;
            this.trcBrightness.Minimum = -100;
            this.trcBrightness.Name = "trcBrightness";
            this.trcBrightness.Size = new System.Drawing.Size(314, 23);
            this.trcBrightness.TabIndex = 27;
            this.trcBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBrightness.ValueChanged += new System.EventHandler(this.trcBrightness_valueCHanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Brightness";
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessValue.Location = new System.Drawing.Point(715, 517);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(57, 30);
            this.lblBrightnessValue.TabIndex = 29;
            this.lblBrightnessValue.Text = "0";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 559);
            this.Controls.Add(this.lblBrightnessValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trcBrightness);
            this.Controls.Add(this.lblContrastValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trcThreshold);
            this.Controls.Add(this.grnscrBtn);
            this.Controls.Add(this.delfilterBtn);
            this.Controls.Add(this.negBtn);
            this.Controls.Add(this.bwBtn);
            this.Controls.Add(this.saveImg);
            this.Controls.Add(this.sepiaBtn);
            this.Controls.Add(this.delImg);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.AddImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FilterMaker";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddImg;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button delImg;
        private System.Windows.Forms.Button sepiaBtn;
        private System.Windows.Forms.Button saveImg;
        private System.Windows.Forms.Button bwBtn;
        private System.Windows.Forms.Button negBtn;
        private System.Windows.Forms.Button delfilterBtn;
        private System.Windows.Forms.Button grnscrBtn;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContrastValue;
        private System.Windows.Forms.TrackBar trcBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrightnessValue;
    }
}

