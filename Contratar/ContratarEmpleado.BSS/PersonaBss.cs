﻿using ContratarEmpleado.DAL;
using ContratarEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratarEmpleado.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);

        }
    }
}
