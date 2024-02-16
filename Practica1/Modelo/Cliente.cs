using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Modelo
{

    public class Cliente
    {
        private string dni;
        private string nombre;
        private string direccion;
        private string ciudad;
        private Empleado representante;
        private string correo;
        private string cif;
        private string telefono;
        private string pais;
        private decimal descuento;
        private string comentarios;
        private Image logo;
        private DateTime cita;
        private string tipoCli;
        /*private enum TipoCliente
        {   
            Pequenio,
            Mediano, 
            Grande,
            Multinacional
        }*/
        public Cliente(string dni,string nombre, string direccion, string ciudad, Empleado representante, 
            string correo, string cif, string telefono, string pais, string tipoCli, decimal descuento, string comentarios, 
            Image logo, DateTime cita)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Representante = representante;
            this.Correo = correo;
            this.Cif = cif;
            this.Telefono = telefono;
            this.Pais = pais;
            this.Descuento = descuento;
            this.Comentarios = comentarios;
            this.Logo = logo;
            this.Cita = cita;
            this.TipoCli = tipoCli;
        }
        public Cliente() { }

        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public Empleado Representante { get => representante; set => representante = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Cif { get => cif; set => cif = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public Image Logo { get => logo; set => logo = value; }
        public DateTime Cita { get => cita; set => cita = value; }
        public string TipoCli { get => tipoCli; set => tipoCli = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"Nombre del Cliente: {Nombre}, DNI: {Dni}, Teléfono: {telefono}, \n Dirección: {direccion}, Ciudad: {ciudad}, País: {pais}, \n" +
                   $"Nombre del Representante: {representante.Nombre}, Logo: {logo}, Tipo: {TipoCli}, \nCorreo: {correo}, Comentarios: {comentarios}, \n" +
                   $"Descuento: {descuento}, Próxima Cita: {Cita}";
        }
    }
    
}
