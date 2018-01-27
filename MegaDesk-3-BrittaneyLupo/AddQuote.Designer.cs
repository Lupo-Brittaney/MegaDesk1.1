namespace MegaDesk_3_BrittaneyLupo
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.addCancel = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.material = new System.Windows.Forms.ListBox();
            this.rush = new System.Windows.Forms.ListBox();
            this.drawers = new System.Windows.Forms.ListBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Location = new System.Drawing.Point(219, 420);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(75, 23);
            this.addCancel.TabIndex = 12;
            this.addCancel.Text = "Cancel";
            this.addCancel.UseVisualStyleBackColor = true;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(30, 422);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(92, 43);
            this.width.MaxLength = 2;
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(30, 20);
            this.width.TabIndex = 2;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            this.width.Validated += new System.EventHandler(this.Width_Validated);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(92, 79);
            this.depth.MaxLength = 2;
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(30, 20);
            this.depth.TabIndex = 3;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "Oak",
            "Pine",
            "Veneer",
            "Laminate"});
            this.material.Location = new System.Drawing.Point(92, 46);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(120, 30);
            this.material.TabIndex = 5;
            // 
            // rush
            // 
            this.rush.FormattingEnabled = true;
            this.rush.Items.AddRange(new object[] {
            "No Rush",
            "3 days",
            "5 days",
            "7 days"});
            this.rush.Location = new System.Drawing.Point(91, 54);
            this.rush.Name = "rush";
            this.rush.Size = new System.Drawing.Size(120, 30);
            this.rush.TabIndex = 8;
            // 
            // drawers
            // 
            this.drawers.FormattingEnabled = true;
            this.drawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawers.Location = new System.Drawing.Point(92, 92);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(120, 30);
            this.drawers.TabIndex = 6;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 46);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(75, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width (inches)";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(5, 82);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(76, 13);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth (inches)";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(37, 46);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(44, 13);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rush";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of \r\nDrawers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 18);
            this.textBox1.MaxLength = 55;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.depth);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Controls.Add(this.depthLabel);
            this.groupBox1.Location = new System.Drawing.Point(30, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(128, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "12in - 48in only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(128, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "24in - 96 in only";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter size in whole inches";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.drawers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.material);
            this.groupBox2.Controls.Add(this.materialLabel);
            this.groupBox2.Location = new System.Drawing.Point(30, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desk Contruction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(49, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pick one option for each";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rush);
            this.groupBox3.Location = new System.Drawing.Point(31, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shipping Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(66, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pick one option ";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 452);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCancel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.ListBox material;
        private System.Windows.Forms.ListBox rush;
        private System.Windows.Forms.ListBox drawers;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}