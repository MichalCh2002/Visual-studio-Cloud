namespace DataTableBindings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Load = new System.Windows.Forms.ToolStripButton();
            this.Next = new System.Windows.Forms.ToolStripButton();
            this.Previous = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Jmeno = new System.Windows.Forms.Label();
            this.Prijmeni = new System.Windows.Forms.Label();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load,
            this.Previous,
            this.Next});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Load
            // 
            this.Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Load.Image = ((System.Drawing.Image)(resources.GetObject("Load.Image")));
            this.Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(25, 22);
            this.Load.Text = "toolStripButton1";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Next
            // 
            this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(25, 22);
            this.Next.Text = "toolStripButton2";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Previous.Image = ((System.Drawing.Image)(resources.GetObject("Previous.Image")));
            this.Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(25, 22);
            this.Previous.Text = "toolStripButton3";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Jmeno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Prijmeni, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxJmeno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrijmeni, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 56);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Jmeno
            // 
            this.Jmeno.AutoSize = true;
            this.Jmeno.Location = new System.Drawing.Point(3, 0);
            this.Jmeno.Name = "Jmeno";
            this.Jmeno.Size = new System.Drawing.Size(45, 15);
            this.Jmeno.TabIndex = 0;
            this.Jmeno.Text = "Jméno";
            // 
            // Prijmeni
            // 
            this.Prijmeni.AutoSize = true;
            this.Prijmeni.Location = new System.Drawing.Point(3, 26);
            this.Prijmeni.Name = "Prijmeni";
            this.Prijmeni.Size = new System.Drawing.Size(53, 15);
            this.Prijmeni.TabIndex = 1;
            this.Prijmeni.Text = "Prijmeni";
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJmeno.Location = new System.Drawing.Point(62, 3);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(683, 20);
            this.textBoxJmeno.TabIndex = 2;
            // 
            // textBoxPrijmeni
            // 
            this.textBoxPrijmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrijmeni.Location = new System.Drawing.Point(62, 31);
            this.textBoxPrijmeni.Name = "textBoxPrijmeni";
            this.textBoxPrijmeni.Size = new System.Drawing.Size(683, 20);
            this.textBoxPrijmeni.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(748, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Load;
        private System.Windows.Forms.ToolStripButton Next;
        private System.Windows.Forms.ToolStripButton Previous;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Jmeno;
        private System.Windows.Forms.Label Prijmeni;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxPrijmeni;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

