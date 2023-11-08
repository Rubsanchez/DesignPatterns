﻿namespace DesignPatterns.Command.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
