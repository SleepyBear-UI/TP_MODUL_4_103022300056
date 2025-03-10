using System;

namespace DoorStateMachine
{
    // Enum untuk merepresentasikan state
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    // Class DoorMachine
    public class DoorMachine
    {
        private DoorState currentState;

        // Constructor, state awal adalah Terkunci
        public DoorMachine()
        {
            currentState = DoorState.Terkunci;
            DisplayState();
        }

        // Method untuk menampilkan state saat ini
        private void DisplayState()
        {
            switch (currentState)
            {
                case DoorState.Terkunci:
                    Console.WriteLine("Pintu terkunci");
                    break;
                case DoorState.Terbuka:
                    Console.WriteLine("Pintu tidak terkunci");
                    break;
            }
        }

        // Method untuk mengubah state
        public void SetState(DoorState newState)
        {
            currentState = newState;
            DisplayState();
        }
    }

}