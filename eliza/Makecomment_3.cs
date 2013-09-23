/*
 * *** Please do not edit ! ***
 * @(#) Makecomment_3.cs
 * @procedure makecomment/3 in eliza.pl
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

public class Makecomment_3 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Makecomment_3_1 = new Predicates.Makecomment_3_1();
    static internal readonly Predicate Makecomment_3_2 = new Predicates.Makecomment_3_2();
    static internal readonly Predicate Makecomment_3_3 = new Predicates.Makecomment_3_3();
    static internal readonly Predicate Makecomment_3_4 = new Predicates.Makecomment_3_4();
    static internal readonly Predicate Makecomment_3_5 = new Predicates.Makecomment_3_5();
    static internal readonly Predicate Makecomment_3_var = new Predicates.Makecomment_3_var();

    public Term arg1, arg2, arg3;

    public Makecomment_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Makecomment_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   Makecomment_3_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   Makecomment_3_var
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "makecomment(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class Makecomment_3_var : Makecomment_3 {
    static internal readonly Predicate Makecomment_3_var_1 = new Predicates.Makecomment_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Makecomment_3_1, Makecomment_3_var_1);
    }
}

sealed class Makecomment_3_var_1 : Makecomment_3 {
    static internal readonly Predicate Makecomment_3_var_2 = new Predicates.Makecomment_3_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Makecomment_3_2, Makecomment_3_var_2);
    }
}

sealed class Makecomment_3_var_2 : Makecomment_3 {
    static internal readonly Predicate Makecomment_3_var_3 = new Predicates.Makecomment_3_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Makecomment_3_3, Makecomment_3_var_3);
    }
}

sealed class Makecomment_3_var_3 : Makecomment_3 {
    static internal readonly Predicate Makecomment_3_var_4 = new Predicates.Makecomment_3_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Makecomment_3_4, Makecomment_3_var_4);
    }
}

sealed class Makecomment_3_var_4 : Makecomment_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Makecomment_3_5);
    }
}

sealed class Makecomment_3_1 : Makecomment_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("your");
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly SymbolTerm f6 = SymbolTerm.MakeSymbol("mem", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        Term[] h7 = {a2};
        a6 = new StructureTerm(f6, h7);
        a9 = engine.makeVariable();
        a8 = new ListTerm(a9, s3);
        a7 = new ListTerm(s5, a8);
        a10 = new ListTerm(s5, a4);
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.McAux_4(a10, a9, a2, a3, p1);
        p3 = new Predicates.Rules_1(a7, p2);
        p4 = new Predicates.Assertz_1(a6, p3);
        return new Predicates.dollar_getLevel_1(a5, p4);
    }
}

sealed class Makecomment_3_2 : Makecomment_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("memory");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly SymbolTerm f6 = SymbolTerm.MakeSymbol("mem", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        a7 = engine.makeVariable();
        Term[] h7 = {a7};
        a6 = new StructureTerm(f6, h7);
        Term[] h8 = {a7};
        a8 = new StructureTerm(f6, h8);
        a11 = engine.makeVariable();
        a10 = new ListTerm(a11, s3);
        a9 = new ListTerm(s5, a10);
        a12 = new ListTerm(s5, a4);
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.McAux_4(a12, a11, a7, a3, p1);
        p3 = new Predicates.Rules_1(a9, p2);
        p4 = new Predicates.Retractall_1(a8, p3);
        p5 = new Predicates.Retract_1(a6, p4);
        return new Predicates.dollar_getLevel_1(a5, p5);
    }
}

sealed class Makecomment_3_3 : Makecomment_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("memory");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        p1 = new Predicates.Makecomment_3(a4, a2, a3, cont);
        p2 = new Predicates.dollar_cut_1(a5, p1);
        p3 = new Predicates.dollar_dummyEliza__1_1(engine.makeVariable(), p2);
        return new Predicates.dollar_getLevel_1(a5, p3);
    }
}

sealed class Makecomment_3_4 : Makecomment_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2, p3;
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
        a6 = engine.makeVariable();
        a9 = engine.makeVariable();
        a8 = new ListTerm(a9, s1);
        a7 = new ListTerm(a4, a8);
        a10 = new ListTerm(a4, a5);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.McAux_4(a10, a9, a2, a3, p1);
        p3 = new Predicates.Rules_1(a7, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Makecomment_3_5 : Makecomment_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(engine.makeVariable(), a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.Makecomment_3(a4, a2, a3, p1);
        return new Predicates.dollar_getLevel_1(a5, p2);
    }
}
}

