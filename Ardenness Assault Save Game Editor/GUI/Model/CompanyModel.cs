using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardenness_Assault_Save_Game_Editor.GUI.Model
{
    class CompanyModel : BaseModel
    {
       private string _companyID;
       private int _veterancy;
       private int _requistion;

        public CompanyModel (string Name, int  Vet, int Req)
        {
            CompanyId = Name;
            Veterancy = Vet;
            Requistion = Req;
        }
        public CompanyModel()
        {
            CompanyId = "";
            Veterancy = 0;
            Requistion = 0;
        }
        public string CompanyId
        {
            get
            {
                return _companyID;
            }
            set
            {
                SetProperty(ref _companyID, value);
            }
        }

        public int Veterancy
        {
            get
            {
                return _veterancy;
            }
            set
            {
                SetProperty(ref _veterancy, value);
            }
        }

        public int Requistion
        {
            get
            {
                return _requistion;
            }
            set
            {
                SetProperty(ref _requistion, value);
            }
        }

    }
}
