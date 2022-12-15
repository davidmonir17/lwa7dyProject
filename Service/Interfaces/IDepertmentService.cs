using Domain.DataTransferObject;
using Domain.DataTransferObject.AddDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IDepertmentService
    {
        DepertmentDTO GetDepertment(int depId);

        IEnumerable<DepertmentDTO> GetAllDepertments();

        DepertmentDTO AddDepertment(DepertmentAddDTO depertment);

        DepertmentDTO DeletDepertment(int depId);

        DepertmentDTO updateDepertment(DepertmentDTO depertment);
    }
}