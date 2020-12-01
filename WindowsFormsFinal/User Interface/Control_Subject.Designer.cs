namespace WindowsFormsFinal
{
    partial class Control_Subject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Subject));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lecturer";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseDown);
            this.label2.MouseLeave += new System.EventHandler(this.Subject_OBJ_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseDown);
            this.label1.MouseLeave += new System.EventHandler(this.Subject_OBJ_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(43, 55);
            this.label3.TabIndex = 0;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseDown);
            this.label3.MouseLeave += new System.EventHandler(this.Subject_OBJ_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Subject_OBJ_MouseUp);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator.Location = new System.Drawing.Point(43, 54);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(215, 1);
            this.separator.TabIndex = 4;
            // 
            // Control_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Control_Subject";
            this.Size = new System.Drawing.Size(258, 55);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label separator;
    }
}
