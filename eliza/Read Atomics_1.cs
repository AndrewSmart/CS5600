/*
 * *** Please do not edit ! ***
 * @(#) ReadAtomics_1.cs
 * @procedure read_atomics/1 in eliza.pl
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

public class ReadAtomics_1 : Predicate {

    public Term arg1;

    public ReadAtomics_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public ReadAtomics_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        a3 = engine.makeVariable();
        p1 = new Predicates.ExtractAtomics_2(a3, a1, cont);
        p2 = new Predicates.CleanString_2(a2, a3, p1);
        return new Predicates.ReadLcString_1(a2, p2);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "read_atomics(" + arg1 + ")";
    }
}
}

