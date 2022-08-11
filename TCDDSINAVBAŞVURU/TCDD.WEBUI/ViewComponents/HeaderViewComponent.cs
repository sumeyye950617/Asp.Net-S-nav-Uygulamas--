using Microsoft.AspNetCore.Mvc;
using TCDD.BLL.Repository;
using TCDD.DLL.Entities;

namespace TCDD.WEBUI.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        SqlRepo<Category> repoCategory;
        public HeaderViewComponent(SqlRepo<Category> _repoCategory)
        {
            repoCategory = _repoCategory;
        }

        public IViewComponentResult Invoke()
        {
            return View(repoCategory.GetAll().OrderBy(o => o.Name));
        }
    }
}
