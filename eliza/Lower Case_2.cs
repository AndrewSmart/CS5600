/*
 * *** Please do not edit ! ***
 * @(#) LowerCase_2.cs
 * @procedure lower_case/2 in eliza.pl
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

public class LowerCase_2 : Predicate {
    static internal readonly Predicate LowerCase_2_1 = new Predicates.LowerCase_2_1();
    static internal readonly Predicate LowerCase_2_2 = new Predicates.LowerCase_2_2();
    static internal readonly Predicate LowerCase_2_sub_1 = new Predicates.LowerCase_2_sub_1();

    public Term arg1, arg2;

    public LowerCase_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public LowerCase_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(LowerCase_2_1, LowerCase_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "lower_case(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class LowerCase_2_sub_1 : LowerCase_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(LowerCase_2_2);
    }
}

sealed class LowerCase_2_1 : LowerCase_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(65);
    static internal readonly IntegerTerm s2 = new IntegerTerm(90);
    static internal readonly IntegerTerm s3 = new IntegerTerm(32);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_plus_3(a1, s3, a2, p1);
        p3 = new Predicates.dollar_lessOrEqual_2(a1, s2, p2);
        p4 = new Predicates.dollar_greaterOrEqual_2(a1, s1, p3);
        return new Predicates.dollar_getLevel_1(a3, p4);
    }
}

sealed class LowerCase_2_2 : LowerCase_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !a1.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

