using MelonLoader;
using BTD_Mod_Helper;
using Hypersonic_Projectiles;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(Hypersonic_Projectiles.Hypersonic_Projectiles), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Hypersonic_Projectiles;

public class Hypersonic_Projectiles : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Hypersonic_Projectiles>("Hypersonic_Projectiles loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
            ModHelper.Msg<Hypersonic_Projectiles>($"Changed {weapon.name} rate to {weapon.rate}.");
        }
    }
}