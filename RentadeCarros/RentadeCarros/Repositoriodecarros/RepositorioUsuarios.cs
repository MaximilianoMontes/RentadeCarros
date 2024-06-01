using Microsoft.EntityFrameworkCore;
using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly RentadeCarrosDBContext _context;

        public RepositorioUsuarios(RentadeCarrosDBContext context)
        {
            _context = context;
        }

        public async Task<Usuarios> Add(Usuarios usuarios)
        {
            await _context.Usuarios.AddAsync(usuarios);
            await _context.SaveChangesAsync();
            return usuarios;
        }

        public async Task Delete(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios != null) 
            {
                _context.Usuarios.Remove(usuarios);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Usuarios?> Get(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<List<Usuarios>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task Update(int id, Usuarios usuarios)
        {
            var usuarioactual = await _context.Usuarios.FindAsync(id);
            if (usuarioactual != null) 
            {
                usuarioactual.Nombre = usuarios.Nombre;
                usuarioactual.Correo = usuarios.Correo;
                usuarioactual.NumTelefonico = usuarios.NumTelefonico;
                await _context.SaveChangesAsync();
            }
        }
    }
}
