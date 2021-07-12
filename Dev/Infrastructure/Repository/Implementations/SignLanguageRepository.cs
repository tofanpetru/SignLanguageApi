using Infrastructure.Persistance;
using Infrastructure.Repository.Abstract;
using Infrastructure.Repository.Interfaces;
using System.Linq;

namespace Infrastructure.Repository.Implementations
{
    public class SignLanguageRepository : AbstractRepository<SignLanguage>, ISignLanguageRepository
    {
        public SignLanguageRepository(SignLanguageContext context) : base(context) { }

        public SignLanguage GetSignLanguageById(int id)
        {
            return DataBaseContext.SignLanguages.Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
