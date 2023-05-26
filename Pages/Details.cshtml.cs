using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TagHelpersDemo.Pages
{
    public class DetailsModel : PageModel
    {
        public string NumberOfInserts { get; set; } = "35";
        public string ReservationLimit { get; set; } = "4";
        public string EnvelopeReturnAddressBlock { get; set; } = "266 Pike St Walterboro, SC 29488";
        public string MailingAmount { get; set; } = "7,500";
        public string DoNotMailListToScrub { get; set; } = "Dark Web\r\n";
        public string ScrubNationalChangeOfAddress { get; set; } = "No";
        public string IsNonProfit { get; set; } = "No";
        public string PurchasedListOrderNumber { get; set; } = "8675309";
        public string NumberOfExtraMailings { get; set; } = "50";
        public string ExtrasAddressBlock { get; set; } = "150 Main St Walterboro, SC 29488";
        public string SeedAddressBlock { get; set; } = "150 Main St Walterboro, SC 29488";
        public string ProductionNotes { get; set; } = "";
        public string JobName { get; set; } = "Chalk-8675309";
        public string SalesRepName { get; set; } = "Jack Sparrow";
        public string ReceivedDate { get; set; } = "May 25th";
        public string MailDate { get; set; } = "June 1st";
        public string MailPiece { get; set; } = "11x17 Brochure Full Color";
        public string EnvelopeType { get; set; } = "#10 Envelope";
        public string PostageClass { get; set; } = "1st Class";
        public string PostageType { get; set; } = "Stamp";
    }
}
