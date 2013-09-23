/*
 * *** Please do not edit ! ***
 * @(#) CleanString_2.cs
 * @procedure clean_string/2 in eliza.pl
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

public class CleanString_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate CleanString_2_1 = new Predicates.CleanString_2_1();
    static internal readonly Predicate CleanString_2_2 = new Predicates.CleanString_2_2();
    static internal readonly Predicate CleanString_2_3 = new Predicates.CleanString_2_3();
    static internal readonly Predicate CleanString_2_4 = new Predicates.CleanString_2_4();
    static internal readonly Predicate CleanString_2_var = new Predicates.CleanString_2_var();

    public Term arg1, arg2;

    public CleanString_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public CleanString_2(){}
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
                                   CleanString_2_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   CleanString_2_var
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "clean_string(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class CleanString_2_var : CleanString_2 {
    static internal readonly Predicate CleanString_2_var_1 = new Predicates.CleanString_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(CleanString_2_1, CleanString_2_var_1);
    }
}

sealed class CleanString_2_var_1 : CleanString_2 {
    static internal readonly Predicate CleanString_2_var_2 = new Predicates.CleanString_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(CleanString_2_2, CleanString_2_var_2);
    }
}

sealed class CleanString_2_var_2 : CleanString_2 {
    static internal readonly Predicate CleanString_2_var_3 = new Predicates.CleanString_2_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(CleanString_2_3, CleanString_2_var_3);
    }
}

sealed class CleanString_2_var_3 : CleanString_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(CleanString_2_4);
    }
}

sealed class CleanString_2_1 : CleanString_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("punctuation");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
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
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.CleanString_2(a4, a2, p1);
        p3 = new Predicates.MyCharType_2(a3, s1, p2);
        return new Predicates.dollar_getLevel_1(a5, p3);
    }
}

sealed class CleanString_2_2 : CleanString_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
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
            if ( !a3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a6 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.CleanString_2(a4, a5, p1);
        return new Predicates.dollar_getLevel_1(a6, p2);
    }
}

sealed class CleanString_2_3 : CleanString_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("punctuation");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            if ( !s1.Unify(((ListTerm)a1).cdr, engine.trail) )
                return engine.fail();
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a4 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.MyCharType_2(a3, s2, p1);
        return new Predicates.dollar_getLevel_1(a4, p2);
    }
}

sealed class CleanString_2_4 : CleanString_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            if ( !s1.Unify(((ListTerm)a1).cdr, engine.trail) )
                return engine.fail();
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !a3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            if ( !s1.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            if ( !a2.Unify(new ListTerm(a3, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}
}

