using Infrastructure.Persistance;

namespace Infrastructure.Repository.Interfaces
{
    public interface ISignLanguageRepository : IRepository<SignLanguage>
    {
        public string FindSignLanguageUrlByWord(string word);
    }
}
