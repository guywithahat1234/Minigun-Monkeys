using MelonLoader;
using BTD_Mod_Helper;
using Minigun_Monkeys;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(Minigun_Monkeys.Minigun_Monkeys), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Minigun_Monkeys;

public class Minigun_Monkeys : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Minigun_Monkeys>("TestMod loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
            ModHelper.Msg<Minigun_Monkeys>($"Changed {weapon.name} rate to {weapon.rate}.");
        }
    }
}