/*
 * *** Please do not edit ! ***
 * @(#) Updaterule_4.cs
 * @procedure updaterule/4 in eliza.pl
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

public class Updaterule_4 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("rules", 1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("[]");

    public Term arg1, arg2, arg3, arg4;

    public Updaterule_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Updaterule_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20;
        Predicate p1, p2;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();
        a4 = arg4.Dereference();

        a8 = engine.makeVariable();
        a7 = new ListTerm(a8, s2);
        a6 = new ListTerm(a1, a7);
        Term[] h3 = {a6};
        a5 = new StructureTerm(f1, h3);
        a11 = engine.makeVariable();
        a13 = engine.makeVariable();
        a12 = new ListTerm(a3, a13);
        a10 = new ListTerm(a11, a12);
        a9 = new ListTerm(a2, a10);
        a16 = new ListTerm(a4, a13);
        a15 = new ListTerm(a11, a16);
        a14 = new ListTerm(a2, a15);
        a17 = engine.makeVariable();
        a20 = new ListTerm(a17, s2);
        a19 = new ListTerm(a1, a20);
        Term[] h4 = {a19};
        a18 = new StructureTerm(f1, h4);
        p1 = new Predicates.Assertz_1(a18, cont);
        p2 = new Predicates.Replace_4(a9, a8, a14, a17, p1);
        return new Predicates.Retract_1(a5, p2);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "updaterule(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}
}

