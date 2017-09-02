using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Hospital
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var doctorsPatients = new Dictionary<string, List<string>>();
            var hospital = new Dictionary<string, Department>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Output")
            {
                var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var department = tokens[0];
                var doctor = tokens[1] + " " + tokens[2];
                var patient = tokens[3];

                if (!doctorsPatients.ContainsKey(doctor))
                {
                    doctorsPatients[doctor] = new List<string>();
                }
                doctorsPatients[doctor].Add(patient);

                if (!hospital.ContainsKey(department))
                {
                    hospital[department] = new Department();
                }
                hospital[department].AddPatient(patient);
            }

            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                var roomNumber = 0;

                if (tokens.Length == 1) //Department
                {
                    if (hospital.ContainsKey(tokens[0]))
                    {
                        hospital[tokens[0]].PrintAllPatients();
                    }
                }
                else if (int.TryParse(tokens[1], out roomNumber)) //Department -> Room
                {
                    hospital[tokens[0]].PrintInRoom(roomNumber);
                }
                else //Doctor
                {
                    var doctorName = tokens[0] + " " + tokens[1];
                    foreach (var masterDoctor in doctorsPatients)
                    {
                        if (masterDoctor.Key == doctorName)
                        {
                            Console.WriteLine(string.Join("\r\n", masterDoctor.Value.OrderBy(p => p)));
                        }
                    }
                }
            }           
        }
    }
}
