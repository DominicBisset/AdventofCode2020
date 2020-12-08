using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    class JmpInstruction : BaseInstruction
    {

        public const string OpCode = "jmp";

        public JmpInstruction(string definition): base(definition)
        {
        }

        protected override StateMachine DoExecute(StateMachine state)
        {
            state.ProgramCounter += Operand;
            return state;
        }
    }
}
