using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class UsuarioSistemaFinanceiro
    {
        public int Id { get; set; }

        public string EmailUsuario { get; set; }

        public bool Administrador { get; set; }

        public bool SistemaAtual { get; set; }


        [ForeignKey("SisteaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }

        public virtual SistemaFinanceiro SisteaFinanceiro { get; set; }
    }
}
