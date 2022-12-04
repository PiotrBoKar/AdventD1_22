using System.Collections;


namespace AdventD1_22
{
    public class dayOne22
    {
        public static void Main()
        {
            int sumCalories = 0;
            int topThree = 0;
            List<int> caloriesList = ReadFile.getNumArray("22D1");
            List<int> calories = new List<int>();
            List<int> topCalories = new();
            for (int i = 0; i < caloriesList.Count; i++)
            {
                if (caloriesList[i] > 0)
                {
                    if(i == caloriesList.Count - 1)
                    {
                        sumCalories = sumCalories + caloriesList[i];
                        calories.Add(sumCalories);
                    }
                    sumCalories = sumCalories + caloriesList[i];
                }
                else if (caloriesList[i] == 0)
                {
                    calories.Add(sumCalories);
                    sumCalories = 0;
                }

            }
            var max = calories.Max();
            Console.WriteLine("-----answer to the first part---------");
            Console.WriteLine(max);
            for (int i = 0; i < 3; i++)
            {
                topThree = topThree + calories.Max();
                topCalories.Add(calories.Max());
                calories.Remove(calories.Max());

            }
            Console.WriteLine("-----answer to the second part---------");
            Console.WriteLine(topThree);
        }

    }
}