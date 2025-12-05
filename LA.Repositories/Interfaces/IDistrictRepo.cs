using LA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Interfaces
{
    public interface IDistrictRepo
    {
        IEnumerable<District> GetAll();

        District GetById(int id);

        //returnType+MethodName(ParameterType parameterName);
        void Save(District district);

        void Edit(District district);

        void RemoveData(District district);
    }
}
