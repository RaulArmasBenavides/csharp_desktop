using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolRestaurante.Util
{
    class ImpresionEstandar
    {

        public enum Separadores
        {
            Ninguno = 0,
            Derecha = 1,
            Isquierda,
            Ambos
        }

        //private struct SColumna {

        //    public Single Tamaño;
        //    public System.Drawing.ContentAlignment Aineacion;
        //    public Boolean Marco;
        //    public System.Drawing.Brush Relleno;
        //    public Separadores Separador;
        //    public String FuenteNombre;
        //    public Int32 FuenteTamaño;
        //    public System.Drawing.FontStyle FuenteEstilo;
        //}

        //private Int32 Pagina;
        private System.Drawing.Printing.PrintPageEventArgs ge;

        public System.Drawing.Printing.PrintPageEventArgs PrintPage
        {
            get { return ge; }
            set { ge = value; }
        }

        //private Single mX;
        //private Single mY;
        //private Boolean mMasDatos;
        //private Boolean mMarco;
        //private Boolean mRelleno;
        private System.Drawing.Font mFuente ;

        public System.Drawing.Font FuenteConcurrente
        {
            get { return mFuente; }
            set { mFuente = value; }
        }

        private String mFuenteNombre;
        private Int32 mFuenteTamaño;
        private System.Drawing.FontStyle mFuenteEstilo;
        //private Single mFuenteEspacion;

        public void Fuente(string Nombre, int Tamaño, System.Drawing.FontStyle Estilo)
        {
            mFuenteNombre = Nombre;
            mFuenteTamaño = Tamaño;
            mFuenteEstilo = Estilo;
            EstablecerFuente();
        }

        public void Fuente(string Nombre, int Tamaño)
        {
            mFuenteNombre = Nombre;
            mFuenteTamaño = Tamaño;
            EstablecerFuente();
        }

        public void Fuente(string Nombre)
        {
            mFuenteNombre = Nombre;
            EstablecerFuente();
        }

        public void Fuente(int Tamaño)
        {
            mFuenteTamaño = Tamaño;
            EstablecerFuente();
        }

        public void Fuente(System.Drawing.FontStyle Estilo)
        {
            mFuenteEstilo = Estilo;
            EstablecerFuente();
        }

        System.Drawing.SizeF sz;

        private Single mFuenteEspacio;

        private void EstablecerFuente()
        {
            mFuente = new System.Drawing.Font(mFuenteNombre, mFuenteTamaño, mFuenteEstilo);
            sz = ge.Graphics.MeasureString(" ", mFuente);
            mFuenteEspacio = sz.Width;
        }

        public void EscribeTexto(String s, Int32 cordenadaX, Int32 cordenadaY)
        {
            ge.Graphics.DrawString(s, mFuente, System.Drawing.Brushes.Black, cordenadaX, cordenadaY);
        }
    }






}

