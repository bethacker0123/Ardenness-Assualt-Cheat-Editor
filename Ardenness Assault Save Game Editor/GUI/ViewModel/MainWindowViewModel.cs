using System;
using Ardenness_Assault_Save_Game_Editor.GUI.Helpers;
using Ardenness_Assault_Save_Game_Editor.GUI.Model;
using System.ComponentModel;

namespace Ardenness_Assault_Save_Game_Editor.GUI.ViewModel
{

    internal class MainWindowViewModel : BaseViewModel
        {
            RelayCommand _Comp1ID = null;
            RelayCommand _Comp1Vet = null;
            RelayCommand _CompReq1 = null;

            RelayCommand _Comp2ID = null;
            RelayCommand _Comp2Vet = null;
            RelayCommand _Comp2eq1 = null;

            RelayCommand _Comp3ID = null;
            RelayCommand _Comp3Vet = null;
            RelayCommand _Comp3eq1 = null;

            RelayCommand _Lierneux = null;
            RelayCommand _Vielsalm = null;
            RelayCommand _Bullingen = null;
            RelayCommand _Wiltz = null;
            RelayCommand _Outskirts = null;
            RelayCommand _Cielle = null;
            RelayCommand _Marche = null;
            RelayCommand _Stoumont = null;
            RelayCommand _Stavelot = null;
            RelayCommand _Elsenborn = null;
            RelayCommand _Vith = null;
            RelayCommand _Ouren = null;
            RelayCommand _Espeler = null;
            RelayCommand _Houffalize = null;
            RelayCommand _Bastogne = null;
            RelayCommand _Eschdorf = null;
            RelayCommand _Siegfried = null;

            RelayCommand _LierneuxMissionDifficulty = null;
            RelayCommand _VielsalmMissionDifficulty = null;
            RelayCommand _BullingenMissionDifficulty = null;
            RelayCommand _WiltzMissionDifficulty = null;
            RelayCommand _OutskirtsMissionDifficulty = null;
            RelayCommand _CielleMissionDifficulty = null;
            RelayCommand _MarcheMissionDifficulty = null;
            RelayCommand _StoumontMissionDifficulty = null;
            RelayCommand _StavelotMissionDifficulty = null;
            RelayCommand _ElsenbornMissionDifficulty = null;
            RelayCommand _VithMissionDifficulty = null;
            RelayCommand _OurenMissionDifficulty = null;
            RelayCommand _EspelerMissionDifficulty = null;
            RelayCommand _HouffalizeMissionDifficulty = null;
            RelayCommand _BastogneMissionDifficulty = null;
            RelayCommand _EschdorfMissionDifficulty = null;
            RelayCommand _SiegfriedMissionDifficulty = null;

            RelayCommand _LierneuxCompleted = null;
            RelayCommand _VielsalmCompleted = null;
            RelayCommand _BullingenCompleted = null;
            RelayCommand _WiltzCompleted = null;
            RelayCommand _OutskirtsCompleted = null;
            RelayCommand _CielleCompleted = null;
            RelayCommand _MarcheCompleted = null;
            RelayCommand _StoumontCompleted = null;
            RelayCommand _StavelotCompleted = null;
            RelayCommand _ElsenbornCompleted = null;
            RelayCommand _VithCompleted = null;
            RelayCommand _OurenCompleted = null;
            RelayCommand _EspelerCompleted = null;
            RelayCommand _HouffalizeCompleted = null;
            RelayCommand _BastogneCompleted = null;
            RelayCommand _EschdorfCompleted = null;
            RelayCommand _SiegfriedCompleted = null;
            public MainWindowViewModel()
            {

            }
            public static SavedGameModel SavedGame { get; } = new SavedGameModel();
            

     
    }

}
