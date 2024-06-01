using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public interface IRepositorioReservaciones
    {
        Task<List<Reservaciones>> GetAll();
        Task<List<Usuarios>> GetUsuarios();
        Task<List<Vehiculos>> GetVehiculos();
        Task<Reservaciones> Get(int id);
        Task<Reservaciones> Add(Reservaciones reservaciones);
        Task Update(int id, Reservaciones reservaciones);
        Task Delete(int id);
    }
}
