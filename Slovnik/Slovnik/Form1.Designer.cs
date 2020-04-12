namespace Slovnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverStatus = new System.Windows.Forms.Label();
            this.TranslateIn = new System.Windows.Forms.RichTextBox();
            this.TranslateOut = new System.Windows.Forms.RichTextBox();
            this.LanguageIn = new System.Windows.Forms.Label();
            this.LanguageOut = new System.Windows.Forms.Label();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.clearInButton = new System.Windows.Forms.Button();
            this.LanguageChange = new System.Windows.Forms.Button();
            this.clearOutButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vlozeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Připojení k databázi:";
            // 
            // serverStatus
            // 
            this.serverStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serverStatus.AutoSize = true;
            this.serverStatus.ForeColor = System.Drawing.Color.Black;
            this.serverStatus.Location = new System.Drawing.Point(165, 325);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(19, 15);
            this.serverStatus.TabIndex = 1;
            this.serverStatus.Text = "---";
            // 
            // TranslateIn
            // 
            this.TranslateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslateIn.Location = new System.Drawing.Point(3, 37);
            this.TranslateIn.Name = "TranslateIn";
            this.TranslateIn.Size = new System.Drawing.Size(287, 153);
            this.TranslateIn.TabIndex = 2;
            this.TranslateIn.Text = "";
            // 
            // TranslateOut
            // 
            this.TranslateOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslateOut.Location = new System.Drawing.Point(393, 37);
            this.TranslateOut.Name = "TranslateOut";
            this.TranslateOut.ReadOnly = true;
            this.TranslateOut.Size = new System.Drawing.Size(288, 153);
            this.TranslateOut.TabIndex = 3;
            this.TranslateOut.Text = "";
            // 
            // LanguageIn
            // 
            this.LanguageIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LanguageIn.AutoSize = true;
            this.LanguageIn.ForeColor = System.Drawing.Color.Black;
            this.LanguageIn.Location = new System.Drawing.Point(135, 0);
            this.LanguageIn.Name = "LanguageIn";
            this.LanguageIn.Size = new System.Drawing.Size(22, 34);
            this.LanguageIn.TabIndex = 4;
            this.LanguageIn.Text = "CZ";
            this.LanguageIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageOut
            // 
            this.LanguageOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LanguageOut.AutoSize = true;
            this.LanguageOut.ForeColor = System.Drawing.Color.Black;
            this.LanguageOut.Location = new System.Drawing.Point(525, 0);
            this.LanguageOut.Name = "LanguageOut";
            this.LanguageOut.Size = new System.Drawing.Size(24, 34);
            this.LanguageOut.TabIndex = 5;
            this.LanguageOut.Text = "EN";
            this.LanguageOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TranslateButton
            // 
            this.TranslateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TranslateButton.BackColor = System.Drawing.Color.LightGray;
            this.TranslateButton.ForeColor = System.Drawing.Color.Black;
            this.TranslateButton.Location = new System.Drawing.Point(308, 202);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(66, 23);
            this.TranslateButton.TabIndex = 6;
            this.TranslateButton.Text = "přeložit";
            this.TranslateButton.UseVisualStyleBackColor = false;
            this.TranslateButton.Click += new System.EventHandler(this.Translate_Click);
            // 
            // clearInButton
            // 
            this.clearInButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearInButton.ForeColor = System.Drawing.Color.Black;
            this.clearInButton.Location = new System.Drawing.Point(132, 202);
            this.clearInButton.Name = "clearInButton";
            this.clearInButton.Size = new System.Drawing.Size(28, 23);
            this.clearInButton.TabIndex = 7;
            this.clearInButton.Text = "X";
            this.clearInButton.UseVisualStyleBackColor = true;
            this.clearInButton.Click += new System.EventHandler(this.ClearInButton_Click);
            // 
            // LanguageChange
            // 
            this.LanguageChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LanguageChange.ForeColor = System.Drawing.Color.Black;
            this.LanguageChange.Location = new System.Drawing.Point(296, 3);
            this.LanguageChange.Name = "LanguageChange";
            this.LanguageChange.Size = new System.Drawing.Size(90, 28);
            this.LanguageChange.TabIndex = 9;
            this.LanguageChange.Text = "<->";
            this.LanguageChange.UseVisualStyleBackColor = true;
            this.LanguageChange.Click += new System.EventHandler(this.LanguageChange_Click);
            // 
            // clearOutButton
            // 
            this.clearOutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearOutButton.ForeColor = System.Drawing.Color.Black;
            this.clearOutButton.Location = new System.Drawing.Point(522, 202);
            this.clearOutButton.Name = "clearOutButton";
            this.clearOutButton.Size = new System.Drawing.Size(30, 23);
            this.clearOutButton.TabIndex = 10;
            this.clearOutButton.Text = "X";
            this.clearOutButton.UseVisualStyleBackColor = true;
            this.clearOutButton.Click += new System.EventHandler(this.ClearOutButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vlozeniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vlozeniToolStripMenuItem
            // 
            this.vlozeniToolStripMenuItem.Name = "vlozeniToolStripMenuItem";
            this.vlozeniToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.vlozeniToolStripMenuItem.Text = "vložení";
            this.vlozeniToolStripMenuItem.Click += new System.EventHandler(this.VlozeniToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel1.Controls.Add(this.TranslateOut, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearInButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TranslateIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TranslateButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LanguageChange, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearOutButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LanguageIn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LanguageOut, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 228);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.TranslateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.serverStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "SlovíkCH";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.RichTextBox TranslateIn;
        private System.Windows.Forms.RichTextBox TranslateOut;
        private System.Windows.Forms.Label LanguageIn;
        private System.Windows.Forms.Label LanguageOut;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button clearInButton;
        private System.Windows.Forms.Button LanguageChange;
        private System.Windows.Forms.Button clearOutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vlozeniToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

