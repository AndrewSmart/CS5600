/*
 * *** Please do not edit ! ***
 * @(#) ProcessInput_3.cs
 * @procedure process_input/3 in eliza.pl
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

public class ProcessInput_3 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate ProcessInput_3_1 = new Predicates.ProcessInput_3_1();
    static internal readonly Predicate ProcessInput_3_2 = new Predicates.ProcessInput_3_2();
    static internal readonly Predicate ProcessInput_3_3 = new Predicates.ProcessInput_3_3();
    static internal readonly Predicate ProcessInput_3_4 = new Predicates.ProcessInput_3_4();
    static internal readonly Predicate ProcessInput_3_5 = new Predicates.ProcessInput_3_5();
    static internal readonly Predicate ProcessInput_3_6 = new Predicates.ProcessInput_3_6();
    static internal readonly Predicate ProcessInput_3_lis = new Predicates.ProcessInput_3_lis();
    static internal readonly Predicate ProcessInput_3_var = new Predicates.ProcessInput_3_var();

    public Term arg1, arg2, arg3;

    public ProcessInput_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public ProcessInput_3(){}
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
                                   ProcessInput_3_var,
                                   dollar_fail_0,
                                   ProcessInput_3_1,
                                   dollar_fail_0,
                                   ProcessInput_3_lis
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "process_input(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class ProcessInput_3_var : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_var_1 = new Predicates.ProcessInput_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ProcessInput_3_1, ProcessInput_3_var_1);
    }
}

sealed class ProcessInput_3_var_1 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_var_2 = new Predicates.ProcessInput_3_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_2, ProcessInput_3_var_2);
    }
}

sealed class ProcessInput_3_var_2 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_var_3 = new Predicates.ProcessInput_3_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_3, ProcessInput_3_var_3);
    }
}

sealed class ProcessInput_3_var_3 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_var_4 = new Predicates.ProcessInput_3_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_4, ProcessInput_3_var_4);
    }
}

sealed class ProcessInput_3_var_4 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_var_5 = new Predicates.ProcessInput_3_var_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_5, ProcessInput_3_var_5);
    }
}

sealed class ProcessInput_3_var_5 : ProcessInput_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ProcessInput_3_6);
    }
}

sealed class ProcessInput_3_lis : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_lis_1 = new Predicates.ProcessInput_3_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ProcessInput_3_2, ProcessInput_3_lis_1);
    }
}

sealed class ProcessInput_3_lis_1 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_lis_2 = new Predicates.ProcessInput_3_lis_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_3, ProcessInput_3_lis_2);
    }
}

sealed class ProcessInput_3_lis_2 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_lis_3 = new Predicates.ProcessInput_3_lis_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_4, ProcessInput_3_lis_3);
    }
}

sealed class ProcessInput_3_lis_3 : ProcessInput_3 {
    static internal readonly Predicate ProcessInput_3_lis_4 = new Predicates.ProcessInput_3_lis_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ProcessInput_3_5, ProcessInput_3_lis_4);
    }
}

sealed class ProcessInput_3_lis_4 : ProcessInput_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ProcessInput_3_6);
    }
}

sealed class ProcessInput_3_1 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class ProcessInput_3_2 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol(".");
    static internal readonly IntegerTerm s2 = new IntegerTerm(3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
        } else if ( a1.IsVariable() ){
            if ( !a1.Unify(new ListTerm(s1, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.dollar_greaterOrEqual_2(a6, s2, p1);
        p3 = new Predicates.Length_2(a5, a6, p2);
        p4 = new Predicates.Findkeywords_2(a2, a5, p3);
        return new Predicates.dollar_getLevel_1(a4, p4);
    }
}

sealed class ProcessInput_3_3 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol(".");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        p1 = new Predicates.ProcessInput_3(a4, s2, a3, cont);
        return new Predicates.dollar_neckCut_0(p1);
    }
}

sealed class ProcessInput_3_4 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol(",");
    static internal readonly IntegerTerm s2 = new IntegerTerm(3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
        } else if ( a1.IsVariable() ){
            if ( !a1.Unify(new ListTerm(s1, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.dollar_greaterOrEqual_2(a6, s2, p1);
        p3 = new Predicates.Length_2(a5, a6, p2);
        p4 = new Predicates.Findkeywords_2(a2, a5, p3);
        return new Predicates.dollar_getLevel_1(a4, p4);
    }
}

sealed class ProcessInput_3_5 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        p1 = new Predicates.ProcessInput_3(a4, s2, a3, cont);
        return new Predicates.dollar_neckCut_0(p1);
    }
}

sealed class ProcessInput_3_6 : ProcessInput_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1;
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
        a6 = new ListTerm(a4, s1);
        a7 = engine.makeVariable();
        p1 = new Predicates.ProcessInput_3(a5, a7, a3, cont);
        return new Predicates.Append_3(a2, a6, a7, p1);
    }
}
}

