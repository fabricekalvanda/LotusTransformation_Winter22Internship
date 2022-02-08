using System.Linq;

namespace LotusTransformation.Models
{
    public interface IAccountCreation
    {
        IQueryable<UserInformation> Account { get; }
    }
}
