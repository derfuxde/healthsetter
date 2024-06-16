using UnityEngine;
using HarmonyLib;
using System;
using System.Runtime.CompilerServices;

public class HealthSetter : Mod
{
    private const string SName = "<color=#0000FF>Health Setter : </color>";
    private const string Error = "<color=#ff0000>Health Setter Error : </color>";
    private const string Loaded = "<color=#0000FF>Health Setter : </color><color=#ffd900>Health Setter Mod has been Loaded!</color>";
    private const string UnLoaded = "<color=#0000FF>Health Setter : </color><color=#ffd900>Health Setter Mod has been UnLoaded!</color>";

    private static int maxHealth = 100;
    private static int maxThirst = 100;
    private static int maxHunger = 100;
    private static int maxOxygen = 100;

    public void Start()
    {
        Debug.Log(Loaded);
        ExtraSettingsAPI_Load();
    }

    public void OnModUnload()
    {
        Debug.Log(UnLoaded);
        ExtraSettingsAPI_Unload();
    }

    [ConsoleCommand("sethealth", "set your health")]
    private static void sethealth(string[] args)
    {
        if (args.Length < 1)
        {
            Debug.Log(Error + "Missing Health Value");
            return;
        }

        if (!int.TryParse(args[0], out int healthint))
        {
            Debug.Log(Error + "Invalid Health");
            return;
        }

        if (healthint > maxHealth)
        {
            Debug.Log(Error + $"Max = {maxHealth}");
            return;
        }

        if (healthint < 1)
        {
            Debug.Log(Error + "Min = 1");
            return;
        }
        
        if(args.Length == 1)
        {
            RAPI.GetLocalPlayer().Stats.stat_health.Value = healthint;
            Debug.Log(SName + "health was set " + healthint);
        }

        if(args.Length > 0)
        {
            var players = FindObjectsOfType<Network_Player>();

            foreach (var player in players)
            {
                string[] names = player.name.Split(',');
                string trimmed = names[1].Trim();

                if(players.Length == 1 && args[1] != trimmed)
                {
                    Debug.Log(Error + "The only player is you " + trimmed);
                }
                if(players.Length == 1 && args[1] == trimmed)
                {
                    RAPI.GetLocalPlayer().Stats.stat_health.Value = healthint;
                    Debug.Log(SName + "health was set " + healthint + " for " + trimmed);
                }
                

                if(trimmed == args[1])
                {
                    player.Stats.stat_health.Value = healthint;
                    Debug.Log(SName + "health was set " + healthint + " for " + trimmed);
                }
            }
        }
    }

    [ConsoleCommand("health", "set your health")]
    private static void health(string[] args)
    {
        sethealth(args);
    }

    [ConsoleCommand("setthirsty", "set your thirst")]
    private static void setthirsty(string[] args)
    {
        if (args.Length < 1)
        {
            Debug.Log(Error + "Missing Thirst Value");
            return;
        }

        if (!int.TryParse(args[0], out int thirstint))
        {
            Debug.Log(Error + "Invalid Thirst");
            return;
        }

        if (thirstint > maxThirst)
        {
            Debug.Log(Error + $"Max = {maxThirst}");
            return;
        }

        if (thirstint < 1)
        {
            Debug.Log(Error + "Min = 1");
            return;
        }

        if(args.Length == 1)
        {
            RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = thirstint;
            Debug.Log(SName + "thirst was set " + thirstint);
        }

        if(args.Length > 0)
        {
            var players = FindObjectsOfType<Network_Player>();

            foreach (var player in players)
            {
                string[] names = player.name.Split(',');
                string trimmed = names[1].Trim();

                if(players.Length == 1 && args[1] != trimmed)
                {
                    Debug.Log(Error + "The only player is you" + trimmed);
                }
                if(players.Length == 1 && args[1] == trimmed)
                {
                    RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = thirstint;
                    Debug.Log(SName + "thirst was set " + thirstint + " for " + trimmed);
                }
                

                if(trimmed == args[1])
                {
                    player.Stats.stat_thirst.Normal.Value = thirstint;
                    Debug.Log(SName + "thirst was set " + thirstint + " for " + trimmed);
                }
            }
        }
    }

    [ConsoleCommand("thirsty", "set your thirst")]
    private static void thirsty(string[] args)
    {
        setthirsty(args);
    }

    [ConsoleCommand("sethunger", "set your hunger")]
    private static void sethunger(string[] args)
    {
        if (args.Length < 1)
        {
            Debug.Log(Error + "Missing Hunger Value");
            return;
        }

        if (!int.TryParse(args[0], out int hungerint))
        {
            Debug.Log(Error + "Invalid Hunger");
            return;
        }

        if (hungerint > maxHunger)
        {
            Debug.Log(Error + $"Max = {maxHunger}");
            return;
        }

        if (hungerint < 1)
        {
            Debug.Log(Error + "Min = 1");
            return;
        }

        if(args.Length == 1)
        {
            RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = hungerint;
            Debug.Log(SName + "hunger was set " + hungerint);
        }

        if(args.Length > 0)
        {
            var players = FindObjectsOfType<Network_Player>();

            foreach (var player in players)
            {
                string[] names = player.name.Split(',');
                string trimmed = names[1].Trim();

                if(players.Length == 1 && args[1] != trimmed)
                {
                    Debug.Log(Error + "The only player is you" + trimmed);
                }
                if(players.Length == 1 && args[1] == trimmed)
                {
                    RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = hungerint;
                    Debug.Log(SName + "hunger was set " + hungerint + " for " + trimmed);
                }
                

                if(trimmed == args[1])
                {
                    player.Stats.stat_hunger.Normal.Value = hungerint;
                    Debug.Log(SName + "hunger was set " + hungerint + " for " + trimmed);
                }
            }
        }

        
    }

