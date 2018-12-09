using System;
using System.Net;
using DonatreKartMockApplication.Helper;
using DonatreKartMockApplication.Repository;

namespace DonatreKartMockApplication.Modules
{
    public class DonorCreatorModule :NancyModule
    {
        
        public DonorCreatorModule(IDonorRepositoty donorRepositoty )
        {
            Post["/donor"] =
                routeParams =>
                {
                    var id = Guid.NewGuid();
                    var name = (string)routeParams.Name;
                    var contact = (string)routeParams.Conatact;
                    var email = (string)routeParams.Email;

                    var daDonor = new DataAccess.Donor()
                    {
                        Id = id,
                        Name = name,
                        Contact = contact,
                        Email = email
                    };

                    donorRepositoty.AddDonor(daDonor);
                    const string subject = "Donor creation";
                    const string messsage = "Hi, Your account has been created";
                    LoggingFactory.GetLogger().InfoFormat("Donor is created");
                    var emailHandler = new EmailHandler(email, subject, messsage);
                    emailHandler.SendEmail();
                    return Negotiate.WithStatusCode(HttpStatusCode.Created);

                };
        }
    }
}
