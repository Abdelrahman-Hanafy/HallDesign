
namespace HallDesign
{
    partial class Drawing
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
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBalet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
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
            this.finish.Location = new System.Drawing.Point(167, 7);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(69, 33);
            this.finish.TabIndex = 1;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // colorBalet
            // 
            this.colorBalet.Controls.Add(this.black);
            this.colorBalet.Controls.Add(this.yellow);
            this.colorBalet.Location = new System.Drawing.Point(59, 10);
            this.colorBalet.Name = "colorBalet";
            this.colorBalet.Size = new System.Drawing.Size(53, 28);
            this.colorBalet.TabIndex = 0;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(29, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(20, 20);
            this.black.TabIndex = 3;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.color_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(3, 3);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(20, 20);
            this.yellow.TabIndex = 2;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.color_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(399, 7);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(66, 33);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "-->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rotate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Blk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Scr";
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.name);
            this.Controls.Add(this.n);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.colorBalet);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Drawing";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Hall Design";
            this.colorBalet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel colorBalet;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

