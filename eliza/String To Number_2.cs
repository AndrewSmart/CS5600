/*
 * *** Please do not edit ! ***
 * @(#) StringToNumber_2.cs
 * @procedure string_to_number/2 in eliza.pl
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

public class StringToNumber_2 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);

    public Term arg1, arg2;

    public StringToNumber_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public StringToNumber_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        return new Predicates.StringToNumberAux_3(a1, s1, a2, cont);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "string_to_number(" + arg1 + ", " + arg2 + ")";
    }
}
}

