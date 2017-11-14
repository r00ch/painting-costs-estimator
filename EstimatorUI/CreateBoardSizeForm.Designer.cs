namespace EstimatorUI
{
	partial class CreateBoardSizeForm
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
			this.newSizeBox = new System.Windows.Forms.GroupBox();
			this.newSizeHeightComboBox = new System.Windows.Forms.ComboBox();
			this.sizeHeightLabel = new System.Windows.Forms.Label();
			this.sizeWidth = new System.Windows.Forms.Label();
			this.addSizeBox = new System.Windows.Forms.GroupBox();
			this.newSizeWidthComboBox = new System.Windows.Forms.ComboBox();
			this.createSizeButton = new System.Windows.Forms.Button();
			this.sizesListBox = new System.Windows.Forms.ListBox();
			this.boardsListBox = new System.Windows.Forms.ListBox();
			this.addSizeButton = new System.Windows.Forms.Button();
			this.sizeListLabel = new System.Windows.Forms.Label();
			this.boardListLabel = new System.Windows.Forms.Label();
			this.newSizeBox.SuspendLayout();
			this.addSizeBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// newSizeBox
			// 
			this.newSizeBox.Controls.Add(this.createSizeButton);
			this.newSizeBox.Controls.Add(this.newSizeHeightComboBox);
			this.newSizeBox.Controls.Add(this.sizeHeightLabel);
			this.newSizeBox.Controls.Add(this.newSizeWidthComboBox);
			this.newSizeBox.Controls.Add(this.sizeWidth);
			this.newSizeBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newSizeBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.newSizeBox.Location = new System.Drawing.Point(25, 30);
			this.newSizeBox.Name = "newSizeBox";
			this.newSizeBox.Size = new System.Drawing.Size(639, 142);
			this.newSizeBox.TabIndex = 1;
			this.newSizeBox.TabStop = false;
			this.newSizeBox.Text = "New size:";
			// 
			// newSizeHeightComboBox
			// 
			this.newSizeHeightComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newSizeHeightComboBox.FormattingEnabled = true;
			this.newSizeHeightComboBox.Location = new System.Drawing.Point(290, 74);
			this.newSizeHeightComboBox.Name = "newSizeHeightComboBox";
			this.newSizeHeightComboBox.Size = new System.Drawing.Size(200, 38);
			this.newSizeHeightComboBox.TabIndex = 3;
			// 
			// sizeHeightLabel
			// 
			this.sizeHeightLabel.AutoSize = true;
			this.sizeHeightLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sizeHeightLabel.Location = new System.Drawing.Point(285, 41);
			this.sizeHeightLabel.Name = "sizeHeightLabel";
			this.sizeHeightLabel.Size = new System.Drawing.Size(80, 30);
			this.sizeHeightLabel.TabIndex = 2;
			this.sizeHeightLabel.Text = "Height:";
			// 
			// sizeWidth
			// 
			this.sizeWidth.AutoSize = true;
			this.sizeWidth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sizeWidth.Location = new System.Drawing.Point(23, 41);
			this.sizeWidth.Name = "sizeWidth";
			this.sizeWidth.Size = new System.Drawing.Size(74, 30);
			this.sizeWidth.TabIndex = 0;
			this.sizeWidth.Text = "Width:";
			// 
			// addSizeBox
			// 
			this.addSizeBox.Controls.Add(this.boardListLabel);
			this.addSizeBox.Controls.Add(this.sizeListLabel);
			this.addSizeBox.Controls.Add(this.addSizeButton);
			this.addSizeBox.Controls.Add(this.boardsListBox);
			this.addSizeBox.Controls.Add(this.sizesListBox);
			this.addSizeBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.addSizeBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.addSizeBox.Location = new System.Drawing.Point(25, 178);
			this.addSizeBox.Name = "addSizeBox";
			this.addSizeBox.Size = new System.Drawing.Size(639, 399);
			this.addSizeBox.TabIndex = 2;
			this.addSizeBox.TabStop = false;
			this.addSizeBox.Text = "Assign size to boards";
			// 
			// newSizeWidthComboBox
			// 
			this.newSizeWidthComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newSizeWidthComboBox.FormattingEnabled = true;
			this.newSizeWidthComboBox.Location = new System.Drawing.Point(28, 74);
			this.newSizeWidthComboBox.Name = "newSizeWidthComboBox";
			this.newSizeWidthComboBox.Size = new System.Drawing.Size(200, 38);
			this.newSizeWidthComboBox.TabIndex = 1;
			// 
			// createSizeButton
			// 
			this.createSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.createSizeButton.Location = new System.Drawing.Point(528, 52);
			this.createSizeButton.Name = "createSizeButton";
			this.createSizeButton.Size = new System.Drawing.Size(78, 60);
			this.createSizeButton.TabIndex = 11;
			this.createSizeButton.Text = "Create";
			this.createSizeButton.UseVisualStyleBackColor = true;
			// 
			// sizesListBox
			// 
			this.sizesListBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sizesListBox.ForeColor = System.Drawing.Color.DimGray;
			this.sizesListBox.FormattingEnabled = true;
			this.sizesListBox.ItemHeight = 30;
			this.sizesListBox.Location = new System.Drawing.Point(28, 85);
			this.sizesListBox.Name = "sizesListBox";
			this.sizesListBox.Size = new System.Drawing.Size(225, 274);
			this.sizesListBox.TabIndex = 9;
			// 
			// boardsListBox
			// 
			this.boardsListBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardsListBox.ForeColor = System.Drawing.Color.DimGray;
			this.boardsListBox.FormattingEnabled = true;
			this.boardsListBox.ItemHeight = 30;
			this.boardsListBox.Location = new System.Drawing.Point(381, 85);
			this.boardsListBox.Name = "boardsListBox";
			this.boardsListBox.Size = new System.Drawing.Size(225, 274);
			this.boardsListBox.TabIndex = 10;
			// 
			// addSizeButton
			// 
			this.addSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.addSizeButton.Location = new System.Drawing.Point(278, 186);
			this.addSizeButton.Name = "addSizeButton";
			this.addSizeButton.Size = new System.Drawing.Size(78, 60);
			this.addSizeButton.TabIndex = 12;
			this.addSizeButton.Text = "Add";
			this.addSizeButton.UseVisualStyleBackColor = true;
			// 
			// sizeListLabel
			// 
			this.sizeListLabel.AutoSize = true;
			this.sizeListLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sizeListLabel.ForeColor = System.Drawing.Color.DimGray;
			this.sizeListLabel.Location = new System.Drawing.Point(23, 52);
			this.sizeListLabel.Name = "sizeListLabel";
			this.sizeListLabel.Size = new System.Drawing.Size(61, 30);
			this.sizeListLabel.TabIndex = 13;
			this.sizeListLabel.Text = "Sizes:";
			// 
			// boardListLabel
			// 
			this.boardListLabel.AutoSize = true;
			this.boardListLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardListLabel.ForeColor = System.Drawing.Color.DimGray;
			this.boardListLabel.Location = new System.Drawing.Point(376, 52);
			this.boardListLabel.Name = "boardListLabel";
			this.boardListLabel.Size = new System.Drawing.Size(123, 30);
			this.boardListLabel.TabIndex = 14;
			this.boardListLabel.Text = "Board types:";
			// 
			// CreateBoardSizeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(688, 602);
			this.Controls.Add(this.addSizeBox);
			this.Controls.Add(this.newSizeBox);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.MaximizeBox = false;
			this.Name = "CreateBoardSizeForm";
			this.Text = "Add/create board sizes";
			this.newSizeBox.ResumeLayout(false);
			this.newSizeBox.PerformLayout();
			this.addSizeBox.ResumeLayout(false);
			this.addSizeBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox newSizeBox;
		private System.Windows.Forms.ComboBox newSizeHeightComboBox;
		private System.Windows.Forms.Label sizeHeightLabel;
		private System.Windows.Forms.Label sizeWidth;
		private System.Windows.Forms.GroupBox addSizeBox;
		private System.Windows.Forms.ComboBox newSizeWidthComboBox;
		private System.Windows.Forms.Button createSizeButton;
		private System.Windows.Forms.Button addSizeButton;
		private System.Windows.Forms.ListBox boardsListBox;
		private System.Windows.Forms.ListBox sizesListBox;
		private System.Windows.Forms.Label boardListLabel;
		private System.Windows.Forms.Label sizeListLabel;
	}
}