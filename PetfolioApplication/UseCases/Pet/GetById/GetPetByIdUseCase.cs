using Petfolio.Communication.Responses;

namespace PetfolioApplication.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{

    public ResponsePetJson Execute(int id)
    {
        // Implementation for getting pet by ID
        return new ResponsePetJson
        {
            Id = id,
            Name = "Pipoca",
            Birthday = new DateTime(year: 2020, month: 5, day: 15),
            Type = Petfolio.Communication.Enums.PetType.Cat,
        };
    }
}
