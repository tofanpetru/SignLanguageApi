using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repository.Interfaces;

namespace Application.Manager
{
    public class SignLanguageManager : ISignLanguageManager
    {
        private readonly ISignLanguageRepository _signLanguageRepository;
        private readonly IMapper _mapper;

        public SignLanguageManager(ISignLanguageRepository signLanguageRepository, IMapper mapper)
        {
            _signLanguageRepository = signLanguageRepository;
            _mapper = mapper;
        }

        public SignLanguageWordDetailsDTO GetSignLanguageWordDetails(int id)
        {
            var signLanguageWord = _signLanguageRepository.GetSignLanguageById(id);
            if (signLanguageWord != null)
            {
                return _mapper.Map<SignLanguageWordDetailsDTO>(signLanguageWord);
            }
            else
            {
                return null;
            }
        }
    }
}
