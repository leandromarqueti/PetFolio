using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;
public class RequestRegisterPetJson
{
    public required string Name { get; set; } = string.Empty;   
    public DateTime BirthDay { get; set; }
    public PetType PetType { get; set; }
}
