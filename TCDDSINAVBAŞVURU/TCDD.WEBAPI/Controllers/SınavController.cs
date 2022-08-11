using Microsoft.AspNetCore.Mvc;
using TCDD.BLL.Repository;
using TCDD.DLL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TCDD.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SınavController : ControllerBase
    {
        SqlRepo<Sınav> repoSınav;
        public SınavController(SqlRepo<Sınav> _repoSınav)
        {
            repoSınav = _repoSınav;

        }
        // GET: api/<BasvuruController>
        [HttpGet]
        public IEnumerable<Sınav> Get()
        {
            return repoSınav.GetAll().OrderBy(o => o.Name);
        }

        // GET api/<BasvuruController>/5
        [HttpGet("{id}")]
        public Sınav Get (int id)
        {
            return repoSınav.GetAll().FirstOrDefault(x => x.ID == id);

        }

        // POST api/<BasvuruController>
        [HttpPost]
        public void Post(Sınav value)
        {
            repoSınav.Add(value);
        }

        // PUT api/<BasvuruController>/5
        [HttpPut("{id}")]
        public void Put(Sınav value)
        {
            repoSınav.Update(value);
        }

        // DELETE api/<BasvuruController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repoSınav.Delete(repoSınav.GetAll().FirstOrDefault(x => x.ID == id));
        }
    }
    }

