using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbcCompany.Models
{
    public class ResellerViewModel
    {
        public int Id { get; set; }

        [DisplayName("Reseller Name")]
        public string ResellerName { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Fax Number")]
        public int FaxNumber { get; set; }

        [DisplayName("Contact Person Name ")]
        public string ContactPersonName { get; set; }

        [DisplayName("Contact Person Phone Number")]
        public int ContactPersonPhoneNumber { get; set; }
    }
}
