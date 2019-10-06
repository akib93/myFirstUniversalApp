using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDB_BISEW
{
    public class TraineeInfo
    {
        public string _id;
        public string ID
        {
            get => this._id;
            set
            {
                this._id = value;
            }
        }
        public string _traineename;
        public string TraineeName
        {
            get => this._traineename;
            set
            {
                this._traineename = value;
            }
        }
        public string _email;
        public string Email
        {
            get => this._email;
            set
            {
                this._email = value;
            }
        }
        public string _phone;
        public string PHone
        {
            get => this._phone;
            set
            {
                this._phone = value;
            }
        }



    }
}
