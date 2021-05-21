using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_CS.Gen2
{
    public interface IManagement<T> where T : Employee
    {
        List<T> SortBy(SortType sortType);
        void Fire(int id);
        void Employ(string fullName);
        void Display(List<T> employees);
        void AddPointsTo(int id);
        void Employ(T employee);
        T GetEmployee(int id);
    }
}
