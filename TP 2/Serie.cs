using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Serie
    {
        private int qTemporadas;
        private int qEpisodios;
        private int duracion;
        private int ranking;
        private string nombre;
        private string director;
        private Genero genero;

        #region Propiedades
        public int QTemporadas { get { return qTemporadas; } set { qTemporadas = value; } }
        public int QEpisodios { get { return qEpisodios; } set { qEpisodios = value; } }
        public int Duracion { get { return duracion; } set { duracion = value; } }
        public int Ranking { get { return ranking; } set { ranking = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Director { get { return director; } set { director = value; } }
        public Genero Genero { get { return genero; } set { genero = value; } }
        #endregion

        #region Constructor
        public Serie(int qT, int qE, int dur, int rank, string nom, string dir, Genero gen)
        {
            QTemporadas = qT;
            QEpisodios = qE;
            Duracion = dur;
            Ranking = rank;
            Nombre = nom;
            Director = dir;
            Genero = gen;

        }
        #endregion
    }
}
