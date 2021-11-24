
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRecord = new System.Windows.Forms.CheckBox();
            this.lblTypeTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(301, 249);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(170, 23);
            this.tbType.TabIndex = 2;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Aquamarine;
            this.btnStart.Location = new System.Drawing.Point(301, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSource
            // 
            this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSource.Location = new System.Drawing.Point(301, 220);
            this.tbSource.Name = "tbSource";
            this.tbSource.ReadOnly = true;
            this.tbSource.Size = new System.Drawing.Size(170, 23);
            this.tbSource.TabIndex = 5;
            this.tbSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbScore.Location = new System.Drawing.Point(239, 279);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(285, 23);
            this.tbScore.TabIndex = 8;
            this.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // cbRecord
            // 
            this.cbRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRecord.AutoSize = true;
            this.cbRecord.ForeColor = System.Drawing.Color.White;
            this.cbRecord.Location = new System.Drawing.Point(288, 308);
            this.cbRecord.Name = "cbRecord";
            this.cbRecord.Size = new System.Drawing.Size(194, 19);
            this.cbRecord.TabIndex = 10;
            this.cbRecord.Text = "Keep tracking of my best record";
            this.cbRecord.UseVisualStyleBackColor = true;
            // 
            // lblTypeTest
            // 
            this.lblTypeTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTypeTest.AutoSize = true;
            this.lblTypeTest.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeTest.ForeColor = System.Drawing.Color.White;
            this.lblTypeTest.Location = new System.Drawing.Point(239, 89);
            this.lblTypeTest.Name = "lblTypeTest";
            this.lblTypeTest.Size = new System.Drawing.Size(289, 62);
            this.lblTypeTest.TabIndex = 11;
            this.lblTypeTest.Text = "TYPING TEST";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTypeTest);
            this.Controls.Add(this.cbRecord);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRecord;
        private System.Windows.Forms.Label lblTypeTest;
    }
}

