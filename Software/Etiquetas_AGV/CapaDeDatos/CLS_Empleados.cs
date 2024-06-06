using System;

namespace CapaDeDatos
{
    public class CLS_Empleados : ConexionBase
    {

        public string c_codigo_emp { get; set; }
        public string v_nombre_emp { get; set; }
        public string c_codigo_pue { get; set; }

        public string Usuario { get; set; }

        public void MtdSeleccionarEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Empleados_Select";
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



        public void MtdInsertarEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Empleados_Insert";
                _dato.CadenaTexto = c_codigo_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_emp");
                _dato.CadenaTexto = v_nombre_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_emp");
                _dato.CadenaTexto = c_codigo_pue;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pue");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Usuario");
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

        public void MtdEliminarEmpleado()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_empleados_Delete";
                _dato.CadenaTexto = c_codigo_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_emp");
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
