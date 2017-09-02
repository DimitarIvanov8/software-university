using System.Collections.Generic;
using System.Linq;

namespace _4.Hospital
{
    class Department
    {
        private int roomNumber;
        private Dictionary<int, List<string>> rooms;

        public Department()
        {
            this.roomNumber = 1;
            this.rooms = new Dictionary<int, List<string>>();
        }

        public void AddPatient(string patient)
        {
            if (!rooms.Any())
            {
                rooms[roomNumber] = new List<string>();
            }
            if (rooms[roomNumber].Count == 3)
            {
                roomNumber++;
                rooms[roomNumber] = new List<string>();
            }
            if (roomNumber <= 20)
            {
                rooms[roomNumber].Add(patient);
            }
        }

        public void PrintAllPatients()
        {
            foreach (var room in rooms)
            {
                foreach (var patient in room.Value)
                {
                    System.Console.WriteLine(patient);
                }
            }
        }

        public void PrintInRoom(int roomNumber)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                foreach (var patient in rooms[roomNumber].OrderBy(p => p))
                {
                    System.Console.WriteLine(patient);
                }
            }
        }
    }
}
