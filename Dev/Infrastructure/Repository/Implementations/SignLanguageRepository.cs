using Infrastructure.Persistance;
using Infrastructure.Repository.Abstract;
using Infrastructure.Repository.Interfaces;
using System.Linq;

namespace Infrastructure.Repository.Implementations
{
    public class SignLanguageRepository : AbstractRepository<SignLanguage>, ISignLanguageRepository
    {
        public SignLanguageRepository(SignLanguageContext context) : base(context) { }

        public string FindSignLanguageUrlByWord(string word)
        {
            return DataBaseContext.SignLanguages.Where(w => w.Word == word)
                                                .Select(x => x.WordVideoUrl)
                                                .FirstOrDefault();
        }
    }
}
