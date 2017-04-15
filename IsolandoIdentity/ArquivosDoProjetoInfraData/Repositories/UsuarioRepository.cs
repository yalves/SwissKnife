using System;
using System.Collections.Generic;
using System.Linq;
using Mau.PauloMau.Domain.Entities;
using Mau.PauloMau.Domain.Interfaces.Repositories;
using Mau.PauloMau.Infra.Data.Contexts;

namespace Mau.PauloMau.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IdentityEntityContextDb _db;

        public UsuarioRepository()
        {
            _db = new IdentityEntityContextDb();
        }

        public Usuario ObterPorId(string id)
        {
            return _db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _db.Usuarios.ToList();
        }

        public void DesativarLock(string id)
        {
            _db.Usuarios.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}