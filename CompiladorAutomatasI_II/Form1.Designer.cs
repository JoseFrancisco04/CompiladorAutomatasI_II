namespace CompiladorAutomatasI_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConsole = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelCode = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.RichTextBox();
            this.panelConsole.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsole
            // 
            this.panelConsole.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelConsole.Controls.Add(this.tbConsole);
            this.panelConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsole.Location = new System.Drawing.Point(0, 242);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(684, 119);
            this.panelConsole.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnStart);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(684, 35);
            this.panelControl.TabIndex = 1;
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.tbCode);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCode.Location = new System.Drawing.Point(0, 35);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(684, 207);
            this.panelCode.TabIndex = 2;
            // 
            // tbCode
            // 
            this.tbCode.AcceptsTab = true;
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.tbCode.Location = new System.Drawing.Point(0, 0);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(684, 207);
            this.tbCode.TabIndex = 0;
            this.tbCode.Text = "Test Text";
            this.tbCode.WordWrap = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(306, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "|>";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsole.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.tbConsole.Location = new System.Drawing.Point(0, 0);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(684, 119);
            this.tbConsole.TabIndex = 0;
            this.tbConsole.Text = "Test Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelConsole);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pseudocódigo Lupiliano";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelConsole.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsole;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.RichTextBox tbCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox tbConsole;
    }
}

