using AppAtusPies.Datos;
using AppAtusPies.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace AppAtusPies.Logica
{
    public class ClAdminL
    {
        public ClAdminE MtdRegistroVendedor(ClAdminE oDatos)
        {
            // Encriptar la contraseña
            oDatos.password = HashPassword(oDatos.password);

            ClAdminD oDatosD = new ClAdminD();
            return oDatosD.MtdRegistrarVendedor(oDatos);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}