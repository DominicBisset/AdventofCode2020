using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    class NopInstruction : BaseInstruction
    {
        public const string OpCode = "nop";

        public NopInstruction(string definition): base(definition)
        {
        }

        protected override StateMachine DoExecute(StateMachine state)
        {
            state.ProgramCounter++;
            return state;
        }
    }
}
