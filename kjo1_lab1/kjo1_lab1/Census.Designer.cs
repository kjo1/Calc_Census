namespace kjo1_lab1
{
    partial class Census
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Census));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.lblProRange = new System.Windows.Forms.Label();
            this.lblRegRange = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitle.Location = new System.Drawing.Point(31, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Census Information";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(36, 85);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 13);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "Province ID";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(36, 132);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(55, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region ID";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(39, 184);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(57, 13);
            this.lblPopulation.TabIndex = 3;
            this.lblPopulation.Text = "Population";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(39, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(155, 226);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(24, 274);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(90, 30);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save to File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(155, 274);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(90, 30);
            this.btnClearData.TabIndex = 7;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.BtnClearData_Click);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(106, 181);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(124, 20);
            this.txtPopulation.TabIndex = 3;
            this.txtPopulation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPopulation_KeyPress);
            // 
            // lblProRange
            // 
            this.lblProRange.AutoSize = true;
            this.lblProRange.Location = new System.Drawing.Point(212, 88);
            this.lblProRange.Name = "lblProRange";
            this.lblProRange.Size = new System.Drawing.Size(43, 13);
            this.lblProRange.TabIndex = 11;
            this.lblProRange.Text = "( 0 - 12)";
            // 
            // lblRegRange
            // 
            this.lblRegRange.AutoSize = true;
            this.lblRegRange.Location = new System.Drawing.Point(215, 132);
            this.lblRegRange.Name = "lblRegRange";
            this.lblRegRange.Size = new System.Drawing.Size(43, 13);
            this.lblRegRange.TabIndex = 12;
            this.lblRegRange.Text = "( 0 -47 )";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(106, 82);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 1;
            this.txtProvince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProvince_KeyPress);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(106, 129);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 2;
            this.txtRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegion_KeyPress);
            // 
            // Census
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 324);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.lblRegRange);
            this.Controls.Add(this.lblProRange);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Census";
            this.RightToLeftLayout = true;
            this.Text = "Census";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label lblProRange;
        private System.Windows.Forms.Label lblRegRange;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtRegion;
    }
}

