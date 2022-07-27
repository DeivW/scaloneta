using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gestion_de_RT.Modelo.Turno;

namespace Gestion_de_RT.Modelo
{
    public class RecursoTeconologico
    {
        private int duracionMantPrev;
        private DateTime fechaAlta;
        private int numeroRT;
        private TipoRecursoTeconologico tipoRT;
        private List<CambioEstadoRT> cambiosEstado = new List<CambioEstadoRT>();
        private int numero;
        private CentroInvestigacion CI;
        private int fraccionamientoTurnos;
        private List<Turno> turnos;
        private int tiempoAntelacionReserva = 3;

        public RecursoTeconologico(TipoRecursoTeconologico tipoRT, int num)
        {
            this.tipoRT = tipoRT;
            this.numero = num;
            this.fraccionamientoTurnos = 12;
            // this.cambiosEstado = new List<CambioEstadoRT>();
        }

        public RecursoTeconologico(int duracionMantPrev, DateTime fechaAlta, int numeroRT)
        {
            this.duracionMantPrev = duracionMantPrev;
            this.fechaAlta = fechaAlta;
            this.numeroRT = numeroRT;
            this.fraccionamientoTurnos = 8;
            //this.cambiosEstado = new List<CambioEstadoRT>();
        }
        public int getNumero()
        {

            return this.numero;
        }
        public void setCI(CentroInvestigacion ci)
        {
            this.CI = ci;
        }

        public void cambiarEstado(CambioEstadoRT cambioEstado)
        {
            this.cambiosEstado.Add(cambioEstado);
        }
        public bool esTipo(TipoRecursoTeconologico tipoRT)
        {
            return this.tipoRT == tipoRT;
        }
        public bool esActivo()
        {
            foreach (CambioEstadoRT cambioEstado in this.cambiosEstado)
            {
                if (cambioEstado.esActual())
                {
                    return cambioEstado.esEstadoReservable();
                }
            }
            return false;
        }
        public int getFraccionamiento()
        {
            return this.fraccionamientoTurnos;

        }
        public bool esCientificoActivoDeMiCI(PersonalCientifico personal)
        {
            return this.CI.esMiCientifico(personal);     
        }
        public void setTurnos(List<Turno> turnos)
        {
            this.turnos = turnos;
        }
        public List<Turno> getTurnos()
        {
            return this.turnos;
        }
        public List<Tuple<string, DateTime, string>> mostrarTurnos(bool pertenece)
        {
            List<Tuple<string, DateTime, string>> datosTurnos = new List<Tuple<string, DateTime, string>>();
            if (!pertenece)
            {
                foreach (Turno turno in this.turnos)
                {
                    if (turno.tieneFechaGeneracionMayorA(DateTime.Now) && (turno.getFechaHoraInicio() > DateTime.Now.AddDays(this.tiempoAntelacionReserva)))
                    {
                        datosTurnos.Add(new Tuple<string, DateTime, string>(turno.getDiaSemana(), turno.getFechaHoraInicio(), turno.mostrarEstado()));
                    }
                }
            }
            else
            {
                foreach (Turno turno in this.turnos)
                {
                    if (turno.tieneFechaGeneracionMayorA(DateTime.Now))
                    {
                        datosTurnos.Add(new Tuple<string, DateTime, string>(turno.getDiaSemana(), turno.getFechaHoraInicio(), turno.mostrarEstado()));
                    }
                }
            }

            return datosTurnos;
        }

        public void reservarTurno(DateTime fechaTurno, Estado estadoReservado)
        {
            foreach (Turno turno in this.turnos)
            {
                if (turno.getFechaHoraInicio() == fechaTurno)
                {
                    turno.enReserva(estadoReservado);
                    Console.WriteLine("FIN CU REY");
                }
            }

        }
    }
}
