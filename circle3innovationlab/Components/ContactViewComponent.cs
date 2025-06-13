using circle3innovationlab.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;

namespace circle3innovationlab.Components
{
    public class ContactViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Views/Partials/Forms/ContactForm.cshtml", new ContactFormViewModel());
        }
    }
}
