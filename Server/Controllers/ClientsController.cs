using prroject.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace prroject.Server.Controllers
{
	public class ClientsController : Controller
	{
		private readonly IDataAccessProvider _dataAccessProvider;

		public ClientsController(IDataAccessProvider dataAccessProvider)
		{
			_dataAccessProvider = dataAccessProvider;
		}

		[HttpGet]
		[Route("api/Clients/Get")]
		public IEnumerable<carrental> Get()
		{
			return _dataAccessProvider.GetClientRecords();
		}

		[HttpPost]
		[Route("api/Client/Create")]
		public void Create([FromBody] carrental person)
		{
			if(ModelState.IsValid)
			{
				_dataAccessProvider.AddClientRecord(person);
			}
		}

		[HttpGet]
		[Route("api/Clients/Details/{id}")]
		public carrental Details(int id)
		{
			return _dataAccessProvider.GetClientRecord(id);
		}

		[HttpPut]
		[Route("api/Clients/Edit")]
		public void Edit([FromBody] carrental person)
		{
			if(ModelState.IsValid) 
			{
				_dataAccessProvider.UpdateClientRecord(person);
			}
		}

		[HttpDelete]
		[Route("api/Clients/Delete/{id}")]
		public void DeleteConfirmed(int id)
		{
			_dataAccessProvider.DeleteClientRecord(id);
		}

        // Auth //
        [HttpGet]
        [Route("api/Auth/Get")]
        public IEnumerable<authentication> GetData()
        {
            return _dataAccessProvider.GetAuthRecords();
        }

        [HttpPost]
        [Route("api/Auth/Create")]
        public void Create([FromBody] authentication person)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddAuthRecord(person);
            }
        }

        [HttpGet]
        [Route("api/Auth/Details/{id}")]
        public authentication Details(string id)
        {
            return _dataAccessProvider.GetAuthRecord(id);
        }

        [HttpPut]
        [Route("api/Auth/Edit")]
        public void Edit([FromBody] authentication person)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateAuthRecord(person);
            }
        }

        [HttpDelete]
        [Route("api/Auth/Delete/{id}")]
        public void DeleteConfirmed(string id)
        {
            _dataAccessProvider.DeleteAuthRecord(id);
        }
    }
}
