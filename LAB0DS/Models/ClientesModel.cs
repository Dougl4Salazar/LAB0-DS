using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LAB0DS.Helpers;

namespace LAB0DS.Models
{
    public class ClientesModel
    {
        [MaxLength(8)]
        [MinLength(8)]
        public int Telefono{get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        public string Apellido { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public static bool Save(ClientesModel model)
        {
            Data.Instance.clienteslist.Add(model);
            return false;
        }
        public static bool Edit(int id, ClientesModel model)
        {
            var position = Data.Instance.clienteslist.FindIndex(cliente => cliente.Telefono == id);
            Data.Instance.clienteslist[position] = new ClientesModel
            {
                Telefono = id,
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Descripcion = model.Descripcion
            };
            return true;
            
        }
        public static bool Clean(int id)
        {
            var position = Data.Instance.clienteslist.FindIndex(cliente => cliente.Telefono == id);
            Data.Instance.clienteslist.RemoveAt(position);
            
            return false;
        }
        public static void OrdenNombre()
        {
            int tam = Data.Instance.clienteslist.Count;
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam - 1 - i; j++)
                {
                    int c = Data.Instance.clienteslist[j].Nombre.CompareTo(Data.Instance.clienteslist[j + 1].Nombre);
                    if (c > 0)
                    {
                        var auxiliar = Data.Instance.clienteslist[j + 1];
                        Data.Instance.clienteslist[j + 1] = Data.Instance.clienteslist[j];
                        Data.Instance.clienteslist[j] = auxiliar;
                    }
                }
            }
        }

        public static void OrdenApellido()
        {
            int tam = Data.Instance.clienteslist.Count;
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam - 1 - i; j++)
                {
                    int c = Data.Instance.clienteslist[j].Apellido.CompareTo(Data.Instance.clienteslist[j + 1].Apellido);
                    if (c > 0)
                    {
                        var auxiliar = Data.Instance.clienteslist[j + 1];
                        Data.Instance.clienteslist[j + 1] = Data.Instance.clienteslist[j];
                        Data.Instance.clienteslist[j] = auxiliar;
                    }
                }
            }
        }
    }
}
