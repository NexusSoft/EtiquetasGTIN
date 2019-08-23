using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeDatos
{
    public class CLS_Juliana:ConexionBase
    {
        public string c_codigo_dis { get; set; }
        public int Fecha_Juliana(DateTime Fecha)
        {
            int li_xday,li_xmonth, li_xyear;

            // dias por mes 
            li_xday= Convert.ToInt32(Fecha.Day.ToString());
            li_xmonth = Convert.ToInt32(Fecha.Month.ToString());
            li_xyear = Convert.ToInt32(Fecha.Year.ToString());

            // Check For a leap Year.
            //	Year divisible by 4, but Not by 100, unless it Is also divisible by 400
            int Dias = 0;
            for (int i = 1; i <= li_xmonth-1; i++)
            {
                Dias += DateTime.DaysInMonth(Convert.ToInt32(Fecha.Year.ToString()), i);
            }
            Dias += li_xday;
            return Dias;
        }
        public void MtdSeleccionarJulianaDistribuidor()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_Juliana_Distribuidor_Select";
                _dato.CadenaTexto = c_codigo_dis;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_dis");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
    }
}
