using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject__TextRPG_PR2_Park
{
    public abstract class BaseScene
    {

        public abstract void Input();

        public abstract void Render()
        ;

        public abstract void Update();




        public abstract void Enter();


    }
}
