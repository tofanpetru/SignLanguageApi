using Infrastructure.Persistance;

namespace Infrastructure.Repository.Interfaces
{
    public interface ISignLanguageRepository : IRepository<SignLanguage>
    {
        public SignLanguage GetSignLanguageById(int id);
    }
}
