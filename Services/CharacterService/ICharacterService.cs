using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotNet_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        // Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter(int userId);
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter();
        Task<ServiceResponse<GetCharacterDto>> GetSingleCharacter(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}