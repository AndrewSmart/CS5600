using System;
using System.Reflection;
using JJC.Psharp.Predicates;
// entry point for the user's Psharp application.
namespace eliza {
	class Loader {
		static void Main(string[] args) {
			// args = new string[] { "Interpreter" };
			if(args.Length == 0) args = new string[] { "Eliza" };
			Assembly a = System.Reflection.Assembly.Load("Psharp");
			a.GetType("JJC.Psharp.Lang.PrologMain").GetMethod("CallbackMain").Invoke(a.CreateInstance( "JJC.Psharp.Lang.PrologMain" ), new object[] { args, Assembly.GetExecutingAssembly() });
			//Eliza_0 e = new Eliza_0();
			//e.exec(a);
		}
	}
}

