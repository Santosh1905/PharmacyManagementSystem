using PharmacyManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Repository
{
    public interface IDrugRepository
    {
        DrugDetail Create(DrugDetail drugDetail);
        Task<IEnumerable<DrugDetail>> GetAll();

        DrugDetail GetDrugName(string drugName);
        DrugDetail GetDrug(int id);
        void DeleteDrug(int id);
        void UpdateDrug(DrugDetail drugDetail);
    }
}