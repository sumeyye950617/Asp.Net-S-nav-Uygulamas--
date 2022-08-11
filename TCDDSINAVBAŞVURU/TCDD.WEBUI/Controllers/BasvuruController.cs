using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCDD.BLL.Repository;
using TCDD.DLL.Entities;
using TCDD.WEBUI.ViewModels;

namespace TCDD.WEBUI.Controllers
{
    public class BasvuruController : Controller
    {

        SqlRepo<Sınav> repoSınav;
        SqlRepo<Unvanlar> repoUnvanlar;
        SqlRepo<Nitelik> repoNitelik;
        public BasvuruController(SqlRepo<Sınav> _repoSınav, SqlRepo<Unvanlar> _repoUnvanlar, SqlRepo<Nitelik> _repoNitelik)
        {

            repoSınav = _repoSınav;
            repoUnvanlar = _repoUnvanlar;
            repoNitelik = _repoNitelik;
        }

        [Route("/kullanıcı/sınav")]
        public IActionResult Index() //Tüm Başvuruları Görüntüleyeceğimiz Yer
        {
            return View(repoSınav.GetAll().Include(i => i.Unvanlar).OrderByDescending(o => o.ID));
        }

        public IActionResult Detail() // Başvuru Formu
        {
            return View();
        }



        [Route("/kullanııcı/yeni/sınav")]
        public IActionResult New() // Başvuru Formu
        {
            SınavVM sınavVM = new SınavVM
            {
                Sınav = new Sınav(),
                Nitelik = repoNitelik.GetAll().OrderBy(o => o.ID),
                Unvanlar = repoUnvanlar.GetAll().OrderBy(o => o.Name)
            };
            return View(sınavVM);
        }

        [Route("/kullanııcı/yeni/sınav"), HttpPost, ValidateAntiForgeryToken]
        public IActionResult New(SınavVM model)
        {
            repoSınav.Add(model.Sınav);
            return RedirectToAction("Index");
        }


        [Route("/kullanıcı/sınav/guncelle/{id}")]
        public IActionResult Update(int id)
        {
            SınavVM sınavVM=new SınavVM
            {
                Sınav = repoSınav.GetAll().FirstOrDefault(x => x.ID == id),
                Unvanlar = repoUnvanlar.GetAll().OrderBy(o => o.Name),
                Nitelik = repoNitelik.GetAll().OrderBy(o => o.ID)
            };
            return View(sınavVM);
        }

        [Route("/kullanıcı/sınav/guncelle/{id}"), HttpPost, ValidateAntiForgeryToken]
        public IActionResult Update(Sınav model)
        {
            repoSınav.Update(model);
            return RedirectToAction("Index");
        }

        [Route("/kullanıcı/sınav/sil/{id}")]
        public IActionResult Delete(int id)
        {
            repoSınav.Delete(repoSınav.GetAll().FirstOrDefault(x => x.ID == id));
            return RedirectToAction("Index");
        }
    }
}