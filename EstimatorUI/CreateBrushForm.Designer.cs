namespace EstimatorUI
{
	partial class CreateBrushForm
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
			this.newBrushBox = new System.Windows.Forms.GroupBox();
			this.newBrushTypeComboBox = new System.Windows.Forms.ComboBox();
			this.newBrushTypeLabel = new System.Windows.Forms.Label();
			this.newBrushShapeComboBox = new System.Windows.Forms.ComboBox();
			this.newBrushSizeLabel = new System.Windows.Forms.Label();
			this.createBrushButton = new System.Windows.Forms.Button();
			this.newBrushPriceTextBox = new System.Windows.Forms.TextBox();
			this.newBrushSizeTextBox = new System.Windows.Forms.TextBox();
			this.newBrushPriceLabel = new System.Windows.Forms.Label();
			this.newBrushShapeLabel = new System.Windows.Forms.Label();
			this.newBrushBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// newBrushBox
			// 
			this.newBrushBox.Controls.Add(this.newBrushTypeComboBox);
			this.newBrushBox.Controls.Add(this.newBrushTypeLabel);
			this.newBrushBox.Controls.Add(this.newBrushShapeComboBox);
			this.newBrushBox.Controls.Add(this.newBrushSizeLabel);
			this.newBrushBox.Controls.Add(this.createBrushButton);
			this.newBrushBox.Controls.Add(this.newBrushPriceTextBox);
			this.newBrushBox.Controls.Add(this.newBrushSizeTextBox);
			this.newBrushBox.Controls.Add(this.newBrushPriceLabel);
			this.newBrushBox.Controls.Add(this.newBrushShapeLabel);
			this.newBrushBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.newBrushBox.Location = new System.Drawing.Point(25, 30);
			this.newBrushBox.Name = "newBrushBox";
			this.newBrushBox.Size = new System.Drawing.Size(298, 472);
			this.newBrushBox.TabIndex = 4;
			this.newBrushBox.TabStop = false;
			this.newBrushBox.Text = "New brush:";
			// 
			// newBrushTypeComboBox
			// 
			this.newBrushTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushTypeComboBox.FormattingEnabled = true;
			this.newBrushTypeComboBox.Items.AddRange(new object[] {
            "Natural",
            "Synthetic"});
			this.newBrushTypeComboBox.Location = new System.Drawing.Point(28, 152);
			this.newBrushTypeComboBox.Name = "newBrushTypeComboBox";
			this.newBrushTypeComboBox.Size = new System.Drawing.Size(240, 38);
			this.newBrushTypeComboBox.TabIndex = 15;
			// 
			// newBrushTypeLabel
			// 
			this.newBrushTypeLabel.AutoSize = true;
			this.newBrushTypeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushTypeLabel.Location = new System.Drawing.Point(23, 119);
			this.newBrushTypeLabel.Name = "newBrushTypeLabel";
			this.newBrushTypeLabel.Size = new System.Drawing.Size(127, 30);
			this.newBrushTypeLabel.TabIndex = 14;
			this.newBrushTypeLabel.Text = "Tip material:";
			// 
			// newBrushShapeComboBox
			// 
			this.newBrushShapeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushShapeComboBox.FormattingEnabled = true;
			this.newBrushShapeComboBox.Items.AddRange(new object[] {
            "Point tip",
            "Flat",
            "Round",
            "Fan"});
			this.newBrushShapeComboBox.Location = new System.Drawing.Point(28, 74);
			this.newBrushShapeComboBox.Name = "newBrushShapeComboBox";
			this.newBrushShapeComboBox.Size = new System.Drawing.Size(240, 38);
			this.newBrushShapeComboBox.TabIndex = 13;
			// 
			// newBrushSizeLabel
			// 
			this.newBrushSizeLabel.AutoSize = true;
			this.newBrushSizeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushSizeLabel.Location = new System.Drawing.Point(23, 203);
			this.newBrushSizeLabel.Name = "newBrushSizeLabel";
			this.newBrushSizeLabel.Size = new System.Drawing.Size(55, 30);
			this.newBrushSizeLabel.TabIndex = 12;
			this.newBrushSizeLabel.Text = "Size:";
			// 
			// createBrushButton
			// 
			this.createBrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createBrushButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createBrushButton.Location = new System.Drawing.Point(69, 383);
			this.createBrushButton.Name = "createBrushButton";
			this.createBrushButton.Size = new System.Drawing.Size(160, 60);
			this.createBrushButton.TabIndex = 11;
			this.createBrushButton.Text = "Create";
			this.createBrushButton.UseVisualStyleBackColor = true;
			// 
			// newBrushPriceTextBox
			// 
			this.newBrushPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushPriceTextBox.Location = new System.Drawing.Point(28, 320);
			this.newBrushPriceTextBox.Name = "newBrushPriceTextBox";
			this.newBrushPriceTextBox.Size = new System.Drawing.Size(240, 35);
			this.newBrushPriceTextBox.TabIndex = 3;
			// 
			// newBrushSizeTextBox
			// 
			this.newBrushSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushSizeTextBox.Location = new System.Drawing.Point(28, 236);
			this.newBrushSizeTextBox.Name = "newBrushSizeTextBox";
			this.newBrushSizeTextBox.Size = new System.Drawing.Size(240, 35);
			this.newBrushSizeTextBox.TabIndex = 2;
			// 
			// newBrushPriceLabel
			// 
			this.newBrushPriceLabel.AutoSize = true;
			this.newBrushPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushPriceLabel.Location = new System.Drawing.Point(23, 287);
			this.newBrushPriceLabel.Name = "newBrushPriceLabel";
			this.newBrushPriceLabel.Size = new System.Drawing.Size(63, 30);
			this.newBrushPriceLabel.TabIndex = 1;
			this.newBrushPriceLabel.Text = "Price:";
			// 
			// newBrushShapeLabel
			// 
			this.newBrushShapeLabel.AutoSize = true;
			this.newBrushShapeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushShapeLabel.Location = new System.Drawing.Point(23, 41);
			this.newBrushShapeLabel.Name = "newBrushShapeLabel";
			this.newBrushShapeLabel.Size = new System.Drawing.Size(75, 30);
			this.newBrushShapeLabel.TabIndex = 0;
			this.newBrushShapeLabel.Text = "Shape:";
			// 
			// CreateBrushForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(347, 538);
			this.Controls.Add(this.newBrushBox);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.MaximizeBox = false;
			this.Name = "CreateBrushForm";
			this.Text = "Create new brush";
			this.newBrushBox.ResumeLayout(false);
			this.newBrushBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox newBrushBox;
		private System.Windows.Forms.ComboBox newBrushTypeComboBox;
		private System.Windows.Forms.Label newBrushTypeLabel;
		private System.Windows.Forms.ComboBox newBrushShapeComboBox;
		private System.Windows.Forms.Label newBrushSizeLabel;
		private System.Windows.Forms.Button createBrushButton;
		private System.Windows.Forms.TextBox newBrushPriceTextBox;
		private System.Windows.Forms.TextBox newBrushSizeTextBox;
		private System.Windows.Forms.Label newBrushPriceLabel;
		private System.Windows.Forms.Label newBrushShapeLabel;
	}
}