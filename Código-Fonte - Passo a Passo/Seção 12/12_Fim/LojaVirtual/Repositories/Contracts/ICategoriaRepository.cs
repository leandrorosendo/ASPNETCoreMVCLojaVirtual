﻿using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        //CRUD
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        IEnumerable<Categoria> ObterTodasCategorias();
    }
}
