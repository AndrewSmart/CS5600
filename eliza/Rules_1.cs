/*
 * *** Please do not edit ! ***
 * @(#) Rules_1.cs
 * @procedure rules/1 in eliza.pl
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

public class Rules_1 : Predicate {
    static internal readonly Predicate Rules_1_1 = new Predicates.Rules_1_1();
    static internal readonly Predicate Rules_1_2 = new Predicates.Rules_1_2();
    static internal readonly Predicate Rules_1_3 = new Predicates.Rules_1_3();
    static internal readonly Predicate Rules_1_4 = new Predicates.Rules_1_4();
    static internal readonly Predicate Rules_1_5 = new Predicates.Rules_1_5();
    static internal readonly Predicate Rules_1_6 = new Predicates.Rules_1_6();
    static internal readonly Predicate Rules_1_7 = new Predicates.Rules_1_7();
    static internal readonly Predicate Rules_1_8 = new Predicates.Rules_1_8();
    static internal readonly Predicate Rules_1_9 = new Predicates.Rules_1_9();
    static internal readonly Predicate Rules_1_10 = new Predicates.Rules_1_10();
    static internal readonly Predicate Rules_1_11 = new Predicates.Rules_1_11();
    static internal readonly Predicate Rules_1_12 = new Predicates.Rules_1_12();
    static internal readonly Predicate Rules_1_13 = new Predicates.Rules_1_13();
    static internal readonly Predicate Rules_1_14 = new Predicates.Rules_1_14();
    static internal readonly Predicate Rules_1_15 = new Predicates.Rules_1_15();
    static internal readonly Predicate Rules_1_16 = new Predicates.Rules_1_16();
    static internal readonly Predicate Rules_1_17 = new Predicates.Rules_1_17();
    static internal readonly Predicate Rules_1_18 = new Predicates.Rules_1_18();
    static internal readonly Predicate Rules_1_19 = new Predicates.Rules_1_19();
    static internal readonly Predicate Rules_1_20 = new Predicates.Rules_1_20();
    static internal readonly Predicate Rules_1_21 = new Predicates.Rules_1_21();
    static internal readonly Predicate Rules_1_22 = new Predicates.Rules_1_22();
    static internal readonly Predicate Rules_1_23 = new Predicates.Rules_1_23();
    static internal readonly Predicate Rules_1_24 = new Predicates.Rules_1_24();
    static internal readonly Predicate Rules_1_25 = new Predicates.Rules_1_25();
    static internal readonly Predicate Rules_1_26 = new Predicates.Rules_1_26();
    static internal readonly Predicate Rules_1_27 = new Predicates.Rules_1_27();
    static internal readonly Predicate Rules_1_28 = new Predicates.Rules_1_28();
    static internal readonly Predicate Rules_1_29 = new Predicates.Rules_1_29();
    static internal readonly Predicate Rules_1_30 = new Predicates.Rules_1_30();
    static internal readonly Predicate Rules_1_31 = new Predicates.Rules_1_31();
    static internal readonly Predicate Rules_1_32 = new Predicates.Rules_1_32();
    static internal readonly Predicate Rules_1_var = new Predicates.Rules_1_var();

    public Term arg1;

    public Rules_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Rules_1(){}
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
                                   Rules_1_var,
                                   Rules_1_1,
                                   Rules_1_1,
                                   Rules_1_1,
                                   Rules_1_var
                                   );
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "rules(" + arg1 + ")";
    }
}

sealed class Rules_1_var : Rules_1 {
    static internal readonly Predicate Rules_1_var_1 = new Predicates.Rules_1_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Rules_1_1, Rules_1_var_1);
    }
}

sealed class Rules_1_var_1 : Rules_1 {
    static internal readonly Predicate Rules_1_var_2 = new Predicates.Rules_1_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_2, Rules_1_var_2);
    }
}

sealed class Rules_1_var_2 : Rules_1 {
    static internal readonly Predicate Rules_1_var_3 = new Predicates.Rules_1_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_3, Rules_1_var_3);
    }
}

sealed class Rules_1_var_3 : Rules_1 {
    static internal readonly Predicate Rules_1_var_4 = new Predicates.Rules_1_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_4, Rules_1_var_4);
    }
}

sealed class Rules_1_var_4 : Rules_1 {
    static internal readonly Predicate Rules_1_var_5 = new Predicates.Rules_1_var_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_5, Rules_1_var_5);
    }
}

sealed class Rules_1_var_5 : Rules_1 {
    static internal readonly Predicate Rules_1_var_6 = new Predicates.Rules_1_var_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_6, Rules_1_var_6);
    }
}

sealed class Rules_1_var_6 : Rules_1 {
    static internal readonly Predicate Rules_1_var_7 = new Predicates.Rules_1_var_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_7, Rules_1_var_7);
    }
}

sealed class Rules_1_var_7 : Rules_1 {
    static internal readonly Predicate Rules_1_var_8 = new Predicates.Rules_1_var_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_8, Rules_1_var_8);
    }
}

sealed class Rules_1_var_8 : Rules_1 {
    static internal readonly Predicate Rules_1_var_9 = new Predicates.Rules_1_var_9();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_9, Rules_1_var_9);
    }
}

sealed class Rules_1_var_9 : Rules_1 {
    static internal readonly Predicate Rules_1_var_10 = new Predicates.Rules_1_var_10();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_10, Rules_1_var_10);
    }
}

sealed class Rules_1_var_10 : Rules_1 {
    static internal readonly Predicate Rules_1_var_11 = new Predicates.Rules_1_var_11();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_11, Rules_1_var_11);
    }
}

sealed class Rules_1_var_11 : Rules_1 {
    static internal readonly Predicate Rules_1_var_12 = new Predicates.Rules_1_var_12();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_12, Rules_1_var_12);
    }
}

sealed class Rules_1_var_12 : Rules_1 {
    static internal readonly Predicate Rules_1_var_13 = new Predicates.Rules_1_var_13();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_13, Rules_1_var_13);
    }
}

sealed class Rules_1_var_13 : Rules_1 {
    static internal readonly Predicate Rules_1_var_14 = new Predicates.Rules_1_var_14();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_14, Rules_1_var_14);
    }
}

sealed class Rules_1_var_14 : Rules_1 {
    static internal readonly Predicate Rules_1_var_15 = new Predicates.Rules_1_var_15();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_15, Rules_1_var_15);
    }
}

sealed class Rules_1_var_15 : Rules_1 {
    static internal readonly Predicate Rules_1_var_16 = new Predicates.Rules_1_var_16();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_16, Rules_1_var_16);
    }
}

sealed class Rules_1_var_16 : Rules_1 {
    static internal readonly Predicate Rules_1_var_17 = new Predicates.Rules_1_var_17();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_17, Rules_1_var_17);
    }
}

sealed class Rules_1_var_17 : Rules_1 {
    static internal readonly Predicate Rules_1_var_18 = new Predicates.Rules_1_var_18();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_18, Rules_1_var_18);
    }
}

sealed class Rules_1_var_18 : Rules_1 {
    static internal readonly Predicate Rules_1_var_19 = new Predicates.Rules_1_var_19();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_19, Rules_1_var_19);
    }
}

sealed class Rules_1_var_19 : Rules_1 {
    static internal readonly Predicate Rules_1_var_20 = new Predicates.Rules_1_var_20();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_20, Rules_1_var_20);
    }
}

sealed class Rules_1_var_20 : Rules_1 {
    static internal readonly Predicate Rules_1_var_21 = new Predicates.Rules_1_var_21();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_21, Rules_1_var_21);
    }
}

sealed class Rules_1_var_21 : Rules_1 {
    static internal readonly Predicate Rules_1_var_22 = new Predicates.Rules_1_var_22();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_22, Rules_1_var_22);
    }
}

sealed class Rules_1_var_22 : Rules_1 {
    static internal readonly Predicate Rules_1_var_23 = new Predicates.Rules_1_var_23();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_23, Rules_1_var_23);
    }
}

sealed class Rules_1_var_23 : Rules_1 {
    static internal readonly Predicate Rules_1_var_24 = new Predicates.Rules_1_var_24();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_24, Rules_1_var_24);
    }
}

sealed class Rules_1_var_24 : Rules_1 {
    static internal readonly Predicate Rules_1_var_25 = new Predicates.Rules_1_var_25();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_25, Rules_1_var_25);
    }
}

sealed class Rules_1_var_25 : Rules_1 {
    static internal readonly Predicate Rules_1_var_26 = new Predicates.Rules_1_var_26();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_26, Rules_1_var_26);
    }
}

sealed class Rules_1_var_26 : Rules_1 {
    static internal readonly Predicate Rules_1_var_27 = new Predicates.Rules_1_var_27();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_27, Rules_1_var_27);
    }
}

sealed class Rules_1_var_27 : Rules_1 {
    static internal readonly Predicate Rules_1_var_28 = new Predicates.Rules_1_var_28();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_28, Rules_1_var_28);
    }
}

sealed class Rules_1_var_28 : Rules_1 {
    static internal readonly Predicate Rules_1_var_29 = new Predicates.Rules_1_var_29();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_29, Rules_1_var_29);
    }
}

sealed class Rules_1_var_29 : Rules_1 {
    static internal readonly Predicate Rules_1_var_30 = new Predicates.Rules_1_var_30();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_30, Rules_1_var_30);
    }
}

sealed class Rules_1_var_30 : Rules_1 {
    static internal readonly Predicate Rules_1_var_31 = new Predicates.Rules_1_var_31();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Rules_1_31, Rules_1_var_31);
    }
}

sealed class Rules_1_var_31 : Rules_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Rules_1_32);
    }
}

sealed class Rules_1_1 : Rules_1 {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("rules", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        Term[] h2 = {a1};
        a2 = new StructureTerm(f1, h2);
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_call_1(a3, cont);
        return new Predicates.Clause_2(a2, a3, p1);
    }
}

sealed class Rules_1_2 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("sorry");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("please");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("apologize");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s10, s12);
    static internal readonly ListTerm s14 = new ListTerm(s9, s13);
    static internal readonly ListTerm s15 = new ListTerm(s8, s14);
    static internal readonly ListTerm s16 = new ListTerm(s7, s15);
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("apologies");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("necessary");
    static internal readonly ListTerm s20 = new ListTerm(s19, s12);
    static internal readonly ListTerm s21 = new ListTerm(s9, s20);
    static internal readonly ListTerm s22 = new ListTerm(s18, s21);
    static internal readonly ListTerm s23 = new ListTerm(s17, s22);
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("feelings");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("when");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s30 = new ListTerm(s29, s3);
    static internal readonly ListTerm s31 = new ListTerm(s10, s30);
    static internal readonly ListTerm s32 = new ListTerm(s26, s31);
    static internal readonly ListTerm s33 = new ListTerm(s28, s32);
    static internal readonly ListTerm s34 = new ListTerm(s27, s33);
    static internal readonly ListTerm s35 = new ListTerm(s26, s34);
    static internal readonly ListTerm s36 = new ListTerm(s8, s35);
    static internal readonly ListTerm s37 = new ListTerm(s25, s36);
    static internal readonly ListTerm s38 = new ListTerm(s24, s37);
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("told");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("required");
    static internal readonly ListTerm s43 = new ListTerm(s42, s12);
    static internal readonly ListTerm s44 = new ListTerm(s9, s43);
    static internal readonly ListTerm s45 = new ListTerm(s18, s44);
    static internal readonly ListTerm s46 = new ListTerm(s17, s45);
    static internal readonly ListTerm s47 = new ListTerm(s41, s46);
    static internal readonly ListTerm s48 = new ListTerm(s26, s47);
    static internal readonly ListTerm s49 = new ListTerm(s40, s48);
    static internal readonly ListTerm s50 = new ListTerm(s27, s49);
    static internal readonly ListTerm s51 = new ListTerm(s39, s50);
    static internal readonly ListTerm s52 = new ListTerm(s51, s3);
    static internal readonly ListTerm s53 = new ListTerm(s38, s52);
    static internal readonly ListTerm s54 = new ListTerm(s23, s53);
    static internal readonly ListTerm s55 = new ListTerm(s16, s54);
    static internal readonly ListTerm s56 = new ListTerm(s2, s55);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s56.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_3 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("remember");
    static internal readonly IntegerTerm s2 = new IntegerTerm(5);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly IntegerTerm s8 = new IntegerTerm(0);
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("often");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("of");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s14 = new ListTerm(s13, s3);
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("thinking");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("bring");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("anything");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("else");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("mind");
    static internal readonly ListTerm s22 = new ListTerm(s21, s14);
    static internal readonly ListTerm s23 = new ListTerm(s20, s22);
    static internal readonly ListTerm s24 = new ListTerm(s19, s23);
    static internal readonly ListTerm s25 = new ListTerm(s18, s24);
    static internal readonly ListTerm s26 = new ListTerm(s17, s25);
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("what");
    static internal readonly ListTerm s28 = new ListTerm(s1, s14);
    static internal readonly ListTerm s29 = new ListTerm(s7, s28);
    static internal readonly ListTerm s30 = new ListTerm(s9, s29);
    static internal readonly ListTerm s31 = new ListTerm(s19, s30);
    static internal readonly ListTerm s32 = new ListTerm(s27, s31);
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("just");
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("now");
    static internal readonly ListTerm s36 = new ListTerm(s35, s14);
    static internal readonly ListTerm s37 = new ListTerm(s34, s36);
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("the");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("present");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("situation");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("reminds");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("connection");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("between");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("and");
    static internal readonly IntegerTerm s48 = new IntegerTerm(2);
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s50 = SymbolTerm.MakeSymbol("did");
    static internal readonly SymbolTerm s51 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol("forget");
    static internal readonly SymbolTerm s54 = SymbolTerm.MakeSymbol("should");
    static internal readonly SymbolTerm s55 = SymbolTerm.MakeSymbol("recall");
    static internal readonly SymbolTerm s56 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s57 = SymbolTerm.MakeSymbol("equal");
    static internal readonly ListTerm s58 = new ListTerm(s8, s3);
    static internal readonly ListTerm s59 = new ListTerm(s27, s58);
    static internal readonly ListTerm s60 = new ListTerm(s59, s3);
    static internal readonly ListTerm s61 = new ListTerm(s57, s60);
    static internal readonly SymbolTerm s62 = SymbolTerm.MakeSymbol("mentioned");
    static internal readonly SymbolTerm s63 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s64 = new ListTerm(s63, s3);
    static internal readonly IntegerTerm s65 = new IntegerTerm(3);
    static internal readonly SymbolTerm s66 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly ListTerm s67 = new ListTerm(s66, s3);
    static internal readonly ListTerm s68 = new ListTerm(s67, s3);
    static internal readonly ListTerm s69 = new ListTerm(s8, s68);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s7.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s7, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s1.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s1, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s8.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s8, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a14 = ((ListTerm)a13).car;
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a14, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s9.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s9, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s7.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s7, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s10.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s10, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s11.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s11, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s12, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            a21 = ((ListTerm)a15).car;
            a22 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a21 = engine.makeVariable();
            a22 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(a21, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s15.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s15, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s16.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s16, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s12.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s12, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !a12.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            if ( !s26.Unify(((ListTerm)a25).cdr, engine.trail) )
                return engine.fail();
        } else if ( a25.IsVariable() ){
            if ( !a25.Unify(new ListTerm(a12, s26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s32.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(s32, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            a27 = ((ListTerm)a26).car;
            a28 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a27 = engine.makeVariable();
            a28 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(a27, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s33.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s33, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s9.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s9, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s7.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s7, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s1.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s1, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !a12.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            if ( !s37.Unify(((ListTerm)a32).cdr, engine.trail) )
                return engine.fail();
        } else if ( a32.IsVariable() ){
            if ( !a32.Unify(new ListTerm(a12, s37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            a33 = ((ListTerm)a28).car;
            a34 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a33 = engine.makeVariable();
            a34 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(a33, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s27.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s27, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s38.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s38, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s39.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(s39, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s40.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a38 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s40, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            if ( !s41.Unify(((ListTerm)a38).car, engine.trail) )
                return engine.fail();
            a39 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(s41, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s42.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a40 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s42, a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s7.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a40).cdr, engine.trail) )
                return engine.fail();
        } else if ( a40.IsVariable() ){
            if ( !a40.Unify(new ListTerm(s7, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(s12, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            a41 = ((ListTerm)a34).car;
            if ( !s3.Unify(((ListTerm)a34).cdr, engine.trail) )
                return engine.fail();
        } else if ( a34.IsVariable() ){
            a41 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(a41, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s27.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a42 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s27, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s43.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s43, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            if ( !s39.Unify(((ListTerm)a43).car, engine.trail) )
                return engine.fail();
            a44 = ((ListTerm)a43).cdr;
        } else if ( a43.IsVariable() ){
            a44 = engine.makeVariable();
            if ( !a43.Unify(new ListTerm(s39, a44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s44.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            a45 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a45 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(s44, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            if ( !s45.Unify(((ListTerm)a45).car, engine.trail) )
                return engine.fail();
            a46 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a46 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(s45, a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s46.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s46, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s47.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a47).cdr, engine.trail) )
                return engine.fail();
        } else if ( a47.IsVariable() ){
            if ( !a47.Unify(new ListTerm(s47, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a48 = ((ListTerm)a5).car;
            a49 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a48 = engine.makeVariable();
            a49 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a48, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s48.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a50 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a50 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s48, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            a51 = ((ListTerm)a50).car;
            a52 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a51 = engine.makeVariable();
            a52 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(a51, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            a53 = ((ListTerm)a51).cdr;
        } else if ( a51.IsVariable() ){
            a53 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(engine.makeVariable(), a53), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            if ( !s9.Unify(((ListTerm)a53).car, engine.trail) )
                return engine.fail();
            a54 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(s9, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s49.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            if ( !a10.Unify(((ListTerm)a54).cdr, engine.trail) )
                return engine.fail();
        } else if ( a54.IsVariable() ){
            if ( !a54.Unify(new ListTerm(s49, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s1.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a10).cdr, engine.trail) )
                return engine.fail();
        } else if ( a10.IsVariable() ){
            if ( !a10.Unify(new ListTerm(s1, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s8.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(s8, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            a56 = ((ListTerm)a55).car;
            a57 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            a57 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(a56, a57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s50.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            a58 = ((ListTerm)a56).cdr;
        } else if ( a56.IsVariable() ){
            a58 = engine.makeVariable();
            if ( !a56.Unify(new ListTerm(s50, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !s7.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(s7, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !s11.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            a60 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a60 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(s11, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            if ( !s51.Unify(((ListTerm)a60).car, engine.trail) )
                return engine.fail();
            a61 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(s51, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s52.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s52, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s53.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a62).cdr, engine.trail) )
                return engine.fail();
        } else if ( a62.IsVariable() ){
            if ( !a62.Unify(new ListTerm(s53, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            a63 = ((ListTerm)a57).car;
            a64 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a63 = engine.makeVariable();
            a64 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(a63, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s33.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            a65 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(s33, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s9.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a66 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s9, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s7.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            a67 = ((ListTerm)a66).cdr;
        } else if ( a66.IsVariable() ){
            a67 = engine.makeVariable();
            if ( !a66.Unify(new ListTerm(s7, a67), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            if ( !s11.Unify(((ListTerm)a67).car, engine.trail) )
                return engine.fail();
            a68 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a68 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(s11, a68), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            if ( !s49.Unify(((ListTerm)a68).car, engine.trail) )
                return engine.fail();
            a69 = ((ListTerm)a68).cdr;
        } else if ( a68.IsVariable() ){
            a69 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(s49, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            if ( !s54.Unify(((ListTerm)a69).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(s54, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s55.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            a71 = ((ListTerm)a70).cdr;
        } else if ( a70.IsVariable() ){
            a71 = engine.makeVariable();
            if ( !a70.Unify(new ListTerm(s55, a71), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !a12.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            if ( !s36.Unify(((ListTerm)a71).cdr, engine.trail) )
                return engine.fail();
        } else if ( a71.IsVariable() ){
            if ( !a71.Unify(new ListTerm(a12, s36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            a72 = ((ListTerm)a64).car;
            a73 = ((ListTerm)a64).cdr;
        } else if ( a64.IsVariable() ){
            a72 = engine.makeVariable();
            a73 = engine.makeVariable();
            if ( !a64.Unify(new ListTerm(a72, a73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a72.IsList() ){
            if ( !s27.Unify(((ListTerm)a72).car, engine.trail) )
                return engine.fail();
            a74 = ((ListTerm)a72).cdr;
        } else if ( a72.IsVariable() ){
            a74 = engine.makeVariable();
            if ( !a72.Unify(new ListTerm(s27, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s56.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a74).cdr, engine.trail) )
                return engine.fail();
        } else if ( a74.IsVariable() ){
            if ( !a74.Unify(new ListTerm(s56, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a73.IsList() ){
            if ( !s61.Unify(((ListTerm)a73).car, engine.trail) )
                return engine.fail();
            a75 = ((ListTerm)a73).cdr;
        } else if ( a73.IsVariable() ){
            a75 = engine.makeVariable();
            if ( !a73.Unify(new ListTerm(s61, a75), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            a76 = ((ListTerm)a75).car;
            if ( !s3.Unify(((ListTerm)a75).cdr, engine.trail) )
                return engine.fail();
        } else if ( a75.IsVariable() ){
            a76 = engine.makeVariable();
            if ( !a75.Unify(new ListTerm(a76, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a76.IsList() ){
            if ( !s7.Unify(((ListTerm)a76).car, engine.trail) )
                return engine.fail();
            a77 = ((ListTerm)a76).cdr;
        } else if ( a76.IsVariable() ){
            a77 = engine.makeVariable();
            if ( !a76.Unify(new ListTerm(s7, a77), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a77.IsList() ){
            if ( !s62.Unify(((ListTerm)a77).car, engine.trail) )
                return engine.fail();
            a78 = ((ListTerm)a77).cdr;
        } else if ( a77.IsVariable() ){
            a78 = engine.makeVariable();
            if ( !a77.Unify(new ListTerm(s62, a78), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a78.IsList() ){
            if ( !a12.Unify(((ListTerm)a78).car, engine.trail) )
                return engine.fail();
            if ( !s64.Unify(((ListTerm)a78).cdr, engine.trail) )
                return engine.fail();
        } else if ( a78.IsVariable() ){
            if ( !a78.Unify(new ListTerm(a12, s64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            a79 = ((ListTerm)a49).car;
            if ( !s3.Unify(((ListTerm)a49).cdr, engine.trail) )
                return engine.fail();
        } else if ( a49.IsVariable() ){
            a79 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(a79, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a79.IsList() ){
            if ( !s65.Unify(((ListTerm)a79).car, engine.trail) )
                return engine.fail();
            a80 = ((ListTerm)a79).cdr;
        } else if ( a79.IsVariable() ){
            a80 = engine.makeVariable();
            if ( !a79.Unify(new ListTerm(s65, a80), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a80.IsList() ){
            a81 = ((ListTerm)a80).car;
            if ( !s69.Unify(((ListTerm)a80).cdr, engine.trail) )
                return engine.fail();
        } else if ( a80.IsVariable() ){
            a81 = engine.makeVariable();
            if ( !a80.Unify(new ListTerm(a81, s69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a81.IsList() ){
            if ( !s3.Unify(((ListTerm)a81).cdr, engine.trail) )
                return engine.fail();
        } else if ( a81.IsVariable() ){
            if ( !a81.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_4 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("if");
    static internal readonly IntegerTerm s2 = new IntegerTerm(3);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("likely");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s16 = new ListTerm(s15, s3);
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("wish");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol(",");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
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
        if ( a6.IsList() ){
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s1.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a9 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s1, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a10 = ((ListTerm)a9).car;
            if ( !s3.Unify(((ListTerm)a9).cdr, engine.trail) )
                return engine.fail();
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a10, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s7.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            a13 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            a13 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s8.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s8, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s9.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s9, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s10.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s10, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s11.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s11, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s12.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s12, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s13.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s13, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s14.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s14, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a10.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s16.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a10, s16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a21 = ((ListTerm)a13).car;
            a22 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a21 = engine.makeVariable();
            a22 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a21, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s8.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s8, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s9.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s9, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s17.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a24).cdr, engine.trail) )
                return engine.fail();
        } else if ( a24.IsVariable() ){
            if ( !a24.Unify(new ListTerm(s17, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s14.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(s14, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a10.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s16.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a10, s16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            a25 = ((ListTerm)a22).car;
            a26 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a25 = engine.makeVariable();
            a26 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(a25, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s18.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s18, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s8.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s8, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s9.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s9, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s10.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s10, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s19.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a30).cdr, engine.trail) )
                return engine.fail();
        } else if ( a30.IsVariable() ){
            if ( !a30.Unify(new ListTerm(s19, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a10.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s16.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a10, s16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            a31 = ((ListTerm)a26).car;
            if ( !s3.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(a31, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s20.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s20, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s21.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s21, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s1.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a33).cdr, engine.trail) )
                return engine.fail();
        } else if ( a33.IsVariable() ){
            if ( !a33.Unify(new ListTerm(s1, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a10.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s16.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a10, s16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_5 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dreamt");
    static internal readonly IntegerTerm s2 = new IntegerTerm(4);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly IntegerTerm s8 = new IntegerTerm(0);
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("ever");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("fantasied");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("while");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("were");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("awake");
    static internal readonly ListTerm s19 = new ListTerm(s18, s12);
    static internal readonly ListTerm s20 = new ListTerm(s17, s19);
    static internal readonly ListTerm s21 = new ListTerm(s7, s20);
    static internal readonly ListTerm s22 = new ListTerm(s16, s21);
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("dream");
    static internal readonly IntegerTerm s25 = new IntegerTerm(3);
    static internal readonly ListTerm s26 = new ListTerm(s25, s3);
    static internal readonly ListTerm s27 = new ListTerm(s24, s26);
    static internal readonly ListTerm s28 = new ListTerm(s27, s3);
    static internal readonly ListTerm s29 = new ListTerm(s23, s28);
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly ListTerm s31 = new ListTerm(s30, s3);
    static internal readonly ListTerm s32 = new ListTerm(s31, s3);
    static internal readonly ListTerm s33 = new ListTerm(s29, s32);
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("before");
    static internal readonly ListTerm s35 = new ListTerm(s34, s12);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
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
        if ( a6.IsList() ){
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s7.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a9 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s7, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            a11 = ((ListTerm)a10).car;
            if ( !s3.Unify(((ListTerm)a10).cdr, engine.trail) )
                return engine.fail();
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(a11, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s8.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a12 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s8, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            a13 = ((ListTerm)a12).car;
            a14 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a13 = engine.makeVariable();
            a14 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(a13, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            if ( !s9.Unify(((ListTerm)a13).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(s9, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s10.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s10, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !a11.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            if ( !s12.Unify(((ListTerm)a16).cdr, engine.trail) )
                return engine.fail();
        } else if ( a16.IsVariable() ){
            if ( !a16.Unify(new ListTerm(a11, s12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            a17 = ((ListTerm)a14).car;
            a18 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a17 = engine.makeVariable();
            a18 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(a17, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s13.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s13, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s7.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s7, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s14.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s14, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s15.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s15, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a11.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s22.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a11, s22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            a23 = ((ListTerm)a18).car;
            if ( !s33.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(a23, s33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s13.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s13, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s7.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s7, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s1.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s1, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !a11.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !s35.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(a11, s35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_6 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dream");
    static internal readonly IntegerTerm s2 = new IntegerTerm(3);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("suggest");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s12, s16);
    static internal readonly ListTerm s18 = new ListTerm(s11, s17);
    static internal readonly ListTerm s19 = new ListTerm(s1, s18);
    static internal readonly ListTerm s20 = new ListTerm(s10, s19);
    static internal readonly ListTerm s21 = new ListTerm(s9, s20);
    static internal readonly ListTerm s22 = new ListTerm(s8, s21);
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("often");
    static internal readonly ListTerm s25 = new ListTerm(s24, s15);
    static internal readonly ListTerm s26 = new ListTerm(s1, s25);
    static internal readonly ListTerm s27 = new ListTerm(s13, s26);
    static internal readonly ListTerm s28 = new ListTerm(s23, s27);
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("persons");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("appear");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("dreams");
    static internal readonly ListTerm s34 = new ListTerm(s33, s15);
    static internal readonly ListTerm s35 = new ListTerm(s32, s34);
    static internal readonly ListTerm s36 = new ListTerm(s31, s35);
    static internal readonly ListTerm s37 = new ListTerm(s30, s36);
    static internal readonly ListTerm s38 = new ListTerm(s29, s37);
    static internal readonly ListTerm s39 = new ListTerm(s8, s38);
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("dreaming");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("has");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("something");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("with");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("problem");
    static internal readonly ListTerm s46 = new ListTerm(s45, s15);
    static internal readonly ListTerm s47 = new ListTerm(s32, s46);
    static internal readonly ListTerm s48 = new ListTerm(s44, s47);
    static internal readonly ListTerm s49 = new ListTerm(s23, s48);
    static internal readonly ListTerm s50 = new ListTerm(s12, s49);
    static internal readonly ListTerm s51 = new ListTerm(s43, s50);
    static internal readonly ListTerm s52 = new ListTerm(s42, s51);
    static internal readonly ListTerm s53 = new ListTerm(s41, s52);
    static internal readonly ListTerm s54 = new ListTerm(s10, s53);
    static internal readonly ListTerm s55 = new ListTerm(s40, s54);
    static internal readonly ListTerm s56 = new ListTerm(s13, s55);
    static internal readonly ListTerm s57 = new ListTerm(s23, s56);
    static internal readonly SymbolTerm s58 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly ListTerm s59 = new ListTerm(s58, s3);
    static internal readonly ListTerm s60 = new ListTerm(s59, s3);
    static internal readonly ListTerm s61 = new ListTerm(s57, s60);
    static internal readonly ListTerm s62 = new ListTerm(s39, s61);
    static internal readonly ListTerm s63 = new ListTerm(s28, s62);
    static internal readonly ListTerm s64 = new ListTerm(s22, s63);
    static internal readonly ListTerm s65 = new ListTerm(s7, s64);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s65.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_7 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("none");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("sure");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("understand");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("fully");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s12, s16);
    static internal readonly ListTerm s18 = new ListTerm(s11, s17);
    static internal readonly ListTerm s19 = new ListTerm(s7, s18);
    static internal readonly ListTerm s20 = new ListTerm(s10, s19);
    static internal readonly ListTerm s21 = new ListTerm(s9, s20);
    static internal readonly ListTerm s22 = new ListTerm(s8, s21);
    static internal readonly ListTerm s23 = new ListTerm(s7, s22);
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("please");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("go");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("on");
    static internal readonly ListTerm s27 = new ListTerm(s26, s15);
    static internal readonly ListTerm s28 = new ListTerm(s25, s27);
    static internal readonly ListTerm s29 = new ListTerm(s24, s28);
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("suggest");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s36 = new ListTerm(s35, s3);
    static internal readonly ListTerm s37 = new ListTerm(s12, s36);
    static internal readonly ListTerm s38 = new ListTerm(s34, s37);
    static internal readonly ListTerm s39 = new ListTerm(s33, s38);
    static internal readonly ListTerm s40 = new ListTerm(s32, s39);
    static internal readonly ListTerm s41 = new ListTerm(s31, s40);
    static internal readonly ListTerm s42 = new ListTerm(s30, s41);
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("feel");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("strongly");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("discussing");
    static internal readonly SymbolTerm s48 = SymbolTerm.MakeSymbol("such");
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("things");
    static internal readonly ListTerm s50 = new ListTerm(s49, s36);
    static internal readonly ListTerm s51 = new ListTerm(s48, s50);
    static internal readonly ListTerm s52 = new ListTerm(s47, s51);
    static internal readonly ListTerm s53 = new ListTerm(s46, s52);
    static internal readonly ListTerm s54 = new ListTerm(s45, s53);
    static internal readonly ListTerm s55 = new ListTerm(s44, s54);
    static internal readonly ListTerm s56 = new ListTerm(s12, s55);
    static internal readonly ListTerm s57 = new ListTerm(s43, s56);
    static internal readonly ListTerm s58 = new ListTerm(s57, s3);
    static internal readonly ListTerm s59 = new ListTerm(s42, s58);
    static internal readonly ListTerm s60 = new ListTerm(s29, s59);
    static internal readonly ListTerm s61 = new ListTerm(s23, s60);
    static internal readonly ListTerm s62 = new ListTerm(s2, s61);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s62.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_8 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("seem");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("quite");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("certain");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s14 = new ListTerm(s13, s3);
    static internal readonly ListTerm s15 = new ListTerm(s12, s14);
    static internal readonly ListTerm s16 = new ListTerm(s11, s15);
    static internal readonly ListTerm s17 = new ListTerm(s10, s16);
    static internal readonly ListTerm s18 = new ListTerm(s9, s17);
    static internal readonly ListTerm s19 = new ListTerm(s8, s18);
    static internal readonly ListTerm s20 = new ListTerm(s7, s19);
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("the");
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("uncertain");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("tone");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s26 = new ListTerm(s25, s3);
    static internal readonly ListTerm s27 = new ListTerm(s24, s26);
    static internal readonly ListTerm s28 = new ListTerm(s23, s27);
    static internal readonly ListTerm s29 = new ListTerm(s22, s28);
    static internal readonly ListTerm s30 = new ListTerm(s21, s29);
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("more");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("positive");
    static internal readonly ListTerm s35 = new ListTerm(s34, s26);
    static internal readonly ListTerm s36 = new ListTerm(s33, s35);
    static internal readonly ListTerm s37 = new ListTerm(s32, s36);
    static internal readonly ListTerm s38 = new ListTerm(s9, s37);
    static internal readonly ListTerm s39 = new ListTerm(s7, s38);
    static internal readonly ListTerm s40 = new ListTerm(s31, s39);
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("sure");
    static internal readonly ListTerm s43 = new ListTerm(s42, s26);
    static internal readonly ListTerm s44 = new ListTerm(s9, s43);
    static internal readonly ListTerm s45 = new ListTerm(s41, s44);
    static internal readonly ListTerm s46 = new ListTerm(s7, s45);
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("know");
    static internal readonly ListTerm s48 = new ListTerm(s47, s26);
    static internal readonly ListTerm s49 = new ListTerm(s9, s48);
    static internal readonly ListTerm s50 = new ListTerm(s7, s49);
    static internal readonly ListTerm s51 = new ListTerm(s8, s50);
    static internal readonly ListTerm s52 = new ListTerm(s51, s3);
    static internal readonly ListTerm s53 = new ListTerm(s46, s52);
    static internal readonly ListTerm s54 = new ListTerm(s40, s53);
    static internal readonly ListTerm s55 = new ListTerm(s30, s54);
    static internal readonly ListTerm s56 = new ListTerm(s20, s55);
    static internal readonly ListTerm s57 = new ListTerm(s2, s56);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s57.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_9 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("name");
    static internal readonly IntegerTerm s2 = new IntegerTerm(15);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("interested");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("names");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s12, s16);
    static internal readonly ListTerm s18 = new ListTerm(s11, s17);
    static internal readonly ListTerm s19 = new ListTerm(s10, s18);
    static internal readonly ListTerm s20 = new ListTerm(s9, s19);
    static internal readonly ListTerm s21 = new ListTerm(s8, s20);
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("told");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("before");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("care");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("about");
    static internal readonly ListTerm s30 = new ListTerm(s29, s16);
    static internal readonly ListTerm s31 = new ListTerm(s28, s30);
    static internal readonly ListTerm s32 = new ListTerm(s10, s31);
    static internal readonly ListTerm s33 = new ListTerm(s27, s32);
    static internal readonly ListTerm s34 = new ListTerm(s8, s33);
    static internal readonly ListTerm s35 = new ListTerm(s26, s34);
    static internal readonly ListTerm s36 = new ListTerm(s25, s35);
    static internal readonly ListTerm s37 = new ListTerm(s24, s36);
    static internal readonly ListTerm s38 = new ListTerm(s23, s37);
    static internal readonly ListTerm s39 = new ListTerm(s22, s38);
    static internal readonly ListTerm s40 = new ListTerm(s8, s39);
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("please");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("continue");
    static internal readonly ListTerm s43 = new ListTerm(s42, s15);
    static internal readonly ListTerm s44 = new ListTerm(s41, s43);
    static internal readonly ListTerm s45 = new ListTerm(s44, s3);
    static internal readonly ListTerm s46 = new ListTerm(s40, s45);
    static internal readonly ListTerm s47 = new ListTerm(s21, s46);
    static internal readonly ListTerm s48 = new ListTerm(s7, s47);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s48.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_10 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("xfremd");
    static internal readonly IntegerTerm s2 = new IntegerTerm(75);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("sorry");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("only");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("speak");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("English");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s16 = new ListTerm(s15, s3);
    static internal readonly ListTerm s17 = new ListTerm(s14, s16);
    static internal readonly ListTerm s18 = new ListTerm(s13, s17);
    static internal readonly ListTerm s19 = new ListTerm(s12, s18);
    static internal readonly ListTerm s20 = new ListTerm(s8, s19);
    static internal readonly ListTerm s21 = new ListTerm(s11, s20);
    static internal readonly ListTerm s22 = new ListTerm(s10, s21);
    static internal readonly ListTerm s23 = new ListTerm(s9, s22);
    static internal readonly ListTerm s24 = new ListTerm(s8, s23);
    static internal readonly ListTerm s25 = new ListTerm(s24, s3);
    static internal readonly ListTerm s26 = new ListTerm(s7, s25);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s26.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_11 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("hello");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("how");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol(".");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("Please");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("state");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("problem");
    static internal readonly ListTerm s15 = new ListTerm(s10, s3);
    static internal readonly ListTerm s16 = new ListTerm(s14, s15);
    static internal readonly ListTerm s17 = new ListTerm(s13, s16);
    static internal readonly ListTerm s18 = new ListTerm(s12, s17);
    static internal readonly ListTerm s19 = new ListTerm(s11, s18);
    static internal readonly ListTerm s20 = new ListTerm(s10, s19);
    static internal readonly ListTerm s21 = new ListTerm(s8, s20);
    static internal readonly ListTerm s22 = new ListTerm(s9, s21);
    static internal readonly ListTerm s23 = new ListTerm(s8, s22);
    static internal readonly ListTerm s24 = new ListTerm(s7, s23);
    static internal readonly ListTerm s25 = new ListTerm(s24, s3);
    static internal readonly ListTerm s26 = new ListTerm(s2, s25);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s26.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_12 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("computer");
    static internal readonly IntegerTerm s2 = new IntegerTerm(50);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("computers");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("worry");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly ListTerm s14 = new ListTerm(s11, s13);
    static internal readonly ListTerm s15 = new ListTerm(s10, s14);
    static internal readonly ListTerm s16 = new ListTerm(s9, s15);
    static internal readonly ListTerm s17 = new ListTerm(s8, s16);
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("mention");
    static internal readonly ListTerm s20 = new ListTerm(s9, s13);
    static internal readonly ListTerm s21 = new ListTerm(s19, s20);
    static internal readonly ListTerm s22 = new ListTerm(s11, s21);
    static internal readonly ListTerm s23 = new ListTerm(s8, s22);
    static internal readonly ListTerm s24 = new ListTerm(s18, s23);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("machines");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("with");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("problem");
    static internal readonly ListTerm s33 = new ListTerm(s32, s13);
    static internal readonly ListTerm s34 = new ListTerm(s31, s33);
    static internal readonly ListTerm s35 = new ListTerm(s30, s34);
    static internal readonly ListTerm s36 = new ListTerm(s8, s35);
    static internal readonly ListTerm s37 = new ListTerm(s29, s36);
    static internal readonly ListTerm s38 = new ListTerm(s28, s37);
    static internal readonly ListTerm s39 = new ListTerm(s27, s38);
    static internal readonly ListTerm s40 = new ListTerm(s26, s39);
    static internal readonly ListTerm s41 = new ListTerm(s11, s40);
    static internal readonly ListTerm s42 = new ListTerm(s8, s41);
    static internal readonly ListTerm s43 = new ListTerm(s25, s42);
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("help");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("people");
    static internal readonly ListTerm s48 = new ListTerm(s47, s13);
    static internal readonly ListTerm s49 = new ListTerm(s46, s48);
    static internal readonly ListTerm s50 = new ListTerm(s45, s49);
    static internal readonly ListTerm s51 = new ListTerm(s9, s50);
    static internal readonly ListTerm s52 = new ListTerm(s26, s51);
    static internal readonly ListTerm s53 = new ListTerm(s44, s52);
    static internal readonly ListTerm s54 = new ListTerm(s11, s53);
    static internal readonly ListTerm s55 = new ListTerm(s8, s54);
    static internal readonly SymbolTerm s56 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s57 = SymbolTerm.MakeSymbol("worries");
    static internal readonly ListTerm s58 = new ListTerm(s57, s14);
    static internal readonly ListTerm s59 = new ListTerm(s27, s58);
    static internal readonly ListTerm s60 = new ListTerm(s56, s59);
    static internal readonly ListTerm s61 = new ListTerm(s25, s60);
    static internal readonly ListTerm s62 = new ListTerm(s27, s13);
    static internal readonly ListTerm s63 = new ListTerm(s56, s62);
    static internal readonly ListTerm s64 = new ListTerm(s26, s63);
    static internal readonly ListTerm s65 = new ListTerm(s11, s64);
    static internal readonly ListTerm s66 = new ListTerm(s8, s65);
    static internal readonly ListTerm s67 = new ListTerm(s25, s66);
    static internal readonly ListTerm s68 = new ListTerm(s67, s3);
    static internal readonly ListTerm s69 = new ListTerm(s61, s68);
    static internal readonly ListTerm s70 = new ListTerm(s55, s69);
    static internal readonly ListTerm s71 = new ListTerm(s43, s70);
    static internal readonly ListTerm s72 = new ListTerm(s24, s71);
    static internal readonly ListTerm s73 = new ListTerm(s17, s72);
    static internal readonly ListTerm s74 = new ListTerm(s7, s73);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s74.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_13 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("are");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s11 = new ListTerm(s10, s3);
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("want");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("wish");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("tell");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("what");
    static internal readonly ListTerm s21 = new ListTerm(s20, s4);
    static internal readonly ListTerm s22 = new ListTerm(s21, s3);
    static internal readonly ListTerm s23 = new ListTerm(s19, s22);
    static internal readonly ListTerm s24 = new ListTerm(s23, s3);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("mean");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("if");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("were");
    static internal readonly IntegerTerm s29 = new IntegerTerm(2);
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("interested");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("whether");
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("or");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("not");
    static internal readonly ListTerm s38 = new ListTerm(s37, s11);
    static internal readonly ListTerm s39 = new ListTerm(s36, s38);
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("prefer");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("fantasies");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s45 = new ListTerm(s44, s3);
    static internal readonly ListTerm s46 = new ListTerm(s43, s45);
    static internal readonly ListTerm s47 = new ListTerm(s42, s46);
    static internal readonly ListTerm s48 = new ListTerm(s33, s47);
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("sometimes");
    static internal readonly SymbolTerm s50 = SymbolTerm.MakeSymbol("think");
    static internal readonly IntegerTerm s51 = new IntegerTerm(3);
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("did");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol("they");
    static internal readonly SymbolTerm s54 = SymbolTerm.MakeSymbol("might");
    static internal readonly SymbolTerm s55 = SymbolTerm.MakeSymbol("like");
    static internal readonly SymbolTerm s56 = SymbolTerm.MakeSymbol("possibly");
    static internal readonly IntegerTerm s57 = new IntegerTerm(4);
    static internal readonly SymbolTerm s58 = SymbolTerm.MakeSymbol("say");
    static internal readonly ListTerm s59 = new ListTerm(s35, s11);
    static internal readonly ListTerm s60 = new ListTerm(s58, s59);
    static internal readonly ListTerm s61 = new ListTerm(s7, s60);
    static internal readonly ListTerm s62 = new ListTerm(s8, s61);
    static internal readonly ListTerm s63 = new ListTerm(s31, s62);
    static internal readonly SymbolTerm s64 = SymbolTerm.MakeSymbol("understand");
    static internal readonly SymbolTerm s65 = SymbolTerm.MakeSymbol("that");
    static internal readonly ListTerm s66 = new ListTerm(s65, s45);
    static internal readonly ListTerm s67 = new ListTerm(s64, s66);
    static internal readonly ListTerm s68 = new ListTerm(s37, s67);
    static internal readonly ListTerm s69 = new ListTerm(s8, s68);
    static internal readonly ListTerm s70 = new ListTerm(s17, s69);
    static internal readonly ListTerm s71 = new ListTerm(s70, s3);
    static internal readonly ListTerm s72 = new ListTerm(s63, s71);
    static internal readonly ListTerm s73 = new ListTerm(s2, s72);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91, a92, a93, a94, a95, a96, a97, a98, a99, a100, a101, a102, a103, a104, a105, a106, a107;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s7.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s2.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s2, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a14 = ((ListTerm)a13).car;
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a14, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s8.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s8, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s7.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s7, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s9.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s9, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s7.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s7, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s1.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s1, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            a21 = ((ListTerm)a15).car;
            a22 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a21 = engine.makeVariable();
            a22 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(a21, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s12.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s12, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s7.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s7, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s13.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s13, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s14.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s14, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s15.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(s15, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            a27 = ((ListTerm)a22).car;
            a28 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a27 = engine.makeVariable();
            a28 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(a27, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s7.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s7, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s16.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s16, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s17.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s17, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s12.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s12, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s18.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s18, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s7.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            if ( !a18.Unify(((ListTerm)a33).cdr, engine.trail) )
                return engine.fail();
        } else if ( a33.IsVariable() ){
            if ( !a33.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s7.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(s7, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s1.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(s1, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            a34 = ((ListTerm)a28).car;
            if ( !s24.Unify(((ListTerm)a28).cdr, engine.trail) )
                return engine.fail();
        } else if ( a28.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(a34, s24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s20.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s20, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s12.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s12, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s25.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(s25, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s26.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a38 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s26, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            if ( !s27.Unify(((ListTerm)a38).car, engine.trail) )
                return engine.fail();
            a39 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(s27, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s7.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a40 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s7, a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s28.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a40).cdr, engine.trail) )
                return engine.fail();
        } else if ( a40.IsVariable() ){
            if ( !a40.Unify(new ListTerm(s28, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a41 = ((ListTerm)a5).car;
            a42 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a41 = engine.makeVariable();
            a42 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a41, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s29.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s29, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            a44 = ((ListTerm)a43).car;
            a45 = ((ListTerm)a43).cdr;
        } else if ( a43.IsVariable() ){
            a44 = engine.makeVariable();
            a45 = engine.makeVariable();
            if ( !a43.Unify(new ListTerm(a44, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            a46 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a46 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(engine.makeVariable(), a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s1.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s1, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s30.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a47).cdr, engine.trail) )
                return engine.fail();
        } else if ( a47.IsVariable() ){
            if ( !a47.Unify(new ListTerm(s30, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            if ( !s2.Unify(((ListTerm)a45).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(s2, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            a49 = ((ListTerm)a48).car;
            a50 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            a50 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(a49, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s31.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            a51 = ((ListTerm)a49).cdr;
        } else if ( a49.IsVariable() ){
            a51 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(s31, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            if ( !s1.Unify(((ListTerm)a51).car, engine.trail) )
                return engine.fail();
            a52 = ((ListTerm)a51).cdr;
        } else if ( a51.IsVariable() ){
            a52 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(s1, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s7.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            a53 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a53 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(s7, a53), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            if ( !s32.Unify(((ListTerm)a53).car, engine.trail) )
                return engine.fail();
            a54 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(s32, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s33.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a54).cdr;
        } else if ( a54.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(s33, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s34.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s34, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s17.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            a57 = ((ListTerm)a56).cdr;
        } else if ( a56.IsVariable() ){
            a57 = engine.makeVariable();
            if ( !a56.Unify(new ListTerm(s17, a57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s35.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a58 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a58 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s35, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !a12.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            if ( !s39.Unify(((ListTerm)a58).cdr, engine.trail) )
                return engine.fail();
        } else if ( a58.IsVariable() ){
            if ( !a58.Unify(new ListTerm(a12, s39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            a59 = ((ListTerm)a50).car;
            a60 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a59 = engine.makeVariable();
            a60 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(a59, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !s12.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            a61 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(s12, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s7.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s7, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s40.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s40, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s27.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            a64 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a64 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(s27, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !s17.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            a65 = ((ListTerm)a64).cdr;
        } else if ( a64.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a64.Unify(new ListTerm(s17, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s28.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a66 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s28, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s37.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a66).cdr, engine.trail) )
                return engine.fail();
        } else if ( a66.IsVariable() ){
            if ( !a66.Unify(new ListTerm(s37, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            a67 = ((ListTerm)a60).car;
            a68 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a67 = engine.makeVariable();
            a68 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(a67, a68), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            if ( !s41.Unify(((ListTerm)a67).car, engine.trail) )
                return engine.fail();
            a69 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a69 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(s41, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            if ( !s17.Unify(((ListTerm)a69).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(s17, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s35.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            a71 = ((ListTerm)a70).cdr;
        } else if ( a70.IsVariable() ){
            a71 = engine.makeVariable();
            if ( !a70.Unify(new ListTerm(s35, a71), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !a12.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            if ( !s48.Unify(((ListTerm)a71).cdr, engine.trail) )
                return engine.fail();
        } else if ( a71.IsVariable() ){
            if ( !a71.Unify(new ListTerm(a12, s48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            a72 = ((ListTerm)a68).car;
            if ( !s24.Unify(((ListTerm)a68).cdr, engine.trail) )
                return engine.fail();
        } else if ( a68.IsVariable() ){
            a72 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(a72, s24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a72.IsList() ){
            if ( !s8.Unify(((ListTerm)a72).car, engine.trail) )
                return engine.fail();
            a73 = ((ListTerm)a72).cdr;
        } else if ( a72.IsVariable() ){
            a73 = engine.makeVariable();
            if ( !a72.Unify(new ListTerm(s8, a73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a73.IsList() ){
            if ( !s7.Unify(((ListTerm)a73).car, engine.trail) )
                return engine.fail();
            a74 = ((ListTerm)a73).cdr;
        } else if ( a73.IsVariable() ){
            a74 = engine.makeVariable();
            if ( !a73.Unify(new ListTerm(s7, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s49.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            a75 = ((ListTerm)a74).cdr;
        } else if ( a74.IsVariable() ){
            a75 = engine.makeVariable();
            if ( !a74.Unify(new ListTerm(s49, a75), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            if ( !s50.Unify(((ListTerm)a75).car, engine.trail) )
                return engine.fail();
            a76 = ((ListTerm)a75).cdr;
        } else if ( a75.IsVariable() ){
            a76 = engine.makeVariable();
            if ( !a75.Unify(new ListTerm(s50, a76), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a76.IsList() ){
            if ( !s17.Unify(((ListTerm)a76).car, engine.trail) )
                return engine.fail();
            a77 = ((ListTerm)a76).cdr;
        } else if ( a76.IsVariable() ){
            a77 = engine.makeVariable();
            if ( !a76.Unify(new ListTerm(s17, a77), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a77.IsList() ){
            if ( !s35.Unify(((ListTerm)a77).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a77).cdr, engine.trail) )
                return engine.fail();
        } else if ( a77.IsVariable() ){
            if ( !a77.Unify(new ListTerm(s35, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            a78 = ((ListTerm)a42).car;
            a79 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a78 = engine.makeVariable();
            a79 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(a78, a79), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a78.IsList() ){
            if ( !s51.Unify(((ListTerm)a78).car, engine.trail) )
                return engine.fail();
            a80 = ((ListTerm)a78).cdr;
        } else if ( a78.IsVariable() ){
            a80 = engine.makeVariable();
            if ( !a78.Unify(new ListTerm(s51, a80), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a80.IsList() ){
            a81 = ((ListTerm)a80).car;
            a82 = ((ListTerm)a80).cdr;
        } else if ( a80.IsVariable() ){
            a81 = engine.makeVariable();
            a82 = engine.makeVariable();
            if ( !a80.Unify(new ListTerm(a81, a82), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a81.IsList() ){
            a83 = ((ListTerm)a81).cdr;
        } else if ( a81.IsVariable() ){
            a83 = engine.makeVariable();
            if ( !a81.Unify(new ListTerm(engine.makeVariable(), a83), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a83.IsList() ){
            if ( !s1.Unify(((ListTerm)a83).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a83).cdr, engine.trail) )
                return engine.fail();
        } else if ( a83.IsVariable() ){
            if ( !a83.Unify(new ListTerm(s1, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a82.IsList() ){
            if ( !s2.Unify(((ListTerm)a82).car, engine.trail) )
                return engine.fail();
            a84 = ((ListTerm)a82).cdr;
        } else if ( a82.IsVariable() ){
            a84 = engine.makeVariable();
            if ( !a82.Unify(new ListTerm(s2, a84), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a84.IsList() ){
            a85 = ((ListTerm)a84).car;
            a86 = ((ListTerm)a84).cdr;
        } else if ( a84.IsVariable() ){
            a85 = engine.makeVariable();
            a86 = engine.makeVariable();
            if ( !a84.Unify(new ListTerm(a85, a86), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a85.IsList() ){
            if ( !s52.Unify(((ListTerm)a85).car, engine.trail) )
                return engine.fail();
            a87 = ((ListTerm)a85).cdr;
        } else if ( a85.IsVariable() ){
            a87 = engine.makeVariable();
            if ( !a85.Unify(new ListTerm(s52, a87), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a87.IsList() ){
            if ( !s7.Unify(((ListTerm)a87).car, engine.trail) )
                return engine.fail();
            a88 = ((ListTerm)a87).cdr;
        } else if ( a87.IsVariable() ){
            a88 = engine.makeVariable();
            if ( !a87.Unify(new ListTerm(s7, a88), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a88.IsList() ){
            if ( !s50.Unify(((ListTerm)a88).car, engine.trail) )
                return engine.fail();
            a89 = ((ListTerm)a88).cdr;
        } else if ( a88.IsVariable() ){
            a89 = engine.makeVariable();
            if ( !a88.Unify(new ListTerm(s50, a89), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a89.IsList() ){
            if ( !s53.Unify(((ListTerm)a89).car, engine.trail) )
                return engine.fail();
            a90 = ((ListTerm)a89).cdr;
        } else if ( a89.IsVariable() ){
            a90 = engine.makeVariable();
            if ( !a89.Unify(new ListTerm(s53, a90), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a90.IsList() ){
            if ( !s54.Unify(((ListTerm)a90).car, engine.trail) )
                return engine.fail();
            a91 = ((ListTerm)a90).cdr;
        } else if ( a90.IsVariable() ){
            a91 = engine.makeVariable();
            if ( !a90.Unify(new ListTerm(s54, a91), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a91.IsList() ){
            if ( !s37.Unify(((ListTerm)a91).car, engine.trail) )
                return engine.fail();
            if ( !a26.Unify(((ListTerm)a91).cdr, engine.trail) )
                return engine.fail();
        } else if ( a91.IsVariable() ){
            if ( !a91.Unify(new ListTerm(s37, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s15.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(s15, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a86.IsList() ){
            a92 = ((ListTerm)a86).car;
            a93 = ((ListTerm)a86).cdr;
        } else if ( a86.IsVariable() ){
            a92 = engine.makeVariable();
            a93 = engine.makeVariable();
            if ( !a86.Unify(new ListTerm(a92, a93), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a92.IsList() ){
            if ( !s12.Unify(((ListTerm)a92).car, engine.trail) )
                return engine.fail();
            a94 = ((ListTerm)a92).cdr;
        } else if ( a92.IsVariable() ){
            a94 = engine.makeVariable();
            if ( !a92.Unify(new ListTerm(s12, a94), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a94.IsList() ){
            if ( !s7.Unify(((ListTerm)a94).car, engine.trail) )
                return engine.fail();
            a95 = ((ListTerm)a94).cdr;
        } else if ( a94.IsVariable() ){
            a95 = engine.makeVariable();
            if ( !a94.Unify(new ListTerm(s7, a95), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a95.IsList() ){
            if ( !s55.Unify(((ListTerm)a95).car, engine.trail) )
                return engine.fail();
            a96 = ((ListTerm)a95).cdr;
        } else if ( a95.IsVariable() ){
            a96 = engine.makeVariable();
            if ( !a95.Unify(new ListTerm(s55, a96), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a96.IsList() ){
            if ( !s25.Unify(((ListTerm)a96).car, engine.trail) )
                return engine.fail();
            a97 = ((ListTerm)a96).cdr;
        } else if ( a96.IsVariable() ){
            a97 = engine.makeVariable();
            if ( !a96.Unify(new ListTerm(s25, a97), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a97.IsList() ){
            if ( !s27.Unify(((ListTerm)a97).car, engine.trail) )
                return engine.fail();
            a98 = ((ListTerm)a97).cdr;
        } else if ( a97.IsVariable() ){
            a98 = engine.makeVariable();
            if ( !a97.Unify(new ListTerm(s27, a98), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a98.IsList() ){
            if ( !s53.Unify(((ListTerm)a98).car, engine.trail) )
                return engine.fail();
            if ( !a65.Unify(((ListTerm)a98).cdr, engine.trail) )
                return engine.fail();
        } else if ( a98.IsVariable() ){
            if ( !a98.Unify(new ListTerm(s53, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s28.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            if ( !a66.Unify(((ListTerm)a65).cdr, engine.trail) )
                return engine.fail();
        } else if ( a65.IsVariable() ){
            if ( !a65.Unify(new ListTerm(s28, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s37.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a66).cdr, engine.trail) )
                return engine.fail();
        } else if ( a66.IsVariable() ){
            if ( !a66.Unify(new ListTerm(s37, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a93.IsList() ){
            a99 = ((ListTerm)a93).car;
            a100 = ((ListTerm)a93).cdr;
        } else if ( a93.IsVariable() ){
            a99 = engine.makeVariable();
            a100 = engine.makeVariable();
            if ( !a93.Unify(new ListTerm(a99, a100), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a99.IsList() ){
            if ( !s20.Unify(((ListTerm)a99).car, engine.trail) )
                return engine.fail();
            if ( !a97.Unify(((ListTerm)a99).cdr, engine.trail) )
                return engine.fail();
        } else if ( a99.IsVariable() ){
            if ( !a99.Unify(new ListTerm(s20, a97), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a97.IsList() ){
            if ( !s27.Unify(((ListTerm)a97).car, engine.trail) )
                return engine.fail();
            if ( !a98.Unify(((ListTerm)a97).cdr, engine.trail) )
                return engine.fail();
        } else if ( a97.IsVariable() ){
            if ( !a97.Unify(new ListTerm(s27, a98), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a98.IsList() ){
            if ( !s53.Unify(((ListTerm)a98).car, engine.trail) )
                return engine.fail();
            if ( !a65.Unify(((ListTerm)a98).cdr, engine.trail) )
                return engine.fail();
        } else if ( a98.IsVariable() ){
            if ( !a98.Unify(new ListTerm(s53, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s28.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            if ( !a66.Unify(((ListTerm)a65).cdr, engine.trail) )
                return engine.fail();
        } else if ( a65.IsVariable() ){
            if ( !a65.Unify(new ListTerm(s28, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s37.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            if ( !a20.Unify(((ListTerm)a66).cdr, engine.trail) )
                return engine.fail();
        } else if ( a66.IsVariable() ){
            if ( !a66.Unify(new ListTerm(s37, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !a12.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            if ( !s11.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            if ( !a20.Unify(new ListTerm(a12, s11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a100.IsList() ){
            a101 = ((ListTerm)a100).car;
            if ( !s3.Unify(((ListTerm)a100).cdr, engine.trail) )
                return engine.fail();
        } else if ( a100.IsVariable() ){
            a101 = engine.makeVariable();
            if ( !a100.Unify(new ListTerm(a101, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a101.IsList() ){
            if ( !s56.Unify(((ListTerm)a101).car, engine.trail) )
                return engine.fail();
            a102 = ((ListTerm)a101).cdr;
        } else if ( a101.IsVariable() ){
            a102 = engine.makeVariable();
            if ( !a101.Unify(new ListTerm(s56, a102), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a102.IsList() ){
            if ( !s53.Unify(((ListTerm)a102).car, engine.trail) )
                return engine.fail();
            a103 = ((ListTerm)a102).cdr;
        } else if ( a102.IsVariable() ){
            a103 = engine.makeVariable();
            if ( !a102.Unify(new ListTerm(s53, a103), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a103.IsList() ){
            if ( !s1.Unify(((ListTerm)a103).car, engine.trail) )
                return engine.fail();
            a104 = ((ListTerm)a103).cdr;
        } else if ( a103.IsVariable() ){
            a104 = engine.makeVariable();
            if ( !a103.Unify(new ListTerm(s1, a104), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a104.IsList() ){
            if ( !a12.Unify(((ListTerm)a104).car, engine.trail) )
                return engine.fail();
            if ( !s45.Unify(((ListTerm)a104).cdr, engine.trail) )
                return engine.fail();
        } else if ( a104.IsVariable() ){
            if ( !a104.Unify(new ListTerm(a12, s45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a79.IsList() ){
            a105 = ((ListTerm)a79).car;
            if ( !s3.Unify(((ListTerm)a79).cdr, engine.trail) )
                return engine.fail();
        } else if ( a79.IsVariable() ){
            a105 = engine.makeVariable();
            if ( !a79.Unify(new ListTerm(a105, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a105.IsList() ){
            if ( !s57.Unify(((ListTerm)a105).car, engine.trail) )
                return engine.fail();
            a106 = ((ListTerm)a105).cdr;
        } else if ( a105.IsVariable() ){
            a106 = engine.makeVariable();
            if ( !a105.Unify(new ListTerm(s57, a106), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a106.IsList() ){
            a107 = ((ListTerm)a106).car;
            if ( !s73.Unify(((ListTerm)a106).cdr, engine.trail) )
                return engine.fail();
        } else if ( a106.IsVariable() ){
            a107 = engine.makeVariable();
            if ( !a106.Unify(new ListTerm(a107, s73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a107.IsList() ){
            if ( !s3.Unify(((ListTerm)a107).cdr, engine.trail) )
                return engine.fail();
        } else if ( a107.IsVariable() ){
            if ( !a107.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_14 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("my");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("concerned");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("over");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("own");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("worried");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("someone");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("elses");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol(",");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
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
        if ( a6.IsList() ){
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s1.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a9 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s1, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a10 = ((ListTerm)a9).car;
            if ( !s3.Unify(((ListTerm)a9).cdr, engine.trail) )
                return engine.fail();
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a10, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s2.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s2, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            a13 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            a13 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s7.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s7, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s8.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s8, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s9.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s9, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s10.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s10, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s11.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s11, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s1.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a10.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a20 = ((ListTerm)a13).car;
            a21 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a20 = engine.makeVariable();
            a21 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a20, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s14.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s14, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s15.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(s15, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s16.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s16, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s17.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a24).cdr, engine.trail) )
                return engine.fail();
        } else if ( a24.IsVariable() ){
            if ( !a24.Unify(new ListTerm(s17, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a10.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            a25 = ((ListTerm)a21).car;
            a26 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a25 = engine.makeVariable();
            a26 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(a25, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s8.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s8, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s9.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s9, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s18.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s18, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s15.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s15, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s19.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s19, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s20.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a31).cdr, engine.trail) )
                return engine.fail();
        } else if ( a31.IsVariable() ){
            if ( !a31.Unify(new ListTerm(s20, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a10.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            a32 = ((ListTerm)a26).car;
            if ( !s3.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(a32, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s21.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s21, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s22.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            if ( !a18.Unify(((ListTerm)a33).cdr, engine.trail) )
                return engine.fail();
        } else if ( a33.IsVariable() ){
            if ( !a33.Unify(new ListTerm(s22, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s1.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a10.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_15 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("was");
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly IntegerTerm s8 = new IntegerTerm(0);
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("if");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("were");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("mean");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("equal");
    static internal readonly ListTerm s20 = new ListTerm(s8, s3);
    static internal readonly ListTerm s21 = new ListTerm(s9, s20);
    static internal readonly ListTerm s22 = new ListTerm(s21, s3);
    static internal readonly ListTerm s23 = new ListTerm(s19, s22);
    static internal readonly ListTerm s24 = new ListTerm(s23, s3);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("suggest");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("to");
    static internal readonly ListTerm s28 = new ListTerm(s7, s13);
    static internal readonly ListTerm s29 = new ListTerm(s27, s28);
    static internal readonly ListTerm s30 = new ListTerm(s26, s29);
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("really");
    static internal readonly ListTerm s32 = new ListTerm(s31, s13);
    static internal readonly ListTerm s33 = new ListTerm(s7, s32);
    static internal readonly ListTerm s34 = new ListTerm(s11, s33);
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("tell");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("just");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("now");
    static internal readonly ListTerm s40 = new ListTerm(s39, s13);
    static internal readonly ListTerm s41 = new ListTerm(s38, s40);
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("already");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("knew");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s47 = new ListTerm(s46, s3);
    static internal readonly IntegerTerm s48 = new IntegerTerm(3);
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s50 = SymbolTerm.MakeSymbol("like");
    static internal readonly SymbolTerm s51 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("suggests");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol("that");
    static internal readonly ListTerm s54 = new ListTerm(s15, s13);
    static internal readonly ListTerm s55 = new ListTerm(s7, s54);
    static internal readonly ListTerm s56 = new ListTerm(s14, s55);
    static internal readonly ListTerm s57 = new ListTerm(s9, s56);
    static internal readonly SymbolTerm s58 = SymbolTerm.MakeSymbol("had");
    static internal readonly SymbolTerm s59 = SymbolTerm.MakeSymbol("been");
    static internal readonly IntegerTerm s60 = new IntegerTerm(4);
    static internal readonly SymbolTerm s61 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly ListTerm s62 = new ListTerm(s61, s3);
    static internal readonly ListTerm s63 = new ListTerm(s62, s3);
    static internal readonly ListTerm s64 = new ListTerm(s8, s63);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91, a92;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s7.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s8.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s8, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a14 = ((ListTerm)a13).car;
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a14, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s9.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s9, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s10.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s10, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s7.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s11.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s11, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            a20 = ((ListTerm)a15).car;
            a21 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a20 = engine.makeVariable();
            a21 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(a20, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s14.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s14, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s7.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(s7, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s15.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            if ( !a17.Unify(((ListTerm)a23).cdr, engine.trail) )
                return engine.fail();
        } else if ( a23.IsVariable() ){
            if ( !a23.Unify(new ListTerm(s15, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s7.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            if ( !a18.Unify(((ListTerm)a17).cdr, engine.trail) )
                return engine.fail();
        } else if ( a17.IsVariable() ){
            if ( !a17.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s11.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(s11, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            a24 = ((ListTerm)a21).car;
            a25 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a24 = engine.makeVariable();
            a25 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(a24, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s11.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s11, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s7.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(s7, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            a27 = ((ListTerm)a25).car;
            a28 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a27 = engine.makeVariable();
            a28 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(a27, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s9.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s9, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s16.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s16, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s17.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s17, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s18.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            if ( !a16.Unify(((ListTerm)a31).cdr, engine.trail) )
                return engine.fail();
        } else if ( a31.IsVariable() ){
            if ( !a31.Unify(new ListTerm(s18, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s10.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            if ( !a17.Unify(((ListTerm)a16).cdr, engine.trail) )
                return engine.fail();
        } else if ( a16.IsVariable() ){
            if ( !a16.Unify(new ListTerm(s10, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s7.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            if ( !a18.Unify(((ListTerm)a17).cdr, engine.trail) )
                return engine.fail();
        } else if ( a17.IsVariable() ){
            if ( !a17.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s11.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(s11, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            a32 = ((ListTerm)a28).car;
            if ( !s24.Unify(((ListTerm)a28).cdr, engine.trail) )
                return engine.fail();
        } else if ( a28.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(a32, s24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s9.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s9, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s25.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s25, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !a12.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            if ( !s30.Unify(((ListTerm)a34).cdr, engine.trail) )
                return engine.fail();
        } else if ( a34.IsVariable() ){
            if ( !a34.Unify(new ListTerm(a12, s30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a35 = ((ListTerm)a5).car;
            a36 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a35 = engine.makeVariable();
            a36 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a35, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s2.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s2, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            a38 = ((ListTerm)a37).car;
            a39 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            a39 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(a38, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            a40 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(engine.makeVariable(), a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s7.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            a41 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a41 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(s7, a41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s1.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a41).cdr, engine.trail) )
                return engine.fail();
        } else if ( a41.IsVariable() ){
            if ( !a41.Unify(new ListTerm(s1, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s8.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a42 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s8, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s34.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s34, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            a44 = ((ListTerm)a43).car;
            a45 = ((ListTerm)a43).cdr;
        } else if ( a43.IsVariable() ){
            a44 = engine.makeVariable();
            a45 = engine.makeVariable();
            if ( !a43.Unify(new ListTerm(a44, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s35.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            a46 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a46 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(s35, a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s14.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s14, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s7.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(s7, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s36.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s36, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s37.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            a50 = ((ListTerm)a49).cdr;
        } else if ( a49.IsVariable() ){
            a50 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(s37, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s7.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            a51 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a51 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(s7, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            if ( !s11.Unify(((ListTerm)a51).car, engine.trail) )
                return engine.fail();
            a52 = ((ListTerm)a51).cdr;
        } else if ( a51.IsVariable() ){
            a52 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(s11, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !a12.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            if ( !s41.Unify(((ListTerm)a52).cdr, engine.trail) )
                return engine.fail();
        } else if ( a52.IsVariable() ){
            if ( !a52.Unify(new ListTerm(a12, s41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            a53 = ((ListTerm)a45).car;
            if ( !s3.Unify(((ListTerm)a45).cdr, engine.trail) )
                return engine.fail();
        } else if ( a45.IsVariable() ){
            a53 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(a53, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            if ( !s42.Unify(((ListTerm)a53).car, engine.trail) )
                return engine.fail();
            a54 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(s42, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s43.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a54).cdr;
        } else if ( a54.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(s43, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s44.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s44, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s45.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            a57 = ((ListTerm)a56).cdr;
        } else if ( a56.IsVariable() ){
            a57 = engine.makeVariable();
            if ( !a56.Unify(new ListTerm(s45, a57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s7.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a58 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a58 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s7, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !s11.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(s11, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !a12.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            if ( !s47.Unify(((ListTerm)a59).cdr, engine.trail) )
                return engine.fail();
        } else if ( a59.IsVariable() ){
            if ( !a59.Unify(new ListTerm(a12, s47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            a60 = ((ListTerm)a36).car;
            a61 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a60 = engine.makeVariable();
            a61 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(a60, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            if ( !s48.Unify(((ListTerm)a60).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(s48, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            a63 = ((ListTerm)a62).car;
            a64 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            a64 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(a63, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            a65 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(engine.makeVariable(), a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s1.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a66 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s1, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s49.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a66).cdr, engine.trail) )
                return engine.fail();
        } else if ( a66.IsVariable() ){
            if ( !a66.Unify(new ListTerm(s49, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !s8.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            a67 = ((ListTerm)a64).cdr;
        } else if ( a64.IsVariable() ){
            a67 = engine.makeVariable();
            if ( !a64.Unify(new ListTerm(s8, a67), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            a68 = ((ListTerm)a67).car;
            a69 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a68 = engine.makeVariable();
            a69 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(a68, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            if ( !s16.Unify(((ListTerm)a68).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a68).cdr;
        } else if ( a68.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(s16, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s7.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            a71 = ((ListTerm)a70).cdr;
        } else if ( a70.IsVariable() ){
            a71 = engine.makeVariable();
            if ( !a70.Unify(new ListTerm(s7, a71), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !s50.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            a72 = ((ListTerm)a71).cdr;
        } else if ( a71.IsVariable() ){
            a72 = engine.makeVariable();
            if ( !a71.Unify(new ListTerm(s50, a72), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a72.IsList() ){
            if ( !s27.Unify(((ListTerm)a72).car, engine.trail) )
                return engine.fail();
            a73 = ((ListTerm)a72).cdr;
        } else if ( a72.IsVariable() ){
            a73 = engine.makeVariable();
            if ( !a72.Unify(new ListTerm(s27, a73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a73.IsList() ){
            if ( !s51.Unify(((ListTerm)a73).car, engine.trail) )
                return engine.fail();
            a74 = ((ListTerm)a73).cdr;
        } else if ( a73.IsVariable() ){
            a74 = engine.makeVariable();
            if ( !a73.Unify(new ListTerm(s51, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s43.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            a75 = ((ListTerm)a74).cdr;
        } else if ( a74.IsVariable() ){
            a75 = engine.makeVariable();
            if ( !a74.Unify(new ListTerm(s43, a75), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            if ( !s1.Unify(((ListTerm)a75).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a75).cdr, engine.trail) )
                return engine.fail();
        } else if ( a75.IsVariable() ){
            if ( !a75.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            a76 = ((ListTerm)a69).car;
            a77 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a76 = engine.makeVariable();
            a77 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(a76, a77), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a76.IsList() ){
            if ( !s9.Unify(((ListTerm)a76).car, engine.trail) )
                return engine.fail();
            a78 = ((ListTerm)a76).cdr;
        } else if ( a76.IsVariable() ){
            a78 = engine.makeVariable();
            if ( !a76.Unify(new ListTerm(s9, a78), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a78.IsList() ){
            if ( !s52.Unify(((ListTerm)a78).car, engine.trail) )
                return engine.fail();
            a79 = ((ListTerm)a78).cdr;
        } else if ( a78.IsVariable() ){
            a79 = engine.makeVariable();
            if ( !a78.Unify(new ListTerm(s52, a79), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a79.IsList() ){
            if ( !s53.Unify(((ListTerm)a79).car, engine.trail) )
                return engine.fail();
            if ( !a74.Unify(((ListTerm)a79).cdr, engine.trail) )
                return engine.fail();
        } else if ( a79.IsVariable() ){
            if ( !a79.Unify(new ListTerm(s53, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s43.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            if ( !a75.Unify(((ListTerm)a74).cdr, engine.trail) )
                return engine.fail();
        } else if ( a74.IsVariable() ){
            if ( !a74.Unify(new ListTerm(s43, a75), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            if ( !s1.Unify(((ListTerm)a75).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a75).cdr, engine.trail) )
                return engine.fail();
        } else if ( a75.IsVariable() ){
            if ( !a75.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a77.IsList() ){
            if ( !s57.Unify(((ListTerm)a77).car, engine.trail) )
                return engine.fail();
            a80 = ((ListTerm)a77).cdr;
        } else if ( a77.IsVariable() ){
            a80 = engine.makeVariable();
            if ( !a77.Unify(new ListTerm(s57, a80), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a80.IsList() ){
            a81 = ((ListTerm)a80).car;
            a82 = ((ListTerm)a80).cdr;
        } else if ( a80.IsVariable() ){
            a81 = engine.makeVariable();
            a82 = engine.makeVariable();
            if ( !a80.Unify(new ListTerm(a81, a82), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a81.IsList() ){
            if ( !s42.Unify(((ListTerm)a81).car, engine.trail) )
                return engine.fail();
            a83 = ((ListTerm)a81).cdr;
        } else if ( a81.IsVariable() ){
            a83 = engine.makeVariable();
            if ( !a81.Unify(new ListTerm(s42, a83), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a83.IsList() ){
            if ( !s43.Unify(((ListTerm)a83).car, engine.trail) )
                return engine.fail();
            a84 = ((ListTerm)a83).cdr;
        } else if ( a83.IsVariable() ){
            a84 = engine.makeVariable();
            if ( !a83.Unify(new ListTerm(s43, a84), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a84.IsList() ){
            if ( !s1.Unify(((ListTerm)a84).car, engine.trail) )
                return engine.fail();
            if ( !a59.Unify(((ListTerm)a84).cdr, engine.trail) )
                return engine.fail();
        } else if ( a84.IsVariable() ){
            if ( !a84.Unify(new ListTerm(s1, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !a12.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            if ( !s47.Unify(((ListTerm)a59).cdr, engine.trail) )
                return engine.fail();
        } else if ( a59.IsVariable() ){
            if ( !a59.Unify(new ListTerm(a12, s47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a82.IsList() ){
            a85 = ((ListTerm)a82).car;
            if ( !s3.Unify(((ListTerm)a82).cdr, engine.trail) )
                return engine.fail();
        } else if ( a82.IsVariable() ){
            a85 = engine.makeVariable();
            if ( !a82.Unify(new ListTerm(a85, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a85.IsList() ){
            if ( !s9.Unify(((ListTerm)a85).car, engine.trail) )
                return engine.fail();
            a86 = ((ListTerm)a85).cdr;
        } else if ( a85.IsVariable() ){
            a86 = engine.makeVariable();
            if ( !a85.Unify(new ListTerm(s9, a86), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a86.IsList() ){
            if ( !s10.Unify(((ListTerm)a86).car, engine.trail) )
                return engine.fail();
            a87 = ((ListTerm)a86).cdr;
        } else if ( a86.IsVariable() ){
            a87 = engine.makeVariable();
            if ( !a86.Unify(new ListTerm(s10, a87), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a87.IsList() ){
            if ( !s43.Unify(((ListTerm)a87).car, engine.trail) )
                return engine.fail();
            a88 = ((ListTerm)a87).cdr;
        } else if ( a87.IsVariable() ){
            a88 = engine.makeVariable();
            if ( !a87.Unify(new ListTerm(s43, a88), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a88.IsList() ){
            if ( !s58.Unify(((ListTerm)a88).car, engine.trail) )
                return engine.fail();
            a89 = ((ListTerm)a88).cdr;
        } else if ( a88.IsVariable() ){
            a89 = engine.makeVariable();
            if ( !a88.Unify(new ListTerm(s58, a89), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a89.IsList() ){
            if ( !s59.Unify(((ListTerm)a89).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a89).cdr, engine.trail) )
                return engine.fail();
        } else if ( a89.IsVariable() ){
            if ( !a89.Unify(new ListTerm(s59, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            a90 = ((ListTerm)a61).car;
            if ( !s3.Unify(((ListTerm)a61).cdr, engine.trail) )
                return engine.fail();
        } else if ( a61.IsVariable() ){
            a90 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(a90, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a90.IsList() ){
            if ( !s60.Unify(((ListTerm)a90).car, engine.trail) )
                return engine.fail();
            a91 = ((ListTerm)a90).cdr;
        } else if ( a90.IsVariable() ){
            a91 = engine.makeVariable();
            if ( !a90.Unify(new ListTerm(s60, a91), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a91.IsList() ){
            a92 = ((ListTerm)a91).car;
            if ( !s64.Unify(((ListTerm)a91).cdr, engine.trail) )
                return engine.fail();
        } else if ( a91.IsVariable() ){
            a92 = engine.makeVariable();
            if ( !a91.Unify(new ListTerm(a92, s64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a92.IsList() ){
            if ( !s3.Unify(((ListTerm)a92).cdr, engine.trail) )
                return engine.fail();
        } else if ( a92.IsVariable() ){
            if ( !a92.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_16 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("im");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("i");
    static internal readonly ListTerm s9 = new ListTerm(s8, s4);
    static internal readonly ListTerm s10 = new ListTerm(s9, s3);
    static internal readonly ListTerm s11 = new ListTerm(s7, s10);
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s2, s12);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s13.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s1.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a8 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s1, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s3.Unify(((ListTerm)a8).cdr, engine.trail) )
                return engine.fail();
        } else if ( a8.IsVariable() ){
            if ( !a8.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_17 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("youre");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("you");
    static internal readonly ListTerm s9 = new ListTerm(s8, s4);
    static internal readonly ListTerm s10 = new ListTerm(s9, s3);
    static internal readonly ListTerm s11 = new ListTerm(s7, s10);
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s2, s12);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s13.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s1.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a8 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s1, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s3.Unify(((ListTerm)a8).cdr, engine.trail) )
                return engine.fail();
        } else if ( a8.IsVariable() ){
            if ( !a8.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_18 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("you");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("cant");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("how");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("know");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s14 = new ListTerm(s13, s3);
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("tried");
    static internal readonly ListTerm s17 = new ListTerm(s16, s14);
    static internal readonly ListTerm s18 = new ListTerm(s1, s17);
    static internal readonly ListTerm s19 = new ListTerm(s15, s18);
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("could");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("now");
    static internal readonly ListTerm s23 = new ListTerm(s22, s14);
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("want");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("able");
    static internal readonly IntegerTerm s29 = new IntegerTerm(2);
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("dont");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("trouble");
    static internal readonly ListTerm s35 = new ListTerm(s1, s14);
    static internal readonly ListTerm s36 = new ListTerm(s34, s35);
    static internal readonly ListTerm s37 = new ListTerm(s33, s36);
    static internal readonly ListTerm s38 = new ListTerm(s32, s37);
    static internal readonly ListTerm s39 = new ListTerm(s38, s3);
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("wish");
    static internal readonly IntegerTerm s41 = new IntegerTerm(3);
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("feel");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("tell");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("more");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("such");
    static internal readonly SymbolTerm s48 = SymbolTerm.MakeSymbol("feelings");
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s50 = new ListTerm(s49, s3);
    static internal readonly ListTerm s51 = new ListTerm(s48, s50);
    static internal readonly ListTerm s52 = new ListTerm(s47, s51);
    static internal readonly ListTerm s53 = new ListTerm(s46, s52);
    static internal readonly ListTerm s54 = new ListTerm(s45, s53);
    static internal readonly ListTerm s55 = new ListTerm(s44, s54);
    static internal readonly ListTerm s56 = new ListTerm(s43, s55);
    static internal readonly SymbolTerm s57 = SymbolTerm.MakeSymbol("often");
    static internal readonly SymbolTerm s58 = SymbolTerm.MakeSymbol("enjoy");
    static internal readonly SymbolTerm s59 = SymbolTerm.MakeSymbol("feeling");
    static internal readonly SymbolTerm s60 = SymbolTerm.MakeSymbol("of");
    static internal readonly SymbolTerm s61 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s62 = SymbolTerm.MakeSymbol("remind");
    static internal readonly ListTerm s63 = new ListTerm(s62, s35);
    static internal readonly IntegerTerm s64 = new IntegerTerm(4);
    static internal readonly SymbolTerm s65 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s66 = SymbolTerm.MakeSymbol("was");
    static internal readonly ListTerm s67 = new ListTerm(s29, s3);
    static internal readonly ListTerm s68 = new ListTerm(s66, s67);
    static internal readonly ListTerm s69 = new ListTerm(s68, s3);
    static internal readonly ListTerm s70 = new ListTerm(s65, s69);
    static internal readonly ListTerm s71 = new ListTerm(s70, s3);
    static internal readonly ListTerm s72 = new ListTerm(s2, s71);
    static internal readonly IntegerTerm s73 = new IntegerTerm(5);
    static internal readonly SymbolTerm s74 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s75 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s76 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s77 = SymbolTerm.MakeSymbol("fantasy");
    static internal readonly SymbolTerm s78 = SymbolTerm.MakeSymbol("we");
    static internal readonly SymbolTerm s79 = SymbolTerm.MakeSymbol("each");
    static internal readonly SymbolTerm s80 = SymbolTerm.MakeSymbol("other");
    static internal readonly ListTerm s81 = new ListTerm(s80, s14);
    static internal readonly ListTerm s82 = new ListTerm(s79, s81);
    static internal readonly ListTerm s83 = new ListTerm(s44, s14);
    static internal readonly SymbolTerm s84 = SymbolTerm.MakeSymbol("seem");
    static internal readonly SymbolTerm s85 = SymbolTerm.MakeSymbol("need");
    static internal readonly ListTerm s86 = new ListTerm(s44, s50);
    static internal readonly SymbolTerm s87 = SymbolTerm.MakeSymbol("anyone");
    static internal readonly SymbolTerm s88 = SymbolTerm.MakeSymbol("else");
    static internal readonly ListTerm s89 = new ListTerm(s88, s14);
    static internal readonly ListTerm s90 = new ListTerm(s87, s89);
    static internal readonly IntegerTerm s91 = new IntegerTerm(6);
    static internal readonly SymbolTerm s92 = SymbolTerm.MakeSymbol("*");
    static internal readonly SymbolTerm s93 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s94 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s95 = SymbolTerm.MakeSymbol("mean");
    static internal readonly SymbolTerm s96 = SymbolTerm.MakeSymbol("if");
    static internal readonly SymbolTerm s97 = SymbolTerm.MakeSymbol("got");
    static internal readonly SymbolTerm s98 = SymbolTerm.MakeSymbol("suppose");
    static internal readonly SymbolTerm s99 = SymbolTerm.MakeSymbol("soon");
    static internal readonly ListTerm s100 = new ListTerm(s99, s14);
    static internal readonly SymbolTerm s101 = SymbolTerm.MakeSymbol("never");
    static internal readonly SymbolTerm s102 = SymbolTerm.MakeSymbol("getting");
    static internal readonly ListTerm s103 = new ListTerm(s26, s35);
    static internal readonly ListTerm s104 = new ListTerm(s95, s103);
    static internal readonly SymbolTerm s105 = SymbolTerm.MakeSymbol("wanting");
    static internal readonly SymbolTerm s106 = SymbolTerm.MakeSymbol("with");
    static internal readonly SymbolTerm s107 = SymbolTerm.MakeSymbol("this");
    static internal readonly SymbolTerm s108 = SymbolTerm.MakeSymbol("discussion");
    static internal readonly ListTerm s109 = new ListTerm(s108, s14);
    static internal readonly ListTerm s110 = new ListTerm(s107, s109);
    static internal readonly ListTerm s111 = new ListTerm(s106, s110);
    static internal readonly ListTerm s112 = new ListTerm(s9, s111);
    static internal readonly ListTerm s113 = new ListTerm(s26, s112);
    static internal readonly ListTerm s114 = new ListTerm(s15, s113);
    static internal readonly IntegerTerm s115 = new IntegerTerm(7);
    static internal readonly SymbolTerm s116 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s117 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s118 = SymbolTerm.MakeSymbol("so");
    static internal readonly ListTerm s119 = new ListTerm(s118, s14);
    static internal readonly ListTerm s120 = new ListTerm(s116, s119);
    static internal readonly ListTerm s121 = new ListTerm(s24, s120);
    static internal readonly ListTerm s122 = new ListTerm(s1, s121);
    static internal readonly ListTerm s123 = new ListTerm(s9, s122);
    static internal readonly SymbolTerm s124 = SymbolTerm.MakeSymbol("but");
    static internal readonly SymbolTerm s125 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s126 = SymbolTerm.MakeSymbol("sure");
    static internal readonly SymbolTerm s127 = SymbolTerm.MakeSymbol("doubt");
    static internal readonly IntegerTerm s128 = new IntegerTerm(8);
    static internal readonly ListTerm s129 = new ListTerm(s5, s3);
    static internal readonly ListTerm s130 = new ListTerm(s65, s129);
    static internal readonly ListTerm s131 = new ListTerm(s130, s3);
    static internal readonly ListTerm s132 = new ListTerm(s2, s131);
    static internal readonly IntegerTerm s133 = new IntegerTerm(9);
    static internal readonly SymbolTerm s134 = SymbolTerm.MakeSymbol("youre");
    static internal readonly SymbolTerm s135 = SymbolTerm.MakeSymbol("sad");
    static internal readonly SymbolTerm s136 = SymbolTerm.MakeSymbol("unhappy");
    static internal readonly SymbolTerm s137 = SymbolTerm.MakeSymbol("depressed");
    static internal readonly SymbolTerm s138 = SymbolTerm.MakeSymbol("sick");
    static internal readonly SymbolTerm s139 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s140 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s141 = SymbolTerm.MakeSymbol("sorry");
    static internal readonly SymbolTerm s142 = SymbolTerm.MakeSymbol("hear");
    static internal readonly SymbolTerm s143 = SymbolTerm.MakeSymbol("coming");
    static internal readonly SymbolTerm s144 = SymbolTerm.MakeSymbol("here");
    static internal readonly SymbolTerm s145 = SymbolTerm.MakeSymbol("will");
    static internal readonly SymbolTerm s146 = SymbolTerm.MakeSymbol("help");
    static internal readonly SymbolTerm s147 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s148 = SymbolTerm.MakeSymbol("pleasant");
    static internal readonly SymbolTerm s149 = SymbolTerm.MakeSymbol("explain");
    static internal readonly SymbolTerm s150 = SymbolTerm.MakeSymbol("made");
    static internal readonly IntegerTerm s151 = new IntegerTerm(10);
    static internal readonly SymbolTerm s152 = SymbolTerm.MakeSymbol("happy");
    static internal readonly SymbolTerm s153 = SymbolTerm.MakeSymbol("elated");
    static internal readonly SymbolTerm s154 = SymbolTerm.MakeSymbol("glad");
    static internal readonly SymbolTerm s155 = SymbolTerm.MakeSymbol("better");
    static internal readonly SymbolTerm s156 = SymbolTerm.MakeSymbol("helped");
    static internal readonly SymbolTerm s157 = SymbolTerm.MakeSymbol("has");
    static internal readonly SymbolTerm s158 = SymbolTerm.MakeSymbol("treatment");
    static internal readonly SymbolTerm s159 = SymbolTerm.MakeSymbol("makes");
    static internal readonly SymbolTerm s160 = SymbolTerm.MakeSymbol("just");
    static internal readonly ListTerm s161 = new ListTerm(s160, s23);
    static internal readonly SymbolTerm s162 = SymbolTerm.MakeSymbol("suddenly");
    static internal readonly IntegerTerm s163 = new IntegerTerm(11);
    static internal readonly SymbolTerm s164 = SymbolTerm.MakeSymbol("because");
    static internal readonly SymbolTerm s165 = SymbolTerm.MakeSymbol("came");
    static internal readonly ListTerm s166 = new ListTerm(s26, s83);
    static internal readonly ListTerm s167 = new ListTerm(s165, s166);
    static internal readonly ListTerm s168 = new ListTerm(s1, s167);
    static internal readonly ListTerm s169 = new ListTerm(s33, s168);
    static internal readonly SymbolTerm s170 = SymbolTerm.MakeSymbol("long");
    static internal readonly SymbolTerm s171 = SymbolTerm.MakeSymbol("been");
    static internal readonly SymbolTerm s172 = SymbolTerm.MakeSymbol("normal");
    static internal readonly SymbolTerm s173 = SymbolTerm.MakeSymbol("being");
    static internal readonly IntegerTerm s174 = new IntegerTerm(12);
    static internal readonly SymbolTerm s175 = SymbolTerm.MakeSymbol("say");
    static internal readonly SymbolTerm s176 = SymbolTerm.MakeSymbol("elaborate");
    static internal readonly SymbolTerm s177 = SymbolTerm.MakeSymbol("on");
    static internal readonly ListTerm s178 = new ListTerm(s33, s14);
    static internal readonly ListTerm s179 = new ListTerm(s177, s178);
    static internal readonly ListTerm s180 = new ListTerm(s176, s179);
    static internal readonly ListTerm s181 = new ListTerm(s1, s180);
    static internal readonly ListTerm s182 = new ListTerm(s11, s181);
    static internal readonly SymbolTerm s183 = SymbolTerm.MakeSymbol("quite");
    static internal readonly SymbolTerm s184 = SymbolTerm.MakeSymbol("interesting");
    static internal readonly ListTerm s185 = new ListTerm(s184, s50);
    static internal readonly ListTerm s186 = new ListTerm(s183, s185);
    static internal readonly ListTerm s187 = new ListTerm(s147, s186);
    static internal readonly ListTerm s188 = new ListTerm(s33, s187);
    static internal readonly ListTerm s189 = new ListTerm(s188, s3);
    static internal readonly SymbolTerm s190 = SymbolTerm.MakeSymbol("for");
    static internal readonly SymbolTerm s191 = SymbolTerm.MakeSymbol("some");
    static internal readonly SymbolTerm s192 = SymbolTerm.MakeSymbol("special");
    static internal readonly SymbolTerm s193 = SymbolTerm.MakeSymbol("reason");
    static internal readonly ListTerm s194 = new ListTerm(s193, s14);
    static internal readonly ListTerm s195 = new ListTerm(s192, s194);
    static internal readonly ListTerm s196 = new ListTerm(s191, s195);
    static internal readonly ListTerm s197 = new ListTerm(s190, s196);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91, a92, a93, a94, a95, a96, a97, a98, a99, a100, a101, a102, a103, a104, a105, a106, a107, a108, a109, a110, a111, a112, a113, a114, a115, a116, a117, a118, a119, a120, a121, a122, a123, a124, a125, a126, a127, a128, a129, a130, a131, a132, a133, a134, a135, a136, a137, a138, a139, a140, a141, a142, a143, a144, a145, a146, a147, a148, a149, a150, a151, a152, a153, a154, a155, a156, a157, a158, a159, a160, a161, a162, a163, a164, a165, a166, a167, a168, a169, a170, a171, a172, a173, a174, a175, a176, a177, a178, a179, a180, a181, a182, a183, a184, a185, a186, a187, a188, a189, a190, a191, a192, a193, a194, a195, a196, a197, a198, a199, a200, a201, a202, a203, a204, a205, a206, a207, a208, a209, a210, a211, a212, a213, a214, a215, a216, a217, a218, a219, a220, a221, a222, a223, a224, a225, a226, a227, a228, a229, a230, a231, a232, a233, a234, a235, a236, a237, a238, a239, a240, a241, a242, a243, a244, a245, a246, a247, a248, a249, a250, a251, a252, a253, a254, a255, a256, a257, a258, a259, a260, a261, a262, a263, a264, a265, a266, a267, a268, a269, a270, a271, a272, a273, a274, a275, a276, a277, a278, a279, a280, a281, a282, a283, a284, a285, a286, a287, a288, a289, a290, a291, a292, a293, a294, a295, a296, a297, a298, a299, a300, a301, a302, a303, a304, a305, a306, a307, a308, a309, a310, a311, a312, a313, a314, a315, a316, a317, a318, a319, a320, a321, a322, a323, a324, a325, a326, a327, a328, a329, a330, a331, a332, a333, a334, a335, a336, a337, a338, a339, a340, a341, a342, a343, a344, a345, a346, a347;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s7.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s2.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s2, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a14 = ((ListTerm)a13).car;
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a14, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s8.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s8, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s9.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s9, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s1.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s1, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s10.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s10, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s1.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s1, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s11.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s11, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s12.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s12, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s19.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s19, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            a24 = ((ListTerm)a23).car;
            a25 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            a25 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(a24, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s20.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s20, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s1.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(s1, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s21.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s21, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !a12.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            if ( !s23.Unify(((ListTerm)a28).cdr, engine.trail) )
                return engine.fail();
        } else if ( a28.IsVariable() ){
            if ( !a28.Unify(new ListTerm(a12, s23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            a29 = ((ListTerm)a25).car;
            if ( !s3.Unify(((ListTerm)a25).cdr, engine.trail) )
                return engine.fail();
        } else if ( a25.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(a29, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s9.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s9, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s1.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s1, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s24.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s24, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s25.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s25, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s26.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s26, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s27.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s27, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s28.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s28, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s26.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a36).cdr, engine.trail) )
                return engine.fail();
        } else if ( a36.IsVariable() ){
            if ( !a36.Unify(new ListTerm(s26, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a37 = ((ListTerm)a5).car;
            a38 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a37 = engine.makeVariable();
            a38 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a37, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s29.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a39 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s29, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            a40 = ((ListTerm)a39).car;
            a41 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            a41 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(a40, a41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            a42 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(engine.makeVariable(), a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s1.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s1, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            if ( !s30.Unify(((ListTerm)a43).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a43).cdr, engine.trail) )
                return engine.fail();
        } else if ( a43.IsVariable() ){
            if ( !a43.Unify(new ListTerm(s30, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s2.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a44 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a44 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s2, a44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            a45 = ((ListTerm)a44).car;
            a46 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a45 = engine.makeVariable();
            a46 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(a45, a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            if ( !s9.Unify(((ListTerm)a45).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(s9, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s1.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(s1, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s12.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s12, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s24.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a49).cdr, engine.trail) )
                return engine.fail();
        } else if ( a49.IsVariable() ){
            if ( !a49.Unify(new ListTerm(s24, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            a50 = ((ListTerm)a46).car;
            a51 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a50 = engine.makeVariable();
            a51 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(a50, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s31.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            a52 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a52 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(s31, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s9.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            a53 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a53 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(s9, a53), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            if ( !s1.Unify(((ListTerm)a53).car, engine.trail) )
                return engine.fail();
            if ( !a21.Unify(((ListTerm)a53).cdr, engine.trail) )
                return engine.fail();
        } else if ( a53.IsVariable() ){
            if ( !a53.Unify(new ListTerm(s1, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s12.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a21).cdr, engine.trail) )
                return engine.fail();
        } else if ( a21.IsVariable() ){
            if ( !a21.Unify(new ListTerm(s12, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            a54 = ((ListTerm)a51).car;
            if ( !s39.Unify(((ListTerm)a51).cdr, engine.trail) )
                return engine.fail();
        } else if ( a51.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(a54, s39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s9.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a54).cdr;
        } else if ( a54.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(s9, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s1.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s1, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s40.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            if ( !a33.Unify(((ListTerm)a56).cdr, engine.trail) )
                return engine.fail();
        } else if ( a56.IsVariable() ){
            if ( !a56.Unify(new ListTerm(s40, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s26.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            if ( !a34.Unify(((ListTerm)a33).cdr, engine.trail) )
                return engine.fail();
        } else if ( a33.IsVariable() ){
            if ( !a33.Unify(new ListTerm(s26, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s27.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            if ( !a35.Unify(((ListTerm)a34).cdr, engine.trail) )
                return engine.fail();
        } else if ( a34.IsVariable() ){
            if ( !a34.Unify(new ListTerm(s27, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s28.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            if ( !a36.Unify(((ListTerm)a35).cdr, engine.trail) )
                return engine.fail();
        } else if ( a35.IsVariable() ){
            if ( !a35.Unify(new ListTerm(s28, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s26.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a36).cdr, engine.trail) )
                return engine.fail();
        } else if ( a36.IsVariable() ){
            if ( !a36.Unify(new ListTerm(s26, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            a57 = ((ListTerm)a38).car;
            a58 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a57 = engine.makeVariable();
            a58 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(a57, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s41.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s41, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            a60 = ((ListTerm)a59).car;
            a61 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a60 = engine.makeVariable();
            a61 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(a60, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            a62 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(engine.makeVariable(), a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s1.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s1, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s42.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a63).cdr, engine.trail) )
                return engine.fail();
        } else if ( a63.IsVariable() ){
            if ( !a63.Unify(new ListTerm(s42, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s2.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a64 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a64 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s2, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !s56.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            a65 = ((ListTerm)a64).cdr;
        } else if ( a64.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a64.Unify(new ListTerm(s56, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            a66 = ((ListTerm)a65).car;
            a67 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            a67 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(a66, a67), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s9.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            a68 = ((ListTerm)a66).cdr;
        } else if ( a66.IsVariable() ){
            a68 = engine.makeVariable();
            if ( !a66.Unify(new ListTerm(s9, a68), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            if ( !s1.Unify(((ListTerm)a68).car, engine.trail) )
                return engine.fail();
            a69 = ((ListTerm)a68).cdr;
        } else if ( a68.IsVariable() ){
            a69 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(s1, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            if ( !s57.Unify(((ListTerm)a69).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(s57, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s42.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a70).cdr, engine.trail) )
                return engine.fail();
        } else if ( a70.IsVariable() ){
            if ( !a70.Unify(new ListTerm(s42, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            a71 = ((ListTerm)a67).car;
            a72 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a71 = engine.makeVariable();
            a72 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(a71, a72), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !s9.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            a73 = ((ListTerm)a71).cdr;
        } else if ( a71.IsVariable() ){
            a73 = engine.makeVariable();
            if ( !a71.Unify(new ListTerm(s9, a73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a73.IsList() ){
            if ( !s1.Unify(((ListTerm)a73).car, engine.trail) )
                return engine.fail();
            a74 = ((ListTerm)a73).cdr;
        } else if ( a73.IsVariable() ){
            a74 = engine.makeVariable();
            if ( !a73.Unify(new ListTerm(s1, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s58.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            a75 = ((ListTerm)a74).cdr;
        } else if ( a74.IsVariable() ){
            a75 = engine.makeVariable();
            if ( !a74.Unify(new ListTerm(s58, a75), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            if ( !s59.Unify(((ListTerm)a75).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a75).cdr, engine.trail) )
                return engine.fail();
        } else if ( a75.IsVariable() ){
            if ( !a75.Unify(new ListTerm(s59, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a72.IsList() ){
            a76 = ((ListTerm)a72).car;
            if ( !s3.Unify(((ListTerm)a72).cdr, engine.trail) )
                return engine.fail();
        } else if ( a72.IsVariable() ){
            a76 = engine.makeVariable();
            if ( !a72.Unify(new ListTerm(a76, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a76.IsList() ){
            if ( !s60.Unify(((ListTerm)a76).car, engine.trail) )
                return engine.fail();
            a77 = ((ListTerm)a76).cdr;
        } else if ( a76.IsVariable() ){
            a77 = engine.makeVariable();
            if ( !a76.Unify(new ListTerm(s60, a77), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a77.IsList() ){
            if ( !s61.Unify(((ListTerm)a77).car, engine.trail) )
                return engine.fail();
            a78 = ((ListTerm)a77).cdr;
        } else if ( a77.IsVariable() ){
            a78 = engine.makeVariable();
            if ( !a77.Unify(new ListTerm(s61, a78), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a78.IsList() ){
            if ( !s32.Unify(((ListTerm)a78).car, engine.trail) )
                return engine.fail();
            a79 = ((ListTerm)a78).cdr;
        } else if ( a78.IsVariable() ){
            a79 = engine.makeVariable();
            if ( !a78.Unify(new ListTerm(s32, a79), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a79.IsList() ){
            if ( !s59.Unify(((ListTerm)a79).car, engine.trail) )
                return engine.fail();
            a80 = ((ListTerm)a79).cdr;
        } else if ( a79.IsVariable() ){
            a80 = engine.makeVariable();
            if ( !a79.Unify(new ListTerm(s59, a80), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a80.IsList() ){
            if ( !a12.Unify(((ListTerm)a80).car, engine.trail) )
                return engine.fail();
            if ( !s63.Unify(((ListTerm)a80).cdr, engine.trail) )
                return engine.fail();
        } else if ( a80.IsVariable() ){
            if ( !a80.Unify(new ListTerm(a12, s63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            a81 = ((ListTerm)a58).car;
            a82 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a81 = engine.makeVariable();
            a82 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(a81, a82), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a81.IsList() ){
            if ( !s64.Unify(((ListTerm)a81).car, engine.trail) )
                return engine.fail();
            a83 = ((ListTerm)a81).cdr;
        } else if ( a81.IsVariable() ){
            a83 = engine.makeVariable();
            if ( !a81.Unify(new ListTerm(s64, a83), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a83.IsList() ){
            a84 = ((ListTerm)a83).car;
            if ( !s72.Unify(((ListTerm)a83).cdr, engine.trail) )
                return engine.fail();
        } else if ( a83.IsVariable() ){
            a84 = engine.makeVariable();
            if ( !a83.Unify(new ListTerm(a84, s72), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a84.IsList() ){
            a85 = ((ListTerm)a84).cdr;
        } else if ( a84.IsVariable() ){
            a85 = engine.makeVariable();
            if ( !a84.Unify(new ListTerm(engine.makeVariable(), a85), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a85.IsList() ){
            if ( !s1.Unify(((ListTerm)a85).car, engine.trail) )
                return engine.fail();
            a86 = ((ListTerm)a85).cdr;
        } else if ( a85.IsVariable() ){
            a86 = engine.makeVariable();
            if ( !a85.Unify(new ListTerm(s1, a86), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a86.IsList() ){
            if ( !s66.Unify(((ListTerm)a86).car, engine.trail) )
                return engine.fail();
            a87 = ((ListTerm)a86).cdr;
        } else if ( a86.IsVariable() ){
            a87 = engine.makeVariable();
            if ( !a86.Unify(new ListTerm(s66, a87), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a87.IsList() ){
            if ( !s3.Unify(((ListTerm)a87).cdr, engine.trail) )
                return engine.fail();
        } else if ( a87.IsVariable() ){
            if ( !a87.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a82.IsList() ){
            a88 = ((ListTerm)a82).car;
            a89 = ((ListTerm)a82).cdr;
        } else if ( a82.IsVariable() ){
            a88 = engine.makeVariable();
            a89 = engine.makeVariable();
            if ( !a82.Unify(new ListTerm(a88, a89), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a88.IsList() ){
            if ( !s73.Unify(((ListTerm)a88).car, engine.trail) )
                return engine.fail();
            a90 = ((ListTerm)a88).cdr;
        } else if ( a88.IsVariable() ){
            a90 = engine.makeVariable();
            if ( !a88.Unify(new ListTerm(s73, a90), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a90.IsList() ){
            a91 = ((ListTerm)a90).car;
            a92 = ((ListTerm)a90).cdr;
        } else if ( a90.IsVariable() ){
            a91 = engine.makeVariable();
            a92 = engine.makeVariable();
            if ( !a90.Unify(new ListTerm(a91, a92), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a91.IsList() ){
            a93 = ((ListTerm)a91).cdr;
        } else if ( a91.IsVariable() ){
            a93 = engine.makeVariable();
            if ( !a91.Unify(new ListTerm(engine.makeVariable(), a93), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a93.IsList() ){
            if ( !s1.Unify(((ListTerm)a93).car, engine.trail) )
                return engine.fail();
            a94 = ((ListTerm)a93).cdr;
        } else if ( a93.IsVariable() ){
            a94 = engine.makeVariable();
            if ( !a93.Unify(new ListTerm(s1, a94), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a94.IsList() ){
            if ( !a12.Unify(((ListTerm)a94).car, engine.trail) )
                return engine.fail();
            a95 = ((ListTerm)a94).cdr;
        } else if ( a94.IsVariable() ){
            a95 = engine.makeVariable();
            if ( !a94.Unify(new ListTerm(a12, a95), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a95.IsList() ){
            if ( !s74.Unify(((ListTerm)a95).car, engine.trail) )
                return engine.fail();
            a96 = ((ListTerm)a95).cdr;
        } else if ( a95.IsVariable() ){
            a96 = engine.makeVariable();
            if ( !a95.Unify(new ListTerm(s74, a96), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a96.IsList() ){
            if ( !s3.Unify(((ListTerm)a96).cdr, engine.trail) )
                return engine.fail();
        } else if ( a96.IsVariable() ){
            if ( !a96.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a92.IsList() ){
            if ( !s2.Unify(((ListTerm)a92).car, engine.trail) )
                return engine.fail();
            a97 = ((ListTerm)a92).cdr;
        } else if ( a92.IsVariable() ){
            a97 = engine.makeVariable();
            if ( !a92.Unify(new ListTerm(s2, a97), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a97.IsList() ){
            a98 = ((ListTerm)a97).car;
            a99 = ((ListTerm)a97).cdr;
        } else if ( a97.IsVariable() ){
            a98 = engine.makeVariable();
            a99 = engine.makeVariable();
            if ( !a97.Unify(new ListTerm(a98, a99), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a98.IsList() ){
            if ( !s20.Unify(((ListTerm)a98).car, engine.trail) )
                return engine.fail();
            a100 = ((ListTerm)a98).cdr;
        } else if ( a98.IsVariable() ){
            a100 = engine.makeVariable();
            if ( !a98.Unify(new ListTerm(s20, a100), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a100.IsList() ){
            if ( !s75.Unify(((ListTerm)a100).car, engine.trail) )
                return engine.fail();
            a101 = ((ListTerm)a100).cdr;
        } else if ( a100.IsVariable() ){
            a101 = engine.makeVariable();
            if ( !a100.Unify(new ListTerm(s75, a101), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a101.IsList() ){
            if ( !s76.Unify(((ListTerm)a101).car, engine.trail) )
                return engine.fail();
            a102 = ((ListTerm)a101).cdr;
        } else if ( a101.IsVariable() ){
            a102 = engine.makeVariable();
            if ( !a101.Unify(new ListTerm(s76, a102), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a102.IsList() ){
            if ( !s77.Unify(((ListTerm)a102).car, engine.trail) )
                return engine.fail();
            a103 = ((ListTerm)a102).cdr;
        } else if ( a102.IsVariable() ){
            a103 = engine.makeVariable();
            if ( !a102.Unify(new ListTerm(s77, a103), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a103.IsList() ){
            if ( !s78.Unify(((ListTerm)a103).car, engine.trail) )
                return engine.fail();
            a104 = ((ListTerm)a103).cdr;
        } else if ( a103.IsVariable() ){
            a104 = engine.makeVariable();
            if ( !a103.Unify(new ListTerm(s78, a104), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a104.IsList() ){
            if ( !a12.Unify(((ListTerm)a104).car, engine.trail) )
                return engine.fail();
            if ( !s82.Unify(((ListTerm)a104).cdr, engine.trail) )
                return engine.fail();
        } else if ( a104.IsVariable() ){
            if ( !a104.Unify(new ListTerm(a12, s82), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a99.IsList() ){
            a105 = ((ListTerm)a99).car;
            a106 = ((ListTerm)a99).cdr;
        } else if ( a99.IsVariable() ){
            a105 = engine.makeVariable();
            a106 = engine.makeVariable();
            if ( !a99.Unify(new ListTerm(a105, a106), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a105.IsList() ){
            if ( !s9.Unify(((ListTerm)a105).car, engine.trail) )
                return engine.fail();
            a107 = ((ListTerm)a105).cdr;
        } else if ( a105.IsVariable() ){
            a107 = engine.makeVariable();
            if ( !a105.Unify(new ListTerm(s9, a107), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a107.IsList() ){
            if ( !s1.Unify(((ListTerm)a107).car, engine.trail) )
                return engine.fail();
            a108 = ((ListTerm)a107).cdr;
        } else if ( a107.IsVariable() ){
            a108 = engine.makeVariable();
            if ( !a107.Unify(new ListTerm(s1, a108), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a108.IsList() ){
            if ( !s40.Unify(((ListTerm)a108).car, engine.trail) )
                return engine.fail();
            a109 = ((ListTerm)a108).cdr;
        } else if ( a108.IsVariable() ){
            a109 = engine.makeVariable();
            if ( !a108.Unify(new ListTerm(s40, a109), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a109.IsList() ){
            if ( !s26.Unify(((ListTerm)a109).car, engine.trail) )
                return engine.fail();
            a110 = ((ListTerm)a109).cdr;
        } else if ( a109.IsVariable() ){
            a110 = engine.makeVariable();
            if ( !a109.Unify(new ListTerm(s26, a110), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a110.IsList() ){
            if ( !a12.Unify(((ListTerm)a110).car, engine.trail) )
                return engine.fail();
            if ( !s83.Unify(((ListTerm)a110).cdr, engine.trail) )
                return engine.fail();
        } else if ( a110.IsVariable() ){
            if ( !a110.Unify(new ListTerm(a12, s83), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a106.IsList() ){
            a111 = ((ListTerm)a106).car;
            a112 = ((ListTerm)a106).cdr;
        } else if ( a106.IsVariable() ){
            a111 = engine.makeVariable();
            a112 = engine.makeVariable();
            if ( !a106.Unify(new ListTerm(a111, a112), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a111.IsList() ){
            if ( !s1.Unify(((ListTerm)a111).car, engine.trail) )
                return engine.fail();
            a113 = ((ListTerm)a111).cdr;
        } else if ( a111.IsVariable() ){
            a113 = engine.makeVariable();
            if ( !a111.Unify(new ListTerm(s1, a113), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a113.IsList() ){
            if ( !s84.Unify(((ListTerm)a113).car, engine.trail) )
                return engine.fail();
            a114 = ((ListTerm)a113).cdr;
        } else if ( a113.IsVariable() ){
            a114 = engine.makeVariable();
            if ( !a113.Unify(new ListTerm(s84, a114), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a114.IsList() ){
            if ( !s26.Unify(((ListTerm)a114).car, engine.trail) )
                return engine.fail();
            a115 = ((ListTerm)a114).cdr;
        } else if ( a114.IsVariable() ){
            a115 = engine.makeVariable();
            if ( !a114.Unify(new ListTerm(s26, a115), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a115.IsList() ){
            if ( !s85.Unify(((ListTerm)a115).car, engine.trail) )
                return engine.fail();
            a116 = ((ListTerm)a115).cdr;
        } else if ( a115.IsVariable() ){
            a116 = engine.makeVariable();
            if ( !a115.Unify(new ListTerm(s85, a116), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a116.IsList() ){
            if ( !s26.Unify(((ListTerm)a116).car, engine.trail) )
                return engine.fail();
            a117 = ((ListTerm)a116).cdr;
        } else if ( a116.IsVariable() ){
            a117 = engine.makeVariable();
            if ( !a116.Unify(new ListTerm(s26, a117), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a117.IsList() ){
            if ( !a12.Unify(((ListTerm)a117).car, engine.trail) )
                return engine.fail();
            if ( !s86.Unify(((ListTerm)a117).cdr, engine.trail) )
                return engine.fail();
        } else if ( a117.IsVariable() ){
            if ( !a117.Unify(new ListTerm(a12, s86), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a112.IsList() ){
            a118 = ((ListTerm)a112).car;
            if ( !s3.Unify(((ListTerm)a112).cdr, engine.trail) )
                return engine.fail();
        } else if ( a112.IsVariable() ){
            a118 = engine.makeVariable();
            if ( !a112.Unify(new ListTerm(a118, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a118.IsList() ){
            if ( !s9.Unify(((ListTerm)a118).car, engine.trail) )
                return engine.fail();
            a119 = ((ListTerm)a118).cdr;
        } else if ( a118.IsVariable() ){
            a119 = engine.makeVariable();
            if ( !a118.Unify(new ListTerm(s9, a119), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a119.IsList() ){
            if ( !s1.Unify(((ListTerm)a119).car, engine.trail) )
                return engine.fail();
            a120 = ((ListTerm)a119).cdr;
        } else if ( a119.IsVariable() ){
            a120 = engine.makeVariable();
            if ( !a119.Unify(new ListTerm(s1, a120), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a120.IsList() ){
            if ( !a12.Unify(((ListTerm)a120).car, engine.trail) )
                return engine.fail();
            if ( !s90.Unify(((ListTerm)a120).cdr, engine.trail) )
                return engine.fail();
        } else if ( a120.IsVariable() ){
            if ( !a120.Unify(new ListTerm(a12, s90), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a89.IsList() ){
            a121 = ((ListTerm)a89).car;
            a122 = ((ListTerm)a89).cdr;
        } else if ( a89.IsVariable() ){
            a121 = engine.makeVariable();
            a122 = engine.makeVariable();
            if ( !a89.Unify(new ListTerm(a121, a122), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a121.IsList() ){
            if ( !s91.Unify(((ListTerm)a121).car, engine.trail) )
                return engine.fail();
            a123 = ((ListTerm)a121).cdr;
        } else if ( a121.IsVariable() ){
            a123 = engine.makeVariable();
            if ( !a121.Unify(new ListTerm(s91, a123), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a123.IsList() ){
            a124 = ((ListTerm)a123).car;
            a125 = ((ListTerm)a123).cdr;
        } else if ( a123.IsVariable() ){
            a124 = engine.makeVariable();
            a125 = engine.makeVariable();
            if ( !a123.Unify(new ListTerm(a124, a125), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a124.IsList() ){
            a126 = ((ListTerm)a124).cdr;
        } else if ( a124.IsVariable() ){
            a126 = engine.makeVariable();
            if ( !a124.Unify(new ListTerm(engine.makeVariable(), a126), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a126.IsList() ){
            if ( !s1.Unify(((ListTerm)a126).car, engine.trail) )
                return engine.fail();
            a127 = ((ListTerm)a126).cdr;
        } else if ( a126.IsVariable() ){
            a127 = engine.makeVariable();
            if ( !a126.Unify(new ListTerm(s1, a127), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a127.IsList() ){
            a128 = ((ListTerm)a127).car;
            if ( !a11.Unify(((ListTerm)a127).cdr, engine.trail) )
                return engine.fail();
        } else if ( a127.IsVariable() ){
            a128 = engine.makeVariable();
            if ( !a127.Unify(new ListTerm(a128, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a128.IsList() ){
            if ( !s92.Unify(((ListTerm)a128).car, engine.trail) )
                return engine.fail();
            a129 = ((ListTerm)a128).cdr;
        } else if ( a128.IsVariable() ){
            a129 = engine.makeVariable();
            if ( !a128.Unify(new ListTerm(s92, a129), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a129.IsList() ){
            if ( !s25.Unify(((ListTerm)a129).car, engine.trail) )
                return engine.fail();
            a130 = ((ListTerm)a129).cdr;
        } else if ( a129.IsVariable() ){
            a130 = engine.makeVariable();
            if ( !a129.Unify(new ListTerm(s25, a130), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a130.IsList() ){
            if ( !s85.Unify(((ListTerm)a130).car, engine.trail) )
                return engine.fail();
            a131 = ((ListTerm)a130).cdr;
        } else if ( a130.IsVariable() ){
            a131 = engine.makeVariable();
            if ( !a130.Unify(new ListTerm(s85, a131), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a131.IsList() ){
            if ( !s3.Unify(((ListTerm)a131).cdr, engine.trail) )
                return engine.fail();
        } else if ( a131.IsVariable() ){
            if ( !a131.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a125.IsList() ){
            if ( !s2.Unify(((ListTerm)a125).car, engine.trail) )
                return engine.fail();
            a132 = ((ListTerm)a125).cdr;
        } else if ( a125.IsVariable() ){
            a132 = engine.makeVariable();
            if ( !a125.Unify(new ListTerm(s2, a132), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a132.IsList() ){
            a133 = ((ListTerm)a132).car;
            a134 = ((ListTerm)a132).cdr;
        } else if ( a132.IsVariable() ){
            a133 = engine.makeVariable();
            a134 = engine.makeVariable();
            if ( !a132.Unify(new ListTerm(a133, a134), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a133.IsList() ){
            if ( !s61.Unify(((ListTerm)a133).car, engine.trail) )
                return engine.fail();
            a135 = ((ListTerm)a133).cdr;
        } else if ( a133.IsVariable() ){
            a135 = engine.makeVariable();
            if ( !a133.Unify(new ListTerm(s61, a135), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a135.IsList() ){
            if ( !s93.Unify(((ListTerm)a135).car, engine.trail) )
                return engine.fail();
            a136 = ((ListTerm)a135).cdr;
        } else if ( a135.IsVariable() ){
            a136 = engine.makeVariable();
            if ( !a135.Unify(new ListTerm(s93, a136), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a136.IsList() ){
            if ( !s94.Unify(((ListTerm)a136).car, engine.trail) )
                return engine.fail();
            a137 = ((ListTerm)a136).cdr;
        } else if ( a136.IsVariable() ){
            a137 = engine.makeVariable();
            if ( !a136.Unify(new ListTerm(s94, a137), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a137.IsList() ){
            if ( !s95.Unify(((ListTerm)a137).car, engine.trail) )
                return engine.fail();
            a138 = ((ListTerm)a137).cdr;
        } else if ( a137.IsVariable() ){
            a138 = engine.makeVariable();
            if ( !a137.Unify(new ListTerm(s95, a138), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a138.IsList() ){
            if ( !s26.Unify(((ListTerm)a138).car, engine.trail) )
                return engine.fail();
            a139 = ((ListTerm)a138).cdr;
        } else if ( a138.IsVariable() ){
            a139 = engine.makeVariable();
            if ( !a138.Unify(new ListTerm(s26, a139), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a139.IsList() ){
            if ( !s1.Unify(((ListTerm)a139).car, engine.trail) )
                return engine.fail();
            a140 = ((ListTerm)a139).cdr;
        } else if ( a139.IsVariable() ){
            a140 = engine.makeVariable();
            if ( !a139.Unify(new ListTerm(s1, a140), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a140.IsList() ){
            if ( !s96.Unify(((ListTerm)a140).car, engine.trail) )
                return engine.fail();
            a141 = ((ListTerm)a140).cdr;
        } else if ( a140.IsVariable() ){
            a141 = engine.makeVariable();
            if ( !a140.Unify(new ListTerm(s96, a141), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a141.IsList() ){
            if ( !s1.Unify(((ListTerm)a141).car, engine.trail) )
                return engine.fail();
            a142 = ((ListTerm)a141).cdr;
        } else if ( a141.IsVariable() ){
            a142 = engine.makeVariable();
            if ( !a141.Unify(new ListTerm(s1, a142), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a142.IsList() ){
            if ( !s97.Unify(((ListTerm)a142).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a142).cdr, engine.trail) )
                return engine.fail();
        } else if ( a142.IsVariable() ){
            if ( !a142.Unify(new ListTerm(s97, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a134.IsList() ){
            a143 = ((ListTerm)a134).car;
            a144 = ((ListTerm)a134).cdr;
        } else if ( a134.IsVariable() ){
            a143 = engine.makeVariable();
            a144 = engine.makeVariable();
            if ( !a134.Unify(new ListTerm(a143, a144), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a143.IsList() ){
            if ( !s31.Unify(((ListTerm)a143).car, engine.trail) )
                return engine.fail();
            a145 = ((ListTerm)a143).cdr;
        } else if ( a143.IsVariable() ){
            a145 = engine.makeVariable();
            if ( !a143.Unify(new ListTerm(s31, a145), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a145.IsList() ){
            if ( !s9.Unify(((ListTerm)a145).car, engine.trail) )
                return engine.fail();
            a146 = ((ListTerm)a145).cdr;
        } else if ( a145.IsVariable() ){
            a146 = engine.makeVariable();
            if ( !a145.Unify(new ListTerm(s9, a146), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a146.IsList() ){
            if ( !s1.Unify(((ListTerm)a146).car, engine.trail) )
                return engine.fail();
            a147 = ((ListTerm)a146).cdr;
        } else if ( a146.IsVariable() ){
            a147 = engine.makeVariable();
            if ( !a146.Unify(new ListTerm(s1, a147), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a147.IsList() ){
            if ( !s25.Unify(((ListTerm)a147).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a147).cdr, engine.trail) )
                return engine.fail();
        } else if ( a147.IsVariable() ){
            if ( !a147.Unify(new ListTerm(s25, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a144.IsList() ){
            a148 = ((ListTerm)a144).car;
            a149 = ((ListTerm)a144).cdr;
        } else if ( a144.IsVariable() ){
            a148 = engine.makeVariable();
            a149 = engine.makeVariable();
            if ( !a144.Unify(new ListTerm(a148, a149), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a148.IsList() ){
            if ( !s98.Unify(((ListTerm)a148).car, engine.trail) )
                return engine.fail();
            a150 = ((ListTerm)a148).cdr;
        } else if ( a148.IsVariable() ){
            a150 = engine.makeVariable();
            if ( !a148.Unify(new ListTerm(s98, a150), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a150.IsList() ){
            if ( !s1.Unify(((ListTerm)a150).car, engine.trail) )
                return engine.fail();
            a151 = ((ListTerm)a150).cdr;
        } else if ( a150.IsVariable() ){
            a151 = engine.makeVariable();
            if ( !a150.Unify(new ListTerm(s1, a151), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a151.IsList() ){
            if ( !s97.Unify(((ListTerm)a151).car, engine.trail) )
                return engine.fail();
            a152 = ((ListTerm)a151).cdr;
        } else if ( a151.IsVariable() ){
            a152 = engine.makeVariable();
            if ( !a151.Unify(new ListTerm(s97, a152), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a152.IsList() ){
            if ( !a12.Unify(((ListTerm)a152).car, engine.trail) )
                return engine.fail();
            if ( !s100.Unify(((ListTerm)a152).cdr, engine.trail) )
                return engine.fail();
        } else if ( a152.IsVariable() ){
            if ( !a152.Unify(new ListTerm(a12, s100), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a149.IsList() ){
            a153 = ((ListTerm)a149).car;
            a154 = ((ListTerm)a149).cdr;
        } else if ( a149.IsVariable() ){
            a153 = engine.makeVariable();
            a154 = engine.makeVariable();
            if ( !a149.Unify(new ListTerm(a153, a154), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a153.IsList() ){
            if ( !s61.Unify(((ListTerm)a153).car, engine.trail) )
                return engine.fail();
            a155 = ((ListTerm)a153).cdr;
        } else if ( a153.IsVariable() ){
            a155 = engine.makeVariable();
            if ( !a153.Unify(new ListTerm(s61, a155), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a155.IsList() ){
            if ( !s96.Unify(((ListTerm)a155).car, engine.trail) )
                return engine.fail();
            a156 = ((ListTerm)a155).cdr;
        } else if ( a155.IsVariable() ){
            a156 = engine.makeVariable();
            if ( !a155.Unify(new ListTerm(s96, a156), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a156.IsList() ){
            if ( !s1.Unify(((ListTerm)a156).car, engine.trail) )
                return engine.fail();
            a157 = ((ListTerm)a156).cdr;
        } else if ( a156.IsVariable() ){
            a157 = engine.makeVariable();
            if ( !a156.Unify(new ListTerm(s1, a157), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a157.IsList() ){
            if ( !s101.Unify(((ListTerm)a157).car, engine.trail) )
                return engine.fail();
            if ( !a142.Unify(((ListTerm)a157).cdr, engine.trail) )
                return engine.fail();
        } else if ( a157.IsVariable() ){
            if ( !a157.Unify(new ListTerm(s101, a142), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a142.IsList() ){
            if ( !s97.Unify(((ListTerm)a142).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a142).cdr, engine.trail) )
                return engine.fail();
        } else if ( a142.IsVariable() ){
            if ( !a142.Unify(new ListTerm(s97, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a154.IsList() ){
            a158 = ((ListTerm)a154).car;
            a159 = ((ListTerm)a154).cdr;
        } else if ( a154.IsVariable() ){
            a158 = engine.makeVariable();
            a159 = engine.makeVariable();
            if ( !a154.Unify(new ListTerm(a158, a159), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a158.IsList() ){
            if ( !s61.Unify(((ListTerm)a158).car, engine.trail) )
                return engine.fail();
            a160 = ((ListTerm)a158).cdr;
        } else if ( a158.IsVariable() ){
            a160 = engine.makeVariable();
            if ( !a158.Unify(new ListTerm(s61, a160), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a160.IsList() ){
            if ( !s93.Unify(((ListTerm)a160).car, engine.trail) )
                return engine.fail();
            a161 = ((ListTerm)a160).cdr;
        } else if ( a160.IsVariable() ){
            a161 = engine.makeVariable();
            if ( !a160.Unify(new ListTerm(s93, a161), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a161.IsList() ){
            if ( !s102.Unify(((ListTerm)a161).car, engine.trail) )
                return engine.fail();
            a162 = ((ListTerm)a161).cdr;
        } else if ( a161.IsVariable() ){
            a162 = engine.makeVariable();
            if ( !a161.Unify(new ListTerm(s102, a162), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a162.IsList() ){
            if ( !a12.Unify(((ListTerm)a162).car, engine.trail) )
                return engine.fail();
            if ( !s104.Unify(((ListTerm)a162).cdr, engine.trail) )
                return engine.fail();
        } else if ( a162.IsVariable() ){
            if ( !a162.Unify(new ListTerm(a12, s104), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a159.IsList() ){
            a163 = ((ListTerm)a159).car;
            if ( !s3.Unify(((ListTerm)a159).cdr, engine.trail) )
                return engine.fail();
        } else if ( a159.IsVariable() ){
            a163 = engine.makeVariable();
            if ( !a159.Unify(new ListTerm(a163, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a163.IsList() ){
            if ( !s61.Unify(((ListTerm)a163).car, engine.trail) )
                return engine.fail();
            a164 = ((ListTerm)a163).cdr;
        } else if ( a163.IsVariable() ){
            a164 = engine.makeVariable();
            if ( !a163.Unify(new ListTerm(s61, a164), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a164.IsList() ){
            if ( !s32.Unify(((ListTerm)a164).car, engine.trail) )
                return engine.fail();
            a165 = ((ListTerm)a164).cdr;
        } else if ( a164.IsVariable() ){
            a165 = engine.makeVariable();
            if ( !a164.Unify(new ListTerm(s32, a165), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a165.IsList() ){
            if ( !s105.Unify(((ListTerm)a165).car, engine.trail) )
                return engine.fail();
            a166 = ((ListTerm)a165).cdr;
        } else if ( a165.IsVariable() ){
            a166 = engine.makeVariable();
            if ( !a165.Unify(new ListTerm(s105, a166), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a166.IsList() ){
            if ( !a12.Unify(((ListTerm)a166).car, engine.trail) )
                return engine.fail();
            if ( !s114.Unify(((ListTerm)a166).cdr, engine.trail) )
                return engine.fail();
        } else if ( a166.IsVariable() ){
            if ( !a166.Unify(new ListTerm(a12, s114), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a122.IsList() ){
            a167 = ((ListTerm)a122).car;
            a168 = ((ListTerm)a122).cdr;
        } else if ( a122.IsVariable() ){
            a167 = engine.makeVariable();
            a168 = engine.makeVariable();
            if ( !a122.Unify(new ListTerm(a167, a168), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a167.IsList() ){
            if ( !s115.Unify(((ListTerm)a167).car, engine.trail) )
                return engine.fail();
            a169 = ((ListTerm)a167).cdr;
        } else if ( a167.IsVariable() ){
            a169 = engine.makeVariable();
            if ( !a167.Unify(new ListTerm(s115, a169), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a169.IsList() ){
            a170 = ((ListTerm)a169).car;
            a171 = ((ListTerm)a169).cdr;
        } else if ( a169.IsVariable() ){
            a170 = engine.makeVariable();
            a171 = engine.makeVariable();
            if ( !a169.Unify(new ListTerm(a170, a171), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a170.IsList() ){
            a172 = ((ListTerm)a170).cdr;
        } else if ( a170.IsVariable() ){
            a172 = engine.makeVariable();
            if ( !a170.Unify(new ListTerm(engine.makeVariable(), a172), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a172.IsList() ){
            if ( !s1.Unify(((ListTerm)a172).car, engine.trail) )
                return engine.fail();
            a173 = ((ListTerm)a172).cdr;
        } else if ( a172.IsVariable() ){
            a173 = engine.makeVariable();
            if ( !a172.Unify(new ListTerm(s1, a173), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a173.IsList() ){
            a174 = ((ListTerm)a173).car;
            a175 = ((ListTerm)a173).cdr;
        } else if ( a173.IsVariable() ){
            a174 = engine.makeVariable();
            a175 = engine.makeVariable();
            if ( !a173.Unify(new ListTerm(a174, a175), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a174.IsList() ){
            if ( !s92.Unify(((ListTerm)a174).car, engine.trail) )
                return engine.fail();
            a176 = ((ListTerm)a174).cdr;
        } else if ( a174.IsVariable() ){
            a176 = engine.makeVariable();
            if ( !a174.Unify(new ListTerm(s92, a176), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a176.IsList() ){
            if ( !s42.Unify(((ListTerm)a176).car, engine.trail) )
                return engine.fail();
            a177 = ((ListTerm)a176).cdr;
        } else if ( a176.IsVariable() ){
            a177 = engine.makeVariable();
            if ( !a176.Unify(new ListTerm(s42, a177), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a177.IsList() ){
            if ( !s116.Unify(((ListTerm)a177).car, engine.trail) )
                return engine.fail();
            a178 = ((ListTerm)a177).cdr;
        } else if ( a177.IsVariable() ){
            a178 = engine.makeVariable();
            if ( !a177.Unify(new ListTerm(s116, a178), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a178.IsList() ){
            if ( !s117.Unify(((ListTerm)a178).car, engine.trail) )
                return engine.fail();
            a179 = ((ListTerm)a178).cdr;
        } else if ( a178.IsVariable() ){
            a179 = engine.makeVariable();
            if ( !a178.Unify(new ListTerm(s117, a179), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a179.IsList() ){
            if ( !s40.Unify(((ListTerm)a179).car, engine.trail) )
                return engine.fail();
            a180 = ((ListTerm)a179).cdr;
        } else if ( a179.IsVariable() ){
            a180 = engine.makeVariable();
            if ( !a179.Unify(new ListTerm(s40, a180), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a180.IsList() ){
            if ( !s3.Unify(((ListTerm)a180).cdr, engine.trail) )
                return engine.fail();
        } else if ( a180.IsVariable() ){
            if ( !a180.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a175.IsList() ){
            if ( !s1.Unify(((ListTerm)a175).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a175).cdr, engine.trail) )
                return engine.fail();
        } else if ( a175.IsVariable() ){
            if ( !a175.Unify(new ListTerm(s1, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a171.IsList() ){
            if ( !s2.Unify(((ListTerm)a171).car, engine.trail) )
                return engine.fail();
            a181 = ((ListTerm)a171).cdr;
        } else if ( a171.IsVariable() ){
            a181 = engine.makeVariable();
            if ( !a171.Unify(new ListTerm(s2, a181), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a181.IsList() ){
            if ( !s123.Unify(((ListTerm)a181).car, engine.trail) )
                return engine.fail();
            a182 = ((ListTerm)a181).cdr;
        } else if ( a181.IsVariable() ){
            a182 = engine.makeVariable();
            if ( !a181.Unify(new ListTerm(s123, a182), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a182.IsList() ){
            a183 = ((ListTerm)a182).car;
            a184 = ((ListTerm)a182).cdr;
        } else if ( a182.IsVariable() ){
            a183 = engine.makeVariable();
            a184 = engine.makeVariable();
            if ( !a182.Unify(new ListTerm(a183, a184), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a183.IsList() ){
            if ( !s124.Unify(((ListTerm)a183).car, engine.trail) )
                return engine.fail();
            a185 = ((ListTerm)a183).cdr;
        } else if ( a183.IsVariable() ){
            a185 = engine.makeVariable();
            if ( !a183.Unify(new ListTerm(s124, a185), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a185.IsList() ){
            if ( !s1.Unify(((ListTerm)a185).car, engine.trail) )
                return engine.fail();
            a186 = ((ListTerm)a185).cdr;
        } else if ( a185.IsVariable() ){
            a186 = engine.makeVariable();
            if ( !a185.Unify(new ListTerm(s1, a186), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a186.IsList() ){
            if ( !s125.Unify(((ListTerm)a186).car, engine.trail) )
                return engine.fail();
            a187 = ((ListTerm)a186).cdr;
        } else if ( a186.IsVariable() ){
            a187 = engine.makeVariable();
            if ( !a186.Unify(new ListTerm(s125, a187), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a187.IsList() ){
            if ( !s12.Unify(((ListTerm)a187).car, engine.trail) )
                return engine.fail();
            a188 = ((ListTerm)a187).cdr;
        } else if ( a187.IsVariable() ){
            a188 = engine.makeVariable();
            if ( !a187.Unify(new ListTerm(s12, a188), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a188.IsList() ){
            if ( !s126.Unify(((ListTerm)a188).car, engine.trail) )
                return engine.fail();
            a189 = ((ListTerm)a188).cdr;
        } else if ( a188.IsVariable() ){
            a189 = engine.makeVariable();
            if ( !a188.Unify(new ListTerm(s126, a189), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a189.IsList() ){
            if ( !s1.Unify(((ListTerm)a189).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a189).cdr, engine.trail) )
                return engine.fail();
        } else if ( a189.IsVariable() ){
            if ( !a189.Unify(new ListTerm(s1, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a184.IsList() ){
            a190 = ((ListTerm)a184).car;
            if ( !s3.Unify(((ListTerm)a184).cdr, engine.trail) )
                return engine.fail();
        } else if ( a184.IsVariable() ){
            a190 = engine.makeVariable();
            if ( !a184.Unify(new ListTerm(a190, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a190.IsList() ){
            if ( !s9.Unify(((ListTerm)a190).car, engine.trail) )
                return engine.fail();
            a191 = ((ListTerm)a190).cdr;
        } else if ( a190.IsVariable() ){
            a191 = engine.makeVariable();
            if ( !a190.Unify(new ListTerm(s9, a191), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a191.IsList() ){
            if ( !s1.Unify(((ListTerm)a191).car, engine.trail) )
                return engine.fail();
            a192 = ((ListTerm)a191).cdr;
        } else if ( a191.IsVariable() ){
            a192 = engine.makeVariable();
            if ( !a191.Unify(new ListTerm(s1, a192), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a192.IsList() ){
            if ( !s24.Unify(((ListTerm)a192).car, engine.trail) )
                return engine.fail();
            a193 = ((ListTerm)a192).cdr;
        } else if ( a192.IsVariable() ){
            a193 = engine.makeVariable();
            if ( !a192.Unify(new ListTerm(s24, a193), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a193.IsList() ){
            if ( !s127.Unify(((ListTerm)a193).car, engine.trail) )
                return engine.fail();
            if ( !a189.Unify(((ListTerm)a193).cdr, engine.trail) )
                return engine.fail();
        } else if ( a193.IsVariable() ){
            if ( !a193.Unify(new ListTerm(s127, a189), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a189.IsList() ){
            if ( !s1.Unify(((ListTerm)a189).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a189).cdr, engine.trail) )
                return engine.fail();
        } else if ( a189.IsVariable() ){
            if ( !a189.Unify(new ListTerm(s1, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a168.IsList() ){
            a194 = ((ListTerm)a168).car;
            a195 = ((ListTerm)a168).cdr;
        } else if ( a168.IsVariable() ){
            a194 = engine.makeVariable();
            a195 = engine.makeVariable();
            if ( !a168.Unify(new ListTerm(a194, a195), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a194.IsList() ){
            if ( !s128.Unify(((ListTerm)a194).car, engine.trail) )
                return engine.fail();
            a196 = ((ListTerm)a194).cdr;
        } else if ( a194.IsVariable() ){
            a196 = engine.makeVariable();
            if ( !a194.Unify(new ListTerm(s128, a196), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a196.IsList() ){
            a197 = ((ListTerm)a196).car;
            if ( !s132.Unify(((ListTerm)a196).cdr, engine.trail) )
                return engine.fail();
        } else if ( a196.IsVariable() ){
            a197 = engine.makeVariable();
            if ( !a196.Unify(new ListTerm(a197, s132), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a197.IsList() ){
            a198 = ((ListTerm)a197).cdr;
        } else if ( a197.IsVariable() ){
            a198 = engine.makeVariable();
            if ( !a197.Unify(new ListTerm(engine.makeVariable(), a198), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a198.IsList() ){
            if ( !s1.Unify(((ListTerm)a198).car, engine.trail) )
                return engine.fail();
            a199 = ((ListTerm)a198).cdr;
        } else if ( a198.IsVariable() ){
            a199 = engine.makeVariable();
            if ( !a198.Unify(new ListTerm(s1, a199), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a199.IsList() ){
            a200 = ((ListTerm)a199).cdr;
        } else if ( a199.IsVariable() ){
            a200 = engine.makeVariable();
            if ( !a199.Unify(new ListTerm(engine.makeVariable(), a200), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a200.IsList() ){
            a201 = ((ListTerm)a200).car;
            a202 = ((ListTerm)a200).cdr;
        } else if ( a200.IsVariable() ){
            a201 = engine.makeVariable();
            a202 = engine.makeVariable();
            if ( !a200.Unify(new ListTerm(a201, a202), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a201.IsList() ){
            if ( !s92.Unify(((ListTerm)a201).car, engine.trail) )
                return engine.fail();
            a203 = ((ListTerm)a201).cdr;
        } else if ( a201.IsVariable() ){
            a203 = engine.makeVariable();
            if ( !a201.Unify(new ListTerm(s92, a203), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a203.IsList() ){
            if ( !s42.Unify(((ListTerm)a203).car, engine.trail) )
                return engine.fail();
            a204 = ((ListTerm)a203).cdr;
        } else if ( a203.IsVariable() ){
            a204 = engine.makeVariable();
            if ( !a203.Unify(new ListTerm(s42, a204), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a204.IsList() ){
            if ( !s116.Unify(((ListTerm)a204).car, engine.trail) )
                return engine.fail();
            a205 = ((ListTerm)a204).cdr;
        } else if ( a204.IsVariable() ){
            a205 = engine.makeVariable();
            if ( !a204.Unify(new ListTerm(s116, a205), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a205.IsList() ){
            if ( !s117.Unify(((ListTerm)a205).car, engine.trail) )
                return engine.fail();
            a206 = ((ListTerm)a205).cdr;
        } else if ( a205.IsVariable() ){
            a206 = engine.makeVariable();
            if ( !a205.Unify(new ListTerm(s117, a206), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a206.IsList() ){
            if ( !s40.Unify(((ListTerm)a206).car, engine.trail) )
                return engine.fail();
            a207 = ((ListTerm)a206).cdr;
        } else if ( a206.IsVariable() ){
            a207 = engine.makeVariable();
            if ( !a206.Unify(new ListTerm(s40, a207), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a207.IsList() ){
            if ( !s3.Unify(((ListTerm)a207).cdr, engine.trail) )
                return engine.fail();
        } else if ( a207.IsVariable() ){
            if ( !a207.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a202.IsList() ){
            a208 = ((ListTerm)a202).cdr;
        } else if ( a202.IsVariable() ){
            a208 = engine.makeVariable();
            if ( !a202.Unify(new ListTerm(engine.makeVariable(), a208), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a208.IsList() ){
            if ( !s74.Unify(((ListTerm)a208).car, engine.trail) )
                return engine.fail();
            a209 = ((ListTerm)a208).cdr;
        } else if ( a208.IsVariable() ){
            a209 = engine.makeVariable();
            if ( !a208.Unify(new ListTerm(s74, a209), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a209.IsList() ){
            if ( !s3.Unify(((ListTerm)a209).cdr, engine.trail) )
                return engine.fail();
        } else if ( a209.IsVariable() ){
            if ( !a209.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a195.IsList() ){
            a210 = ((ListTerm)a195).car;
            a211 = ((ListTerm)a195).cdr;
        } else if ( a195.IsVariable() ){
            a210 = engine.makeVariable();
            a211 = engine.makeVariable();
            if ( !a195.Unify(new ListTerm(a210, a211), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a210.IsList() ){
            if ( !s133.Unify(((ListTerm)a210).car, engine.trail) )
                return engine.fail();
            a212 = ((ListTerm)a210).cdr;
        } else if ( a210.IsVariable() ){
            a212 = engine.makeVariable();
            if ( !a210.Unify(new ListTerm(s133, a212), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a212.IsList() ){
            a213 = ((ListTerm)a212).car;
            a214 = ((ListTerm)a212).cdr;
        } else if ( a212.IsVariable() ){
            a213 = engine.makeVariable();
            a214 = engine.makeVariable();
            if ( !a212.Unify(new ListTerm(a213, a214), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a213.IsList() ){
            a215 = ((ListTerm)a213).cdr;
        } else if ( a213.IsVariable() ){
            a215 = engine.makeVariable();
            if ( !a213.Unify(new ListTerm(engine.makeVariable(), a215), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a215.IsList() ){
            if ( !s134.Unify(((ListTerm)a215).car, engine.trail) )
                return engine.fail();
            a216 = ((ListTerm)a215).cdr;
        } else if ( a215.IsVariable() ){
            a216 = engine.makeVariable();
            if ( !a215.Unify(new ListTerm(s134, a216), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a216.IsList() ){
            a217 = ((ListTerm)a216).cdr;
        } else if ( a216.IsVariable() ){
            a217 = engine.makeVariable();
            if ( !a216.Unify(new ListTerm(engine.makeVariable(), a217), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a217.IsList() ){
            a218 = ((ListTerm)a217).car;
            a219 = ((ListTerm)a217).cdr;
        } else if ( a217.IsVariable() ){
            a218 = engine.makeVariable();
            a219 = engine.makeVariable();
            if ( !a217.Unify(new ListTerm(a218, a219), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a218.IsList() ){
            if ( !s92.Unify(((ListTerm)a218).car, engine.trail) )
                return engine.fail();
            a220 = ((ListTerm)a218).cdr;
        } else if ( a218.IsVariable() ){
            a220 = engine.makeVariable();
            if ( !a218.Unify(new ListTerm(s92, a220), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a220.IsList() ){
            if ( !s135.Unify(((ListTerm)a220).car, engine.trail) )
                return engine.fail();
            a221 = ((ListTerm)a220).cdr;
        } else if ( a220.IsVariable() ){
            a221 = engine.makeVariable();
            if ( !a220.Unify(new ListTerm(s135, a221), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a221.IsList() ){
            if ( !s136.Unify(((ListTerm)a221).car, engine.trail) )
                return engine.fail();
            a222 = ((ListTerm)a221).cdr;
        } else if ( a221.IsVariable() ){
            a222 = engine.makeVariable();
            if ( !a221.Unify(new ListTerm(s136, a222), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a222.IsList() ){
            if ( !s137.Unify(((ListTerm)a222).car, engine.trail) )
                return engine.fail();
            a223 = ((ListTerm)a222).cdr;
        } else if ( a222.IsVariable() ){
            a223 = engine.makeVariable();
            if ( !a222.Unify(new ListTerm(s137, a223), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a223.IsList() ){
            if ( !s138.Unify(((ListTerm)a223).car, engine.trail) )
                return engine.fail();
            a224 = ((ListTerm)a223).cdr;
        } else if ( a223.IsVariable() ){
            a224 = engine.makeVariable();
            if ( !a223.Unify(new ListTerm(s138, a224), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a224.IsList() ){
            a225 = ((ListTerm)a224).car;
            if ( !s3.Unify(((ListTerm)a224).cdr, engine.trail) )
                return engine.fail();
        } else if ( a224.IsVariable() ){
            a225 = engine.makeVariable();
            if ( !a224.Unify(new ListTerm(a225, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a219.IsList() ){
            if ( !s3.Unify(((ListTerm)a219).cdr, engine.trail) )
                return engine.fail();
        } else if ( a219.IsVariable() ){
            if ( !a219.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a214.IsList() ){
            if ( !s2.Unify(((ListTerm)a214).car, engine.trail) )
                return engine.fail();
            a226 = ((ListTerm)a214).cdr;
        } else if ( a214.IsVariable() ){
            a226 = engine.makeVariable();
            if ( !a214.Unify(new ListTerm(s2, a226), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a226.IsList() ){
            a227 = ((ListTerm)a226).car;
            a228 = ((ListTerm)a226).cdr;
        } else if ( a226.IsVariable() ){
            a227 = engine.makeVariable();
            a228 = engine.makeVariable();
            if ( !a226.Unify(new ListTerm(a227, a228), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a227.IsList() ){
            if ( !s139.Unify(((ListTerm)a227).car, engine.trail) )
                return engine.fail();
            a229 = ((ListTerm)a227).cdr;
        } else if ( a227.IsVariable() ){
            a229 = engine.makeVariable();
            if ( !a227.Unify(new ListTerm(s139, a229), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a229.IsList() ){
            if ( !s140.Unify(((ListTerm)a229).car, engine.trail) )
                return engine.fail();
            a230 = ((ListTerm)a229).cdr;
        } else if ( a229.IsVariable() ){
            a230 = engine.makeVariable();
            if ( !a229.Unify(new ListTerm(s140, a230), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a230.IsList() ){
            if ( !s141.Unify(((ListTerm)a230).car, engine.trail) )
                return engine.fail();
            a231 = ((ListTerm)a230).cdr;
        } else if ( a230.IsVariable() ){
            a231 = engine.makeVariable();
            if ( !a230.Unify(new ListTerm(s141, a231), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a231.IsList() ){
            if ( !s26.Unify(((ListTerm)a231).car, engine.trail) )
                return engine.fail();
            a232 = ((ListTerm)a231).cdr;
        } else if ( a231.IsVariable() ){
            a232 = engine.makeVariable();
            if ( !a231.Unify(new ListTerm(s26, a232), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a232.IsList() ){
            if ( !s142.Unify(((ListTerm)a232).car, engine.trail) )
                return engine.fail();
            a233 = ((ListTerm)a232).cdr;
        } else if ( a232.IsVariable() ){
            a233 = engine.makeVariable();
            if ( !a232.Unify(new ListTerm(s142, a233), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a233.IsList() ){
            if ( !s1.Unify(((ListTerm)a233).car, engine.trail) )
                return engine.fail();
            a234 = ((ListTerm)a233).cdr;
        } else if ( a233.IsVariable() ){
            a234 = engine.makeVariable();
            if ( !a233.Unify(new ListTerm(s1, a234), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a234.IsList() ){
            if ( !s125.Unify(((ListTerm)a234).car, engine.trail) )
                return engine.fail();
            a235 = ((ListTerm)a234).cdr;
        } else if ( a234.IsVariable() ){
            a235 = engine.makeVariable();
            if ( !a234.Unify(new ListTerm(s125, a235), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a235.IsList() ){
            if ( !a225.Unify(((ListTerm)a235).car, engine.trail) )
                return engine.fail();
            if ( !s50.Unify(((ListTerm)a235).cdr, engine.trail) )
                return engine.fail();
        } else if ( a235.IsVariable() ){
            if ( !a235.Unify(new ListTerm(a225, s50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a228.IsList() ){
            a236 = ((ListTerm)a228).car;
            a237 = ((ListTerm)a228).cdr;
        } else if ( a228.IsVariable() ){
            a236 = engine.makeVariable();
            a237 = engine.makeVariable();
            if ( !a228.Unify(new ListTerm(a236, a237), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a236.IsList() ){
            if ( !s9.Unify(((ListTerm)a236).car, engine.trail) )
                return engine.fail();
            a238 = ((ListTerm)a236).cdr;
        } else if ( a236.IsVariable() ){
            a238 = engine.makeVariable();
            if ( !a236.Unify(new ListTerm(s9, a238), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a238.IsList() ){
            if ( !s1.Unify(((ListTerm)a238).car, engine.trail) )
                return engine.fail();
            a239 = ((ListTerm)a238).cdr;
        } else if ( a238.IsVariable() ){
            a239 = engine.makeVariable();
            if ( !a238.Unify(new ListTerm(s1, a239), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a239.IsList() ){
            if ( !s116.Unify(((ListTerm)a239).car, engine.trail) )
                return engine.fail();
            a240 = ((ListTerm)a239).cdr;
        } else if ( a239.IsVariable() ){
            a240 = engine.makeVariable();
            if ( !a239.Unify(new ListTerm(s116, a240), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a240.IsList() ){
            if ( !s143.Unify(((ListTerm)a240).car, engine.trail) )
                return engine.fail();
            a241 = ((ListTerm)a240).cdr;
        } else if ( a240.IsVariable() ){
            a241 = engine.makeVariable();
            if ( !a240.Unify(new ListTerm(s143, a241), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a241.IsList() ){
            if ( !s144.Unify(((ListTerm)a241).car, engine.trail) )
                return engine.fail();
            a242 = ((ListTerm)a241).cdr;
        } else if ( a241.IsVariable() ){
            a242 = engine.makeVariable();
            if ( !a241.Unify(new ListTerm(s144, a242), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a242.IsList() ){
            if ( !s145.Unify(((ListTerm)a242).car, engine.trail) )
                return engine.fail();
            a243 = ((ListTerm)a242).cdr;
        } else if ( a242.IsVariable() ){
            a243 = engine.makeVariable();
            if ( !a242.Unify(new ListTerm(s145, a243), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a243.IsList() ){
            if ( !s146.Unify(((ListTerm)a243).car, engine.trail) )
                return engine.fail();
            a244 = ((ListTerm)a243).cdr;
        } else if ( a243.IsVariable() ){
            a244 = engine.makeVariable();
            if ( !a243.Unify(new ListTerm(s146, a244), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a244.IsList() ){
            if ( !s1.Unify(((ListTerm)a244).car, engine.trail) )
                return engine.fail();
            a245 = ((ListTerm)a244).cdr;
        } else if ( a244.IsVariable() ){
            a245 = engine.makeVariable();
            if ( !a244.Unify(new ListTerm(s1, a245), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a245.IsList() ){
            if ( !s12.Unify(((ListTerm)a245).car, engine.trail) )
                return engine.fail();
            a246 = ((ListTerm)a245).cdr;
        } else if ( a245.IsVariable() ){
            a246 = engine.makeVariable();
            if ( !a245.Unify(new ListTerm(s12, a246), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a246.IsList() ){
            if ( !s26.Unify(((ListTerm)a246).car, engine.trail) )
                return engine.fail();
            a247 = ((ListTerm)a246).cdr;
        } else if ( a246.IsVariable() ){
            a247 = engine.makeVariable();
            if ( !a246.Unify(new ListTerm(s26, a247), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a247.IsList() ){
            if ( !s27.Unify(((ListTerm)a247).car, engine.trail) )
                return engine.fail();
            a248 = ((ListTerm)a247).cdr;
        } else if ( a247.IsVariable() ){
            a248 = engine.makeVariable();
            if ( !a247.Unify(new ListTerm(s27, a248), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a248.IsList() ){
            if ( !a225.Unify(((ListTerm)a248).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a248).cdr, engine.trail) )
                return engine.fail();
        } else if ( a248.IsVariable() ){
            if ( !a248.Unify(new ListTerm(a225, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a237.IsList() ){
            a249 = ((ListTerm)a237).car;
            a250 = ((ListTerm)a237).cdr;
        } else if ( a237.IsVariable() ){
            a249 = engine.makeVariable();
            a250 = engine.makeVariable();
            if ( !a237.Unify(new ListTerm(a249, a250), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a249.IsList() ){
            if ( !s139.Unify(((ListTerm)a249).car, engine.trail) )
                return engine.fail();
            a251 = ((ListTerm)a249).cdr;
        } else if ( a249.IsVariable() ){
            a251 = engine.makeVariable();
            if ( !a249.Unify(new ListTerm(s139, a251), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a251.IsList() ){
            if ( !s140.Unify(((ListTerm)a251).car, engine.trail) )
                return engine.fail();
            a252 = ((ListTerm)a251).cdr;
        } else if ( a251.IsVariable() ){
            a252 = engine.makeVariable();
            if ( !a251.Unify(new ListTerm(s140, a252), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a252.IsList() ){
            if ( !s126.Unify(((ListTerm)a252).car, engine.trail) )
                return engine.fail();
            a253 = ((ListTerm)a252).cdr;
        } else if ( a252.IsVariable() ){
            a253 = engine.makeVariable();
            if ( !a252.Unify(new ListTerm(s126, a253), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a253.IsList() ){
            if ( !s94.Unify(((ListTerm)a253).car, engine.trail) )
                return engine.fail();
            a254 = ((ListTerm)a253).cdr;
        } else if ( a253.IsVariable() ){
            a254 = engine.makeVariable();
            if ( !a253.Unify(new ListTerm(s94, a254), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a254.IsList() ){
            if ( !s147.Unify(((ListTerm)a254).car, engine.trail) )
                return engine.fail();
            a255 = ((ListTerm)a254).cdr;
        } else if ( a254.IsVariable() ){
            a255 = engine.makeVariable();
            if ( !a254.Unify(new ListTerm(s147, a255), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a255.IsList() ){
            if ( !s12.Unify(((ListTerm)a255).car, engine.trail) )
                return engine.fail();
            a256 = ((ListTerm)a255).cdr;
        } else if ( a255.IsVariable() ){
            a256 = engine.makeVariable();
            if ( !a255.Unify(new ListTerm(s12, a256), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a256.IsList() ){
            if ( !s148.Unify(((ListTerm)a256).car, engine.trail) )
                return engine.fail();
            a257 = ((ListTerm)a256).cdr;
        } else if ( a256.IsVariable() ){
            a257 = engine.makeVariable();
            if ( !a256.Unify(new ListTerm(s148, a257), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a257.IsList() ){
            if ( !s26.Unify(((ListTerm)a257).car, engine.trail) )
                return engine.fail();
            a258 = ((ListTerm)a257).cdr;
        } else if ( a257.IsVariable() ){
            a258 = engine.makeVariable();
            if ( !a257.Unify(new ListTerm(s26, a258), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a258.IsList() ){
            if ( !s27.Unify(((ListTerm)a258).car, engine.trail) )
                return engine.fail();
            if ( !a235.Unify(((ListTerm)a258).cdr, engine.trail) )
                return engine.fail();
        } else if ( a258.IsVariable() ){
            if ( !a258.Unify(new ListTerm(s27, a235), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a235.IsList() ){
            if ( !a225.Unify(((ListTerm)a235).car, engine.trail) )
                return engine.fail();
            if ( !s50.Unify(((ListTerm)a235).cdr, engine.trail) )
                return engine.fail();
        } else if ( a235.IsVariable() ){
            if ( !a235.Unify(new ListTerm(a225, s50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a250.IsList() ){
            a259 = ((ListTerm)a250).car;
            if ( !s3.Unify(((ListTerm)a250).cdr, engine.trail) )
                return engine.fail();
        } else if ( a250.IsVariable() ){
            a259 = engine.makeVariable();
            if ( !a250.Unify(new ListTerm(a259, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a259.IsList() ){
            if ( !s11.Unify(((ListTerm)a259).car, engine.trail) )
                return engine.fail();
            a260 = ((ListTerm)a259).cdr;
        } else if ( a259.IsVariable() ){
            a260 = engine.makeVariable();
            if ( !a259.Unify(new ListTerm(s11, a260), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a260.IsList() ){
            if ( !s1.Unify(((ListTerm)a260).car, engine.trail) )
                return engine.fail();
            a261 = ((ListTerm)a260).cdr;
        } else if ( a260.IsVariable() ){
            a261 = engine.makeVariable();
            if ( !a260.Unify(new ListTerm(s1, a261), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a261.IsList() ){
            if ( !s149.Unify(((ListTerm)a261).car, engine.trail) )
                return engine.fail();
            a262 = ((ListTerm)a261).cdr;
        } else if ( a261.IsVariable() ){
            a262 = engine.makeVariable();
            if ( !a261.Unify(new ListTerm(s149, a262), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a262.IsList() ){
            if ( !s61.Unify(((ListTerm)a262).car, engine.trail) )
                return engine.fail();
            a263 = ((ListTerm)a262).cdr;
        } else if ( a262.IsVariable() ){
            a263 = engine.makeVariable();
            if ( !a262.Unify(new ListTerm(s61, a263), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a263.IsList() ){
            if ( !s150.Unify(((ListTerm)a263).car, engine.trail) )
                return engine.fail();
            a264 = ((ListTerm)a263).cdr;
        } else if ( a263.IsVariable() ){
            a264 = engine.makeVariable();
            if ( !a263.Unify(new ListTerm(s150, a264), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a264.IsList() ){
            if ( !s1.Unify(((ListTerm)a264).car, engine.trail) )
                return engine.fail();
            if ( !a248.Unify(((ListTerm)a264).cdr, engine.trail) )
                return engine.fail();
        } else if ( a264.IsVariable() ){
            if ( !a264.Unify(new ListTerm(s1, a248), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a248.IsList() ){
            if ( !a225.Unify(((ListTerm)a248).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a248).cdr, engine.trail) )
                return engine.fail();
        } else if ( a248.IsVariable() ){
            if ( !a248.Unify(new ListTerm(a225, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a211.IsList() ){
            a265 = ((ListTerm)a211).car;
            a266 = ((ListTerm)a211).cdr;
        } else if ( a211.IsVariable() ){
            a265 = engine.makeVariable();
            a266 = engine.makeVariable();
            if ( !a211.Unify(new ListTerm(a265, a266), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a265.IsList() ){
            if ( !s151.Unify(((ListTerm)a265).car, engine.trail) )
                return engine.fail();
            a267 = ((ListTerm)a265).cdr;
        } else if ( a265.IsVariable() ){
            a267 = engine.makeVariable();
            if ( !a265.Unify(new ListTerm(s151, a267), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a267.IsList() ){
            a268 = ((ListTerm)a267).car;
            a269 = ((ListTerm)a267).cdr;
        } else if ( a267.IsVariable() ){
            a268 = engine.makeVariable();
            a269 = engine.makeVariable();
            if ( !a267.Unify(new ListTerm(a268, a269), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a268.IsList() ){
            a270 = ((ListTerm)a268).cdr;
        } else if ( a268.IsVariable() ){
            a270 = engine.makeVariable();
            if ( !a268.Unify(new ListTerm(engine.makeVariable(), a270), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a270.IsList() ){
            if ( !s134.Unify(((ListTerm)a270).car, engine.trail) )
                return engine.fail();
            a271 = ((ListTerm)a270).cdr;
        } else if ( a270.IsVariable() ){
            a271 = engine.makeVariable();
            if ( !a270.Unify(new ListTerm(s134, a271), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a271.IsList() ){
            a272 = ((ListTerm)a271).cdr;
        } else if ( a271.IsVariable() ){
            a272 = engine.makeVariable();
            if ( !a271.Unify(new ListTerm(engine.makeVariable(), a272), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a272.IsList() ){
            a273 = ((ListTerm)a272).car;
            a274 = ((ListTerm)a272).cdr;
        } else if ( a272.IsVariable() ){
            a273 = engine.makeVariable();
            a274 = engine.makeVariable();
            if ( !a272.Unify(new ListTerm(a273, a274), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a273.IsList() ){
            if ( !s92.Unify(((ListTerm)a273).car, engine.trail) )
                return engine.fail();
            a275 = ((ListTerm)a273).cdr;
        } else if ( a273.IsVariable() ){
            a275 = engine.makeVariable();
            if ( !a273.Unify(new ListTerm(s92, a275), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a275.IsList() ){
            if ( !s152.Unify(((ListTerm)a275).car, engine.trail) )
                return engine.fail();
            a276 = ((ListTerm)a275).cdr;
        } else if ( a275.IsVariable() ){
            a276 = engine.makeVariable();
            if ( !a275.Unify(new ListTerm(s152, a276), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a276.IsList() ){
            if ( !s153.Unify(((ListTerm)a276).car, engine.trail) )
                return engine.fail();
            a277 = ((ListTerm)a276).cdr;
        } else if ( a276.IsVariable() ){
            a277 = engine.makeVariable();
            if ( !a276.Unify(new ListTerm(s153, a277), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a277.IsList() ){
            if ( !s154.Unify(((ListTerm)a277).car, engine.trail) )
                return engine.fail();
            a278 = ((ListTerm)a277).cdr;
        } else if ( a277.IsVariable() ){
            a278 = engine.makeVariable();
            if ( !a277.Unify(new ListTerm(s154, a278), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a278.IsList() ){
            if ( !s155.Unify(((ListTerm)a278).car, engine.trail) )
                return engine.fail();
            if ( !a224.Unify(((ListTerm)a278).cdr, engine.trail) )
                return engine.fail();
        } else if ( a278.IsVariable() ){
            if ( !a278.Unify(new ListTerm(s155, a224), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a224.IsList() ){
            if ( !a225.Unify(((ListTerm)a224).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a224).cdr, engine.trail) )
                return engine.fail();
        } else if ( a224.IsVariable() ){
            if ( !a224.Unify(new ListTerm(a225, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a274.IsList() ){
            if ( !s3.Unify(((ListTerm)a274).cdr, engine.trail) )
                return engine.fail();
        } else if ( a274.IsVariable() ){
            if ( !a274.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a269.IsList() ){
            if ( !s2.Unify(((ListTerm)a269).car, engine.trail) )
                return engine.fail();
            a279 = ((ListTerm)a269).cdr;
        } else if ( a269.IsVariable() ){
            a279 = engine.makeVariable();
            if ( !a269.Unify(new ListTerm(s2, a279), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a279.IsList() ){
            a280 = ((ListTerm)a279).car;
            a281 = ((ListTerm)a279).cdr;
        } else if ( a279.IsVariable() ){
            a280 = engine.makeVariable();
            a281 = engine.makeVariable();
            if ( !a279.Unify(new ListTerm(a280, a281), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a280.IsList() ){
            if ( !s8.Unify(((ListTerm)a280).car, engine.trail) )
                return engine.fail();
            a282 = ((ListTerm)a280).cdr;
        } else if ( a280.IsVariable() ){
            a282 = engine.makeVariable();
            if ( !a280.Unify(new ListTerm(s8, a282), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a282.IsList() ){
            if ( !s15.Unify(((ListTerm)a282).car, engine.trail) )
                return engine.fail();
            a283 = ((ListTerm)a282).cdr;
        } else if ( a282.IsVariable() ){
            a283 = engine.makeVariable();
            if ( !a282.Unify(new ListTerm(s15, a283), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a283.IsList() ){
            if ( !s139.Unify(((ListTerm)a283).car, engine.trail) )
                return engine.fail();
            a284 = ((ListTerm)a283).cdr;
        } else if ( a283.IsVariable() ){
            a284 = engine.makeVariable();
            if ( !a283.Unify(new ListTerm(s139, a284), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a284.IsList() ){
            if ( !s156.Unify(((ListTerm)a284).car, engine.trail) )
                return engine.fail();
            a285 = ((ListTerm)a284).cdr;
        } else if ( a284.IsVariable() ){
            a285 = engine.makeVariable();
            if ( !a284.Unify(new ListTerm(s156, a285), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a285.IsList() ){
            if ( !s1.Unify(((ListTerm)a285).car, engine.trail) )
                return engine.fail();
            if ( !a246.Unify(((ListTerm)a285).cdr, engine.trail) )
                return engine.fail();
        } else if ( a285.IsVariable() ){
            if ( !a285.Unify(new ListTerm(s1, a246), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a246.IsList() ){
            if ( !s26.Unify(((ListTerm)a246).car, engine.trail) )
                return engine.fail();
            if ( !a247.Unify(((ListTerm)a246).cdr, engine.trail) )
                return engine.fail();
        } else if ( a246.IsVariable() ){
            if ( !a246.Unify(new ListTerm(s26, a247), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a247.IsList() ){
            if ( !s27.Unify(((ListTerm)a247).car, engine.trail) )
                return engine.fail();
            if ( !a248.Unify(((ListTerm)a247).cdr, engine.trail) )
                return engine.fail();
        } else if ( a247.IsVariable() ){
            if ( !a247.Unify(new ListTerm(s27, a248), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a248.IsList() ){
            if ( !a225.Unify(((ListTerm)a248).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a248).cdr, engine.trail) )
                return engine.fail();
        } else if ( a248.IsVariable() ){
            if ( !a248.Unify(new ListTerm(a225, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a281.IsList() ){
            a286 = ((ListTerm)a281).car;
            a287 = ((ListTerm)a281).cdr;
        } else if ( a281.IsVariable() ){
            a286 = engine.makeVariable();
            a287 = engine.makeVariable();
            if ( !a281.Unify(new ListTerm(a286, a287), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a286.IsList() ){
            if ( !s157.Unify(((ListTerm)a286).car, engine.trail) )
                return engine.fail();
            a288 = ((ListTerm)a286).cdr;
        } else if ( a286.IsVariable() ){
            a288 = engine.makeVariable();
            if ( !a286.Unify(new ListTerm(s157, a288), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a288.IsList() ){
            if ( !s76.Unify(((ListTerm)a288).car, engine.trail) )
                return engine.fail();
            a289 = ((ListTerm)a288).cdr;
        } else if ( a288.IsVariable() ){
            a289 = engine.makeVariable();
            if ( !a288.Unify(new ListTerm(s76, a289), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a289.IsList() ){
            if ( !s158.Unify(((ListTerm)a289).car, engine.trail) )
                return engine.fail();
            if ( !a263.Unify(((ListTerm)a289).cdr, engine.trail) )
                return engine.fail();
        } else if ( a289.IsVariable() ){
            if ( !a289.Unify(new ListTerm(s158, a263), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a263.IsList() ){
            if ( !s150.Unify(((ListTerm)a263).car, engine.trail) )
                return engine.fail();
            if ( !a264.Unify(((ListTerm)a263).cdr, engine.trail) )
                return engine.fail();
        } else if ( a263.IsVariable() ){
            if ( !a263.Unify(new ListTerm(s150, a264), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a264.IsList() ){
            if ( !s1.Unify(((ListTerm)a264).car, engine.trail) )
                return engine.fail();
            if ( !a248.Unify(((ListTerm)a264).cdr, engine.trail) )
                return engine.fail();
        } else if ( a264.IsVariable() ){
            if ( !a264.Unify(new ListTerm(s1, a248), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a248.IsList() ){
            if ( !a225.Unify(((ListTerm)a248).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a248).cdr, engine.trail) )
                return engine.fail();
        } else if ( a248.IsVariable() ){
            if ( !a248.Unify(new ListTerm(a225, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a287.IsList() ){
            a290 = ((ListTerm)a287).car;
            a291 = ((ListTerm)a287).cdr;
        } else if ( a287.IsVariable() ){
            a290 = engine.makeVariable();
            a291 = engine.makeVariable();
            if ( !a287.Unify(new ListTerm(a290, a291), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a290.IsList() ){
            if ( !s61.Unify(((ListTerm)a290).car, engine.trail) )
                return engine.fail();
            a292 = ((ListTerm)a290).cdr;
        } else if ( a290.IsVariable() ){
            a292 = engine.makeVariable();
            if ( !a290.Unify(new ListTerm(s61, a292), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a292.IsList() ){
            if ( !s159.Unify(((ListTerm)a292).car, engine.trail) )
                return engine.fail();
            a293 = ((ListTerm)a292).cdr;
        } else if ( a292.IsVariable() ){
            a293 = engine.makeVariable();
            if ( !a292.Unify(new ListTerm(s159, a293), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a293.IsList() ){
            if ( !s1.Unify(((ListTerm)a293).car, engine.trail) )
                return engine.fail();
            a294 = ((ListTerm)a293).cdr;
        } else if ( a293.IsVariable() ){
            a294 = engine.makeVariable();
            if ( !a293.Unify(new ListTerm(s1, a294), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a294.IsList() ){
            if ( !a225.Unify(((ListTerm)a294).car, engine.trail) )
                return engine.fail();
            if ( !s161.Unify(((ListTerm)a294).cdr, engine.trail) )
                return engine.fail();
        } else if ( a294.IsVariable() ){
            if ( !a294.Unify(new ListTerm(a225, s161), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a291.IsList() ){
            a295 = ((ListTerm)a291).car;
            if ( !s3.Unify(((ListTerm)a291).cdr, engine.trail) )
                return engine.fail();
        } else if ( a291.IsVariable() ){
            a295 = engine.makeVariable();
            if ( !a291.Unify(new ListTerm(a295, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a295.IsList() ){
            if ( !s11.Unify(((ListTerm)a295).car, engine.trail) )
                return engine.fail();
            a296 = ((ListTerm)a295).cdr;
        } else if ( a295.IsVariable() ){
            a296 = engine.makeVariable();
            if ( !a295.Unify(new ListTerm(s11, a296), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a296.IsList() ){
            if ( !s1.Unify(((ListTerm)a296).car, engine.trail) )
                return engine.fail();
            a297 = ((ListTerm)a296).cdr;
        } else if ( a296.IsVariable() ){
            a297 = engine.makeVariable();
            if ( !a296.Unify(new ListTerm(s1, a297), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a297.IsList() ){
            if ( !s149.Unify(((ListTerm)a297).car, engine.trail) )
                return engine.fail();
            a298 = ((ListTerm)a297).cdr;
        } else if ( a297.IsVariable() ){
            a298 = engine.makeVariable();
            if ( !a297.Unify(new ListTerm(s149, a298), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a298.IsList() ){
            if ( !s31.Unify(((ListTerm)a298).car, engine.trail) )
                return engine.fail();
            a299 = ((ListTerm)a298).cdr;
        } else if ( a298.IsVariable() ){
            a299 = engine.makeVariable();
            if ( !a298.Unify(new ListTerm(s31, a299), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a299.IsList() ){
            if ( !s1.Unify(((ListTerm)a299).car, engine.trail) )
                return engine.fail();
            a300 = ((ListTerm)a299).cdr;
        } else if ( a299.IsVariable() ){
            a300 = engine.makeVariable();
            if ( !a299.Unify(new ListTerm(s1, a300), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a300.IsList() ){
            if ( !s125.Unify(((ListTerm)a300).car, engine.trail) )
                return engine.fail();
            a301 = ((ListTerm)a300).cdr;
        } else if ( a300.IsVariable() ){
            a301 = engine.makeVariable();
            if ( !a300.Unify(new ListTerm(s125, a301), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a301.IsList() ){
            if ( !s162.Unify(((ListTerm)a301).car, engine.trail) )
                return engine.fail();
            if ( !a248.Unify(((ListTerm)a301).cdr, engine.trail) )
                return engine.fail();
        } else if ( a301.IsVariable() ){
            if ( !a301.Unify(new ListTerm(s162, a248), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a248.IsList() ){
            if ( !a225.Unify(((ListTerm)a248).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a248).cdr, engine.trail) )
                return engine.fail();
        } else if ( a248.IsVariable() ){
            if ( !a248.Unify(new ListTerm(a225, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a266.IsList() ){
            a302 = ((ListTerm)a266).car;
            a303 = ((ListTerm)a266).cdr;
        } else if ( a266.IsVariable() ){
            a302 = engine.makeVariable();
            a303 = engine.makeVariable();
            if ( !a266.Unify(new ListTerm(a302, a303), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a302.IsList() ){
            if ( !s163.Unify(((ListTerm)a302).car, engine.trail) )
                return engine.fail();
            a304 = ((ListTerm)a302).cdr;
        } else if ( a302.IsVariable() ){
            a304 = engine.makeVariable();
            if ( !a302.Unify(new ListTerm(s163, a304), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a304.IsList() ){
            a305 = ((ListTerm)a304).car;
            a306 = ((ListTerm)a304).cdr;
        } else if ( a304.IsVariable() ){
            a305 = engine.makeVariable();
            a306 = engine.makeVariable();
            if ( !a304.Unify(new ListTerm(a305, a306), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a305.IsList() ){
            a307 = ((ListTerm)a305).cdr;
        } else if ( a305.IsVariable() ){
            a307 = engine.makeVariable();
            if ( !a305.Unify(new ListTerm(engine.makeVariable(), a307), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a307.IsList() ){
            if ( !s134.Unify(((ListTerm)a307).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a307).cdr, engine.trail) )
                return engine.fail();
        } else if ( a307.IsVariable() ){
            if ( !a307.Unify(new ListTerm(s134, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a306.IsList() ){
            if ( !s2.Unify(((ListTerm)a306).car, engine.trail) )
                return engine.fail();
            a308 = ((ListTerm)a306).cdr;
        } else if ( a306.IsVariable() ){
            a308 = engine.makeVariable();
            if ( !a306.Unify(new ListTerm(s2, a308), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a308.IsList() ){
            a309 = ((ListTerm)a308).car;
            a310 = ((ListTerm)a308).cdr;
        } else if ( a308.IsVariable() ){
            a309 = engine.makeVariable();
            a310 = engine.makeVariable();
            if ( !a308.Unify(new ListTerm(a309, a310), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a309.IsList() ){
            if ( !s147.Unify(((ListTerm)a309).car, engine.trail) )
                return engine.fail();
            a311 = ((ListTerm)a309).cdr;
        } else if ( a309.IsVariable() ){
            a311 = engine.makeVariable();
            if ( !a309.Unify(new ListTerm(s147, a311), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a311.IsList() ){
            if ( !s94.Unify(((ListTerm)a311).car, engine.trail) )
                return engine.fail();
            a312 = ((ListTerm)a311).cdr;
        } else if ( a311.IsVariable() ){
            a312 = engine.makeVariable();
            if ( !a311.Unify(new ListTerm(s94, a312), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a312.IsList() ){
            if ( !s164.Unify(((ListTerm)a312).car, engine.trail) )
                return engine.fail();
            a313 = ((ListTerm)a312).cdr;
        } else if ( a312.IsVariable() ){
            a313 = engine.makeVariable();
            if ( !a312.Unify(new ListTerm(s164, a313), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a313.IsList() ){
            if ( !s1.Unify(((ListTerm)a313).car, engine.trail) )
                return engine.fail();
            a314 = ((ListTerm)a313).cdr;
        } else if ( a313.IsVariable() ){
            a314 = engine.makeVariable();
            if ( !a313.Unify(new ListTerm(s1, a314), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a314.IsList() ){
            if ( !s125.Unify(((ListTerm)a314).car, engine.trail) )
                return engine.fail();
            a315 = ((ListTerm)a314).cdr;
        } else if ( a314.IsVariable() ){
            a315 = engine.makeVariable();
            if ( !a314.Unify(new ListTerm(s125, a315), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a315.IsList() ){
            if ( !a12.Unify(((ListTerm)a315).car, engine.trail) )
                return engine.fail();
            if ( !s169.Unify(((ListTerm)a315).cdr, engine.trail) )
                return engine.fail();
        } else if ( a315.IsVariable() ){
            if ( !a315.Unify(new ListTerm(a12, s169), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a310.IsList() ){
            a316 = ((ListTerm)a310).car;
            a317 = ((ListTerm)a310).cdr;
        } else if ( a310.IsVariable() ){
            a316 = engine.makeVariable();
            a317 = engine.makeVariable();
            if ( !a310.Unify(new ListTerm(a316, a317), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a316.IsList() ){
            if ( !s8.Unify(((ListTerm)a316).car, engine.trail) )
                return engine.fail();
            a318 = ((ListTerm)a316).cdr;
        } else if ( a316.IsVariable() ){
            a318 = engine.makeVariable();
            if ( !a316.Unify(new ListTerm(s8, a318), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a318.IsList() ){
            if ( !s170.Unify(((ListTerm)a318).car, engine.trail) )
                return engine.fail();
            a319 = ((ListTerm)a318).cdr;
        } else if ( a318.IsVariable() ){
            a319 = engine.makeVariable();
            if ( !a318.Unify(new ListTerm(s170, a319), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a319.IsList() ){
            if ( !s15.Unify(((ListTerm)a319).car, engine.trail) )
                return engine.fail();
            a320 = ((ListTerm)a319).cdr;
        } else if ( a319.IsVariable() ){
            a320 = engine.makeVariable();
            if ( !a319.Unify(new ListTerm(s15, a320), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a320.IsList() ){
            if ( !s1.Unify(((ListTerm)a320).car, engine.trail) )
                return engine.fail();
            a321 = ((ListTerm)a320).cdr;
        } else if ( a320.IsVariable() ){
            a321 = engine.makeVariable();
            if ( !a320.Unify(new ListTerm(s1, a321), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a321.IsList() ){
            if ( !s171.Unify(((ListTerm)a321).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a321).cdr, engine.trail) )
                return engine.fail();
        } else if ( a321.IsVariable() ){
            if ( !a321.Unify(new ListTerm(s171, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a317.IsList() ){
            a322 = ((ListTerm)a317).car;
            a323 = ((ListTerm)a317).cdr;
        } else if ( a317.IsVariable() ){
            a322 = engine.makeVariable();
            a323 = engine.makeVariable();
            if ( !a317.Unify(new ListTerm(a322, a323), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a322.IsList() ){
            if ( !s9.Unify(((ListTerm)a322).car, engine.trail) )
                return engine.fail();
            a324 = ((ListTerm)a322).cdr;
        } else if ( a322.IsVariable() ){
            a324 = engine.makeVariable();
            if ( !a322.Unify(new ListTerm(s9, a324), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a324.IsList() ){
            if ( !s1.Unify(((ListTerm)a324).car, engine.trail) )
                return engine.fail();
            a325 = ((ListTerm)a324).cdr;
        } else if ( a324.IsVariable() ){
            a325 = engine.makeVariable();
            if ( !a324.Unify(new ListTerm(s1, a325), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a325.IsList() ){
            if ( !s117.Unify(((ListTerm)a325).car, engine.trail) )
                return engine.fail();
            a326 = ((ListTerm)a325).cdr;
        } else if ( a325.IsVariable() ){
            a326 = engine.makeVariable();
            if ( !a325.Unify(new ListTerm(s117, a326), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a326.IsList() ){
            if ( !s94.Unify(((ListTerm)a326).car, engine.trail) )
                return engine.fail();
            a327 = ((ListTerm)a326).cdr;
        } else if ( a326.IsVariable() ){
            a327 = engine.makeVariable();
            if ( !a326.Unify(new ListTerm(s94, a327), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a327.IsList() ){
            if ( !s172.Unify(((ListTerm)a327).car, engine.trail) )
                return engine.fail();
            a328 = ((ListTerm)a327).cdr;
        } else if ( a327.IsVariable() ){
            a328 = engine.makeVariable();
            if ( !a327.Unify(new ListTerm(s172, a328), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a328.IsList() ){
            if ( !s26.Unify(((ListTerm)a328).car, engine.trail) )
                return engine.fail();
            a329 = ((ListTerm)a328).cdr;
        } else if ( a328.IsVariable() ){
            a329 = engine.makeVariable();
            if ( !a328.Unify(new ListTerm(s26, a329), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a329.IsList() ){
            if ( !s27.Unify(((ListTerm)a329).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a329).cdr, engine.trail) )
                return engine.fail();
        } else if ( a329.IsVariable() ){
            if ( !a329.Unify(new ListTerm(s27, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a323.IsList() ){
            a330 = ((ListTerm)a323).car;
            if ( !s3.Unify(((ListTerm)a323).cdr, engine.trail) )
                return engine.fail();
        } else if ( a323.IsVariable() ){
            a330 = engine.makeVariable();
            if ( !a323.Unify(new ListTerm(a330, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a330.IsList() ){
            if ( !s9.Unify(((ListTerm)a330).car, engine.trail) )
                return engine.fail();
            a331 = ((ListTerm)a330).cdr;
        } else if ( a330.IsVariable() ){
            a331 = engine.makeVariable();
            if ( !a330.Unify(new ListTerm(s9, a331), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a331.IsList() ){
            if ( !s1.Unify(((ListTerm)a331).car, engine.trail) )
                return engine.fail();
            a332 = ((ListTerm)a331).cdr;
        } else if ( a331.IsVariable() ){
            a332 = engine.makeVariable();
            if ( !a331.Unify(new ListTerm(s1, a332), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a332.IsList() ){
            if ( !s58.Unify(((ListTerm)a332).car, engine.trail) )
                return engine.fail();
            a333 = ((ListTerm)a332).cdr;
        } else if ( a332.IsVariable() ){
            a333 = engine.makeVariable();
            if ( !a332.Unify(new ListTerm(s58, a333), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a333.IsList() ){
            if ( !s173.Unify(((ListTerm)a333).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a333).cdr, engine.trail) )
                return engine.fail();
        } else if ( a333.IsVariable() ){
            if ( !a333.Unify(new ListTerm(s173, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a12.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s14.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a12, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a303.IsList() ){
            a334 = ((ListTerm)a303).car;
            if ( !s3.Unify(((ListTerm)a303).cdr, engine.trail) )
                return engine.fail();
        } else if ( a303.IsVariable() ){
            a334 = engine.makeVariable();
            if ( !a303.Unify(new ListTerm(a334, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a334.IsList() ){
            if ( !s174.Unify(((ListTerm)a334).car, engine.trail) )
                return engine.fail();
            a335 = ((ListTerm)a334).cdr;
        } else if ( a334.IsVariable() ){
            a335 = engine.makeVariable();
            if ( !a334.Unify(new ListTerm(s174, a335), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a335.IsList() ){
            a336 = ((ListTerm)a335).car;
            a337 = ((ListTerm)a335).cdr;
        } else if ( a335.IsVariable() ){
            a336 = engine.makeVariable();
            a337 = engine.makeVariable();
            if ( !a335.Unify(new ListTerm(a336, a337), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a336.IsList() ){
            a338 = ((ListTerm)a336).car;
            if ( !s3.Unify(((ListTerm)a336).cdr, engine.trail) )
                return engine.fail();
        } else if ( a336.IsVariable() ){
            a338 = engine.makeVariable();
            if ( !a336.Unify(new ListTerm(a338, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a337.IsList() ){
            if ( !s2.Unify(((ListTerm)a337).car, engine.trail) )
                return engine.fail();
            a339 = ((ListTerm)a337).cdr;
        } else if ( a337.IsVariable() ){
            a339 = engine.makeVariable();
            if ( !a337.Unify(new ListTerm(s2, a339), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a339.IsList() ){
            a340 = ((ListTerm)a339).car;
            a341 = ((ListTerm)a339).cdr;
        } else if ( a339.IsVariable() ){
            a340 = engine.makeVariable();
            a341 = engine.makeVariable();
            if ( !a339.Unify(new ListTerm(a340, a341), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a340.IsList() ){
            if ( !s1.Unify(((ListTerm)a340).car, engine.trail) )
                return engine.fail();
            a342 = ((ListTerm)a340).cdr;
        } else if ( a340.IsVariable() ){
            a342 = engine.makeVariable();
            if ( !a340.Unify(new ListTerm(s1, a342), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a342.IsList() ){
            if ( !s175.Unify(((ListTerm)a342).car, engine.trail) )
                return engine.fail();
            if ( !a336.Unify(((ListTerm)a342).cdr, engine.trail) )
                return engine.fail();
        } else if ( a342.IsVariable() ){
            if ( !a342.Unify(new ListTerm(s175, a336), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a336.IsList() ){
            if ( !a338.Unify(((ListTerm)a336).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a336).cdr, engine.trail) )
                return engine.fail();
        } else if ( a336.IsVariable() ){
            if ( !a336.Unify(new ListTerm(a338, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a341.IsList() ){
            if ( !s182.Unify(((ListTerm)a341).car, engine.trail) )
                return engine.fail();
            a343 = ((ListTerm)a341).cdr;
        } else if ( a341.IsVariable() ){
            a343 = engine.makeVariable();
            if ( !a341.Unify(new ListTerm(s182, a343), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a343.IsList() ){
            a344 = ((ListTerm)a343).car;
            if ( !s189.Unify(((ListTerm)a343).cdr, engine.trail) )
                return engine.fail();
        } else if ( a343.IsVariable() ){
            a344 = engine.makeVariable();
            if ( !a343.Unify(new ListTerm(a344, s189), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a344.IsList() ){
            if ( !s9.Unify(((ListTerm)a344).car, engine.trail) )
                return engine.fail();
            a345 = ((ListTerm)a344).cdr;
        } else if ( a344.IsVariable() ){
            a345 = engine.makeVariable();
            if ( !a344.Unify(new ListTerm(s9, a345), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a345.IsList() ){
            if ( !s1.Unify(((ListTerm)a345).car, engine.trail) )
                return engine.fail();
            a346 = ((ListTerm)a345).cdr;
        } else if ( a345.IsVariable() ){
            a346 = engine.makeVariable();
            if ( !a345.Unify(new ListTerm(s1, a346), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a346.IsList() ){
            if ( !s175.Unify(((ListTerm)a346).car, engine.trail) )
                return engine.fail();
            a347 = ((ListTerm)a346).cdr;
        } else if ( a346.IsVariable() ){
            a347 = engine.makeVariable();
            if ( !a346.Unify(new ListTerm(s175, a347), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a347.IsList() ){
            if ( !a338.Unify(((ListTerm)a347).car, engine.trail) )
                return engine.fail();
            if ( !s197.Unify(((ListTerm)a347).cdr, engine.trail) )
                return engine.fail();
        } else if ( a347.IsVariable() ){
            if ( !a347.Unify(new ListTerm(a338, s197), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_19 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("i");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("dit");
    static internal readonly IntegerTerm s9 = new IntegerTerm(10);
    static internal readonly ListTerm s10 = new ListTerm(s9, s3);
    static internal readonly ListTerm s11 = new ListTerm(s8, s10);
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s7, s12);
    static internal readonly ListTerm s14 = new ListTerm(s13, s3);
    static internal readonly ListTerm s15 = new ListTerm(s2, s14);
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("remind");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("of");
    static internal readonly IntegerTerm s19 = new IntegerTerm(2);
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("im");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("makes");
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s27 = new ListTerm(s26, s3);
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("please");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("sometimes");
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("wish");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("were");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("like");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("be");
    static internal readonly IntegerTerm s41 = new IntegerTerm(3);
    static internal readonly ListTerm s42 = new ListTerm(s17, s3);
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("why");
    static internal readonly ListTerm s44 = new ListTerm(s17, s27);
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("not");
    static internal readonly ListTerm s47 = new ListTerm(s46, s27);
    static internal readonly ListTerm s48 = new ListTerm(s17, s47);
    static internal readonly ListTerm s49 = new ListTerm(s33, s48);
    static internal readonly ListTerm s50 = new ListTerm(s45, s49);
    static internal readonly ListTerm s51 = new ListTerm(s17, s50);
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s54 = new ListTerm(s53, s3);
    static internal readonly ListTerm s55 = new ListTerm(s17, s54);
    static internal readonly SymbolTerm s56 = SymbolTerm.MakeSymbol("suppose");
    static internal readonly SymbolTerm s57 = SymbolTerm.MakeSymbol("did");
    static internal readonly SymbolTerm s58 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s59 = SymbolTerm.MakeSymbol("mean");
    static internal readonly ListTerm s60 = new ListTerm(s31, s44);
    static internal readonly ListTerm s61 = new ListTerm(s59, s60);
    static internal readonly ListTerm s62 = new ListTerm(s58, s61);
    static internal readonly ListTerm s63 = new ListTerm(s38, s62);
    static internal readonly ListTerm s64 = new ListTerm(s21, s63);
    static internal readonly ListTerm s65 = new ListTerm(s45, s64);
    static internal readonly ListTerm s66 = new ListTerm(s17, s65);
    static internal readonly SymbolTerm s67 = SymbolTerm.MakeSymbol("someone");
    static internal readonly SymbolTerm s68 = SymbolTerm.MakeSymbol("else");
    static internal readonly IntegerTerm s69 = new IntegerTerm(4);
    static internal readonly SymbolTerm s70 = SymbolTerm.MakeSymbol("we");
    static internal readonly SymbolTerm s71 = SymbolTerm.MakeSymbol("discussing");
    static internal readonly SymbolTerm s72 = SymbolTerm.MakeSymbol("me");
    static internal readonly ListTerm s73 = new ListTerm(s72, s54);
    static internal readonly ListTerm s74 = new ListTerm(s46, s73);
    static internal readonly ListTerm s75 = new ListTerm(s45, s74);
    static internal readonly ListTerm s76 = new ListTerm(s17, s75);
    static internal readonly ListTerm s77 = new ListTerm(s71, s76);
    static internal readonly ListTerm s78 = new ListTerm(s36, s77);
    static internal readonly ListTerm s79 = new ListTerm(s70, s78);
    static internal readonly SymbolTerm s80 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s81 = SymbolTerm.MakeSymbol("talking");
    static internal readonly SymbolTerm s82 = SymbolTerm.MakeSymbol("about");
    static internal readonly ListTerm s83 = new ListTerm(s80, s44);
    static internal readonly ListTerm s84 = new ListTerm(s45, s83);
    static internal readonly ListTerm s85 = new ListTerm(s72, s84);
    static internal readonly ListTerm s86 = new ListTerm(s82, s85);
    static internal readonly ListTerm s87 = new ListTerm(s81, s86);
    static internal readonly ListTerm s88 = new ListTerm(s52, s87);
    static internal readonly ListTerm s89 = new ListTerm(s46, s88);
    static internal readonly ListTerm s90 = new ListTerm(s80, s89);
    static internal readonly ListTerm s91 = new ListTerm(s17, s90);
    static internal readonly SymbolTerm s92 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s93 = SymbolTerm.MakeSymbol("feelings");
    static internal readonly SymbolTerm s94 = SymbolTerm.MakeSymbol("now");
    static internal readonly ListTerm s95 = new ListTerm(s94, s27);
    static internal readonly ListTerm s96 = new ListTerm(s93, s95);
    static internal readonly ListTerm s97 = new ListTerm(s92, s96);
    static internal readonly ListTerm s98 = new ListTerm(s80, s97);
    static internal readonly ListTerm s99 = new ListTerm(s21, s98);
    static internal readonly ListTerm s100 = new ListTerm(s99, s3);
    static internal readonly ListTerm s101 = new ListTerm(s91, s100);
    static internal readonly SymbolTerm s102 = SymbolTerm.MakeSymbol("oh");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91, a92, a93, a94, a95, a96, a97, a98, a99, a100, a101, a102, a103, a104;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            if ( !s15.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a8 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s1.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a9 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s1, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s16.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s16, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s17.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s17, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !s18.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            a12 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(s18, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s3.Unify(((ListTerm)a12).cdr, engine.trail) )
                return engine.fail();
        } else if ( a12.IsVariable() ){
            if ( !a12.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a13 = ((ListTerm)a5).car;
            a14 = ((ListTerm)a5).cdr;
        } else if ( a5.IsVariable() ){
            a13 = engine.makeVariable();
            a14 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a13, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            if ( !s19.Unify(((ListTerm)a13).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(s19, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            a16 = ((ListTerm)a15).car;
            a17 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            a17 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(a16, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            a18 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(engine.makeVariable(), a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s20.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s20, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            a20 = ((ListTerm)a19).car;
            if ( !s3.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(a20, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s2.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s2, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            a22 = ((ListTerm)a21).car;
            a23 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            a23 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(a22, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s21.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(s21, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s22.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s22, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s17.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s17, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s23.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(s23, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s24.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s24, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s25.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s25, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a20.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s27.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a20, s27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            a30 = ((ListTerm)a23).car;
            a31 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a30 = engine.makeVariable();
            a31 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(a30, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s28.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s28, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s29.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s29, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s30.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s30, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s17.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s17, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s31.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s31, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s32.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            if ( !a27.Unify(((ListTerm)a36).cdr, engine.trail) )
                return engine.fail();
        } else if ( a36.IsVariable() ){
            if ( !a36.Unify(new ListTerm(s32, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s24.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            if ( !a28.Unify(((ListTerm)a27).cdr, engine.trail) )
                return engine.fail();
        } else if ( a27.IsVariable() ){
            if ( !a27.Unify(new ListTerm(s24, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s25.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            if ( !a29.Unify(((ListTerm)a28).cdr, engine.trail) )
                return engine.fail();
        } else if ( a28.IsVariable() ){
            if ( !a28.Unify(new ListTerm(s25, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a20.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s27.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a20, s27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            a37 = ((ListTerm)a31).car;
            a38 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a37 = engine.makeVariable();
            a38 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(a37, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s33.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a39 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s33, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s17.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a40 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s17, a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s34.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            a41 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a41 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(s34, a41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s35.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a42 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s35, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s17.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s17, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            if ( !s36.Unify(((ListTerm)a43).car, engine.trail) )
                return engine.fail();
            if ( !a29.Unify(((ListTerm)a43).cdr, engine.trail) )
                return engine.fail();
        } else if ( a43.IsVariable() ){
            if ( !a43.Unify(new ListTerm(s36, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a20.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s27.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a20, s27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            a44 = ((ListTerm)a38).car;
            if ( !s3.Unify(((ListTerm)a38).cdr, engine.trail) )
                return engine.fail();
        } else if ( a38.IsVariable() ){
            a44 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(a44, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s37.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            a45 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a45 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(s37, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            if ( !s17.Unify(((ListTerm)a45).car, engine.trail) )
                return engine.fail();
            a46 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a46 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(s17, a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s38.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s38, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s39.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(s39, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s31.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s31, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s40.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            if ( !a29.Unify(((ListTerm)a49).cdr, engine.trail) )
                return engine.fail();
        } else if ( a49.IsVariable() ){
            if ( !a49.Unify(new ListTerm(s40, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a20.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s27.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a20, s27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            a50 = ((ListTerm)a14).car;
            a51 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a50 = engine.makeVariable();
            a51 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(a50, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s41.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            a52 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a52 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(s41, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            a53 = ((ListTerm)a52).car;
            a54 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a53 = engine.makeVariable();
            a54 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(a53, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            a55 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(engine.makeVariable(), a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s1.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s1, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !a20.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            if ( !s42.Unify(((ListTerm)a56).cdr, engine.trail) )
                return engine.fail();
        } else if ( a56.IsVariable() ){
            if ( !a56.Unify(new ListTerm(a20, s42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s2.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            a57 = ((ListTerm)a54).cdr;
        } else if ( a54.IsVariable() ){
            a57 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(s2, a57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            a58 = ((ListTerm)a57).car;
            a59 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a58 = engine.makeVariable();
            a59 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(a58, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !s43.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            a60 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a60 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(s43, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            if ( !s33.Unify(((ListTerm)a60).car, engine.trail) )
                return engine.fail();
            a61 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(s33, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s17.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s17, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s23.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s23, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s24.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            a64 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a64 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(s24, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !a20.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            if ( !s44.Unify(((ListTerm)a64).cdr, engine.trail) )
                return engine.fail();
        } else if ( a64.IsVariable() ){
            if ( !a64.Unify(new ListTerm(a20, s44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            a65 = ((ListTerm)a59).car;
            a66 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a65 = engine.makeVariable();
            a66 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(a65, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s17.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a67 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a67 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s17, a67), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            if ( !s39.Unify(((ListTerm)a67).car, engine.trail) )
                return engine.fail();
            a68 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a68 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(s39, a68), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            if ( !s31.Unify(((ListTerm)a68).car, engine.trail) )
                return engine.fail();
            a69 = ((ListTerm)a68).cdr;
        } else if ( a68.IsVariable() ){
            a69 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(s31, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            if ( !s23.Unify(((ListTerm)a69).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(s23, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s24.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            a71 = ((ListTerm)a70).cdr;
        } else if ( a70.IsVariable() ){
            a71 = engine.makeVariable();
            if ( !a70.Unify(new ListTerm(s24, a71), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !a20.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            if ( !s51.Unify(((ListTerm)a71).cdr, engine.trail) )
                return engine.fail();
        } else if ( a71.IsVariable() ){
            if ( !a71.Unify(new ListTerm(a20, s51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            a72 = ((ListTerm)a66).car;
            a73 = ((ListTerm)a66).cdr;
        } else if ( a66.IsVariable() ){
            a72 = engine.makeVariable();
            a73 = engine.makeVariable();
            if ( !a66.Unify(new ListTerm(a72, a73), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a72.IsList() ){
            if ( !s21.Unify(((ListTerm)a72).car, engine.trail) )
                return engine.fail();
            a74 = ((ListTerm)a72).cdr;
        } else if ( a72.IsVariable() ){
            a74 = engine.makeVariable();
            if ( !a72.Unify(new ListTerm(s21, a74), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a74.IsList() ){
            if ( !s22.Unify(((ListTerm)a74).car, engine.trail) )
                return engine.fail();
            if ( !a61.Unify(((ListTerm)a74).cdr, engine.trail) )
                return engine.fail();
        } else if ( a74.IsVariable() ){
            if ( !a74.Unify(new ListTerm(s22, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s17.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            if ( !a62.Unify(((ListTerm)a61).cdr, engine.trail) )
                return engine.fail();
        } else if ( a61.IsVariable() ){
            if ( !a61.Unify(new ListTerm(s17, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s23.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            if ( !a63.Unify(((ListTerm)a62).cdr, engine.trail) )
                return engine.fail();
        } else if ( a62.IsVariable() ){
            if ( !a62.Unify(new ListTerm(s23, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s24.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            if ( !a64.Unify(((ListTerm)a63).cdr, engine.trail) )
                return engine.fail();
        } else if ( a63.IsVariable() ){
            if ( !a63.Unify(new ListTerm(s24, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !a20.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            if ( !s44.Unify(((ListTerm)a64).cdr, engine.trail) )
                return engine.fail();
        } else if ( a64.IsVariable() ){
            if ( !a64.Unify(new ListTerm(a20, s44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a73.IsList() ){
            a75 = ((ListTerm)a73).car;
            a76 = ((ListTerm)a73).cdr;
        } else if ( a73.IsVariable() ){
            a75 = engine.makeVariable();
            a76 = engine.makeVariable();
            if ( !a73.Unify(new ListTerm(a75, a76), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a75.IsList() ){
            if ( !s52.Unify(((ListTerm)a75).car, engine.trail) )
                return engine.fail();
            a77 = ((ListTerm)a75).cdr;
        } else if ( a75.IsVariable() ){
            a77 = engine.makeVariable();
            if ( !a75.Unify(new ListTerm(s52, a77), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a77.IsList() ){
            if ( !s45.Unify(((ListTerm)a77).car, engine.trail) )
                return engine.fail();
            a78 = ((ListTerm)a77).cdr;
        } else if ( a77.IsVariable() ){
            a78 = engine.makeVariable();
            if ( !a77.Unify(new ListTerm(s45, a78), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a78.IsList() ){
            if ( !s24.Unify(((ListTerm)a78).car, engine.trail) )
                return engine.fail();
            a79 = ((ListTerm)a78).cdr;
        } else if ( a78.IsVariable() ){
            a79 = engine.makeVariable();
            if ( !a78.Unify(new ListTerm(s24, a79), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a79.IsList() ){
            if ( !a20.Unify(((ListTerm)a79).car, engine.trail) )
                return engine.fail();
            if ( !s55.Unify(((ListTerm)a79).cdr, engine.trail) )
                return engine.fail();
        } else if ( a79.IsVariable() ){
            if ( !a79.Unify(new ListTerm(a20, s55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a76.IsList() ){
            a80 = ((ListTerm)a76).car;
            a81 = ((ListTerm)a76).cdr;
        } else if ( a76.IsVariable() ){
            a80 = engine.makeVariable();
            a81 = engine.makeVariable();
            if ( !a76.Unify(new ListTerm(a80, a81), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a80.IsList() ){
            if ( !s33.Unify(((ListTerm)a80).car, engine.trail) )
                return engine.fail();
            a82 = ((ListTerm)a80).cdr;
        } else if ( a80.IsVariable() ){
            a82 = engine.makeVariable();
            if ( !a80.Unify(new ListTerm(s33, a82), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a82.IsList() ){
            if ( !s17.Unify(((ListTerm)a82).car, engine.trail) )
                return engine.fail();
            a83 = ((ListTerm)a82).cdr;
        } else if ( a82.IsVariable() ){
            a83 = engine.makeVariable();
            if ( !a82.Unify(new ListTerm(s17, a83), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a83.IsList() ){
            if ( !s35.Unify(((ListTerm)a83).car, engine.trail) )
                return engine.fail();
            a84 = ((ListTerm)a83).cdr;
        } else if ( a83.IsVariable() ){
            a84 = engine.makeVariable();
            if ( !a83.Unify(new ListTerm(s35, a84), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a84.IsList() ){
            if ( !s31.Unify(((ListTerm)a84).car, engine.trail) )
                return engine.fail();
            a85 = ((ListTerm)a84).cdr;
        } else if ( a84.IsVariable() ){
            a85 = engine.makeVariable();
            if ( !a84.Unify(new ListTerm(s31, a85), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a85.IsList() ){
            if ( !s32.Unify(((ListTerm)a85).car, engine.trail) )
                return engine.fail();
            if ( !a63.Unify(((ListTerm)a85).cdr, engine.trail) )
                return engine.fail();
        } else if ( a85.IsVariable() ){
            if ( !a85.Unify(new ListTerm(s32, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s24.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            if ( !a64.Unify(((ListTerm)a63).cdr, engine.trail) )
                return engine.fail();
        } else if ( a63.IsVariable() ){
            if ( !a63.Unify(new ListTerm(s24, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !a20.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            if ( !s44.Unify(((ListTerm)a64).cdr, engine.trail) )
                return engine.fail();
        } else if ( a64.IsVariable() ){
            if ( !a64.Unify(new ListTerm(a20, s44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a81.IsList() ){
            a86 = ((ListTerm)a81).car;
            a87 = ((ListTerm)a81).cdr;
        } else if ( a81.IsVariable() ){
            a86 = engine.makeVariable();
            a87 = engine.makeVariable();
            if ( !a81.Unify(new ListTerm(a86, a87), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a86.IsList() ){
            if ( !s56.Unify(((ListTerm)a86).car, engine.trail) )
                return engine.fail();
            a88 = ((ListTerm)a86).cdr;
        } else if ( a86.IsVariable() ){
            a88 = engine.makeVariable();
            if ( !a86.Unify(new ListTerm(s56, a88), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a88.IsList() ){
            if ( !s24.Unify(((ListTerm)a88).car, engine.trail) )
                return engine.fail();
            a89 = ((ListTerm)a88).cdr;
        } else if ( a88.IsVariable() ){
            a89 = engine.makeVariable();
            if ( !a88.Unify(new ListTerm(s24, a89), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a89.IsList() ){
            if ( !s57.Unify(((ListTerm)a89).car, engine.trail) )
                return engine.fail();
            a90 = ((ListTerm)a89).cdr;
        } else if ( a89.IsVariable() ){
            a90 = engine.makeVariable();
            if ( !a89.Unify(new ListTerm(s57, a90), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a90.IsList() ){
            if ( !a20.Unify(((ListTerm)a90).car, engine.trail) )
                return engine.fail();
            if ( !s66.Unify(((ListTerm)a90).cdr, engine.trail) )
                return engine.fail();
        } else if ( a90.IsVariable() ){
            if ( !a90.Unify(new ListTerm(a20, s66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a87.IsList() ){
            a91 = ((ListTerm)a87).car;
            if ( !s3.Unify(((ListTerm)a87).cdr, engine.trail) )
                return engine.fail();
        } else if ( a87.IsVariable() ){
            a91 = engine.makeVariable();
            if ( !a87.Unify(new ListTerm(a91, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a91.IsList() ){
            if ( !s28.Unify(((ListTerm)a91).car, engine.trail) )
                return engine.fail();
            a92 = ((ListTerm)a91).cdr;
        } else if ( a91.IsVariable() ){
            a92 = engine.makeVariable();
            if ( !a91.Unify(new ListTerm(s28, a92), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a92.IsList() ){
            if ( !s67.Unify(((ListTerm)a92).car, engine.trail) )
                return engine.fail();
            a93 = ((ListTerm)a92).cdr;
        } else if ( a92.IsVariable() ){
            a93 = engine.makeVariable();
            if ( !a92.Unify(new ListTerm(s67, a93), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a93.IsList() ){
            if ( !s68.Unify(((ListTerm)a93).car, engine.trail) )
                return engine.fail();
            if ( !a85.Unify(((ListTerm)a93).cdr, engine.trail) )
                return engine.fail();
        } else if ( a93.IsVariable() ){
            if ( !a93.Unify(new ListTerm(s68, a85), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a85.IsList() ){
            if ( !s32.Unify(((ListTerm)a85).car, engine.trail) )
                return engine.fail();
            if ( !a63.Unify(((ListTerm)a85).cdr, engine.trail) )
                return engine.fail();
        } else if ( a85.IsVariable() ){
            if ( !a85.Unify(new ListTerm(s32, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s24.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            if ( !a64.Unify(((ListTerm)a63).cdr, engine.trail) )
                return engine.fail();
        } else if ( a63.IsVariable() ){
            if ( !a63.Unify(new ListTerm(s24, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !a20.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            if ( !s44.Unify(((ListTerm)a64).cdr, engine.trail) )
                return engine.fail();
        } else if ( a64.IsVariable() ){
            if ( !a64.Unify(new ListTerm(a20, s44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            a94 = ((ListTerm)a51).car;
            if ( !s3.Unify(((ListTerm)a51).cdr, engine.trail) )
                return engine.fail();
        } else if ( a51.IsVariable() ){
            a94 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(a94, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a94.IsList() ){
            if ( !s69.Unify(((ListTerm)a94).car, engine.trail) )
                return engine.fail();
            a95 = ((ListTerm)a94).cdr;
        } else if ( a94.IsVariable() ){
            a95 = engine.makeVariable();
            if ( !a94.Unify(new ListTerm(s69, a95), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a95.IsList() ){
            a96 = ((ListTerm)a95).car;
            a97 = ((ListTerm)a95).cdr;
        } else if ( a95.IsVariable() ){
            a96 = engine.makeVariable();
            a97 = engine.makeVariable();
            if ( !a95.Unify(new ListTerm(a96, a97), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a96.IsList() ){
            a98 = ((ListTerm)a96).cdr;
        } else if ( a96.IsVariable() ){
            a98 = engine.makeVariable();
            if ( !a96.Unify(new ListTerm(engine.makeVariable(), a98), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a98.IsList() ){
            if ( !s1.Unify(((ListTerm)a98).car, engine.trail) )
                return engine.fail();
            if ( !a19.Unify(((ListTerm)a98).cdr, engine.trail) )
                return engine.fail();
        } else if ( a98.IsVariable() ){
            if ( !a98.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a20.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a20, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a97.IsList() ){
            if ( !s2.Unify(((ListTerm)a97).car, engine.trail) )
                return engine.fail();
            a99 = ((ListTerm)a97).cdr;
        } else if ( a97.IsVariable() ){
            a99 = engine.makeVariable();
            if ( !a97.Unify(new ListTerm(s2, a99), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a99.IsList() ){
            if ( !s79.Unify(((ListTerm)a99).car, engine.trail) )
                return engine.fail();
            a100 = ((ListTerm)a99).cdr;
        } else if ( a99.IsVariable() ){
            a100 = engine.makeVariable();
            if ( !a99.Unify(new ListTerm(s79, a100), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a100.IsList() ){
            a101 = ((ListTerm)a100).car;
            if ( !s101.Unify(((ListTerm)a100).cdr, engine.trail) )
                return engine.fail();
        } else if ( a100.IsVariable() ){
            a101 = engine.makeVariable();
            if ( !a100.Unify(new ListTerm(a101, s101), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a101.IsList() ){
            if ( !s102.Unify(((ListTerm)a101).car, engine.trail) )
                return engine.fail();
            a102 = ((ListTerm)a101).cdr;
        } else if ( a101.IsVariable() ){
            a102 = engine.makeVariable();
            if ( !a101.Unify(new ListTerm(s102, a102), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a102.IsList() ){
            if ( !s45.Unify(((ListTerm)a102).car, engine.trail) )
                return engine.fail();
            a103 = ((ListTerm)a102).cdr;
        } else if ( a102.IsVariable() ){
            a103 = engine.makeVariable();
            if ( !a102.Unify(new ListTerm(s45, a103), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a103.IsList() ){
            if ( !s1.Unify(((ListTerm)a103).car, engine.trail) )
                return engine.fail();
            a104 = ((ListTerm)a103).cdr;
        } else if ( a103.IsVariable() ){
            a104 = engine.makeVariable();
            if ( !a103.Unify(new ListTerm(s1, a104), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a104.IsList() ){
            if ( !a20.Unify(((ListTerm)a104).car, engine.trail) )
                return engine.fail();
            if ( !s54.Unify(((ListTerm)a104).cdr, engine.trail) )
                return engine.fail();
        } else if ( a104.IsVariable() ){
            if ( !a104.Unify(new ListTerm(a20, s54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_20 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("yes");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("seem");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("quite");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("positive");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s10, s12);
    static internal readonly ListTerm s14 = new ListTerm(s9, s13);
    static internal readonly ListTerm s15 = new ListTerm(s8, s14);
    static internal readonly ListTerm s16 = new ListTerm(s7, s15);
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("sure");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s20 = new ListTerm(s19, s3);
    static internal readonly ListTerm s21 = new ListTerm(s18, s20);
    static internal readonly ListTerm s22 = new ListTerm(s17, s21);
    static internal readonly ListTerm s23 = new ListTerm(s7, s22);
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("see");
    static internal readonly ListTerm s26 = new ListTerm(s25, s12);
    static internal readonly ListTerm s27 = new ListTerm(s24, s26);
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("understand");
    static internal readonly ListTerm s29 = new ListTerm(s28, s12);
    static internal readonly ListTerm s30 = new ListTerm(s24, s29);
    static internal readonly ListTerm s31 = new ListTerm(s30, s3);
    static internal readonly ListTerm s32 = new ListTerm(s27, s31);
    static internal readonly ListTerm s33 = new ListTerm(s23, s32);
    static internal readonly ListTerm s34 = new ListTerm(s16, s33);
    static internal readonly ListTerm s35 = new ListTerm(s2, s34);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s35.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_21 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("no");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("saying");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("just");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("negative");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s12, s16);
    static internal readonly ListTerm s18 = new ListTerm(s11, s17);
    static internal readonly ListTerm s19 = new ListTerm(s10, s18);
    static internal readonly ListTerm s20 = new ListTerm(s1, s19);
    static internal readonly ListTerm s21 = new ListTerm(s9, s20);
    static internal readonly ListTerm s22 = new ListTerm(s8, s21);
    static internal readonly ListTerm s23 = new ListTerm(s7, s22);
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("being");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("a");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("bit");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s28 = new ListTerm(s27, s3);
    static internal readonly ListTerm s29 = new ListTerm(s13, s28);
    static internal readonly ListTerm s30 = new ListTerm(s26, s29);
    static internal readonly ListTerm s31 = new ListTerm(s25, s30);
    static internal readonly ListTerm s32 = new ListTerm(s24, s31);
    static internal readonly ListTerm s33 = new ListTerm(s7, s32);
    static internal readonly ListTerm s34 = new ListTerm(s8, s33);
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("not");
    static internal readonly ListTerm s37 = new ListTerm(s36, s15);
    static internal readonly ListTerm s38 = new ListTerm(s35, s37);
    static internal readonly ListTerm s39 = new ListTerm(s1, s15);
    static internal readonly ListTerm s40 = new ListTerm(s35, s39);
    static internal readonly ListTerm s41 = new ListTerm(s40, s3);
    static internal readonly ListTerm s42 = new ListTerm(s38, s41);
    static internal readonly ListTerm s43 = new ListTerm(s34, s42);
    static internal readonly ListTerm s44 = new ListTerm(s23, s43);
    static internal readonly ListTerm s45 = new ListTerm(s2, s44);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s45.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_22 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("your");
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("*");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("mother");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("father");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("brother");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("sister");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("children");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("wife");
    static internal readonly IntegerTerm s14 = new IntegerTerm(0);
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("tell");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("more");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("about");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("family");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s21 = new ListTerm(s20, s3);
    static internal readonly ListTerm s22 = new ListTerm(s19, s21);
    static internal readonly ListTerm s23 = new ListTerm(s1, s22);
    static internal readonly ListTerm s24 = new ListTerm(s18, s23);
    static internal readonly ListTerm s25 = new ListTerm(s17, s24);
    static internal readonly ListTerm s26 = new ListTerm(s16, s25);
    static internal readonly ListTerm s27 = new ListTerm(s15, s26);
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("who");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("else");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s32 = new ListTerm(s31, s3);
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s34 = SymbolTerm.MakeSymbol("comes");
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("mind");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("when");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("of");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("say");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("suggest");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("anything");
    static internal readonly SymbolTerm s48 = SymbolTerm.MakeSymbol("which");
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("belongs");
    static internal readonly ListTerm s50 = new ListTerm(s38, s32);
    static internal readonly ListTerm s51 = new ListTerm(s35, s50);
    static internal readonly ListTerm s52 = new ListTerm(s49, s51);
    static internal readonly ListTerm s53 = new ListTerm(s48, s52);
    static internal readonly ListTerm s54 = new ListTerm(s29, s53);
    static internal readonly ListTerm s55 = new ListTerm(s47, s54);
    static internal readonly ListTerm s56 = new ListTerm(s46, s55);
    static internal readonly ListTerm s57 = new ListTerm(s45, s56);
    static internal readonly ListTerm s58 = new ListTerm(s44, s57);
    static internal readonly SymbolTerm s59 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s60 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s61 = SymbolTerm.MakeSymbol("important");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(engine.makeVariable(), a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            a13 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            a13 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s7.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s7, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s8.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s8, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s9.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s9, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s10.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s10, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s11.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s11, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s12.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s12, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s13.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s13, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            a21 = ((ListTerm)a20).car;
            if ( !s3.Unify(((ListTerm)a20).cdr, engine.trail) )
                return engine.fail();
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(a21, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a22 = ((ListTerm)a13).car;
            if ( !s3.Unify(((ListTerm)a13).cdr, engine.trail) )
                return engine.fail();
        } else if ( a13.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a22, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s14.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s14, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s27.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s27, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            a25 = ((ListTerm)a24).car;
            a26 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            a26 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(a25, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s28.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s28, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s29.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s29, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s30.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s30, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s1.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s1, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s19.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s19, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !a22.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a31).cdr, engine.trail) )
                return engine.fail();
        } else if ( a31.IsVariable() ){
            if ( !a31.Unify(new ListTerm(a22, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            a32 = ((ListTerm)a26).car;
            a33 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a32 = engine.makeVariable();
            a33 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(a32, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s1.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s1, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !a21.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a34).cdr, engine.trail) )
                return engine.fail();
        } else if ( a34.IsVariable() ){
            if ( !a34.Unify(new ListTerm(a21, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            a35 = ((ListTerm)a33).car;
            if ( !s3.Unify(((ListTerm)a33).cdr, engine.trail) )
                return engine.fail();
        } else if ( a33.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(a35, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s33.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s33, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s29.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(s29, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s34.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a38 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s34, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            if ( !s35.Unify(((ListTerm)a38).car, engine.trail) )
                return engine.fail();
            a39 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(s35, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s36.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a40 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s36, a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s37.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            a41 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a41 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(s37, a41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s38.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a42 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s38, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s39.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s39, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            if ( !s40.Unify(((ListTerm)a43).car, engine.trail) )
                return engine.fail();
            if ( !a32.Unify(((ListTerm)a43).cdr, engine.trail) )
                return engine.fail();
        } else if ( a43.IsVariable() ){
            if ( !a43.Unify(new ListTerm(s40, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s1.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            if ( !a34.Unify(((ListTerm)a32).cdr, engine.trail) )
                return engine.fail();
        } else if ( a32.IsVariable() ){
            if ( !a32.Unify(new ListTerm(s1, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !a21.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a34).cdr, engine.trail) )
                return engine.fail();
        } else if ( a34.IsVariable() ){
            if ( !a34.Unify(new ListTerm(a21, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a44 = ((ListTerm)a5).car;
            if ( !s3.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a44 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a44, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s2.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            a45 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a45 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(s2, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            a46 = ((ListTerm)a45).car;
            a47 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a46 = engine.makeVariable();
            a47 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(a46, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            a48 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(engine.makeVariable(), a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s1.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s1, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            a50 = ((ListTerm)a49).car;
            if ( !s3.Unify(((ListTerm)a49).cdr, engine.trail) )
                return engine.fail();
        } else if ( a49.IsVariable() ){
            a50 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(a50, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s14.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            a51 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a51 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(s14, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            a52 = ((ListTerm)a51).car;
            a53 = ((ListTerm)a51).cdr;
        } else if ( a51.IsVariable() ){
            a52 = engine.makeVariable();
            a53 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(a52, a53), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s1.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            a54 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(s1, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !a50.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a54).cdr, engine.trail) )
                return engine.fail();
        } else if ( a54.IsVariable() ){
            if ( !a54.Unify(new ListTerm(a50, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            a55 = ((ListTerm)a53).car;
            a56 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a55 = engine.makeVariable();
            a56 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(a55, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s41.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a57 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a57 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s41, a57), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s42.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a58 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a58 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s42, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !s38.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(s38, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !s43.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            if ( !a52.Unify(((ListTerm)a59).cdr, engine.trail) )
                return engine.fail();
        } else if ( a59.IsVariable() ){
            if ( !a59.Unify(new ListTerm(s43, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s1.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            if ( !a54.Unify(((ListTerm)a52).cdr, engine.trail) )
                return engine.fail();
        } else if ( a52.IsVariable() ){
            if ( !a52.Unify(new ListTerm(s1, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !a50.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a54).cdr, engine.trail) )
                return engine.fail();
        } else if ( a54.IsVariable() ){
            if ( !a54.Unify(new ListTerm(a50, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s58.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            a60 = ((ListTerm)a56).cdr;
        } else if ( a56.IsVariable() ){
            a60 = engine.makeVariable();
            if ( !a56.Unify(new ListTerm(s58, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            a61 = ((ListTerm)a60).car;
            if ( !s3.Unify(((ListTerm)a60).cdr, engine.trail) )
                return engine.fail();
        } else if ( a60.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(a61, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s59.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s59, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s60.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s60, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s61.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            a64 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a64 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(s61, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !s35.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            a65 = ((ListTerm)a64).cdr;
        } else if ( a64.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a64.Unify(new ListTerm(s35, a65), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s38.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a66 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s38, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s45.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            if ( !a52.Unify(((ListTerm)a66).cdr, engine.trail) )
                return engine.fail();
        } else if ( a66.IsVariable() ){
            if ( !a66.Unify(new ListTerm(s45, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s1.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            if ( !a54.Unify(((ListTerm)a52).cdr, engine.trail) )
                return engine.fail();
        } else if ( a52.IsVariable() ){
            if ( !a52.Unify(new ListTerm(s1, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !a50.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            if ( !s32.Unify(((ListTerm)a54).cdr, engine.trail) )
                return engine.fail();
        } else if ( a54.IsVariable() ){
            if ( !a54.Unify(new ListTerm(a50, s32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_23 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("memory");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("lets");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("discuss");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("further");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("earlier");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("said");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("but");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s19 = new ListTerm(s18, s3);
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("anything");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("with");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("the");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("fact");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
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
        if ( a6.IsList() ){
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s7.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a9 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s7, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a10 = ((ListTerm)a9).car;
            if ( !s3.Unify(((ListTerm)a9).cdr, engine.trail) )
                return engine.fail();
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a10, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s2.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s2, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            a13 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            a13 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s8.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s8, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s9.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s9, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s10.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s10, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s11.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s11, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s7.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !a10.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a19 = ((ListTerm)a13).car;
            a20 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a19 = engine.makeVariable();
            a20 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a19, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s14.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s14, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s15.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s15, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s16.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !a17.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(s16, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s7.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            if ( !a18.Unify(((ListTerm)a17).cdr, engine.trail) )
                return engine.fail();
        } else if ( a17.IsVariable() ){
            if ( !a17.Unify(new ListTerm(s7, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !a10.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            if ( !s13.Unify(((ListTerm)a18).cdr, engine.trail) )
                return engine.fail();
        } else if ( a18.IsVariable() ){
            if ( !a18.Unify(new ListTerm(a10, s13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            a23 = ((ListTerm)a20).car;
            a24 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a23 = engine.makeVariable();
            a24 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(a23, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s17.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s17, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s7.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s7, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !a10.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !s19.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(a10, s19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            a27 = ((ListTerm)a24).car;
            if ( !s3.Unify(((ListTerm)a24).cdr, engine.trail) )
                return engine.fail();
        } else if ( a24.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(a27, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s20.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s20, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s21.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s21, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !s22.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a29).cdr;
        } else if ( a29.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(s22, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s23.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s23, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s24.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s24, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s25.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s25, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s26.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s26, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s27.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s27, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s28.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s28, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s21.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            if ( !a25.Unify(((ListTerm)a36).cdr, engine.trail) )
                return engine.fail();
        } else if ( a36.IsVariable() ){
            if ( !a36.Unify(new ListTerm(s21, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s7.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            if ( !a26.Unify(((ListTerm)a25).cdr, engine.trail) )
                return engine.fail();
        } else if ( a25.IsVariable() ){
            if ( !a25.Unify(new ListTerm(s7, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !a10.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !s19.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(a10, s19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_24 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("can");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s8, s16);
    static internal readonly ListTerm s18 = new ListTerm(s12, s17);
    static internal readonly ListTerm s19 = new ListTerm(s11, s18);
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("what");
    static internal readonly ListTerm s22 = new ListTerm(s21, s4);
    static internal readonly ListTerm s23 = new ListTerm(s22, s3);
    static internal readonly ListTerm s24 = new ListTerm(s20, s23);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("want");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("able");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("like");
    static internal readonly SymbolTerm s33 = SymbolTerm.MakeSymbol("yourself");
    static internal readonly ListTerm s34 = new ListTerm(s33, s15);
    static internal readonly IntegerTerm s35 = new IntegerTerm(2);
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("whether");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("or");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("depends");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("on");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("more");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("than");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s43 = new ListTerm(s42, s3);
    static internal readonly ListTerm s44 = new ListTerm(s26, s43);
    static internal readonly ListTerm s45 = new ListTerm(s39, s44);
    static internal readonly ListTerm s46 = new ListTerm(s41, s45);
    static internal readonly ListTerm s47 = new ListTerm(s40, s46);
    static internal readonly ListTerm s48 = new ListTerm(s8, s47);
    static internal readonly ListTerm s49 = new ListTerm(s39, s48);
    static internal readonly ListTerm s50 = new ListTerm(s38, s49);
    static internal readonly ListTerm s51 = new ListTerm(s24, s3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s7.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            a12 = ((ListTerm)a11).car;
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s2.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s2, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            a14 = ((ListTerm)a13).car;
            a15 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            a15 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(a14, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s8.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s8, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s9.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s9, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s10.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s10, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s1.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !a12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            if ( !s19.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(a12, s19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s24.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s24, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            a21 = ((ListTerm)a20).car;
            a22 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            a22 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(a21, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s8.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s8, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s25.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a24 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a24 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s25, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            if ( !s26.Unify(((ListTerm)a24).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(s26, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s27.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s27, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s28.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(s28, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s29.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            a28 = ((ListTerm)a27).cdr;
        } else if ( a27.IsVariable() ){
            a28 = engine.makeVariable();
            if ( !a27.Unify(new ListTerm(s29, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s27.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a29 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a29 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s27, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a12.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a12, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            a30 = ((ListTerm)a22).car;
            if ( !s3.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(a30, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s30.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s30, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !s8.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            a32 = ((ListTerm)a31).cdr;
        } else if ( a31.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a31.Unify(new ListTerm(s8, a32), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s31.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s31, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s32.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s32, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s27.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s27, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s28.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            a36 = ((ListTerm)a35).cdr;
        } else if ( a35.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a35.Unify(new ListTerm(s28, a36), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s29.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(s29, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            if ( !s27.Unify(((ListTerm)a37).car, engine.trail) )
                return engine.fail();
            a38 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(s27, a38), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            if ( !a12.Unify(((ListTerm)a38).car, engine.trail) )
                return engine.fail();
            if ( !s34.Unify(((ListTerm)a38).cdr, engine.trail) )
                return engine.fail();
        } else if ( a38.IsVariable() ){
            if ( !a38.Unify(new ListTerm(a12, s34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a39 = ((ListTerm)a5).car;
            if ( !s3.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a39 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a39, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s35.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a40 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s35, a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            a41 = ((ListTerm)a40).car;
            a42 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a41 = engine.makeVariable();
            a42 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(a41, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            a43 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(engine.makeVariable(), a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            if ( !s1.Unify(((ListTerm)a43).car, engine.trail) )
                return engine.fail();
            a44 = ((ListTerm)a43).cdr;
        } else if ( a43.IsVariable() ){
            a44 = engine.makeVariable();
            if ( !a43.Unify(new ListTerm(s1, a44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s8.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            if ( !a11.Unify(((ListTerm)a44).cdr, engine.trail) )
                return engine.fail();
        } else if ( a44.IsVariable() ){
            if ( !a44.Unify(new ListTerm(s8, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !a12.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(a12, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s2.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            a45 = ((ListTerm)a42).cdr;
        } else if ( a42.IsVariable() ){
            a45 = engine.makeVariable();
            if ( !a42.Unify(new ListTerm(s2, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            a46 = ((ListTerm)a45).car;
            a47 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a46 = engine.makeVariable();
            a47 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(a46, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s36.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s36, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s37.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s37, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s13.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            a50 = ((ListTerm)a49).cdr;
        } else if ( a49.IsVariable() ){
            a50 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(s13, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s8.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            a51 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a51 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(s8, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            if ( !s1.Unify(((ListTerm)a51).car, engine.trail) )
                return engine.fail();
            a52 = ((ListTerm)a51).cdr;
        } else if ( a51.IsVariable() ){
            a52 = engine.makeVariable();
            if ( !a51.Unify(new ListTerm(s1, a52), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !a12.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            if ( !s50.Unify(((ListTerm)a52).cdr, engine.trail) )
                return engine.fail();
        } else if ( a52.IsVariable() ){
            if ( !a52.Unify(new ListTerm(a12, s50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            a53 = ((ListTerm)a47).car;
            a54 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a53 = engine.makeVariable();
            a54 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(a53, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            if ( !s12.Unify(((ListTerm)a53).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(s12, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s8.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s8, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s25.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            if ( !a25.Unify(((ListTerm)a56).cdr, engine.trail) )
                return engine.fail();
        } else if ( a56.IsVariable() ){
            if ( !a56.Unify(new ListTerm(s25, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s27.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            if ( !a26.Unify(((ListTerm)a25).cdr, engine.trail) )
                return engine.fail();
        } else if ( a25.IsVariable() ){
            if ( !a25.Unify(new ListTerm(s27, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s28.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            if ( !a27.Unify(((ListTerm)a26).cdr, engine.trail) )
                return engine.fail();
        } else if ( a26.IsVariable() ){
            if ( !a26.Unify(new ListTerm(s28, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !s29.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            if ( !a28.Unify(((ListTerm)a27).cdr, engine.trail) )
                return engine.fail();
        } else if ( a27.IsVariable() ){
            if ( !a27.Unify(new ListTerm(s29, a28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s27.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            if ( !a29.Unify(((ListTerm)a28).cdr, engine.trail) )
                return engine.fail();
        } else if ( a28.IsVariable() ){
            if ( !a28.Unify(new ListTerm(s27, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            if ( !a12.Unify(((ListTerm)a29).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            if ( !a29.Unify(new ListTerm(a12, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            a57 = ((ListTerm)a54).car;
            if ( !s51.Unify(((ListTerm)a54).cdr, engine.trail) )
                return engine.fail();
        } else if ( a54.IsVariable() ){
            a57 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(a57, s51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s30.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a58 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a58 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s30, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            if ( !s8.Unify(((ListTerm)a58).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a58).cdr;
        } else if ( a58.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(s8, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !s12.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            a60 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a60 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(s12, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            if ( !s13.Unify(((ListTerm)a60).car, engine.trail) )
                return engine.fail();
            a61 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(s13, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s25.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s25, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s27.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s27, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !a12.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            if ( !s43.Unify(((ListTerm)a63).cdr, engine.trail) )
                return engine.fail();
        } else if ( a63.IsVariable() ){
            if ( !a63.Unify(new ListTerm(a12, s43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_25 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("what");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("why");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("ask");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s10, s12);
    static internal readonly ListTerm s14 = new ListTerm(s9, s13);
    static internal readonly ListTerm s15 = new ListTerm(s8, s14);
    static internal readonly ListTerm s16 = new ListTerm(s7, s15);
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("question");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("interest");
    static internal readonly ListTerm s21 = new ListTerm(s9, s12);
    static internal readonly ListTerm s22 = new ListTerm(s20, s21);
    static internal readonly ListTerm s23 = new ListTerm(s19, s22);
    static internal readonly ListTerm s24 = new ListTerm(s18, s23);
    static internal readonly ListTerm s25 = new ListTerm(s17, s24);
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("it");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("want");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("know");
    static internal readonly ListTerm s32 = new ListTerm(s31, s12);
    static internal readonly ListTerm s33 = new ListTerm(s30, s32);
    static internal readonly ListTerm s34 = new ListTerm(s29, s33);
    static internal readonly ListTerm s35 = new ListTerm(s28, s34);
    static internal readonly ListTerm s36 = new ListTerm(s9, s35);
    static internal readonly ListTerm s37 = new ListTerm(s27, s36);
    static internal readonly ListTerm s38 = new ListTerm(s26, s37);
    static internal readonly ListTerm s39 = new ListTerm(s1, s38);
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("such");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("questions");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("much");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("on");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("your");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("mind");
    static internal readonly ListTerm s47 = new ListTerm(s46, s12);
    static internal readonly ListTerm s48 = new ListTerm(s45, s47);
    static internal readonly ListTerm s49 = new ListTerm(s44, s48);
    static internal readonly ListTerm s50 = new ListTerm(s43, s49);
    static internal readonly ListTerm s51 = new ListTerm(s42, s50);
    static internal readonly ListTerm s52 = new ListTerm(s41, s51);
    static internal readonly ListTerm s53 = new ListTerm(s40, s52);
    static internal readonly SymbolTerm s54 = SymbolTerm.MakeSymbol("answer");
    static internal readonly SymbolTerm s55 = SymbolTerm.MakeSymbol("would");
    static internal readonly SymbolTerm s56 = SymbolTerm.MakeSymbol("please");
    static internal readonly SymbolTerm s57 = SymbolTerm.MakeSymbol("most");
    static internal readonly ListTerm s58 = new ListTerm(s57, s12);
    static internal readonly ListTerm s59 = new ListTerm(s9, s58);
    static internal readonly ListTerm s60 = new ListTerm(s56, s59);
    static internal readonly ListTerm s61 = new ListTerm(s55, s60);
    static internal readonly ListTerm s62 = new ListTerm(s54, s61);
    static internal readonly ListTerm s63 = new ListTerm(s1, s62);
    static internal readonly SymbolTerm s64 = SymbolTerm.MakeSymbol("think");
    static internal readonly ListTerm s65 = new ListTerm(s64, s12);
    static internal readonly ListTerm s66 = new ListTerm(s9, s65);
    static internal readonly ListTerm s67 = new ListTerm(s8, s66);
    static internal readonly ListTerm s68 = new ListTerm(s1, s67);
    static internal readonly SymbolTerm s69 = SymbolTerm.MakeSymbol("comes");
    static internal readonly SymbolTerm s70 = SymbolTerm.MakeSymbol("when");
    static internal readonly ListTerm s71 = new ListTerm(s18, s12);
    static internal readonly ListTerm s72 = new ListTerm(s10, s71);
    static internal readonly ListTerm s73 = new ListTerm(s9, s72);
    static internal readonly ListTerm s74 = new ListTerm(s70, s73);
    static internal readonly ListTerm s75 = new ListTerm(s46, s74);
    static internal readonly ListTerm s76 = new ListTerm(s45, s75);
    static internal readonly ListTerm s77 = new ListTerm(s30, s76);
    static internal readonly ListTerm s78 = new ListTerm(s69, s77);
    static internal readonly ListTerm s79 = new ListTerm(s1, s78);
    static internal readonly SymbolTerm s80 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s81 = SymbolTerm.MakeSymbol("asked");
    static internal readonly SymbolTerm s82 = SymbolTerm.MakeSymbol("before");
    static internal readonly ListTerm s83 = new ListTerm(s82, s12);
    static internal readonly ListTerm s84 = new ListTerm(s42, s83);
    static internal readonly ListTerm s85 = new ListTerm(s41, s84);
    static internal readonly ListTerm s86 = new ListTerm(s81, s85);
    static internal readonly ListTerm s87 = new ListTerm(s9, s86);
    static internal readonly ListTerm s88 = new ListTerm(s80, s87);
    static internal readonly SymbolTerm s89 = SymbolTerm.MakeSymbol("anyone");
    static internal readonly SymbolTerm s90 = SymbolTerm.MakeSymbol("else");
    static internal readonly ListTerm s91 = new ListTerm(s90, s12);
    static internal readonly ListTerm s92 = new ListTerm(s89, s91);
    static internal readonly ListTerm s93 = new ListTerm(s81, s92);
    static internal readonly ListTerm s94 = new ListTerm(s9, s93);
    static internal readonly ListTerm s95 = new ListTerm(s80, s94);
    static internal readonly ListTerm s96 = new ListTerm(s95, s3);
    static internal readonly ListTerm s97 = new ListTerm(s88, s96);
    static internal readonly ListTerm s98 = new ListTerm(s79, s97);
    static internal readonly ListTerm s99 = new ListTerm(s68, s98);
    static internal readonly ListTerm s100 = new ListTerm(s63, s99);
    static internal readonly ListTerm s101 = new ListTerm(s53, s100);
    static internal readonly ListTerm s102 = new ListTerm(s39, s101);
    static internal readonly ListTerm s103 = new ListTerm(s25, s102);
    static internal readonly ListTerm s104 = new ListTerm(s16, s103);
    static internal readonly ListTerm s105 = new ListTerm(s2, s104);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s105.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s105), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_26 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("because");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("the");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("real");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("reason");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly ListTerm s14 = new ListTerm(s11, s13);
    static internal readonly ListTerm s15 = new ListTerm(s10, s14);
    static internal readonly ListTerm s16 = new ListTerm(s9, s15);
    static internal readonly ListTerm s17 = new ListTerm(s8, s16);
    static internal readonly ListTerm s18 = new ListTerm(s7, s17);
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("any");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("other");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("reasons");
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s24 = SymbolTerm.MakeSymbol("come");
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("to");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("mind");
    static internal readonly ListTerm s27 = new ListTerm(s26, s13);
    static internal readonly ListTerm s28 = new ListTerm(s25, s27);
    static internal readonly ListTerm s29 = new ListTerm(s24, s28);
    static internal readonly ListTerm s30 = new ListTerm(s23, s29);
    static internal readonly ListTerm s31 = new ListTerm(s22, s30);
    static internal readonly ListTerm s32 = new ListTerm(s21, s31);
    static internal readonly ListTerm s33 = new ListTerm(s20, s32);
    static internal readonly ListTerm s34 = new ListTerm(s19, s33);
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("seem");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("explain");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("anything");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("else");
    static internal readonly ListTerm s40 = new ListTerm(s39, s13);
    static internal readonly ListTerm s41 = new ListTerm(s38, s40);
    static internal readonly ListTerm s42 = new ListTerm(s37, s41);
    static internal readonly ListTerm s43 = new ListTerm(s25, s42);
    static internal readonly ListTerm s44 = new ListTerm(s36, s43);
    static internal readonly ListTerm s45 = new ListTerm(s11, s44);
    static internal readonly ListTerm s46 = new ListTerm(s8, s45);
    static internal readonly ListTerm s47 = new ListTerm(s35, s46);
    static internal readonly SymbolTerm s48 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s49 = SymbolTerm.MakeSymbol("might");
    static internal readonly SymbolTerm s50 = SymbolTerm.MakeSymbol("there");
    static internal readonly SymbolTerm s51 = SymbolTerm.MakeSymbol("be");
    static internal readonly ListTerm s52 = new ListTerm(s51, s13);
    static internal readonly ListTerm s53 = new ListTerm(s50, s52);
    static internal readonly ListTerm s54 = new ListTerm(s49, s53);
    static internal readonly ListTerm s55 = new ListTerm(s22, s54);
    static internal readonly ListTerm s56 = new ListTerm(s21, s55);
    static internal readonly ListTerm s57 = new ListTerm(s48, s56);
    static internal readonly ListTerm s58 = new ListTerm(s57, s3);
    static internal readonly ListTerm s59 = new ListTerm(s47, s58);
    static internal readonly ListTerm s60 = new ListTerm(s34, s59);
    static internal readonly ListTerm s61 = new ListTerm(s18, s60);
    static internal readonly ListTerm s62 = new ListTerm(s2, s61);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s62.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_27 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("why");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("dont");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("believe");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("I");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("not");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("will");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("good");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("time");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol(".");
    static internal readonly ListTerm s22 = new ListTerm(s21, s3);
    static internal readonly ListTerm s23 = new ListTerm(s20, s22);
    static internal readonly ListTerm s24 = new ListTerm(s19, s23);
    static internal readonly ListTerm s25 = new ListTerm(s18, s24);
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("should");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("yourself");
    static internal readonly ListTerm s28 = new ListTerm(s27, s15);
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("what");
    static internal readonly ListTerm s31 = new ListTerm(s30, s4);
    static internal readonly ListTerm s32 = new ListTerm(s31, s3);
    static internal readonly ListTerm s33 = new ListTerm(s29, s32);
    static internal readonly ListTerm s34 = new ListTerm(s33, s3);
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("want");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol("me");
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("to");
    static internal readonly IntegerTerm s38 = new IntegerTerm(2);
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("cant");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("able");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("this");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("help");
    static internal readonly SymbolTerm s45 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s46 = SymbolTerm.MakeSymbol("any");
    static internal readonly SymbolTerm s47 = SymbolTerm.MakeSymbol("idea");
    static internal readonly SymbolTerm s48 = SymbolTerm.MakeSymbol("can");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a71;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s1.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a10 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s1, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s7.Unify(((ListTerm)a10).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !s8.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            a12 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(s8, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            a13 = ((ListTerm)a12).car;
            if ( !s3.Unify(((ListTerm)a12).cdr, engine.trail) )
                return engine.fail();
        } else if ( a12.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(a13, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            if ( !s2.Unify(((ListTerm)a8).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(s2, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            a15 = ((ListTerm)a14).car;
            a16 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            a16 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(a15, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s9.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s9, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s10.Unify(((ListTerm)a17).car, engine.trail) )
                return engine.fail();
            a18 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(s10, a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s11.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s11, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s12.Unify(((ListTerm)a19).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a19).cdr;
        } else if ( a19.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(s12, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s9.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s9, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s13.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            a22 = ((ListTerm)a21).cdr;
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(s13, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            a23 = ((ListTerm)a16).car;
            a24 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a23 = engine.makeVariable();
            a24 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(a23, a24), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s16.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            a25 = ((ListTerm)a23).cdr;
        } else if ( a23.IsVariable() ){
            a25 = engine.makeVariable();
            if ( !a23.Unify(new ListTerm(s16, a25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a25.IsList() ){
            if ( !s12.Unify(((ListTerm)a25).car, engine.trail) )
                return engine.fail();
            a26 = ((ListTerm)a25).cdr;
        } else if ( a25.IsVariable() ){
            a26 = engine.makeVariable();
            if ( !a25.Unify(new ListTerm(s12, a26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a26.IsList() ){
            if ( !s17.Unify(((ListTerm)a26).car, engine.trail) )
                return engine.fail();
            a27 = ((ListTerm)a26).cdr;
        } else if ( a26.IsVariable() ){
            a27 = engine.makeVariable();
            if ( !a26.Unify(new ListTerm(s17, a27), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a27.IsList() ){
            if ( !a13.Unify(((ListTerm)a27).car, engine.trail) )
                return engine.fail();
            if ( !s25.Unify(((ListTerm)a27).cdr, engine.trail) )
                return engine.fail();
        } else if ( a27.IsVariable() ){
            if ( !a27.Unify(new ListTerm(a13, s25), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a24.IsList() ){
            a28 = ((ListTerm)a24).car;
            a29 = ((ListTerm)a24).cdr;
        } else if ( a24.IsVariable() ){
            a28 = engine.makeVariable();
            a29 = engine.makeVariable();
            if ( !a24.Unify(new ListTerm(a28, a29), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a28.IsList() ){
            if ( !s26.Unify(((ListTerm)a28).car, engine.trail) )
                return engine.fail();
            a30 = ((ListTerm)a28).cdr;
        } else if ( a28.IsVariable() ){
            a30 = engine.makeVariable();
            if ( !a28.Unify(new ListTerm(s26, a30), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a30.IsList() ){
            if ( !s10.Unify(((ListTerm)a30).car, engine.trail) )
                return engine.fail();
            a31 = ((ListTerm)a30).cdr;
        } else if ( a30.IsVariable() ){
            a31 = engine.makeVariable();
            if ( !a30.Unify(new ListTerm(s10, a31), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a31.IsList() ){
            if ( !a13.Unify(((ListTerm)a31).car, engine.trail) )
                return engine.fail();
            if ( !s28.Unify(((ListTerm)a31).cdr, engine.trail) )
                return engine.fail();
        } else if ( a31.IsVariable() ){
            if ( !a31.Unify(new ListTerm(a13, s28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a29.IsList() ){
            a32 = ((ListTerm)a29).car;
            if ( !s34.Unify(((ListTerm)a29).cdr, engine.trail) )
                return engine.fail();
        } else if ( a29.IsVariable() ){
            a32 = engine.makeVariable();
            if ( !a29.Unify(new ListTerm(a32, s34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a32.IsList() ){
            if ( !s10.Unify(((ListTerm)a32).car, engine.trail) )
                return engine.fail();
            a33 = ((ListTerm)a32).cdr;
        } else if ( a32.IsVariable() ){
            a33 = engine.makeVariable();
            if ( !a32.Unify(new ListTerm(s10, a33), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a33.IsList() ){
            if ( !s35.Unify(((ListTerm)a33).car, engine.trail) )
                return engine.fail();
            a34 = ((ListTerm)a33).cdr;
        } else if ( a33.IsVariable() ){
            a34 = engine.makeVariable();
            if ( !a33.Unify(new ListTerm(s35, a34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a34.IsList() ){
            if ( !s36.Unify(((ListTerm)a34).car, engine.trail) )
                return engine.fail();
            a35 = ((ListTerm)a34).cdr;
        } else if ( a34.IsVariable() ){
            a35 = engine.makeVariable();
            if ( !a34.Unify(new ListTerm(s36, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s37.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a35).cdr, engine.trail) )
                return engine.fail();
        } else if ( a35.IsVariable() ){
            if ( !a35.Unify(new ListTerm(s37, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a36 = ((ListTerm)a5).car;
            if ( !s3.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a36 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a36, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a36.IsList() ){
            if ( !s38.Unify(((ListTerm)a36).car, engine.trail) )
                return engine.fail();
            a37 = ((ListTerm)a36).cdr;
        } else if ( a36.IsVariable() ){
            a37 = engine.makeVariable();
            if ( !a36.Unify(new ListTerm(s38, a37), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a37.IsList() ){
            a38 = ((ListTerm)a37).car;
            a39 = ((ListTerm)a37).cdr;
        } else if ( a37.IsVariable() ){
            a38 = engine.makeVariable();
            a39 = engine.makeVariable();
            if ( !a37.Unify(new ListTerm(a38, a39), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a38.IsList() ){
            a40 = ((ListTerm)a38).cdr;
        } else if ( a38.IsVariable() ){
            a40 = engine.makeVariable();
            if ( !a38.Unify(new ListTerm(engine.makeVariable(), a40), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a40.IsList() ){
            if ( !s1.Unify(((ListTerm)a40).car, engine.trail) )
                return engine.fail();
            a41 = ((ListTerm)a40).cdr;
        } else if ( a40.IsVariable() ){
            a41 = engine.makeVariable();
            if ( !a40.Unify(new ListTerm(s1, a41), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a41.IsList() ){
            if ( !s39.Unify(((ListTerm)a41).car, engine.trail) )
                return engine.fail();
            a42 = ((ListTerm)a41).cdr;
        } else if ( a41.IsVariable() ){
            a42 = engine.makeVariable();
            if ( !a41.Unify(new ListTerm(s39, a42), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a42.IsList() ){
            if ( !s10.Unify(((ListTerm)a42).car, engine.trail) )
                return engine.fail();
            if ( !a12.Unify(((ListTerm)a42).cdr, engine.trail) )
                return engine.fail();
        } else if ( a42.IsVariable() ){
            if ( !a42.Unify(new ListTerm(s10, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !a13.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            if ( !s3.Unify(((ListTerm)a12).cdr, engine.trail) )
                return engine.fail();
        } else if ( a12.IsVariable() ){
            if ( !a12.Unify(new ListTerm(a13, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a39.IsList() ){
            if ( !s2.Unify(((ListTerm)a39).car, engine.trail) )
                return engine.fail();
            a43 = ((ListTerm)a39).cdr;
        } else if ( a39.IsVariable() ){
            a43 = engine.makeVariable();
            if ( !a39.Unify(new ListTerm(s2, a43), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a43.IsList() ){
            a44 = ((ListTerm)a43).car;
            a45 = ((ListTerm)a43).cdr;
        } else if ( a43.IsVariable() ){
            a44 = engine.makeVariable();
            a45 = engine.makeVariable();
            if ( !a43.Unify(new ListTerm(a44, a45), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a44.IsList() ){
            if ( !s9.Unify(((ListTerm)a44).car, engine.trail) )
                return engine.fail();
            a46 = ((ListTerm)a44).cdr;
        } else if ( a44.IsVariable() ){
            a46 = engine.makeVariable();
            if ( !a44.Unify(new ListTerm(s9, a46), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a46.IsList() ){
            if ( !s10.Unify(((ListTerm)a46).car, engine.trail) )
                return engine.fail();
            a47 = ((ListTerm)a46).cdr;
        } else if ( a46.IsVariable() ){
            a47 = engine.makeVariable();
            if ( !a46.Unify(new ListTerm(s10, a47), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a47.IsList() ){
            if ( !s40.Unify(((ListTerm)a47).car, engine.trail) )
                return engine.fail();
            a48 = ((ListTerm)a47).cdr;
        } else if ( a47.IsVariable() ){
            a48 = engine.makeVariable();
            if ( !a47.Unify(new ListTerm(s40, a48), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a48.IsList() ){
            if ( !s10.Unify(((ListTerm)a48).car, engine.trail) )
                return engine.fail();
            a49 = ((ListTerm)a48).cdr;
        } else if ( a48.IsVariable() ){
            a49 = engine.makeVariable();
            if ( !a48.Unify(new ListTerm(s10, a49), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a49.IsList() ){
            if ( !s26.Unify(((ListTerm)a49).car, engine.trail) )
                return engine.fail();
            a50 = ((ListTerm)a49).cdr;
        } else if ( a49.IsVariable() ){
            a50 = engine.makeVariable();
            if ( !a49.Unify(new ListTerm(s26, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s41.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            a51 = ((ListTerm)a50).cdr;
        } else if ( a50.IsVariable() ){
            a51 = engine.makeVariable();
            if ( !a50.Unify(new ListTerm(s41, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            if ( !s42.Unify(((ListTerm)a51).car, engine.trail) )
                return engine.fail();
            if ( !a35.Unify(((ListTerm)a51).cdr, engine.trail) )
                return engine.fail();
        } else if ( a51.IsVariable() ){
            if ( !a51.Unify(new ListTerm(s42, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s37.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a35).cdr, engine.trail) )
                return engine.fail();
        } else if ( a35.IsVariable() ){
            if ( !a35.Unify(new ListTerm(s37, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a45.IsList() ){
            a52 = ((ListTerm)a45).car;
            a53 = ((ListTerm)a45).cdr;
        } else if ( a45.IsVariable() ){
            a52 = engine.makeVariable();
            a53 = engine.makeVariable();
            if ( !a45.Unify(new ListTerm(a52, a53), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a52.IsList() ){
            if ( !s9.Unify(((ListTerm)a52).car, engine.trail) )
                return engine.fail();
            a54 = ((ListTerm)a52).cdr;
        } else if ( a52.IsVariable() ){
            a54 = engine.makeVariable();
            if ( !a52.Unify(new ListTerm(s9, a54), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a54.IsList() ){
            if ( !s10.Unify(((ListTerm)a54).car, engine.trail) )
                return engine.fail();
            a55 = ((ListTerm)a54).cdr;
        } else if ( a54.IsVariable() ){
            a55 = engine.makeVariable();
            if ( !a54.Unify(new ListTerm(s10, a55), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a55.IsList() ){
            if ( !s35.Unify(((ListTerm)a55).car, engine.trail) )
                return engine.fail();
            a56 = ((ListTerm)a55).cdr;
        } else if ( a55.IsVariable() ){
            a56 = engine.makeVariable();
            if ( !a55.Unify(new ListTerm(s35, a56), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a56.IsList() ){
            if ( !s37.Unify(((ListTerm)a56).car, engine.trail) )
                return engine.fail();
            if ( !a50.Unify(((ListTerm)a56).cdr, engine.trail) )
                return engine.fail();
        } else if ( a56.IsVariable() ){
            if ( !a56.Unify(new ListTerm(s37, a50), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a50.IsList() ){
            if ( !s41.Unify(((ListTerm)a50).car, engine.trail) )
                return engine.fail();
            if ( !a51.Unify(((ListTerm)a50).cdr, engine.trail) )
                return engine.fail();
        } else if ( a50.IsVariable() ){
            if ( !a50.Unify(new ListTerm(s41, a51), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a51.IsList() ){
            if ( !s42.Unify(((ListTerm)a51).car, engine.trail) )
                return engine.fail();
            if ( !a35.Unify(((ListTerm)a51).cdr, engine.trail) )
                return engine.fail();
        } else if ( a51.IsVariable() ){
            if ( !a51.Unify(new ListTerm(s42, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s37.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a35).cdr, engine.trail) )
                return engine.fail();
        } else if ( a35.IsVariable() ){
            if ( !a35.Unify(new ListTerm(s37, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a53.IsList() ){
            a57 = ((ListTerm)a53).car;
            a58 = ((ListTerm)a53).cdr;
        } else if ( a53.IsVariable() ){
            a57 = engine.makeVariable();
            a58 = engine.makeVariable();
            if ( !a53.Unify(new ListTerm(a57, a58), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a57.IsList() ){
            if ( !s9.Unify(((ListTerm)a57).car, engine.trail) )
                return engine.fail();
            a59 = ((ListTerm)a57).cdr;
        } else if ( a57.IsVariable() ){
            a59 = engine.makeVariable();
            if ( !a57.Unify(new ListTerm(s9, a59), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a59.IsList() ){
            if ( !s10.Unify(((ListTerm)a59).car, engine.trail) )
                return engine.fail();
            a60 = ((ListTerm)a59).cdr;
        } else if ( a59.IsVariable() ){
            a60 = engine.makeVariable();
            if ( !a59.Unify(new ListTerm(s10, a60), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a60.IsList() ){
            if ( !s11.Unify(((ListTerm)a60).car, engine.trail) )
                return engine.fail();
            a61 = ((ListTerm)a60).cdr;
        } else if ( a60.IsVariable() ){
            a61 = engine.makeVariable();
            if ( !a60.Unify(new ListTerm(s11, a61), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a61.IsList() ){
            if ( !s43.Unify(((ListTerm)a61).car, engine.trail) )
                return engine.fail();
            a62 = ((ListTerm)a61).cdr;
        } else if ( a61.IsVariable() ){
            a62 = engine.makeVariable();
            if ( !a61.Unify(new ListTerm(s43, a62), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a62.IsList() ){
            if ( !s17.Unify(((ListTerm)a62).car, engine.trail) )
                return engine.fail();
            a63 = ((ListTerm)a62).cdr;
        } else if ( a62.IsVariable() ){
            a63 = engine.makeVariable();
            if ( !a62.Unify(new ListTerm(s17, a63), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a63.IsList() ){
            if ( !s44.Unify(((ListTerm)a63).car, engine.trail) )
                return engine.fail();
            a64 = ((ListTerm)a63).cdr;
        } else if ( a63.IsVariable() ){
            a64 = engine.makeVariable();
            if ( !a63.Unify(new ListTerm(s44, a64), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a64.IsList() ){
            if ( !s10.Unify(((ListTerm)a64).car, engine.trail) )
                return engine.fail();
            if ( !a35.Unify(((ListTerm)a64).cdr, engine.trail) )
                return engine.fail();
        } else if ( a64.IsVariable() ){
            if ( !a64.Unify(new ListTerm(s10, a35), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a35.IsList() ){
            if ( !s37.Unify(((ListTerm)a35).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a35).cdr, engine.trail) )
                return engine.fail();
        } else if ( a35.IsVariable() ){
            if ( !a35.Unify(new ListTerm(s37, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a58.IsList() ){
            a65 = ((ListTerm)a58).car;
            if ( !s34.Unify(((ListTerm)a58).cdr, engine.trail) )
                return engine.fail();
        } else if ( a58.IsVariable() ){
            a65 = engine.makeVariable();
            if ( !a58.Unify(new ListTerm(a65, s34), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a65.IsList() ){
            if ( !s45.Unify(((ListTerm)a65).car, engine.trail) )
                return engine.fail();
            a66 = ((ListTerm)a65).cdr;
        } else if ( a65.IsVariable() ){
            a66 = engine.makeVariable();
            if ( !a65.Unify(new ListTerm(s45, a66), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a66.IsList() ){
            if ( !s10.Unify(((ListTerm)a66).car, engine.trail) )
                return engine.fail();
            a67 = ((ListTerm)a66).cdr;
        } else if ( a66.IsVariable() ){
            a67 = engine.makeVariable();
            if ( !a66.Unify(new ListTerm(s10, a67), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a67.IsList() ){
            if ( !s46.Unify(((ListTerm)a67).car, engine.trail) )
                return engine.fail();
            a68 = ((ListTerm)a67).cdr;
        } else if ( a67.IsVariable() ){
            a68 = engine.makeVariable();
            if ( !a67.Unify(new ListTerm(s46, a68), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a68.IsList() ){
            if ( !s47.Unify(((ListTerm)a68).car, engine.trail) )
                return engine.fail();
            a69 = ((ListTerm)a68).cdr;
        } else if ( a68.IsVariable() ){
            a69 = engine.makeVariable();
            if ( !a68.Unify(new ListTerm(s47, a69), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a69.IsList() ){
            if ( !s1.Unify(((ListTerm)a69).car, engine.trail) )
                return engine.fail();
            a70 = ((ListTerm)a69).cdr;
        } else if ( a69.IsVariable() ){
            a70 = engine.makeVariable();
            if ( !a69.Unify(new ListTerm(s1, a70), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a70.IsList() ){
            if ( !s10.Unify(((ListTerm)a70).car, engine.trail) )
                return engine.fail();
            a71 = ((ListTerm)a70).cdr;
        } else if ( a70.IsVariable() ){
            a71 = engine.makeVariable();
            if ( !a70.Unify(new ListTerm(s10, a71), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a71.IsList() ){
            if ( !s48.Unify(((ListTerm)a71).car, engine.trail) )
                return engine.fail();
            if ( !a21.Unify(((ListTerm)a71).cdr, engine.trail) )
                return engine.fail();
        } else if ( a71.IsVariable() ){
            if ( !a71.Unify(new ListTerm(s48, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !s13.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            if ( !a22.Unify(((ListTerm)a21).cdr, engine.trail) )
                return engine.fail();
        } else if ( a21.IsVariable() ){
            if ( !a21.Unify(new ListTerm(s13, a22), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !a13.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(a13, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_28 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("everyone");
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("*");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("everybody");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("nobody");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("noone");
    static internal readonly IntegerTerm s11 = new IntegerTerm(0);
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol(",");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("of");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("anyone");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s22 = SymbolTerm.MakeSymbol("particular");
    static internal readonly ListTerm s23 = new ListTerm(s22, s15);
    static internal readonly ListTerm s24 = new ListTerm(s21, s23);
    static internal readonly ListTerm s25 = new ListTerm(s20, s24);
    static internal readonly ListTerm s26 = new ListTerm(s19, s25);
    static internal readonly ListTerm s27 = new ListTerm(s18, s26);
    static internal readonly ListTerm s28 = new ListTerm(s17, s27);
    static internal readonly ListTerm s29 = new ListTerm(s16, s28);
    static internal readonly SymbolTerm s30 = SymbolTerm.MakeSymbol("who");
    static internal readonly SymbolTerm s31 = SymbolTerm.MakeSymbol("for");
    static internal readonly SymbolTerm s32 = SymbolTerm.MakeSymbol("example");
    static internal readonly ListTerm s33 = new ListTerm(s32, s15);
    static internal readonly ListTerm s34 = new ListTerm(s31, s33);
    static internal readonly ListTerm s35 = new ListTerm(s13, s34);
    static internal readonly ListTerm s36 = new ListTerm(s30, s35);
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("thinking");
    static internal readonly SymbolTerm s39 = SymbolTerm.MakeSymbol("a");
    static internal readonly SymbolTerm s40 = SymbolTerm.MakeSymbol("very");
    static internal readonly SymbolTerm s41 = SymbolTerm.MakeSymbol("special");
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("person");
    static internal readonly ListTerm s43 = new ListTerm(s42, s15);
    static internal readonly ListTerm s44 = new ListTerm(s41, s43);
    static internal readonly ListTerm s45 = new ListTerm(s40, s44);
    static internal readonly ListTerm s46 = new ListTerm(s39, s45);
    static internal readonly ListTerm s47 = new ListTerm(s19, s46);
    static internal readonly ListTerm s48 = new ListTerm(s38, s47);
    static internal readonly ListTerm s49 = new ListTerm(s37, s48);
    static internal readonly ListTerm s50 = new ListTerm(s17, s49);
    static internal readonly SymbolTerm s51 = SymbolTerm.MakeSymbol("may");
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("i");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol("ask");
    static internal readonly ListTerm s54 = new ListTerm(s53, s15);
    static internal readonly ListTerm s55 = new ListTerm(s52, s54);
    static internal readonly ListTerm s56 = new ListTerm(s51, s55);
    static internal readonly ListTerm s57 = new ListTerm(s13, s56);
    static internal readonly ListTerm s58 = new ListTerm(s30, s57);
    static internal readonly SymbolTerm s59 = SymbolTerm.MakeSymbol("someone");
    static internal readonly SymbolTerm s60 = SymbolTerm.MakeSymbol("perhaps");
    static internal readonly ListTerm s61 = new ListTerm(s60, s15);
    static internal readonly ListTerm s62 = new ListTerm(s41, s61);
    static internal readonly ListTerm s63 = new ListTerm(s59, s62);
    static internal readonly SymbolTerm s64 = SymbolTerm.MakeSymbol("have");
    static internal readonly SymbolTerm s65 = SymbolTerm.MakeSymbol("paticular");
    static internal readonly SymbolTerm s66 = SymbolTerm.MakeSymbol("mind");
    static internal readonly SymbolTerm s67 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s68 = SymbolTerm.MakeSymbol("not");
    static internal readonly ListTerm s69 = new ListTerm(s68, s15);
    static internal readonly ListTerm s70 = new ListTerm(s17, s69);
    static internal readonly ListTerm s71 = new ListTerm(s67, s70);
    static internal readonly ListTerm s72 = new ListTerm(s13, s71);
    static internal readonly ListTerm s73 = new ListTerm(s66, s72);
    static internal readonly ListTerm s74 = new ListTerm(s21, s73);
    static internal readonly ListTerm s75 = new ListTerm(s42, s74);
    static internal readonly ListTerm s76 = new ListTerm(s65, s75);
    static internal readonly ListTerm s77 = new ListTerm(s39, s76);
    static internal readonly ListTerm s78 = new ListTerm(s64, s77);
    static internal readonly ListTerm s79 = new ListTerm(s17, s78);
    static internal readonly SymbolTerm s80 = SymbolTerm.MakeSymbol("talking");
    static internal readonly SymbolTerm s81 = SymbolTerm.MakeSymbol("about");
    static internal readonly ListTerm s82 = new ListTerm(s81, s15);
    static internal readonly ListTerm s83 = new ListTerm(s80, s82);
    static internal readonly ListTerm s84 = new ListTerm(s37, s83);
    static internal readonly ListTerm s85 = new ListTerm(s17, s84);
    static internal readonly ListTerm s86 = new ListTerm(s18, s85);
    static internal readonly ListTerm s87 = new ListTerm(s17, s86);
    static internal readonly ListTerm s88 = new ListTerm(s67, s87);
    static internal readonly ListTerm s89 = new ListTerm(s30, s88);
    static internal readonly ListTerm s90 = new ListTerm(s89, s3);
    static internal readonly ListTerm s91 = new ListTerm(s79, s90);
    static internal readonly ListTerm s92 = new ListTerm(s63, s91);
    static internal readonly ListTerm s93 = new ListTerm(s58, s92);
    static internal readonly ListTerm s94 = new ListTerm(s50, s93);
    static internal readonly ListTerm s95 = new ListTerm(s36, s94);
    static internal readonly ListTerm s96 = new ListTerm(s29, s95);
    static internal readonly SymbolTerm s97 = SymbolTerm.MakeSymbol("surely");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
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
        if ( a6.IsList() ){
            a8 = ((ListTerm)a6).cdr;
        } else if ( a6.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            a9 = ((ListTerm)a8).car;
            a10 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            a10 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(a9, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s7.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s7, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !s1.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            a12 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(s1, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s8.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s8, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            if ( !s9.Unify(((ListTerm)a13).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(s9, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s10.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s10, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            a16 = ((ListTerm)a15).car;
            if ( !s3.Unify(((ListTerm)a15).cdr, engine.trail) )
                return engine.fail();
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(a16, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            if ( !s3.Unify(((ListTerm)a10).cdr, engine.trail) )
                return engine.fail();
        } else if ( a10.IsVariable() ){
            if ( !a10.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            if ( !s11.Unify(((ListTerm)a7).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(s11, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            a18 = ((ListTerm)a17).car;
            a19 = ((ListTerm)a17).cdr;
        } else if ( a17.IsVariable() ){
            a18 = engine.makeVariable();
            a19 = engine.makeVariable();
            if ( !a17.Unify(new ListTerm(a18, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s12.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a20 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s12, a20), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s13.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s13, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !a16.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a21).cdr, engine.trail) )
                return engine.fail();
        } else if ( a21.IsVariable() ){
            if ( !a21.Unify(new ListTerm(a16, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            a22 = ((ListTerm)a19).car;
            if ( !s96.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a19.Unify(new ListTerm(a22, s96), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s97.Unify(((ListTerm)a22).car, engine.trail) )
                return engine.fail();
            a23 = ((ListTerm)a22).cdr;
        } else if ( a22.IsVariable() ){
            a23 = engine.makeVariable();
            if ( !a22.Unify(new ListTerm(s97, a23), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a23.IsList() ){
            if ( !s68.Unify(((ListTerm)a23).car, engine.trail) )
                return engine.fail();
            if ( !a21.Unify(((ListTerm)a23).cdr, engine.trail) )
                return engine.fail();
        } else if ( a23.IsVariable() ){
            if ( !a23.Unify(new ListTerm(s68, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            if ( !a16.Unify(((ListTerm)a21).car, engine.trail) )
                return engine.fail();
            if ( !s15.Unify(((ListTerm)a21).cdr, engine.trail) )
                return engine.fail();
        } else if ( a21.IsVariable() ){
            if ( !a21.Unify(new ListTerm(a16, s15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_29 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("always");
    static internal readonly IntegerTerm s2 = new IntegerTerm(1);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(0);
    static internal readonly SymbolTerm s7 = SymbolTerm.MakeSymbol("can");
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("think");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("of");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("a");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("specific");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("example");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s15 = new ListTerm(s14, s3);
    static internal readonly ListTerm s16 = new ListTerm(s13, s15);
    static internal readonly ListTerm s17 = new ListTerm(s12, s16);
    static internal readonly ListTerm s18 = new ListTerm(s11, s17);
    static internal readonly ListTerm s19 = new ListTerm(s10, s18);
    static internal readonly ListTerm s20 = new ListTerm(s9, s19);
    static internal readonly ListTerm s21 = new ListTerm(s8, s20);
    static internal readonly ListTerm s22 = new ListTerm(s7, s21);
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("when");
    static internal readonly ListTerm s24 = new ListTerm(s23, s15);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("incident");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("thinking");
    static internal readonly ListTerm s29 = new ListTerm(s10, s15);
    static internal readonly ListTerm s30 = new ListTerm(s28, s29);
    static internal readonly ListTerm s31 = new ListTerm(s8, s30);
    static internal readonly ListTerm s32 = new ListTerm(s27, s31);
    static internal readonly ListTerm s33 = new ListTerm(s26, s32);
    static internal readonly ListTerm s34 = new ListTerm(s25, s33);
    static internal readonly SymbolTerm s35 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s36 = SymbolTerm.MakeSymbol(",");
    static internal readonly ListTerm s37 = new ListTerm(s1, s15);
    static internal readonly ListTerm s38 = new ListTerm(s36, s37);
    static internal readonly ListTerm s39 = new ListTerm(s35, s38);
    static internal readonly ListTerm s40 = new ListTerm(s39, s3);
    static internal readonly ListTerm s41 = new ListTerm(s34, s40);
    static internal readonly ListTerm s42 = new ListTerm(s24, s41);
    static internal readonly ListTerm s43 = new ListTerm(s22, s42);
    static internal readonly ListTerm s44 = new ListTerm(s6, s43);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s2.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s2, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s44.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s44), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_30 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("like");
    static internal readonly IntegerTerm s2 = new IntegerTerm(10);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("equal");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("dit");
    static internal readonly ListTerm s10 = new ListTerm(s9, s4);
    static internal readonly ListTerm s11 = new ListTerm(s10, s3);
    static internal readonly ListTerm s12 = new ListTerm(s8, s11);
    static internal readonly ListTerm s13 = new ListTerm(s12, s3);
    static internal readonly ListTerm s14 = new ListTerm(s7, s13);
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("*");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("im");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("youre");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("am");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s20 = SymbolTerm.MakeSymbol("are");
    static internal readonly SymbolTerm s21 = SymbolTerm.MakeSymbol("was");
    static internal readonly IntegerTerm s22 = new IntegerTerm(2);
    static internal readonly SymbolTerm s23 = SymbolTerm.MakeSymbol("newkey");
    static internal readonly ListTerm s24 = new ListTerm(s23, s3);
    static internal readonly ListTerm s25 = new ListTerm(s24, s3);
    static internal readonly ListTerm s26 = new ListTerm(s7, s25);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            a7 = ((ListTerm)a6).car;
            if ( !s14.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            a7 = engine.makeVariable();
            if ( !a6.Unify(new ListTerm(a7, s14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a8 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(engine.makeVariable(), a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a8.IsList() ){
            a9 = ((ListTerm)a8).car;
            a10 = ((ListTerm)a8).cdr;
        } else if ( a8.IsVariable() ){
            a9 = engine.makeVariable();
            a10 = engine.makeVariable();
            if ( !a8.Unify(new ListTerm(a9, a10), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            if ( !s15.Unify(((ListTerm)a9).car, engine.trail) )
                return engine.fail();
            a11 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a11 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(s15, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !s16.Unify(((ListTerm)a11).car, engine.trail) )
                return engine.fail();
            a12 = ((ListTerm)a11).cdr;
        } else if ( a11.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a11.Unify(new ListTerm(s16, a12), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a12.IsList() ){
            if ( !s17.Unify(((ListTerm)a12).car, engine.trail) )
                return engine.fail();
            a13 = ((ListTerm)a12).cdr;
        } else if ( a12.IsVariable() ){
            a13 = engine.makeVariable();
            if ( !a12.Unify(new ListTerm(s17, a13), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a13.IsList() ){
            if ( !s18.Unify(((ListTerm)a13).car, engine.trail) )
                return engine.fail();
            a14 = ((ListTerm)a13).cdr;
        } else if ( a13.IsVariable() ){
            a14 = engine.makeVariable();
            if ( !a13.Unify(new ListTerm(s18, a14), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a14.IsList() ){
            if ( !s19.Unify(((ListTerm)a14).car, engine.trail) )
                return engine.fail();
            a15 = ((ListTerm)a14).cdr;
        } else if ( a14.IsVariable() ){
            a15 = engine.makeVariable();
            if ( !a14.Unify(new ListTerm(s19, a15), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a15.IsList() ){
            if ( !s20.Unify(((ListTerm)a15).car, engine.trail) )
                return engine.fail();
            a16 = ((ListTerm)a15).cdr;
        } else if ( a15.IsVariable() ){
            a16 = engine.makeVariable();
            if ( !a15.Unify(new ListTerm(s20, a16), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a16.IsList() ){
            if ( !s21.Unify(((ListTerm)a16).car, engine.trail) )
                return engine.fail();
            a17 = ((ListTerm)a16).cdr;
        } else if ( a16.IsVariable() ){
            a17 = engine.makeVariable();
            if ( !a16.Unify(new ListTerm(s21, a17), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a17.IsList() ){
            if ( !s3.Unify(((ListTerm)a17).cdr, engine.trail) )
                return engine.fail();
        } else if ( a17.IsVariable() ){
            if ( !a17.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a10.IsList() ){
            a18 = ((ListTerm)a10).cdr;
        } else if ( a10.IsVariable() ){
            a18 = engine.makeVariable();
            if ( !a10.Unify(new ListTerm(engine.makeVariable(), a18), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a18.IsList() ){
            if ( !s1.Unify(((ListTerm)a18).car, engine.trail) )
                return engine.fail();
            a19 = ((ListTerm)a18).cdr;
        } else if ( a18.IsVariable() ){
            a19 = engine.makeVariable();
            if ( !a18.Unify(new ListTerm(s1, a19), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a19.IsList() ){
            if ( !s3.Unify(((ListTerm)a19).cdr, engine.trail) )
                return engine.fail();
        } else if ( a19.IsVariable() ){
            if ( !a19.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a20 = ((ListTerm)a5).car;
            if ( !s3.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a20 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a20, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a20.IsList() ){
            if ( !s22.Unify(((ListTerm)a20).car, engine.trail) )
                return engine.fail();
            a21 = ((ListTerm)a20).cdr;
        } else if ( a20.IsVariable() ){
            a21 = engine.makeVariable();
            if ( !a20.Unify(new ListTerm(s22, a21), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a21.IsList() ){
            a22 = ((ListTerm)a21).car;
            if ( !s26.Unify(((ListTerm)a21).cdr, engine.trail) )
                return engine.fail();
        } else if ( a21.IsVariable() ){
            a22 = engine.makeVariable();
            if ( !a21.Unify(new ListTerm(a22, s26), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a22.IsList() ){
            if ( !s3.Unify(((ListTerm)a22).cdr, engine.trail) )
                return engine.fail();
        } else if ( a22.IsVariable() ){
            if ( !a22.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_31 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("dit");
    static internal readonly IntegerTerm s2 = new IntegerTerm(10);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("in");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol("what");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("way");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("?");
    static internal readonly ListTerm s12 = new ListTerm(s11, s3);
    static internal readonly ListTerm s13 = new ListTerm(s10, s12);
    static internal readonly ListTerm s14 = new ListTerm(s9, s13);
    static internal readonly ListTerm s15 = new ListTerm(s8, s14);
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("resemblance");
    static internal readonly SymbolTerm s17 = SymbolTerm.MakeSymbol("do");
    static internal readonly SymbolTerm s18 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s19 = SymbolTerm.MakeSymbol("see");
    static internal readonly ListTerm s20 = new ListTerm(s19, s12);
    static internal readonly ListTerm s21 = new ListTerm(s18, s20);
    static internal readonly ListTerm s22 = new ListTerm(s17, s21);
    static internal readonly ListTerm s23 = new ListTerm(s16, s22);
    static internal readonly ListTerm s24 = new ListTerm(s9, s23);
    static internal readonly SymbolTerm s25 = SymbolTerm.MakeSymbol("does");
    static internal readonly SymbolTerm s26 = SymbolTerm.MakeSymbol("that");
    static internal readonly SymbolTerm s27 = SymbolTerm.MakeSymbol("similarity");
    static internal readonly SymbolTerm s28 = SymbolTerm.MakeSymbol("suggest");
    static internal readonly SymbolTerm s29 = SymbolTerm.MakeSymbol("to");
    static internal readonly ListTerm s30 = new ListTerm(s18, s12);
    static internal readonly ListTerm s31 = new ListTerm(s29, s30);
    static internal readonly ListTerm s32 = new ListTerm(s28, s31);
    static internal readonly ListTerm s33 = new ListTerm(s27, s32);
    static internal readonly ListTerm s34 = new ListTerm(s26, s33);
    static internal readonly ListTerm s35 = new ListTerm(s25, s34);
    static internal readonly ListTerm s36 = new ListTerm(s9, s35);
    static internal readonly SymbolTerm s37 = SymbolTerm.MakeSymbol("other");
    static internal readonly SymbolTerm s38 = SymbolTerm.MakeSymbol("connections");
    static internal readonly ListTerm s39 = new ListTerm(s38, s22);
    static internal readonly ListTerm s40 = new ListTerm(s37, s39);
    static internal readonly ListTerm s41 = new ListTerm(s9, s40);
    static internal readonly SymbolTerm s42 = SymbolTerm.MakeSymbol("so");
    static internal readonly SymbolTerm s43 = SymbolTerm.MakeSymbol("suppose");
    static internal readonly SymbolTerm s44 = SymbolTerm.MakeSymbol("means");
    static internal readonly ListTerm s45 = new ListTerm(s44, s12);
    static internal readonly ListTerm s46 = new ListTerm(s16, s45);
    static internal readonly ListTerm s47 = new ListTerm(s26, s46);
    static internal readonly ListTerm s48 = new ListTerm(s43, s47);
    static internal readonly ListTerm s49 = new ListTerm(s18, s48);
    static internal readonly ListTerm s50 = new ListTerm(s42, s49);
    static internal readonly ListTerm s51 = new ListTerm(s9, s50);
    static internal readonly SymbolTerm s52 = SymbolTerm.MakeSymbol("is");
    static internal readonly SymbolTerm s53 = SymbolTerm.MakeSymbol("the");
    static internal readonly SymbolTerm s54 = SymbolTerm.MakeSymbol("connection");
    static internal readonly SymbolTerm s55 = SymbolTerm.MakeSymbol(",");
    static internal readonly ListTerm s56 = new ListTerm(s43, s12);
    static internal readonly ListTerm s57 = new ListTerm(s18, s56);
    static internal readonly ListTerm s58 = new ListTerm(s17, s57);
    static internal readonly ListTerm s59 = new ListTerm(s55, s58);
    static internal readonly ListTerm s60 = new ListTerm(s54, s59);
    static internal readonly ListTerm s61 = new ListTerm(s53, s60);
    static internal readonly ListTerm s62 = new ListTerm(s52, s61);
    static internal readonly ListTerm s63 = new ListTerm(s9, s62);
    static internal readonly SymbolTerm s64 = SymbolTerm.MakeSymbol("could");
    static internal readonly SymbolTerm s65 = SymbolTerm.MakeSymbol("there");
    static internal readonly SymbolTerm s66 = SymbolTerm.MakeSymbol("really");
    static internal readonly SymbolTerm s67 = SymbolTerm.MakeSymbol("be");
    static internal readonly SymbolTerm s68 = SymbolTerm.MakeSymbol("some");
    static internal readonly ListTerm s69 = new ListTerm(s54, s12);
    static internal readonly ListTerm s70 = new ListTerm(s68, s69);
    static internal readonly ListTerm s71 = new ListTerm(s67, s70);
    static internal readonly ListTerm s72 = new ListTerm(s66, s71);
    static internal readonly ListTerm s73 = new ListTerm(s65, s72);
    static internal readonly ListTerm s74 = new ListTerm(s64, s73);
    static internal readonly SymbolTerm s75 = SymbolTerm.MakeSymbol("how");
    static internal readonly ListTerm s76 = new ListTerm(s75, s12);
    static internal readonly ListTerm s77 = new ListTerm(s76, s3);
    static internal readonly ListTerm s78 = new ListTerm(s74, s77);
    static internal readonly ListTerm s79 = new ListTerm(s63, s78);
    static internal readonly ListTerm s80 = new ListTerm(s51, s79);
    static internal readonly ListTerm s81 = new ListTerm(s41, s80);
    static internal readonly ListTerm s82 = new ListTerm(s36, s81);
    static internal readonly ListTerm s83 = new ListTerm(s24, s82);
    static internal readonly ListTerm s84 = new ListTerm(s15, s83);
    static internal readonly ListTerm s85 = new ListTerm(s7, s84);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s85.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s85), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Rules_1_32 : Rules_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("quit");
    static internal readonly IntegerTerm s2 = new IntegerTerm(100);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");
    static internal readonly ListTerm s4 = new ListTerm(s2, s3);
    static internal readonly ListTerm s5 = new ListTerm(s1, s4);
    static internal readonly IntegerTerm s6 = new IntegerTerm(1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(0);
    static internal readonly SymbolTerm s8 = SymbolTerm.MakeSymbol("goodbye");
    static internal readonly SymbolTerm s9 = SymbolTerm.MakeSymbol(".");
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("My");
    static internal readonly SymbolTerm s11 = SymbolTerm.MakeSymbol("secretary");
    static internal readonly SymbolTerm s12 = SymbolTerm.MakeSymbol("will");
    static internal readonly SymbolTerm s13 = SymbolTerm.MakeSymbol("send");
    static internal readonly SymbolTerm s14 = SymbolTerm.MakeSymbol("you");
    static internal readonly SymbolTerm s15 = SymbolTerm.MakeSymbol("a");
    static internal readonly SymbolTerm s16 = SymbolTerm.MakeSymbol("bill");
    static internal readonly ListTerm s17 = new ListTerm(s9, s3);
    static internal readonly ListTerm s18 = new ListTerm(s16, s17);
    static internal readonly ListTerm s19 = new ListTerm(s15, s18);
    static internal readonly ListTerm s20 = new ListTerm(s14, s19);
    static internal readonly ListTerm s21 = new ListTerm(s13, s20);
    static internal readonly ListTerm s22 = new ListTerm(s12, s21);
    static internal readonly ListTerm s23 = new ListTerm(s11, s22);
    static internal readonly ListTerm s24 = new ListTerm(s10, s23);
    static internal readonly ListTerm s25 = new ListTerm(s9, s24);
    static internal readonly ListTerm s26 = new ListTerm(s8, s25);
    static internal readonly ListTerm s27 = new ListTerm(s26, s3);
    static internal readonly ListTerm s28 = new ListTerm(s7, s27);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            if ( !s5.Unify(((ListTerm)a1).car, engine.trail) )
                return engine.fail();
            a2 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(s5, a2), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            if ( !s3.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a4 = ((ListTerm)a3).car;
            if ( !s3.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s6.Unify(((ListTerm)a4).car, engine.trail) )
                return engine.fail();
            a5 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(s6, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a5.IsList() ){
            a6 = ((ListTerm)a5).car;
            if ( !s28.Unify(((ListTerm)a5).cdr, engine.trail) )
                return engine.fail();
        } else if ( a5.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a5.Unify(new ListTerm(a6, s28), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a6.IsList() ){
            if ( !s3.Unify(((ListTerm)a6).cdr, engine.trail) )
                return engine.fail();
        } else if ( a6.IsVariable() ){
            if ( !a6.Unify(new ListTerm(engine.makeVariable(), s3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}
}

