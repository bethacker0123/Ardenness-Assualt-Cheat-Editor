using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardenness_Assault_Save_Game_Editor.GUI.Model
{

    class SavedGameModel : BaseModel
    {
        public static  string[] MissionNames { get; } = { "Lierneux", "Vielsalm", "Bullingen", "Wiltz", "Outskirts", "Marche", "Stoumont", "Stavelot", "Elsenborn", "Vith", "Ouren", "Espeler", "Houffalize", "Bastogne", "Eschdorf", "Siegfried" };
        public static int[] DifficultySettings { get; } = { 1, 2, 3, 4, 5 };
        public static  string[] CompanyNames { get; } = { "Fox", "Dog", "Able", "Charlie" };
        public CompanyModel[] Companys { get; } = new CompanyModel[3];
        public MissionModel[] MissionSet { get; } = new MissionModel[MissionNames.Length];
        private string _savedGameDataPath;

        public SavedGameModel ()
        {
            SavedGameDataPath = "Default Shit";

            
            for (int i = 0; i < MissionNames.Length; i++)
            {
                MissionSet[i] = new MissionModel();
                MissionSet[i].MapName = MissionNames[i];
            }
            for (int i = 0; i < 3; i++)
            {
                Companys[i] = new CompanyModel();
                Companys[i].CompanyId = CompanyNames[i]; 
            }

        }

        public string SavedGameDataPath
        {
            get
            {
                return _savedGameDataPath;
            }
            set
            {
                SetProperty(ref _savedGameDataPath, value);
            }
        }

       
     

    }
}
