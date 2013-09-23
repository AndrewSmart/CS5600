/*
 * *** Please do not edit ! ***
 * @(#) MatchAux3_4.cs
 * @procedure match_aux3/4 in eliza.pl
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

public class MatchAux3_4 : Predicate {
    static internal readonly Predicate MatchAux3_4_1 = new Predicates.MatchAux3_4_1();
    static internal readonly Predicate MatchAux3_4_2 = new Predicates.MatchAux3_4_2();
    static internal readonly Predicate MatchAux3_4_var = new Predicates.MatchAux3_4_var();

    public Term arg1, arg2, arg3, arg4;

    public MatchAux3_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public MatchAux3_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   MatchAux3_4_var,
                                   MatchAux3_4_1,
                                   MatchAux3_4_1,
                                   MatchAux3_4_1,
                                   MatchAux3_4_var
                                   );
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "match_aux3(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class MatchAux3_4_var : MatchAux3_4 {
    static internal readonly Predicate MatchAux3_4_var_1 = new Predicates.MatchAux3_4_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MatchAux3_4_1, MatchAux3_4_var_1);
    }
}

sealed class MatchAux3_4_var_1 : MatchAux3_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MatchAux3_4_2);
    }
}

sealed class MatchAux3_4_1 : MatchAux3_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !a1.Unify(a3, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.MatchAux2_2(a2, a4, p1);
        return new Predicates.dollar_getLevel_1(a5, p2);
    }
}

sealed class MatchAux3_4_2 : MatchAux3_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a5 = ((ListTerm)a1).car;
            a6 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            a6 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a5, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        a7 = engine.makeVariable();
        p1 = new Predicates.MatchAux2_2(a2, a7, cont);
        return new Predicates.Append_3(a6, a7, a4, p1);
    }
}
}

