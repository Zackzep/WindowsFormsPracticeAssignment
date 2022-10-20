using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPracticeAssignment
{
    public class BaseballPlayer
    {
        //Fields
        string _name;
        string _team;
        string _city;
        int _average;
        string _position;

        //Constructor
        public BaseballPlayer(string name, string team, string city, int average, string position)
        {
            _name = name;
            _team = team;
            _city = city;
            _average = average;
            _position = position;
        }

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public int Average
        {
            get { return _average; }
            set { _average = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
