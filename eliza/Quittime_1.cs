/*
 * *** Please do not edit ! ***
 * @(#) Quittime_1.cs
 * @procedure quittime/1 in eliza.pl
 */

/*
 * @version P# 1.1.3, on Sept 1 2003;  Prolog Cafe 0.44, on November 12 1999
 * @author Mutsunori Banbara (banbara@pascal.seg.kobe-u.ac.jp)
 * @author Naoyuki Tamura    (tamura@kobe-u.ac.jp)
 * Modified by Jonathan Cook (jjc@dcs.ed.ac.uk)
 */
namespace JJC.Psharp.Predicates {

using JJC.Psharp.Lang;
using JJC.Psharp.Lang.Resource;
using Predicates = JJC.Psharp.Predicates;
using Resources = JJC.Psharp.Resources;

public class Quittime_1 : Predicate {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("quit");

    public Term arg1;

    public Quittime_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Quittime_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1;
        a1 = arg1.Dereference();

        return new Predicates.Member_2(s1, a1, cont);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "quittime(" + arg1 + ")";
    }
}
}

