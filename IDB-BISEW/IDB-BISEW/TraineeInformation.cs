using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDB_BISEW
{
    public class TraineeInformation
    {
        public string _name;
        public String Name
        {
            get => this._name;
            set
            {
                this._name = value;
            }
        }
        public string _round;
        public string Round
        {
            get => this._round;
            set
            {
                this._round = value;
            }
        }
        public string _coursename;
        public string CourseName
        {
            get => this._coursename;
            set
            {
                this._coursename = value;
            }
        }
        public string _batchno;
        public string BachNo
        {
            get => this._batchno;
            set
            {
                this._batchno = value;
            }
        }
        public string _tspname;
        public string TSPName
        {
            get => this._tspname;
            set
            {
                this._tspname = value;
            }
        }
        public string _trainername;
        public string TrainerName
        {
            get => this._trainername;
            set
            {
                this._trainername = value;
            }
        }
        
    }
    
}
