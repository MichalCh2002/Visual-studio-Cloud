namespace BasicCalculator
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
            this.UserIntputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIntputText
            // 
            this.UserIntputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserIntputText.Location = new System.Drawing.Point(12, 12);
            this.UserIntputText.Name = "UserIntputText";
            this.UserIntputText.Size = new System.Drawing.Size(344, 20);
            this.UserIntputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Location = new System.Drawing.Point(13, 39);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(343, 77);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Vložte rovnici a stiskněte enter nebo =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.ButtonsPanel.Controls.Add(this.EnterButton, 0, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 0, 4);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.DeleteButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.PercentButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.TimesButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 119);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(344, 213);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(3, 171);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(80, 39);
            this.ZeroButton.TabIndex = 24;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterButton.Location = new System.Drawing.Point(89, 171);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(80, 39);
            this.EnterButton.TabIndex = 22;
            this.EnterButton.Text = "=";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(175, 171);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(80, 39);
            this.DotButton.TabIndex = 21;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(89, 129);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(80, 36);
            this.TwoButton.TabIndex = 9;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 129);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(80, 36);
            this.OneButton.TabIndex = 8;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(261, 129);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(80, 36);
            this.PlusButton.TabIndex = 7;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(175, 129);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(80, 36);
            this.ThreeButton.TabIndex = 5;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(80, 36);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(175, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 36);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentButton.Location = new System.Drawing.Point(261, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(80, 36);
            this.PercentButton.TabIndex = 12;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 45);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(80, 36);
            this.SevenButton.TabIndex = 13;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 87);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(80, 36);
            this.FourButton.TabIndex = 14;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(89, 45);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(80, 36);
            this.EightButton.TabIndex = 15;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(89, 87);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 36);
            this.FiveButton.TabIndex = 16;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(175, 45);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(80, 36);
            this.NineButton.TabIndex = 17;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimesButton.Location = new System.Drawing.Point(261, 45);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(80, 36);
            this.TimesButton.TabIndex = 18;
            this.TimesButton.Text = "x";
            this.TimesButton.UseVisualStyleBackColor = true;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(175, 87);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(80, 36);
            this.SixButton.TabIndex = 19;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(261, 87);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(80, 36);
            this.MinusButton.TabIndex = 20;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(368, 344);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserIntputText);
            this.MinimumSize = new System.Drawing.Size(270, 270);
            this.Name = "Form1";
            this.Text = " ";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIntputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DotButton;
    }
}

