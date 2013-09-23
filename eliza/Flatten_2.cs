/*
 * *** Please do not edit ! ***
 * @(#) Flatten_2.cs
 * @procedure flatten/2 in eliza.pl
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

public class Flatten_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Flatten_2_1 = new Predicates.Flatten_2_1();
    static internal readonly Predicate Flatten_2_2 = new Predicates.Flatten_2_2();
    static internal readonly Predicate Flatten_2_3 = new Predicates.Flatten_2_3();
    static internal readonly Predicate Flatten_2_lis = new Predicates.Flatten_2_lis();
    static internal readonly Predicate Flatten_2_var = new Predicates.Flatten_2_var();

    public Term arg1, arg2;

    public Flatten_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Flatten_2(){}
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
                                   Flatten_2_var,
                                   dollar_fail_0,
                                   Flatten_2_1,
                                   dollar_fail_0,
                                   Flatten_2_lis
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "flatten(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Flatten_2_var : Flatten_2 {
    static internal readonly Predicate Flatten_2_var_1 = new Predicates.Flatten_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Flatten_2_1, Flatten_2_var_1);
    }
}

sealed class Flatten_2_var_1 : Flatten_2 {
    static internal readonly Predicate Flatten_2_var_2 = new Predicates.Flatten_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Flatten_2_2, Flatten_2_var_2);
    }
}

sealed class Flatten_2_var_2 : Flatten_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Flatten_2_3);
    }
}

sealed class Flatten_2_lis : Flatten_2 {
    static internal readonly Predicate Flatten_2_lis_1 = new Predicates.Flatten_2_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Flatten_2_2, Flatten_2_lis_1);
    }
}

sealed class Flatten_2_lis_1 : Flatten_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Flatten_2_3);
    }
}

sealed class Flatten_2_1 : Flatten_2 {
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

sealed class Flatten_2_2 : Flatten_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1;
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
        p1 = new Predicates.Flatten_2(a4, a5, cont);
        return new Predicates.dollar_dummyEliza__0_1(a3, p1);
    }
}

sealed class Flatten_2_3 : Flatten_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
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
        a6 = engine.makeVariable();
        p1 = new Predicates.Append_3(a5, a6, a2, cont);
        p2 = new Predicates.Flatten_2(a4, a6, p1);
        p3 = new Predicates.Flatten_2(a3, a5, p2);
        return new Predicates.Isalist_1(a3, p3);
    }
}
}

