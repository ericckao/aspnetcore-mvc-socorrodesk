using SocorroDesk.Database;
using SocorroDesk.Models;

namespace SocorroDesk.Repositories
{
    public class ChamadoRepository : IChamadoRepository
    {
        private readonly SocorroDeskContext _context;

        public ChamadoRepository(SocorroDeskContext context)
        {
            _context = context;
        }


        public List<Chamado> Get()
        {
            return _context.Chamados.OrderBy(x => x.Id).ToList();
        }

        public Chamado GetById(int id)
        {
            return _context.Chamados.Find(id)!;
        }

        public void Create(Chamado chamado)
        {
            _context.Chamados.Add(chamado);
            _context.SaveChanges();
        }
        public void Update(Chamado chamado)
        {
            _context.Remove(GetById(chamado.Id));
            _context.Add(chamado);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Chamados.Remove(GetById(id));
            _context.SaveChanges();
        }

    }
}
