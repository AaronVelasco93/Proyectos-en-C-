using System;
using System.Collections.Generic;
using System.Text;

namespace MiClaseBasica
{
    class Veiculo
    {
        public string marca;
        private int modelo;
        public string placa;

        public Veiculo( string marca, int modelo, string placa ) {

            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;

        }

    }
}
