/*
 * *** Please do not edit ! ***
 * @(#) StringToNumberAux_3.cs
 * @procedure string_to_number_aux/3 in eliza.pl
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

public class StringToNumberAux_3 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate StringToNumberAux_3_1 = new Predicates.StringToNumberAux_3_1();
    static internal readonly Predicate StringToNumberAux_3_2 = new Predicates.StringToNumberAux_3_2();
    static internal readonly Predicate StringToNumberAux_3_var = new Predicates.StringToNumberAux_3_var();

    public Term arg1, arg2, arg3;

    public StringToNumberAux_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public StringToNumberAux_3(){}
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
                                   StringToNumberAux_3_var,
                                   dollar_fail_0,
                                   StringToNumberAux_3_2,
                                   dollar_fail_0,
                                   StringToNumberAux_3_1
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "string_to_number_aux(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class StringToNumberAux_3_var : StringToNumberAux_3 {
    static internal readonly Predicate StringToNumberAux_3_var_1 = new Predicates.StringToNumberAux_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(StringToNumberAux_3_1, StringToNumberAux_3_var_1);
    }
}

sealed class StringToNumberAux_3_var_1 : StringToNumberAux_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(StringToNumberAux_3_2);
    }
}

sealed class StringToNumberAux_3_1 : StringToNumberAux_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(10);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8;
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
        a7 = engine.makeVariable();
        a8 = engine.makeVariable();
        p1 = new Predicates.StringToNumberAux_3(a5, a8, a3, cont);
        p2 = new Predicates.dollar_plus_3(a7, a6, a8, p1);
        p3 = new Predicates.dollar_multi_3(s1, a2, a7, p2);
        return new Predicates.DigitValue_2(a4, a6, p3);
    }
}

sealed class StringToNumberAux_3_2 : StringToNumberAux_3 {
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
}

