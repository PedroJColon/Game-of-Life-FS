
namespace Game_of_Life
{
    partial class CustomizeUniverse
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.HeightUniverse = new System.Windows.Forms.NumericUpDown();
            this.WidthUniverse = new System.Windows.Forms.NumericUpDown();
            this.MillSecondTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUniverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUniverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MillSecondTime)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(153, 242);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(285, 242);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // HeightUniverse
            // 
            this.HeightUniverse.Location = new System.Drawing.Point(285, 54);
            this.HeightUniverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightUniverse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightUniverse.Name = "HeightUniverse";
            this.HeightUniverse.Size = new System.Drawing.Size(120, 22);
            this.HeightUniverse.TabIndex = 2;
            this.HeightUniverse.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // WidthUniverse
            // 
            this.WidthUniverse.Location = new System.Drawing.Point(285, 100);
            this.WidthUniverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthUniverse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthUniverse.Name = "WidthUniverse";
            this.WidthUniverse.Size = new System.Drawing.Size(120, 22);
            this.WidthUniverse.TabIndex = 3;
            this.WidthUniverse.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MillSecondTime
            // 
            this.MillSecondTime.Location = new System.Drawing.Point(285, 146);
            this.MillSecondTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MillSecondTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MillSecondTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MillSecondTime.Name = "MillSecondTime";
            this.MillSecondTime.Size = new System.Drawing.Size(120, 22);
            this.MillSecondTime.TabIndex = 4;
            this.MillSecondTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change Height of Universe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Width of Universe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change Millsecond Time of Universe:";
            // 
            // CustomizeUniverse
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MillSecondTime);
            this.Controls.Add(this.WidthUniverse);
            this.Controls.Add(this.HeightUniverse);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeUniverse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customize Universe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomizeUniverse_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.HeightUniverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUniverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MillSecondTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown HeightUniverse;
        private System.Windows.Forms.NumericUpDown WidthUniverse;
        private System.Windows.Forms.NumericUpDown MillSecondTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}