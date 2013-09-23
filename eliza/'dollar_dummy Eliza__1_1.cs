/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummyEliza__1_1.cs
 * @procedure $dummy_eliza_1/1 in eliza.pl
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

public class dollar_dummyEliza__1_1 : Predicate {
    static internal readonly Predicate dollar_dummyEliza__1_1_1 = new Predicates.dollar_dummyEliza__1_1_1();
    static internal readonly Predicate dollar_dummyEliza__1_1_2 = new Predicates.dollar_dummyEliza__1_1_2();
    static internal readonly Predicate dollar_dummyEliza__1_1_sub_1 = new Predicates.dollar_dummyEliza__1_1_sub_1();

    public Term arg1;

    public dollar_dummyEliza__1_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public dollar_dummyEliza__1_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummyEliza__1_1_1, dollar_dummyEliza__1_1_sub_1);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "$dummy_eliza_1(" + arg1 + ")";
    }
}

sealed class dollar_dummyEliza__1_1_sub_1 : dollar_dummyEliza__1_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummyEliza__1_1_2);
    }
}

sealed class dollar_dummyEliza__1_1_1 : dollar_dummyEliza__1_1 {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("mem", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        a2 = engine.makeVariable();
        Term[] h2 = {a1};
        a3 = new StructureTerm(f1, h2);
        p1 = new Predicates.dollar_fail_0(cont);
        p2 = new Predicates.dollar_cut_1(a2, p1);
        p3 = new Predicates.Retract_1(a3, p2);
        return new Predicates.dollar_getLevel_1(a2, p3);
    }
}

sealed class dollar_dummyEliza__1_1_2 : dollar_dummyEliza__1_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.cont;
    }
}
}

