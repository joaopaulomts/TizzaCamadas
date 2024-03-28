using Entidades;

namespace Repositorio
{
    public interface IRepoPizzaria
    {
        void Inserir(Pizzaria pizzaria);
    }
    public class RepoPizzaria : IRepoPizzaria
    {
        private DataContext _dataContext;
        public RepoPizzaria()
        {
            _dataContext = DataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {

        }
    }
}
