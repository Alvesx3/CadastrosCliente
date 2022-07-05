using CadastrosCliente.Models;
using CadastrosCliente.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastrosCliente.Controllers
{
    public class BaseController<M, R> : Controller where M : BaseModel where R : BaseRepository<M>
    {
        R repo = Activator.CreateInstance<R>();

        public BaseController(R repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(M model)
        {
            repo.Create(model);
            return RedirectToAction(nameof(List));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repo.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(M model)
        {
            repo.Edit(model);
            return RedirectToAction(nameof(List));
        }
        public ActionResult List()
        {
            return View(repo.Read());
        }
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction(nameof(List));
        }
    }
}
