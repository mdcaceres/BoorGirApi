
namespace BooGir.Forms
{
    partial class FrmConsultarClientes
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
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnSalirConsultar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNroPresup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFecha,
            this.cNroPresup,
            this.ColDireccion,
            this.Acciones});
            this.dgvConsultar.Location = new System.Drawing.Point(18, 69);
            this.dgvConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(950, 561);
            this.dgvConsultar.TabIndex = 19;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::BooGir.Properties.Resources.filter;
            this.btnFiltrar.Location = new System.Drawing.Point(280, 30);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(67, 31);
            this.btnFiltrar.TabIndex = 20;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.FlatAppearance.BorderSize = 0;
            this.btnEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFiltro.Image = global::BooGir.Properties.Resources.delete;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(355, 26);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(59, 38);
            this.btnEliminarFiltro.TabIndex = 21;
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // btnSalirConsultar
            // 
            this.btnSalirConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSalirConsultar.FlatAppearance.BorderSize = 0;
            this.btnSalirConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalirConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirConsultar.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSalirConsultar.Location = new System.Drawing.Point(18, 650);
            this.btnSalirConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirConsultar.Name = "btnSalirConsultar";
            this.btnSalirConsultar.Size = new System.Drawing.Size(128, 38);
            this.btnSalirConsultar.TabIndex = 24;
            this.btnSalirConsultar.Text = "Volver";
            this.btnSalirConsultar.UseVisualStyleBackColor = false;
            this.btnSalirConsultar.Click += new System.EventHandler(this.btnSalirConsultar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(74, 32);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(185, 26);
            this.txtDni.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::BooGir.Properties.Resources.people;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "           ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cFecha
            // 
            this.cFecha.FillWeight = 160F;
            this.cFecha.HeaderText = "Cliente";
            this.cFecha.MinimumWidth = 8;
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            // 
            // cNroPresup
            // 
            this.cNroPresup.HeaderText = "Telefono";
            this.cNroPresup.MinimumWidth = 8;
            this.cNroPresup.Name = "cNroPresup";
            this.cNroPresup.ReadOnly = true;
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Direccion";
            this.ColDireccion.MinimumWidth = 8;
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.MinimumWidth = 8;
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Acciones.Text = "Editar";
            this.Acciones.ToolTipText = "Editar";
            this.Acciones.UseColumnTextForButtonValue = true;
            // 
            // FrmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(981, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnSalirConsultar);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsultarClientes";
            this.Text = "FrmConsultarClientes";
            this.Load += new System.EventHandler(this.FrmConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnSalirConsultar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}