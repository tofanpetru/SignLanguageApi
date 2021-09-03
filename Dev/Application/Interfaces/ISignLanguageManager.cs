using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ISignLanguageManager
    {
        public SignLanguageDTO GetSignUrlByWord(string word);
        public SignLanguageDTO Get(int id);
        public ICollection<SignLanguageDTO> GetAll();
    }
}
