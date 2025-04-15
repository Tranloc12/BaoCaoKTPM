using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Loc_43_N2_
{
    public class Caculation_30_Loc
    {
        private int a_30_Loc, b_30_Loc;
        public Caculation_30_Loc(int a_30_Loc, int b_30_Loc)
        {
            this.a_30_Loc = a_30_Loc;
            this.b_30_Loc = b_30_Loc;
        }
        public int Execute(string operation_30_Loc)
        {
            int result_30_Loc = 0;
            switch (operation_30_Loc)
            {
                case "+":
                    result_30_Loc = a_30_Loc + b_30_Loc;
                    break;
                case "-":
                    result_30_Loc = a_30_Loc - b_30_Loc;
                    break;
                case "*":
                    result_30_Loc = a_30_Loc * b_30_Loc;
                    break;
                case "/":
                    result_30_Loc = a_30_Loc / b_30_Loc;
                    break;
            }

            return result_30_Loc;
        }
    }
}
