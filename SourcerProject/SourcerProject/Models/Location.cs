using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourcerProject.Models
{
    public class Location
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _accessilbe;
        private string _messages;

        public string Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }


        public bool Accessilbe
        {
            get { return _accessilbe; }
            set { _accessilbe = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return _id + "" + _name; 
        }

    }
}
