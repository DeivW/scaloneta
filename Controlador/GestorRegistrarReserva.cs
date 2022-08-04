using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_RT.Modelo;
using static Gestion_de_RT.Modelo.Turno;

namespace Gestion_de_RT
{
    public class GestorRegistrarReserva
    {
        private PantallaRegistrarReserva pantalla;
        private List<Estado> estados;
        private List<TipoRecursoTeconologico> tipoRecursos;
        private TipoRecursoTeconologico tipoRTSeleccionado;
        private List<RecursoTeconologico> RTs;
        private RecursoTeconologico RTSeleccionado;
        private Sesion sesionActual;
        private PersonalCientifico cientificoEnSesion;
        private DateTime turnoSeleccionado;
        //private Estado estadoTurnoReservado;


        public GestorRegistrarReserva()
        {
        }

        public GestorRegistrarReserva(List<TipoRecursoTeconologico>tiposRT)
        {
            this.tipoRecursos = tiposRT;
        }
        public void setPantalla(PantallaRegistrarReserva pantalla)
        {
            this.pantalla = pantalla;
        }
        public void setEstados(List<Estado> estados)
        {
            this.estados = estados;
        }
        public void setRTs(List<RecursoTeconologico> RT)
        {
            this.RTs = RT;
        }
        public void setSesionActual(Sesion sesion)
        {
            this.sesionActual = sesion;
        }


        public void nuevaReserva()
        {
            this.buscarTipoRT();
        }

        private void buscarTipoRT()
        {
            List<string> vecNombresTipoRT = new List<string>();
            for (int i = 0; i < this.tipoRecursos.Count; i++)
            {
                vecNombresTipoRT.Add(this.tipoRecursos[i].getNombre());
            }
            pantalla.listarTiposRT(vecNombresTipoRT);
        }

        public void tomarSeleccionTipoRT(string tipoRTSelec)
        {
            foreach (TipoRecursoTeconologico tipoRT in this.tipoRecursos)
            {
                if(tipoRT.getNombre().Equals(tipoRTSelec)){
                    this.tipoRTSeleccionado = tipoRT;
                }
            }
            this.buscarRTActivoTipo();

        }
        public void buscarRTActivoTipo()
        {
            List<RecursoTeconologico> RTCandidatos = new List<RecursoTeconologico>();
            foreach (RecursoTeconologico RT in this.RTs)
            {
                if (RT.esTipo(this.tipoRTSeleccionado))
                {
                    if (RT.esActivo())
                    {
                        RTCandidatos.Add(RT);
                    }

                }
            }

            // LABURAR ESTA PARTE 
            // Numero, modelo, marca y centro de investigación

            List<Tuple<int, string, string>> datosRTs = new List<Tuple<int, string, string>>();
            List<int> numRT = new List<int>();
            foreach (RecursoTeconologico RT in RTCandidatos)
            {
                datosRTs.Add(RT.mostrarDatos());
                numRT.Add(RT.getNumero());
            }
            pantalla.listarRT(datosRTs);



            //----
        }
        // VEEER kionda
        public void agruparPorCI()
        {

        }
        public void tomarSeleccionRT(int numRT)
        {
            foreach (RecursoTeconologico RT in this.RTs)
            {
                if (RT.getNumero().Equals(numRT))
                {
                    this.RTSeleccionado = RT;
                }
            }
            this.obtenerCientificoEnSesion();

        }
        public void obtenerCientificoEnSesion()
        {
            this.cientificoEnSesion = this.sesionActual.obtenerCientificoEnSesion();
            this.validarPertenencia();
        }
        public void validarPertenencia()
        {
            pantalla.mostrarMensajePertenencia(this.RTSeleccionado.esCientificoActivoDeMiCI(this.cientificoEnSesion));
            // this.RTSeleccionado.esCientificoActivoDeMiCI(cientificoEnSesion);
            this.buscarTurnos(this.RTSeleccionado.esCientificoActivoDeMiCI(this.cientificoEnSesion));
           
        }
        public void buscarTurnos(bool pertenece)
        {
            List<Tuple<string, DateTime, string>> datosTurnos = new List<Tuple<string, DateTime, string>>();
            datosTurnos = this.RTSeleccionado.mostrarTurnos(pertenece);
            pantalla.presentarTurnos(datosTurnos);
        }
        public void tomarSeleccionTurno(DateTime fechaTurno)
        {
            //this.turnoSeleccionado = fechaTurno;
            pantalla.pedirConfirmacion(fechaTurno, this.presentarFormasNotificacion());
        }
        public List<String> presentarFormasNotificacion()
        {
            List<String> formasNotif = new List<string>();
            formasNotif.Add("Whatsapp");
            formasNotif.Add("Email");
            return formasNotif;
        }
        public void tomarConfirmacion(DateTime fechaConfirmada)
        {
            this.turnoSeleccionado = fechaConfirmada;
            this.registrarReservaTurnoRT();
        }
        public void registrarReservaTurnoRT()
        {

            this.RTSeleccionado.reservarTurno(this.turnoSeleccionado,this.buscarEstadoReservadoTurno());
        }
        public Estado buscarEstadoReservadoTurno()
        {
            foreach (Estado estado in this.estados)
            {
                if (estado.esAmbitoTurno() && estado.esReservado())
                {
                    return estado;
                }
            }
            return null;
        }
        private void notificarTurnoReservado()
        {
            String emailCientifico = this.cientificoEnSesion.getEmail();
            InterfazCorreo.enviarEmail(emailCientifico);
        }
    }

 
}
