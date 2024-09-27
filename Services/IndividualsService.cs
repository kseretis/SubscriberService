using Grpc.Core;

namespace IndividualService.Services;

public class IndividualsService : Individuals.IndividualsBase
{
    private readonly ILogger<IndividualsService> _logger;
    
    public IndividualsService(ILogger<IndividualsService> logger)
    {
        _logger = logger;
    }
    
    public override Task<GetAllIndividualsResponse> GetIndividuals(GetAllIndividualsRequest request, ServerCallContext context)
    {
        var response = new GetAllIndividualsResponse();
        
        response.Individuals.Add(new GetAllIndividualsResponse.Types.Individual
        {
            Id = "a3sd761da12335",
            FirstName = "Makis",
            LastName = "Kotsampasis"
        });
   
        response.Individuals.Add(new GetAllIndividualsResponse.Types.Individual
        {
            Id = "dkjasd67a5sd",
            FirstName = "Maria",
            LastName = "Petropoulou"
        });
        
        return Task.FromResult(response);
    }
}