using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9F
{
    public interface PersonDAO
    {
        void connect();
        void add(Person p);
        void del(Person p);
        void update(Person p);
        List<Person> read();
    }
}
