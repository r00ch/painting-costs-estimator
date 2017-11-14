namespace EstimatorUI
{
	partial class CreatePaintForm
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
			this.newPaintBox = new System.Windows.Forms.GroupBox();
			this.createPaintButton = new System.Windows.Forms.Button();
			this.newPaintPriceTextBox = new System.Windows.Forms.TextBox();
			this.newPaintTypeTextBox = new System.Windows.Forms.TextBox();
			this.newPaintPriceLabel = new System.Windows.Forms.Label();
			this.newPaintTypeLabel = new System.Windows.Forms.Label();
			this.newPaintBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// newPaintBox
			// 
			this.newPaintBox.Controls.Add(this.createPaintButton);
			this.newPaintBox.Controls.Add(this.newPaintPriceTextBox);
			this.newPaintBox.Controls.Add(this.newPaintTypeTextBox);
			this.newPaintBox.Controls.Add(this.newPaintPriceLabel);
			this.newPaintBox.Controls.Add(this.newPaintTypeLabel);
			this.newPaintBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.newPaintBox.Location = new System.Drawing.Point(25, 30);
			this.newPaintBox.Name = "newPaintBox";
			this.newPaintBox.Size = new System.Drawing.Size(298, 299);
			this.newPaintBox.TabIndex = 2;
			this.newPaintBox.TabStop = false;
			this.newPaintBox.Text = "New paint:";
			// 
			// createPaintButton
			// 
			this.createPaintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPaintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createPaintButton.Location = new System.Drawing.Point(68, 215);
			this.createPaintButton.Name = "createPaintButton";
			this.createPaintButton.Size = new System.Drawing.Size(160, 60);
			this.createPaintButton.TabIndex = 11;
			this.createPaintButton.Text = "Create";
			this.createPaintButton.UseVisualStyleBackColor = true;
			// 
			// newPaintPriceTextBox
			// 
			this.newPaintPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintPriceTextBox.Location = new System.Drawing.Point(28, 155);
			this.newPaintPriceTextBox.Name = "newPaintPriceTextBox";
			this.newPaintPriceTextBox.Size = new System.Drawing.Size(240, 35);
			this.newPaintPriceTextBox.TabIndex = 3;
			// 
			// newPaintTypeTextBox
			// 
			this.newPaintTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintTypeTextBox.Location = new System.Drawing.Point(28, 74);
			this.newPaintTypeTextBox.Name = "newPaintTypeTextBox";
			this.newPaintTypeTextBox.Size = new System.Drawing.Size(240, 35);
			this.newPaintTypeTextBox.TabIndex = 2;
			// 
			// newPaintPriceLabel
			// 
			this.newPaintPriceLabel.AutoSize = true;
			this.newPaintPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintPriceLabel.Location = new System.Drawing.Point(23, 122);
			this.newPaintPriceLabel.Name = "newPaintPriceLabel";
			this.newPaintPriceLabel.Size = new System.Drawing.Size(63, 30);
			this.newPaintPriceLabel.TabIndex = 1;
			this.newPaintPriceLabel.Text = "Price:";
			// 
			// newPaintTypeLabel
			// 
			this.newPaintTypeLabel.AutoSize = true;
			this.newPaintTypeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintTypeLabel.Location = new System.Drawing.Point(23, 41);
			this.newPaintTypeLabel.Name = "newPaintTypeLabel";
			this.newPaintTypeLabel.Size = new System.Drawing.Size(61, 30);
			this.newPaintTypeLabel.TabIndex = 0;
			this.newPaintTypeLabel.Text = "Type:";
			// 
			// CreatePaintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(348, 384);
			this.Controls.Add(this.newPaintBox);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.MaximizeBox = false;
			this.Name = "CreatePaintForm";
			this.Text = "Create new paint";
			this.newPaintBox.ResumeLayout(false);
			this.newPaintBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox newPaintBox;
		private System.Windows.Forms.Button createPaintButton;
		private System.Windows.Forms.TextBox newPaintPriceTextBox;
		private System.Windows.Forms.TextBox newPaintTypeTextBox;
		private System.Windows.Forms.Label newPaintPriceLabel;
		private System.Windows.Forms.Label newPaintTypeLabel;
	}
}