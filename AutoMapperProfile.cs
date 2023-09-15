using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_RPG.Dtos.Skill;
using DotNet_RPG.Dtos.Weapon;

namespace DotNet_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}