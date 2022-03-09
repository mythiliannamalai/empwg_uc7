// UC7 Employees monthly wage for a given condition

namespace practice
{
    class EmployeeWageComputaion
    {
        public int empRatePrHr;//constatnt
        public  int isFullTime = 1;
        public  int isPartTime = 2;
        public  int numOfDays = 20;
        public  int maxHrs = 100;
        public const int IS_ABSEND = 0;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public  int workHr = 0;//variable
        public const int totalWrkHr = 0;
        int totalWage;
        int totalWrkDays = 0;

        public EmployeeWageComputaion(int empRatePrHr, int isFullTime, int isPartTime, int numOfDays, int maxHrs)
        {
            this.empRatePrHr = empRatePrHr;
            this.isFullTime = isFullTime;
            this.isPartTime = isPartTime;
            this.numOfDays = numOfDays;
            this.maxHrs = maxHrs;

        }

        private int IsEmployeePresent()
        {
            Random random = new Random();
            int empStatus = random.Next(0, 3);
            return empStatus;
        }
        public void CalculateWage()
        {
            int workHr = 0;
            int totalWrkHr = 0;



            while (totalWrkHr < maxHrs && totalWrkDays < numOfDays)
            {
                Random random = new Random();
                int employeeStatus = random.Next(0, 3);
                switch (IsEmployeePresent())
                {
                    case IS_FULL_TIME:
                        workHr = 8;
                        break;
                    case IS_PART_TIME:
                        workHr = 4;
                        break;
                    default:
                        workHr = 0;
                        break;
                }
                totalWrkHr += workHr;
                totalWrkDays++;
            }
            totalWage = totalWrkHr * empRatePrHr;
            Console.WriteLine("Employee total wage is " + totalWage
                + " for {0} working Days", totalWrkDays);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage Computtation");
            EmployeeWageComputaion wage = new EmployeeWageComputaion(20, 1, 2, 20, 100);
            wage.CalculateWage();

        }
    }
}