using FluentValidation;

namespace CortexAPI.Features.Xxxx;

public class UpdateXxxxEndpoint : ICarterModule {
	public void AddRoutes(IEndpointRouteBuilder app) {
		app.MapPut("Features/Template/Xxxx", async (XxxxUpdateRequest request, ISender sender) => {
			var command = new UpdateXxxx.Command { Xxxx = request };
			var result = await sender.Send(command);

			if (result.IsFailure) {
				return Results.BadRequest(result.Error);
			}

			return Results.Ok(result.Value);
		})
		.Produces<int>()
		.RequireAuthorization("APIUser")
		.WithMetadata(new RouteMetadata { Tags = new[] { "Profiles" } });
	}
}

public static partial class UpdateXxxx {
	public class Command : IRequest<Result<int>> {
		public XxxxUpdateRequest? Xxxx { get; set; }
	}

	public class Validator : AbstractValidator<Command> {
		public Validator() {
			RuleFor(x => x.Xxxx)
				.NotNull()
				.WithMessage("No xxxx data provided.");

			RuleFor(x => x.Xxxx!.StateID)
				.GreaterThan(0)
				.WithMessage("The StateID cannot be zero.");

			RuleFor(x => x.Xxxx!.BranchID)
				.GreaterThan(0)
				.WithMessage("The BranchID cannot be zero.");

			RuleFor(x => x.Xxxx!.TypeID)
				.GreaterThan(0)
				.WithMessage("TypeID cannot be zero.");
		}
	}

	internal sealed partial class XxxxHandler : IRequestHandler<Command, Result<int>> {

		private readonly ILogger<XxxxHandler> _logger;
		private readonly IValidator<Command> _validator;
		private readonly IXxxxData _xxxxdata;

		public XxxxHandler(ISender sender
			, IValidator<Command> validator
			, ILogger<XxxxHandler> logger
			, IXxxxData xxxxdata
		) {
			_validator = validator;
			_logger = logger;
			_xxxxdata = xxxxdata;
		}

		public async Task<Result<int>> Handle(Command request, CancellationToken cancellationToken) {
			var validationResult = _validator.Validate(request);
			if (!validationResult.IsValid) {
				return Result.Failure<int>(new Error("UpdateXxxx.Validation", validationResult.ToString()));
			}
			int xxxxID = request.Xxxx!.ID;
			int stateID = request.Xxxx!.StateID;
			int typeID = request.Xxxx!.TypeID;
			int branchID = request.Xxxx!.BranchID;
			try {
				XxxxModel? existxxxx = await _xxxxdata.GetXxxx(xxxxID);
				if (existxxxx is null) {
					return Result.Failure<int>(new Error("UpdateXxxx", "The Xxxx with the specified ID was not found"));
				}
				await _xxxxdata.UpdateXxxx(xxxxID, typeID, stateID);

				return existxxxx.ID;
			} catch (Exception ex) {
				return Result.Failure<int>(new Error("UpdateXxxx.Exception", ex.Message));
			}
		}
	}
}