﻿using Actores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcccesoDatos;

namespace ReglasNegocio
{
    public class GestorCalificacion
    {
        DataCalificacion dataCalificacion = new DataCalificacion();
        // 3 llamar sp de guardado

        // 4 manejar la respuesta del sp
        string respuestaInsercion = "";

        public string ingresarCalificacion(Calificacion calificacion)
        {
            respuestaInsercion = dataCalificacion.registrarCalificacion(calificacion);
            return respuestaInsercion;
        }
    }
}