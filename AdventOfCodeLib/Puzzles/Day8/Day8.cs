using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day8
{
    public class Day8 : DaySolver<string, int>
    {
        private bool Debug = false;

        public Day8(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            Debug = true;
            return TestProgram(Data.Get()).FinalAccumulatorValue;
        }


        public ExecutionResult TestProgram(IEnumerable<string> program)
        {
            StateMachine state = new StateMachine(program);
            int accValue = state.Accumulator;
            BaseInstruction pendingInstruction = state.Program.Skip(state.ProgramCounter).First();
            bool terminatedSuccessfully = false;
            while (pendingInstruction?.ExecutionCount < 1 && !terminatedSuccessfully)
            {
                if(Debug)
                {
                    Console.WriteLine(state.ToString());
                }
                state = pendingInstruction.Execute(state);
                terminatedSuccessfully = state.ProgramCounter >= state.Program.Length;
                pendingInstruction = state.Program.Skip(state.ProgramCounter).FirstOrDefault();
            }
            accValue = state.Accumulator;

            return new ExecutionResult() { FinalAccumulatorValue = accValue, TerminatedSuccessfully = terminatedSuccessfully };
        }

        public override int Puzzle2Solution()
        {

            var program = Data.Get();
            ExecutionResult executionResult = new ExecutionResult();
            for (int i = 0; i < program.Count(); i++)
            {
                Debug = false;
                string replacementLine = string.Empty;
                if (program[i].StartsWith(NopInstruction.OpCode))
                {
                    replacementLine = program[i].Replace(NopInstruction.OpCode, JmpInstruction.OpCode);
                }
                else if (program[i].StartsWith(JmpInstruction.OpCode))
                {

                    replacementLine = program[i].Replace(JmpInstruction.OpCode, NopInstruction.OpCode);
                }

                if (replacementLine != string.Empty)
                {
                    executionResult = TestProgramVariant(program, i, replacementLine);
                    if (executionResult.TerminatedSuccessfully)
                    {
                        //Repeat the final run, this time with logging 
                        Debug = true;
                        executionResult = TestProgramVariant(program, i, replacementLine);
                        break;
                    }
                }
            }
            return executionResult.FinalAccumulatorValue;
        }

        private ExecutionResult TestProgramVariant(List<string> baseProgram, int lineNumber, string replacementLine)
        {
            string[] newProgram = new string[baseProgram.Count()];
            baseProgram.CopyTo(newProgram);

            newProgram[lineNumber] = replacementLine;

            return TestProgram(newProgram);
        }
    }
}
