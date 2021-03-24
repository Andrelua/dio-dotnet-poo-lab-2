using System;
using System.Collections.Generic;
using Dio_series.Interfaces;

namespace Dio_series
{
    public class SeriesRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>(); 
        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}