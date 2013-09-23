/*
 * *** Please do not edit ! ***
 * @(#) Findkeywords_2.cs
 * @procedure findkeywords/2 in eliza.pl
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

public class Findkeywords_2 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Findkeywords_2 );
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Findkeywords_2_1 = new Predicates.Findkeywords_2_1();
    static internal readonly Predicate Findkeywords_2_2 = new Predicates.Findkeywords_2_2();
    static internal readonly Predicate Findkeywords_2_3 = new Predicates.Findkeywords_2_3();
    static internal readonly Predicate Findkeywords_2_lis = new Predicates.Findkeywords_2_lis();
    static internal readonly Predicate Findkeywords_2_var = new Predicates.Findkeywords_2_var();

    public Term arg1, arg2;

    public Findkeywords_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Findkeywords_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   Findkeywords_2_var,
                                   dollar_fail_0,
                                   Findkeywords_2_1,
                                   dollar_fail_0,
                                   Findkeywords_2_lis
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "findkeywords(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Findkeywords_2_var : Findkeywords_2 {
    static internal readonly Predicate Findkeywords_2_var_1 = new Predicates.Findkeywords_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Findkeywords_2_1, Findkeywords_2_var_1);
    }
}

sealed class Findkeywords_2_var_1 : Findkeywords_2 {
    static internal readonly Predicate Findkeywords_2_var_2 = new Predicates.Findkeywords_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Findkeywords_2_2, Findkeywords_2_var_2);
    }
}

sealed class Findkeywords_2_var_2 : Findkeywords_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Findkeywords_2_3);
    }
}

sealed class Findkeywords_2_lis : Findkeywords_2 {
    static internal readonly Predicate Findkeywords_2_lis_1 = new Predicates.Findkeywords_2_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Findkeywords_2_2, Findkeywords_2_lis_1);
    }
}

sealed class Findkeywords_2_lis_1 : Findkeywords_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Findkeywords_2_3);
    }
}

sealed class Findkeywords_2_1 : Findkeywords_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("memory");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);
    static internal readonly ListTerm s4 = new ListTerm(s3, s1);
    static internal readonly ListTerm s5 = new ListTerm(s2, s4);
    static internal readonly SymbolTerm s6 = SymbolTerm.MakeSymbol("none");
    static internal readonly ListTerm s7 = new ListTerm(s6, s4);
    static internal readonly ListTerm s8 = new ListTerm(s7, s1);
    static internal readonly ListTerm s9 = new ListTerm(s5, s8);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s9.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Findkeywords_2_2 : Findkeywords_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
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
        if ( a5.IsList() ){
            if ( !a3.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a8 = ((ListTerm)a7).car;
            if ( !s1.Unify(((ListTerm)a7).cdr, engine.trail) )
                return engine.fail();
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(a8, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a9 = engine.makeVariable();
        a12 = new ListTerm(a8, s1);
        a11 = new ListTerm(a3, a12);
        a10 = new ListTerm(a11, engine.makeVariable());
        p1 = new Predicates.Findkeywords_2(a4, a6, cont);
        p2 = new Predicates.dollar_cut_1(a9, p1);
        p3 = new Predicates.Rules_1(a10, p2);
        return new Predicates.dollar_getLevel_1(a9, p3);
    }
}

sealed class Findkeywords_2_3 : Findkeywords_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(engine.makeVariable(), a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a3;
        engine.aregs[2] = a2;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

