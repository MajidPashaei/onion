using System.Collections.Generic;
using Core.Domain;
namespace Core.Interface.Repository
{
    public interface IStudent
    {
        bool AddStudent(MStudent St);
        bool DeletStudent(int id);
        bool EditStudent(MStudent St);
        List<MStudent> GetAllStudent();
        List<MStudent> FindStudent(string Name ,string Family);
    }
}