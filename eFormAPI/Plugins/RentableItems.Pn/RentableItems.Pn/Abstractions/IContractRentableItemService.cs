using System.Threading.Tasks;
using Microting.eFormApi.BasePn.Infrastructure.Models.API;
using RentableItems.Pn.Infrastructure.Models;

namespace RentableItems.Pn.Abstractions
{
    public interface IContractRentableItemService
    {
        Task<OperationDataResult<RentableItemsModel>> Index(int contractId);
    }
}