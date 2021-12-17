using System;
using UIExample.Razor.Interfaces;
using Microsoft.Extensions.Logging;
using CommonDeliveryFramework;
using System.Threading.Tasks;

namespace UIExample.Razor.Models
{
	public class SampleModel: ISampleModel
	{

		/// <summary>
		/// Logger for all logging interactions in the class.
		/// </summary>
		private readonly ILogger _logger;
	
		public string RequestId { get; set; }
		
		public string RequestName { get; set; }
		
		public string RequestTitle { get; set; }
	}
}