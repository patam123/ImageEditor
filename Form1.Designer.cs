using System;

namespace ImageModifierForms
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
            this.NegativeBtn = new System.Windows.Forms.Button();
            this.GreyScaleBtn = new System.Windows.Forms.Button();
            this.BlurBtn = new System.Windows.Forms.Button();
            this.pictureBoxOrg = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnd = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // NegativeBtn
            // 
            this.NegativeBtn.Location = new System.Drawing.Point(627, 113);
            this.NegativeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NegativeBtn.Name = "NegativeBtn";
            this.NegativeBtn.Size = new System.Drawing.Size(101, 38);
            this.NegativeBtn.TabIndex = 0;
            this.NegativeBtn.Text = "Invert";
            this.NegativeBtn.UseVisualStyleBackColor = true;
            this.NegativeBtn.Click += new System.EventHandler(this.NegativeBtn_Click);
            // 
            // GreyScaleBtn
            // 
            this.GreyScaleBtn.Location = new System.Drawing.Point(627, 232);
            this.GreyScaleBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GreyScaleBtn.Name = "GreyScaleBtn";
            this.GreyScaleBtn.Size = new System.Drawing.Size(101, 38);
            this.GreyScaleBtn.TabIndex = 1;
            this.GreyScaleBtn.Text = "Greyscale";
            this.GreyScaleBtn.UseVisualStyleBackColor = true;
            this.GreyScaleBtn.Click += new System.EventHandler(this.GreyScaleBtn_Click);
            // 
            // BlurBtn
            // 
            this.BlurBtn.Location = new System.Drawing.Point(627, 355);
            this.BlurBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BlurBtn.Name = "BlurBtn";
            this.BlurBtn.Size = new System.Drawing.Size(101, 38);
            this.BlurBtn.TabIndex = 2;
            this.BlurBtn.Text = "Blur";
            this.BlurBtn.UseVisualStyleBackColor = true;
            this.BlurBtn.Click += new System.EventHandler(this.BlurBtn_Click);
            // 
            // pictureBoxOrg
            // 
            this.pictureBoxOrg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxOrg.Location = new System.Drawing.Point(87, 45);
            this.pictureBoxOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxOrg.Name = "pictureBoxOrg";
            this.pictureBoxOrg.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrg.TabIndex = 4;
            this.pictureBoxOrg.TabStop = false;
            // 
            // pictureBoxEnd
            // 
            this.pictureBoxEnd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxEnd.Location = new System.Drawing.Point(844, 45);
            this.pictureBoxEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEnd.Name = "pictureBoxEnd";
            this.pictureBoxEnd.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnd.TabIndex = 5;
            this.pictureBoxEnd.TabStop = false;
            this.pictureBoxEnd.Click += new System.EventHandler(this.PbPostMod_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseBtn.Location = new System.Drawing.Point(195, 492);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(150, 30);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse file...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(995, 499);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 562);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBoxEnd);
            this.Controls.Add(this.pictureBoxOrg);
            this.Controls.Add(this.BlurBtn);
            this.Controls.Add(this.GreyScaleBtn);
            this.Controls.Add(this.NegativeBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).EndInit();
            this.ResumeLayout(false);

        }

        private void PbPostMod_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button NegativeBtn;
        private System.Windows.Forms.Button GreyScaleBtn;
        private System.Windows.Forms.Button BlurBtn;
        private System.Windows.Forms.PictureBox pictureBoxOrg;
        private System.Windows.Forms.PictureBox pictureBoxEnd;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

