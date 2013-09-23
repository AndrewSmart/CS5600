/*
 * *** Please do not edit ! ***
 * @(#) ExtractAtomics_2.cs
 * @procedure extract_atomics/2 in eliza.pl
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

public class ExtractAtomics_2 : Predicate {

    public Term arg1, arg2;

    public ExtractAtomics_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public ExtractAtomics_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        p1 = new Predicates.ExtractAtomicsAux_2(a3, a2, cont);
        return new Predicates.RemoveInitialBlanks_2(a1, a3, p1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "extract_atomics(" + arg1 + ", " + arg2 + ")";
    }
}
}

