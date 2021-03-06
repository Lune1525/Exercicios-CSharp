using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    
        public class ValorConta
    {
        public int Codigo { get; set; }
        public decimal Preco { get; set; }
    }

    static void Main(string[] args) { 

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        List<ValorConta> lanchonete = new List<ValorConta>();

        ValorConta hotdog = new ValorConta();
        hotdog.Codigo = 1;
        hotdog.Preco = 4.00M;
        ValorConta xsalada = new ValorConta();
        xsalada.Codigo = 2;
        xsalada.Preco = 4.50M;
        ValorConta xbacon = new ValorConta();
        xbacon.Codigo = 3;
        xbacon.Preco = 5.00M;
        ValorConta torrada = new ValorConta();
        torrada.Codigo = 4;
        torrada.Preco = 2.00M;
        ValorConta refrigerante = new ValorConta();
        refrigerante.Codigo = 5;
        refrigerante.Preco = 1.50M;

        lanchonete.Add(hotdog);
        lanchonete.Add(xsalada);
        lanchonete.Add(xbacon);
        lanchonete.Add(torrada);
        lanchonete.Add(refrigerante);

        string pedido = Console.ReadLine();
        string[] quantidadePedido = pedido.Split(' ');

        int codigoPedido = Convert.ToInt32(quantidadePedido[0]);
        int totalPedido = Convert.ToInt32(quantidadePedido[1]);

        ValorConta pedidoatual = lanchonete.Where(p => p.Codigo == codigoPedido).FirstOrDefault();
        decimal total = pedidoatual.Preco * totalPedido;
        Console.WriteLine($"Total: R$ {total}");
        
    }
