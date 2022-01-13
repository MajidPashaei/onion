using System.Collections.Generic;
using System.Linq;
using Core.Domain;
using Core.Interface.Repository;
using Infrastructure.Data.Context;

namespace Infrastructure.Data.Repository
{
    public class RStudent : IStudent
    {
       private readonly ContextDb _Context;
       public RStudent(ContextDb Context)
       {
           _Context=Context;
       }
        public bool AddStudent(MStudent St)
        {
            throw new System.NotImplementedException();
        }

        public bool DeletStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool EditStudent(MStudent St)
        {
            throw new System.NotImplementedException();
        }

        public List<MStudent> FindStudent(string Name, string Family)
        {
            throw new System.NotImplementedException();
        }

        public List<MStudent> GetAllStudent()
        {
            var ALlStudentintable=_Context.students.ToList();
            if (ALlStudentintable != null)
            {
                List<MStudent>  a=new List<MStudent>();
                foreach (var item in ALlStudentintable)
                {
                    MStudent f=new MStudent()
                    {
                        Id=item.Id,
                        Name=item.Name,
                        Family=item.Family,
                    };
                    a.Add(f);
                }
                return a;
            }
            else
            {
                return null;
            }
        }
    }
}