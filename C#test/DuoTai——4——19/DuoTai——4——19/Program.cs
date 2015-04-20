using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai__4__19
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李磊");
            Japaniese J1 = new Japaniese("树下军");
            Japaniese J2 = new Japaniese("井边");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金三胖");
            Amercia A1 = new Amercia("Jane");
            Amercia A2 = new Amercia("bohb");
            Person[] pers={cn1,cn2,k1,k2,J1,J2,A1,A2,new Chinese("啰里啰唆")};
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).Sayhello();
 
                //}
                //else if (pers[i] is Japaniese)
                //{
                //    ((Japaniese)pers[i]).Sayhello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).Sayhello();
                //}
                //else
                //{
                //    ((Amercia)pers[i]).Sayhello();
                //} 

                pers[i].Sayhello();

            }
        }
    }
}
