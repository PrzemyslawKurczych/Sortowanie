﻿namespace PositioningElements
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
            this.btStart = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(42, 24);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(97, 35);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Sortuj";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(161, 24);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(97, 35);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "Zakończ";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.BtEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 85);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Sortowanie punktów z Ewmapy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btEnd;
    }
}

