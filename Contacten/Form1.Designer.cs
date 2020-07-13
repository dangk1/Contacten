namespace Contacten
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.knopToevoeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.knopAfsluiten = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobiel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotities = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.knopWis = new System.Windows.Forms.Button();
            this.knopWijzig = new System.Windows.Forms.Button();
            this.knopOpslaan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wijzig = new System.Windows.Forms.DataGridViewImageColumn();
            this.wissen = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtID = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.knopToevoeg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.knopAfsluiten);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 67);
            this.panel1.TabIndex = 0;
            // 
            // knopToevoeg
            // 
            this.knopToevoeg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.knopToevoeg.FlatAppearance.BorderSize = 0;
            this.knopToevoeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopToevoeg.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopToevoeg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.knopToevoeg.Location = new System.Drawing.Point(327, 6);
            this.knopToevoeg.Name = "knopToevoeg";
            this.knopToevoeg.Size = new System.Drawing.Size(83, 51);
            this.knopToevoeg.TabIndex = 2;
            this.knopToevoeg.Text = "+";
            this.knopToevoeg.UseVisualStyleBackColor = true;
            this.knopToevoeg.Click += new System.EventHandler(this.knopToevoeg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTACT GEGEVENS";
            // 
            // knopAfsluiten
            // 
            this.knopAfsluiten.FlatAppearance.BorderSize = 0;
            this.knopAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopAfsluiten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAfsluiten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.knopAfsluiten.Location = new System.Drawing.Point(1062, 19);
            this.knopAfsluiten.Name = "knopAfsluiten";
            this.knopAfsluiten.Size = new System.Drawing.Size(91, 23);
            this.knopAfsluiten.TabIndex = 1;
            this.knopAfsluiten.Text = "Afsluiten";
            this.knopAfsluiten.UseVisualStyleBackColor = true;
            this.knopAfsluiten.Click += new System.EventHandler(this.KnopAfsluiten);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VOORNAAM";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(200, 30);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(334, 20);
            this.txtVoornaam.TabIndex = 2;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(200, 67);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(334, 20);
            this.txtAchternaam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ACHTERNAAM";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(200, 143);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(334, 20);
            this.txtPostcode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "POSTCODE";
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(200, 106);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(334, 20);
            this.txtStraat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(26, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "STRAAT EN HUISNUMMER";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "EMAILADRES";
            // 
            // txtMobiel
            // 
            this.txtMobiel.Location = new System.Drawing.Point(200, 256);
            this.txtMobiel.Name = "txtMobiel";
            this.txtMobiel.Size = new System.Drawing.Size(334, 20);
            this.txtMobiel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(26, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "MOBIEL";
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Location = new System.Drawing.Point(200, 217);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(334, 20);
            this.txtTelefoon.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(26, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "TELFOONNUMMER";
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(200, 180);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(334, 20);
            this.txtWoonplaats.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(26, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "WOOPLAATS";
            // 
            // txtNotities
            // 
            this.txtNotities.Location = new System.Drawing.Point(639, 59);
            this.txtNotities.Multiline = true;
            this.txtNotities.Name = "txtNotities";
            this.txtNotities.Size = new System.Drawing.Size(435, 170);
            this.txtNotities.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(636, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "NOTITIES";
            // 
            // knopWis
            // 
            this.knopWis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.knopWis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopWis.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopWis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.knopWis.Location = new System.Drawing.Point(965, 249);
            this.knopWis.Name = "knopWis";
            this.knopWis.Size = new System.Drawing.Size(109, 56);
            this.knopWis.TabIndex = 19;
            this.knopWis.Text = "WISSEN";
            this.knopWis.UseVisualStyleBackColor = false;
            // 
            // knopWijzig
            // 
            this.knopWijzig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopWijzig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopWijzig.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopWijzig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.knopWijzig.Location = new System.Drawing.Point(803, 249);
            this.knopWijzig.Name = "knopWijzig";
            this.knopWijzig.Size = new System.Drawing.Size(109, 56);
            this.knopWijzig.TabIndex = 20;
            this.knopWijzig.Text = "WIJZIGEN";
            this.knopWijzig.UseVisualStyleBackColor = false;
            this.knopWijzig.Click += new System.EventHandler(this.knopWijzig_Click);
            // 
            // knopOpslaan
            // 
            this.knopOpslaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.knopOpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopOpslaan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopOpslaan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.knopOpslaan.Location = new System.Drawing.Point(639, 249);
            this.knopOpslaan.Name = "knopOpslaan";
            this.knopOpslaan.Size = new System.Drawing.Size(109, 56);
            this.knopOpslaan.TabIndex = 21;
            this.knopOpslaan.Text = "OPSLAAN";
            this.knopOpslaan.UseVisualStyleBackColor = false;
            this.knopOpslaan.Click += new System.EventHandler(this.knopOpslaan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column12,
            this.wijzig,
            this.wissen});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(43, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 263);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtZoek
            // 
            this.txtZoek.Location = new System.Drawing.Point(886, 441);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(244, 20);
            this.txtZoek.TabIndex = 24;
            this.txtZoek.TextChanged += new System.EventHandler(this.txtZoek_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(748, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ZOEK OP ACHTERNAAM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.knopOpslaan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtVoornaam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAchternaam);
            this.panel2.Controls.Add(this.knopWijzig);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.knopWis);
            this.panel2.Controls.Add(this.txtStraat);
            this.panel2.Controls.Add(this.txtNotities);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPostcode);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtWoonplaats);
            this.panel2.Controls.Add(this.txtMobiel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelefoon);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(43, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 341);
            this.panel2.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "VOORNAAM";
            this.Column3.Name = "Column3";
            this.Column3.Width = 94;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "ACHTERNAAM";
            this.Column4.Name = "Column4";
            this.Column4.Width = 107;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "STRAAT EN HUISNUMMER";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "POSTCODE";
            this.Column10.Name = "Column10";
            this.Column10.Width = 91;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "WOONPLAATS";
            this.Column6.Name = "Column6";
            this.Column6.Width = 108;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "TEL";
            this.Column7.Name = "Column7";
            this.Column7.Width = 52;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "GSM";
            this.Column8.Name = "Column8";
            this.Column8.Width = 56;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "EMAIL";
            this.Column9.Name = "Column9";
            this.Column9.Width = 64;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            this.Column12.Width = 19;
            // 
            // wijzig
            // 
            this.wijzig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wijzig.HeaderText = "";
            this.wijzig.Image = ((System.Drawing.Image)(resources.GetObject("wijzig.Image")));
            this.wijzig.MinimumWidth = 50;
            this.wijzig.Name = "wijzig";
            this.wijzig.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wijzig.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wijzig.Width = 50;
            // 
            // wissen
            // 
            this.wissen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wissen.HeaderText = "";
            this.wissen.Image = ((System.Drawing.Image)(resources.GetObject("wissen.Image")));
            this.wissen.MinimumWidth = 50;
            this.wissen.Name = "wissen";
            this.wissen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wissen.Width = 50;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtID.Location = new System.Drawing.Point(197, 328);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 22;
            this.txtID.Text = "ID";
            this.txtID.Visible = false;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Copyright.Location = new System.Drawing.Point(1092, 739);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(73, 13);
            this.Copyright.TabIndex = 23;
            this.Copyright.Text = "© Dang Khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtZoek);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button knopAfsluiten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobiel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNotities;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button knopWis;
        private System.Windows.Forms.Button knopWijzig;
        private System.Windows.Forms.Button knopOpslaan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtZoek;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button knopToevoeg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewImageColumn wijzig;
        private System.Windows.Forms.DataGridViewImageColumn wissen;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label Copyright;
    }
}

