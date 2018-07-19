using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.dao
{
    public interface Obligatorio<cualquierclase>
    {
        void create(cualquierclase obj);
        void update(cualquierclase obj);
        void delete(cualquierclase obj);
        bool find(cualquierclase obj);
        List<cualquierclase> FindAll();
    }
}
