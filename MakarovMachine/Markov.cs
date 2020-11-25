using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakarovMachine
{
    public class Markov
    {
        public List<Instruction> Instuctions;
        public int LastInstructionIndex { get; protected set; }
        public Instruction LastInstruction => LastInstructionIndex == -1 ? null : Instuctions[LastInstructionIndex];
        public Instruction CurrentInstuction => Current == -1 ? null : Instuctions[Current];
        public int Current { get; set; } = -1;
        public string Word { get; protected set; }

        public Markov(List<Instruction> instructions)
        {
            Instuctions = new List<Instruction>(instructions);
        }

        public void Stop()
        {
            Current = -1;
        }

        public string Execute(string input, Action<Markov> callback = null)
        {
            if (Current != -1)
            {
                throw new Exception("Machine is already running");
            }

            LastInstructionIndex = -1;
            Word = input;
            Current = 0;
            int k = 0;
            while (DoStep())
            {
                callback?.Invoke(this);
            }

            callback?.Invoke(this);
            return Word;
        }

        public bool DoStep()
        {
            if (Current != -1)
            {
                bool full = false;
                int index;
                do
                {
                    if (Current == 0)
                    {
                        full = true;
                    }
                    Instruction ins = Instuctions[Current];
                    index = Word.IndexOf(ins.From, StringComparison.Ordinal);
                    if (index == -1)
                    {
                        Current++;
                    }
                    else
                    {
                        Word = Word.Substring(0, index) + ins.To + Word.Substring(index + ins.From.Length);
                        LastInstructionIndex = Current;
                        if (ins.Finish)
                        {
                            Stop();
                        }
                    }

                    if (Current == Instuctions.Count)
                    {
                        if (full)
                        {
                            Stop();
                        }
                        else
                        {
                            Current = 0;
                        }
                    }
                } while (index == -1 && Current != -1);
            }

            return Current != -1;
        }
    }

    public class Instruction
    {
        public string From;
        public string To;
        public bool Finish;

        public Instruction(string from, string to, bool finish = false)
        {
            From = from;
            To = to;
            Finish = finish;
        }

        public override string ToString()
        {
            return From + " ->" + (Finish ? "* " : " ") + To;
        }
    }
}
