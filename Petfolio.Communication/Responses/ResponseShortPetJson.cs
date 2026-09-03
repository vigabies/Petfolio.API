using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
//esta devolvendo poucas info

public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public PetType Type { get; set; }


}
