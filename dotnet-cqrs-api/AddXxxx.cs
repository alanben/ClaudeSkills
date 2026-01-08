using FluentValidation;

namespace CortexAPI.Features.Xxxx;

public class AddXxxxEndpoint : ICarterModule {
	public void AddRoutes(IEndpointRouteBuilder app) {
		app.MapPost("Features/Template/Xxxx", async (XxxxAddRequest request, ISender sender) => {
			var command = new AddXxxx.Command { Xxxx = request };
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

public static partial class AddXxxx {
	public class Command : IRequest<Result<int>> {
		public XxxxAddRequest? Xxxx { get; set; }
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
				return Result.Failure<int>(new Error("AddXxxx.Validation", validationResult.ToString()));
			}
			try {
				XxxxModel newxxxx = request.Xxxx!.Adapt<XxxxModel>();
				var xxxx = await _xxxxdata.AddXxxx(newxxxx);
				if (xxxx is null) {
					return Result.Failure<int>(new Error("AddXxxx", "Failed to add Xxxx"));
				}

				return xxxx.ID;
			} catch (Exception ex) {
				return Result.Failure<int>(new Error("AddXxxx.Exception", ex.Message));
			}
		}
	}
}