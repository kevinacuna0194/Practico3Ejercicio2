using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Practico3Ejercicio2.Interface;

namespace Practico3Ejercicio2
{

    internal class Auto : IValidar
    {
        private static int _idAuto = 1;
        private int _id;
        private Marca _marca;
        private string _modelo;
        private int _año;
        private TipoAuto _tipoAuto;
        private string _matricula;
        private DateTime _fechaUltimoServicio;

        public Auto(Marca marca, string modelo, int año, TipoAuto tipoAuto, string matricula, DateTime fechaUltimoServicio)
        {
            _id = Auto._idAuto++;
            _marca = marca;
            _modelo = modelo;
            _año = año;
            _tipoAuto = tipoAuto;
            _matricula = matricula;
            _fechaUltimoServicio = fechaUltimoServicio;
        }

        /**  
        public bool Validar()
        {
            return !string.IsNullOrEmpty(modelo) &&
                   año > 1900 &&
                   (tipo == "Nuevo" || tipo == "Usado") &&
                   matricula.Length == 6 &&
                   fechaUltimoServicio <= DateTime.Today;
        }
        **/

        public void Validar()
        {
            ValidarMarca();
            ValidarModelo();
            ValidarAño();
            ValidarTipo();
            ValidarMatricula();
        }

        internal void ValidarMarca()
        {
            if (_marca == null) throw new Exception("Marca Obligatoria");
        }

        internal void ValidarModelo()
        {
            if (string.IsNullOrEmpty(_modelo)) throw new Exception("Marca y Modelo Obligatorios");
        }

        internal void ValidarAño()
        {
            if (_año <= 1900) throw new Exception("Año Debe ser Mayor que 1900");
        }

        internal void ValidarTipo()
        {
            if ((_tipoAuto != TipoAuto.Nuevo) && (_tipoAuto != TipoAuto.Usado)) throw new Exception("El tipo Debe ser Nuevo o Usado");
        }

        internal void ValidarMatricula()
        {
            if (_matricula.Length != 6) throw new Exception("La Matrícula Debe Tener 6 Caracteres");
        }

        internal DateTime CalcularProximoServicio()
        {
            return _fechaUltimoServicio.AddYears(1);
        } 

        public override string ToString()
        {
            var mensaje = $"{_marca} - ";
            mensaje += $"Modelo: {_modelo} - ";
            mensaje += $"Año: {_año} - ";
            mensaje += $"Tipo de Auto: {_tipoAuto} - ";
            mensaje += $"Matrícula: {_matricula} - ";
            mensaje += $"Última Fecha de Servicio: {_fechaUltimoServicio} \n";
            return mensaje;
        }
    }
}
