/*
 * *** Please do not edit ! ***
 * @(#) RemoveInitialBlanks_2.cs
 * @procedure remove_initial_blanks/2 in eliza.pl
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

public class RemoveInitialBlanks_2 : Predicate {
    static internal readonly Predicate RemoveInitialBlanks_2_1 = new Predicates.RemoveInitialBlanks_2_1();
    static internal readonly Predicate RemoveInitialBlanks_2_2 = new Predicates.RemoveInitialBlanks_2_2();
    static internal readonly Predicate RemoveInitialBlanks_2_var = new Predicates.RemoveInitialBlanks_2_var();

    public Term arg1, arg2;

    public RemoveInitialBlanks_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public RemoveInitialBlanks_2(){}
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
                                   RemoveInitialBlanks_2_var,
                                   RemoveInitialBlanks_2_2,
                                   RemoveInitialBlanks_2_2,
                                   RemoveInitialBlanks_2_2,
                                   RemoveInitialBlanks_2_var
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "remove_initial_blanks(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class RemoveInitialBlanks_2_var : RemoveInitialBlanks_2 {
    static internal readonly Predicate RemoveInitialBlanks_2_var_1 = new Predicates.RemoveInitialBlanks_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(RemoveInitialBlanks_2_1, RemoveInitialBlanks_2_var_1);
    }
}

sealed class RemoveInitialBlanks_2_var_1 : RemoveInitialBlanks_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(RemoveInitialBlanks_2_2);
    }
}

sealed class RemoveInitialBlanks_2_1 : RemoveInitialBlanks_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("whitespace");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
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
        p1 = new Predicates.RemoveInitialBlanks_2(a4, a2, cont);
        p2 = new Predicates.dollar_cut_1(a5, p1);
        p3 = new Predicates.MyCharType_2(a3, s1, p2);
        return new Predicates.dollar_getLevel_1(a5, p3);
    }
}

sealed class RemoveInitialBlanks_2_2 : RemoveInitialBlanks_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !a1.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}
}

