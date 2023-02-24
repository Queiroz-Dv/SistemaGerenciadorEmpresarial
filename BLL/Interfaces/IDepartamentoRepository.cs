﻿using DAL;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IDepartamentoRepository
    {
        List<DEPARTAMENTO> ObterDepartamentos();

        void GravarDepartamento(DEPARTAMENTO departamento);

        void AtualizarDepartamento(int id);

        void DeletarDepartamento(int id);

        void DeletarDepartamentos(DEPARTAMENTO departamentos);
    }
}
