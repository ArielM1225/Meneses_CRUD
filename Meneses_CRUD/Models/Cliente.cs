using System;
using System.Collections.Generic;

namespace Meneses_CRUD.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumTel { get; set; }
    }
}
