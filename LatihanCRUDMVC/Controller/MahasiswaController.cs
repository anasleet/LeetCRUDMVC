using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using LatihanCRUDMVC.Model.Entity;
using LatihanCRUDMVC.Model.Repository;
using LatihanCRUDMVC.Model.Context;

namespace LatihanCRUDMVC.Controller
{
    public class MahasiswaController
    {

        // deklarasi objek _repository
        private MahasiswaRepository _repository;
        public int Save(Mahasiswa obj)
        {
            var result = 0;

            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("NPM harus di isi!!!");
                return 0;
            }

            if (string.IsNullOrEmpty(obj.nama))
            {
                MessageBox.Show("Nama harus di isi!!!");
                return 0;
            }

            using (var context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                result = _repository.Save(obj);
            }
            return result;
        }

        public int Update(Mahasiswa obj)
        {
            var result = 0;

            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("Npm harus di isi!!!");
                return 0;
            }

            if (string.IsNullOrEmpty(obj.nama))
            {
                MessageBox.Show("Nama harus di isi!!!");
                return 0;
            }

            using (var context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                result = _repository.Save(obj);
            }
            return result;

        }

        public int Delete(Mahasiswa obj)
        {
            var result = 0;

            if (string.IsNullOrEmpty(obj.npm))
            {
                MessageBox.Show("NPM harus di isi!!!");
                return 0;
            }

            if (string.IsNullOrEmpty(obj.nama))
            {
                MessageBox.Show("Nama harus di isi!!!");
                return 0;
            }

            using (var context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                result = _repository.Save(obj);
            }
            return result;

        }

        public List<Mahasiswa> GetAll()
        {
            var list = new List<Mahasiswa>();

            using (var context = new DbContext())
            {
                _repository = new MahasiswaRepository(context);
                list = _repository.GetAll();

            }

            return list;
        }
    }
}
