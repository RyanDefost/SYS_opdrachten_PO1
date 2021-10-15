using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSettersOefening
{
    class Person
    {
        private int age;

        public void setAge(int anAge)
        {
            age = anAge;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
