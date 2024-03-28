using Entidades;
using Repositorio;

namespace Servicos
{
    public class IServPizzaria
    {

    }

    public class ServPizzaria
    {
        private IRepoPizzaria _repoPizzaria;

        public ServPizzaria()
        {
            _repoPizzaria = _repoPizzaria;
        }

        public void Inserir(InserirPizzariaDTO inserirPizzariaDto)
        {
            var pizzaria = new Pizzaria();

            pizzaria.Nome = inserirPizzariaDto.Nome;
            pizzaria.Telefone = inserirPizzariaDto.Telefone;
            pizzaria.Endereco = inserirPizzariaDto.Telefone;

            _repoPizzaria.Inserir(pizzaria);
        }
    }
}

