
namespace HallDesign
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
            this.finish = new System.Windows.Forms.Button();
            this.colorBalet = new System.Windows.Forms.Panel();
            this.black = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.cols = new System.Windows.Forms.TextBox();
            this.rows = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBalet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(1, 46);
            this.canvas.Margin = new System.Windows.Forms.Padding(5);
            this.canvas.Name = "canvas";
            this.canvas.Padding = new System.Windows.Forms.Padding(5);
            this.canvas.Size = new System.Drawing.Size(980, 533);
            this.canvas.TabIndex = 0;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(97, 7);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 33);
            this.finish.TabIndex = 1;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // colorBalet
            // 
            this.colorBalet.Controls.Add(this.black);
            this.colorBalet.Controls.Add(this.yellow);
            this.colorBalet.Controls.Add(this.red);
            this.colorBalet.Location = new System.Drawing.Point(12, 12);
            this.colorBalet.Name = "colorBalet";
            this.colorBalet.Size = new System.Drawing.Size(79, 28);
            this.colorBalet.TabIndex = 0;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(55, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(20, 20);
            this.black.TabIndex = 3;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.color_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(29, 3);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(20, 20);
            this.yellow.TabIndex = 2;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.color_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(3, 3);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(20, 20);
            this.red.TabIndex = 1;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.color_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(178, 7);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 33);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cols
            // 
            this.cols.ForeColor = System.Drawing.Color.Black;
            this.cols.Location = new System.Drawing.Point(612, 10);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(147, 26);
            this.cols.TabIndex = 3;
            this.cols.Text = "0";
            // 
            // rows
            // 
            this.rows.ForeColor = System.Drawing.Color.Black;
            this.rows.Location = new System.Drawing.Point(823, 10);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(147, 26);
            this.rows.TabIndex = 4;
            this.rows.Text = "0";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(460, 9);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(100, 26);
            this.angle.TabIndex = 6;
            this.angle.Text = "0";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 7);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 32);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.colorBalet);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Hall Design";
            this.colorBalet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel colorBalet;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox cols;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

