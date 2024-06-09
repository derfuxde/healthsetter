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
  private const string UnLoaded = "<color=#0000FF>Health Setter : </color><color=#ffd900>Health Setter Mod has been UnLoaded!</color>";


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
      int healthint = 100;
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

    [ConsoleCommand("health", "set your health")]
    private static void health(string[] args)
    {
      int healthin = 100;
      if (!int.TryParse(args[0], out healthin))
      {
          Debug.Log(Error + "Invalid Health");
          return;
      }
      if (healthin > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (healthin < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_health.Value = healthin;
      Debug.Log(SName + "health was set " + healthin);
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

    [ConsoleCommand("bonushealth", "set your bonus health")]
    private static void bonushp(string[] args)
    {
      int bonushpint = 10;
      if (!int.TryParse(args[0], out bonushpint))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (bonushpint > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (bonushpint < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_BonusHealth.Value = bonushpint;
      Debug.Log(SName + "Bonushealth was set " + bonushpint);
    }

    [ConsoleCommand("thirsty", "set your thirsty")]
    private static void thirsty(string[] args)
    {
      int thirstyin = 10;
      if (!int.TryParse(args[0], out thirstyin))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (thirstyin > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (thirstyin < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = thirstyin;
      Debug.Log(SName + "thirsty was set " + thirstyin);
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

    [ConsoleCommand("hunger", "set your hunger")]
    private static void hunger(string[] args)
    {
      int hungerin = 10;
      if (!int.TryParse(args[0], out hungerin))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (hungerin > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (hungerin < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = hungerin;
      Debug.Log(SName + "hunger was set " + hungerin);
    }

    [ConsoleCommand("setoxygen", "set your oxygen")]
    private static void setoxygen(string[] args)
    {
      int oxygenint = 10;
      if (!int.TryParse(args[0], out oxygenint))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (oxygenint > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (oxygenint < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = oxygenint;
      Debug.Log(SName + "oxygenint was set " + oxygenint);
    }

    [ConsoleCommand("oxygen", "set your oxygen")]
    private static void oxygen(string[] args)
    {
      int oxygenin = 10;
      if (!int.TryParse(args[0], out oxygenin))
      {
          Debug.Log(Error + "Invalid Value");
          return;
      }
      if (oxygenin > 100) {
        Debug.Log(Error + "Max = 100");
        return;
      }
      if (oxygenin < 1) {
        Debug.Log(Error + "Min = 1");
        return;
      }
      RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = oxygenin;
      Debug.Log(SName + "oxygenint was set " + oxygenin);
    }

    [ConsoleCommand("refill", "refill health, thirst and hungry bar")]
    private static void refill(string[] args)
    {
        if (Raft_Network.InMenuScene)
        {
            Debug.Log(Error + "Is In Lobby");
            return;
        }
        if (args.Length < 1)
        {
            RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = 100;
            RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = 100;
            RAPI.GetLocalPlayer().Stats.stat_health.Value = 100;
            RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = 100;
        }
        else
        {
            Debug.Log(Error + "use cmd \"refill\" only!");
        }
    }

    [ConsoleCommand("healthhelp", "all command for health setter")]
    private static void healthhelp(string[] args)
    {
        if (args.Length < 1)
        {
          Debug.Log(SName + "sethealth or health (count)" + " = set your health");
          Debug.Log(SName + "sethunger or hunger (count)" + " = set your hunger");
          Debug.Log(SName + "setthirsty or thirst (count)" + " = set your thirst");
          Debug.Log(SName + "setoxygen or oxygen (count)" + " = set your oxygen");
          Debug.Log(SName + "refill" + " = refill your health, hunger, thirst and oxygen");
        }
        else
        {
            Debug.Log(Error + "use cmd \"help\" only!");
        }
    }
}
