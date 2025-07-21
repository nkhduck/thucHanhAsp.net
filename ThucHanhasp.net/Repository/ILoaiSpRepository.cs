using ThucHanhasp.net.Models;
namespace ThucHanhasp.net.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);

        TLoaiSp Update(TLoaiSp loaiSp);

        TLoaiSp Delete(TLoaiSp maloaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
