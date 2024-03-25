using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico3Ejercicio2.Interface;

namespace Practico3Ejercicio2
{
    internal class Marca : IValidar
    {
        private static int _idMarca = 1;
        private int _id;
        private string _nombre;
        private string _paisOrigen;

        public Marca(string nombre, string paisOrigen)
        {
            _id = Marca._idMarca++;
            _nombre = nombre;
            _paisOrigen = paisOrigen;
        }
        public void Validar()
        {
            ValidarNombre();
            ValidarPaisOrigen();
        }

        internal void ValidarNombre()
        {
            if (string.IsNullOrEmpty(_nombre) || _nombre.Length < 3) throw new Exception($"Nombre de la Marca debe Tener al Menos 3 Caracteres: {_nombre}");
        }

        internal void ValidarPaisOrigen()
        {
            if (string.IsNullOrEmpty(_paisOrigen)) throw new Exception("País de Origen Obligatorio");
        }

        public override string ToString()
        {
            var mensaje = $"Marca: {_nombre} - ";
            mensaje += $"País de Origen: {_paisOrigen}";

            return mensaje;
        }
    }
}
