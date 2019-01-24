using SageHackbarthWeek2.Shared.Orchestrators.Interfaces;
using SageHackbarthWeek2.Shared.ViewModel;
using System.Collections.Generic;

namespace SageHackbarthWeek2.Shared.Orchestrators
{
	public class PersonelOrchestrator : IPersonelOrchestrator
	{
		public List<PersonelViewModel> GetAllPersonel()
		{
			var personel = new List<PersonelViewModel>
			{
				new PersonelViewModel
				{
					FName = "Shawn",
					LName = "Spencer",
					Age = 26,
					Major = "Psychiatry"
				},
				new PersonelViewModel
				{
					FName = "Burton",
					LName = "Guster",
					Age = 26,
					Major = "Pharmaceuticals"
				}
			};

			return personel;
		}
	}
}
