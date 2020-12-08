using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    public abstract class BaseInstruction
    {
        public int Operand { get; }
        public string Definition { get; }
        public int ExecutionCount { get; private set; }

        public StateMachine Execute(StateMachine state)
        {
            ExecutionCount++;
            return DoExecute(state);
        }
        protected abstract StateMachine DoExecute(StateMachine state);

        protected BaseInstruction(string definition)
        {
            Definition = definition;
            Operand = int.Parse(definition.Split(' ')[1]);
            ExecutionCount = 0;
        }

        public override string ToString()
        {
            return "Instruction:" + Definition + " (ExecutionCount " + ExecutionCount + ")";
        }

    }
}
