using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    class AccInstruction : BaseInstruction
    {

        public const string OpCode = "acc";

        public AccInstruction(string definition): base(definition)
        {
        }

        protected override StateMachine DoExecute(StateMachine state)
        {
            state.ProgramCounter++;
            state.Accumulator += Operand;
            return state;
        }
    }
}
