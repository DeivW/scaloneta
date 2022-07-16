using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_RT
{
    public partial class PantallaRegistrarReserva : Form
    {
        GestorRegistrarReserva gestor;

        public PantallaRegistrarReserva(GestorRegistrarReserva gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            gestor.setPantalla(this);

        }

        private void btnNvaReserva_Click(object sender, EventArgs e)
        {
            this.habilitar();
        }
        public void habilitar()
        {
            gestor.nuevaReserva();
            lblTiposRT.Visible = true;
            cmbTiposRT.Visible = true;
            btnNvaReserva.Visible = false;
            btnSelecTipoRT.Visible = true;
        }
        public void listarTiposRT(List<string> tiposRT)
        {
            cmbTiposRT.DataSource = tiposRT;
        }

        private void btnSelecTipoRT_Click(object sender, EventArgs e)
        {
            this.seleccionTipoRT();
        }
        public void seleccionTipoRT()
        {
            gestor.tomarSeleccionTipoRT(cmbTiposRT.SelectedItem.ToString());
            btnSelecTipoRT.Enabled = false;
            cmbTiposRT.Enabled = false;
            lblCheckTipoRT.Visible = true;
        }
        public void listarRT(List<int> numRT)
        {
            lblRTs.Visible = true;
            cmbRTs.Visible = true;
            btnSelecRT.Visible = true;
            cmbRTs.DataSource = numRT;

        }
        public void seleccionRT()
        {
            gestor.tomarSeleccionRT(int.Parse(cmbRTs.SelectedItem.ToString()));
            btnSelecRT.Enabled = false;
            cmbRTs.Enabled = false;
            lblCheckRT.Visible = true;
        }

        private void btnSelecRT_Click(object sender, EventArgs e)
        {
            this.seleccionRT();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void mostrarMensajePertenencia(bool op)
        {
            if (op)
            {
                MessageBox.Show("El cientifico pertenece al CI del RT", "Important!");
            }
            else
            {
                MessageBox.Show("El cientifico no pertenece al CI del RT", "Warning!");
            }

        }
        public void presentarTurnos(List<Tuple<string, DateTime, string>> datosTurnos)
        {


            for (int f = 0; f < datosTurnos.Count / 5; f++)
            {
                dgvTurnos.Rows.Add(new DataGridViewRow());
            }
            
            for (int c = 0; c <= 4; c++)
            {
                for (int i = 0; i < dgvTurnos.Rows.Count; i++)
                {
                    foreach (Tuple<string, DateTime, string> tupla in datosTurnos)
                    {
                        if (c == 0)
                        {
                            if (tupla.Item1.Equals("lunes"))
                            {
                                DataGridViewTextBoxCell celdaLunes = new DataGridViewTextBoxCell();
                                celdaLunes.Value = tupla.Item2;
                                dgvTurnos.Rows[i].Cells[c] = celdaLunes;
                                datosTurnos.Remove(tupla);
                                break;
                            }
                        }
                        else if (c == 1)
                        {
                            if (tupla.Item1.Equals("martes"))
                            {
                                DataGridViewTextBoxCell celdaMartes = new DataGridViewTextBoxCell();
                                celdaMartes.Value = tupla.Item2;
                                dgvTurnos.Rows[i].Cells[c] = celdaMartes;
                                datosTurnos.Remove(tupla);
                                break;
                            }
                        }
                        else if (c == 2)
                        {
                            if (tupla.Item1.Equals("miércoles"))
                            {
                                DataGridViewTextBoxCell celdaMiercoles = new DataGridViewTextBoxCell();
                                celdaMiercoles.Value = tupla.Item2;
                                dgvTurnos.Rows[i].Cells[c] = celdaMiercoles;
                                datosTurnos.Remove(tupla);
                                break;
                            }
                        }
                        else if (c == 3)
                        {
                            if (tupla.Item1.Equals("jueves"))
                            {
                                DataGridViewTextBoxCell celdaJueves = new DataGridViewTextBoxCell();
                                celdaJueves.Value = tupla.Item2;
                                dgvTurnos.Rows[i].Cells[c] = celdaJueves;
                                datosTurnos.Remove(tupla);
                                break;
                            }
                        }
                        else if (c == 4)
                        {
                            if (tupla.Item1.Equals("viernes"))
                            {
                                DataGridViewTextBoxCell celdaViernes = new DataGridViewTextBoxCell();
                                celdaViernes.Value = tupla.Item2;
                                dgvTurnos.Rows[i].Cells[c] = celdaViernes;
                                datosTurnos.Remove(tupla);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void dgvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MessageBox.Show("Usted escogio el turno " + dgvTurnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
