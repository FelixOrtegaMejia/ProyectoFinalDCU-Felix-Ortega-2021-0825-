namespace ProyectoFinalDCU_Felix_Ortega_2021_0825_
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dcufinalDataSet = new ProyectoFinalDCU_Felix_Ortega_2021_0825_.dcufinalDataSet();
            this.datosTableAdapter = new ProyectoFinalDCU_Felix_Ortega_2021_0825_.dcufinalDataSetTableAdapters.datosTableAdapter();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pictobox = new System.Windows.Forms.PictureBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcufinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictobox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 33);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1076, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "--->";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1080, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 26);
            this.button4.TabIndex = 8;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DCU-Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(24, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(27, 357);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(166, 20);
            this.txtcorreo.TabIndex = 8;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(27, 416);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(166, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(27, 299);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(166, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(27, 240);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 20);
            this.txtid.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(24, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.textoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 361);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "texto";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "datos";
            this.datosBindingSource.DataSource = this.dcufinalDataSet;
            // 
            // dcufinalDataSet
            // 
            this.dcufinalDataSet.DataSetName = "dcufinalDataSet";
            this.dcufinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(730, 486);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 36);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Location = new System.Drawing.Point(605, 486);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnupdate.Size = new System.Drawing.Size(96, 36);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Actualizar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Location = new System.Drawing.Point(477, 486);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(96, 36);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Buscar";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(351, 486);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 36);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Añadir";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pictobox
            // 
            this.pictobox.BackgroundImage = global::ProyectoFinalDCU_Felix_Ortega_2021_0825_.Properties.Resources.Invitado;
            this.pictobox.Location = new System.Drawing.Point(68, 61);
            this.pictobox.Name = "pictobox";
            this.pictobox.Size = new System.Drawing.Size(100, 100);
            this.pictobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictobox.TabIndex = 22;
            this.pictobox.TabStop = false;
            this.pictobox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Location = new System.Drawing.Point(68, 182);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(100, 19);
            this.btnfoto.TabIndex = 23;
            this.btnfoto.Text = "Subir Foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(27, 475);
            this.txttexto.Multiline = true;
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(194, 96);
            this.txttexto.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(24, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Texto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(975, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1111, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.pictobox);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcufinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dcufinalDataSet dcufinalDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private dcufinalDataSetTableAdapters.datosTableAdapter datosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pictobox;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}