using RCSS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCSS.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
