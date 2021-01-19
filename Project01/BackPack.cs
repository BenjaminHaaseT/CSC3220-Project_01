using System;
namespace Project01
{
    public class BackPack
    {
        // Datafields
        private double mainPocketWeight;
        private double rightPocketWeight;
        private double leftPocketWeight;

        public BackPack()
        {
            this.mainPocketWeight = 0;
            this.rightPocketWeight = 0;
            this.leftPocketWeight = 0;
        }

        public bool InsertItemsInMainPocket(double weight)
        {
            if (this.mainPocketWeight + weight > 10)
            {
                return false;
            }
            else
            {
                this.mainPocketWeight += weight;
                return true;
            }
        }

        public bool InsertItemsRightPocket(double weight)
        {
            if (this.rightPocketWeight + weight > 5)
            {
                return false;
            }
            else
            {
                this.rightPocketWeight += weight;
                return true;
            }
        }

        public bool InsertItemsLeftPocket(double weight)
        {
            if (this.leftPocketWeight + weight > 5)
            {
                return false;
            }
            else
            {
                this.leftPocketWeight += weight;
                return true;
            }
        }

        public double GetTotalWeight()
        {
            return this.mainPocketWeight +
                   this.rightPocketWeight +
                   this.leftPocketWeight;
        }

        public bool RemoveItemsFromMainPocket(double weight)
        {
            if (this.mainPocketWeight - weight >= 0)
            {
                Console.WriteLine("{} pounds removed from main pocket.", weight);
                this.mainPocketWeight -= weight;
                Console.WriteLine("Main pocket is now {} pounds", this.mainPocketWeight);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveItemsFromRightPocket(double weight)
        {
            if (this.rightPocketWeight - weight >= 0)
            {
                Console.WriteLine("{} pounds removed from right pocket.", weight);
                this.rightPocketWeight -= weight;
                Console.WriteLine("Right pocket is now {} pounds", this.rightPocketWeight);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveItemsFromLeftPocket(double weight)
        {
            if (this.leftPocketWeight - weight >= 0)
            {
                Console.WriteLine("{} pounds removed from left pocket.", weight);
                this.leftPocketWeight -= weight;
                Console.WriteLine("Left pocket is now {} pounds", this.leftPocketWeight);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
