using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace UniversityStudy {

    static class Program {

        static void Main(string[] args) {

		//Part1.Prac4_VI_19();
		//Part1.Prac4_VII_4();
		//Part1.Prac5_II_17();
		//Part1.Prac5_IV_4();
		//Part1.Prac5_V_2();
    		//Part1.Prac6_II_3();
    		Part1.Prac6_V_6();

		if (args.Length != 0) {
			Type parts = typeof(Part1);
			MethodInfo method = parts.GetMethod(args[0]);
			Part1 tasks = new Part1();
			method.Invoke(tasks, null);
		}
        }
    }
}
