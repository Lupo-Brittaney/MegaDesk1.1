namespace MegaDesk_4_BrittaneyLupo
{
    partial class DisplayQuote
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
            this.displayCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerNameDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quoteDateDisplay = new System.Windows.Forms.Label();
            this.depthDisplay = new System.Windows.Forms.Label();
            this.widthDisplay = new System.Windows.Forms.Label();
            this.materialDisplay = new System.Windows.Forms.Label();
            this.rushDisplay = new System.Windows.Forms.Label();
            this.quoteTotalDisplay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drawersDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayCancel
            // 
            this.displayCancel.Location = new System.Drawing.Point(236, 343);
            this.displayCancel.Name = "displayCancel";
            this.displayCancel.Size = new System.Drawing.Size(75, 23);
            this.displayCancel.TabIndex = 0;
            this.displayCancel.Text = "Cancel";
            this.displayCancel.UseVisualStyleBackColor = true;
            this.displayCancel.Click += new System.EventHandler(this.displayCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quote Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desk Depth (in)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desk Width (in)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desktop Material";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CustomerNameDisplay
            // 
            this.CustomerNameDisplay.AutoSize = true;
            this.CustomerNameDisplay.Location = new System.Drawing.Point(140, 12);
            this.CustomerNameDisplay.Name = "CustomerNameDisplay";
            this.CustomerNameDisplay.Size = new System.Drawing.Size(63, 13);
            this.CustomerNameDisplay.TabIndex = 6;
            this.CustomerNameDisplay.Text = "Placeholder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rush Order (days)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quote Total";
            // 
            // quoteDateDisplay
            // 
            this.quoteDateDisplay.AutoSize = true;
            this.quoteDateDisplay.Location = new System.Drawing.Point(140, 51);
            this.quoteDateDisplay.Name = "quoteDateDisplay";
            this.quoteDateDisplay.Size = new System.Drawing.Size(35, 13);
            this.quoteDateDisplay.TabIndex = 9;
            this.quoteDateDisplay.Text = "label8";
            // 
            // depthDisplay
            // 
            this.depthDisplay.AutoSize = true;
            this.depthDisplay.Location = new System.Drawing.Point(140, 129);
            this.depthDisplay.Name = "depthDisplay";
            this.depthDisplay.Size = new System.Drawing.Size(35, 13);
            this.depthDisplay.TabIndex = 10;
            this.depthDisplay.Text = "label9";
            // 
            // widthDisplay
            // 
            this.widthDisplay.AutoSize = true;
            this.widthDisplay.Location = new System.Drawing.Point(140, 90);
            this.widthDisplay.Name = "widthDisplay";
            this.widthDisplay.Size = new System.Drawing.Size(41, 13);
            this.widthDisplay.TabIndex = 11;
            this.widthDisplay.Text = "label10";
            // 
            // materialDisplay
            // 
            this.materialDisplay.AutoSize = true;
            this.materialDisplay.Location = new System.Drawing.Point(140, 168);
            this.materialDisplay.Name = "materialDisplay";
            this.materialDisplay.Size = new System.Drawing.Size(41, 13);
            this.materialDisplay.TabIndex = 12;
            this.materialDisplay.Text = "label11";
            // 
            // rushDisplay
            // 
            this.rushDisplay.AutoSize = true;
            this.rushDisplay.Location = new System.Drawing.Point(140, 207);
            this.rushDisplay.Name = "rushDisplay";
            this.rushDisplay.Size = new System.Drawing.Size(41, 13);
            this.rushDisplay.TabIndex = 13;
            this.rushDisplay.Text = "label12";
            // 
            // quoteTotalDisplay
            // 
            this.quoteTotalDisplay.AutoSize = true;
            this.quoteTotalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotalDisplay.Location = new System.Drawing.Point(140, 285);
            this.quoteTotalDisplay.Name = "quoteTotalDisplay";
            this.quoteTotalDisplay.Size = new System.Drawing.Size(54, 17);
            this.quoteTotalDisplay.TabIndex = 14;
            this.quoteTotalDisplay.Text = "label13";
            this.quoteTotalDisplay.Click += new System.EventHandler(this.quoteTotalDisplay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Drawers";
            // 
            // drawersDisplay
            // 
            this.drawersDisplay.AutoSize = true;
            this.drawersDisplay.Location = new System.Drawing.Point(140, 246);
            this.drawersDisplay.Name = "drawersDisplay";
            this.drawersDisplay.Size = new System.Drawing.Size(35, 13);
            this.drawersDisplay.TabIndex = 16;
            this.drawersDisplay.Text = "label9";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 378);
            this.ControlBox = false;
            this.Controls.Add(this.drawersDisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quoteTotalDisplay);
            this.Controls.Add(this.rushDisplay);
            this.Controls.Add(this.materialDisplay);
            this.Controls.Add(this.widthDisplay);
            this.Controls.Add(this.depthDisplay);
            this.Controls.Add(this.quoteDateDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerNameDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayCancel);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CustomerNameDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label quoteDateDisplay;
        private System.Windows.Forms.Label depthDisplay;
        private System.Windows.Forms.Label widthDisplay;
        private System.Windows.Forms.Label materialDisplay;
        private System.Windows.Forms.Label rushDisplay;
        private System.Windows.Forms.Label quoteTotalDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label drawersDisplay;
    }
}