/*
 * *** Please do not edit ! ***
 * @(#) ReadLcStringAux_2.cs
 * @procedure read_lc_string_aux/2 in eliza.pl
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

public class ReadLcStringAux_2 : Predicate {
    static internal readonly Predicate ReadLcStringAux_2_1 = new Predicates.ReadLcStringAux_2_1();
    static internal readonly Predicate ReadLcStringAux_2_2 = new Predicates.ReadLcStringAux_2_2();
    static internal readonly Predicate ReadLcStringAux_2_3 = new Predicates.ReadLcStringAux_2_3();
    static internal readonly Predicate ReadLcStringAux_2_var = new Predicates.ReadLcStringAux_2_var();

    public Term arg1, arg2;

    public ReadLcStringAux_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public ReadLcStringAux_2(){}
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
                                   ReadLcStringAux_2_var,
                                   ReadLcStringAux_2_var,
                                   ReadLcStringAux_2_3,
                                   ReadLcStringAux_2_3,
                                   ReadLcStringAux_2_3
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "read_lc_string_aux(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class ReadLcStringAux_2_var : ReadLcStringAux_2 {
    static internal readonly Predicate ReadLcStringAux_2_var_1 = new Predicates.ReadLcStringAux_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(ReadLcStringAux_2_1, ReadLcStringAux_2_var_1);
    }
}

sealed class ReadLcStringAux_2_var_1 : ReadLcStringAux_2 {
    static internal readonly Predicate ReadLcStringAux_2_var_2 = new Predicates.ReadLcStringAux_2_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(ReadLcStringAux_2_2, ReadLcStringAux_2_var_2);
    }
}

sealed class ReadLcStringAux_2_var_2 : ReadLcStringAux_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ReadLcStringAux_2_3);
    }
}

sealed class ReadLcStringAux_2_1 : ReadLcStringAux_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(10);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

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

sealed class ReadLcStringAux_2_2 : ReadLcStringAux_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(-1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

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

sealed class ReadLcStringAux_2_3 : ReadLcStringAux_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            if ( !a1.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
            a3 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a1, a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return new Predicates.ReadLcString_1(a3, cont);
    }
}
}

