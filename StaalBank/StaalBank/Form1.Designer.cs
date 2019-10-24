namespace StaalBank
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnLoadFileForm = new System.Windows.Forms.Button();
            this.lblLoadFile = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 15);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(104, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(172, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(13, 48);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(84, 13);
            this.lblCharacterName.TabIndex = 2;
            this.lblCharacterName.Text = "Character Name";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(104, 48);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(172, 20);
            this.txtCharacterName.TabIndex = 3;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(291, 51);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race";
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(330, 48);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(130, 20);
            this.txtRace.TabIndex = 5;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(476, 51);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(514, 48);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(139, 20);
            this.txtClass.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(36, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height (cm)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(104, 89);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 20);
            this.txtHeight.TabIndex = 9;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(256, 89);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(68, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(188, 92);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 13);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(16, 160);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(106, 13);
            this.lblInventory.TabIndex = 12;
            this.lblInventory.Text = "INVENTORY ITEMS";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(19, 370);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(19, 177);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(634, 187);
            this.txtInventory.TabIndex = 15;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(13, 456);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(109, 13);
            this.lblPrompt.TabIndex = 16;
            this.lblPrompt.Text = "Need to create a file?";
            // 
            // btnLoadFileForm
            // 
            this.btnLoadFileForm.Location = new System.Drawing.Point(128, 451);
            this.btnLoadFileForm.Name = "btnLoadFileForm";
            this.btnLoadFileForm.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileForm.TabIndex = 17;
            this.btnLoadFileForm.Text = "Click here!";
            this.btnLoadFileForm.UseVisualStyleBackColor = true;
            this.btnLoadFileForm.Click += new System.EventHandler(this.btnLoadFileForm_Click);
            // 
            // lblLoadFile
            // 
            this.lblLoadFile.AutoSize = true;
            this.lblLoadFile.Location = new System.Drawing.Point(215, 456);
            this.lblLoadFile.Name = "lblLoadFile";
            this.lblLoadFile.Size = new System.Drawing.Size(99, 13);
            this.lblLoadFile.TabIndex = 18;
            this.lblLoadFile.Text = "Need to load a file?";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(330, 451);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 19;
            this.btnLoadFile.Text = "Click here!";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 481);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.lblLoadFile);
            this.Controls.Add(this.btnLoadFileForm);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "Form1";
            this.Text = "StaalBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnLoadFileForm;
        private System.Windows.Forms.Label lblLoadFile;
        private System.Windows.Forms.Button btnLoadFile;
        public System.Windows.Forms.TextBox txtPlayerName;
    }
}

