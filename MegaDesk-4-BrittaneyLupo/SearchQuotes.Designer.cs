namespace MegaDesk_4_BrittaneyLupo
{
    partial class SearchQuotes
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
            this.quoteCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quoteCancel
            // 
            this.quoteCancel.Location = new System.Drawing.Point(197, 226);
            this.quoteCancel.Name = "quoteCancel";
            this.quoteCancel.Size = new System.Drawing.Size(75, 23);
            this.quoteCancel.TabIndex = 0;
            this.quoteCancel.Text = "Cancel";
            this.quoteCancel.UseVisualStyleBackColor = true;
            this.quoteCancel.Click += new System.EventHandler(this.quoteCancel_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.quoteCancel);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quoteCancel;
    }
}