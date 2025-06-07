using System.Collections.Generic;
using VidlyV1.Models;

namespace VidlyV1.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}