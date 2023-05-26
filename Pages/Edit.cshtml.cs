using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TagHelpersDemo.Pages;

public class EditModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public void OnGet()
    {
    }

    public class InputModel
    {
        public string JobName { get; set; }
        public string SalesRepName { get; set; }
        public DateTime? MailDate { get; set; }
        public int? NumberOfExtraMailings { get; set; }
        public string ExtrasAddressLine1 { get; set; }
        public string ExtrasAddressLine2 { get; set; }
        public string ExtrasAddressCity { get; set; }
        public string ExtrasAddressStateOrProvince { get; set; }
        public string ExtrasAddressZipCode { get; set; }
    }
}
