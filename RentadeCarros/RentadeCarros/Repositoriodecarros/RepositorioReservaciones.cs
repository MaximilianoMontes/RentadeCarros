using Microsoft.EntityFrameworkCore;
using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public class RepositorioReservaciones : IRepositorioReservaciones
    {
        private readonly RentadeCarrosDBContext _context;

        public RepositorioReservaciones(RentadeCarrosDBContext context)
        {
            _context = context;
        }
        public async Task<Reservaciones> Add(Reservaciones reservaciones)
        {
            await _context.Reservaciones.AddAsync(reservaciones);
            await _context.SaveChangesAsync();
            return reservaciones;
        }

        public async Task Delete(int id)
        {
            var reservaciones = await _context.Reservaciones.FindAsync(id);
            if (reservaciones != null)
            {
                _context.Reservaciones.Remove(reservaciones);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Reservaciones?> Get(int id)
        {
            return await _context.Reservaciones.FindAsync(id);
        }

        public async Task<List<Reservaciones>> GetAll()
        {
            return await _context.Reservaciones.ToListAsync();
        }
        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
        public async Task<List<Vehiculos>> GetVehiculos()
        {
            return await _context.Vehiculos.ToListAsync();
        }

        public async Task Update(int id, Reservaciones reservaciones)
        {
            var reservacionactual = await _context.Reservaciones.FindAsync(id);
            if (reservacionactual != null)
            {
                reservacionactual.Id = reservaciones.Id;
                reservacionactual.Fechainicioreserva = reservaciones.Fechainicioreserva;
                reservacionactual.Fechafinalreserva = reservaciones.Fechafinalreserva;
                await _context.SaveChangesAsync();
            }
        }
    }
}
