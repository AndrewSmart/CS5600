/*
 * *** Please do not edit ! ***
 * @(#) Sr_4.cs
 * @procedure sr/4 in eliza.pl
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

public class Sr_4 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Sr_4_1 = new Predicates.Sr_4_1();
    static internal readonly Predicate Sr_4_2 = new Predicates.Sr_4_2();
    static internal readonly Predicate Sr_4_3 = new Predicates.Sr_4_3();
    static internal readonly Predicate Sr_4_4 = new Predicates.Sr_4_4();
    static internal readonly Predicate Sr_4_5 = new Predicates.Sr_4_5();
    static internal readonly Predicate Sr_4_6 = new Predicates.Sr_4_6();
    static internal readonly Predicate Sr_4_7 = new Predicates.Sr_4_7();
    static internal readonly Predicate Sr_4_8 = new Predicates.Sr_4_8();
    static internal readonly Predicate Sr_4_9 = new Predicates.Sr_4_9();
    static internal readonly Predicate Sr_4_10 = new Predicates.Sr_4_10();
    static internal readonly Predicate Sr_4_11 = new Predicates.Sr_4_11();
    static internal readonly Predicate Sr_4_12 = new Predicates.Sr_4_12();
    static internal readonly Predicate Sr_4_13 = new Predicates.Sr_4_13();
    static internal readonly Predicate Sr_4_14 = new Predicates.Sr_4_14();
    static internal readonly Predicate Sr_4_15 = new Predicates.Sr_4_15();
    static internal readonly Predicate Sr_4_16 = new Predicates.Sr_4_16();
    static internal readonly Predicate Sr_4_17 = new Predicates.Sr_4_17();
    static internal readonly Predicate Sr_4_18 = new Predicates.Sr_4_18();
    static internal readonly Predicate Sr_4_19 = new Predicates.Sr_4_19();
    static internal readonly Predicate Sr_4_20 = new Predicates.Sr_4_20();
    static internal readonly Predicate Sr_4_21 = new Predicates.Sr_4_21();
    static internal readonly Predicate Sr_4_22 = new Predicates.Sr_4_22();
    static internal readonly Predicate Sr_4_23 = new Predicates.Sr_4_23();
    static internal readonly Predicate Sr_4_24 = new Predicates.Sr_4_24();
    static internal readonly Predicate Sr_4_25 = new Predicates.Sr_4_25();
    static internal readonly Predicate Sr_4_26 = new Predicates.Sr_4_26();
    static internal readonly Predicate Sr_4_27 = new Predicates.Sr_4_27();
    static internal readonly Predicate Sr_4_28 = new Predicates.Sr_4_28();
    static internal readonly Predicate Sr_4_29 = new Predicates.Sr_4_29();
    static internal readonly Predicate Sr_4_30 = new Predicates.Sr_4_30();
    static internal readonly Predicate Sr_4_31 = new Predicates.Sr_4_31();
    static internal readonly Predicate Sr_4_32 = new Predicates.Sr_4_32();
    static internal readonly Predicate Sr_4_33 = new Predicates.Sr_4_33();
    static internal readonly Predicate Sr_4_var = new Predicates.Sr_4_var();

    public Term arg1, arg2, arg3, arg4;

    public Sr_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Sr_4(){}
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
                                   Sr_4_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   Sr_4_var
                                   );
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "sr(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class Sr_4_var : Sr_4 {
    static internal readonly Predicate Sr_4_var_1 = new Predicates.Sr_4_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Sr_4_1, Sr_4_var_1);
    }
}

sealed class Sr_4_var_1 : Sr_4 {
    static internal readonly Predicate Sr_4_var_2 = new Predicates.Sr_4_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_2, Sr_4_var_2);
    }
}

sealed class Sr_4_var_2 : Sr_4 {
    static internal readonly Predicate Sr_4_var_3 = new Predicates.Sr_4_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_3, Sr_4_var_3);
    }
}

sealed class Sr_4_var_3 : Sr_4 {
    static internal readonly Predicate Sr_4_var_4 = new Predicates.Sr_4_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_4, Sr_4_var_4);
    }
}

sealed class Sr_4_var_4 : Sr_4 {
    static internal readonly Predicate Sr_4_var_5 = new Predicates.Sr_4_var_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_5, Sr_4_var_5);
    }
}

sealed class Sr_4_var_5 : Sr_4 {
    static internal readonly Predicate Sr_4_var_6 = new Predicates.Sr_4_var_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_6, Sr_4_var_6);
    }
}

sealed class Sr_4_var_6 : Sr_4 {
    static internal readonly Predicate Sr_4_var_7 = new Predicates.Sr_4_var_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_7, Sr_4_var_7);
    }
}

sealed class Sr_4_var_7 : Sr_4 {
    static internal readonly Predicate Sr_4_var_8 = new Predicates.Sr_4_var_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_8, Sr_4_var_8);
    }
}

sealed class Sr_4_var_8 : Sr_4 {
    static internal readonly Predicate Sr_4_var_9 = new Predicates.Sr_4_var_9();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_9, Sr_4_var_9);
    }
}

sealed class Sr_4_var_9 : Sr_4 {
    static internal readonly Predicate Sr_4_var_10 = new Predicates.Sr_4_var_10();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_10, Sr_4_var_10);
    }
}

sealed class Sr_4_var_10 : Sr_4 {
    static internal readonly Predicate Sr_4_var_11 = new Predicates.Sr_4_var_11();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_11, Sr_4_var_11);
    }
}

sealed class Sr_4_var_11 : Sr_4 {
    static internal readonly Predicate Sr_4_var_12 = new Predicates.Sr_4_var_12();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_12, Sr_4_var_12);
    }
}

sealed class Sr_4_var_12 : Sr_4 {
    static internal readonly Predicate Sr_4_var_13 = new Predicates.Sr_4_var_13();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_13, Sr_4_var_13);
    }
}

sealed class Sr_4_var_13 : Sr_4 {
    static internal readonly Predicate Sr_4_var_14 = new Predicates.Sr_4_var_14();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_14, Sr_4_var_14);
    }
}

sealed class Sr_4_var_14 : Sr_4 {
    static internal readonly Predicate Sr_4_var_15 = new Predicates.Sr_4_var_15();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_15, Sr_4_var_15);
    }
}

sealed class Sr_4_var_15 : Sr_4 {
    static internal readonly Predicate Sr_4_var_16 = new Predicates.Sr_4_var_16();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_16, Sr_4_var_16);
    }
}

sealed class Sr_4_var_16 : Sr_4 {
    static internal readonly Predicate Sr_4_var_17 = new Predicates.Sr_4_var_17();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_17, Sr_4_var_17);
    }
}

sealed class Sr_4_var_17 : Sr_4 {
    static internal readonly Predicate Sr_4_var_18 = new Predicates.Sr_4_var_18();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_18, Sr_4_var_18);
    }
}

sealed class Sr_4_var_18 : Sr_4 {
    static internal readonly Predicate Sr_4_var_19 = new Predicates.Sr_4_var_19();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_19, Sr_4_var_19);
    }
}

sealed class Sr_4_var_19 : Sr_4 {
    static internal readonly Predicate Sr_4_var_20 = new Predicates.Sr_4_var_20();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_20, Sr_4_var_20);
    }
}

sealed class Sr_4_var_20 : Sr_4 {
    static internal readonly Predicate Sr_4_var_21 = new Predicates.Sr_4_var_21();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_21, Sr_4_var_21);
    }
}

sealed class Sr_4_var_21 : Sr_4 {
    static internal readonly Predicate Sr_4_var_22 = new Predicates.Sr_4_var_22();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_22, Sr_4_var_22);
    }
}

sealed class Sr_4_var_22 : Sr_4 {
    static internal readonly Predicate Sr_4_var_23 = new Predicates.Sr_4_var_23();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_23, Sr_4_var_23);
    }
}

sealed class Sr_4_var_23 : Sr_4 {
    static internal readonly Predicate Sr_4_var_24 = new Predicates.Sr_4_var_24();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_24, Sr_4_var_24);
    }
}

sealed class Sr_4_var_24 : Sr_4 {
    static internal readonly Predicate Sr_4_var_25 = new Predicates.Sr_4_var_25();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_25, Sr_4_var_25);
    }
}

sealed class Sr_4_var_25 : Sr_4 {
    static internal readonly Predicate Sr_4_var_26 = new Predicates.Sr_4_var_26();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_26, Sr_4_var_26);
    }
}

sealed class Sr_4_var_26 : Sr_4 {
    static internal readonly Predicate Sr_4_var_27 = new Predicates.Sr_4_var_27();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_27, Sr_4_var_27);
    }
}

sealed class Sr_4_var_27 : Sr_4 {
    static internal readonly Predicate Sr_4_var_28 = new Predicates.Sr_4_var_28();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_28, Sr_4_var_28);
    }
}

sealed class Sr_4_var_28 : Sr_4 {
    static internal readonly Predicate Sr_4_var_29 = new Predicates.Sr_4_var_29();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_29, Sr_4_var_29);
    }
}

sealed class Sr_4_var_29 : Sr_4 {
    static internal readonly Predicate Sr_4_var_30 = new Predicates.Sr_4_var_30();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_30, Sr_4_var_30);
    }
}

sealed class Sr_4_var_30 : Sr_4 {
    static internal readonly Predicate Sr_4_var_31 = new Predicates.Sr_4_var_31();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_31, Sr_4_var_31);
    }
}

sealed class Sr_4_var_31 : Sr_4 {
    static internal readonly Predicate Sr_4_var_32 = new Predicates.Sr_4_var_32();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Sr_4_32, Sr_4_var_32);
    }
}

sealed class Sr_4_var_32 : Sr_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Sr_4_33);
    }
}

sealed class Sr_4_1 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("dont");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s2.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a6.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a7.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_2 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("cant");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s2.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a6.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a7.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_3 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("cannot");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("cant");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_4 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("will");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("wont");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s2.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a6.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a7.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_5 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dreamed");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("dreamt");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_6 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dreams");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("dream");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_7 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("how");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("what");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_8 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("when");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("what");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_9 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("alike");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("dit");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_10 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("same");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("dit");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_11 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("certainly");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yes");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_12 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("maybe");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("perhaps");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_13 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("deutsch");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("xfremd");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_14 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("francais");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("xfremd");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_15 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("espanol");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("xfremd");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_16 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("machine");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("computer");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_17 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("machines");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("computer");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_18 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("computers");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("computer");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_19 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("are");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_20 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("my");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_21 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("were");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("was");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_22 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("you");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_23 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("im");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s2.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a6.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a7.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_24 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("youre");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            if ( !s2.Unify(((ListTerm)a5).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s3.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s3, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a6.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a7.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_25 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("myself");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yourself");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_26 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("yourself");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("myself");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_27 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("mom");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("mother");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_28 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dad");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("father");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_29 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("you");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_30 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("i");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_31 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("my");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("your");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_32 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("everybody");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("everyone");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Sr_4_33 : Sr_4 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("nobody");
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("everyone");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s1.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s1, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            if ( !s2.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(s2, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a3, engine.trail) ) return engine.fail();
        if ( !a6.Unify(a4, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

