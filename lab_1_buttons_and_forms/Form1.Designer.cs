
namespace lab_1_buttons_and_forms
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbType = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.rbDarkMode = new System.Windows.Forms.RadioButton();
            this.rbLightMode = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbBackColor = new System.Windows.Forms.ComboBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(239, 249);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(285, 23);
            this.tbType.TabIndex = 2;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbType, "Typing field");
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(239, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(285, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.toolTip1.SetToolTip(this.btnStart, "Press and Start typing for the test");
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSource
            // 
            this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSource.Location = new System.Drawing.Point(239, 220);
            this.tbSource.Name = "tbSource";
            this.tbSource.ReadOnly = true;
            this.tbSource.Size = new System.Drawing.Size(285, 23);
            this.tbSource.TabIndex = 5;
            this.tbSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbSource, "Typing test words");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoEllipsis = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(367, 151);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(58, 37);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "0";
            // 
            // tbScore
            // 
            this.tbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScore.Location = new System.Drawing.Point(290, 279);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(234, 23);
            this.tbScore.TabIndex = 8;
            this.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(239, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 62);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "TYPING TEST";
            // 
            // pbTimer
            // 
            this.pbTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbTimer.Location = new System.Drawing.Point(239, 125);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(285, 23);
            this.pbTimer.TabIndex = 12;
            // 
            // rbDarkMode
            // 
            this.rbDarkMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDarkMode.AutoSize = true;
            this.rbDarkMode.ForeColor = System.Drawing.Color.White;
            this.rbDarkMode.Location = new System.Drawing.Point(301, 309);
            this.rbDarkMode.Name = "rbDarkMode";
            this.rbDarkMode.Size = new System.Drawing.Size(83, 19);
            this.rbDarkMode.TabIndex = 13;
            this.rbDarkMode.TabStop = true;
            this.rbDarkMode.Text = "Dark mode";
            this.toolTip1.SetToolTip(this.rbDarkMode, "make programm theme iin dark mode");
            this.rbDarkMode.UseVisualStyleBackColor = true;
            this.rbDarkMode.Click += new System.EventHandler(this.rbDarkMode_Click);
            // 
            // rbLightMode
            // 
            this.rbLightMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbLightMode.AutoSize = true;
            this.rbLightMode.ForeColor = System.Drawing.Color.White;
            this.rbLightMode.Location = new System.Drawing.Point(385, 309);
            this.rbLightMode.Name = "rbLightMode";
            this.rbLightMode.Size = new System.Drawing.Size(86, 19);
            this.rbLightMode.TabIndex = 14;
            this.rbLightMode.TabStop = true;
            this.rbLightMode.Text = "Light mode";
            this.toolTip1.SetToolTip(this.rbLightMode, "make programm theme light mode");
            this.rbLightMode.UseVisualStyleBackColor = true;
            this.rbLightMode.Click += new System.EventHandler(this.rbLightMode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.Location = new System.Drawing.Point(239, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save your records");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbBackColor
            // 
            this.cbBackColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbBackColor.FormattingEnabled = true;
            this.cbBackColor.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "brown"});
            this.cbBackColor.Location = new System.Drawing.Point(544, 191);
            this.cbBackColor.Name = "cbBackColor";
            this.cbBackColor.Size = new System.Drawing.Size(121, 23);
            this.cbBackColor.TabIndex = 16;
            this.cbBackColor.Text = "Background color";
            this.toolTip1.SetToolTip(this.cbBackColor, "change the background color");
            this.cbBackColor.TextChanged += new System.EventHandler(this.cbBackColor_TextChanged);
            // 
            // cbDefault
            // 
            this.cbDefault.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbDefault.AutoSize = true;
            this.cbDefault.ForeColor = System.Drawing.Color.White;
            this.cbDefault.Location = new System.Drawing.Point(544, 221);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(108, 19);
            this.cbDefault.TabIndex = 17;
            this.cbDefault.Text = "Defualt settings";
            this.toolTip1.SetToolTip(this.cbDefault, "return the programm to default settings");
            this.cbDefault.UseVisualStyleBackColor = true;
            this.cbDefault.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDefault);
            this.Controls.Add(this.cbBackColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbLightMode);
            this.Controls.Add(this.rbDarkMode);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbType);
            this.Name = "formMain";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.RadioButton rbDarkMode;
        private System.Windows.Forms.RadioButton rbLightMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbBackColor;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

