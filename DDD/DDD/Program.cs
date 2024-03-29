﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DDD> municipiosDDD = new List<DDD>();

            DDD brasilia = new DDD();
            brasilia.Numero = 61;
            brasilia.Nome = "Brasilia";

            DDD salvador = new DDD();
            salvador.Numero = 71;
            salvador.Nome = "Salvador";

            DDD saoPaulo = new DDD();
            saoPaulo.Numero = 11;
            saoPaulo.Nome = "Sao Paulo";

            DDD rioJaneiro = new DDD();
            rioJaneiro.Numero = 21;
            rioJaneiro.Nome = "Rio de Janeiro";

            DDD juizFora = new DDD();
            juizFora.Numero = 32;
            juizFora.Nome = "Juiz de Fora";

            DDD campinas = new DDD();
            campinas.Numero = 19;
            campinas.Nome = "Campinas";

            DDD vitoria = new DDD();
            vitoria.Numero = 27;
            vitoria.Nome = "Vitoria";

            DDD beloHorizaonte = new DDD();
            beloHorizaonte.Numero = 31;
            beloHorizaonte.Nome = "Belo Horizonte";

            municipiosDDD.Add(brasilia);
            municipiosDDD.Add(salvador);
            municipiosDDD.Add(saoPaulo);
            municipiosDDD.Add(rioJaneiro);
            municipiosDDD.Add(juizFora);
            municipiosDDD.Add(campinas);
            municipiosDDD.Add(vitoria);
            municipiosDDD.Add(beloHorizaonte);

            Console.WriteLine("Digite o DDD para saber a qual municipio pertence: ");
            string digiteDDD = Console.ReadLine();
            int dddAtual = Convert.ToInt32(digiteDDD);

            DDD municipio = municipiosDDD.Where(d => d.Numero == dddAtual).FirstOrDefault();

            if (municipio == null)
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            else
            {
                string municipioAtual = municipio.Nome;
                Console.WriteLine(municipioAtual);
            }
        }
    }
}
