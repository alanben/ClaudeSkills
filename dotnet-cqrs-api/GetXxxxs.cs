using CallCenterWS;
using FluentValidation;

namespace CortexAPI.Features.Xxxx;

public class GetXxxxsEndpoint : ICarterModule {
	public void AddRoutes(IEndpointRouteBuilder app) {

		app.MapGet("Features/Template/{branchID:int}/Xxxx", async (int branchID, int StateID, int TypeID, ISender sender) => {
			var query = new GetXxxxs.XxxxQuery { BranchID = branchID, StateID = StateID, TypeID = TypeID };

			var result = await sender.Send(query);

			if (result.IsFailure) {
				return Results.NotFound(result.Error);
			}

			return Results.Ok(result.Value);
		})
		.Produces<IEnumerable<XxxxResponse>>()
		.RequireAuthorization("APIUser")
		.WithMetadata(new RouteMetadata { Tags = new[] { "Features" } });
	}
}

public static class GetXxxxs {
	public class XxxxQuery : IRequest<Result<IEnumerable<XxxxResponse>>> {
		public int BranchID { get; set; } = 0;
		public int StateID { get; set; } = 0;
		public int TypeID { get; set; } = 0;
		public string FromDate { get; set; } = String.Empty;
		public string ToDate { get; set; } = String.Empty;
	}

	public class Validator : AbstractValidator<XxxxQuery> {
		public Validator() {
			RuleFor(x => x.BranchID)
				.GreaterThan(0)
				.WithMessage("The BranchID cannot be zero.");
			
			RuleFor(x => x.FromDate)
				.Matches(@"\d{4}-\d{2}-\d{2}")
				.WithMessage("The FromDate must be in the format yyyy-MM-dd.");

			RuleFor(x => x.ToDate)
				.Matches(@"\d{4}-\d{2}-\d{2}")
				.WithMessage("The ToDate must be in the format yyyy-MM-dd.");
		}
	}

	internal sealed class Handler : IRequestHandler<XxxxQuery, Result<IEnumerable<XxxxResponse>>> {

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

		public async Task<Result<IEnumerable<XxxxResponse>>> Handle(XxxxQuery request, CancellationToken cancellationToken) {
			var validationResult = _validator.Validate(request);
			if (!validationResult.IsValid) {
				return Result.Failure<IEnumerable<XxxxResponse>>(new Error("GetXxxxs.Validation", validationResult.ToString()));
			}

			var xxxxs = await _xxxxdata.ListXxxxs(request.FromDate, request.ToDate, request.TypeID, request.StateID, request.BranchID, new ListSettings { SortBy = "", SortType = false });
			if (xxxxs is null) {
				return Result.Failure<IEnumerable<XxxxResponse>>(new Error(
					"GetXxxxs.Null",
					"Failed to get GetXxxxs"));
			}

			var xxxxsResponse = xxxxs.Adapt<List<XxxxResponse>>();

			return xxxxsResponse;
		}
	}
}

