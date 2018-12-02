using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models {
    public class EmailFormModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string FromName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string FromEmail { get; set; }

        [RegularExpression(@"/^\D*(\d{3})\D*(\d{3})\D*(\d{4})$/", ErrorMessage = "Please provide a 10 digit phone number")]
        public string FromPhoneNumber { get; set; }

        [Required(ErrorMessage = "A message is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "A name is required")]
        public string Message { get; set; }

        public string GetFormattedEmailBody()
        {
            return $"<p><b>Name:</b> {FromName}</p>"
                + $"<p><b>Email:</b> {FromEmail}</p>"
                + $"<p><b>PhoneNumber:</b> {FromPhoneNumber ?? "N/A"}</p>"
                + $"<p><b>Subject:</b> {Subject}</p>"
                + $"<p><b>Message:</b></p><p>{Message}</p>";
        }
    }
}
