/*
 * *** Please do not edit ! ***
 * @(#) StringToAtomic_2.cs
 * @procedure string_to_atomic/2 in eliza.pl
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

public class StringToAtomic_2 : Predicate {
    static internal readonly Predicate StringToAtomic_2_1 = new Predicates.StringToAtomic_2_1();
    static internal readonly Predicate StringToAtomic_2_2 = new Predicates.StringToAtomic_2_2();
    static internal readonly Predicate StringToAtomic_2_var = new Predicates.StringToAtomic_2_var();

    public Term arg1, arg2;

    public StringToAtomic_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public StringToAtomic_2(){}
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
                                   StringToAtomic_2_var,
                                   StringToAtomic_2_2,
                                   StringToAtomic_2_2,
                                   StringToAtomic_2_2,
                                   StringToAtomic_2_var
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "string_to_atomic(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class StringToAtomic_2_var : StringToAtomic_2 {
    static internal readonly Predicate StringToAtomic_2_var_1 = new Predicates.StringToAtomic_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(StringToAtomic_2_1, StringToAtomic_2_var_1);
    }
}

sealed class StringToAtomic_2_var_1 : StringToAtomic_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(StringToAtomic_2_2);
    }
}

sealed class StringToAtomic_2_1 : StringToAtomic_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        a6 = new ListTerm(a3, a4);
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.StringToNumber_2(a6, a2, p1);
        return new Predicates.dollar_getLevel_1(a5, p2);
    }
}

sealed class StringToAtomic_2_2 : StringToAtomic_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.Name_2(a2, a1, cont);
    }
}
}

