﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTurnoConfirmado = new System.Windows.Forms.Label();
            this.lblTurnoConfirmado2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNvaReserva
            // 
            this.btnNvaReserva.Location = new System.Drawing.Point(576, 13);
            this.btnNvaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvaReserva.Name = "btnNvaReserva";
            this.btnNvaReserva.Size = new System.Drawing.Size(186, 48);
            this.btnNvaReserva.TabIndex = 0;
            this.btnNvaReserva.Text = "Registrar reserva";
            this.btnNvaReserva.UseVisualStyleBackColor = true;
            this.btnNvaReserva.Click += new System.EventHandler(this.btnNvaReserva_Click);
            // 
            // cmbTiposRT
            // 
            this.cmbTiposRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposRT.FormattingEnabled = true;
            this.cmbTiposRT.Location = new System.Drawing.Point(433, 93);
            this.cmbTiposRT.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTiposRT.Name = "cmbTiposRT";
            this.cmbTiposRT.Size = new System.Drawing.Size(185, 24);
            this.cmbTiposRT.TabIndex = 1;
            this.cmbTiposRT.Visible = false;
            // 
            // lblTiposRT
            // 
            this.lblTiposRT.AutoSize = true;
            this.lblTiposRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiposRT.ForeColor = System.Drawing.Color.White;
            this.lblTiposRT.Location = new System.Drawing.Point(30, 94);
            this.lblTiposRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiposRT.Name = "lblTiposRT";
            this.lblTiposRT.Size = new System.Drawing.Size(300, 20);
            this.lblTiposRT.TabIndex = 2;
            this.lblTiposRT.Text = "Tipos de Recursos Teconológicos:";
            this.lblTiposRT.Visible = false;
            // 
            // btnSelecTipoRT
            // 
            this.btnSelecTipoRT.Location = new System.Drawing.Point(628, 93);
            this.btnSelecTipoRT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecTipoRT.Name = "btnSelecTipoRT";
            this.btnSelecTipoRT.Size = new System.Drawing.Size(100, 28);
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
            this.lblCheckTipoRT.Location = new System.Drawing.Point(736, 89);
            this.lblCheckTipoRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckTipoRT.Name = "lblCheckTipoRT";
            this.lblCheckTipoRT.Size = new System.Drawing.Size(30, 31);
            this.lblCheckTipoRT.TabIndex = 4;
            this.lblCheckTipoRT.Text = "✓";
            this.lblCheckTipoRT.Visible = false;
            // 
            // lblRTs
            // 
            this.lblRTs.AutoSize = true;
            this.lblRTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTs.ForeColor = System.Drawing.Color.White;
            this.lblRTs.Location = new System.Drawing.Point(118, 136);
            this.lblRTs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRTs.Name = "lblRTs";
            this.lblRTs.Size = new System.Drawing.Size(212, 20);
            this.lblRTs.TabIndex = 5;
            this.lblRTs.Text = "Recursos Tecnológicos:";
            this.lblRTs.Visible = false;
            // 
            // cmbRTs
            // 
            this.cmbRTs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRTs.FormattingEnabled = true;
            this.cmbRTs.Location = new System.Drawing.Point(433, 135);
            this.cmbRTs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRTs.Name = "cmbRTs";
            this.cmbRTs.Size = new System.Drawing.Size(185, 24);
            this.cmbRTs.TabIndex = 6;
            this.cmbRTs.Visible = false;
            // 
            // btnSelecRT
            // 
            this.btnSelecRT.Location = new System.Drawing.Point(628, 132);
            this.btnSelecRT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecRT.Name = "btnSelecRT";
            this.btnSelecRT.Size = new System.Drawing.Size(100, 28);
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
            this.lblCheckRT.Location = new System.Drawing.Point(736, 133);
            this.lblCheckRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckRT.Name = "lblCheckRT";
            this.lblCheckRT.Size = new System.Drawing.Size(30, 31);
            this.lblCheckRT.TabIndex = 8;
            this.lblCheckRT.Text = "✓";
            this.lblCheckRT.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1236, 572);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 42);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCalendario
            // 
            this.dgvCalendario.AllowUserToAddRows = false;
            this.dgvCalendario.AllowUserToDeleteRows = false;
            this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendario.Location = new System.Drawing.Point(175, 190);
            this.dgvCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCalendario.Name = "dgvCalendario";
            this.dgvCalendario.ReadOnly = true;
            this.dgvCalendario.RowHeadersWidth = 51;
            this.dgvCalendario.Size = new System.Drawing.Size(1020, 235);
            this.dgvCalendario.TabIndex = 10;
            this.dgvCalendario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_de_RT.Properties.Resources.imagen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTurnoConfirmado
            // 
            this.lblTurnoConfirmado.AutoSize = true;
            this.lblTurnoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoConfirmado.ForeColor = System.Drawing.Color.White;
            this.lblTurnoConfirmado.Location = new System.Drawing.Point(353, 448);
            this.lblTurnoConfirmado.Name = "lblTurnoConfirmado";
            this.lblTurnoConfirmado.Size = new System.Drawing.Size(64, 25);
            this.lblTurnoConfirmado.TabIndex = 11;
            this.lblTurnoConfirmado.Text = "label1";
            this.lblTurnoConfirmado.Visible = false;
            // 
            // lblTurnoConfirmado2
            // 
            this.lblTurnoConfirmado2.AutoSize = true;
            this.lblTurnoConfirmado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoConfirmado2.ForeColor = System.Drawing.Color.White;
            this.lblTurnoConfirmado2.Location = new System.Drawing.Point(353, 485);
            this.lblTurnoConfirmado2.Name = "lblTurnoConfirmado2";
            this.lblTurnoConfirmado2.Size = new System.Drawing.Size(64, 25);
            this.lblTurnoConfirmado2.TabIndex = 12;
            this.lblTurnoConfirmado2.Text = "label1";
            this.lblTurnoConfirmado2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(705, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(7, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Via Email";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(7, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Via Whatsapp";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione su forma de notificación:";
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(154)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1375, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTurnoConfirmado2);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar reserva de un RT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaRegistrarReserva_FormClosing);
            this.Load += new System.EventHandler(this.PantallaRegistrarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lblTurnoConfirmado;
        private System.Windows.Forms.Label lblTurnoConfirmado2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

