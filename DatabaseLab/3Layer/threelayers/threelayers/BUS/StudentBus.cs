using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using threelayers.DAO;

namespace threelayers.BUS
{
    internal class StudentBus
    {
        private StudentDao _stdDao;

        public StudentBus()
        {
            _stdDao = new StudentDao();
        }

        public DataSet getAll()
        {
            return _stdDao.getAll();
        }

        public void insertStudent(string id, string name, string classid)
        {
            _stdDao.insertStudent(id, name, classid);
        }
        public void updateStudent(string id, string name, string classid, int position)
        {
            _stdDao.updateStudent(id, name, classid, position);
        }
        public void deleteStudent(int position)
        {
            _stdDao.deleteStudent(position);
        }
    }
}
