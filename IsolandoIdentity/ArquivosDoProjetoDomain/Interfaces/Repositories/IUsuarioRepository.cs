using System;
using System.Collections.Generic;
using Mau.PauloMau.Domain.Entities;

namespace Mau.PauloMau.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}