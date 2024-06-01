using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public interface IRepositorioVehiculo
    {
        Task<List<Vehiculos>> GetAll();
        Task<Vehiculos> Get(int id);
        Task<Vehiculos> Add(Vehiculos vehiculos);
        Task Update(int id, Vehiculos vehiculos);
        Task Delete(int id);
    }
}
