﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    [System.Serializable]
    class Ebook : Produto , IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome , float preco , string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possivel dar entrada no E-Book,pois é um produto digital");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar venda do E-Book: {nome}");
            Console.WriteLine("Digite a Qnt. que você deseja dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saída Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");            
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("================================");
        }
    }
}
