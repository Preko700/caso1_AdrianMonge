using System;
using System.Collections.Generic;
using System.Linq;
using caso1_AdrianMonge.Models;

namespace caso1_AdrianMonge.Services
{
    public class AsignaturaService
    {
        private readonly UniversidadABCContext _context;

        public AsignaturaService(UniversidadABCContext context)
        {
            _context = context;
        }

        public List<AsignaturaListadoViewModel> ObtenerAsignaturas()
        {
            return _context.Asignaturas.Select(a => new AsignaturaListadoViewModel
            {
                Id = a.Id,
                CodigoAsignatura = a.CodigoAsignatura,
                NombreAsignatura = a.NombreAsignatura,
                CarreraProfesional = a.CarreraProfesional,
                Creditos = a.Creditos,
                CuatrimestreAcademico = a.CuatrimestreAcademico,
                HorasSemanales = a.HorasSemanales,
                DuracionSemanas = a.DuracionSemanas
            }).ToList();
        }

        public AsignaturaDetallesViewModel ObtenerAsignaturaPorId(int id)
        {
            var asignatura = _context.Asignaturas.Find(id);

            if (asignatura == null)
            {
                throw new Exception($"La asignatura con Id {id} no existe.");
            }

            return new AsignaturaDetallesViewModel
            {
                Id = asignatura.Id,
                CarreraProfesional = asignatura.CarreraProfesional,
                CodigoAsignatura = asignatura.CodigoAsignatura,
                Correo = asignatura.Correo,
                Creditos = asignatura.Creditos,
                CuatrimestreAcademico = asignatura.CuatrimestreAcademico,
                Docente = asignatura.Docente,
                DuracionSemanas = asignatura.DuracionSemanas,
                HorasSemanales = asignatura.HorasSemanales,
                Inicio = asignatura.Inicio,
                NombreAsignatura = asignatura.NombreAsignatura,
                Termino = asignatura.Termino
            };
        }

        public void AgregarAsignatura(AsignaturaDetallesViewModel detalles)
        {
            if (string.IsNullOrEmpty(detalles.CodigoAsignatura))
            {
                throw new Exception("El código de la asignatura es requerido.");
            }

            if (string.IsNullOrEmpty(detalles.NombreAsignatura))
            {
                throw new Exception("El nombre de la asignatura es requerido.");
            }

            if (string.IsNullOrEmpty(detalles.CarreraProfesional))
            {
                throw new Exception("La carrera profesional es requerida.");
            }

            if (detalles.Creditos <= 0)
            {
                throw new Exception("El número de créditos debe ser mayor a cero.");
            }

            var asignatura = new Asignatura
            {
                CarreraProfesional = detalles.CarreraProfesional,
                CodigoAsignatura = detalles.CodigoAsignatura,
                Correo = detalles.Correo,
                Creditos = detalles.Creditos,
                CuatrimestreAcademico = detalles.CuatrimestreAcademico,
                Docente = detalles.Docente,
                DuracionSemanas = detalles.DuracionSemanas,
                HorasSemanales = detalles.HorasSemanales,
                Inicio = detalles.Inicio,
                NombreAsignatura = detalles.NombreAsignatura,
                Termino = detalles.Termino
            };

            _context.Asignaturas.Add(asignatura);
            _context.SaveChanges();
        }
        public void ActualizarAsignatura(AsignaturaDetallesViewModel detalles)
        {
            var asignatura = _context.Asignaturas.Find(detalles.Id);

            if (asignatura == null)
            {
                throw new Exception($"La asignatura con Id {detalles.Id} no existe.");
            }

            if (string.IsNullOrEmpty(detalles.CodigoAsignatura))
            {
                throw new Exception("El código de la asignatura es requerido.");
            }

            if (string.IsNullOrEmpty(detalles.NombreAsignatura))
            {
                throw new Exception("El nombre de la asignatura es requerido.");
            }

            if (string.IsNullOrEmpty(detalles.CarreraProfesional))
            {
                throw new Exception("La carrera profesional es requerida.");
            }

            if (detalles.Creditos <= 0)
            {
                throw new Exception("El número de créditos debe ser mayor a cero.");
            }

            asignatura.CarreraProfesional = detalles.CarreraProfesional;
            asignatura.CodigoAsignatura = detalles.CodigoAsignatura;
            asignatura.Correo = detalles.Correo;
            asignatura.Creditos = detalles.Creditos;
            asignatura.CuatrimestreAcademico = detalles.CuatrimestreAcademico;
            asignatura.Docente = detalles.Docente;
            asignatura.DuracionSemanas = detalles.DuracionSemanas;
            asignatura.HorasSemanales = detalles.HorasSemanales;
            asignatura.Inicio = detalles.Inicio;
            asignatura.NombreAsignatura = detalles.NombreAsignatura;
            asignatura.Termino = detalles.Termino;

            _context.SaveChanges();
        }

        public void EliminarAsignatura(int id)
        {
            var asignatura = _context.Asignaturas.Find(id);

            if (asignatura == null)
            {
                throw new Exception($"La asignatura con Id {id} no existe.");
            }

            _context.Asignaturas.Remove(asignatura);
            _context.SaveChanges();
        }
    }
}

