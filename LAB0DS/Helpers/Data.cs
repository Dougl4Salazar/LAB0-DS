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

            }
        };



    }
}
