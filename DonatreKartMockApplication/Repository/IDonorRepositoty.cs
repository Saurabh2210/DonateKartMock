using System;
using DonatreKartMockApplication.DataAccess;

namespace DonatreKartMockApplication.Repository
{
    public interface IDonorRepositoty
    {
        void AddDonor(Donor donor);
        Donor GetDonors(Guid id);
    }
}
