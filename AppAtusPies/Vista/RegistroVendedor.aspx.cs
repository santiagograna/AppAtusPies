using AppAtusPies.Entidades;
using AppAtusPies.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppAtusPies.Vista
{
    public partial class RegistroVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreVendedor = txtNombre.Text;
            string documentoVendedor = txtDocumento.Text;
            string emailVendedor = txtEmail.Text;
            string telefonoVendedor = txtTelefono.Text;
            string contraseñaVendedor = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(nombreVendedor) || string.IsNullOrWhiteSpace(documentoVendedor) || string.IsNullOrWhiteSpace(emailVendedor) || string.IsNullOrWhiteSpace(telefonoVendedor) || string.IsNullOrWhiteSpace(contraseñaVendedor))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert",
                    "Swal.fire({title: 'Advertencia!', text: 'Todos los campos son obligatorios', icon: 'warning', confirmButtonText: 'Aceptar'});", true);
                return;
            }

            ClAdminL oDatosuser = new ClAdminL();
            ClAdminE objDatosAdmin = new ClAdminE();
            objDatosAdmin.nombre = nombreVendedor;
            objDatosAdmin.documento = documentoVendedor;
            objDatosAdmin.email = emailVendedor;
            objDatosAdmin.password = contraseñaVendedor;
            ClAdminE respuestaDevuelta = oDatosuser.MtdRegistroVendedor(objDatosAdmin);
        }
    }
}