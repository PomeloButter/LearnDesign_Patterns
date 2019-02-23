﻿namespace LearnDesign_Pattern.Command_Patterns
{
    public abstract class Command
    {
        public Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Action();
    }
}