/*
 * *** Please do not edit ! ***
 * @(#) McAux2_6.cs
 * @procedure mc_aux2/6 in eliza.pl
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

public class McAux2_6 : Predicate {
    static internal readonly Predicate McAux2_6_1 = new Predicates.McAux2_6_1();
    static internal readonly Predicate McAux2_6_2 = new Predicates.McAux2_6_2();
    static internal readonly Predicate McAux2_6_sub_1 = new Predicates.McAux2_6_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5, arg6;

    public McAux2_6(Term a1, Term a2, Term a3, Term a4, Term a5, Term a6, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        arg6 = a6; 
        this.cont = cont;
    }

    public McAux2_6(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        arg6 = args[5]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.aregs[6] = arg6;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(McAux2_6_1, McAux2_6_sub_1);
    }

    public override int arity() { return 6; }

    public override string ToString() {
        return "mc_aux2(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + ")";
    }
}

sealed class McAux2_6_sub_1 : McAux2_6 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(McAux2_6_2);
    }
}

sealed class McAux2_6_1 : McAux2_6 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2, p3, p4, p5, p6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        Predicate cont = engine.cont;

        a7 = engine.makeVariable();
        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        a10 = engine.makeVariable();
        p1 = new Predicates.McAux3_7(a1, a2, a3, a9, a10, a5, a6, cont);
        p2 = new Predicates.Findnth_3(a4, a9, a10, p1);
        p3 = new Predicates.dollar_plus_3(a3, s1, a9, p2);
        p4 = new Predicates.dollar_cut_1(a7, p3);
        p5 = new Predicates.dollar_lessThan_2(a3, a8, p4);
        p6 = new Predicates.Length_2(a4, a8, p5);
        return new Predicates.dollar_getLevel_1(a7, p6);
    }
}

sealed class McAux2_6_2 : McAux2_6 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        Predicate cont = engine.cont;

        a7 = engine.makeVariable();
        p1 = new Predicates.McAux3_7(a1, a2, a3, s1, a7, a5, a6, cont);
        return new Predicates.Member_2(a7, a4, p1);
    }
}
}

