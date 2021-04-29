using BLL;
using Entities.Models;
using System;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // apenas para testes
            AdmFacade _adm = new AdmFacade();

            _adm.Add(new Grupo()
            {
                Nome = "Grupo 07",
                Integrantes = "14111016 - Kalissa, 16111178 - Alisson, 16109628 - Matheus",
                GitHub = "https://github.com/kalissa/SecondHand_TF07",
                Comentarios = "Grupo 07"
            });


            foreach (Grupo g in _adm.GetGrupos())
            {
                Console.WriteLine("Nome: {0}\n\tid: {1}\n\tComponentes: {2}\n\tComentarios: {3}\n",
                    g.Nome, g.GrupoId, g.Integrantes, g.Comentarios);

            }


        }
    }
}
