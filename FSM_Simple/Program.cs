using System.Collections.Generic;

namespace FSM_Simple{
   internal class Program{
      private static void Main(string[] args){
         var Q = new List<string>{"q0", "q1", "q2"};
         var Sigma = new List<char>{'a'};
         var Delta = new List<Transition>{
            new Transition("q0", 'a', "q1"),
            new Transition("q1", 'a', "q2"),
            new Transition("q2", 'a', "q1")
         };
         var Q0 = "q0";
         var F = new List<string>{"q0", "q2"};
         var dFSM = new DeterministicFSM(Q, Sigma, Delta, Q0, F);

         dFSM.Accepts("");
         dFSM.Accepts("a");
         dFSM.Accepts("aa");
         dFSM.Accepts("aaa");
         dFSM.Accepts("aaaa");
         dFSM.Accepts("aaaaa");
         dFSM.Accepts("aaaaaa");
      }
   }
}