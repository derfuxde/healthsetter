using UnityEngine;
using HarmonyLib;
using System;
using System.Globalization;
using System.Threading.Tasks;

public class healthsetter : Mod
{

  private const string SName = "<color=#0000FF>Health Setter : </color>";
  private const string Error = "<color=#ff0000>Health Setter Error : </color>";
  private const string Loaded = "<color=#0000FF>Health Setter : </color><color=#ffd900>Health Setter Mod has been Loaded!</color>";
  private const string UnLoaded = "<color=#0000FF>Health Setter : </color><color#ff0000>Health Setter Mod has been UnLoaded!</color>";


    public void Start()
    {
        Debug.Log(Loaded);
    }

    public void OnModUnload()
    {
        Debug.Log(UnLoaded);
    }

    [ConsoleCommand("sethealth", "set your health")]
    private static void sethealth(string[] args)
    {
      int healthint = 10;
      if (!int.TryParse(args[0], out healthint))
      {
          Debug.Log(Error + "Invalid Health");
          return;
      }
      if (healthint > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (healthint < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_health.Value = healthint;
      Debug.Log(SName + "health was set " + healthint);
    }

    [ConsoleCommand("setthirsty", "set your thirsty")]
    private static void setthirsty(string[] args)
    {
      int thirstyint = 10;
      if (!int.TryParse(args[0], out thirstyint))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (thirstyint > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (thirstyint < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = thirstyint;
      Debug.Log(SName + "thirsty was set " + thirstyint);
    }

    [ConsoleCommand("sethunger", "set your hunger")]
    private static void sethunger(string[] args)
    {
      int hungerint = 10;
      if (!int.TryParse(args[0], out hungerint))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (hungerint > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (hungerint < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = hungerint;
      Debug.Log(SName + "hunger was set " + hungerint);
    }
}
