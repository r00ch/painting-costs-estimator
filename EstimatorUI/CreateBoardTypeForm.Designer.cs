namespace EstimatorUI
{
	partial class CreateBoardTypeForm
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
			this.newBoardBox = new System.Windows.Forms.GroupBox();
			this.newBoardNameLabel = new System.Windows.Forms.Label();
			this.newBoardpriceLabel = new System.Windows.Forms.Label();
			this.newBoardNameTextBox = new System.Windows.Forms.TextBox();
			this.newBoardPriceTextBox = new System.Windows.Forms.TextBox();
			this.createBoardButton = new System.Windows.Forms.Button();
			this.newBoardBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// newBoardBox
			// 
			this.newBoardBox.Controls.Add(this.createBoardButton);
			this.newBoardBox.Controls.Add(this.newBoardPriceTextBox);
			this.newBoardBox.Controls.Add(this.newBoardNameTextBox);
			this.newBoardBox.Controls.Add(this.newBoardpriceLabel);
			this.newBoardBox.Controls.Add(this.newBoardNameLabel);
			this.newBoardBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.newBoardBox.Location = new System.Drawing.Point(25, 30);
			this.newBoardBox.Name = "newBoardBox";
			this.newBoardBox.Size = new System.Drawing.Size(298, 299);
			this.newBoardBox.TabIndex = 1;
			this.newBoardBox.TabStop = false;
			this.newBoardBox.Text = "New board:";
			// 
			// newBoardNameLabel
			// 
			this.newBoardNameLabel.AutoSize = true;
			this.newBoardNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardNameLabel.Location = new System.Drawing.Point(23, 41);
			this.newBoardNameLabel.Name = "newBoardNameLabel";
			this.newBoardNameLabel.Size = new System.Drawing.Size(74, 30);
			this.newBoardNameLabel.TabIndex = 0;
			this.newBoardNameLabel.Text = "Name:";
			// 
			// newBoardpriceLabel
			// 
			this.newBoardpriceLabel.AutoSize = true;
			this.newBoardpriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardpriceLabel.Location = new System.Drawing.Point(23, 122);
			this.newBoardpriceLabel.Name = "newBoardpriceLabel";
			this.newBoardpriceLabel.Size = new System.Drawing.Size(63, 30);
			this.newBoardpriceLabel.TabIndex = 1;
			this.newBoardpriceLabel.Text = "Price:";
			// 
			// newBoardNameTextBox
			// 
			this.newBoardNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardNameTextBox.Location = new System.Drawing.Point(28, 74);
			this.newBoardNameTextBox.Name = "newBoardNameTextBox";
			this.newBoardNameTextBox.Size = new System.Drawing.Size(240, 35);
			this.newBoardNameTextBox.TabIndex = 2;
			// 
			// newBoardPriceTextBox
			// 
			this.newBoardPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardPriceTextBox.Location = new System.Drawing.Point(28, 155);
			this.newBoardPriceTextBox.Name = "newBoardPriceTextBox";
			this.newBoardPriceTextBox.Size = new System.Drawing.Size(240, 35);
			this.newBoardPriceTextBox.TabIndex = 3;
			// 
			// createBoardButton
			// 
			this.createBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createBoardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createBoardButton.Location = new System.Drawing.Point(68, 215);
			this.createBoardButton.Name = "createBoardButton";
			this.createBoardButton.Size = new System.Drawing.Size(160, 60);
			this.createBoardButton.TabIndex = 11;
			this.createBoardButton.Text = "Create";
			this.createBoardButton.UseVisualStyleBackColor = true;
			// 
			// CreateBoardTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(348, 384);
			this.Controls.Add(this.newBoardBox);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.MaximizeBox = false;
			this.Name = "CreateBoardTypeForm";
			this.Text = "Create new board type";
			this.newBoardBox.ResumeLayout(false);
			this.newBoardBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox newBoardBox;
		private System.Windows.Forms.TextBox newBoardPriceTextBox;
		private System.Windows.Forms.TextBox newBoardNameTextBox;
		private System.Windows.Forms.Label newBoardpriceLabel;
		private System.Windows.Forms.Label newBoardNameLabel;
		private System.Windows.Forms.Button createBoardButton;
	}
}