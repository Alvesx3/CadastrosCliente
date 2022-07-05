﻿using CadastrosCliente.Models;

namespace CadastrosCliente.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        private static List<T> lista = new List<T>();
        public virtual void Create(T model)
        {
            lista.Add(model);
        }
        public List<T> Read()
        {
            return lista;
        }
        public T Read(int id)
        {
            return lista.Find(t => t.Id == id);
        }
        public void Edit(T model)
        {
            int index = lista.FindIndex(t => t.Id == model.Id);
            if (index != -1)
            {
                lista[index] = model;
            }
        }
        public void Delete(int id)
        {
            lista.Remove(Read(id));
        }
    }
}
