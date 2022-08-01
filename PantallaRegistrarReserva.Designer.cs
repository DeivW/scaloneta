
namespace Gestion_de_RT
{
    partial class PantallaRegistrarReserva
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
            this.btnNvaReserva = new System.Windows.Forms.Button();
            this.cmbTiposRT = new System.Windows.Forms.ComboBox();
            this.lblTiposRT = new System.Windows.Forms.Label();
            this.btnSelecTipoRT = new System.Windows.Forms.Button();
            this.lblCheckTipoRT = new System.Windows.Forms.Label();
            this.lblRTs = new System.Windows.Forms.Label();
            this.cmbRTs = new System.Windows.Forms.ComboBox();
            this.btnSelecRT = new System.Windows.Forms.Button();
            this.lblCheckRT = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCalendario = new System.Windows.Forms.DataGridView();
            this.lblTurnoConfirmado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNvaReserva
            // 
            this.btnNvaReserva.Location = new System.Drawing.Point(438, 12);
            this.btnNvaReserva.Name = "btnNvaReserva";
            this.btnNvaReserva.Size = new System.Drawing.Size(124, 23);
            this.btnNvaReserva.TabIndex = 0;
            this.btnNvaReserva.Text = "Registrar reserva";
            this.btnNvaReserva.UseVisualStyleBackColor = true;
            this.btnNvaReserva.Click += new System.EventHandler(this.btnNvaReserva_Click);
            // 
            // cmbTiposRT
            // 
            this.cmbTiposRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposRT.FormattingEnabled = true;
            this.cmbTiposRT.Location = new System.Drawing.Point(190, 55);
            this.cmbTiposRT.Name = "cmbTiposRT";
            this.cmbTiposRT.Size = new System.Drawing.Size(156, 21);
            this.cmbTiposRT.TabIndex = 1;
            this.cmbTiposRT.Visible = false;
            // 
            // lblTiposRT
            // 
            this.lblTiposRT.AutoSize = true;
            this.lblTiposRT.Location = new System.Drawing.Point(12, 58);
            this.lblTiposRT.Name = "lblTiposRT";
            this.lblTiposRT.Size = new System.Drawing.Size(172, 13);
            this.lblTiposRT.TabIndex = 2;
            this.lblTiposRT.Text = "Tipos de Recursos Teconológicos:";
            this.lblTiposRT.Visible = false;
            // 
            // btnSelecTipoRT
            // 
            this.btnSelecTipoRT.Location = new System.Drawing.Point(352, 55);
            this.btnSelecTipoRT.Name = "btnSelecTipoRT";
            this.btnSelecTipoRT.Size = new System.Drawing.Size(75, 23);
            this.btnSelecTipoRT.TabIndex = 3;
            this.btnSelecTipoRT.Text = "Seleccionar";
            this.btnSelecTipoRT.UseVisualStyleBackColor = true;
            this.btnSelecTipoRT.Visible = false;
            this.btnSelecTipoRT.Click += new System.EventHandler(this.btnSelecTipoRT_Click);
            // 
            // lblCheckTipoRT
            // 
            this.lblCheckTipoRT.AutoSize = true;
            this.lblCheckTipoRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckTipoRT.ForeColor = System.Drawing.Color.Lime;
            this.lblCheckTipoRT.Location = new System.Drawing.Point(433, 52);
            this.lblCheckTipoRT.Name = "lblCheckTipoRT";
            this.lblCheckTipoRT.Size = new System.Drawing.Size(25, 26);
            this.lblCheckTipoRT.TabIndex = 4;
            this.lblCheckTipoRT.Text = "✓";
            this.lblCheckTipoRT.Visible = false;
            // 
            // lblRTs
            // 
            this.lblRTs.AutoSize = true;
            this.lblRTs.Location = new System.Drawing.Point(66, 92);
            this.lblRTs.Name = "lblRTs";
            this.lblRTs.Size = new System.Drawing.Size(118, 13);
            this.lblRTs.TabIndex = 5;
            this.lblRTs.Text = "Recursos tecnológicos:";
            this.lblRTs.Visible = false;
            // 
            // cmbRTs
            // 
            this.cmbRTs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRTs.FormattingEnabled = true;
            this.cmbRTs.Location = new System.Drawing.Point(190, 89);
            this.cmbRTs.Name = "cmbRTs";
            this.cmbRTs.Size = new System.Drawing.Size(156, 21);
            this.cmbRTs.TabIndex = 6;
            this.cmbRTs.Visible = false;
            // 
            // btnSelecRT
            // 
            this.btnSelecRT.Location = new System.Drawing.Point(352, 87);
            this.btnSelecRT.Name = "btnSelecRT";
            this.btnSelecRT.Size = new System.Drawing.Size(75, 23);
            this.btnSelecRT.TabIndex = 7;
            this.btnSelecRT.Text = "Seleccionar";
            this.btnSelecRT.UseVisualStyleBackColor = true;
            this.btnSelecRT.Visible = false;
            this.btnSelecRT.Click += new System.EventHandler(this.btnSelecRT_Click);
            // 
            // lblCheckRT
            // 
            this.lblCheckRT.AutoSize = true;
            this.lblCheckRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckRT.ForeColor = System.Drawing.Color.Lime;
            this.lblCheckRT.Location = new System.Drawing.Point(433, 84);
            this.lblCheckRT.Name = "lblCheckRT";
            this.lblCheckRT.Size = new System.Drawing.Size(25, 26);
            this.lblCheckRT.TabIndex = 8;
            this.lblCheckRT.Text = "✓";
            this.lblCheckRT.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(944, 476);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCalendario
            // 
            this.dgvCalendario.AllowUserToAddRows = false;
            this.dgvCalendario.AllowUserToDeleteRows = false;
            this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendario.Location = new System.Drawing.Point(124, 175);
            this.dgvCalendario.Name = "dgvCalendario";
            this.dgvCalendario.ReadOnly = true;
            this.dgvCalendario.RowHeadersWidth = 51;
            this.dgvCalendario.Size = new System.Drawing.Size(765, 166);
            this.dgvCalendario.TabIndex = 10;
            this.dgvCalendario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellDoubleClick);
            // 
            // lblTurnoConfirmado
            // 
            this.lblTurnoConfirmado.AutoSize = true;
            this.lblTurnoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoConfirmado.Location = new System.Drawing.Point(120, 344);
            this.lblTurnoConfirmado.Name = "lblTurnoConfirmado";
            this.lblTurnoConfirmado.Size = new System.Drawing.Size(51, 20);
            this.lblTurnoConfirmado.TabIndex = 11;
            this.lblTurnoConfirmado.Text = "label1";
            this.lblTurnoConfirmado.Visible = false;
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 511);
            this.Controls.Add(this.lblTurnoConfirmado);
            this.Controls.Add(this.dgvCalendario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCheckRT);
            this.Controls.Add(this.btnSelecRT);
            this.Controls.Add(this.cmbRTs);
            this.Controls.Add(this.lblRTs);
            this.Controls.Add(this.lblCheckTipoRT);
            this.Controls.Add(this.btnSelecTipoRT);
            this.Controls.Add(this.lblTiposRT);
            this.Controls.Add(this.cmbTiposRT);
            this.Controls.Add(this.btnNvaReserva);
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar reserva de un RT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaRegistrarReserva_FormClosing);
            this.Load += new System.EventHandler(this.PantallaRegistrarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNvaReserva;
        private System.Windows.Forms.ComboBox cmbTiposRT;
        private System.Windows.Forms.Label lblTiposRT;
        private System.Windows.Forms.Button btnSelecTipoRT;
        private System.Windows.Forms.Label lblCheckTipoRT;
        private System.Windows.Forms.Label lblRTs;
        private System.Windows.Forms.ComboBox cmbRTs;
        private System.Windows.Forms.Button btnSelecRT;
        private System.Windows.Forms.Label lblCheckRT;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCalendario;
        private System.Windows.Forms.Label lblTurnoConfirmado;
    }
}

