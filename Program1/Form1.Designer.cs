
namespace Program1
{
    partial class Program1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.frontLengthLabel = new System.Windows.Forms.Label();
            this.sideLengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.windowPromptLabel = new System.Windows.Forms.Label();
            this.dryWallCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalSqFeetLabel = new System.Windows.Forms.Label();
            this.tenPercentExtraLabel = new System.Windows.Forms.Label();
            this.totalLaborCostLabel = new System.Windows.Forms.Label();
            this.totalMaterialCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.frontLengthInput = new System.Windows.Forms.TextBox();
            this.sideLengthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.windowInput = new System.Windows.Forms.TextBox();
            this.dryWallCostInput = new System.Windows.Forms.TextBox();
            this.laborCostInput = new System.Windows.Forms.TextBox();
            this.totalSqFeetOutput = new System.Windows.Forms.Label();
            this.tenPercentExtraOutput = new System.Windows.Forms.Label();
            this.totalLaborCostOutput = new System.Windows.Forms.Label();
            this.totalMaterialCostOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.calculateEstimateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(68, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(184, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dry Wall and Window Cost Calculator";
            // 
            // frontLengthLabel
            // 
            this.frontLengthLabel.AutoSize = true;
            this.frontLengthLabel.Location = new System.Drawing.Point(76, 51);
            this.frontLengthLabel.Name = "frontLengthLabel";
            this.frontLengthLabel.Size = new System.Drawing.Size(97, 13);
            this.frontLengthLabel.TabIndex = 1;
            this.frontLengthLabel.Text = "Length of Front (ft):";
            // 
            // sideLengthLabel
            // 
            this.sideLengthLabel.AutoSize = true;
            this.sideLengthLabel.Location = new System.Drawing.Point(79, 77);
            this.sideLengthLabel.Name = "sideLengthLabel";
            this.sideLengthLabel.Size = new System.Drawing.Size(94, 13);
            this.sideLengthLabel.TabIndex = 2;
            this.sideLengthLabel.Text = "Length of Side (ft):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(117, 103);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height (ft):";
            // 
            // windowPromptLabel
            // 
            this.windowPromptLabel.AutoSize = true;
            this.windowPromptLabel.Location = new System.Drawing.Point(33, 143);
            this.windowPromptLabel.Name = "windowPromptLabel";
            this.windowPromptLabel.Size = new System.Drawing.Size(140, 13);
            this.windowPromptLabel.TabIndex = 4;
            this.windowPromptLabel.Text = "Window? (1 = YES, 0 = NO)";
            // 
            // dryWallCostLabel
            // 
            this.dryWallCostLabel.AutoSize = true;
            this.dryWallCostLabel.Location = new System.Drawing.Point(26, 186);
            this.dryWallCostLabel.Name = "dryWallCostLabel";
            this.dryWallCostLabel.Size = new System.Drawing.Size(147, 13);
            this.dryWallCostLabel.TabIndex = 5;
            this.dryWallCostLabel.Text = "Cost of Dry Wall Per SQ Foot:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(39, 212);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(134, 13);
            this.laborCostLabel.TabIndex = 6;
            this.laborCostLabel.Text = "Cost of Labor Per SQ Foot:";
            // 
            // totalSqFeetLabel
            // 
            this.totalSqFeetLabel.AutoSize = true;
            this.totalSqFeetLabel.Location = new System.Drawing.Point(61, 273);
            this.totalSqFeetLabel.Name = "totalSqFeetLabel";
            this.totalSqFeetLabel.Size = new System.Drawing.Size(112, 13);
            this.totalSqFeetLabel.TabIndex = 7;
            this.totalSqFeetLabel.Text = "Total SQ feet needed:";
            // 
            // tenPercentExtraLabel
            // 
            this.tenPercentExtraLabel.AutoSize = true;
            this.tenPercentExtraLabel.Location = new System.Drawing.Point(116, 300);
            this.tenPercentExtraLabel.Name = "tenPercentExtraLabel";
            this.tenPercentExtraLabel.Size = new System.Drawing.Size(57, 13);
            this.tenPercentExtraLabel.TabIndex = 8;
            this.tenPercentExtraLabel.Text = "10% Extra:";
            // 
            // totalLaborCostLabel
            // 
            this.totalLaborCostLabel.AutoSize = true;
            this.totalLaborCostLabel.Location = new System.Drawing.Point(112, 327);
            this.totalLaborCostLabel.Name = "totalLaborCostLabel";
            this.totalLaborCostLabel.Size = new System.Drawing.Size(61, 13);
            this.totalLaborCostLabel.TabIndex = 9;
            this.totalLaborCostLabel.Text = "Labor Cost:";
            // 
            // totalMaterialCostLabel
            // 
            this.totalMaterialCostLabel.AutoSize = true;
            this.totalMaterialCostLabel.Location = new System.Drawing.Point(102, 354);
            this.totalMaterialCostLabel.Name = "totalMaterialCostLabel";
            this.totalMaterialCostLabel.Size = new System.Drawing.Size(71, 13);
            this.totalMaterialCostLabel.TabIndex = 10;
            this.totalMaterialCostLabel.Text = "Material Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(104, 380);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(69, 13);
            this.totalCostLabel.TabIndex = 11;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // frontLengthInput
            // 
            this.frontLengthInput.Location = new System.Drawing.Point(179, 48);
            this.frontLengthInput.Name = "frontLengthInput";
            this.frontLengthInput.Size = new System.Drawing.Size(100, 20);
            this.frontLengthInput.TabIndex = 12;
            // 
            // sideLengthInput
            // 
            this.sideLengthInput.Location = new System.Drawing.Point(179, 74);
            this.sideLengthInput.Name = "sideLengthInput";
            this.sideLengthInput.Size = new System.Drawing.Size(100, 20);
            this.sideLengthInput.TabIndex = 13;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(179, 100);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 14;
            // 
            // windowInput
            // 
            this.windowInput.Location = new System.Drawing.Point(179, 140);
            this.windowInput.Name = "windowInput";
            this.windowInput.Size = new System.Drawing.Size(100, 20);
            this.windowInput.TabIndex = 15;
            // 
            // dryWallCostInput
            // 
            this.dryWallCostInput.Location = new System.Drawing.Point(179, 183);
            this.dryWallCostInput.Name = "dryWallCostInput";
            this.dryWallCostInput.Size = new System.Drawing.Size(100, 20);
            this.dryWallCostInput.TabIndex = 16;
            // 
            // laborCostInput
            // 
            this.laborCostInput.Location = new System.Drawing.Point(179, 209);
            this.laborCostInput.Name = "laborCostInput";
            this.laborCostInput.Size = new System.Drawing.Size(100, 20);
            this.laborCostInput.TabIndex = 17;
            // 
            // totalSqFeetOutput
            // 
            this.totalSqFeetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFeetOutput.Location = new System.Drawing.Point(179, 269);
            this.totalSqFeetOutput.Name = "totalSqFeetOutput";
            this.totalSqFeetOutput.Size = new System.Drawing.Size(100, 20);
            this.totalSqFeetOutput.TabIndex = 18;
            this.totalSqFeetOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenPercentExtraOutput
            // 
            this.tenPercentExtraOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenPercentExtraOutput.Location = new System.Drawing.Point(179, 296);
            this.tenPercentExtraOutput.Name = "tenPercentExtraOutput";
            this.tenPercentExtraOutput.Size = new System.Drawing.Size(100, 20);
            this.tenPercentExtraOutput.TabIndex = 19;
            this.tenPercentExtraOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLaborCostOutput
            // 
            this.totalLaborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborCostOutput.Location = new System.Drawing.Point(179, 323);
            this.totalLaborCostOutput.Name = "totalLaborCostOutput";
            this.totalLaborCostOutput.Size = new System.Drawing.Size(100, 20);
            this.totalLaborCostOutput.TabIndex = 20;
            this.totalLaborCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalMaterialCostOutput
            // 
            this.totalMaterialCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMaterialCostOutput.Location = new System.Drawing.Point(179, 350);
            this.totalMaterialCostOutput.Name = "totalMaterialCostOutput";
            this.totalMaterialCostOutput.Size = new System.Drawing.Size(100, 20);
            this.totalMaterialCostOutput.TabIndex = 21;
            this.totalMaterialCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutput.Location = new System.Drawing.Point(179, 376);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 20);
            this.totalCostOutput.TabIndex = 22;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculateEstimateButton
            // 
            this.calculateEstimateButton.Location = new System.Drawing.Point(93, 415);
            this.calculateEstimateButton.Name = "calculateEstimateButton";
            this.calculateEstimateButton.Size = new System.Drawing.Size(150, 23);
            this.calculateEstimateButton.TabIndex = 23;
            this.calculateEstimateButton.Text = "Calculate Estimate";
            this.calculateEstimateButton.UseVisualStyleBackColor = true;
            this.calculateEstimateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.calculateEstimateButton);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.totalMaterialCostOutput);
            this.Controls.Add(this.totalLaborCostOutput);
            this.Controls.Add(this.tenPercentExtraOutput);
            this.Controls.Add(this.totalSqFeetOutput);
            this.Controls.Add(this.laborCostInput);
            this.Controls.Add(this.dryWallCostInput);
            this.Controls.Add(this.windowInput);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.sideLengthInput);
            this.Controls.Add(this.frontLengthInput);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalMaterialCostLabel);
            this.Controls.Add(this.totalLaborCostLabel);
            this.Controls.Add(this.tenPercentExtraLabel);
            this.Controls.Add(this.totalSqFeetLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.dryWallCostLabel);
            this.Controls.Add(this.windowPromptLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.sideLengthLabel);
            this.Controls.Add(this.frontLengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label frontLengthLabel;
        private System.Windows.Forms.Label sideLengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label windowPromptLabel;
        private System.Windows.Forms.Label dryWallCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalSqFeetLabel;
        private System.Windows.Forms.Label tenPercentExtraLabel;
        private System.Windows.Forms.Label totalLaborCostLabel;
        private System.Windows.Forms.Label totalMaterialCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox frontLengthInput;
        private System.Windows.Forms.TextBox sideLengthInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox windowInput;
        private System.Windows.Forms.TextBox dryWallCostInput;
        private System.Windows.Forms.TextBox laborCostInput;
        private System.Windows.Forms.Label totalSqFeetOutput;
        private System.Windows.Forms.Label tenPercentExtraOutput;
        private System.Windows.Forms.Label totalLaborCostOutput;
        private System.Windows.Forms.Label totalMaterialCostOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Button calculateEstimateButton;
    }
}

