/*
 * *** Please do not edit ! ***
 * @(#) Member_2.cs
 * @procedure member/2 in eliza.pl
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

public class Member_2 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Member_2 );
    static internal readonly Predicate Member_2_1 = new Predicates.Member_2_1();
    static internal readonly Predicate Member_2_2 = new Predicates.Member_2_2();
    static internal readonly Predicate Member_2_sub_1 = new Predicates.Member_2_sub_1();

    public Term arg1, arg2;

    public Member_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Member_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Member_2_1, Member_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "member(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Member_2_sub_1 : Member_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Member_2_2);
    }
}

sealed class Member_2_1 : Member_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            if ( !a1.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            if ( !a2.Unify(new ListTerm(a1, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Member_2_2 : Member_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(engine.makeVariable(), a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a1;
        engine.aregs[2] = a3;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

