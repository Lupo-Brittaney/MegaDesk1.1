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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Location = new System.Drawing.Point(293, 298);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(75, 23);
            this.addCancel.TabIndex = 0;
            this.addCancel.Text = "Cancel";
            this.addCancel.UseVisualStyleBackColor = true;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(201, 298);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(142, 24);
            this.width.MaxLength = 2;
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 2;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            this.width.Validated += new System.EventHandler(this.Width_Validated);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(142, 74);
            this.depth.MaxLength = 2;
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 20);
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
            this.material.Location = new System.Drawing.Point(142, 176);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(120, 30);
            this.material.TabIndex = 4;
            // 
            // rush
            // 
            this.rush.FormattingEnabled = true;
            this.rush.Items.AddRange(new object[] {
            "No Rush",
            "3 days",
            "5 days",
            "7 days"});
            this.rush.Location = new System.Drawing.Point(142, 237);
            this.rush.Name = "rush";
            this.rush.Size = new System.Drawing.Size(120, 30);
            this.rush.TabIndex = 5;
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
            this.drawers.Location = new System.Drawing.Point(142, 117);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(120, 30);
            this.drawers.TabIndex = 6;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(56, 24);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(75, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width (inches)";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(55, 74);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(76, 13);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth (inches)";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(87, 176);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(44, 13);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rush";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Drawers";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 333);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.rush);
            this.Controls.Add(this.material);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
    }
}