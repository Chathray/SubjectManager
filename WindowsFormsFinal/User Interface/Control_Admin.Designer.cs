namespace WindowsFormsFinal
{
    partial class Control_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolbar = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolbar_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolbar_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolbar_Separator0 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolbar_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_Submit = new System.Windows.Forms.ToolStripButton();
            this.toolbar_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolbar_Print = new System.Windows.Forms.ToolStripButton();
            this.dataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbar)).BeginInit();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.AddNewItem = this.toolbar_AddNewItem;
            this.toolbar.AutoSize = false;
            this.toolbar.BindingSource = this.bindingSource;
            this.toolbar.CountItem = this.toolbar_CountItem;
            this.toolbar.DeleteItem = this.toolbar_DeleteItem;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbar_MoveFirstItem,
            this.toolbar_MovePreviousItem,
            this.toolbar_Separator,
            this.toolbar_PositionItem,
            this.toolbar_CountItem,
            this.toolbar_Separator0,
            this.toolbar_MoveNextItem,
            this.toolbar_MoveLastItem,
            this.toolbar_Separator1,
            this.toolbar_AddNewItem,
            this.toolbar_DeleteItem,
            this.toolbar_Separator2,
            this.toolbar_Submit,
            this.toolbar_Refresh,
            this.toolbar_Print});
            this.toolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.MoveFirstItem = this.toolbar_MoveFirstItem;
            this.toolbar.MoveLastItem = this.toolbar_MoveLastItem;
            this.toolbar.MoveNextItem = this.toolbar_MoveNextItem;
            this.toolbar.MovePreviousItem = this.toolbar_MovePreviousItem;
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolbar.PositionItem = this.toolbar_PositionItem;
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolbar.Size = new System.Drawing.Size(660, 30);
            this.toolbar.TabIndex = 1;
            // 
            // toolbar_AddNewItem
            // 
            this.toolbar_AddNewItem.AutoSize = false;
            this.toolbar_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_AddNewItem.Image")));
            this.toolbar_AddNewItem.Name = "toolbar_AddNewItem";
            this.toolbar_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_AddNewItem.Size = new System.Drawing.Size(49, 20);
            this.toolbar_AddNewItem.Text = "Add";
            // 
            // toolbar_CountItem
            // 
            this.toolbar_CountItem.AutoSize = false;
            this.toolbar_CountItem.Name = "toolbar_CountItem";
            this.toolbar_CountItem.Size = new System.Drawing.Size(35, 20);
            this.toolbar_CountItem.Text = "of {0}";
            this.toolbar_CountItem.ToolTipText = "Total number of items";
            // 
            // toolbar_DeleteItem
            // 
            this.toolbar_DeleteItem.AutoSize = false;
            this.toolbar_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_DeleteItem.Image")));
            this.toolbar_DeleteItem.Name = "toolbar_DeleteItem";
            this.toolbar_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_DeleteItem.Size = new System.Drawing.Size(60, 20);
            this.toolbar_DeleteItem.Text = "Delete";
            // 
            // toolbar_MoveFirstItem
            // 
            this.toolbar_MoveFirstItem.AutoSize = false;
            this.toolbar_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_MoveFirstItem.Image")));
            this.toolbar_MoveFirstItem.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.toolbar_MoveFirstItem.Name = "toolbar_MoveFirstItem";
            this.toolbar_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_MoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.toolbar_MoveFirstItem.Text = "Move first";
            // 
            // toolbar_MovePreviousItem
            // 
            this.toolbar_MovePreviousItem.AutoSize = false;
            this.toolbar_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_MovePreviousItem.Image")));
            this.toolbar_MovePreviousItem.Name = "toolbar_MovePreviousItem";
            this.toolbar_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_MovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.toolbar_MovePreviousItem.Text = "Move previous";
            // 
            // toolbar_Separator
            // 
            this.toolbar_Separator.AutoSize = false;
            this.toolbar_Separator.Name = "toolbar_Separator";
            this.toolbar_Separator.Size = new System.Drawing.Size(6, 20);
            // 
            // toolbar_PositionItem
            // 
            this.toolbar_PositionItem.AccessibleName = "Position";
            this.toolbar_PositionItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolbar_PositionItem.Name = "toolbar_PositionItem";
            this.toolbar_PositionItem.Size = new System.Drawing.Size(50, 30);
            this.toolbar_PositionItem.Text = "0";
            this.toolbar_PositionItem.ToolTipText = "Current position";
            // 
            // toolbar_Separator0
            // 
            this.toolbar_Separator0.AutoSize = false;
            this.toolbar_Separator0.Name = "toolbar_Separator0";
            this.toolbar_Separator0.Size = new System.Drawing.Size(6, 20);
            // 
            // toolbar_MoveNextItem
            // 
            this.toolbar_MoveNextItem.AutoSize = false;
            this.toolbar_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_MoveNextItem.Image")));
            this.toolbar_MoveNextItem.Name = "toolbar_MoveNextItem";
            this.toolbar_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_MoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.toolbar_MoveNextItem.Text = "Move next";
            // 
            // toolbar_MoveLastItem
            // 
            this.toolbar_MoveLastItem.AutoSize = false;
            this.toolbar_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_MoveLastItem.Image")));
            this.toolbar_MoveLastItem.Name = "toolbar_MoveLastItem";
            this.toolbar_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.toolbar_MoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.toolbar_MoveLastItem.Text = "Move last";
            // 
            // toolbar_Separator1
            // 
            this.toolbar_Separator1.AutoSize = false;
            this.toolbar_Separator1.Name = "toolbar_Separator1";
            this.toolbar_Separator1.Size = new System.Drawing.Size(6, 20);
            // 
            // toolbar_Separator2
            // 
            this.toolbar_Separator2.AutoSize = false;
            this.toolbar_Separator2.Name = "toolbar_Separator2";
            this.toolbar_Separator2.Size = new System.Drawing.Size(6, 20);
            // 
            // toolbar_Submit
            // 
            this.toolbar_Submit.AutoSize = false;
            this.toolbar_Submit.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_Submit.Image")));
            this.toolbar_Submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_Submit.Name = "toolbar_Submit";
            this.toolbar_Submit.Size = new System.Drawing.Size(65, 20);
            this.toolbar_Submit.Text = "&Submit";
            this.toolbar_Submit.Click += new System.EventHandler(this.Toolbar_Submit_Click);
            // 
            // toolbar_Refresh
            // 
            this.toolbar_Refresh.AutoSize = false;
            this.toolbar_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_Refresh.Image")));
            this.toolbar_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_Refresh.Name = "toolbar_Refresh";
            this.toolbar_Refresh.Size = new System.Drawing.Size(66, 20);
            this.toolbar_Refresh.Text = "&Refresh";
            this.toolbar_Refresh.Click += new System.EventHandler(this.Toolbar_Refresh_Click);
            // 
            // toolbar_Print
            // 
            this.toolbar_Print.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbar_Print.AutoSize = false;
            this.toolbar_Print.Image = ((System.Drawing.Image)(resources.GetObject("toolbar_Print.Image")));
            this.toolbar_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_Print.Name = "toolbar_Print";
            this.toolbar_Print.Size = new System.Drawing.Size(52, 20);
            this.toolbar_Print.Text = "&Print";
            this.toolbar_Print.Click += new System.EventHandler(this.PrintToolStripButton_Click);
            // 
            // dataTable
            // 
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeight = 25;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.Silver;
            this.dataTable.Location = new System.Drawing.Point(0, 30);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataTable.Size = new System.Drawing.Size(660, 450);
            this.dataTable.TabIndex = 2;
            // 
            // Control_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.toolbar);
            this.Name = "Control_Admin";
            this.Size = new System.Drawing.Size(660, 480);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbar)).EndInit();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingNavigator toolbar;
        private System.Windows.Forms.ToolStripButton toolbar_AddNewItem;
        private System.Windows.Forms.ToolStripLabel toolbar_CountItem;
        private System.Windows.Forms.ToolStripButton toolbar_DeleteItem;
        private System.Windows.Forms.ToolStripButton toolbar_MoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator toolbar_Separator;
        private System.Windows.Forms.ToolStripTextBox toolbar_PositionItem;
        private System.Windows.Forms.ToolStripSeparator toolbar_Separator0;
        private System.Windows.Forms.ToolStripButton toolbar_MoveLastItem;
        private System.Windows.Forms.ToolStripButton toolbar_Submit;
        private System.Windows.Forms.ToolStripButton toolbar_Print;
        private System.Windows.Forms.ToolStripSeparator toolbar_Separator1;
        private System.Windows.Forms.ToolStripSeparator toolbar_Separator2;
        private System.Windows.Forms.ToolStripButton toolbar_MovePreviousItem;
        private System.Windows.Forms.ToolStripButton toolbar_MoveNextItem;
        private System.Windows.Forms.ToolStripButton toolbar_Refresh;
        private System.Windows.Forms.DataGridView dataTable;
    }
}
