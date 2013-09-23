/*
 * *** Please do not edit ! ***
 * @(#) Replace_4.cs
 * @procedure replace/4 in eliza.pl
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

public class Replace_4 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Replace_4 );
    static internal readonly Predicate Replace_4_1 = new Predicates.Replace_4_1();
    static internal readonly Predicate Replace_4_2 = new Predicates.Replace_4_2();
    static internal readonly Predicate Replace_4_3 = new Predicates.Replace_4_3();
    static internal readonly Predicate Replace_4_sub_1 = new Predicates.Replace_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public Replace_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Replace_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Replace_4_1, Replace_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "replace(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class Replace_4_sub_1 : Replace_4 {
    static internal readonly Predicate Replace_4_sub_2 = new Predicates.Replace_4_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Replace_4_2, Replace_4_sub_2);
    }
}

sealed class Replace_4_sub_2 : Replace_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Replace_4_3);
    }
}

sealed class Replace_4_1 : Replace_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Replace_4_2 : Replace_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

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
        if ( a4.IsList() ){
            if ( !a3.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a8 = engine.makeVariable();
        p1 = new Predicates.Replace_4(a1, a6, a3, a7, cont);
        p2 = new Predicates.dollar_cut_1(a8, p1);
        p3 = new Predicates.dollar_unify_2(a5, a1, p2);
        p4 = new Predicates.dollar_nonvar_1(a5, p3);
        return new Predicates.dollar_getLevel_1(a8, p4);
    }
}

sealed class Replace_4_3 : Replace_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

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
        if ( a4.IsList() ){
            if ( !a5.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a5, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a1;
        engine.aregs[2] = a6;
        engine.aregs[3] = a3;
        engine.aregs[4] = a7;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

