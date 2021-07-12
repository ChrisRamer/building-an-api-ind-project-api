using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace AnimalShelterApi
{
	public class ApiErrorHandler : DefaultErrorResponseProvider
	{
		public override IActionResult CreateResponse(ErrorResponseContext context)
		{
			switch (context.ErrorCode)
			{
				case "UnsupportedApiVersion":
					context = new ErrorResponseContext(
						context.Request,
						context.StatusCode,
						"API or Route Error",
						"Unknown API version or route",
						context.MessageDetail);
					break;
			}

			return base.CreateResponse(context);
		}
	}
}