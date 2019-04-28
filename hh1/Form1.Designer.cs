namespace hw2
{
    partial class hw2
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.fxy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(496, 79);
            this.txtx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(247, 29);
            this.txtx.TabIndex = 1;
            this.txtx.TextChanged += new System.EventHandler(this.txtx_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(496, 126);
            this.txty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(247, 29);
            this.txty.TabIndex = 1;
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(496, 179);
            this.txtf.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(247, 29);
            this.txtf.TabIndex = 1;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(381, 79);
            this.x.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(94, 25);
            this.x.TabIndex = 2;
            this.x.Text = "Optimal x";
            this.x.Click += new System.EventHandler(this.label1_Click);
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(381, 126);
            this.y.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(94, 25);
            this.y.TabIndex = 2;
            this.y.Text = "Optimal y";
            // 
            // fxy
            // 
            this.fxy.AutoSize = true;
            this.fxy.Location = new System.Drawing.Point(381, 182);
            this.fxy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fxy.Name = "fxy";
            this.fxy.Size = new System.Drawing.Size(56, 25);
            this.fxy.TabIndex = 2;
            this.fxy.Text = "f(x,y)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulated Annealing";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hw2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fxy);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "hw2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label fxy;
        private System.Windows.Forms.Label label1;
    }
}

