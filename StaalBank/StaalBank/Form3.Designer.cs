namespace StaalBank
{
    partial class Form3
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
            this.lblLoad = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(13, 13);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(85, 13);
            this.lblLoad.TabIndex = 0;
            this.lblLoad.Text = "File to load path:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(180, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(105, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(319, 20);
            this.txtPath.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 81);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblLoad);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPath;
    }
}