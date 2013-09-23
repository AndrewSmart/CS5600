/*
 * *** Please do not edit ! ***
 * @(#) MatchAux1_2.cs
 * @procedure match_aux1/2 in eliza.pl
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

public class MatchAux1_2 : Predicate {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("*");

    public Term arg1, arg2;

    public MatchAux1_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public MatchAux1_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8, p9;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        a5 = engine.makeVariable();
        a4 = new ListTerm(s1, a5);
        a6 = engine.makeVariable();
        a7 = new ListTerm(s1, a5);
        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        p1 = new Predicates.dollar_unify_2(a9, a6, cont);
        p2 = new Predicates.LastMember_2(a9, a5, p1);
        p3 = new Predicates.dollar_cut_1(a3, p2);
        p4 = new Predicates.MatchAux2_2(a8, a2, p3);
        p5 = new Predicates.Replace_4(a7, a1, a6, a8, p4);
        p6 = new Predicates.dollar_nonvar_1(a6, p5);
        p7 = new Predicates.Member_2(a6, a5, p6);
        p8 = new Predicates.dollar_nonvar_1(a5, p7);
        p9 = new Predicates.Member_2(a4, a1, p8);
        return new Predicates.dollar_getLevel_1(a3, p9);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "match_aux1(" + arg1 + ", " + arg2 + ")";
    }
}
}

