/*
 * *** Please do not edit ! ***
 * @(#) Match_2.cs
 * @procedure match/2 in eliza.pl
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

public class Match_2 : Predicate {
    static internal readonly Predicate Match_2_1 = new Predicates.Match_2_1();
    static internal readonly Predicate Match_2_2 = new Predicates.Match_2_2();
    static internal readonly Predicate Match_2_sub_1 = new Predicates.Match_2_sub_1();

    public Term arg1, arg2;

    public Match_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Match_2(){}
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
        return engine.jtry(Match_2_1, Match_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "match(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Match_2_sub_1 : Match_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Match_2_2);
    }
}

sealed class Match_2_1 : Match_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.MatchAux1_2(a1, a2, p1);
        return new Predicates.dollar_getLevel_1(a3, p2);
    }
}

sealed class Match_2_2 : Match_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.MatchAux2_2(a1, a2, cont);
    }
}
}

