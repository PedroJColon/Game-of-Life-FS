
namespace Game_of_Life
{
    partial class RandomizeUniverse
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
            this.SeedValue = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SeedRandomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // SeedValue
            // 
            this.SeedValue.Location = new System.Drawing.Point(231, 107);
            this.SeedValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SeedValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SeedValue.Name = "SeedValue";
            this.SeedValue.Size = new System.Drawing.Size(120, 22);
            this.SeedValue.TabIndex = 1;
            this.SeedValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(130, 214);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(231, 214);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SeedRandomLabel
            // 
            this.SeedRandomLabel.AutoSize = true;
            this.SeedRandomLabel.Location = new System.Drawing.Point(64, 109);
            this.SeedRandomLabel.Name = "SeedRandomLabel";
            this.SeedRandomLabel.Size = new System.Drawing.Size(145, 17);
            this.SeedRandomLabel.TabIndex = 4;
            this.SeedRandomLabel.Text = "Seed To Randomize: ";
            // 
            // RandomizeUniverse
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(461, 268);
            this.Controls.Add(this.SeedRandomLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SeedValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RandomizeUniverse";
            this.Text = "Randomize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomizeUniverse_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SeedValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown SeedValue;
        private System.Windows.Forms.Button OkButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label SeedRandomLabel;
    }
}