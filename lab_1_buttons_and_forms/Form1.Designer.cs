
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
            this.tbType = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(301, 249);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(170, 23);
            this.tbType.TabIndex = 2;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(301, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(301, 220);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(170, 23);
            this.tbSource.TabIndex = 5;
            this.tbSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(383, 275);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 15);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
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
        private System.Windows.Forms.Label lblScore;
    }
}

