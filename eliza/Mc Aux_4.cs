/*
 * *** Please do not edit ! ***
 * @(#) McAux_4.cs
 * @procedure mc_aux/4 in eliza.pl
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

public class McAux_4 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( McAux_4 );
    static internal readonly Predicate McAux_4_1 = new Predicates.McAux_4_1();
    static internal readonly Predicate McAux_4_2 = new Predicates.McAux_4_2();
    static internal readonly Predicate McAux_4_3 = new Predicates.McAux_4_3();
    static internal readonly Predicate McAux_4_sub_1 = new Predicates.McAux_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public McAux_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public McAux_4(){}
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
        return engine.jtry(McAux_4_1, McAux_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "mc_aux(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class McAux_4_sub_1 : McAux_4 {
    static internal readonly Predicate McAux_4_sub_2 = new Predicates.McAux_4_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(McAux_4_2, McAux_4_sub_2);
    }
}

sealed class McAux_4_sub_2 : McAux_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(McAux_4_3);
    }
}

sealed class McAux_4_1 : McAux_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            a5 = ((ListTerm)a2).car;
        } else if ( a2.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a5, engine.makeVariable()), engine.trail) )
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
        if ( a7.IsList() ){
            a8 = ((ListTerm)a7).car;
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(a8, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a10 = ((ListTerm)a9).car;
            a11 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            a11 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a10, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a12 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a12, cont);
        p2 = new Predicates.McAux2_6(a1, a6, a10, a11, a3, a4, p1);
        p3 = new Predicates.Match_2(a8, a3, p2);
        return new Predicates.dollar_getLevel_1(a12, p3);
    }
}

sealed class McAux_4_2 : McAux_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            a5 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(engine.makeVariable(), a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a1;
        engine.aregs[2] = a5;
        engine.aregs[3] = a3;
        engine.aregs[4] = a4;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}

sealed class McAux_4_3 : McAux_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        p1 = new Predicates.dollar_fail_0(cont);
        return new Predicates.dollar_neckCut_0(p1);
    }
}
}

