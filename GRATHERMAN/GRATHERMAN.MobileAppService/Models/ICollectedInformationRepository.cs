using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRATHERMAN.MobileAppService.Models
{
    public interface ICollectedInformationRepository
    {
        void Add(CollectedInformation c);
        void Update(CollectedInformation item);
        CollectedInformation Remove(string key);
        CollectedInformation Get(string id);
        IEnumerable<CollectedInformation> GetAll();
    }
}
