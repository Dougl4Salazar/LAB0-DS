using System;
using LAB0DS.Models;
using LAB0DS.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0DS.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Data();

                }
                return _instance;
            }
        }
        public List<ClientesModel>clienteslist = new List<ClientesModel>
        {
            new ClientesModel
            {
                Telefono = 55283982,
                Nombre = "Douglas",
                Apellido = "Salazar",
                Descripcion = "Cliente VIP"

            },
            new ClientesModel
            {
                Telefono = 49930011,
                Nombre = "Peter",
                Apellido = "Parker",
                Descripcion = "Denegado"

            },
            new ClientesModel
            {
                Telefono = 67892345,
                Nombre = "Reed",
                Apellido = "Richards",
                Descripcion = "Socio"

            },
            new ClientesModel
            {
                Telefono = 90619023,
                Nombre = "Bruce",
                Apellido = "Banner",
                Descripcion = "Fundador"

            },
            new ClientesModel
            {
                Telefono = 20082022,
                Nombre = "Antony",
                Apellido = "Stark",
                Descripcion = "Fundador"

            }
        };



    }
}
