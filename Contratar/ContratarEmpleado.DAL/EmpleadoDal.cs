using ContratarEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratarEmpleado.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadosDal()
        {
            string consulta = "select * from empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into empleado values(" + empleado.IdPersona + "," +
                                                         "'" + empleado.Puesto + "',"+
                                                         "'" + empleado.Salario + "'," +
                                                         "'" + empleado.FechaDeContratacion+ "'," +
                                                         "'Activo')"; 
            conexion.Ejecutar(consulta);
        }
        
    }
}
