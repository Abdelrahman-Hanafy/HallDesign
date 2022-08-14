
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
            this.n = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.finish = new System.Windows.Forms.Button();
            this.colorBalet = new System.Windows.Forms.Panel();
            this.black = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ang = new System.Windows.Forms.TextBox();
            this.rotate = new System.Windows.Forms.Button();
            this.colorBalet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(0, 43);
            this.canvas.Margin = new System.Windows.Forms.Padding(5);
            this.canvas.Name = "canvas";
            this.canvas.Padding = new System.Windows.Forms.Padding(5);
            this.canvas.Size = new System.Drawing.Size(982, 536);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(697, 15);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(51, 20);
            this.n.TabIndex = 13;
            this.n.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(754, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 26);
            this.name.TabIndex = 12;
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
            // save
            // 
            this.save.Location = new System.Drawing.Point(889, 9);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 32);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ang
            // 
            this.ang.BackColor = System.Drawing.SystemColors.Window;
            this.ang.ForeColor = System.Drawing.Color.DarkGray;
            this.ang.Location = new System.Drawing.Point(276, 10);
            this.ang.Name = "ang";
            this.ang.Size = new System.Drawing.Size(129, 26);
            this.ang.TabIndex = 14;
            this.ang.Text = "Angle";
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(411, 7);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 32);
            this.rotate.TabIndex = 15;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.ang);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.name);
            this.Controls.Add(this.n);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.colorBalet);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Hall Design";
            this.TopMost = true;
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
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox ang;
        private System.Windows.Forms.Button rotate;
    }
}

