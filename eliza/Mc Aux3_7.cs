/*
 * *** Please do not edit ! ***
 * @(#) McAux3_7.cs
 * @procedure mc_aux3/7 in eliza.pl
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

public class McAux3_7 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate McAux3_7_1 = new Predicates.McAux3_7_1();
    static internal readonly Predicate McAux3_7_2 = new Predicates.McAux3_7_2();
    static internal readonly Predicate McAux3_7_3 = new Predicates.McAux3_7_3();
    static internal readonly Predicate McAux3_7_var = new Predicates.McAux3_7_var();

    public Term arg1, arg2, arg3, arg4, arg5, arg6, arg7;

    public McAux3_7(Term a1, Term a2, Term a3, Term a4, Term a5, Term a6, Term a7, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        arg6 = a6; 
        arg7 = a7; 
        this.cont = cont;
    }

    public McAux3_7(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        arg6 = args[5]; 
        arg7 = args[6]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.aregs[6] = arg6;
        engine.aregs[7] = arg7;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   McAux3_7_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   McAux3_7_var
                                   );
    }

    public override int arity() { return 7; }

    public override string ToString() {
        return "mc_aux3(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + ", " + arg7 + ")";
    }
}

sealed class McAux3_7_var : McAux3_7 {
    static internal readonly Predicate McAux3_7_var_1 = new Predicates.McAux3_7_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(McAux3_7_1, McAux3_7_var_1);
    }
}

sealed class McAux3_7_var_1 : McAux3_7 {
    static internal readonly Predicate McAux3_7_var_2 = new Predicates.McAux3_7_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(McAux3_7_2, McAux3_7_var_2);
    }
}

sealed class McAux3_7_var_2 : McAux3_7 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(McAux3_7_3);
    }
}

sealed class McAux3_7_1 : McAux3_7 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a8 = ((ListTerm)a1).car;
            a9 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a8 = engine.makeVariable();
            a9 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a8, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s1.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            a11 = ((ListTerm)a10).car;
            if ( !s2.Unify(((ListTerm)a10).cdr, engine.trail) )
                return engine.fail();
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(a11, s2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a12 = new ListTerm(a11, a9);
        p1 = new Predicates.Makecomment_3(a12, a6, a7, cont);
        p2 = new Predicates.Updaterule_4(a8, a2, a3, a4, p1);
        return new Predicates.dollar_neckCut_0(p2);
    }
}

sealed class McAux3_7_2 : McAux3_7 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s3 = new ListTerm(s1, s2);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a8 = ((ListTerm)a1).car;
            a9 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a8 = engine.makeVariable();
            a9 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a8, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !s3.Unify(a5, engine.trail) ) return engine.fail();
        p1 = new Predicates.Makecomment_3(a9, a6, a7, cont);
        p2 = new Predicates.Updaterule_4(a8, a2, a3, a4, p1);
        return new Predicates.dollar_neckCut_0(p2);
    }
}

sealed class McAux3_7_3 : McAux3_7 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a8 = ((ListTerm)a1).car;
        } else if ( a1.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a8, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a7, engine.trail) ) return engine.fail();
        return new Predicates.Updaterule_4(a8, a2, a3, a4, cont);
    }
}
}

