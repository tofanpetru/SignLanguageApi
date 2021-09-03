using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using System.Collections;
using System.Collections.Generic;

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

        public SignLanguageDTO GetSignUrlByWord(string word)
        {
            return _mapper.Map<SignLanguageDTO>(_signLanguageRepository.FindSignLanguageUrlByWord(word));
        }
        public SignLanguageDTO Get(int id)
        {
            return _mapper.Map<SignLanguageDTO>(_signLanguageRepository.Get(id));
        }
        public ICollection<SignLanguageDTO> GetAll()
        {
            return _mapper.Map<ICollection<SignLanguageDTO>>(_signLanguageRepository.GetAll());
        }
    }
}
