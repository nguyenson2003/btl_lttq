namespace PlayerUI
{
    partial class FormShowVideo
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
            this.flpContain = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flpContain
            // 
            this.flpContain.AutoScroll = true;
            this.flpContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContain.Location = new System.Drawing.Point(0, 0);
            this.flpContain.Margin = new System.Windows.Forms.Padding(0);
            this.flpContain.Name = "flpContain";
            this.flpContain.Size = new System.Drawing.Size(399, 440);
            this.flpContain.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormShowVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(399, 440);
            this.Controls.Add(this.flpContain);
            this.Name = "FormShowVideo";
            this.Text = "FormShowVideo";
            this.Load += new System.EventHandler(this.FormShowVideo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContain;
        private System.Windows.Forms.Timer timer1;
    }
}