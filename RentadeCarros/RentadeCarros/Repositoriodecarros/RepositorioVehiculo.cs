using Microsoft.EntityFrameworkCore;
using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public class RepositorioVehiculos : IRepositorioVehiculo
    {
        private readonly RentadeCarrosDBContext _context;

        public RepositorioVehiculos(RentadeCarrosDBContext context)
        {
            _context = context;
        }
        public async Task<Vehiculos> Add(Vehiculos vehiculos)
        {
            await _context.Vehiculos.AddAsync(vehiculos);
            await _context.SaveChangesAsync();
            return vehiculos;
        }

        public async Task Delete(int id)
        {
            var vehiculos = await _context.Vehiculos.FindAsync(id);
            if (vehiculos != null)
            {
                _context.Vehiculos.Remove(vehiculos);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Vehiculos?> Get(int id)
        {
            return await _context.Vehiculos.FindAsync(id);
        }

        public async Task<List<Vehiculos>> GetAll()
        {
            return await _context.Vehiculos.ToListAsync();
        }

        public async Task Update(int id, Vehiculos vehiculos)
        {
            var vehiculoactual = await _context.Vehiculos.FindAsync(id);
            if (vehiculoactual != null)
            {
                vehiculoactual.Id = vehiculos.Id;
                vehiculoactual.Marca = vehiculos.Marca;
                vehiculoactual.Modelo = vehiculos.Modelo;
                vehiculoactual.Año = vehiculos.Año;
                await _context.SaveChangesAsync();
            }
        }
    }
}
