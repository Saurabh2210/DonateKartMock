using System;

namespace DonatreKartMockApplication.PublicInterfaces
{
    public interface IDonor
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Contact { get; set; }
    }
}
