﻿using System.Linq;
using Base.Defs;
using Base.Core;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Tactical.Entities;

namespace SuperCheatsModPlus
{
    internal class EliteSoldiers
    {
        public static void EliteSquad()
        {
            SuperCheatsModPlusConfig Config = (SuperCheatsModPlusConfig)SuperCheatsModPlusMain.Main.Config;
            DefRepository Repo = GameUtl.GameComponent<DefRepository>();
            GameDifficultyLevelDef easy = Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("Easy_GameDifficultyLevelDef"));
            GameDifficultyLevelDef standard = Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("Standard_GameDifficultyLevelDef"));
            GameDifficultyLevelDef hard = Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("Hard_GameDifficultyLevelDef"));
            GameDifficultyLevelDef veryhard = Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("VeryHard_GameDifficultyLevelDef"));
            TacCharacterDef tobias = Repo.GetAllDefs<TacCharacterDef>().FirstOrDefault(a => a.name.Equals("NJ_TobiasWest_TacCharacterDef"));
            TacCharacterDef exalted = Repo.GetAllDefs<TacCharacterDef>().FirstOrDefault(a => a.name.Equals("AN_Exalted_TacCharacterDef"));
            TacCharacterDef synedrionLeader = Repo.GetAllDefs<TacCharacterDef>().FirstOrDefault(a => a.name.Equals("SY_Leader_TacCharacterDef"));
            TacCharacterDef pirateKing = Repo.GetAllDefs<TacCharacterDef>().FirstOrDefault(a => a.name.Equals("NJ_SuperHeavy_TacCharacterDef"));
            TacCharacterDef godly = Repo.GetAllDefs<TacCharacterDef>().FirstOrDefault(a => a.name.Equals("NJ_Godly_TacCharacterDef"));

            if (Config.StartWithEliteSoldiers == true)
            {
                easy.StartingSquadTemplate = new TacCharacterDef[]
                {
                    pirateKing,
                    synedrionLeader,
                    godly,
                    easy.StartingSquadTemplate[3],
                    tobias,
                    easy.StartingSquadTemplate[5],
                    exalted,
                };
                standard.StartingSquadTemplate = new TacCharacterDef[]
                {
                    standard.StartingSquadTemplate[0],
                    tobias,
                    synedrionLeader,
                    standard.StartingSquadTemplate[3],
                    pirateKing,
                    godly,
                    exalted,
                };
                hard.StartingSquadTemplate = new TacCharacterDef[]
                {
                    pirateKing,
                    hard.StartingSquadTemplate[1],
                    synedrionLeader,
                    hard.StartingSquadTemplate[3],
                    tobias,
                    godly,
                    exalted,
                };
                veryhard.StartingSquadTemplate = new TacCharacterDef[]
                {
                    pirateKing,
                    veryhard.StartingSquadTemplate[1],
                    synedrionLeader,
                    veryhard.StartingSquadTemplate[3],
                    tobias,
                    godly,
                    exalted,
                };
            }
        }
    }
}
