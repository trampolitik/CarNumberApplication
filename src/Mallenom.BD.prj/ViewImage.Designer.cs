namespace Mallenom.BD
{
	partial class ViewImage
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
			if(disposing && (components != null))
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this._btnLoadImage = new System.Windows.Forms.Button();
			this._btnSaveImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(368, 295);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// _btnLoadImage
			// 
			this._btnLoadImage.Location = new System.Drawing.Point(392, 12);
			this._btnLoadImage.Name = "_btnLoadImage";
			this._btnLoadImage.Size = new System.Drawing.Size(105, 23);
			this._btnLoadImage.TabIndex = 1;
			this._btnLoadImage.Text = "Загрузить";
			this._btnLoadImage.UseVisualStyleBackColor = true;
			this._btnLoadImage.Click += new System.EventHandler(this._btnLoadImage_Click);
			// 
			// _btnSaveImage
			// 
			this._btnSaveImage.Location = new System.Drawing.Point(392, 41);
			this._btnSaveImage.Name = "_btnSaveImage";
			this._btnSaveImage.Size = new System.Drawing.Size(105, 23);
			this._btnSaveImage.TabIndex = 2;
			this._btnSaveImage.Text = "Сохранить";
			this._btnSaveImage.UseVisualStyleBackColor = true;
			this._btnSaveImage.Click += new System.EventHandler(this._btnSaveImage_Click);
			// 
			// ViewImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 307);
			this.Controls.Add(this._btnSaveImage);
			this.Controls.Add(this._btnLoadImage);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewImage";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button _btnLoadImage;
		private System.Windows.Forms.Button _btnSaveImage;
	}
}