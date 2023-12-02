namespace MatrixMath
{
    partial class UxMatrixMath
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxALoad = new Button();
            uxAShow = new Button();
            uxBLoad = new Button();
            uxBShow = new Button();
            uxSwap = new Button();
            uxAdd = new Button();
            uxSubtract = new Button();
            uxMultiply = new Button();
            uxALabel = new Label();
            uxOpenFile = new OpenFileDialog();
            uxBLabel = new Label();
            uxATranspose = new Button();
            SuspendLayout();
            // 
            // uxALoad
            // 
            uxALoad.Location = new Point(71, 70);
            uxALoad.Margin = new Padding(3, 2, 3, 2);
            uxALoad.Name = "uxALoad";
            uxALoad.Size = new Size(82, 22);
            uxALoad.TabIndex = 0;
            uxALoad.Text = "Load A";
            uxALoad.UseVisualStyleBackColor = true;
            uxALoad.Click += ALoad_Click;
            // 
            // uxAShow
            // 
            uxAShow.Enabled = false;
            uxAShow.Location = new Point(248, 67);
            uxAShow.Margin = new Padding(3, 2, 3, 2);
            uxAShow.Name = "uxAShow";
            uxAShow.Size = new Size(82, 22);
            uxAShow.TabIndex = 1;
            uxAShow.Text = "Show A";
            uxAShow.UseVisualStyleBackColor = true;
            uxAShow.Click += AShow_Click;
            // 
            // uxBLoad
            // 
            uxBLoad.Location = new Point(71, 109);
            uxBLoad.Margin = new Padding(3, 2, 3, 2);
            uxBLoad.Name = "uxBLoad";
            uxBLoad.Size = new Size(82, 22);
            uxBLoad.TabIndex = 2;
            uxBLoad.Text = "Load B";
            uxBLoad.UseVisualStyleBackColor = true;
            uxBLoad.Click += BLoad_Click;
            // 
            // uxBShow
            // 
            uxBShow.Enabled = false;
            uxBShow.Location = new Point(248, 110);
            uxBShow.Margin = new Padding(3, 2, 3, 2);
            uxBShow.Name = "uxBShow";
            uxBShow.Size = new Size(82, 22);
            uxBShow.TabIndex = 3;
            uxBShow.Text = "Show B";
            uxBShow.UseVisualStyleBackColor = true;
            uxBShow.Click += BShow_Click;
            // 
            // uxSwap
            // 
            uxSwap.Location = new Point(399, 70);
            uxSwap.Margin = new Padding(3, 2, 3, 2);
            uxSwap.Name = "uxSwap";
            uxSwap.Size = new Size(102, 22);
            uxSwap.TabIndex = 4;
            uxSwap.Text = "Swap A<->B";
            uxSwap.UseVisualStyleBackColor = true;
            uxSwap.Click += Swap_Click;
            // 
            // uxAdd
            // 
            uxAdd.Enabled = false;
            uxAdd.Location = new Point(71, 160);
            uxAdd.Margin = new Padding(3, 2, 3, 2);
            uxAdd.Name = "uxAdd";
            uxAdd.Size = new Size(82, 22);
            uxAdd.TabIndex = 5;
            uxAdd.Text = "A + B";
            uxAdd.UseVisualStyleBackColor = true;
            uxAdd.Click += Add_Click;
            // 
            // uxSubtract
            // 
            uxSubtract.Enabled = false;
            uxSubtract.Location = new Point(248, 160);
            uxSubtract.Margin = new Padding(3, 2, 3, 2);
            uxSubtract.Name = "uxSubtract";
            uxSubtract.Size = new Size(82, 22);
            uxSubtract.TabIndex = 6;
            uxSubtract.Text = "A - B";
            uxSubtract.UseVisualStyleBackColor = true;
            uxSubtract.Click += Subtract_Click;
            // 
            // uxMultiply
            // 
            uxMultiply.Enabled = false;
            uxMultiply.Location = new Point(399, 160);
            uxMultiply.Margin = new Padding(3, 2, 3, 2);
            uxMultiply.Name = "uxMultiply";
            uxMultiply.Size = new Size(82, 22);
            uxMultiply.TabIndex = 7;
            uxMultiply.Text = "A * B";
            uxMultiply.UseVisualStyleBackColor = true;
            uxMultiply.Click += Multiply_Click;
            // 
            // uxALabel
            // 
            uxALabel.AutoSize = true;
            uxALabel.Location = new Point(176, 70);
            uxALabel.Name = "uxALabel";
            uxALabel.Size = new Size(31, 15);
            uxALabel.TabIndex = 8;
            uxALabel.Text = "0 x 0";
            // 
            // uxOpenFile
            // 
            uxOpenFile.FileName = "openFileDialog1";
            // 
            // uxBLabel
            // 
            uxBLabel.AutoSize = true;
            uxBLabel.Location = new Point(174, 113);
            uxBLabel.Name = "uxBLabel";
            uxBLabel.Size = new Size(31, 15);
            uxBLabel.TabIndex = 9;
            uxBLabel.Text = "0 x 0";
            // 
            // uxATranspose
            // 
            uxATranspose.Enabled = false;
            uxATranspose.Location = new Point(399, 113);
            uxATranspose.Margin = new Padding(3, 2, 3, 2);
            uxATranspose.Name = "uxATranspose";
            uxATranspose.Size = new Size(102, 22);
            uxATranspose.TabIndex = 10;
            uxATranspose.Text = "A Transpose";
            uxATranspose.UseVisualStyleBackColor = true;
            uxATranspose.Click += ATranspose_Click;
            // 
            // UxMatrixMath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 297);
            Controls.Add(uxATranspose);
            Controls.Add(uxBLabel);
            Controls.Add(uxALabel);
            Controls.Add(uxMultiply);
            Controls.Add(uxSubtract);
            Controls.Add(uxAdd);
            Controls.Add(uxSwap);
            Controls.Add(uxBShow);
            Controls.Add(uxBLoad);
            Controls.Add(uxAShow);
            Controls.Add(uxALoad);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UxMatrixMath";
            Text = "MatrixMath";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxALoad;
        private Button uxAShow;
        private Button uxBLoad;
        private Button uxBShow;
        private Button uxSwap;
        private Button uxAdd;
        private Button uxSubtract;
        private Button uxMultiply;
        private Label uxALabel;
        private OpenFileDialog uxOpenFile;
        private Label uxBLabel;
        private Button uxATranspose;
    }
}