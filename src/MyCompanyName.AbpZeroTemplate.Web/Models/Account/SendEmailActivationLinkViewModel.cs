using System.ComponentModel.DataAnnotations;

namespace MyCompanyName.AbpZeroTemplate.Web.Models.Account
{
    public class SendEmailActivationLinkViewModel
    {
        public string TenancyName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}