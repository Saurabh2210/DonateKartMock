using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonatreKartMockApplication.DataAccess;

namespace DonatreKartMockApplication.Repository
{
    public class DonorRepository :IDonorRepositoty
    {
        public void AddDonor(Donor donor)
        {
            //Add Donor Implementation
        }

        public Donor GetDonors(Guid id)
        {
            //Implementation not written
            throw new NotImplementedException();
        }
    }
}
