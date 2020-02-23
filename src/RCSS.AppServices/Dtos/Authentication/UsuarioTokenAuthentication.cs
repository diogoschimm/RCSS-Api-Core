using RCSS.Infra.Identity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCSS.AppServices.Dtos
{
    public class UsuarioTokenAuthentication
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public TokenAuthentication Token { get; set; }
         
    }
}
