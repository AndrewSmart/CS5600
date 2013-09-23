/*
 * *** Please do not edit ! ***
 * @(#) Findnth_3.cs
 * @procedure findnth/3 in eliza.pl
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

public class Findnth_3 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Findnth_3_1 = new Predicates.Findnth_3_1();
    static internal readonly Predicate Findnth_3_2 = new Predicates.Findnth_3_2();
    static internal readonly Predicate Findnth_3_var = new Predicates.Findnth_3_var();

    public Term arg1, arg2, arg3;

    public Findnth_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Findnth_3(){}
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
                                   Findnth_3_var,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   dollar_fail_0,
                                   Findnth_3_var
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "findnth(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class Findnth_3_var : Findnth_3 {
    static internal readonly Predicate Findnth_3_var_1 = new Predicates.Findnth_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Findnth_3_1, Findnth_3_var_1);
    }
}

sealed class Findnth_3_var_1 : Findnth_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Findnth_3_2);
    }
}

sealed class Findnth_3_1 : Findnth_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).car;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a4, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        if ( !a4.Unify(a3, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Findnth_3_2 : Findnth_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1;
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
        p1 = new Predicates.Findnth_3(a4, a5, a3, cont);
        return new Predicates.dollar_minus_3(a2, s1, a5, p1);
    }
}
}

