using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using InscryptionAPI.Sound;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]

    public class Plugin : BaseUnityPlugin
    {
        Harmony harmony = new Harmony(PluginGuid);

        private const string PluginGuid = "creator.hex.gramophone.add.tracks";
        private const string PluginName = "HexGramaphoneMod";
        private const string PluginVersion = "1.0.0";

        //Initializes the configs
        public ConfigEntry<bool> configEnableSuperWeaselKid;
        public ConfigEntry<bool> configEnableRadicalRoad;
        public ConfigEntry<bool> configEnableSWK_Prok_Version_2_Final4;
        public ConfigEntry<bool> configEnableFight;
        public ConfigEntry<bool> configEnableToTheTop;
        public ConfigEntry<bool> configEnableSadosTheme;
        public ConfigEntry<bool> configEnableLegendariaEternal;
        public ConfigEntry<bool> configEnableMojisTheme;
        public ConfigEntry<bool> configEnableBattleTheme;
        public ConfigEntry<bool> configEnableVallamirsTheme;
        public ConfigEntry<bool> configEnableMoltenPeak;
        public ConfigEntry<bool> configEnableBattleThemeSweatyDragonEdition;
        public ConfigEntry<bool> configEnableTheGreatDesert;
        public ConfigEntry<bool> configEnableBattleThemeSphinxEdition;
        public ConfigEntry<bool> configEnableERR_IRVING_PROTOCOL;
        public ConfigEntry<bool> configEnableTheWasteland;
        public ConfigEntry<bool> configEnableAlienModTrack1;
        public ConfigEntry<bool> configEnableScrapShop;
        public ConfigEntry<bool> configEnableDustbowlDannysTheme;
        public ConfigEntry<bool> configEnableTheVurm;
        public ConfigEntry<bool> configEnable4ATRDCZEROr_MOD;
        public ConfigEntry<bool> configEnableComingInHot;
        public ConfigEntry<bool> configEnableClearTheBarracks;
        public ConfigEntry<bool> configEnableShutDown;
        public ConfigEntry<bool> configEnableGoingUp;
        public ConfigEntry<bool> configEnableBreach;
        public ConfigEntry<bool> configEnableSanctuary;
        public ConfigEntry<bool> configEnableOH_SUS_DROPTABLE_;
        public ConfigEntry<bool> configEnableTheHex;

        public void Awake()
        {
            // Summpms The Config file
            configEnableSuperWeaselKid = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Super Weasel Kid?",
                                    true,
                                    "Should the 'Super Weasel Kid' Track Show up on the Gramophone?");
            configEnableRadicalRoad = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Radical Road",
                                    true,
                                    "Should the 'Radical Road' Track Show up on the Gramophone?");
            configEnableSWK_Prok_Version_2_Final4 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "SWK_Prok_Version_2_Final4?",
                                    true,
                                    "Should the 'SWK_Prok_Version_2_Final4' Track Show up on the Gramophone?");
            configEnableFight = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Fight!?",
                                    true,
                                    "Should the 'Fight!' Track Show up on the Gramophone?");
            configEnableToTheTop = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "To The Top?",
                                    true,
                                    "Should the 'To The Top' Track Show up on the Gramophone?");
            configEnableSadosTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Sados Theme?",
                                    true,
                                    "Should the 'Sado's Theme' Track Show up on the Gramophone?");
            configEnableLegendariaEternal = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Legendaria Eternal?",
                                    true,
                                    "Should the 'Legendaria Eternal' Track Show up on the Gramophone?");
            configEnableMojisTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Mojis Theme?",
                                    true,
                                    "Should the 'Moji's Theme' Track Show up on the Gramophone?");
            configEnableBattleTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Battle Theme?",
                                    true,
                                    "Should the 'Battle Theme' Track Show up on the Gramophone?");
            configEnableVallamirsTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Vallamirs Theme?",
                                    true,
                                    "Should the 'Vallamirs Theme' Track Show up on the Gramophone?");
            configEnableMoltenPeak = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Molten Peak?",
                                    true,
                                    "Should the 'Molten Peak' Track Show up on the Gramophone?");
            configEnableBattleThemeSweatyDragonEdition = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Battle Theme Sweaty Dragon Edition?",
                                    true,
                                    "Should the 'Battle Theme Sweaty Dragon Edition' Track Show up on the Gramophone?");
            configEnableTheGreatDesert = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Great Desert?",
                                    true,
                                    "Should the 'The Great Desert' Track Show up on the Gramophone?");
            configEnableBattleThemeSphinxEdition = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Battle Theme Sphinx Edition?",
                                    true,
                                    "Should the 'Battle Theme Sphinx Edition' Track Show up on the Gramophone?");
            configEnableERR_IRVING_PROTOCOL = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "ERR_IRVING_PROTOCOL?",
                                    true,
                                    "Should the 'ERR_IRVING_PROTOCOL' Track Show up on the Gramophone?");
            configEnableTheWasteland = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Wasteland?",
                                    true,
                                    "Should the 'The Wasteland' Track Show up on the Gramophone?");
            configEnableAlienModTrack1 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Alien Mod Track 1?",
                                    true,
                                    "Should the 'Alien Mod Track 1' Track Show up on the Gramophone?");
            configEnableScrapShop = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Scrap Shop?",
                                    true,
                                    "Should the 'Scrap Shop' Track Show up on the Gramophone?");
            configEnableDustbowlDannysTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Dustbowl Dannys Theme?",
                                    true,
                                    "Should the 'Dustbowl Danny's Theme' Track Show up on the Gramophone?");
            configEnableTheVurm = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Vurm?",
                                    true,
                                    "Should the 'The Vurm' Track Show up on the Gramophone?");
            configEnable4ATRDCZEROr_MOD = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "4@RDC0r_MOD?",
                                    true,
                                    "Should the '4@RDC0r_MOD' Track show up on the Gramophone");
            configEnableComingInHot = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Coming In Hot?",
                                     true,
                                     "Should the 'Coming In Hot' Track show up on the gramophone");
            configEnableClearTheBarracks = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Clear The Barracks?",
                                    true,
                                    "Should the 'Clear The Barracks' Track show up on the gramophone?"
                                    );
            configEnableShutDown = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Shut Down?",
                                    true,
                                    "Should the 'Shut Down' Track show up on the gramophone?"
                                    );
            configEnableGoingUp = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Going Up?",
                                    true,
                                    "Should the 'Going Up' Track show up on the gramophone?"
                                    );
            configEnableBreach = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Breach?",
                                    true,
                                    "Should the 'Breach' Track show up on the gramophone?"
                                    );
            configEnableSanctuary = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Sanctuary?",
                                    true,
                                    "Should the 'Sanctuary' track show up on the gramophone?"
                                    );
            configEnableOH_SUS_DROPTABLE_ = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "OH_SUS_DROPTABLE_?",
                                    true,
                                    "Should the 'OH_SUS_DROPTABLE_' Track show up on the gramophone?"
                                    );
            configEnableTheHex = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Hex?",
                                    true,
                                    "Should the 'The Hex' Track show up on the gramophone?"
                                    );
            //Music Num
            int MusicAmount = 0;

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            //Summons the music
            if (configEnableSuperWeaselKid.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_01.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableRadicalRoad.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_02.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableSWK_Prok_Version_2_Final4.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_03.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnableFight.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_04.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableToTheTop.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_05.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableSadosTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_06.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLegendariaEternal.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_08.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableMojisTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_09.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBattleTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_10.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableVallamirsTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_11.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableMoltenPeak.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_12.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBattleThemeSweatyDragonEdition.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_13.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheGreatDesert.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_14.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBattleThemeSphinxEdition.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_15.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableERR_IRVING_PROTOCOL.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_16.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheWasteland.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_17.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableAlienModTrack1.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_18.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableScrapShop.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_19.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableDustbowlDannysTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_20.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheVurm.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_21.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable4ATRDCZEROr_MOD.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_22.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableComingInHot.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_23.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableClearTheBarracks.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_24.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableShutDown.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_25.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableGoingUp.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_26.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBreach.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_27.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableSanctuary.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_29.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableOH_SUS_DROPTABLE_.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_31.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheHex.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_32.mp3", 0.5f);

                MusicAmount++;
            }
            // Was this sucsessful?
            Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");


        }
    }
}
