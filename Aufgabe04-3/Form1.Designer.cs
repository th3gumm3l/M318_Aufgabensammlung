namespace Aufgabe04_3
{
    partial class FormA043
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NewBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_time,
            this.Column_Change,
            this.Column_NewBalance});
            this.dataGridView1.Location = new System.Drawing.Point(47, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(805, 826);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column_time
            // 
            this.Column_time.HeaderText = "Time";
            this.Column_time.MinimumWidth = 10;
            this.Column_time.Name = "Column_time";
            this.Column_time.ReadOnly = true;
            this.Column_time.Width = 200;
            // 
            // Column_Change
            // 
            this.Column_Change.HeaderText = "Change";
            this.Column_Change.MinimumWidth = 10;
            this.Column_Change.Name = "Column_Change";
            this.Column_Change.ReadOnly = true;
            this.Column_Change.Width = 200;
            // 
            // Column_NewBalance
            // 
            this.Column_NewBalance.HeaderText = "New Balance";
            this.Column_NewBalance.MinimumWidth = 10;
            this.Column_NewBalance.Name = "Column_NewBalance";
            this.Column_NewBalance.ReadOnly = true;
            this.Column_NewBalance.Width = 200;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(356, 131);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(0, 25);
            this.lbl_Balance.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Balance:";
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(667, 124);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(185, 39);
            this.btn_Withdraw.TabIndex = 16;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(667, 65);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(185, 39);
            this.btn_Deposit.TabIndex = 15;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(343, 65);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 31);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount:";
            // 
            // FormA043
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 1124);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "FormA043";
            this.Text = "Aufgabe04-3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NewBalance;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

