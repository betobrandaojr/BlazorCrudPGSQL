using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrudPGSQL.Shared.Modals
{
    public class Animal
    {
        public long Id { get; set; }
        public string Especie { get; set; }
        public decimal Preco { get; set; }
    }
}
