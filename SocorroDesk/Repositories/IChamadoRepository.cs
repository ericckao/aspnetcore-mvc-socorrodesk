using SocorroDesk.Models;

namespace SocorroDesk.Repositories
{
    public interface IChamadoRepository
    {
        //CRUD
        List<Chamado> Get();
        Chamado GetById(int id);
        void Create(Chamado chamado);
        void Update(Chamado chamado);
        void Delete(int id);
    }
}
