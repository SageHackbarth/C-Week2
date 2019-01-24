using SageHackbarthWeek2.Shared.ViewModel;
using System.Collections.Generic;

namespace SageHackbarthWeek2.Shared.Orchestrators.Interfaces
{
	public interface IPersonelOrchestrator
	{
		List<PersonelViewModel> GetAllPersonel();
	}
}
