using ThucHanhasp.net.Models;
using Microsoft.AspNetCore.Mvc;
using ThucHanhasp.net.Repository;
namespace ThucHanhasp.net.ViewComponents
{
    public class LoaiSpMenuViewComponent: ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaiSp = _loaiSp.GetAllLoaiSp().OrderBy(X => X.Loai);
            return View(loaiSp);
        }
    }
}
