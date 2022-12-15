using AutoMapper;
using Domain.DataTransferObject;
using Domain.DataTransferObject.AddDTO;
using Domain.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemtaion
{
    public class DepertmentService : IDepertmentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public DepertmentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public DepertmentDTO AddDepertment(DepertmentAddDTO depertment)
        {
            if (depertment == null)
                return null;
            var dep = _mapper.Map<Depertment>(depertment);
            _repositoryManager.departmentRepository.AddDepertment(dep);
            _repositoryManager.save();
            var DepToReturn = _mapper.Map<DepertmentDTO>(dep);
            return DepToReturn;
        }

        public DepertmentDTO DeletDepertment(int depId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepertmentDTO> GetAllDepertments()
        {
            var deps = _repositoryManager.departmentRepository.GetAllDepertment();
            if (deps == null)
                return null;
            var depertments = _mapper.Map<IEnumerable<DepertmentDTO>>(deps);
            return depertments;
        }

        public DepertmentDTO GetDepertment(int depId)
        {
            var depertment = _repositoryManager.departmentRepository.GetDepertment(depId);
            if (depertment == null)
                return null;
            return _mapper.Map<DepertmentDTO>(depertment);
        }

        public DepertmentDTO updateDepertment(DepertmentDTO depertment)
        {
            var dep = _repositoryManager.departmentRepository.GetDepertment(depertment.Id);
            if (dep == null)
                return null;
            _mapper.Map(depertment, dep);
            _repositoryManager.save();
            return GetDepertment(dep.Id);
        }
    }
}