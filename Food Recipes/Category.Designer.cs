﻿namespace Food_Recipes
{
    partial class Category
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
            this.SuspendLayout();
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.DoubleBuffered = true;
            this.Name = "Category";
            this.Size = new System.Drawing.Size(498, 530);
            this.Load += new System.EventHandler(this.Category_Load);
            this.Click += new System.EventHandler(this.Category_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Category_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Category_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
