﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PAT.Common.Classes.CUDDLib;
using PAT.Common.Classes.Expressions.ExpressionClass;
using PAT.Common.Classes.LTS;
using PAT.Common.Classes.SemanticModels.LTS.BDD;
namespace PAT.BDD.Testing {
	class Program {
		static void Main(string[] args) {
			Test1();
			Test2();
		}
		/// <summary>
		/// This test create a SymbolicLTS with 3 states and check whether a certain condition is reachable
		/// </summary>
		static void Test1() {
			string varX = "x";
			//Set number of action names, 2 for a, b
			Model.NUMBER_OF_EVENT = 2;
			Model.MAX_NUMBER_EVENT_PARAMETERS = 0;

			BDDEncoder encoder = new BDDEncoder();
			encoder.model.AddGlobalVar(varX, 0, 10);

			SymbolicLTS lts = new SymbolicLTS();

			State state1 = lts.AddState();
			State state2 = lts.AddState();
			State state3 = lts.AddState();

			lts.InitialState = state1;

			Transition trans1 = new Transition(new Event("a"), null, new Assignment(varX, new PrimitiveApplication(PrimitiveApplication.PLUS, new Variable(varX), new IntConstant(1))), state1, state2);
			Transition trans2 = new Transition(new Event("b"), null, new Assignment(varX, new PrimitiveApplication(PrimitiveApplication.PLUS, new Variable(varX), new IntConstant(2))), state2, state3);

			lts.AddTransition(trans1);
			lts.AddTransition(trans2);

			AutomataBDD systemBDD = lts.Encode(encoder);

			//Variable x is initialised to 1
			systemBDD.initExpression = new PrimitiveApplication(PrimitiveApplication.AND, systemBDD.initExpression,
			                                                             new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(1)));

			CUDDNode initDD = CUDD.Function.Or(systemBDD.initExpression.TranslateBoolExpToBDD(encoder.model).GuardDDs);

			//Define 2 goals
			Expression goal1 = new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(4));
			Expression goal2 = new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(2));

			//Encode 2 goals to BDD
			CUDDNode goal1DD = CUDD.Function.Or(goal1.TranslateBoolExpToBDD(encoder.model).GuardDDs);
			CUDDNode goal2DD = CUDD.Function.Or(goal2.TranslateBoolExpToBDD(encoder.model).GuardDDs);

			List<CUDDNode> path = new List<CUDDNode>();

			bool reach1 = encoder.model.PathForward(initDD, goal1DD, new List<List<CUDDNode>>() { systemBDD.transitionBDD }, path, true);
			if(reach1) {
				Console.WriteLine("goal1 is reachable");
				foreach(var cuddNode in path) {
					int valueOfX = encoder.model.GetRowVarValue(cuddNode, varX);
					Console.WriteLine(varX + " = " + valueOfX);
				}
			} else {
				Console.WriteLine("goal1 is unreachable");
			}

			path.Clear();

			bool reach2 = encoder.model.PathForward(initDD, goal2DD, new List<List<CUDDNode>>() { systemBDD.transitionBDD }, path, true);
			if(reach2) {
				Console.WriteLine("goal2 is reachable");
				foreach(var cuddNode in path) {
					int valueOfX = encoder.model.GetRowVarValue(cuddNode, varX);
					Console.WriteLine(varX + " = " + valueOfX);
				}
			} else {
				Console.WriteLine("goal2 is unreachable");
			}

			encoder.model.Close();
		}
		/// <summary>
		/// In this example, we try to get the BDD encoding of the same system as Test1.
		/// However we assume to have the subsytem containing 2 states s2, and s3
		/// Then we compositionally get the BDD encoding of the whole system
		/// </summary>
		static void Test2() {
			string varX = "x";
			//Set number of action names, 2 for a, b
			Model.NUMBER_OF_EVENT = 2;
			Model.MAX_NUMBER_EVENT_PARAMETERS = 0;

			BDDEncoder encoder = new BDDEncoder();
			encoder.model.AddGlobalVar(varX, 0, 10);

			SymbolicLTS lts = new SymbolicLTS();

			State state2 = lts.AddState();
			State state3 = lts.AddState();

			lts.InitialState = state2;

			Transition trans2 = new Transition(new Event("b"), null, new Assignment(varX, new PrimitiveApplication(PrimitiveApplication.PLUS, new Variable(varX), new IntConstant(2))), state2, state3);

			lts.AddTransition(trans2);

			AutomataBDD subSystemBDD = lts.Encode(encoder);


			//Get the BDD encoding of the whole system by using compositional function AutomataBDD.EventPrefix
			Expression updateWithTransition = new Sequence(encoder.GetEventExpression(new Event("a")),
			                                                        new Assignment(varX, new PrimitiveApplication(PrimitiveApplication.PLUS, new Variable(varX), new IntConstant(1))));
			AutomataBDD systemBDD = AutomataBDD.EventPrefix(new BoolConstant(true), updateWithTransition, subSystemBDD, encoder.model);


			//Variable x is initialised to 1
			systemBDD.initExpression = new PrimitiveApplication(PrimitiveApplication.AND, systemBDD.initExpression,
			                                                             new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(1)));

			CUDDNode initDD = CUDD.Function.Or(systemBDD.initExpression.TranslateBoolExpToBDD(encoder.model).GuardDDs);

			Expression goal1 = new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(4));
			Expression goal2 = new PrimitiveApplication(PrimitiveApplication.EQUAL, new Variable(varX), new IntConstant(5));

			CUDDNode goal1DD = CUDD.Function.Or(goal1.TranslateBoolExpToBDD(encoder.model).GuardDDs);
			CUDDNode goal2DD = CUDD.Function.Or(goal2.TranslateBoolExpToBDD(encoder.model).GuardDDs);

			List<CUDDNode> path = new List<CUDDNode>();

			bool reach1 = encoder.model.PathForward(initDD, goal1DD, new List<List<CUDDNode>>() { systemBDD.transitionBDD }, path, true);
			if(reach1) {
				Console.WriteLine("goal1 is reachable");
				foreach(var cuddNode in path) {
					int valueOfX = encoder.model.GetRowVarValue(cuddNode, varX);
					Console.WriteLine(varX + " = " + valueOfX);
				}
			} else {
				Console.WriteLine("goal1 is unreachable");
			}

			path.Clear();

			bool reach2 = encoder.model.PathForward(initDD, goal2DD, new List<List<CUDDNode>>() { systemBDD.transitionBDD }, path, true);
			if(reach2) {
				Console.WriteLine("goal2 is reachable");
				foreach(var cuddNode in path) {
					int valueOfX = encoder.model.GetRowVarValue(cuddNode, varX);
					Console.WriteLine(varX + " = " + valueOfX);
				}
			} else {
				Console.WriteLine("goal2 is unreachable");
			}

			encoder.model.Close();
		}
	}
}
