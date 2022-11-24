﻿using CapaDeDatos.Clases;
using CapaDeEntidad.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio.Clases
{
    public class CN_DetalleServicio
    {
        CD_DetalleServicio CD_DetalleServicio = new CD_DetalleServicio();
        private readonly CD_DetalleServicio objDatos = new CD_DetalleServicio();

        #region Insertar   

        public void Insertar(CE_DetalleServicio Servicios)
        {
            objDatos.CD_Insertar(Servicios);
        }

        #endregion

        #region CARGAR ARTEFACTOS AL GRID

        public DataTable VerServiciosContratados(int idUsuario, int idReserva)
        {
            return objDatos.VerServiciosContratados(idUsuario, idReserva);
        }

        #endregion
    }
}