using RentadeCarros.Artefactos;

namespace RentadeCarros.Repositoriodecarros
{
    public interface IRepositorioUsuarios
    {
        Task<List<Usuarios>> GetAll();
        Task<Usuarios> Get(int id);
        Task<Usuarios> Add(Usuarios usuarios);
        Task Update(int id, Usuarios usuarios);
        Task Delete(int id);

    }
}
