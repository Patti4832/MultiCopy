namespace MultiCopy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathSource = new System.Windows.Forms.TextBox();
            this.btnSearchSource = new System.Windows.Forms.Button();
            this.btnSearchDest = new System.Windows.Forms.Button();
            this.txtPathDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartCopy = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnShowLog = new System.Windows.Forms.LinkLabel();
            this.cbProgressGet = new System.Windows.Forms.CheckBox();
            this.cbProgressCreated = new System.Windows.Forms.CheckBox();
            this.cbProgressCopied = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quell-Verzeichnis:";
            // 
            // txtPathSource
            // 
            this.txtPathSource.Location = new System.Drawing.Point(109, 12);
            this.txtPathSource.Name = "txtPathSource";
            this.txtPathSource.Size = new System.Drawing.Size(461, 20);
            this.txtPathSource.TabIndex = 1;
            // 
            // btnSearchSource
            // 
            this.btnSearchSource.Location = new System.Drawing.Point(576, 10);
            this.btnSearchSource.Name = "btnSearchSource";
            this.btnSearchSource.Size = new System.Drawing.Size(84, 23);
            this.btnSearchSource.TabIndex = 2;
            this.btnSearchSource.Text = "Durchsuchen";
            this.btnSearchSource.UseVisualStyleBackColor = true;
            this.btnSearchSource.Click += new System.EventHandler(this.btnSearchSource_Click);
            // 
            // btnSearchDest
            // 
            this.btnSearchDest.Location = new System.Drawing.Point(576, 39);
            this.btnSearchDest.Name = "btnSearchDest";
            this.btnSearchDest.Size = new System.Drawing.Size(84, 23);
            this.btnSearchDest.TabIndex = 5;
            this.btnSearchDest.Text = "Durchsuchen";
            this.btnSearchDest.UseVisualStyleBackColor = true;
            this.btnSearchDest.Click += new System.EventHandler(this.btnSearchDest_Click);
            // 
            // txtPathDest
            // 
            this.txtPathDest.Location = new System.Drawing.Point(109, 41);
            this.txtPathDest.Name = "txtPathDest";
            this.txtPathDest.Size = new System.Drawing.Size(461, 20);
            this.txtPathDest.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ziel-Verzeichnis:";
            // 
            // btnStartCopy
            // 
            this.btnStartCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCopy.Location = new System.Drawing.Point(12, 81);
            this.btnStartCopy.Name = "btnStartCopy";
            this.btnStartCopy.Size = new System.Drawing.Size(648, 42);
            this.btnStartCopy.TabIndex = 6;
            this.btnStartCopy.Text = "Kopieren starten";
            this.btnStartCopy.UseVisualStyleBackColor = true;
            this.btnStartCopy.Click += new System.EventHandler(this.btnStartCopy_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 152);
            this.pbProgress.Maximum = 101;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(648, 23);
            this.pbProgress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fortschritt:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 259);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(648, 268);
            this.txtLog.TabIndex = 9;
            // 
            // btnShowLog
            // 
            this.btnShowLog.AutoSize = true;
            this.btnShowLog.Location = new System.Drawing.Point(12, 194);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(71, 13);
            this.btnShowLog.TabIndex = 10;
            this.btnShowLog.TabStop = true;
            this.btnShowLog.Text = "Log anzeigen";
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // cbProgressGet
            // 
            this.cbProgressGet.AutoSize = true;
            this.cbProgressGet.Enabled = false;
            this.cbProgressGet.Location = new System.Drawing.Point(184, 193);
            this.cbProgressGet.Name = "cbProgressGet";
            this.cbProgressGet.Size = new System.Drawing.Size(97, 17);
            this.cbProgressGet.TabIndex = 11;
            this.cbProgressGet.Text = "Dateien erfasst";
            this.cbProgressGet.UseVisualStyleBackColor = true;
            // 
            // cbProgressCreated
            // 
            this.cbProgressCreated.AutoSize = true;
            this.cbProgressCreated.Enabled = false;
            this.cbProgressCreated.Location = new System.Drawing.Point(355, 193);
            this.cbProgressCreated.Name = "cbProgressCreated";
            this.cbProgressCreated.Size = new System.Drawing.Size(91, 17);
            this.cbProgressCreated.TabIndex = 12;
            this.cbProgressCreated.Text = "Ordner erstellt";
            this.cbProgressCreated.UseVisualStyleBackColor = true;
            // 
            // cbProgressCopied
            // 
            this.cbProgressCopied.AutoSize = true;
            this.cbProgressCopied.Enabled = false;
            this.cbProgressCopied.Location = new System.Drawing.Point(562, 193);
            this.cbProgressCopied.Name = "cbProgressCopied";
            this.cbProgressCopied.Size = new System.Drawing.Size(98, 17);
            this.cbProgressCopied.TabIndex = 13;
            this.cbProgressCopied.Text = "Dateien kopiert";
            this.cbProgressCopied.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 222);
            this.Controls.Add(this.cbProgressCopied);
            this.Controls.Add(this.cbProgressCreated);
            this.Controls.Add(this.cbProgressGet);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnStartCopy);
            this.Controls.Add(this.btnSearchDest);
            this.Controls.Add(this.txtPathDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchSource);
            this.Controls.Add(this.txtPathSource);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(699, 583);
            this.MinimumSize = new System.Drawing.Size(699, 261);
            this.Name = "Form1";
            this.Text = "MultiCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathSource;
        private System.Windows.Forms.Button btnSearchSource;
        private System.Windows.Forms.Button btnSearchDest;
        private System.Windows.Forms.TextBox txtPathDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartCopy;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.LinkLabel btnShowLog;
        internal System.Windows.Forms.CheckBox cbProgressGet;
        internal System.Windows.Forms.CheckBox cbProgressCreated;
        internal System.Windows.Forms.CheckBox cbProgressCopied;
    }
}

