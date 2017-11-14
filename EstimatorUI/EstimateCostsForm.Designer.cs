namespace EstimatorUI
{
	partial class EstimateCostsForm
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
			this.boardBox = new System.Windows.Forms.GroupBox();
			this.boardSizeComboBox = new System.Windows.Forms.ComboBox();
			this.boardSizeLabel = new System.Windows.Forms.Label();
			this.boardTypeComboBox = new System.Windows.Forms.ComboBox();
			this.boardTypeLabel = new System.Windows.Forms.Label();
			this.brushesBox = new System.Windows.Forms.GroupBox();
			this.mediumsBox = new System.Windows.Forms.GroupBox();
			this.paintShapeLabel = new System.Windows.Forms.Label();
			this.brushShapeComboBox = new System.Windows.Forms.ComboBox();
			this.brushMaterialComboBox = new System.Windows.Forms.ComboBox();
			this.brushMaterialLabel = new System.Windows.Forms.Label();
			this.brushSizeComboBox = new System.Windows.Forms.ComboBox();
			this.brushSizeLabel = new System.Windows.Forms.Label();
			this.vernixComboBox = new System.Windows.Forms.ComboBox();
			this.vernixLabel = new System.Windows.Forms.Label();
			this.mediumComboBox = new System.Windows.Forms.ComboBox();
			this.mediumLabel = new System.Windows.Forms.Label();
			this.paintComboBox = new System.Windows.Forms.ComboBox();
			this.paintLabel = new System.Windows.Forms.Label();
			this.newBoardTypeLink = new System.Windows.Forms.LinkLabel();
			this.newBoardSizeLink = new System.Windows.Forms.LinkLabel();
			this.newPaintLink = new System.Windows.Forms.LinkLabel();
			this.newMediumLink = new System.Windows.Forms.LinkLabel();
			this.newVernixLink = new System.Windows.Forms.LinkLabel();
			this.newBrushLink = new System.Windows.Forms.LinkLabel();
			this.costsBox = new System.Windows.Forms.GroupBox();
			this.boardTypeAndSizeLabel = new System.Windows.Forms.Label();
			this.BoardPriceLabel = new System.Windows.Forms.Label();
			this.paintTypeLabel = new System.Windows.Forms.Label();
			this.paintPriceLabel = new System.Windows.Forms.Label();
			this.mediumTypeLabel = new System.Windows.Forms.Label();
			this.mediumPriceLabel = new System.Windows.Forms.Label();
			this.vernixTypeLabel = new System.Windows.Forms.Label();
			this.vernixPriceLabel = new System.Windows.Forms.Label();
			this.brushesListBox = new System.Windows.Forms.ListBox();
			this.brushesPriceLabel = new System.Windows.Forms.Label();
			this.addBrushButton = new System.Windows.Forms.Button();
			this.removeBrushButton = new System.Windows.Forms.Button();
			this.fullCostBox = new System.Windows.Forms.GroupBox();
			this.fullPriceLabel = new System.Windows.Forms.Label();
			this.boardBox.SuspendLayout();
			this.brushesBox.SuspendLayout();
			this.mediumsBox.SuspendLayout();
			this.costsBox.SuspendLayout();
			this.fullCostBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// boardBox
			// 
			this.boardBox.Controls.Add(this.newBoardSizeLink);
			this.boardBox.Controls.Add(this.newBoardTypeLink);
			this.boardBox.Controls.Add(this.boardSizeComboBox);
			this.boardBox.Controls.Add(this.boardSizeLabel);
			this.boardBox.Controls.Add(this.boardTypeComboBox);
			this.boardBox.Controls.Add(this.boardTypeLabel);
			this.boardBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.boardBox.Location = new System.Drawing.Point(24, 27);
			this.boardBox.Name = "boardBox";
			this.boardBox.Size = new System.Drawing.Size(518, 142);
			this.boardBox.TabIndex = 0;
			this.boardBox.TabStop = false;
			this.boardBox.Text = "Board";
			// 
			// boardSizeComboBox
			// 
			this.boardSizeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardSizeComboBox.FormattingEnabled = true;
			this.boardSizeComboBox.Location = new System.Drawing.Point(290, 74);
			this.boardSizeComboBox.Name = "boardSizeComboBox";
			this.boardSizeComboBox.Size = new System.Drawing.Size(200, 38);
			this.boardSizeComboBox.TabIndex = 3;
			// 
			// boardSizeLabel
			// 
			this.boardSizeLabel.AutoSize = true;
			this.boardSizeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardSizeLabel.Location = new System.Drawing.Point(285, 41);
			this.boardSizeLabel.Name = "boardSizeLabel";
			this.boardSizeLabel.Size = new System.Drawing.Size(50, 30);
			this.boardSizeLabel.TabIndex = 2;
			this.boardSizeLabel.Text = "Size";
			// 
			// boardTypeComboBox
			// 
			this.boardTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardTypeComboBox.FormattingEnabled = true;
			this.boardTypeComboBox.Location = new System.Drawing.Point(28, 74);
			this.boardTypeComboBox.Name = "boardTypeComboBox";
			this.boardTypeComboBox.Size = new System.Drawing.Size(200, 38);
			this.boardTypeComboBox.TabIndex = 1;
			// 
			// boardTypeLabel
			// 
			this.boardTypeLabel.AutoSize = true;
			this.boardTypeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardTypeLabel.Location = new System.Drawing.Point(23, 41);
			this.boardTypeLabel.Name = "boardTypeLabel";
			this.boardTypeLabel.Size = new System.Drawing.Size(56, 30);
			this.boardTypeLabel.TabIndex = 0;
			this.boardTypeLabel.Text = "Type";
			// 
			// brushesBox
			// 
			this.brushesBox.Controls.Add(this.newBrushLink);
			this.brushesBox.Controls.Add(this.brushSizeComboBox);
			this.brushesBox.Controls.Add(this.brushSizeLabel);
			this.brushesBox.Controls.Add(this.brushMaterialComboBox);
			this.brushesBox.Controls.Add(this.brushMaterialLabel);
			this.brushesBox.Controls.Add(this.brushShapeComboBox);
			this.brushesBox.Controls.Add(this.paintShapeLabel);
			this.brushesBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushesBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.brushesBox.Location = new System.Drawing.Point(287, 175);
			this.brushesBox.Name = "brushesBox";
			this.brushesBox.Size = new System.Drawing.Size(255, 324);
			this.brushesBox.TabIndex = 1;
			this.brushesBox.TabStop = false;
			this.brushesBox.Text = "Brushes";
			// 
			// mediumsBox
			// 
			this.mediumsBox.Controls.Add(this.newVernixLink);
			this.mediumsBox.Controls.Add(this.newMediumLink);
			this.mediumsBox.Controls.Add(this.newPaintLink);
			this.mediumsBox.Controls.Add(this.vernixComboBox);
			this.mediumsBox.Controls.Add(this.vernixLabel);
			this.mediumsBox.Controls.Add(this.mediumComboBox);
			this.mediumsBox.Controls.Add(this.mediumLabel);
			this.mediumsBox.Controls.Add(this.paintComboBox);
			this.mediumsBox.Controls.Add(this.paintLabel);
			this.mediumsBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mediumsBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.mediumsBox.Location = new System.Drawing.Point(24, 175);
			this.mediumsBox.Name = "mediumsBox";
			this.mediumsBox.Size = new System.Drawing.Size(255, 324);
			this.mediumsBox.TabIndex = 2;
			this.mediumsBox.TabStop = false;
			this.mediumsBox.Text = "Mediums";
			// 
			// paintShapeLabel
			// 
			this.paintShapeLabel.AutoSize = true;
			this.paintShapeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.paintShapeLabel.Location = new System.Drawing.Point(23, 39);
			this.paintShapeLabel.Name = "paintShapeLabel";
			this.paintShapeLabel.Size = new System.Drawing.Size(70, 30);
			this.paintShapeLabel.TabIndex = 1;
			this.paintShapeLabel.Text = "Shape";
			// 
			// brushShapeComboBox
			// 
			this.brushShapeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushShapeComboBox.FormattingEnabled = true;
			this.brushShapeComboBox.Location = new System.Drawing.Point(28, 72);
			this.brushShapeComboBox.Name = "brushShapeComboBox";
			this.brushShapeComboBox.Size = new System.Drawing.Size(200, 38);
			this.brushShapeComboBox.TabIndex = 2;
			// 
			// brushMaterialComboBox
			// 
			this.brushMaterialComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushMaterialComboBox.FormattingEnabled = true;
			this.brushMaterialComboBox.Location = new System.Drawing.Point(28, 157);
			this.brushMaterialComboBox.Name = "brushMaterialComboBox";
			this.brushMaterialComboBox.Size = new System.Drawing.Size(200, 38);
			this.brushMaterialComboBox.TabIndex = 4;
			// 
			// brushMaterialLabel
			// 
			this.brushMaterialLabel.AutoSize = true;
			this.brushMaterialLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushMaterialLabel.Location = new System.Drawing.Point(23, 124);
			this.brushMaterialLabel.Name = "brushMaterialLabel";
			this.brushMaterialLabel.Size = new System.Drawing.Size(89, 30);
			this.brushMaterialLabel.TabIndex = 3;
			this.brushMaterialLabel.Text = "Material";
			// 
			// brushSizeComboBox
			// 
			this.brushSizeComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushSizeComboBox.FormattingEnabled = true;
			this.brushSizeComboBox.Location = new System.Drawing.Point(28, 243);
			this.brushSizeComboBox.Name = "brushSizeComboBox";
			this.brushSizeComboBox.Size = new System.Drawing.Size(200, 38);
			this.brushSizeComboBox.TabIndex = 6;
			// 
			// brushSizeLabel
			// 
			this.brushSizeLabel.AutoSize = true;
			this.brushSizeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushSizeLabel.Location = new System.Drawing.Point(23, 210);
			this.brushSizeLabel.Name = "brushSizeLabel";
			this.brushSizeLabel.Size = new System.Drawing.Size(50, 30);
			this.brushSizeLabel.TabIndex = 5;
			this.brushSizeLabel.Text = "Size";
			// 
			// vernixComboBox
			// 
			this.vernixComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vernixComboBox.FormattingEnabled = true;
			this.vernixComboBox.Location = new System.Drawing.Point(27, 243);
			this.vernixComboBox.Name = "vernixComboBox";
			this.vernixComboBox.Size = new System.Drawing.Size(200, 38);
			this.vernixComboBox.TabIndex = 12;
			// 
			// vernixLabel
			// 
			this.vernixLabel.AutoSize = true;
			this.vernixLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vernixLabel.Location = new System.Drawing.Point(22, 210);
			this.vernixLabel.Name = "vernixLabel";
			this.vernixLabel.Size = new System.Drawing.Size(70, 30);
			this.vernixLabel.TabIndex = 11;
			this.vernixLabel.Text = "Vernix";
			// 
			// mediumComboBox
			// 
			this.mediumComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mediumComboBox.FormattingEnabled = true;
			this.mediumComboBox.Location = new System.Drawing.Point(27, 157);
			this.mediumComboBox.Name = "mediumComboBox";
			this.mediumComboBox.Size = new System.Drawing.Size(200, 38);
			this.mediumComboBox.TabIndex = 10;
			// 
			// mediumLabel
			// 
			this.mediumLabel.AutoSize = true;
			this.mediumLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mediumLabel.Location = new System.Drawing.Point(22, 124);
			this.mediumLabel.Name = "mediumLabel";
			this.mediumLabel.Size = new System.Drawing.Size(83, 30);
			this.mediumLabel.TabIndex = 9;
			this.mediumLabel.Text = "Thinner";
			// 
			// paintComboBox
			// 
			this.paintComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.paintComboBox.FormattingEnabled = true;
			this.paintComboBox.Location = new System.Drawing.Point(27, 72);
			this.paintComboBox.Name = "paintComboBox";
			this.paintComboBox.Size = new System.Drawing.Size(200, 38);
			this.paintComboBox.TabIndex = 8;
			// 
			// paintLabel
			// 
			this.paintLabel.AutoSize = true;
			this.paintLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.paintLabel.Location = new System.Drawing.Point(22, 39);
			this.paintLabel.Name = "paintLabel";
			this.paintLabel.Size = new System.Drawing.Size(59, 30);
			this.paintLabel.TabIndex = 7;
			this.paintLabel.Text = "Paint";
			// 
			// newBoardTypeLink
			// 
			this.newBoardTypeLink.AutoSize = true;
			this.newBoardTypeLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardTypeLink.Location = new System.Drawing.Point(177, 41);
			this.newBoardTypeLink.Name = "newBoardTypeLink";
			this.newBoardTypeLink.Size = new System.Drawing.Size(51, 30);
			this.newBoardTypeLink.TabIndex = 4;
			this.newBoardTypeLink.TabStop = true;
			this.newBoardTypeLink.Text = "new";
			// 
			// newBoardSizeLink
			// 
			this.newBoardSizeLink.AutoSize = true;
			this.newBoardSizeLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBoardSizeLink.Location = new System.Drawing.Point(439, 41);
			this.newBoardSizeLink.Name = "newBoardSizeLink";
			this.newBoardSizeLink.Size = new System.Drawing.Size(51, 30);
			this.newBoardSizeLink.TabIndex = 5;
			this.newBoardSizeLink.TabStop = true;
			this.newBoardSizeLink.Text = "new";
			// 
			// newPaintLink
			// 
			this.newPaintLink.AutoSize = true;
			this.newPaintLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newPaintLink.Location = new System.Drawing.Point(176, 39);
			this.newPaintLink.Name = "newPaintLink";
			this.newPaintLink.Size = new System.Drawing.Size(51, 30);
			this.newPaintLink.TabIndex = 13;
			this.newPaintLink.TabStop = true;
			this.newPaintLink.Text = "new";
			// 
			// newMediumLink
			// 
			this.newMediumLink.AutoSize = true;
			this.newMediumLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newMediumLink.Location = new System.Drawing.Point(176, 124);
			this.newMediumLink.Name = "newMediumLink";
			this.newMediumLink.Size = new System.Drawing.Size(51, 30);
			this.newMediumLink.TabIndex = 14;
			this.newMediumLink.TabStop = true;
			this.newMediumLink.Text = "new";
			// 
			// newVernixLink
			// 
			this.newVernixLink.AutoSize = true;
			this.newVernixLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newVernixLink.Location = new System.Drawing.Point(176, 210);
			this.newVernixLink.Name = "newVernixLink";
			this.newVernixLink.Size = new System.Drawing.Size(51, 30);
			this.newVernixLink.TabIndex = 15;
			this.newVernixLink.TabStop = true;
			this.newVernixLink.Text = "new";
			// 
			// newBrushLink
			// 
			this.newBrushLink.AutoSize = true;
			this.newBrushLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.newBrushLink.Location = new System.Drawing.Point(177, 0);
			this.newBrushLink.Name = "newBrushLink";
			this.newBrushLink.Size = new System.Drawing.Size(51, 30);
			this.newBrushLink.TabIndex = 6;
			this.newBrushLink.TabStop = true;
			this.newBrushLink.Text = "new";
			// 
			// costsBox
			// 
			this.costsBox.Controls.Add(this.removeBrushButton);
			this.costsBox.Controls.Add(this.addBrushButton);
			this.costsBox.Controls.Add(this.brushesPriceLabel);
			this.costsBox.Controls.Add(this.brushesListBox);
			this.costsBox.Controls.Add(this.vernixPriceLabel);
			this.costsBox.Controls.Add(this.vernixTypeLabel);
			this.costsBox.Controls.Add(this.mediumPriceLabel);
			this.costsBox.Controls.Add(this.mediumTypeLabel);
			this.costsBox.Controls.Add(this.paintPriceLabel);
			this.costsBox.Controls.Add(this.paintTypeLabel);
			this.costsBox.Controls.Add(this.BoardPriceLabel);
			this.costsBox.Controls.Add(this.boardTypeAndSizeLabel);
			this.costsBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.costsBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.costsBox.Location = new System.Drawing.Point(557, 27);
			this.costsBox.Name = "costsBox";
			this.costsBox.Size = new System.Drawing.Size(374, 388);
			this.costsBox.TabIndex = 3;
			this.costsBox.TabStop = false;
			this.costsBox.Text = "Costs of materials";
			// 
			// boardTypeAndSizeLabel
			// 
			this.boardTypeAndSizeLabel.AutoSize = true;
			this.boardTypeAndSizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.boardTypeAndSizeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.boardTypeAndSizeLabel.Location = new System.Drawing.Point(22, 41);
			this.boardTypeAndSizeLabel.Name = "boardTypeAndSizeLabel";
			this.boardTypeAndSizeLabel.Size = new System.Drawing.Size(216, 30);
			this.boardTypeAndSizeLabel.TabIndex = 0;
			this.boardTypeAndSizeLabel.Text = "<Board type and size>";
			// 
			// BoardPriceLabel
			// 
			this.BoardPriceLabel.AutoSize = true;
			this.BoardPriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.BoardPriceLabel.ForeColor = System.Drawing.Color.DimGray;
			this.BoardPriceLabel.Location = new System.Drawing.Point(270, 41);
			this.BoardPriceLabel.Name = "BoardPriceLabel";
			this.BoardPriceLabel.Size = new System.Drawing.Size(83, 30);
			this.BoardPriceLabel.TabIndex = 1;
			this.BoardPriceLabel.Text = "<Price>";
			// 
			// paintTypeLabel
			// 
			this.paintTypeLabel.AutoSize = true;
			this.paintTypeLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.paintTypeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.paintTypeLabel.Location = new System.Drawing.Point(22, 76);
			this.paintTypeLabel.Name = "paintTypeLabel";
			this.paintTypeLabel.Size = new System.Drawing.Size(127, 30);
			this.paintTypeLabel.TabIndex = 2;
			this.paintTypeLabel.Text = "<Paint type>";
			// 
			// paintPriceLabel
			// 
			this.paintPriceLabel.AutoSize = true;
			this.paintPriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.paintPriceLabel.ForeColor = System.Drawing.Color.DimGray;
			this.paintPriceLabel.Location = new System.Drawing.Point(270, 76);
			this.paintPriceLabel.Name = "paintPriceLabel";
			this.paintPriceLabel.Size = new System.Drawing.Size(83, 30);
			this.paintPriceLabel.TabIndex = 3;
			this.paintPriceLabel.Text = "<Price>";
			// 
			// mediumTypeLabel
			// 
			this.mediumTypeLabel.AutoSize = true;
			this.mediumTypeLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mediumTypeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.mediumTypeLabel.Location = new System.Drawing.Point(22, 111);
			this.mediumTypeLabel.Name = "mediumTypeLabel";
			this.mediumTypeLabel.Size = new System.Drawing.Size(152, 30);
			this.mediumTypeLabel.TabIndex = 4;
			this.mediumTypeLabel.Text = "<Thinner type>";
			// 
			// mediumPriceLabel
			// 
			this.mediumPriceLabel.AutoSize = true;
			this.mediumPriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mediumPriceLabel.ForeColor = System.Drawing.Color.DimGray;
			this.mediumPriceLabel.Location = new System.Drawing.Point(270, 112);
			this.mediumPriceLabel.Name = "mediumPriceLabel";
			this.mediumPriceLabel.Size = new System.Drawing.Size(83, 30);
			this.mediumPriceLabel.TabIndex = 5;
			this.mediumPriceLabel.Text = "<Price>";
			// 
			// vernixTypeLabel
			// 
			this.vernixTypeLabel.AutoSize = true;
			this.vernixTypeLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vernixTypeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.vernixTypeLabel.Location = new System.Drawing.Point(22, 146);
			this.vernixTypeLabel.Name = "vernixTypeLabel";
			this.vernixTypeLabel.Size = new System.Drawing.Size(139, 30);
			this.vernixTypeLabel.TabIndex = 6;
			this.vernixTypeLabel.Text = "<Vernix type>";
			// 
			// vernixPriceLabel
			// 
			this.vernixPriceLabel.AutoSize = true;
			this.vernixPriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vernixPriceLabel.ForeColor = System.Drawing.Color.DimGray;
			this.vernixPriceLabel.Location = new System.Drawing.Point(270, 146);
			this.vernixPriceLabel.Name = "vernixPriceLabel";
			this.vernixPriceLabel.Size = new System.Drawing.Size(83, 30);
			this.vernixPriceLabel.TabIndex = 7;
			this.vernixPriceLabel.Text = "<Price>";
			// 
			// brushesListBox
			// 
			this.brushesListBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushesListBox.ForeColor = System.Drawing.Color.DimGray;
			this.brushesListBox.FormattingEnabled = true;
			this.brushesListBox.ItemHeight = 30;
			this.brushesListBox.Location = new System.Drawing.Point(27, 184);
			this.brushesListBox.Name = "brushesListBox";
			this.brushesListBox.Size = new System.Drawing.Size(225, 184);
			this.brushesListBox.TabIndex = 8;
			// 
			// brushesPriceLabel
			// 
			this.brushesPriceLabel.AutoSize = true;
			this.brushesPriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.brushesPriceLabel.ForeColor = System.Drawing.Color.DimGray;
			this.brushesPriceLabel.Location = new System.Drawing.Point(270, 343);
			this.brushesPriceLabel.Name = "brushesPriceLabel";
			this.brushesPriceLabel.Size = new System.Drawing.Size(83, 30);
			this.brushesPriceLabel.TabIndex = 9;
			this.brushesPriceLabel.Text = "<Price>";
			// 
			// addBrushButton
			// 
			this.addBrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBrushButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.addBrushButton.Location = new System.Drawing.Point(275, 214);
			this.addBrushButton.Name = "addBrushButton";
			this.addBrushButton.Size = new System.Drawing.Size(78, 60);
			this.addBrushButton.TabIndex = 10;
			this.addBrushButton.Text = "Add";
			this.addBrushButton.UseVisualStyleBackColor = true;
			// 
			// removeBrushButton
			// 
			this.removeBrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeBrushButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.removeBrushButton.Location = new System.Drawing.Point(275, 280);
			this.removeBrushButton.Name = "removeBrushButton";
			this.removeBrushButton.Size = new System.Drawing.Size(78, 60);
			this.removeBrushButton.TabIndex = 11;
			this.removeBrushButton.Text = "Remove selected";
			this.removeBrushButton.UseVisualStyleBackColor = true;
			// 
			// fullCostBox
			// 
			this.fullCostBox.Controls.Add(this.fullPriceLabel);
			this.fullCostBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fullCostBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.fullCostBox.Location = new System.Drawing.Point(557, 421);
			this.fullCostBox.Name = "fullCostBox";
			this.fullCostBox.Size = new System.Drawing.Size(374, 78);
			this.fullCostBox.TabIndex = 4;
			this.fullCostBox.TabStop = false;
			this.fullCostBox.Text = "Full Cost";
			// 
			// fullPriceLabel
			// 
			this.fullPriceLabel.AutoSize = true;
			this.fullPriceLabel.ForeColor = System.Drawing.Color.Black;
			this.fullPriceLabel.Location = new System.Drawing.Point(208, 28);
			this.fullPriceLabel.Name = "fullPriceLabel";
			this.fullPriceLabel.Size = new System.Drawing.Size(160, 37);
			this.fullPriceLabel.TabIndex = 0;
			this.fullPriceLabel.Text = "<Full price>";
			// 
			// EstimateCostsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(967, 533);
			this.Controls.Add(this.fullCostBox);
			this.Controls.Add(this.costsBox);
			this.Controls.Add(this.mediumsBox);
			this.Controls.Add(this.brushesBox);
			this.Controls.Add(this.boardBox);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "EstimateCostsForm";
			this.Text = "Painting Costs Estimator";
			this.boardBox.ResumeLayout(false);
			this.boardBox.PerformLayout();
			this.brushesBox.ResumeLayout(false);
			this.brushesBox.PerformLayout();
			this.mediumsBox.ResumeLayout(false);
			this.mediumsBox.PerformLayout();
			this.costsBox.ResumeLayout(false);
			this.costsBox.PerformLayout();
			this.fullCostBox.ResumeLayout(false);
			this.fullCostBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox boardBox;
		private System.Windows.Forms.ComboBox boardSizeComboBox;
		private System.Windows.Forms.Label boardSizeLabel;
		private System.Windows.Forms.ComboBox boardTypeComboBox;
		private System.Windows.Forms.Label boardTypeLabel;
		private System.Windows.Forms.GroupBox brushesBox;
		private System.Windows.Forms.ComboBox brushSizeComboBox;
		private System.Windows.Forms.Label brushSizeLabel;
		private System.Windows.Forms.ComboBox brushMaterialComboBox;
		private System.Windows.Forms.Label brushMaterialLabel;
		private System.Windows.Forms.ComboBox brushShapeComboBox;
		private System.Windows.Forms.Label paintShapeLabel;
		private System.Windows.Forms.GroupBox mediumsBox;
		private System.Windows.Forms.ComboBox vernixComboBox;
		private System.Windows.Forms.Label vernixLabel;
		private System.Windows.Forms.ComboBox mediumComboBox;
		private System.Windows.Forms.Label mediumLabel;
		private System.Windows.Forms.ComboBox paintComboBox;
		private System.Windows.Forms.Label paintLabel;
		private System.Windows.Forms.LinkLabel newBoardSizeLink;
		private System.Windows.Forms.LinkLabel newBoardTypeLink;
		private System.Windows.Forms.LinkLabel newBrushLink;
		private System.Windows.Forms.LinkLabel newVernixLink;
		private System.Windows.Forms.LinkLabel newMediumLink;
		private System.Windows.Forms.LinkLabel newPaintLink;
		private System.Windows.Forms.GroupBox costsBox;
		private System.Windows.Forms.Button removeBrushButton;
		private System.Windows.Forms.Button addBrushButton;
		private System.Windows.Forms.Label brushesPriceLabel;
		private System.Windows.Forms.ListBox brushesListBox;
		private System.Windows.Forms.Label vernixPriceLabel;
		private System.Windows.Forms.Label vernixTypeLabel;
		private System.Windows.Forms.Label mediumPriceLabel;
		private System.Windows.Forms.Label mediumTypeLabel;
		private System.Windows.Forms.Label paintPriceLabel;
		private System.Windows.Forms.Label paintTypeLabel;
		private System.Windows.Forms.Label BoardPriceLabel;
		private System.Windows.Forms.Label boardTypeAndSizeLabel;
		private System.Windows.Forms.GroupBox fullCostBox;
		private System.Windows.Forms.Label fullPriceLabel;
	}
}

