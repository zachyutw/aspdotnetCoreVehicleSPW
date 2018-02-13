using System.Threading.Tasks;

namespace aspdotnetblog.Persistence
{

    public interface IUnitOfWork
    {
        Task Complete();
    }
}