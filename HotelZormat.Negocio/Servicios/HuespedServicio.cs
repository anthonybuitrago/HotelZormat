// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class HuespedServicio
    {
        private readonly HuespedRepository _repo;

        public HuespedServicio()
        {
            _repo = new HuespedRepository();
        }

        public List<Huesped> Listar(string busqueda = "")
        {
            return _repo.Listar(busqueda);
        }

        public Huesped ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }

        public void Guardar(Huesped h)
        {
            if (h == null) throw new ArgumentNullException("h");
            if (string.IsNullOrWhiteSpace(h.Nombre)) throw new ArgumentException("El nombre del huésped es obligatorio.");

            ValidarDocumento(h.TipoDocumento, h.NumeroDocumento);

            if (h.Id == 0)
            {
                _repo.Crear(h);
            }
            else
            {
                _repo.Actualizar(h);
            }
        }

        public void Eliminar(int id)
        {
            _repo.Eliminar(id);
        }

        public bool ValidarDocumento(string tipoDoc, string numeroDoc)
        {
            if (string.IsNullOrWhiteSpace(numeroDoc))
            {
                throw new ArgumentException("El número de documento no puede estar vacío.");
            }

            string limpio = numeroDoc.Replace("-", "").Replace(" ", "").Trim();

            if (tipoDoc == "Cédula")
            {
                if (limpio.Length != 11 || !Regex.IsMatch(limpio, @"^\d{11}$"))
                {
                    throw new ArgumentException("La cédula dominicana debe contener exactamente 11 dígitos numéricos.");
                }
            }
            else if (tipoDoc == "Pasaporte")
            {
                if (limpio.Length < 6)
                {
                    throw new ArgumentException("El número de pasaporte debe tener al menos 6 caracteres.");
                }
            }

            return true;
        }
    }
}
