using System;

namespace CapaDeDatos
{
    public class CLS_Puesto : ConexionBase
    {

        public string c_codigo_pue { get; set; }
        public string v_nombre_pue { get; set; }
        public string Id_Usuario { get; set; }


        public void MtdSeleccionarPuesto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Puestos_Select";
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
        public void MtdInsertarPuesto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Puestos_Insert";
                _dato.CadenaTexto = c_codigo_pue;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pue");
                _dato.CadenaTexto = v_nombre_pue;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_pue");
                _dato.CadenaTexto = Id_Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Usuario");
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
        public void MtdEliminarPuesto()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Puestos_Delete";
                _dato.CadenaTexto = c_codigo_pue;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pue");
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
