namespace button
{
    partial class fmMain
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
            this.btFlat = new System.Windows.Forms.Button();
            this.btPopup = new System.Windows.Forms.Button();
            this.btStandart = new System.Windows.Forms.Button();
            this.btImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFlat
            // 
            this.btFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFlat.Location = new System.Drawing.Point(46, 29);
            this.btFlat.Name = "btFlat";
            this.btFlat.Size = new System.Drawing.Size(198, 23);
            this.btFlat.TabIndex = 0;
            this.btFlat.Text = "Flat";
            this.btFlat.UseVisualStyleBackColor = true;
            // 
            // btPopup
            // 
            this.btPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPopup.Location = new System.Drawing.Point(46, 68);
            this.btPopup.Name = "btPopup";
            this.btPopup.Size = new System.Drawing.Size(198, 23);
            this.btPopup.TabIndex = 1;
            this.btPopup.Text = "Popup";
            this.btPopup.UseVisualStyleBackColor = true;
            // 
            // btStandart
            // 
            this.btStandart.Location = new System.Drawing.Point(46, 109);
            this.btStandart.Name = "btStandart";
            this.btStandart.Size = new System.Drawing.Size(198, 61);
            this.btStandart.TabIndex = 2;
            this.btStandart.Text = "Standart";
            this.btStandart.UseVisualStyleBackColor = true;
            this.btStandart.Click += new System.EventHandler(this.btStandart_Click);
            // 
            // btImage
            // 
            this.btImage.Image = global::button.Properties.Resources.clogo;
            this.btImage.Location = new System.Drawing.Point(46, 186);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(198, 194);
            this.btImage.TabIndex = 3;
            this.btImage.Text = "Image";
            this.btImage.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 420);
            this.Controls.Add(this.btImage);
            this.Controls.Add(this.btStandart);
            this.Controls.Add(this.btPopup);
            this.Controls.Add(this.btFlat);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFlat;
        private System.Windows.Forms.Button btPopup;
        private System.Windows.Forms.Button btStandart;
        private System.Windows.Forms.Button btImage;
    }
}

