using SageHackbarthWeek2.Models;
using SageHackbarthWeek2.Shared.Enums;
using SageHackbarthWeek2.Shared.Orchestrators;
using System.Web.Mvc;

namespace SageHackbarthWeek2.Controllers
{
	public class PersonelController : Controller
    {
		// GET: Personel
		public ActionResult Index()
		{
			var personelOrchestrator = new PersonelOrchestrator();
			var genderModel = new GenderModel
			{
				Personel = personelOrchestrator.GetAllPersonel(),
				Gender = GenderEnum.Male,
				Age = 26,
				Major = "Psychiatry"
			};

            return View(genderModel);
        }
    }
}