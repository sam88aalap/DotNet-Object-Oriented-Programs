using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    public class Module
    {
        public string moduleName { get; set; }
        private List<Unit> units = new List<Unit>();

        public void AddUnit(Unit unit)
        {
            this.units.Add(unit);
        }
        public IEnumerable<Unit> GetUnits()
        {
            return this.units;
        }
    }
}
