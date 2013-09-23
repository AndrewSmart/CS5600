/*
 * *** Please do not edit ! ***
 * @(#) Isalist_1.cs
 * @procedure isalist/1 in eliza.pl
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

public class Isalist_1 : Predicate {

    public Term arg1;

    public Isalist_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Isalist_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1;
        a1 = arg1.Dereference();

        if ( a1.IsList() ){
        } else if ( a1.IsVariable() ){
            if ( !a1.Unify(new ListTerm(engine.makeVariable(), engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "isalist(" + arg1 + ")";
    }
}
}

