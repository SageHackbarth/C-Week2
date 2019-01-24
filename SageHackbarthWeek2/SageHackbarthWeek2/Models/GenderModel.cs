using SageHackbarthWeek2.Shared.Enums;
using SageHackbarthWeek2.Shared.ViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SageHackbarthWeek2.Models
{
	public class GenderModel
	{
		[Display(Name = "Age: ")]
		public int Age { get; set; }
		[Display(Name = "Major: ")]
		public string Major { get; set; }
		public GenderEnum Gender { get; set; }
		[Display(Name = "Gender: ")]
		public string PersonelGender => Gender.ToString();
		public List<PersonelViewModel> Personel { get; set; }
	}
}