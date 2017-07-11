namespace Metronome
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primaryColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accentColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beatSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.default1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.default2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.default3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BeatNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGColorToolStripMenuItem,
            this.beatSoundToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.optionsToolStripMenuItem.Text = "Preferences";
            // 
            // bGColorToolStripMenuItem
            // 
            this.bGColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaryColorToolStripMenuItem,
            this.accentColorToolStripMenuItem});
            this.bGColorToolStripMenuItem.Name = "bGColorToolStripMenuItem";
            this.bGColorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bGColorToolStripMenuItem.Text = "Color Scheme";
            // 
            // primaryColorToolStripMenuItem
            // 
            this.primaryColorToolStripMenuItem.Name = "primaryColorToolStripMenuItem";
            this.primaryColorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.primaryColorToolStripMenuItem.Text = "Primary Color";
            this.primaryColorToolStripMenuItem.Click += new System.EventHandler(this.primaryColorToolStripMenuItem_Click);
            // 
            // accentColorToolStripMenuItem
            // 
            this.accentColorToolStripMenuItem.Name = "accentColorToolStripMenuItem";
            this.accentColorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.accentColorToolStripMenuItem.Text = "Accent Color";
            this.accentColorToolStripMenuItem.Click += new System.EventHandler(this.accentColorToolStripMenuItem_Click);
            // 
            // beatSoundToolStripMenuItem
            // 
            this.beatSoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.default1ToolStripMenuItem,
            this.default2ToolStripMenuItem,
            this.default3ToolStripMenuItem,
            this.chooseSoundToolStripMenuItem});
            this.beatSoundToolStripMenuItem.Name = "beatSoundToolStripMenuItem";
            this.beatSoundToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.beatSoundToolStripMenuItem.Text = "Beat Sound";
            // 
            // default1ToolStripMenuItem
            // 
            this.default1ToolStripMenuItem.Name = "default1ToolStripMenuItem";
            this.default1ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.default1ToolStripMenuItem.Text = "Default1";
            this.default1ToolStripMenuItem.Click += new System.EventHandler(this.default1ToolStripMenuItem_Click);
            // 
            // default2ToolStripMenuItem
            // 
            this.default2ToolStripMenuItem.Name = "default2ToolStripMenuItem";
            this.default2ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.default2ToolStripMenuItem.Text = "Default2";
            this.default2ToolStripMenuItem.Click += new System.EventHandler(this.default2ToolStripMenuItem_Click);
            // 
            // default3ToolStripMenuItem
            // 
            this.default3ToolStripMenuItem.Name = "default3ToolStripMenuItem";
            this.default3ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.default3ToolStripMenuItem.Text = "Default3";
            this.default3ToolStripMenuItem.Click += new System.EventHandler(this.default3ToolStripMenuItem_Click);
            // 
            // chooseSoundToolStripMenuItem
            // 
            this.chooseSoundToolStripMenuItem.Name = "chooseSoundToolStripMenuItem";
            this.chooseSoundToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.chooseSoundToolStripMenuItem.Text = "Choose Sound";
            this.chooseSoundToolStripMenuItem.Click += new System.EventHandler(this.chooseSoundToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.displayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.displayToolStripMenuItem.Text = "Display Beat Count";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BeatNum
            // 
            this.BeatNum.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BeatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeatNum.ForeColor = System.Drawing.SystemColors.Window;
            this.BeatNum.Location = new System.Drawing.Point(14, 35);
            this.BeatNum.MaxLength = 16;
            this.BeatNum.Multiline = true;
            this.BeatNum.Name = "BeatNum";
            this.BeatNum.ReadOnly = true;
            this.BeatNum.Size = new System.Drawing.Size(274, 252);
            this.BeatNum.TabIndex = 2;
            this.BeatNum.Text = "1";
            this.BeatNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(12, 399);
            this.trackBar1.Maximum = 240;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(275, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "60 Beats Per Minute";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "000";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 4;
            this.trackBar2.Location = new System.Drawing.Point(12, 494);
            this.trackBar2.Maximum = 32;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(275, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.TickFrequency = 4;
            this.trackBar2.Value = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "4 Beats Per Cycles";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BeatNum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Metronome v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGColorToolStripMenuItem;
        private System.Windows.Forms.TextBox BeatNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem primaryColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accentColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem beatSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem default1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem default2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem default3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
    }
}

