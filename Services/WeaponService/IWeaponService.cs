using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_RPG.Dtos.Weapon;

namespace DotNet_RPG.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}