namespace RegexTool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtBxRegex = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTxtBxInput = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.rTxtBxExtract = new System.Windows.Forms.RichTextBox();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.rTxtBxReplace = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rTbxPattern = new System.Windows.Forms.RichTextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkBxAutoMatch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageExtract.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtBxRegex);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regex";
            // 
            // rtxtBxRegex
            // 
            this.rtxtBxRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtBxRegex.Location = new System.Drawing.Point(7, 20);
            this.rtxtBxRegex.Name = "rtxtBxRegex";
            this.rtxtBxRegex.Size = new System.Drawing.Size(532, 84);
            this.rtxtBxRegex.TabIndex = 0;
            this.rtxtBxRegex.Text = "";
            this.rtxtBxRegex.TextChanged += new System.EventHandler(this.rtxtBxRegex_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rTxtBxInput);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Text";
            // 
            // rTxtBxInput
            // 
            this.rTxtBxInput.Location = new System.Drawing.Point(7, 19);
            this.rTxtBxInput.Name = "rTxtBxInput";
            this.rTxtBxInput.Size = new System.Drawing.Size(532, 295);
            this.rTxtBxInput.TabIndex = 0;
            this.rTxtBxInput.Text = "";
            this.rTxtBxInput.TextChanged += new System.EventHandler(this.rTxtBxInput_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageExtract);
            this.tabControl1.Controls.Add(this.tabPageReplace);
            this.tabControl1.Location = new System.Drawing.Point(564, 158);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 320);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageExtract
            // 
            this.tabPageExtract.Controls.Add(this.rTxtBxExtract);
            this.tabPageExtract.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtract.Name = "tabPageExtract";
            this.tabPageExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtract.Size = new System.Drawing.Size(420, 294);
            this.tabPageExtract.TabIndex = 0;
            this.tabPageExtract.Text = "Extract";
            this.tabPageExtract.UseVisualStyleBackColor = true;
            // 
            // rTxtBxExtract
            // 
            this.rTxtBxExtract.Location = new System.Drawing.Point(7, 7);
            this.rTxtBxExtract.Name = "rTxtBxExtract";
            this.rTxtBxExtract.ReadOnly = true;
            this.rTxtBxExtract.Size = new System.Drawing.Size(407, 281);
            this.rTxtBxExtract.TabIndex = 0;
            this.rTxtBxExtract.Text = "";
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.rTxtBxReplace);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 22);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReplace.Size = new System.Drawing.Size(420, 294);
            this.tabPageReplace.TabIndex = 1;
            this.tabPageReplace.Text = "Replace";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // rTxtBxReplace
            // 
            this.rTxtBxReplace.Location = new System.Drawing.Point(7, 7);
            this.rTxtBxReplace.Name = "rTxtBxReplace";
            this.rTxtBxReplace.ReadOnly = true;
            this.rTxtBxReplace.Size = new System.Drawing.Size(407, 281);
            this.rTxtBxReplace.TabIndex = 0;
            this.rTxtBxReplace.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rTbxPattern);
            this.groupBox3.Location = new System.Drawing.Point(575, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Pattern";
            // 
            // rTbxPattern
            // 
            this.rTbxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rTbxPattern.Location = new System.Drawing.Point(7, 20);
            this.rTbxPattern.Name = "rTbxPattern";
            this.rTbxPattern.Size = new System.Drawing.Size(394, 78);
            this.rTbxPattern.TabIndex = 0;
            this.rTbxPattern.Text = "";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(13, 13);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count : ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(144, 18);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0";
            // 
            // chkBxAutoMatch
            // 
            this.chkBxAutoMatch.AutoSize = true;
            this.chkBxAutoMatch.Location = new System.Drawing.Point(208, 17);
            this.chkBxAutoMatch.Name = "chkBxAutoMatch";
            this.chkBxAutoMatch.Size = new System.Drawing.Size(81, 17);
            this.chkBxAutoMatch.TabIndex = 7;
            this.chkBxAutoMatch.Text = "Auto Match";
            this.chkBxAutoMatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 488);
            this.Controls.Add(this.chkBxAutoMatch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageExtract.ResumeLayout(false);
            this.tabPageReplace.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtBxRegex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rTxtBxInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageExtract;
        private System.Windows.Forms.RichTextBox rTxtBxExtract;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.RichTextBox rTxtBxReplace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rTbxPattern;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkBxAutoMatch;
    }
}

