/*
 * *** Please do not edit ! ***
 * @(#) DigitValue_2.cs
 * @procedure digit_value/2 in eliza.pl
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

public class DigitValue_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate DigitValue_2_1 = new Predicates.DigitValue_2_1();
    static internal readonly Predicate DigitValue_2_2 = new Predicates.DigitValue_2_2();
    static internal readonly Predicate DigitValue_2_3 = new Predicates.DigitValue_2_3();
    static internal readonly Predicate DigitValue_2_4 = new Predicates.DigitValue_2_4();
    static internal readonly Predicate DigitValue_2_5 = new Predicates.DigitValue_2_5();
    static internal readonly Predicate DigitValue_2_6 = new Predicates.DigitValue_2_6();
    static internal readonly Predicate DigitValue_2_7 = new Predicates.DigitValue_2_7();
    static internal readonly Predicate DigitValue_2_8 = new Predicates.DigitValue_2_8();
    static internal readonly Predicate DigitValue_2_9 = new Predicates.DigitValue_2_9();
    static internal readonly Predicate DigitValue_2_10 = new Predicates.DigitValue_2_10();
    static internal readonly Predicate DigitValue_2_var = new Predicates.DigitValue_2_var();

    public Term arg1, arg2;

    public DigitValue_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public DigitValue_2(){}
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
                                   DigitValue_2_var,
                                   DigitValue_2_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "digit_value(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class DigitValue_2_var : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_1 = new Predicates.DigitValue_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(DigitValue_2_1, DigitValue_2_var_1);
    }
}

sealed class DigitValue_2_var_1 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_2 = new Predicates.DigitValue_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_2, DigitValue_2_var_2);
    }
}

sealed class DigitValue_2_var_2 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_3 = new Predicates.DigitValue_2_var_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_3, DigitValue_2_var_3);
    }
}

sealed class DigitValue_2_var_3 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_4 = new Predicates.DigitValue_2_var_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_4, DigitValue_2_var_4);
    }
}

sealed class DigitValue_2_var_4 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_5 = new Predicates.DigitValue_2_var_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_5, DigitValue_2_var_5);
    }
}

sealed class DigitValue_2_var_5 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_6 = new Predicates.DigitValue_2_var_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_6, DigitValue_2_var_6);
    }
}

sealed class DigitValue_2_var_6 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_7 = new Predicates.DigitValue_2_var_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_7, DigitValue_2_var_7);
    }
}

sealed class DigitValue_2_var_7 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_8 = new Predicates.DigitValue_2_var_8();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_8, DigitValue_2_var_8);
    }
}

sealed class DigitValue_2_var_8 : DigitValue_2 {
    static internal readonly Predicate DigitValue_2_var_9 = new Predicates.DigitValue_2_var_9();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(DigitValue_2_9, DigitValue_2_var_9);
    }
}

sealed class DigitValue_2_var_9 : DigitValue_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(DigitValue_2_10);
    }
}

sealed class DigitValue_2_1 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(48);
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_2 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(49);
    static internal readonly IntegerTerm s2 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_3 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(50);
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_4 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(51);
    static internal readonly IntegerTerm s2 = new IntegerTerm(3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_5 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(52);
    static internal readonly IntegerTerm s2 = new IntegerTerm(4);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_6 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(53);
    static internal readonly IntegerTerm s2 = new IntegerTerm(5);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_7 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(54);
    static internal readonly IntegerTerm s2 = new IntegerTerm(6);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_8 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(55);
    static internal readonly IntegerTerm s2 = new IntegerTerm(7);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_9 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(56);
    static internal readonly IntegerTerm s2 = new IntegerTerm(8);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class DigitValue_2_10 : DigitValue_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(57);
    static internal readonly IntegerTerm s2 = new IntegerTerm(9);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

