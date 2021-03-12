using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        IEnumerable<Leilao> BuscarPorTermo(string termo);


        IEnumerable<Leilao> BuscarLeiloes();

        void Incluir(Leilao leilao);

        void Alterar(Leilao leilao);

        void Excluir(Leilao leilao);

        Leilao BuscarPorId(int id);

    }
}
