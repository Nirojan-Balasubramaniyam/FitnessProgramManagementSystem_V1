using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class IndividualFitnessProgram : FitnessProgram
    {
        public string SubscriptionType { get; set; }
        public bool needPersonalTrainer { get; set; }

        public IndividualFitnessProgram(string fitnessProgramId, string title, string duration, string price, string subscriptionType, bool needPersonalTrainer) : base(fitnessProgramId, title, duration, price)
        {
            SubscriptionType = subscriptionType;
            this.needPersonalTrainer = needPersonalTrainer;
        }
        /*public string DisplayIndividualFitnessProgramInfo()
        {
            string personalTrainer = needPersonalTrainer ? "Yes" : "No";
            return base.ToString() + $"SubscriptionType: {SubscriptionType}, needPersonalTrainer: {personalTrainer}";
        }*/

        public override string DisplayFitnessProgramInfo()
        {
            string personalTrainer = needPersonalTrainer ? "Yes" : "No";
            return base.DisplayFitnessProgramInfo() + $"SubscriptionType: {SubscriptionType}, needPersonalTrainer: {personalTrainer}";
        }

    }
}
