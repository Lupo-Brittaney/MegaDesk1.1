﻿namespace MegaDesk_4_BrittaneyLupo
{
    partial class ViewAllQuotes
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
            this.viewCancel = new System.Windows.Forms.Button();
            this.quotesDisplay = new System.Windows.Forms.ListView();
            this.quotesDisplay2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewCancel
            // 
            this.viewCancel.Location = new System.Drawing.Point(360, 226);
            this.viewCancel.Name = "viewCancel";
            this.viewCancel.Size = new System.Drawing.Size(75, 23);
            this.viewCancel.TabIndex = 0;
            this.viewCancel.Text = "Cancel";
            this.viewCancel.UseVisualStyleBackColor = true;
            this.viewCancel.Click += new System.EventHandler(this.viewCancel_Click);
            // 
            // quotesDisplay
            // 
            this.quotesDisplay.Location = new System.Drawing.Point(12, 21);
            this.quotesDisplay.Name = "quotesDisplay";
            this.quotesDisplay.Size = new System.Drawing.Size(423, 98);
            this.quotesDisplay.TabIndex = 2;
            this.quotesDisplay.UseCompatibleStateImageBehavior = false;
            this.quotesDisplay.View = System.Windows.Forms.View.List;
            // 
            // quotesDisplay2
            // 
            this.quotesDisplay2.AutoSize = true;
            this.quotesDisplay2.Location = new System.Drawing.Point(13, 136);
            this.quotesDisplay2.Name = "quotesDisplay2";
            this.quotesDisplay2.Size = new System.Drawing.Size(0, 13);
            this.quotesDisplay2.TabIndex = 3;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.ControlBox = false;
            this.Controls.Add(this.quotesDisplay2);
            this.Controls.Add(this.quotesDisplay);
            this.Controls.Add(this.viewCancel);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewCancel;
        private System.Windows.Forms.ListView quotesDisplay;
        private System.Windows.Forms.Label quotesDisplay2;
    }
}