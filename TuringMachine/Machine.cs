using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Machine<T,D>
    {
        public readonly Dictionary<D, Dictionary<T, Instruction<T, D>>> Instructions;

        public LinkedList<T> Data { get; protected set; }
        public LinkedListNode<T> Current { get; protected set; }

        public D State { get; protected set; }
        public readonly D StartState;
        public readonly D EndState;
        public T DefaultValue { get; set; } = default(T);

        public Machine(D startState, D endState, Dictionary<D, Dictionary<T, Instruction<T, D>>> instructions)
        {
            StartState = startState;
            EndState = endState;
            State = startState;
            Instructions = instructions;
        }

        public D DoStep()
        {
            if (State.Equals(EndState))
            {
                return State;
            }

            var instruction = Instructions[State][Current.Value];

            if (instruction.IsEmpty())
            {
                throw new DataException("Empty instruction");
            }

            if (instruction.ChangeValue)
            {
                Current.Value = instruction.NewValue;
            }

            if (instruction.ChangeState)
            {
                State = instruction.NewState;
            }

            if (instruction.ReaderStep > 0)
            {
                if (Current.Next == null)
                {
                    Data.AddAfter(Current, DefaultValue);
                }

                Current = Current.Next;
            }
            else if (instruction.ReaderStep < 0)
            {
                if (Current.Previous == null)
                {
                    Data.AddBefore(Current, DefaultValue);
                }
                Current = Current.Previous;
            }

            return State;
        }

        public void Execute(LinkedList<T> data = null, LinkedListNode<T> current = null, Func<Machine<T,D>, bool> callback = null)
        {
            Data = data;

            if (Data == null)
            {
                Data = new LinkedList<T>();
                Data.AddFirst(DefaultValue);
            }
            else if (Data.Count == 0)
            {
                Data.AddFirst(DefaultValue);
            }

            Current = current;

            if (Current == null)
            {
                Current = Data.First;
            }


            State = StartState;
            while (!DoStep().Equals(EndState))
            {
                var res = callback?.Invoke(this);

                if (res == false)
                {
                    break;
                }
            }

            callback?.Invoke(this);
        }
    }

    public struct Instruction<T, D>
    {
        public bool ChangeState { get; private set; }
        public bool ChangeValue { get; private set; }
        public D _newState { get; private set; }
        public T _newValue { get; private set; }

        public int ReaderStep;

        public D NewState
        {
            get { return _newState; }
            set 
            { 
                _newState = value;
                ChangeState = true;
            }
        }

        public T NewValue
        {
            get { return _newValue; }
            set
            {
                _newValue = value;
                ChangeValue = true;
            }
        }

        public Instruction(D newState, T newValue)
        {
            _newState = newState;
            _newValue = newValue;
            ChangeValue = true;
            ChangeState = true;
            ReaderStep = 0;
        }

        public override string ToString()
        {
            string state = ChangeState ? NewState.ToString() : "None";
            string value = ChangeValue ? NewValue.ToString() : "None";
            return $"{state}, {value}, {ReaderStep}";
        }

        public bool IsEmpty()
        {
            return !ChangeState && !ChangeValue && ReaderStep == 0;
        }
    }
}
