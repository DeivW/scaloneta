using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;


namespace Gestion_de_RT
{
    public partial class PantallaRegistrarReserva : Form
    {
        private GestorRegistrarReserva gestor;
        private List<Tuple<string, DateTime, string>> datosTurnos;

        public PantallaRegistrarReserva(GestorRegistrarReserva gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            gestor.setPantalla(this);

        }
        public List<Tuple<string, DateTime, string>> getDatosTurnos()
        {
            return this.datosTurnos;
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
            //btnSelecTipoRT.Enabled = false;
            cmbTiposRT.Enabled = false;
            lblCheckTipoRT.Visible = true;
        }
        public void listarRT(List<Tuple<int, string, string>> datosRTs)
        {
            lblRTs.Visible = true;
            cmbRTs.Visible = true;
            btnSelecRT.Visible = true;
            cmbRTs.DataSource = datosRTs;

        }
        public void seleccionRT()
        {
            gestor.tomarSeleccionRT(int.Parse(cmbRTs.SelectedItem.ToString().Substring(1, 3)));
            btnSelecRT.Enabled = false;
            btnSelecTipoRT.Enabled = false;
            cmbRTs.Enabled = false;
            lblCheckRT.Visible = true;
        }

        private void btnSelecRT_Click(object sender, EventArgs e)
        {
            this.seleccionRT();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                MessageBox.Show("Notificación enviada, Muchas gracias!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una forma de notificacion!");
            }


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
            List<string> turnosDispo = new List<string>();
            this.datosTurnos = datosTurnos;
            foreach (Tuple<string, DateTime, string> turno in datosTurnos)
            {
                if (turno.Item3.Equals("Disponible"))
                {
                    //   turnosDispo.Add(turno.Item2.ToString());
                    turnosDispo.Add(turno.Item2.ToString("dd/M/yyyy"));
                }
            }

            DataTable tabla = new DataTable();

            List<string> dias = new List<string>();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miércoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            dias.Add("Sábado");
            dias.Add("Domingo");


            for (int i = 0; i < 7; i++)
            {
                tabla.Columns.Add(dias[i].ToString(), typeof(string));
            }

            DateTime fechaInicial = DateTime.Now.Date;
            for (int i = 0; i < 6; i++)
            {
                DataRow dr = tabla.NewRow();
                tabla.Rows.Add(dr);
            }
            int indice = 0;
            for (DateTime d = fechaInicial; d < fechaInicial.AddMonths(1); d = d.AddDays(1))
            {
                // d.ToString("dddd", new CultureInfo("es-ES"))

                tabla.Rows[indice][d.ToString("dddd", new CultureInfo("es-ES"))] = d.Date.ToString("dd/M/yyyy");
                if (d.ToString("dddd", new CultureInfo("es-ES")).Equals("domingo"))
                {
                    indice++;
                }
            }

            dgvCalendario.DataSource = tabla;
            for (int f = 0; f < 6; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (turnosDispo.Contains(dgvCalendario[c, f].Value.ToString()))
                    {
                        dgvCalendario[c, f].Style.BackColor = Color.FromArgb(7, 83, 217);
                    }
                    else
                    {
                        dgvCalendario[c, f].Style.BackColor = Color.FromArgb(230, 47, 8);
                    }

                }
            }
            dgvCalendario.ClearSelection();

        }
        private void dgvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(230, 47, 8))
            {
                MessageBox.Show("Error - Este día no hay turnos disponibles");
            }
            else
            {
                //MessageBox.Show("Usted escogio el turno " + dgvCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                this.Enabled = false;

                List<Tuple<string, DateTime, string>> turnosDia = new List<Tuple<string, DateTime, string>>();
                foreach (Tuple<string, DateTime, string> turno in this.datosTurnos)
                {
                    if (turno.Item2.ToString("dd/M/yyyy") == dgvCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                    {
                        turnosDia.Add(turno);
                    }
                }
                popUp turnos = new popUp(this, turnosDia);
                //turnos.Show();
            }
        }

        public void seleccionTurno(DateTime fechaTurno)
        {
            this.gestor.tomarSeleccionTurno(fechaTurno);
        }

        public void pedirConfirmacion(DateTime fechaTurno, List<String> formasNotif)
        {

            DialogResult resultado = MessageBox.Show("Desea confirmar el turno con fecha " + fechaTurno.ToString(), "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Turno seleccionado con exito!");
                gestor.tomarConfirmacion(fechaTurno);
                dgvCalendario.Enabled = false;
                lblTurnoConfirmado.Text = "Turno para el día y hora " + fechaTurno.ToString() ;
                lblTurnoConfirmado.Visible = true;
                lblTurnoConfirmado2.Text = "Para el recurso " + cmbRTs.SelectedItem.ToString() + " confirmado con éxito!";
                lblTurnoConfirmado2.Visible = true;
                label1.Visible = true;
                groupBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                btnSalir.Enabled = true;

            }
            else
            {
                MessageBox.Show("Cancelo la confirmación!");
            }
        }

        //private void cmbTiposRT_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    // Draw the background 
        //    e.DrtawBackground();

        //    // Get the item text    
        //    string text = ((ComboBox)sender).Items[e.Index].ToString();

        //    // Determine the forecolor based on whether or not the item is selected    
        //    Brush brush;
        //    if (YourListOfDates[e.Index] < DateTime.Now)// compare  date with your list.  
        //    {
        //        brush = Brushes.Red;
        //    }
        //    else
        //    {
        //        brush = Brushes.Green;
        //    }

        //    // Draw the text    
        //    e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        //}

        private void PantallaRegistrarReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PantallaRegistrarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
