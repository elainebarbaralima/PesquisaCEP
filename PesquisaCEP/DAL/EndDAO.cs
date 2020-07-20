using System.Collections.Generic;
using System.Linq;
using PesquisaCEP.Models;

namespace PesquisaCEP.DAL
{
    public class EndDAO
    {
        public readonly Context _context;

        public EndDAO(Context context)
        {
            _context = context;
        }

        public void Create(End end)
        {
            _context.Ends.Add(end);
            _context.SaveChanges();
        }

        public List<End> List()
        {
            return _context.Ends.ToList(); ;
        }

        public End List(string end)
        {
            string str1 = end.Substring(0, 5);
            string str2 = end.Substring(5, 3);
            string str = $"{str1}-{str2}";
            return _context.Ends.First(c => c.Cep == str);
        }

        public End Update(End end)
        {
            _context.Ends.Update(end);
            _context.SaveChanges();
            return _context.Ends.First(c => c == end);
        }

        public End Delete(string endid)
        {
            End endereco = _context.Ends.Find(int.Parse(endid));
            _context.Ends.Remove(endereco);
            _context.SaveChanges();
            return endereco;
        }
    }
}
