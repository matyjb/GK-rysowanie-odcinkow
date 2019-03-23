namespace GK_rysowanie_odcinków
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.bUp = new System.Windows.Forms.Button();
            this.gBoxMove = new System.Windows.Forms.GroupBox();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.nX = new System.Windows.Forms.NumericUpDown();
            this.nY = new System.Windows.Forms.NumericUpDown();
            this.bUpRight = new System.Windows.Forms.Button();
            this.bDownRight = new System.Windows.Forms.Button();
            this.bDownLeft = new System.Windows.Forms.Button();
            this.bUpLeft = new System.Windows.Forms.Button();
            this.gBoxScale = new System.Windows.Forms.GroupBox();
            this.nScaleY = new System.Windows.Forms.NumericUpDown();
            this.lY = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.nScaleX = new System.Windows.Forms.NumericUpDown();
            this.bScale = new System.Windows.Forms.Button();
            this.gBoxRotation = new System.Windows.Forms.GroupBox();
            this.bRotate = new System.Windows.Forms.Button();
            this.lFi = new System.Windows.Forms.Label();
            this.nAngle = new System.Windows.Forms.NumericUpDown();
            this.gBoxMethod = new System.Windows.Forms.GroupBox();
            this.rPrzyrostowy = new System.Windows.Forms.RadioButton();
            this.bClearCanvas = new System.Windows.Forms.Button();
            this.gBoxMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).BeginInit();
            this.gBoxScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleX)).BeginInit();
            this.gBoxRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).BeginInit();
            this.gBoxMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(555, 470);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(76, 19);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(50, 50);
            this.bUp.TabIndex = 1;
            this.bUp.Text = "up";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // gBoxMove
            // 
            this.gBoxMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxMove.Controls.Add(this.bUpLeft);
            this.gBoxMove.Controls.Add(this.bDownLeft);
            this.gBoxMove.Controls.Add(this.bDownRight);
            this.gBoxMove.Controls.Add(this.bUpRight);
            this.gBoxMove.Controls.Add(this.nY);
            this.gBoxMove.Controls.Add(this.nX);
            this.gBoxMove.Controls.Add(this.bDown);
            this.gBoxMove.Controls.Add(this.bLeft);
            this.gBoxMove.Controls.Add(this.bRight);
            this.gBoxMove.Controls.Add(this.bUp);
            this.gBoxMove.Location = new System.Drawing.Point(588, 13);
            this.gBoxMove.Name = "gBoxMove";
            this.gBoxMove.Size = new System.Drawing.Size(200, 198);
            this.gBoxMove.TabIndex = 2;
            this.gBoxMove.TabStop = false;
            this.gBoxMove.Text = "Przemieszczanie";
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(131, 75);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(50, 50);
            this.bRight.TabIndex = 3;
            this.bRight.Text = "right";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(20, 75);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(50, 50);
            this.bLeft.TabIndex = 4;
            this.bLeft.Text = "left";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bDown
            // 
            this.bDown.Location = new System.Drawing.Point(76, 131);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(50, 50);
            this.bDown.TabIndex = 5;
            this.bDown.Text = "down";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // nX
            // 
            this.nX.Location = new System.Drawing.Point(77, 76);
            this.nX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nX.Name = "nX";
            this.nX.Size = new System.Drawing.Size(48, 20);
            this.nX.TabIndex = 6;
            this.nX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nY
            // 
            this.nY.Location = new System.Drawing.Point(77, 105);
            this.nY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nY.Name = "nY";
            this.nY.Size = new System.Drawing.Size(48, 20);
            this.nY.TabIndex = 7;
            this.nY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bUpRight
            // 
            this.bUpRight.Location = new System.Drawing.Point(131, 28);
            this.bUpRight.Name = "bUpRight";
            this.bUpRight.Size = new System.Drawing.Size(41, 41);
            this.bUpRight.TabIndex = 8;
            this.bUpRight.Text = "up right";
            this.bUpRight.UseVisualStyleBackColor = true;
            this.bUpRight.Click += new System.EventHandler(this.bUpRight_Click);
            // 
            // bDownRight
            // 
            this.bDownRight.Location = new System.Drawing.Point(131, 131);
            this.bDownRight.Name = "bDownRight";
            this.bDownRight.Size = new System.Drawing.Size(41, 41);
            this.bDownRight.TabIndex = 9;
            this.bDownRight.Text = "down right";
            this.bDownRight.UseVisualStyleBackColor = true;
            this.bDownRight.Click += new System.EventHandler(this.bDownRight_Click);
            // 
            // bDownLeft
            // 
            this.bDownLeft.Location = new System.Drawing.Point(29, 131);
            this.bDownLeft.Name = "bDownLeft";
            this.bDownLeft.Size = new System.Drawing.Size(41, 41);
            this.bDownLeft.TabIndex = 10;
            this.bDownLeft.Text = "down left";
            this.bDownLeft.UseVisualStyleBackColor = true;
            this.bDownLeft.Click += new System.EventHandler(this.bDownLeft_Click);
            // 
            // bUpLeft
            // 
            this.bUpLeft.Location = new System.Drawing.Point(29, 28);
            this.bUpLeft.Name = "bUpLeft";
            this.bUpLeft.Size = new System.Drawing.Size(41, 41);
            this.bUpLeft.TabIndex = 11;
            this.bUpLeft.Text = "up left";
            this.bUpLeft.UseVisualStyleBackColor = true;
            this.bUpLeft.Click += new System.EventHandler(this.bUpLeft_Click);
            // 
            // gBoxScale
            // 
            this.gBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxScale.Controls.Add(this.bScale);
            this.gBoxScale.Controls.Add(this.lX);
            this.gBoxScale.Controls.Add(this.nScaleX);
            this.gBoxScale.Controls.Add(this.lY);
            this.gBoxScale.Controls.Add(this.nScaleY);
            this.gBoxScale.Location = new System.Drawing.Point(588, 217);
            this.gBoxScale.Name = "gBoxScale";
            this.gBoxScale.Size = new System.Drawing.Size(200, 85);
            this.gBoxScale.TabIndex = 3;
            this.gBoxScale.TabStop = false;
            this.gBoxScale.Text = "Skalowanie";
            // 
            // nScaleY
            // 
            this.nScaleY.DecimalPlaces = 4;
            this.nScaleY.Location = new System.Drawing.Point(118, 20);
            this.nScaleY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nScaleY.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nScaleY.Name = "nScaleY";
            this.nScaleY.Size = new System.Drawing.Size(76, 20);
            this.nScaleY.TabIndex = 0;
            this.nScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(102, 22);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(12, 13);
            this.lY.TabIndex = 1;
            this.lY.Text = "y";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(6, 22);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(12, 13);
            this.lX.TabIndex = 3;
            this.lX.Text = "x";
            // 
            // nScaleX
            // 
            this.nScaleX.DecimalPlaces = 4;
            this.nScaleX.Location = new System.Drawing.Point(20, 20);
            this.nScaleX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nScaleX.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nScaleX.Name = "nScaleX";
            this.nScaleX.Size = new System.Drawing.Size(76, 20);
            this.nScaleX.TabIndex = 2;
            this.nScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bScale
            // 
            this.bScale.Location = new System.Drawing.Point(6, 47);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(188, 31);
            this.bScale.TabIndex = 4;
            this.bScale.Text = "Skaluj";
            this.bScale.UseVisualStyleBackColor = true;
            this.bScale.Click += new System.EventHandler(this.bScale_Click);
            // 
            // gBoxRotation
            // 
            this.gBoxRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxRotation.Controls.Add(this.bRotate);
            this.gBoxRotation.Controls.Add(this.lFi);
            this.gBoxRotation.Controls.Add(this.nAngle);
            this.gBoxRotation.Location = new System.Drawing.Point(588, 308);
            this.gBoxRotation.Name = "gBoxRotation";
            this.gBoxRotation.Size = new System.Drawing.Size(200, 85);
            this.gBoxRotation.TabIndex = 5;
            this.gBoxRotation.TabStop = false;
            this.gBoxRotation.Text = "Obracanie";
            // 
            // bRotate
            // 
            this.bRotate.Location = new System.Drawing.Point(6, 47);
            this.bRotate.Name = "bRotate";
            this.bRotate.Size = new System.Drawing.Size(188, 31);
            this.bRotate.TabIndex = 4;
            this.bRotate.Text = "Obróć";
            this.bRotate.UseVisualStyleBackColor = true;
            this.bRotate.Click += new System.EventHandler(this.bRotate_Click);
            // 
            // lFi
            // 
            this.lFi.AutoSize = true;
            this.lFi.Location = new System.Drawing.Point(6, 22);
            this.lFi.Name = "lFi";
            this.lFi.Size = new System.Drawing.Size(88, 13);
            this.lFi.TabIndex = 3;
            this.lFi.Text = "kąt (w stopniach)";
            // 
            // nAngle
            // 
            this.nAngle.DecimalPlaces = 4;
            this.nAngle.Location = new System.Drawing.Point(96, 20);
            this.nAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nAngle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nAngle.Name = "nAngle";
            this.nAngle.Size = new System.Drawing.Size(98, 20);
            this.nAngle.TabIndex = 0;
            // 
            // gBoxMethod
            // 
            this.gBoxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxMethod.Controls.Add(this.rPrzyrostowy);
            this.gBoxMethod.Location = new System.Drawing.Point(588, 400);
            this.gBoxMethod.Name = "gBoxMethod";
            this.gBoxMethod.Size = new System.Drawing.Size(200, 37);
            this.gBoxMethod.TabIndex = 6;
            this.gBoxMethod.TabStop = false;
            this.gBoxMethod.Text = "Algorytm rysujący";
            // 
            // rPrzyrostowy
            // 
            this.rPrzyrostowy.AutoSize = true;
            this.rPrzyrostowy.Checked = true;
            this.rPrzyrostowy.Location = new System.Drawing.Point(7, 14);
            this.rPrzyrostowy.Name = "rPrzyrostowy";
            this.rPrzyrostowy.Size = new System.Drawing.Size(80, 17);
            this.rPrzyrostowy.TabIndex = 0;
            this.rPrzyrostowy.TabStop = true;
            this.rPrzyrostowy.Text = "przyrostowy";
            this.rPrzyrostowy.UseVisualStyleBackColor = true;
            // 
            // bClearCanvas
            // 
            this.bClearCanvas.Location = new System.Drawing.Point(594, 444);
            this.bClearCanvas.Name = "bClearCanvas";
            this.bClearCanvas.Size = new System.Drawing.Size(188, 39);
            this.bClearCanvas.TabIndex = 7;
            this.bClearCanvas.Text = "Wyczyść płutno";
            this.bClearCanvas.UseVisualStyleBackColor = true;
            this.bClearCanvas.Click += new System.EventHandler(this.bClearCanvas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.bClearCanvas);
            this.Controls.Add(this.gBoxMethod);
            this.Controls.Add(this.gBoxRotation);
            this.Controls.Add(this.gBoxScale);
            this.Controls.Add(this.gBoxMove);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).EndInit();
            this.gBoxScale.ResumeLayout(false);
            this.gBoxScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScaleX)).EndInit();
            this.gBoxRotation.ResumeLayout(false);
            this.gBoxRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).EndInit();
            this.gBoxMethod.ResumeLayout(false);
            this.gBoxMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.GroupBox gBoxMove;
        private System.Windows.Forms.Button bUpLeft;
        private System.Windows.Forms.Button bDownLeft;
        private System.Windows.Forms.Button bDownRight;
        private System.Windows.Forms.Button bUpRight;
        private System.Windows.Forms.NumericUpDown nY;
        private System.Windows.Forms.NumericUpDown nX;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.GroupBox gBoxScale;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.NumericUpDown nScaleX;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.NumericUpDown nScaleY;
        private System.Windows.Forms.GroupBox gBoxRotation;
        private System.Windows.Forms.Button bRotate;
        private System.Windows.Forms.Label lFi;
        private System.Windows.Forms.NumericUpDown nAngle;
        private System.Windows.Forms.GroupBox gBoxMethod;
        private System.Windows.Forms.RadioButton rPrzyrostowy;
        private System.Windows.Forms.Button bClearCanvas;
    }
}

