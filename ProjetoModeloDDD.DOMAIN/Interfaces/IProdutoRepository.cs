
using ProjetoModeloDDD.DOMAIN.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.DOMAIN.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
