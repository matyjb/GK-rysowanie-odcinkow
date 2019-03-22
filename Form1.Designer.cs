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
            this.gBoxMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(555, 425);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
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
            this.gBoxMove.Text = "Move by";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxMove);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).EndInit();
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
    }
}

