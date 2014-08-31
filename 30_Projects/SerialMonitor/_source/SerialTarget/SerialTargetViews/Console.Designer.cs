namespace De.Bitmarker.Target.Serial.Views
{
    partial class Console
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialOutput
            // 
            this.serialOutput.Location = new System.Drawing.Point(3, 3);
            this.serialOutput.Multiline = true;
            this.serialOutput.Name = "serialOutput";
            this.serialOutput.ReadOnly = true;
            this.serialOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serialOutput.Size = new System.Drawing.Size(837, 320);
            this.serialOutput.TabIndex = 0;
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serialOutput);
            this.Name = "Console";
            this.Size = new System.Drawing.Size(843, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serialOutput;
    }
}
