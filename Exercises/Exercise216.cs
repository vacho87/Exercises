using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise216 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> base10List = new List<int>(Exercise214.DecomposeNumber(7));
            List<int> base2List = new List<int>(ChangeNumberBaseFrom10ToAnyOther(base10List, 2));

            base10List.ShowList("base10List");
            base2List.ShowList("base2List");

        }

        

    }
}
