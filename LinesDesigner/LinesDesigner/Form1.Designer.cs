namespace LinesDesigner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_increment = new System.Windows.Forms.TextBox();
            this.textbox_length = new System.Windows.Forms.TextBox();
            this.textbox_angle = new System.Windows.Forms.TextBox();
            this.textbox_num_lines = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textbox_increment);
            this.panel1.Controls.Add(this.textbox_length);
            this.panel1.Controls.Add(this.textbox_angle);
            this.panel1.Controls.Add(this.textbox_num_lines);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 58);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(780, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_increment
            // 
            this.textbox_increment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textbox_increment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_increment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_increment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_increment.Location = new System.Drawing.Point(667, 16);
            this.textbox_increment.Name = "textbox_increment";
            this.textbox_increment.Size = new System.Drawing.Size(61, 26);
            this.textbox_increment.TabIndex = 1;
            this.textbox_increment.Text = "1";
            this.textbox_increment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_increment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.textbox_increment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // textbox_length
            // 
            this.textbox_length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textbox_length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_length.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_length.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_length.Location = new System.Drawing.Point(457, 16);
            this.textbox_length.Name = "textbox_length";
            this.textbox_length.Size = new System.Drawing.Size(61, 26);
            this.textbox_length.TabIndex = 1;
            this.textbox_length.Text = "2";
            this.textbox_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.textbox_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // textbox_angle
            // 
            this.textbox_angle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textbox_angle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_angle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_angle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_angle.Location = new System.Drawing.Point(276, 16);
            this.textbox_angle.Name = "textbox_angle";
            this.textbox_angle.Size = new System.Drawing.Size(61, 26);
            this.textbox_angle.TabIndex = 1;
            this.textbox_angle.Text = "88";
            this.textbox_angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_angle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.textbox_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // textbox_num_lines
            // 
            this.textbox_num_lines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textbox_num_lines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_num_lines.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_num_lines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_num_lines.Location = new System.Drawing.Point(104, 16);
            this.textbox_num_lines.Name = "textbox_num_lines";
            this.textbox_num_lines.Size = new System.Drawing.Size(61, 26);
            this.textbox_num_lines.TabIndex = 1;
            this.textbox_num_lines.Text = "100";
            this.textbox_num_lines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_num_lines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.textbox_num_lines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(561, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(380, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(208, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "#Lines";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.ForeColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(0, 58);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(897, 505);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 563);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines Designer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_increment;
        private System.Windows.Forms.TextBox textbox_length;
        private System.Windows.Forms.TextBox textbox_angle;
        private System.Windows.Forms.TextBox textbox_num_lines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
    }
}

