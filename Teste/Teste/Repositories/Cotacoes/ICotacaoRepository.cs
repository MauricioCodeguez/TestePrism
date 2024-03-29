﻿using System.Collections.Generic;
using Teste.Models;

namespace Teste.Repositories.Cotacoes
{
    public interface ICotacaoRepository
    {
        int DeletarCotacao(Cotacao cotacao);
        bool Save(Cotacao cotacao);
        IEnumerable<Cotacao> GetAllCotacao();
        Cotacao GetCotacao(decimal codigoCotacao);
    }
}