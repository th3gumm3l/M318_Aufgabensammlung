namespace Aufgabe02
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
            this.cmb_Items = new System.Windows.Forms.ComboBox();
            this.btn_toAusgabe = new System.Windows.Forms.Button();
            this.btn_toItems = new System.Windows.Forms.Button();
            this.lbx_Ausgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_Items
            // 
            this.cmb_Items.FormattingEnabled = true;
            this.cmb_Items.Items.AddRange(new object[] {
            "Konfi",
            "Kaffee",
            "Butter",
            "Banane",
            "Brot",
            "Käse",
            "Apfel",
            "Müesli"});
            this.cmb_Items.Location = new System.Drawing.Point(71, 122);
            this.cmb_Items.Name = "cmb_Items";
            this.cmb_Items.Size = new System.Drawing.Size(423, 33);
            this.cmb_Items.TabIndex = 0;
            this.cmb_Items.SelectedIndexChanged += new System.EventHandler(this.cmb_Items_SelectedIndexChanged);
            // 
            // btn_toAusgabe
            // 
            this.btn_toAusgabe.Enabled = false;
            this.btn_toAusgabe.Location = new System.Drawing.Point(605, 106);
            this.btn_toAusgabe.Name = "btn_toAusgabe";
            this.btn_toAusgabe.Size = new System.Drawing.Size(185, 63);
            this.btn_toAusgabe.TabIndex = 1;
            this.btn_toAusgabe.Text = ">>";
            this.btn_toAusgabe.UseVisualStyleBackColor = true;
            this.btn_toAusgabe.Click += new System.EventHandler(this.btn_toAusgabe_Click);
            // 
            // btn_toItems
            // 
            this.btn_toItems.Enabled = false;
            this.btn_toItems.Location = new System.Drawing.Point(605, 206);
            this.btn_toItems.Name = "btn_toItems";
            this.btn_toItems.Size = new System.Drawing.Size(185, 58);
            this.btn_toItems.TabIndex = 2;
            this.btn_toItems.Text = "<<";
            this.btn_toItems.UseVisualStyleBackColor = true;
            this.btn_toItems.Click += new System.EventHandler(this.btn_toItems_Click);
            // 
            // lbx_Ausgabe
            // 
            this.lbx_Ausgabe.FormattingEnabled = true;
            this.lbx_Ausgabe.ItemHeight = 25;
            this.lbx_Ausgabe.Location = new System.Drawing.Point(867, 106);
            this.lbx_Ausgabe.Name = "lbx_Ausgabe";
            this.lbx_Ausgabe.Size = new System.Drawing.Size(504, 454);
            this.lbx_Ausgabe.TabIndex = 3;
            this.lbx_Ausgabe.SelectedIndexChanged += new System.EventHandler(this.lbx_Ausgabe_SelectedIndexChanged);
            this.lbx_Ausgabe.DoubleClick += new System.EventHandler(this.lbx_Ausgabe_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 668);
            this.Controls.Add(this.lbx_Ausgabe);
            this.Controls.Add(this.btn_toItems);
            this.Controls.Add(this.btn_toAusgabe);
            this.Controls.Add(this.cmb_Items);
            this.Name = "Form1";
            this.Text = "Aufgabe02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Items;
        private System.Windows.Forms.Button btn_toAusgabe;
        private System.Windows.Forms.Button btn_toItems;
        private System.Windows.Forms.ListBox lbx_Ausgabe;
    }
}

