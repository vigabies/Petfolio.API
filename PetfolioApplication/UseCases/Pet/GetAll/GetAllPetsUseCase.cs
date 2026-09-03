using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace PetfolioApplication.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{

    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson { Id = 1, Name = "Buddy", Type = PetType.Dog },
                new ResponseShortPetJson { Id = 2, Name = "Whiskers", Type = PetType.Cat },
            }
        };
    }
}
