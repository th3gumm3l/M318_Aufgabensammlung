namespace Aufgabe01
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
            this.tbx_Eingabe = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_Ausgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbx_Eingabe
            // 
            this.tbx_Eingabe.Location = new System.Drawing.Point(113, 40);
            this.tbx_Eingabe.Name = "tbx_Eingabe";
            this.tbx_Eingabe.Size = new System.Drawing.Size(342, 31);
            this.tbx_Eingabe.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(497, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(130, 31);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // lbx_Ausgabe
            // 
            this.lbx_Ausgabe.FormattingEnabled = true;
            this.lbx_Ausgabe.ItemHeight = 25;
            this.lbx_Ausgabe.Location = new System.Drawing.Point(52, 106);
            this.lbx_Ausgabe.Name = "lbx_Ausgabe";
            this.lbx_Ausgabe.Size = new System.Drawing.Size(576, 279);
            this.lbx_Ausgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 448);
            this.Controls.Add(this.lbx_Ausgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_Eingabe);
            this.Name = "Form1";
            this.Text = "Aufgabe01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Eingabe;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_Ausgabe;
    }
}

