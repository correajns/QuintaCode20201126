using System;

namespace WebApp
{
    public class Usuario
    {
        public int ID { get; set; }
        public DateTime? DataNasc { get; set; }
        public DateTime? DataInclusao { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }
        public string Email { get; set; }


    }
}