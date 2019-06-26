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
            this.blurBtn = new System.Windows.Forms.Button();
            this.blurtrackBar = new System.Windows.Forms.TrackBar();
            this.aquaBtn = new System.Windows.Forms.Button();
            this.swirlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AddImg
            // 
            this.AddImg.Location = new System.Drawing.Point(12, 12);
            this.AddImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddImg.Name = "AddImg";
            this.AddImg.Size = new System.Drawing.Size(111, 33);
            this.AddImg.TabIndex = 0;
            this.AddImg.Text = "Add image";
            this.AddImg.UseVisualStyleBackColor = true;
            this.AddImg.Click += new System.EventHandler(this.addImg_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(129, 12);
            this.imgBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(1023, 560);
            this.imgBox.TabIndex = 1;
            this.imgBox.TabStop = false;
            // 
            // delImg
            // 
            this.delImg.Location = new System.Drawing.Point(12, 60);
            this.delImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delImg.Name = "delImg";
            this.delImg.Size = new System.Drawing.Size(111, 34);
            this.delImg.TabIndex = 2;
            this.delImg.Text = "Delete image";
            this.delImg.UseVisualStyleBackColor = true;
            this.delImg.Click += new System.EventHandler(this.delImg_Click);
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Location = new System.Drawing.Point(27, 586);
            this.sepiaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(107, 33);
            this.sepiaBtn.TabIndex = 3;
            this.sepiaBtn.Text = "Sepia";
            this.sepiaBtn.UseVisualStyleBackColor = true;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // saveImg
            // 
            this.saveImg.Location = new System.Drawing.Point(12, 111);
            this.saveImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(111, 33);
            this.saveImg.TabIndex = 4;
            this.saveImg.Text = "Save image";
            this.saveImg.UseVisualStyleBackColor = true;
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // bwBtn
            // 
            this.bwBtn.Location = new System.Drawing.Point(140, 586);
            this.bwBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bwBtn.Name = "bwBtn";
            this.bwBtn.Size = new System.Drawing.Size(107, 33);
            this.bwBtn.TabIndex = 5;
            this.bwBtn.Text = "Black\'n\'White";
            this.bwBtn.UseVisualStyleBackColor = true;
            this.bwBtn.Click += new System.EventHandler(this.bwBtn_Click);
            // 
            // negBtn
            // 
            this.negBtn.Location = new System.Drawing.Point(253, 586);
            this.negBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.negBtn.Name = "negBtn";
            this.negBtn.Size = new System.Drawing.Size(109, 32);
            this.negBtn.TabIndex = 6;
            this.negBtn.Text = "Negative";
            this.negBtn.UseVisualStyleBackColor = true;
            this.negBtn.Click += new System.EventHandler(this.negBtn_Click);
            // 
            // delfilterBtn
            // 
            this.delfilterBtn.Location = new System.Drawing.Point(12, 538);
            this.delfilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delfilterBtn.Name = "delfilterBtn";
            this.delfilterBtn.Size = new System.Drawing.Size(107, 34);
            this.delfilterBtn.TabIndex = 7;
            this.delfilterBtn.Text = "No filter";
            this.delfilterBtn.UseVisualStyleBackColor = true;
            this.delfilterBtn.Click += new System.EventHandler(this.delfilterBtn_Click);
            // 
            // grnscrBtn
            // 
            this.grnscrBtn.Location = new System.Drawing.Point(368, 586);
            this.grnscrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grnscrBtn.Name = "grnscrBtn";
            this.grnscrBtn.Size = new System.Drawing.Size(117, 32);
            this.grnscrBtn.TabIndex = 8;
            this.grnscrBtn.Text = "ChromaKey\'d";
            this.grnscrBtn.UseVisualStyleBackColor = true;
            this.grnscrBtn.Click += new System.EventHandler(this.grnscrBtn_Click);
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.Color.LightGray;
            this.trcThreshold.Location = new System.Drawing.Point(16, 645);
            this.trcThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trcThreshold.Maximum = 100;
            this.trcThreshold.Minimum = -100;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(419, 28);
            this.trcThreshold.TabIndex = 24;
            this.trcThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.TrcThreshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 625);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contrast";
            // 
            // lblContrastValue
            // 
            this.lblContrastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrastValue.Location = new System.Drawing.Point(443, 640);
            this.lblContrastValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrastValue.Name = "lblContrastValue";
            this.lblContrastValue.Size = new System.Drawing.Size(76, 37);
            this.lblContrastValue.TabIndex = 26;
            this.lblContrastValue.Text = "0";
            this.lblContrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcBrightness
            // 
            this.trcBrightness.AutoSize = false;
            this.trcBrightness.BackColor = System.Drawing.Color.LightGray;
            this.trcBrightness.Location = new System.Drawing.Point(527, 645);
            this.trcBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trcBrightness.Maximum = 100;
            this.trcBrightness.Minimum = -100;
            this.trcBrightness.Name = "trcBrightness";
            this.trcBrightness.Size = new System.Drawing.Size(419, 28);
            this.trcBrightness.TabIndex = 27;
            this.trcBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBrightness.ValueChanged += new System.EventHandler(this.trcBrightness_valueCHanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 625);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Brightness";
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessValue.Location = new System.Drawing.Point(953, 636);
            this.lblBrightnessValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(76, 37);
            this.lblBrightnessValue.TabIndex = 29;
            this.lblBrightnessValue.Text = "0";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blurBtn
            // 
            this.blurBtn.Location = new System.Drawing.Point(491, 586);
            this.blurBtn.Name = "blurBtn";
            this.blurBtn.Size = new System.Drawing.Size(111, 32);
            this.blurBtn.TabIndex = 30;
            this.blurBtn.Text = "Blur";
            this.blurBtn.UseVisualStyleBackColor = true;
            this.blurBtn.Click += new System.EventHandler(this.blurBtn_Click);
            // 
            // blurtrackBar
            // 
            this.blurtrackBar.Location = new System.Drawing.Point(608, 586);
            this.blurtrackBar.Name = "blurtrackBar";
            this.blurtrackBar.Size = new System.Drawing.Size(116, 56);
            this.blurtrackBar.TabIndex = 31;
            this.blurtrackBar.Scroll += new System.EventHandler(this.blurtrackBar_Scroll);
            // 
            // aquaBtn
            // 
            this.aquaBtn.Location = new System.Drawing.Point(730, 586);
            this.aquaBtn.Name = "aquaBtn";
            this.aquaBtn.Size = new System.Drawing.Size(118, 32);
            this.aquaBtn.TabIndex = 32;
            this.aquaBtn.Text = "Aquatic";
            this.aquaBtn.UseVisualStyleBackColor = true;
            this.aquaBtn.Click += new System.EventHandler(this.aquaBtn_Click);
            // 
            // swirlBtn
            // 
            this.swirlBtn.Location = new System.Drawing.Point(854, 586);
            this.swirlBtn.Name = "swirlBtn";
            this.swirlBtn.Size = new System.Drawing.Size(115, 32);
            this.swirlBtn.TabIndex = 33;
            this.swirlBtn.Text = "Swirl it!";
            this.swirlBtn.UseVisualStyleBackColor = true;
            this.swirlBtn.Click += new System.EventHandler(this.swirlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 688);
            this.Controls.Add(this.swirlBtn);
            this.Controls.Add(this.aquaBtn);
            this.Controls.Add(this.blurtrackBar);
            this.Controls.Add(this.blurBtn);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FilterMaker";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurtrackBar)).EndInit();
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
        private System.Windows.Forms.Button blurBtn;
        private System.Windows.Forms.TrackBar blurtrackBar;
        private System.Windows.Forms.Button aquaBtn;
        private System.Windows.Forms.Button swirlBtn;
    }
}

