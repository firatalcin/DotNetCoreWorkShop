using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void Add(Job t)
        {
            _jobDal.Insert(t);
        }

        public Job Get(int id)
        {
            return _jobDal.Get(id);
        }

        public List<Job> GetAll()
        {
            return _jobDal.GetAll();
        }

        public void Remove(Job t)
        {
            _jobDal.Delete(t);
        }

        public void Update(Job t)
        {
            _jobDal.Update(t);
        }
    }
}