using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Tarea6_7.Data
{
    public class UsuarioServices
    {
        private AppDbContext dbContext;
        public UsuarioServices (AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //datos para utilizar en todas las paginas
        public List<Tesoro> usuario_tesoros = new List<Tesoro>();
        public Usuario _usuario = new Usuario();
        public Tesoro _tesoro = new Tesoro();
        public bool estado;

        //get
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            return await dbContext.Usuarios.ToListAsync();
        }

        //add
        public async Task<string> AddUsuarioAsync(Usuario usuario)
        {
            try
            {
                var userExit = dbContext.Usuarios.FirstOrDefault(p => p.Correo == usuario.Correo);
                if(userExit == null)
                {
                    dbContext.Usuarios.Add(usuario);
                    await dbContext.SaveChangesAsync();
                    return ("Usuario creado exitosamente");
                }
                else
                {
                    return ("El correo ya esta en uso");
                }
            }
            catch
            {
                return ("Se produjo un error");
            }
        }

        //update
        public async Task<Usuario> UpdateUsuarioAsync (Usuario usuario)
        {
            try
            {
                var userExit = dbContext.Usuarios.FirstOrDefault(p => p.UsuarioId == usuario.UsuarioId);
                if(userExit != null)
                {
                    dbContext.Usuarios.Update(usuario);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch
            {
                throw;
            }
            _usuario = usuario;
            usuario_tesoros = dbContext.Tesoros.Where(p => p.UsuarioId == _usuario.UsuarioId).ToList();
            return usuario;
        }

        //identificar si tiene los datos correctos del usuario
        public bool ValidarUsuario(Usuario _user)
        {
            _usuario = dbContext.Usuarios.FirstOrDefault(p => p.Correo + p.Clave == _user.Correo + _user.Clave);
            if(_usuario != null)
            {
                usuario_tesoros = dbContext.Tesoros.Where(p => p.UsuarioId == _usuario.UsuarioId).ToList();
                estado = true;
                return true;
            }
            else
            {
                estado = false;
                return false;
            }

        }

        public void Setestado()
        {
            estado = false;
        }
    }
}
