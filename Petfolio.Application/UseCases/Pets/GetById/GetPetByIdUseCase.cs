using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int petId)
    {
        return new ResponsePetJson
        {
            Id = petId,
            Name = "Charlie",
            BirthDay = new DateTime(year: 2020, month: 5, day: 15),
            PetType = PetType.Dog
        };
    }
}
