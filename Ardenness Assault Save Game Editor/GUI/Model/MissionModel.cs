using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardenness_Assault_Save_Game_Editor.GUI.Model
{
    class MissionModel : BaseModel
    {
        private string  _mapName;
        private int     _difficulty;
        private Boolean _completed;

        public MissionModel (string Name, int Diff, Boolean Done)
        {
            MapName = Name;
            Difficulty = Diff;
            Completed = Done;
        }
        public MissionModel()
        {
            MapName = "NULL";
            Difficulty = 0;
            Completed = false;
        }

        public string MapName
        {
            get
            {
                return _mapName;
            }
            set
            {
                SetProperty(ref _mapName, value);
            }
        }


        public int Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                SetProperty(ref _difficulty, value);
            }
        }

        public Boolean Completed
        {
            get
            {
                return _completed;
            }
            set
            {
                SetProperty(ref _completed, value);
            }
        }


    }
}
