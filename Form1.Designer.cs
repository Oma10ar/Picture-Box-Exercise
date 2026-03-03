namespace PictureBoxExercise
{
    partial class frmMain
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.ErrorImage = global::PictureBoxExercise.Properties.Resources.Boy;
            this.pbPhoto.Location = new System.Drawing.Point(280, 109);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(250, 212);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(356, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 47);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "TITLE";
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoy.Location = new System.Drawing.Point(181, 362);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(61, 24);
            this.rbBoy.TabIndex = 6;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGirl.Location = new System.Drawing.Point(302, 362);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(60, 24);
            this.rbGirl.TabIndex = 7;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBook.Location = new System.Drawing.Point(412, 362);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(72, 24);
            this.rbBook.TabIndex = 8;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPen.Location = new System.Drawing.Point(547, 362);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(61, 24);
            this.rbPen.TabIndex = 9;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPen);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rbGirl);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPhoto);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbPen;
    }
}

