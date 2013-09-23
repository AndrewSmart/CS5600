/*
 * *** Please do not edit ! ***
 * @(#) WritecommentAux_1.cs
 * @procedure writecomment_aux/1 in eliza.pl
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

public class WritecommentAux_1 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate WritecommentAux_1_1 = new Predicates.WritecommentAux_1_1();
    static internal readonly Predicate WritecommentAux_1_2 = new Predicates.WritecommentAux_1_2();
    static internal readonly Predicate WritecommentAux_1_3 = new Predicates.WritecommentAux_1_3();
    static internal readonly Predicate WritecommentAux_1_lis = new Predicates.WritecommentAux_1_lis();
    static internal readonly Predicate WritecommentAux_1_var = new Predicates.WritecommentAux_1_var();

    public Term arg1;

    public WritecommentAux_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public WritecommentAux_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   WritecommentAux_1_var,
                                   dollar_fail_0,
                                   WritecommentAux_1_1,
                                   dollar_fail_0,
                                   WritecommentAux_1_lis
                                   );
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "writecomment_aux(" + arg1 + ")";
    }
}

sealed class WritecommentAux_1_var : WritecommentAux_1 {
    static internal readonly Predicate WritecommentAux_1_var_1 = new Predicates.WritecommentAux_1_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(WritecommentAux_1_1, WritecommentAux_1_var_1);
    }
}

sealed class WritecommentAux_1_var_1 : WritecommentAux_1 {
    static internal readonly Predicate WritecommentAux_1_var_2 = new Predicates.WritecommentAux_1_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(WritecommentAux_1_2, WritecommentAux_1_var_2);
    }
}

sealed class WritecommentAux_1_var_2 : WritecommentAux_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(WritecommentAux_1_3);
    }
}

sealed class WritecommentAux_1_lis : WritecommentAux_1 {
    static internal readonly Predicate WritecommentAux_1_lis_1 = new Predicates.WritecommentAux_1_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(WritecommentAux_1_2, WritecommentAux_1_lis_1);
    }
}

sealed class WritecommentAux_1_lis_1 : WritecommentAux_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(WritecommentAux_1_3);
    }
}

sealed class WritecommentAux_1_1 : WritecommentAux_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class WritecommentAux_1_2 : WritecommentAux_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("punctuation");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a2 = ((ListTerm)a1).car;
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a2, a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a4 = engine.makeVariable();
        a6 = engine.makeVariable();
        a5 = new ListTerm(a6, s1);
        p1 = new Predicates.WritecommentAux_1(a3, cont);
        p2 = new Predicates.Write_1(a2, p1);
        p3 = new Predicates.dollar_cut_1(a4, p2);
        p4 = new Predicates.MyCharType_2(a6, s2, p3);
        p5 = new Predicates.Name_2(a2, a5, p4);
        return new Predicates.dollar_getLevel_1(a4, p5);
    }
}

sealed class WritecommentAux_1_3 : WritecommentAux_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol(" ");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a2 = ((ListTerm)a1).car;
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a2, a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        p1 = new Predicates.WritecommentAux_1(a3, cont);
        p2 = new Predicates.Write_1(a2, p1);
        return new Predicates.Write_1(s1, p2);
    }
}
}

