namespace BPS.Lite
{
    partial class frmProductionControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grbActividadActual = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActividad = new System.Windows.Forms.Label();
            this.grbTiempoTranscurrido = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.grbCambiarActividad = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreparacion = new System.Windows.Forms.Button();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.btnMaquinaParada = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grbActividadesRealizadas = new System.Windows.Forms.GroupBox();
            this.dgvActividadesRealizadas = new System.Windows.Forms.DataGridView();
            this.actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grbPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grbActividadActual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grbTiempoTranscurrido.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.grbCambiarActividad.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbActividadesRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadesRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grbPrincipal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbActividadActual, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbCambiarActividad, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbActividadesRealizadas, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.grbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPrincipal.Location = new System.Drawing.Point(3, 3);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(1135, 41);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1129, 22);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Producción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "General Vacuum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(679, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "A";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operador:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(1017, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Operador";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbActividadActual
            // 
            this.grbActividadActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grbActividadActual.Controls.Add(this.groupBox1);
            this.grbActividadActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbActividadActual.Location = new System.Drawing.Point(3, 50);
            this.grbActividadActual.Name = "grbActividadActual";
            this.grbActividadActual.Size = new System.Drawing.Size(1135, 232);
            this.grbActividadActual.TabIndex = 1;
            this.grbActividadActual.TabStop = false;
            this.grbActividadActual.Text = "Actividad actual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 213);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1123, 194);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblActividad, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.grbTiempoTranscurrido, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1117, 52);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(3, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(552, 52);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "label5";
            // 
            // grbTiempoTranscurrido
            // 
            this.grbTiempoTranscurrido.Controls.Add(this.tableLayoutPanel6);
            this.grbTiempoTranscurrido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTiempoTranscurrido.Location = new System.Drawing.Point(561, 3);
            this.grbTiempoTranscurrido.Name = "grbTiempoTranscurrido";
            this.grbTiempoTranscurrido.Size = new System.Drawing.Size(553, 46);
            this.grbTiempoTranscurrido.TabIndex = 7;
            this.grbTiempoTranscurrido.TabStop = false;
            this.grbTiempoTranscurrido.Text = "Tiempo transcurrido";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.txtHoras, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtMinutos, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSegundos, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(547, 27);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // txtHoras
            // 
            this.txtHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(3, 3);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(158, 38);
            this.txtHoras.TabIndex = 2;
            this.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = ":";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(194, 3);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(158, 38);
            this.txtMinutos.TabIndex = 3;
            this.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundos.Location = new System.Drawing.Point(385, 3);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(159, 38);
            this.txtSegundos.TabIndex = 5;
            this.txtSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // grbCambiarActividad
            // 
            this.grbCambiarActividad.Controls.Add(this.tableLayoutPanel3);
            this.grbCambiarActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCambiarActividad.Location = new System.Drawing.Point(3, 288);
            this.grbCambiarActividad.Name = "grbCambiarActividad";
            this.grbCambiarActividad.Size = new System.Drawing.Size(1135, 65);
            this.grbCambiarActividad.TabIndex = 2;
            this.grbCambiarActividad.TabStop = false;
            this.grbCambiarActividad.Text = "Cambiar actividad actual";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnPreparacion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnProduccion, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMaquinaParada, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1129, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnPreparacion
            // 
            this.btnPreparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPreparacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreparacion.Location = new System.Drawing.Point(3, 3);
            this.btnPreparacion.Name = "btnPreparacion";
            this.btnPreparacion.Size = new System.Drawing.Size(276, 40);
            this.btnPreparacion.TabIndex = 0;
            this.btnPreparacion.Text = "Preparación";
            this.btnPreparacion.UseVisualStyleBackColor = false;
            this.btnPreparacion.Click += new System.EventHandler(this.btnPreparacion_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduccion.Location = new System.Drawing.Point(285, 3);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(276, 40);
            this.btnProduccion.TabIndex = 1;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.UseVisualStyleBackColor = false;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // btnMaquinaParada
            // 
            this.btnMaquinaParada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMaquinaParada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaquinaParada.Location = new System.Drawing.Point(567, 3);
            this.btnMaquinaParada.Name = "btnMaquinaParada";
            this.btnMaquinaParada.Size = new System.Drawing.Size(276, 40);
            this.btnMaquinaParada.TabIndex = 2;
            this.btnMaquinaParada.Text = "Máquina parada";
            this.btnMaquinaParada.UseVisualStyleBackColor = false;
            this.btnMaquinaParada.Click += new System.EventHandler(this.btnMaquinaParada_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(849, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(277, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fin del turno";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // grbActividadesRealizadas
            // 
            this.grbActividadesRealizadas.Controls.Add(this.dgvActividadesRealizadas);
            this.grbActividadesRealizadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbActividadesRealizadas.Location = new System.Drawing.Point(3, 359);
            this.grbActividadesRealizadas.Name = "grbActividadesRealizadas";
            this.grbActividadesRealizadas.Size = new System.Drawing.Size(1135, 115);
            this.grbActividadesRealizadas.TabIndex = 3;
            this.grbActividadesRealizadas.TabStop = false;
            this.grbActividadesRealizadas.Text = "Actividades realizadas en el turno";
            // 
            // dgvActividadesRealizadas
            // 
            this.dgvActividadesRealizadas.AllowUserToAddRows = false;
            this.dgvActividadesRealizadas.AllowUserToDeleteRows = false;
            this.dgvActividadesRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividadesRealizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actividad,
            this.detalle,
            this.orden,
            this.observaciones,
            this.desde,
            this.hasta});
            this.dgvActividadesRealizadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActividadesRealizadas.Location = new System.Drawing.Point(3, 16);
            this.dgvActividadesRealizadas.Name = "dgvActividadesRealizadas";
            this.dgvActividadesRealizadas.ReadOnly = true;
            this.dgvActividadesRealizadas.Size = new System.Drawing.Size(1129, 96);
            this.dgvActividadesRealizadas.TabIndex = 0;
            // 
            // actividad
            // 
            this.actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actividad.HeaderText = "Actividad";
            this.actividad.Name = "actividad";
            this.actividad.ReadOnly = true;
            this.actividad.Width = 76;
            // 
            // detalle
            // 
            this.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 65;
            // 
            // orden
            // 
            this.orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orden.HeaderText = "Orden de producción";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Width = 121;
            // 
            // observaciones
            // 
            this.observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 103;
            // 
            // desde
            // 
            this.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            this.desde.Width = 63;
            // 
            // hasta
            // 
            this.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            this.hasta.Width = 60;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProductionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmProductionControl";
            this.ShowIcon = false;
            this.Text = "Control de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grbActividadActual.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.grbTiempoTranscurrido.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.grbCambiarActividad.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbActividadesRealizadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadesRealizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grbActividadActual;
        private System.Windows.Forms.GroupBox grbCambiarActividad;
        private System.Windows.Forms.GroupBox grbActividadesRealizadas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPreparacion;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Button btnMaquinaParada;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvActividadesRealizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.GroupBox grbTiempoTranscurrido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}