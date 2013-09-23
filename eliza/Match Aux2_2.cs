/*
 * *** Please do not edit ! ***
 * @(#) MatchAux2_2.cs
 * @procedure match_aux2/2 in eliza.pl
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

public class MatchAux2_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate MatchAux2_2_1 = new Predicates.MatchAux2_2_1();
    static internal readonly Predicate MatchAux2_2_2 = new Predicates.MatchAux2_2_2();
    static internal readonly Predicate MatchAux2_2_3 = new Predicates.MatchAux2_2_3();
    static internal readonly Predicate MatchAux2_2_4 = new Predicates.MatchAux2_2_4();
    static internal readonly Predicate MatchAux2_2_5 = new Predicates.MatchAux2_2_5();
    static internal readonly Predicate MatchAux2_2_lis = new Predicates.MatchAux2_2_lis();
    static internal readonly Predicate MatchAux2_2_var = new Predicates.MatchAux2_2_var();

    public Term arg1, arg2;

    public MatchAux2_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public MatchAux2_2(){}
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
        return engine.switch_on_term(
                                   MatchAux2_2_var,
                                   dollar_fail_0,
                                   MatchAux2_2_1,
                                   dollar_fail_0,
                                   MatchAux2_2_lis
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "match_aux2(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class MatchAux2_2_var : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_var_1 = new Predicates.MatchAux2_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MatchAux2_2_1, MatchAux2_2_var_1);
    }
}

sealed class MatchAux2_2_var_1 : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_var_2 = new Predicates.MatchAux2_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MatchAux2_2_2, MatchAux2_2_var_2);
    }
}

sealed class MatchAux2_2_var_2 : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_var_3 = new Predicates.MatchAux2_2_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MatchAux2_2_3, MatchAux2_2_var_3);
    }
}

sealed class MatchAux2_2_var_3 : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_var_4 = new Predicates.MatchAux2_2_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MatchAux2_2_4, MatchAux2_2_var_4);
    }
}

sealed class MatchAux2_2_var_4 : MatchAux2_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MatchAux2_2_5);
    }
}

sealed class MatchAux2_2_lis : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_lis_1 = new Predicates.MatchAux2_2_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MatchAux2_2_2, MatchAux2_2_lis_1);
    }
}

sealed class MatchAux2_2_lis_1 : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_lis_2 = new Predicates.MatchAux2_2_lis_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MatchAux2_2_3, MatchAux2_2_lis_2);
    }
}

sealed class MatchAux2_2_lis_2 : MatchAux2_2 {
    static internal readonly Predicate MatchAux2_2_lis_3 = new Predicates.MatchAux2_2_lis_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MatchAux2_2_4, MatchAux2_2_lis_3);
    }
}

sealed class MatchAux2_2_lis_3 : MatchAux2_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MatchAux2_2_5);
    }
}

sealed class MatchAux2_2_1 : MatchAux2_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class MatchAux2_2_2 : MatchAux2_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a5 = ((ListTerm)a2).car;
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a5 = engine.makeVariable();
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a5, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a7 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a7, cont);
        p2 = new Predicates.MatchAux3_4(a3, a4, a5, a6, p1);
        return new Predicates.dollar_getLevel_1(a7, p2);
    }
}

sealed class MatchAux2_2_3 : MatchAux2_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            a5 = ((ListTerm)a4).car;
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a5, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a7 = ((ListTerm)a2).car;
            a8 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a9 = engine.makeVariable();
        a11 = new ListTerm(a5, a6);
        a10 = new ListTerm(a3, a11);
        a13 = new ListTerm(a7, a8);
        a12 = new ListTerm(s1, a13);
        p1 = new Predicates.MatchAux2_2(a10, a12, cont);
        p2 = new Predicates.dollar_cut_1(a9, p1);
        p3 = new Predicates.dollar_equalityOfTerm_2(a5, a7, p2);
        p4 = new Predicates.dollar_nonvar_1(a5, p3);
        p5 = new Predicates.dollar_var_1(a3, p4);
        return new Predicates.dollar_getLevel_1(a9, p5);
    }
}

sealed class MatchAux2_2_4 : MatchAux2_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            a5 = ((ListTerm)a4).car;
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a5, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a7 = ((ListTerm)a2).car;
            a8 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a9 = engine.makeVariable();
        a11 = new ListTerm(a5, a6);
        a10 = new ListTerm(a3, a11);
        a13 = new ListTerm(a7, a8);
        a12 = new ListTerm(s1, a13);
        p1 = new Predicates.MatchAux2_2(a10, a12, cont);
        p2 = new Predicates.dollar_cut_1(a9, p1);
        p3 = new Predicates.dollar_var_1(a5, p2);
        p4 = new Predicates.dollar_var_1(a3, p3);
        return new Predicates.dollar_getLevel_1(a9, p4);
    }
}

sealed class MatchAux2_2_5 : MatchAux2_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s2 = new ListTerm(s1, s1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s2.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

