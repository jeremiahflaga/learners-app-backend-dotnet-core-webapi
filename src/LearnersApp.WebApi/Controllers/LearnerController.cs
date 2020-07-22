using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnersApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnersApp.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LearnerController : ControllerBase
	{
		[HttpGet]
		[Route("{learnerId}/history")]
		public IEnumerable<LearnerHistory> GetHistory(Guid learnerId)
		{
			return new List<LearnerHistory>
			{
				new LearnerHistory(learnerId, new Article(Guid.NewGuid())
				{
					Title = "A Little Architecture",
					Author = "Uncle Bob Martin",					
				})
                {
					DateFrom = DateTimeOffset.Parse("2016/03/02"),
					DateTo = DateTimeOffset.Parse("2016/03/04"),
					TimeZoneId = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time").Id,
				}
			};
		}
	}
}
