/*
 * *** Please do not edit ! ***
 * @(#) MyCharType_2.cs
 * @procedure my_char_type/2 in eliza.pl
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

public class MyCharType_2 : Predicate {
    static internal readonly Predicate MyCharType_2_1 = new Predicates.MyCharType_2_1();
    static internal readonly Predicate MyCharType_2_2 = new Predicates.MyCharType_2_2();
    static internal readonly Predicate MyCharType_2_3 = new Predicates.MyCharType_2_3();
    static internal readonly Predicate MyCharType_2_4 = new Predicates.MyCharType_2_4();
    static internal readonly Predicate MyCharType_2_5 = new Predicates.MyCharType_2_5();
    static internal readonly Predicate MyCharType_2_6 = new Predicates.MyCharType_2_6();
    static internal readonly Predicate MyCharType_2_7 = new Predicates.MyCharType_2_7();
    static internal readonly Predicate MyCharType_2_8 = new Predicates.MyCharType_2_8();
    static internal readonly Predicate MyCharType_2_9 = new Predicates.MyCharType_2_9();
    static internal readonly Predicate MyCharType_2_10 = new Predicates.MyCharType_2_10();
    static internal readonly Predicate MyCharType_2_con = new Predicates.MyCharType_2_con();
    static internal readonly Predicate MyCharType_2_lis = new Predicates.MyCharType_2_lis();
    static internal readonly Predicate MyCharType_2_str = new Predicates.MyCharType_2_str();
    static internal readonly Predicate MyCharType_2_var = new Predicates.MyCharType_2_var();

    public Term arg1, arg2;

    public MyCharType_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public MyCharType_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   MyCharType_2_var,
                                   MyCharType_2_var,
                                   MyCharType_2_con,
                                   MyCharType_2_str,
                                   MyCharType_2_lis
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "my_char_type(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class MyCharType_2_var : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_1 = new Predicates.MyCharType_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MyCharType_2_1, MyCharType_2_var_1);
    }
}

sealed class MyCharType_2_var_1 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_2 = new Predicates.MyCharType_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_2, MyCharType_2_var_2);
    }
}

sealed class MyCharType_2_var_2 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_3 = new Predicates.MyCharType_2_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_3, MyCharType_2_var_3);
    }
}

sealed class MyCharType_2_var_3 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_4 = new Predicates.MyCharType_2_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_4, MyCharType_2_var_4);
    }
}

sealed class MyCharType_2_var_4 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_5 = new Predicates.MyCharType_2_var_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_5, MyCharType_2_var_5);
    }
}

sealed class MyCharType_2_var_5 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_6 = new Predicates.MyCharType_2_var_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_6, MyCharType_2_var_6);
    }
}

sealed class MyCharType_2_var_6 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_7 = new Predicates.MyCharType_2_var_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_7, MyCharType_2_var_7);
    }
}

sealed class MyCharType_2_var_7 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_8 = new Predicates.MyCharType_2_var_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_8, MyCharType_2_var_8);
    }
}

sealed class MyCharType_2_var_8 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_var_9 = new Predicates.MyCharType_2_var_9();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_9, MyCharType_2_var_9);
    }
}

sealed class MyCharType_2_var_9 : MyCharType_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MyCharType_2_10);
    }
}

sealed class MyCharType_2_con : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_1 = new Predicates.MyCharType_2_con_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MyCharType_2_2, MyCharType_2_con_1);
    }
}

sealed class MyCharType_2_con_1 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_2 = new Predicates.MyCharType_2_con_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_3, MyCharType_2_con_2);
    }
}

sealed class MyCharType_2_con_2 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_3 = new Predicates.MyCharType_2_con_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_4, MyCharType_2_con_3);
    }
}

sealed class MyCharType_2_con_3 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_4 = new Predicates.MyCharType_2_con_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_5, MyCharType_2_con_4);
    }
}

sealed class MyCharType_2_con_4 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_5 = new Predicates.MyCharType_2_con_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_6, MyCharType_2_con_5);
    }
}

sealed class MyCharType_2_con_5 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_6 = new Predicates.MyCharType_2_con_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_7, MyCharType_2_con_6);
    }
}

sealed class MyCharType_2_con_6 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_7 = new Predicates.MyCharType_2_con_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_8, MyCharType_2_con_7);
    }
}

sealed class MyCharType_2_con_7 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_con_8 = new Predicates.MyCharType_2_con_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_9, MyCharType_2_con_8);
    }
}

sealed class MyCharType_2_con_8 : MyCharType_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MyCharType_2_10);
    }
}

sealed class MyCharType_2_str : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_1 = new Predicates.MyCharType_2_str_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MyCharType_2_2, MyCharType_2_str_1);
    }
}

sealed class MyCharType_2_str_1 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_2 = new Predicates.MyCharType_2_str_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_3, MyCharType_2_str_2);
    }
}

sealed class MyCharType_2_str_2 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_3 = new Predicates.MyCharType_2_str_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_4, MyCharType_2_str_3);
    }
}

sealed class MyCharType_2_str_3 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_4 = new Predicates.MyCharType_2_str_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_5, MyCharType_2_str_4);
    }
}

sealed class MyCharType_2_str_4 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_5 = new Predicates.MyCharType_2_str_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_6, MyCharType_2_str_5);
    }
}

sealed class MyCharType_2_str_5 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_6 = new Predicates.MyCharType_2_str_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_7, MyCharType_2_str_6);
    }
}

sealed class MyCharType_2_str_6 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_7 = new Predicates.MyCharType_2_str_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_8, MyCharType_2_str_7);
    }
}

sealed class MyCharType_2_str_7 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_str_8 = new Predicates.MyCharType_2_str_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_9, MyCharType_2_str_8);
    }
}

sealed class MyCharType_2_str_8 : MyCharType_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MyCharType_2_10);
    }
}

sealed class MyCharType_2_lis : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_1 = new Predicates.MyCharType_2_lis_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(MyCharType_2_2, MyCharType_2_lis_1);
    }
}

sealed class MyCharType_2_lis_1 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_2 = new Predicates.MyCharType_2_lis_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_3, MyCharType_2_lis_2);
    }
}

sealed class MyCharType_2_lis_2 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_3 = new Predicates.MyCharType_2_lis_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_4, MyCharType_2_lis_3);
    }
}

sealed class MyCharType_2_lis_3 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_4 = new Predicates.MyCharType_2_lis_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_5, MyCharType_2_lis_4);
    }
}

sealed class MyCharType_2_lis_4 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_5 = new Predicates.MyCharType_2_lis_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_6, MyCharType_2_lis_5);
    }
}

sealed class MyCharType_2_lis_5 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_6 = new Predicates.MyCharType_2_lis_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_7, MyCharType_2_lis_6);
    }
}

sealed class MyCharType_2_lis_6 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_7 = new Predicates.MyCharType_2_lis_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_8, MyCharType_2_lis_7);
    }
}

sealed class MyCharType_2_lis_7 : MyCharType_2 {
    static internal readonly Predicate MyCharType_2_lis_8 = new Predicates.MyCharType_2_lis_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(MyCharType_2_9, MyCharType_2_lis_8);
    }
}

sealed class MyCharType_2_lis_8 : MyCharType_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(MyCharType_2_10);
    }
}

sealed class MyCharType_2_1 : MyCharType_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(46);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("period");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return new Predicates.dollar_neckCut_0(cont);
    }
}

sealed class MyCharType_2_2 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("alphanumeric");
    static internal readonly IntegerTerm s2 = new IntegerTerm(65);
    static internal readonly IntegerTerm s3 = new IntegerTerm(90);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_3 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("alphanumeric");
    static internal readonly IntegerTerm s2 = new IntegerTerm(97);
    static internal readonly IntegerTerm s3 = new IntegerTerm(123);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_4 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("alphanumeric");
    static internal readonly IntegerTerm s2 = new IntegerTerm(48);
    static internal readonly IntegerTerm s3 = new IntegerTerm(57);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_5 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("whitespace");
    static internal readonly IntegerTerm s2 = new IntegerTerm(32);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s2, p1);
        return new Predicates.dollar_getLevel_1(a3, p2);
    }
}

sealed class MyCharType_2_6 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("punctuation");
    static internal readonly IntegerTerm s2 = new IntegerTerm(33);
    static internal readonly IntegerTerm s3 = new IntegerTerm(47);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_7 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("punctuation");
    static internal readonly IntegerTerm s2 = new IntegerTerm(58);
    static internal readonly IntegerTerm s3 = new IntegerTerm(64);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_8 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("punctuation");
    static internal readonly IntegerTerm s2 = new IntegerTerm(91);
    static internal readonly IntegerTerm s3 = new IntegerTerm(96);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_9 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("punctuation");
    static internal readonly IntegerTerm s2 = new IntegerTerm(123);
    static internal readonly IntegerTerm s3 = new IntegerTerm(126);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s3, p1);
        p3 = new Predicates.dollar_greaterOrEqual_2(a1, s2, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }
}

sealed class MyCharType_2_10 : MyCharType_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("special");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

