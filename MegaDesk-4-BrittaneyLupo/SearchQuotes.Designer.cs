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
            this.label1 = new System.Windows.Forms.Label();
            this.searchQuoteDisplay = new System.Windows.Forms.Label();
            this.searchDisplay = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.materialSelectBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // quoteCancel
            // 
            this.quoteCancel.Location = new System.Drawing.Point(305, 226);
            this.quoteCancel.Name = "quoteCancel";
            this.quoteCancel.Size = new System.Drawing.Size(75, 23);
            this.quoteCancel.TabIndex = 0;
            this.quoteCancel.Text = "Cancel";
            this.quoteCancel.UseVisualStyleBackColor = true;
            this.quoteCancel.Click += new System.EventHandler(this.quoteCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Material:";
            // 
            // searchQuoteDisplay
            // 
            this.searchQuoteDisplay.AutoSize = true;
            this.searchQuoteDisplay.Location = new System.Drawing.Point(29, 66);
            this.searchQuoteDisplay.Name = "searchQuoteDisplay";
            this.searchQuoteDisplay.Size = new System.Drawing.Size(0, 13);
            this.searchQuoteDisplay.TabIndex = 3;
            // 
            // searchDisplay
            // 
            this.searchDisplay.Location = new System.Drawing.Point(12, 109);
            this.searchDisplay.Name = "searchDisplay";
            this.searchDisplay.Size = new System.Drawing.Size(368, 97);
            this.searchDisplay.TabIndex = 4;
            this.searchDisplay.UseCompatibleStateImageBehavior = false;
            this.searchDisplay.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // materialSelectBox
            // 
            this.materialSelectBox.FormattingEnabled = true;
            this.materialSelectBox.Location = new System.Drawing.Point(185, 18);
            this.materialSelectBox.Name = "materialSelectBox";
            this.materialSelectBox.Size = new System.Drawing.Size(121, 21);
            this.materialSelectBox.TabIndex = 7;
            this.materialSelectBox.SelectionChangeCommitted += new System.EventHandler(this.materialSelectBox_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.ControlBox = false;
            this.Controls.Add(this.materialSelectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchDisplay);
            this.Controls.Add(this.searchQuoteDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quoteCancel);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quoteCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchQuoteDisplay;
        private System.Windows.Forms.ListView searchDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materialSelectBox;
    }
}