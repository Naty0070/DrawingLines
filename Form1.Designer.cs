
namespace DrawingLines {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btColor_default = new System.Windows.Forms.Button();
            this.btLinCol_default = new System.Windows.Forms.Button();
            this.btLineColor = new System.Windows.Forms.Button();
            this.btColor = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.Angle = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.Label();
            this.txAngle = new System.Windows.Forms.TextBox();
            this.txIncrement = new System.Windows.Forms.TextBox();
            this.txLenght = new System.Windows.Forms.TextBox();
            this.txLines = new System.Windows.Forms.TextBox();
            this.Lines = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btColor_default);
            this.panel1.Controls.Add(this.btLinCol_default);
            this.panel1.Controls.Add(this.btLineColor);
            this.panel1.Controls.Add(this.btColor);
            this.panel1.Controls.Add(this.btGo);
            this.panel1.Controls.Add(this.Angle);
            this.panel1.Controls.Add(this.Increment);
            this.panel1.Controls.Add(this.Lenght);
            this.panel1.Controls.Add(this.txAngle);
            this.panel1.Controls.Add(this.txIncrement);
            this.panel1.Controls.Add(this.txLenght);
            this.panel1.Controls.Add(this.txLines);
            this.panel1.Controls.Add(this.Lines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 36);
            this.panel1.TabIndex = 0;
            // 
            // btColor_default
            // 
            this.btColor_default.BackColor = System.Drawing.Color.Silver;
            this.btColor_default.Location = new System.Drawing.Point(632, 9);
            this.btColor_default.Name = "btColor_default";
            this.btColor_default.Size = new System.Drawing.Size(60, 23);
            this.btColor_default.TabIndex = 10;
            this.btColor_default.Text = "Def.Bg.";
            this.btColor_default.UseVisualStyleBackColor = false;
            this.btColor_default.Click += new System.EventHandler(this.btColor_default_Click);
            this.btColor_default.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btLinCol_default
            // 
            this.btLinCol_default.BackColor = System.Drawing.Color.Silver;
            this.btLinCol_default.Location = new System.Drawing.Point(500, 8);
            this.btLinCol_default.Name = "btLinCol_default";
            this.btLinCol_default.Size = new System.Drawing.Size(60, 23);
            this.btLinCol_default.TabIndex = 11;
            this.btLinCol_default.Text = "Def.Lin";
            this.btLinCol_default.UseVisualStyleBackColor = false;
            this.btLinCol_default.Click += new System.EventHandler(this.btLinCol_default_Click);
            this.btLinCol_default.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btLineColor
            // 
            this.btLineColor.BackColor = System.Drawing.Color.Silver;
            this.btLineColor.Location = new System.Drawing.Point(434, 8);
            this.btLineColor.Name = "btLineColor";
            this.btLineColor.Size = new System.Drawing.Size(60, 23);
            this.btLineColor.TabIndex = 9;
            this.btLineColor.Text = "Lin.Col.";
            this.btLineColor.UseVisualStyleBackColor = false;
            this.btLineColor.Click += new System.EventHandler(this.btLineColor_Click);
            this.btLineColor.Click += new System.EventHandler(this.btGo_Click);

            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.Silver;
            this.btColor.Location = new System.Drawing.Point(566, 9);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(60, 23);
            this.btColor.TabIndex = 8;
            this.btColor.Text = "Bg.Col.";
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            this.btColor.Click += new System.EventHandler(this.btGo_Click);

            // 
            // btGo
            // 
            this.btGo.BackColor = System.Drawing.Color.Silver;
            this.btGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGo.Location = new System.Drawing.Point(388, 8);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(40, 23);
            this.btGo.TabIndex = 0;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Angle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Angle.Location = new System.Drawing.Point(89, 10);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(38, 15);
            this.Angle.TabIndex = 7;
            this.Angle.Text = "Angle";
            // 
            // Increment
            // 
            this.Increment.AutoSize = true;
            this.Increment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Increment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Increment.Location = new System.Drawing.Point(275, 11);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(61, 15);
            this.Increment.TabIndex = 6;
            this.Increment.Text = "Increment";
            // 
            // Lenght
            // 
            this.Lenght.AutoSize = true;
            this.Lenght.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lenght.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lenght.Location = new System.Drawing.Point(179, 12);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(44, 15);
            this.Lenght.TabIndex = 5;
            this.Lenght.Text = "Lenght";
            // 
            // txAngle
            // 
            this.txAngle.Location = new System.Drawing.Point(133, 7);
            this.txAngle.Name = "txAngle";
            this.txAngle.Size = new System.Drawing.Size(40, 23);
            this.txAngle.TabIndex = 4;
            this.txAngle.Text = "24";
            this.txAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txAngle.TextChanged += new System.EventHandler(this.txAngle_TextChanged);
            this.txAngle.TextChanged += new System.EventHandler(this.btGo_Click);
            // 
            // txIncrement
            // 
            this.txIncrement.Location = new System.Drawing.Point(342, 8);
            this.txIncrement.Name = "txIncrement";
            this.txIncrement.Size = new System.Drawing.Size(40, 23);
            this.txIncrement.TabIndex = 3;
            this.txIncrement.Text = "1";
            this.txIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txIncrement.TextChanged += new System.EventHandler(this.txIncrement_TextChanged);
            this.txIncrement.TextChanged += new System.EventHandler(this.btGo_Click);

            // 
            // txLenght
            // 
            this.txLenght.Location = new System.Drawing.Point(229, 7);
            this.txLenght.Name = "txLenght";
            this.txLenght.Size = new System.Drawing.Size(40, 23);
            this.txLenght.TabIndex = 2;
            this.txLenght.Text = "5";
            this.txLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txLenght.TextChanged += new System.EventHandler(this.txLenght_TextChanged);
            this.txLenght.TextChanged += new System.EventHandler(this.btGo_Click);
            // 
            // txLines
            // 
            this.txLines.Location = new System.Drawing.Point(43, 7);
            this.txLines.Name = "txLines";
            this.txLines.Size = new System.Drawing.Size(40, 23);
            this.txLines.TabIndex = 1;
            this.txLines.Text = "100";
            this.txLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txLines.TextChanged += new System.EventHandler(this.txLines_TextChanged);
            this.txLines.TextChanged += new System.EventHandler(this.btGo_Click);
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lines.Location = new System.Drawing.Point(3, 9);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(34, 15);
            this.Lines.TabIndex = 0;
            this.Lines.Text = "Lines";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 436);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Enter += new System.EventHandler(this.btGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines";
            this.SizeChanged += new System.EventHandler(this.btGo_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void TxAngle_Enter(object sender, System.EventArgs e) {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.Label Increment;
        private System.Windows.Forms.Label Lenght;
        private System.Windows.Forms.TextBox txAngle;
        private System.Windows.Forms.TextBox txIncrement;
        private System.Windows.Forms.TextBox txLenght;
        private System.Windows.Forms.TextBox txLines;
        private System.Windows.Forms.Label Lines;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btLineColor;
        private System.Windows.Forms.Button btColor_default;
        private System.Windows.Forms.Button btLinCol_default;
    }
}

