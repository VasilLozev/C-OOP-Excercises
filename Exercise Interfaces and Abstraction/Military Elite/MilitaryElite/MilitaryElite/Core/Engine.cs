namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Core.Interfaces;
    using IO.Interfaces;
    using MilitaryElite.Models;
    using MilitaryElite.Models.Enums;
    using MilitaryElite.Models.Interfaces;
    
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICollection<ISoldier> allSoldiers;

        public Engine() 
        {
            allSoldiers = new HashSet<ISoldier>();
        }
        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            this.CreateSoldiers();
            this.PrintSoldiers();
        }

        private void CreateSoldiers()
        {
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(' ');

                string SoldierType = input[0];
                int Id = int.Parse(input[1]);
                string firstName = input[2];
                string lastName = input[3];

                ISoldier soldier;
                if (SoldierType == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);
                    soldier = new Private(Id, firstName, lastName, salary);

                }
                else if (SoldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    ICollection<IPrivate> privates = this.FindPrivates(input);

                    soldier = new LieutenantGeneral(Id, firstName, lastName, salary, privates);
                }
                else if (SoldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corpsText = input[5];
                    bool isCorpsValid = Enum.TryParse<Corps>(corpsText, false, out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }

                    ICollection<IRepair> repairs = this.CreateRepairs(input);
                    soldier = new Engineer(Id, firstName, lastName, salary, corps, repairs);
                }
                else if (SoldierType == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);

                    string corpsText = input[5];
                    bool isCorpsValid = Enum.TryParse<Corps>(corpsText, true, out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    ICollection<IMission> missions = this.CreateMissions(input);
                    soldier = new Commando(Id, firstName, lastName, salary, corps, missions);
                }
                else if (SoldierType == "Spy")
                {
                    int codeNumber = int.Parse(input[4]);
                    soldier = new Spy(Id, firstName, lastName, codeNumber);
                }
                else
                {
                    continue;
                }
                this.allSoldiers.Add(soldier);
            }
        }

        private ICollection<IPrivate> FindPrivates(string[] cmdArgs)
        {
            int[] privateIds = cmdArgs
                .Skip(5)
                .Select(int.Parse)
                .ToArray();

            ICollection<IPrivate> privates = new HashSet<IPrivate>();
            foreach (int privateId in privateIds)
            {
                IPrivate currPrivate = (IPrivate)allSoldiers
                  .FirstOrDefault(s => s.Id == privateId);

                privates.Add(currPrivate);
            }
            return privates;
        }
        private ICollection<IRepair> CreateRepairs(string[] cmdArgs)
        {
            ICollection<IRepair> repairs = new HashSet<IRepair>();

            string[] repairsInfo = cmdArgs
                .Skip(6)                       
                .ToArray();
            for (int i = 0; i < repairsInfo.Length; i+=2)
            {
                string partName = repairsInfo[i];
                int hoursWorked = int.Parse(repairsInfo[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);
                repairs.Add(repair);
            }

            return repairs;
        }
        private ICollection<IMission> CreateMissions(string[] cmdArgs)
        {
            ICollection <IMission> missions = new HashSet<IMission>();    
            string[] missionsInfo = cmdArgs
               .Skip(6)
               .ToArray();
            for (int i = 0; i < missionsInfo.Length; i+= 2)
            {
                string codeName = missionsInfo[i];

                string stateText = missionsInfo[i + 1];
                bool isStateValid = Enum.TryParse<State>(stateText, false, out State state);
                if (!isStateValid)
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);
                missions.Add(mission);
            }

            return missions;
        }
        private void PrintSoldiers()
        {
            foreach (ISoldier soldier in this.allSoldiers)
            {
                this.writer.WriteLine(soldier.ToString());
            }
        }
    }
}
