using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prroject.Shared.Models
{
    public interface IDataAccessProvider
    {
        void AddClientRecord(carrental car);
        void UpdateClientRecord(carrental car);
        void DeleteClientRecord(int Id);
        carrental GetClientRecord(int Id);
        List<carrental> GetClientRecords();

        // *** Authentication *** //
        void AddAuthRecord(authentication auth);
        void UpdateAuthRecord(authentication auth);
        void DeleteAuthRecord(string email);
        authentication GetAuthRecord(string email);
        List<authentication> GetAuthRecords();
    }
}
