namespace BPS
{
    partial class frmMaterialStatusReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantProg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantSinPal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantPredesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1243, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BPS.Properties.Resources.OPPFILM_ARGENTINA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1206, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(34, 88);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(947, 88);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(941, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de materiales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(941, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPedido,
            this.clmOC,
            this.clmPelicula,
            this.clmAncho,
            this.clmDiametro,
            this.clmCore,
            this.clmCantSol,
            this.clmCantProg,
            this.clmCantSinPal,
            this.clmCantDep,
            this.clmCantPredesp,
            this.clmCantDesp,
            this.clmCantPend,
            this.clmPrecio,
            this.clmFechaIng,
            this.clmFechaSol,
            this.clmFechaEnt,
            this.clmObservaciones});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 440);
            this.dataGridView1.TabIndex = 1;
            // 
            // clmPedido
            // 
            this.clmPedido.HeaderText = "Pedido";
            this.clmPedido.Name = "clmPedido";
            this.clmPedido.ReadOnly = true;
            this.clmPedido.Width = 50;
            // 
            // clmOC
            // 
            this.clmOC.HeaderText = "Orden de Compra";
            this.clmOC.Name = "clmOC";
            this.clmOC.ReadOnly = true;
            this.clmOC.Width = 60;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 60;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 45;
            // 
            // clmDiametro
            // 
            this.clmDiametro.HeaderText = "Diam.";
            this.clmDiametro.Name = "clmDiametro";
            this.clmDiametro.ReadOnly = true;
            this.clmDiametro.Width = 40;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 35;
            // 
            // clmCantSol
            // 
            this.clmCantSol.HeaderText = "Cantidad solicitada [Kg]";
            this.clmCantSol.Name = "clmCantSol";
            this.clmCantSol.ReadOnly = true;
            this.clmCantSol.Width = 85;
            // 
            // clmCantProg
            // 
            this.clmCantProg.HeaderText = "Cantidad programada [Kg]";
            this.clmCantProg.Name = "clmCantProg";
            this.clmCantProg.ReadOnly = true;
            this.clmCantProg.Width = 85;
            // 
            // clmCantSinPal
            // 
            this.clmCantSinPal.HeaderText = "Cantidad sin paletizar [Kg]";
            this.clmCantSinPal.Name = "clmCantSinPal";
            this.clmCantSinPal.ReadOnly = true;
            this.clmCantSinPal.Width = 85;
            // 
            // clmCantDep
            // 
            this.clmCantDep.HeaderText = "Cantidad en deposito [Kg]";
            this.clmCantDep.Name = "clmCantDep";
            this.clmCantDep.ReadOnly = true;
            this.clmCantDep.Width = 85;
            // 
            // clmCantPredesp
            // 
            this.clmCantPredesp.HeaderText = "Cantidad pre-despachada [Kg]";
            this.clmCantPredesp.Name = "clmCantPredesp";
            this.clmCantPredesp.ReadOnly = true;
            this.clmCantPredesp.Width = 85;
            // 
            // clmCantDesp
            // 
            this.clmCantDesp.HeaderText = "Cantidad entregada [Kg]";
            this.clmCantDesp.Name = "clmCantDesp";
            this.clmCantDesp.ReadOnly = true;
            this.clmCantDesp.Width = 85;
            // 
            // clmCantPend
            // 
            this.clmCantPend.HeaderText = "Cantidad pendiente de entrega [Kg]";
            this.clmCantPend.Name = "clmCantPend";
            this.clmCantPend.ReadOnly = true;
            this.clmCantPend.Width = 85;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio [USD]";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            this.clmPrecio.Width = 50;
            // 
            // clmFechaIng
            // 
            this.clmFechaIng.HeaderText = "Fecha ingreso";
            this.clmFechaIng.Name = "clmFechaIng";
            this.clmFechaIng.ReadOnly = true;
            this.clmFechaIng.Width = 80;
            // 
            // clmFechaSol
            // 
            this.clmFechaSol.HeaderText = "Fecha solicitada";
            this.clmFechaSol.Name = "clmFechaSol";
            this.clmFechaSol.ReadOnly = true;
            this.clmFechaSol.Width = 80;
            // 
            // clmFechaEnt
            // 
            this.clmFechaEnt.HeaderText = "Fecha entrega";
            this.clmFechaEnt.Name = "clmFechaEnt";
            this.clmFechaEnt.ReadOnly = true;
            this.clmFechaEnt.Width = 80;
            // 
            // clmObservaciones
            // 
            this.clmObservaciones.HeaderText = "Observaciones";
            this.clmObservaciones.Name = "clmObservaciones";
            this.clmObservaciones.ReadOnly = true;
            // 
            // frmMaterialStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaterialStatusReport";
            this.ShowIcon = false;
            this.Text = "Estado de materiales";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantProg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantSinPal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantPredesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantDesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservaciones;
    }
}