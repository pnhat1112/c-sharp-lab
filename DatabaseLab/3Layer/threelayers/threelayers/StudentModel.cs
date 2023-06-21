using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threelayers
{
    internal class StudentModel
    {
        private string _id;
        private string _name;
        private string _classid;
        public StudentModel(string id, string name, string classid)
        {
            _id = id;
            _name = name;
            _classid = classid;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Classid { get => _classid; set => _classid = value; }
    }
}
