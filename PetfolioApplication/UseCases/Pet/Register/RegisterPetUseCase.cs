using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace PetfolioApplication.UseCases.Pet.Register;

public  class RegisterPetUseCase
{

    public ResponseRegisteredPetJson Execute(RequestRegisterPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
        };
    }
}
