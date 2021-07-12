using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISignLanguageManager
    {
        public SignLanguageWordDetailsDTO GetSignLanguageWordDetails(int id);
    }
}
