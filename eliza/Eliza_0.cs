/*
 * *** Please do not edit ! ***
 * @(#) Eliza_0.cs
 * @procedure eliza/0 in eliza.pl
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

public class Eliza_0 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("mem", 1);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("Hello. I am ELIZA. How can I help you?");
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("> ");
    static internal readonly SymbolTerm s5 = SymbolTerm.MakeSymbol("[]");

    public Eliza_0(Predicate cont) {
        this.cont = cont;
    }

    public Eliza_0(){}
    public override void setArgument(Term[] args, Predicate cont) {
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20;

        a1 = engine.makeVariable();
        Term[] h2 = {engine.makeVariable()};
        a2 = new StructureTerm(f1, h2);
        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        a7 = engine.makeVariable();
        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a1, cont);
        p2 = new Predicates.Quittime_1(a5, p1);
        p3 = new Predicates.Write_1(s4, p2);
        p4 = new Predicates.dollar_nl_0(p3);
        p5 = new Predicates.Writecomment_1(a9, p4);
        p6 = new Predicates.Flatten_2(a8, a9, p5);
        p7 = new Predicates.Makecomment_3(a7, a5, a8, p6);
        p8 = new Predicates.Sortkeywords_2(a6, a7, p7);
        p9 = new Predicates.Findkeywords_2(a5, a6, p8);
        p10 = new Predicates.Simplify_2(a4, a5, p9);
        p11 = new Predicates.ProcessInput_3(a3, s5, a4, p10);
        p12 = new Predicates.dollar_nl_0(p11);
        p13 = new Predicates.ReadAtomics_1(a3, p12);
        p14 = new Predicates.Repeat_0(p13);
        p15 = new Predicates.Write_1(s4, p14);
        p16 = new Predicates.dollar_nl_0(p15);
        p17 = new Predicates.Write_1(s3, p16);
        p18 = new Predicates.dollar_nl_0(p17);
        p19 = new Predicates.dollar_nl_0(p18);
        p20 = new Predicates.Retractall_1(a2, p19);
        return new Predicates.dollar_getLevel_1(a1, p20);
    }

    public override int arity() { return 0; }

    public override string ToString() {
        return "eliza";
    }
}
}

