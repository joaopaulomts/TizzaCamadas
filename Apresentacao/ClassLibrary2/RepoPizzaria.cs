﻿using Entidades;

namespace Repositorio
{
    public interface IRepoPizzaria
    {
        void Inserir(Pizzaria pizzaria);
    }
    public class RepoPizzaria : IRepoPizzaria
    {
        private DataContext _dataContext;
        public RepoPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {

        }
    }
}
