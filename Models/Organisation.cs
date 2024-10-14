using System.ComponentModel.DataAnnotations;

namespace LookupFunction.Models;

public class Organisation
{
	[Required]
	public string Name { get; set; }
	public string LookupId { get; set; }
	public string Country { get; set; }
	[Required]
	public string OrganisationId { get; set; }
}
