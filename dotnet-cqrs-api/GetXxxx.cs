using CallCenterWS;
using FluentValidation;

namespace CortexAPI.Features.Xxxx;

public class GetXxxxEndpoint : ICarterModule {
	public void AddRoutes(IEndpointRouteBuilder app) {

		app.MapGet("Features/Template/{branchID:int}/Xxxx/{xxxxID:int}", async (int branchID, int xxxxID, ISender sender) => {
			var query = new GetXxxx.XxxxQuery { BranchID = branchID, XxxxID = xxxxID };

			var result = await sender.Send(query);

			if (result.IsFailure) {
				return Results.NotFound(result.Error);
			}

			return Results.Ok(result.Value);
		})
		.Produces<XxxxResponse>()
		.RequireAuthorization("APIUser")
		.WithMetadata(new RouteMetadata { Tags = new[] { "Features" } });
	}
}

public static class GetXxxx {
	public class XxxxQuery : IRequest<Result<XxxxResponse>> {
		public int BranchID { get; set; } = 0;
		public int XxxxID { get; set; } = 0;
	}

	public class Validator : AbstractValidator<XxxxQuery> {
		public Validator() {
			RuleFor(x => x.BranchID)
			.GreaterThan(0)
			.WithMessage("The BranchID cannot be zero.");

			RuleFor(x => x.XxxxID)
				.GreaterThan(0)
				.WithMessage("XxxxID cannot be zero.");
		}
	}

	internal sealed class Handler : IRequestHandler<XxxxQuery, Result<XxxxResponse>> {

		private readonly ILogger<Handler> _logger;
		private readonly IValidator<XxxxQuery> _validator;
		private readonly IXxxxData _xxxxdata;

		public Handler(ILogger<Handler> logger
			, IValidator<XxxxQuery> validator
			, CallCenterWsSoapClient soapClient
			, IXxxxData xxxxdata
		) {
			_logger = logger;
			_validator = validator;
			_xxxxdata = xxxxdata;
		}

		public async Task<Result<XxxxResponse>> Handle(XxxxQuery request, CancellationToken cancellationToken) {
			var validationResult = _validator.Validate(request);
			if (!validationResult.IsValid) {
				return Result.Failure<XxxxResponse>(new Error("GetXxxx.Validation", validationResult.ToString()));
			}

			XxxxResponse? xxxx = await GetXxxx(request);

			if (xxxx is null) {
				return Result.Failure<XxxxResponse>(new Error(
					"GetXxxx.Null",
					"The xxxx with the specified BranchID and XxxxID was not found"));
			}
			return xxxx;
		}

		private async Task<XxxxResponse?> GetXxxx(XxxxQuery request) {
			var xxxx = await _xxxxdata.GetXxxx(request.XxxxID);
			if (xxxx is null) {
				return null;
			}
			
			var xxxxResponse = xxxx.Adapt<XxxxResponse>();
			if (xxxxResponse is not null) {
				// Process response in some way
			}

			return xxxxResponse;
		}
	}
}

