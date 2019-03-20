using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize (SistemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria {Nombre = "Precalculo", Descripcion= "Calculo basico", Eestado= true},
                new Categoria{Nombre="Programacion", Descripcion = "Curso de programacion", Eestado =  true}
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
