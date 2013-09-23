/*
 * *** Please do not edit ! ***
 * @(#) ExtractWordAux_4.cs
 * @procedure extract_word_aux/4 in eliza.pl
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

public class ExtractWordAux_4 : Predicate {
    static internal readonly Predicate ExtractWordAux_4_1 = new Predicates.ExtractWordAux_4_1();
    static internal readonly Predicate ExtractWordAux_4_2 = new Predicates.ExtractWordAux_4_2();
    static internal readonly Predicate ExtractWordAux_4_3 = new Predicates.ExtractWordAux_4_3();
    static internal readonly Predicate ExtractWordAux_4_int = new Predicates.ExtractWordAux_4_int();
    static internal readonly Predicate ExtractWordAux_4_lis = new Predicates.ExtractWordAux_4_lis();
    static internal readonly Predicate ExtractWordAux_4_str = new Predicates.ExtractWordAux_4_str();
    static internal readonly Predicate ExtractWordAux_4_var = new Predicates.ExtractWordAux_4_var();

    public Term arg1, arg2, arg3, arg4;

    public ExtractWordAux_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public ExtractWordAux_4(){}
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
                                   ExtractWordAux_4_var,
                                   ExtractWordAux_4_int,
                                   ExtractWordAux_4_var,
                                   ExtractWordAux_4_str,
                                   ExtractWordAux_4_lis
                                   );
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "extract_word_aux(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class ExtractWordAux_4_var : ExtractWordAux_4 {
    static internal readonly Predicate ExtractWordAux_4_var_1 = new Predicates.ExtractWordAux_4_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ExtractWordAux_4_1, ExtractWordAux_4_var_1);
    }
}

sealed class ExtractWordAux_4_var_1 : ExtractWordAux_4 {
    static internal readonly Predicate ExtractWordAux_4_var_2 = new Predicates.ExtractWordAux_4_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ExtractWordAux_4_2, ExtractWordAux_4_var_2);
    }
}

sealed class ExtractWordAux_4_var_2 : ExtractWordAux_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ExtractWordAux_4_3);
    }
}

sealed class ExtractWordAux_4_int : ExtractWordAux_4 {
    static internal readonly Predicate ExtractWordAux_4_int_1 = new Predicates.ExtractWordAux_4_int_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ExtractWordAux_4_2, ExtractWordAux_4_int_1);
    }
}

sealed class ExtractWordAux_4_int_1 : ExtractWordAux_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ExtractWordAux_4_3);
    }
}

sealed class ExtractWordAux_4_str : ExtractWordAux_4 {
    static internal readonly Predicate ExtractWordAux_4_str_1 = new Predicates.ExtractWordAux_4_str_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ExtractWordAux_4_2, ExtractWordAux_4_str_1);
    }
}

sealed class ExtractWordAux_4_str_1 : ExtractWordAux_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ExtractWordAux_4_3);
    }
}

sealed class ExtractWordAux_4_lis : ExtractWordAux_4 {
    static internal readonly Predicate ExtractWordAux_4_lis_1 = new Predicates.ExtractWordAux_4_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ExtractWordAux_4_2, ExtractWordAux_4_lis_1);
    }
}

sealed class ExtractWordAux_4_lis_1 : ExtractWordAux_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ExtractWordAux_4_3);
    }
}

sealed class ExtractWordAux_4_1 : ExtractWordAux_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("special");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        return new Predicates.dollar_neckCut_0(cont);
    }
}

sealed class ExtractWordAux_4_2 : ExtractWordAux_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
        Predicate p1, p2, p3;
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
        a8 = engine.makeVariable();
        p1 = new Predicates.ExtractWordAux_4(a1, a6, a3, a7, cont);
        p2 = new Predicates.dollar_cut_1(a8, p1);
        p3 = new Predicates.MyCharType_2(a5, a1, p2);
        return new Predicates.dollar_getLevel_1(a8, p3);
    }
}

sealed class ExtractWordAux_4_3 : ExtractWordAux_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

