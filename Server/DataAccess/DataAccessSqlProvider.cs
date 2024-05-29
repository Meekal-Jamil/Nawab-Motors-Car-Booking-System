using prroject.Server;
using prroject.Shared.Models;

namespace prroject.Server.DataAccess
{
    public class DataAccessSqlProvider : IDataAccessProvider
    {
        private readonly DomainModelSqlContext _context;

        public DataAccessSqlProvider(DomainModelSqlContext context)
        {
            _context = context;
        }

        public void AddClientRecord(carrental person)
        {
            _context.rentaltable.Add(person);
            _context.SaveChanges();
        }

		public void UpdateClientRecord(carrental person)
		{
			_context.rentaltable.Update(person);
			_context.SaveChanges();
		}

		public void DeleteClientRecord(int id)
		{
            var entity = _context.rentaltable.First(t => t.car_no == id);
			_context.rentaltable.Remove(entity);
			_context.SaveChanges();
		}

        public carrental GetClientRecord(int id)
        {
            return _context.rentaltable.First(t =>t.car_no == id);
        }

        public List<carrental> GetClientRecords()
        {
            return _context.rentaltable.ToList();
        }

        // Auth //
        public void AddAuthRecord(authentication person)
        {
            _context.Authentication.Add(person);
            _context.SaveChanges();
        }

        public void UpdateAuthRecord(authentication person)
        {
            _context.Authentication.Update(person);
            _context.SaveChanges();
        }

        public void DeleteAuthRecord(string email)
        {
            var entity = _context.Authentication.First(t => t.email == email);
            _context.Authentication.Remove(entity);
            _context.SaveChanges();
        }

        public authentication GetAuthRecord(string email)
        {
            return _context.Authentication.First(t => t.email == email);
        }

        public List<authentication> GetAuthRecords()
        {
            return _context.Authentication.ToList();
        }
    }
}
