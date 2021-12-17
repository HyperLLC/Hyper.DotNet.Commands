using System.ComponentModel.DataAnnotations;

namespace UIExample.Razor.Interfaces
{
	public interface IPage
	{
		[Required(ErrorMessage = "{0} is required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Page Name should be minimum 3 characters and a maximum of 50 characters")]
		[DataType(DataType.Text)]
		string PageName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[DataType(DataType.Text)]
		string PageId { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[DataType(DataType.MultilineText)]
		string PageContent { get; set; }

		void GetPageContent(string pageName, string description, int pageId);

	}
}