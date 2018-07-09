namespace PersonalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.dPersonal = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ålder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smeknamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnRadera = new System.Windows.Forms.Button();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(86, 207);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(97, 32);
            this.btnSpara.TabIndex = 1;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(218, 80);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(160, 20);
            this.txtNamn.TabIndex = 2;
            // 
            // dPersonal
            // 
            this.dPersonal.AllowUserToDeleteRows = false;
            this.dPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.Namn,
            this.Ålder,
            this.Smeknamn,
            this.Datum});
            this.dPersonal.Location = new System.Drawing.Point(44, 257);
            this.dPersonal.Name = "dPersonal";
            this.dPersonal.ReadOnly = true;
            this.dPersonal.Size = new System.Drawing.Size(574, 519);
            this.dPersonal.TabIndex = 3;
            this.dPersonal.DoubleClick += new System.EventHandler(this.dPersonal_DoubleClick);
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "Id";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // Namn
            // 
            this.Namn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namn.DataPropertyName = "Namn";
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            // 
            // Ålder
            // 
            this.Ålder.DataPropertyName = "Ålder";
            this.Ålder.HeaderText = "Ålder";
            this.Ålder.Name = "Ålder";
            this.Ålder.ReadOnly = true;
            // 
            // Smeknamn
            // 
            this.Smeknamn.DataPropertyName = "Smeknamn";
            this.Smeknamn.HeaderText = "Smeknamn";
            this.Smeknamn.Name = "Smeknamn";
            this.Smeknamn.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ålder";
            // 
            // txtAlder
            // 
            this.txtAlder.Location = new System.Drawing.Point(218, 106);
            this.txtAlder.Name = "txtAlder";
            this.txtAlder.Size = new System.Drawing.Size(160, 20);
            this.txtAlder.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Smeknamn";
            // 
            // txtSmek
            // 
            this.txtSmek.Location = new System.Drawing.Point(218, 132);
            this.txtSmek.Name = "txtSmek";
            this.txtSmek.Size = new System.Drawing.Size(160, 20);
            this.txtSmek.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(458, 110);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(160, 20);
            this.txtDatum.TabIndex = 2;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(292, 207);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(97, 32);
            this.btnAvbryt.TabIndex = 1;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnRadera
            // 
            this.btnRadera.Location = new System.Drawing.Point(189, 207);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(97, 32);
            this.btnRadera.TabIndex = 1;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click_1);
            // 
            // dtPick
            // 
            this.dtPick.CustomFormat = "yyyy-MM-dd";
            this.dtPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPick.Location = new System.Drawing.Point(218, 159);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(160, 20);
            this.dtPick.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 710);
            this.Controls.Add(this.dtPick);
            this.Controls.Add(this.dPersonal);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtSmek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PersonalRegister";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.DataGridView dPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSmek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ålder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smeknamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DateTimePicker dtPick;
    }
}

