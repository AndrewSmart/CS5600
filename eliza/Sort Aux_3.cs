/*
 * *** Please do not edit ! ***
 * @(#) SortAux_3.cs
 * @procedure sort_aux/3 in eliza.pl
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

public class SortAux_3 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( SortAux_3 );
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate SortAux_3_1 = new Predicates.SortAux_3_1();
    static internal readonly Predicate SortAux_3_2 = new Predicates.SortAux_3_2();
    static internal readonly Predicate SortAux_3_3 = new Predicates.SortAux_3_3();
    static internal readonly Predicate SortAux_3_4 = new Predicates.SortAux_3_4();
    static internal readonly Predicate SortAux_3_lis = new Predicates.SortAux_3_lis();
    static internal readonly Predicate SortAux_3_var = new Predicates.SortAux_3_var();

    public Term arg1, arg2, arg3;

    public SortAux_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public SortAux_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   SortAux_3_var,
                                   dollar_fail_0,
                                   SortAux_3_1,
                                   dollar_fail_0,
                                   SortAux_3_lis
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "sort_aux(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class SortAux_3_var : SortAux_3 {
    static internal readonly Predicate SortAux_3_var_1 = new Predicates.SortAux_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(SortAux_3_1, SortAux_3_var_1);
    }
}

sealed class SortAux_3_var_1 : SortAux_3 {
    static internal readonly Predicate SortAux_3_var_2 = new Predicates.SortAux_3_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(SortAux_3_2, SortAux_3_var_2);
    }
}

sealed class SortAux_3_var_2 : SortAux_3 {
    static internal readonly Predicate SortAux_3_var_3 = new Predicates.SortAux_3_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(SortAux_3_3, SortAux_3_var_3);
    }
}

sealed class SortAux_3_var_3 : SortAux_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(SortAux_3_4);
    }
}

sealed class SortAux_3_lis : SortAux_3 {
    static internal readonly Predicate SortAux_3_lis_1 = new Predicates.SortAux_3_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(SortAux_3_2, SortAux_3_lis_1);
    }
}

sealed class SortAux_3_lis_1 : SortAux_3 {
    static internal readonly Predicate SortAux_3_lis_2 = new Predicates.SortAux_3_lis_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(SortAux_3_3, SortAux_3_lis_2);
    }
}

sealed class SortAux_3_lis_2 : SortAux_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(SortAux_3_4);
    }
}

sealed class SortAux_3_1 : SortAux_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a3, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class SortAux_3_2 : SortAux_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).car;
            if ( !s1.Unify(((ListTerm)a1).cdr, engine.trail) )
                return engine.fail();
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a4, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !a4.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            if ( !s1.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            if ( !a2.Unify(new ListTerm(a4, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !s2.Unify(a3, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class SortAux_3_3 : SortAux_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly IntegerTerm s2 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).car;
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            a6 = ((ListTerm)a4).car;
            a7 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            a7 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a6, a7), engine.trail) )
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
        if ( a5.IsList() ){
            a9 = ((ListTerm)a5).car;
            a10 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a9 = engine.makeVariable();
            a10 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a9, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a11 = ((ListTerm)a9).car;
            a12 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a11 = engine.makeVariable();
            a12 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a11, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            a13 = ((ListTerm)a12).car;
            if ( !s1.Unify(((ListTerm)a12).cdr, engine.trail) )
                return engine.fail();
        } else if ( a12.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(a13, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !a9.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a9, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !a11.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            if ( !a12.Unify(((ListTerm)a9).cdr, engine.trail) )
                return engine.fail();
        } else if ( a9.IsVariable() ){
            if ( !a9.Unify(new ListTerm(a11, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !a13.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            if ( !s1.Unify(((ListTerm)a12).cdr, engine.trail) )
                return engine.fail();
        } else if ( a12.IsVariable() ){
            if ( !a12.Unify(new ListTerm(a13, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !a4.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            if ( !a10.Unify(((ListTerm)a14).cdr, engine.trail) )
                return engine.fail();
        } else if ( a14.IsVariable() ){
            if ( !a14.Unify(new ListTerm(a4, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !a6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            if ( !a7.Unify(((ListTerm)a4).cdr, engine.trail) )
                return engine.fail();
        } else if ( a4.IsVariable() ){
            if ( !a4.Unify(new ListTerm(a6, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !a8.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            if ( !s1.Unify(((ListTerm)a7).cdr, engine.trail) )
                return engine.fail();
        } else if ( a7.IsVariable() ){
            if ( !a7.Unify(new ListTerm(a8, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !s2.Unify(a3, engine.trail) ) return engine.fail();
        return new Predicates.dollar_lessThan_2(a8, a13, cont);
    }
}

sealed class SortAux_3_4 : SortAux_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).car;
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            a7 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            a7 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !a4.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a8 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a4, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a9 = new ListTerm(a6, a7);
        engine.aregs[1] = a9;
        engine.aregs[2] = a8;
        engine.aregs[3] = a3;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

