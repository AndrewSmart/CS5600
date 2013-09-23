/*
 * *** Please do not edit ! ***
 * @(#) ExtractWord_3.cs
 * @procedure extract_word/3 in eliza.pl
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

public class ExtractWord_3 : Predicate {

    public Term arg1, arg2, arg3;

    public ExtractWord_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public ExtractWord_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();

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
        if ( a3.IsList() ){
            if ( !a4.Unify(((ListTerm)a3).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a7 = engine.makeVariable();
        p1 = new Predicates.ExtractWordAux_4(a7, a5, a2, a6, cont);
        return new Predicates.MyCharType_2(a4, a7, p1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "extract_word(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}
}