    [ConsoleCommand("hunger", "set your hunger")]
    private static void hunger(string[] args)
    {
        sethunger(args);
    }

    [ConsoleCommand("setoxygen", "set your oxygen")]
    private static void setoxygen(string[] args)
    {
        if (args.Length < 1)
        {
            Debug.Log(Error + "Missing Oxygen Value");
            return;
        }

        if (!int.TryParse(args[0], out int oxygenint))
        {
            Debug.Log(Error + "Invalid Oxygen");
            return;
        }

        if (oxygenint > maxOxygen)
        {
            Debug.Log(Error + $"Max = {maxOxygen}");
            return;
        }

        if (oxygenint < 1)
        {
            Debug.Log(Error + "Min = 1");
            return;
        }

        if(args.Length == 1)
        {
            RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = oxygenint;
            Debug.Log(SName + "oxygen was set " + oxygenint);
        }

        if(args.Length > 0)
        {
            var players = FindObjectsOfType<Network_Player>();

            foreach (var player in players)
            {
                string[] names = player.name.Split(',');
                string trimmed = names[1].Trim();

                if(players.Length == 1 && args[1] != trimmed)
                {
                    Debug.Log(Error + "The only player is you" + trimmed);
                     
                }
                if(players.Length == 1 && args[1] == trimmed)
                {
                    RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = oxygenint;
                    Debug.Log(SName + "oxygen was set " + oxygenint + " for " + trimmed);
                }
                

                if(trimmed == args[1])
                {
                    player.Stats.stat_oxygen.Value = oxygenint;
                    Debug.Log(SName + "oxygen was set " + oxygenint + " for " + trimmed);
                }
            }
        }

        RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = oxygenint;
        Debug.Log(SName + "oxygen was set " + oxygenint);
    }

    [ConsoleCommand("oxygen", "set your oxygen")]
    private static void oxygen(string[] args)
    {
        setoxygen(args);
    }

    [ConsoleCommand("refill", "refill your health, hunger, thirst, and oxygen")]
    private static void refill(string[] args)
    {
        RAPI.GetLocalPlayer().Stats.stat_health.Value = maxHealth;
        RAPI.GetLocalPlayer().Stats.stat_thirst.Normal.Value = maxThirst;
        RAPI.GetLocalPlayer().Stats.stat_hunger.Normal.Value = maxHunger;
        RAPI.GetLocalPlayer().Stats.stat_oxygen.Value = maxOxygen;

        Debug.Log(SName + "All stats refilled to maximum values.");
    }

    [ConsoleCommand("healthhelp", "all commands for health setter")]
    private static void healthhelp(string[] args)
    {
        if (args.Length < 1)
        {
            Debug.Log(SName + "sethealth or health (count)" + " = set your health");
            Debug.Log(SName + "sethunger or hunger (count)" + " = set your hunger");
            Debug.Log(SName + "setthirsty or thirsty (count)" + " = set your thirst");
            Debug.Log(SName + "setoxygen or oxygen (count)" + " = set your oxygen");
            Debug.Log(SName + "refill" + " = refill your health, hunger, thirst and oxygen");
        }
        else
        {
            Debug.Log(Error + "use cmd \"help\" only!");
        }
    }

    // ExtraSettingsAPI methods
    public void ExtraSettingsAPI_Load()
    {
        ExtraSettingsAPI_SetInputValue("maxHealth", maxHealth.ToString());
        ExtraSettingsAPI_SetInputValue("maxThirst", maxThirst.ToString());
        ExtraSettingsAPI_SetInputValue("maxHunger", maxHunger.ToString());
        ExtraSettingsAPI_SetInputValue("maxOxygen", maxOxygen.ToString());
    }

    public void ExtraSettingsAPI_Unload()
    {
        // Cleanup if necessary
    }

    public void ExtraSettingsAPI_SettingsOpen()
    {
        // Called when settings menu is opened
    }

    public void ExtraSettingsAPI_SettingsClose()
    {
        // Called when settings menu is closed
        maxHealth = Convert.ToInt32(ExtraSettingsAPI_GetInputValue("maxHealth"));
        maxThirst = Convert.ToInt32(ExtraSettingsAPI_GetInputValue("maxThirst"));
        maxHunger = Convert.ToInt32(ExtraSettingsAPI_GetInputValue("maxHunger"));
        maxOxygen = Convert.ToInt32(ExtraSettingsAPI_GetInputValue("maxOxygen"));
    }

    
    public static void ExtraSettingsAPI_SaveSettings() { }

    
    public static string ExtraSettingsAPI_GetInputValue(string SettingName) => "";

    
    public static void ExtraSettingsAPI_SetInputValue(string SettingName, string value) { }
}
