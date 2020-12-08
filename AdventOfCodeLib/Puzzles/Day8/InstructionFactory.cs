using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    public static class InstructionFactory
    {
        public static BaseInstruction CreateInstruction(string definition)
        {
            var opCode = definition.Split(' ')[0];

            return opCode switch
            {
                JmpInstruction.OpCode => new JmpInstruction(definition),
                AccInstruction.OpCode => new AccInstruction(definition),
                NopInstruction.OpCode => new NopInstruction(definition),
                _ => new NopInstruction(definition),
            };
        }
    }
}
