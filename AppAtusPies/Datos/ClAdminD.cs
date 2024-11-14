using AppAtusPies.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppAtusPies.Datos
{
    public class ClAdminD
    {
        public ClAdminE MtdRegistrarVendedor(ClAdminE oDatos)
        {
            ClConexion oconexion = new ClConexion();

            SqlCommand cmd = new SqlCommand("spRegistraVendedor", oconexion.MtdAbrirConexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", oDatos.nombre);
            cmd.Parameters.AddWithValue("@documento", oDatos.documento);
            cmd.Parameters.AddWithValue("@telefono", oDatos.telefono);
            cmd.Parameters.AddWithValue("@email", oDatos.email);
            cmd.Parameters.AddWithValue("@estado", oDatos.estado);
            cmd.Parameters.AddWithValue("@password", oDatos.password);

            cmd.ExecuteNonQuery();
            oconexion.MtdCerrarConexion();

            return oDatos;

        }
    }
}
