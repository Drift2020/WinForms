namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.MMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sqrt = new System.Windows.Forms.Button();
            this.PlusForMin = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.CleanElement = new System.Windows.Forms.Button();
            this.Backspase = new System.Windows.Forms.Button();
            this.Proz = new System.Windows.Forms.Button();
            this.Dell = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.OneDellX = new System.Windows.Forms.Button();
            this.Ymnoj = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.RESULT = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Zap = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(225, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(12, 88);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(36, 29);
            this.MC.TabIndex = 1;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(54, 88);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(36, 29);
            this.MR.TabIndex = 3;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(96, 88);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(36, 29);
            this.MS.TabIndex = 4;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // MPlus
            // 
            this.MPlus.Location = new System.Drawing.Point(138, 88);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(36, 29);
            this.MPlus.TabIndex = 5;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = true;
            this.MPlus.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // MMin
            // 
            this.MMin.Location = new System.Drawing.Point(182, 88);
            this.MMin.Name = "MMin";
            this.MMin.Size = new System.Drawing.Size(36, 29);
            this.MMin.TabIndex = 6;
            this.MMin.Text = "M-";
            this.MMin.UseVisualStyleBackColor = true;
            this.MMin.Click += new System.EventHandler(this.MMin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(182, 123);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(36, 29);
            this.Sqrt.TabIndex = 12;
            this.Sqrt.Text = " √";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // PlusForMin
            // 
            this.PlusForMin.Location = new System.Drawing.Point(138, 123);
            this.PlusForMin.Name = "PlusForMin";
            this.PlusForMin.Size = new System.Drawing.Size(36, 29);
            this.PlusForMin.TabIndex = 11;
            this.PlusForMin.Text = "±";
            this.PlusForMin.UseVisualStyleBackColor = true;
            this.PlusForMin.Click += new System.EventHandler(this.PlusForMin_Click);
            // 
            // CleanAll
            // 
            this.CleanAll.Location = new System.Drawing.Point(96, 123);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(36, 29);
            this.CleanAll.TabIndex = 10;
            this.CleanAll.Text = "C";
            this.CleanAll.UseVisualStyleBackColor = true;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // CleanElement
            // 
            this.CleanElement.Location = new System.Drawing.Point(54, 123);
            this.CleanElement.Name = "CleanElement";
            this.CleanElement.Size = new System.Drawing.Size(36, 29);
            this.CleanElement.TabIndex = 9;
            this.CleanElement.Text = "CE";
            this.CleanElement.UseVisualStyleBackColor = true;
            this.CleanElement.Click += new System.EventHandler(this.CleanElement_Click);
            // 
            // Backspase
            // 
            this.Backspase.Location = new System.Drawing.Point(12, 123);
            this.Backspase.Name = "Backspase";
            this.Backspase.Size = new System.Drawing.Size(36, 29);
            this.Backspase.TabIndex = 8;
            this.Backspase.Text = "←";
            this.Backspase.UseVisualStyleBackColor = true;
            this.Backspase.Click += new System.EventHandler(this.Backspase_Click);
            // 
            // Proz
            // 
            this.Proz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proz.Location = new System.Drawing.Point(182, 158);
            this.Proz.Name = "Proz";
            this.Proz.Size = new System.Drawing.Size(36, 29);
            this.Proz.TabIndex = 17;
            this.Proz.Text = "%";
            this.Proz.UseVisualStyleBackColor = true;
            this.Proz.Click += new System.EventHandler(this.Proz_Click);
            // 
            // Dell
            // 
            this.Dell.Location = new System.Drawing.Point(138, 158);
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(36, 29);
            this.Dell.TabIndex = 16;
            this.Dell.Text = "/";
            this.Dell.UseVisualStyleBackColor = true;
            this.Dell.Click += new System.EventHandler(this.Dell_Click);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B9.Location = new System.Drawing.Point(96, 158);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(36, 29);
            this.B9.TabIndex = 15;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B8.Location = new System.Drawing.Point(54, 158);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(36, 29);
            this.B8.TabIndex = 14;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B7.Location = new System.Drawing.Point(12, 158);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(36, 29);
            this.B7.TabIndex = 13;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // OneDellX
            // 
            this.OneDellX.Location = new System.Drawing.Point(182, 193);
            this.OneDellX.Name = "OneDellX";
            this.OneDellX.Size = new System.Drawing.Size(36, 29);
            this.OneDellX.TabIndex = 22;
            this.OneDellX.Text = "1/x";
            this.OneDellX.UseVisualStyleBackColor = true;
            this.OneDellX.Click += new System.EventHandler(this.OneDellX_Click);
            // 
            // Ymnoj
            // 
            this.Ymnoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ymnoj.Location = new System.Drawing.Point(138, 193);
            this.Ymnoj.Name = "Ymnoj";
            this.Ymnoj.Size = new System.Drawing.Size(36, 29);
            this.Ymnoj.TabIndex = 21;
            this.Ymnoj.Text = "*";
            this.Ymnoj.UseVisualStyleBackColor = true;
            this.Ymnoj.Click += new System.EventHandler(this.Ymnoj_Click);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B6.Location = new System.Drawing.Point(96, 193);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(36, 29);
            this.B6.TabIndex = 20;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B5.Location = new System.Drawing.Point(54, 193);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(36, 29);
            this.B5.TabIndex = 19;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B4.Location = new System.Drawing.Point(12, 193);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(36, 29);
            this.B4.TabIndex = 18;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.Location = new System.Drawing.Point(138, 228);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(36, 29);
            this.Min.TabIndex = 26;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(96, 228);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(36, 29);
            this.B3.TabIndex = 25;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(53, 228);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(36, 29);
            this.B2.TabIndex = 24;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(12, 228);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(36, 29);
            this.B1.TabIndex = 23;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // RESULT
            // 
            this.RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RESULT.Location = new System.Drawing.Point(182, 228);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(36, 64);
            this.RESULT.TabIndex = 32;
            this.RESULT.Text = "=";
            this.RESULT.UseVisualStyleBackColor = true;
            this.RESULT.Click += new System.EventHandler(this.RESULT_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(138, 263);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(36, 29);
            this.Plus.TabIndex = 31;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Zap
            // 
            this.Zap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zap.Location = new System.Drawing.Point(96, 263);
            this.Zap.Name = "Zap";
            this.Zap.Size = new System.Drawing.Size(36, 29);
            this.Zap.TabIndex = 30;
            this.Zap.Text = ",";
            this.Zap.UseVisualStyleBackColor = true;
            this.Zap.Click += new System.EventHandler(this.Zap_Click);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(12, 263);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(78, 29);
            this.B0.TabIndex = 28;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 305);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Zap);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.OneDellX);
            this.Controls.Add(this.Ymnoj);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.Proz);
            this.Controls.Add(this.Dell);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.PlusForMin);
            this.Controls.Add(this.CleanAll);
            this.Controls.Add(this.CleanElement);
            this.Controls.Add(this.Backspase);
            this.Controls.Add(this.MMin);
            this.Controls.Add(this.MPlus);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.Button MPlus;
        private System.Windows.Forms.Button MMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button PlusForMin;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button CleanElement;
        private System.Windows.Forms.Button Backspase;
        private System.Windows.Forms.Button Proz;
        private System.Windows.Forms.Button Dell;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button OneDellX;
        private System.Windows.Forms.Button Ymnoj;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button RESULT;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Zap;
        private System.Windows.Forms.Button B0;
    }
}

