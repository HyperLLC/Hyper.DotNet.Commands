using System;
using UIExample.Razor.Interfaces;
using Microsoft.Extensions.Logging;
using CommonDeliveryFramework;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace UIExample.Razor.Models
{
	public class PageModel : IPage
	{
		/// <summary>
		/// Logger for all logging interactions in the class.
		/// </summary>
		private readonly ILogger _logger;		
		
		[RequiredAttribute(ErrorMessage = "{0} is required")]
		[StringLengthAttribute(50, MinimumLength = 3, ErrorMessage = "Page Name should be minimum 3 characters and a maximum of 50 characters")]
		[DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Text)]
		public string PageName { get; set; }

		
		[RequiredAttribute(ErrorMessage = "{0} is required")]
		[DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Text)]
		public string PageId { get; set; }

		
		[RequiredAttribute(ErrorMessage = "{0} is required")]
		[DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
		public string PageContent { get; set; }								

		
		public void GetPageContent(string pageName, string description, int pageId)
		{
			_logger.InformationEnterLog();
		
			if(string.IsNullOrEmpty(pageName))
			{
				_logger.ErrorLog($"The parameter {nameof(pageName)} was not provided. Will raise an argument exception");
				_logger.InformationExitLog();
				throw new ValidationException(nameof(pageName));
			}
		
			if(string.IsNullOrEmpty(description))
			{
				_logger.ErrorLog($"The parameter {nameof(description)} was not provided. Will raise an argument exception");
				_logger.InformationExitLog();
				throw new ValidationException(nameof(description));
			}
		
			try
			{
				//TODO: add execution logic here
			}
			catch (ManagedException)
			{
				//Throwing the managed exception. Override this logic if you have logic in this method to handle managed errors.
				throw;
			}
			catch (Exception unhandledException)
			{
				_logger.ErrorLog("An unhandled exception occured, see the exception for details. Will throw a UnhandledException", unhandledException);
				_logger.InformationExitLog();
				throw new UnhandledException();
			}
		
			_logger.InformationExitLog();
			throw new NotImplementedException();
		}
			}
}