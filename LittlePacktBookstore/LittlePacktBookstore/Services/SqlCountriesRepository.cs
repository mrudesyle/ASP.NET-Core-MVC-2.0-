using LittlePacktBookstore.Data;
using LittlePacktBookstore.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LittlePacktBookstore.Services
{
    public class SqlCountriesRepository : IRepository<Country>
    {
        private LittlePacktBookStoreDbContex _context;

        public SqlCountriesRepository(LittlePacktBookStoreDbContex context)
        {
            _context = context;
        }

        public bool Add(Country item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Country Item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Country item)
        {
            throw new NotImplementedException();
        }

        public Country Get(int id)
        {
            if (_context.Countries.Count(x => x.Id == id) > 0)
            {
                return _context.Countries.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }
        

        public IEnumerable<Country> GetAll()
        {
            var cList = _context.Countries.ToList();
            return new List<Country>(cList);
        }        


    }
}

