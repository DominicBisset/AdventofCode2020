using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    public class StateMachine
    {
        public BaseInstruction[] Program { get; }
        public int Accumulator { get; set; }
        public int ProgramCounter { get; set; }

        public StateMachine(IEnumerable<string> programDefinition): 
            this(programDefinition.Select(s => InstructionFactory.CreateInstruction(s)))
        {
           
        }

        public StateMachine(IEnumerable<BaseInstruction> program)
        {
            Program = program.ToArray(); ;
            Accumulator = 0;
            ProgramCounter = 0;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Current accumulator:\t");
            sb.Append(Accumulator);
            sb.Append("Current program counter:\t");
            sb.Append(ProgramCounter);
            sb.Append("Current Instruction:\t");
            sb.Append(Program[ProgramCounter].ToString()); ;

            return sb.ToString();
        }

    }
}