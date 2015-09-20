namespace MementoPattern
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            Originator<string> originator = new Originator<string>();

            originator.SetState("state0");
            Caretaker<string>.SaveState(originator); // save state of the originator
            originator.ShowState();

            originator.SetState("state1");
            Caretaker<string>.SaveState(originator); // save state of the originator
            originator.ShowState();

            originator.SetState("state2");
            Caretaker<string>.SaveState(originator); // save state of the originator
            originator.ShowState();

            // restore state of the originator
            Caretaker<string>.RestoreState(originator, 0);
            originator.ShowState();  // shows state0
        }
    }
}
