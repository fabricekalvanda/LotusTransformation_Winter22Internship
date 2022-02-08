using System.Linq;

namespace LotusTransformation.Models
{
    public class EFAccountCreation : IAccountCreation
    {
        private LotusTransformationDBContext _dbContext;

        public EFAccountCreation(LotusTransformationDBContext LTctx)
        {
            _dbContext = LTctx; 
        }

        public IQueryable<UserInformation> Account => _dbContext.UserInformation;
    }
}
