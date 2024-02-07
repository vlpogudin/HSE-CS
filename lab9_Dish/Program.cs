namespace lab9_Dish
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int answer;
            do
            {
                Interface.PrintMainMenu();
                answer = Interface.GetInt();
                Console.Clear();
                switch (answer)
                {
                    case 1:
                        {
                            Dish d1 = new Dish();
                            string name = "nameless";
                            d1.Show(name);
                            Interface.PrintNumberCalories(d1.NumberCalories());

                            Dish d2 = new Dish(27.8, 29.6, 1.7);
                            name = "steak";
                            d2.Show(name);
                            Interface.PrintNumberCalories(d2.NumberCalories());

                            Dish d3 = new Dish(d2);
                            name = "beefsteak";
                            d3.Show(name);
                            Interface.PrintNumberCalories(Dish.CalculateCalories(d3));

                            Interface.PrintCountObjects(1);
                            break;
                        }

                    case 2:
                        {
                            Dish d1 = new Dish(3, 0.9, 13);
                            string name = "draniki";
                            d1.Show(name);
                            Interface.PrintNumberCalories(d1.NumberCalories());

                            d1++;
                            d1.Show(name);
                            Interface.PrintNumberCalories(d1.NumberCalories());

                            Interface.PrintPercentageCalories(~d1);

                            Dish d2 = new Dish(15, 15, 20);
                            name = "idealDish";
                            d2.Show(name);
                            Interface.PrintNumberCalories(d2.NumberCalories());
                            Interface.PrintIsIdeal((bool)d2);

                            string dishDetails = d1;
                            Interface.PrintDishDetails(dishDetails);

                            int total = 1.5 * d1;
                            Interface.PrintTotalCalorieContent(total);

                            bool isHigher = d1 > d2;
                            bool isLower = d1 < d2;
                            Interface.PrintDishComparison(isHigher, isLower);
                            break;
                        }

                    case 3:
                        {
                            DishArray arr = new DishArray();
                            int addAnswer;
                            do
                            {
                                Interface.PrintAdditionalMenu();
                                addAnswer = Interface.GetInt();
                                switch (addAnswer)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            arr = new DishArray(5);
                                            arr.Show();
                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.Clear();
                                            arr = new DishArray(5, 1);
                                            Console.Clear();
                                            arr.Show();
                                            break;
                                        }

                                    case 3:
                                        {
                                            Console.Clear();
                                            Interface.PrintMostCaloric(arr);
                                            break;
                                        }

                                    case 4:
                                        {
                                            Console.Clear();
                                            arr[0] = new(10, 10, 10);
                                            Dish d = new(100, 100, 100);
                                            arr[100] = d;
                                            arr.Show();
                                            try
                                            {
                                                Console.Write(arr[2]);
                                            }
                                            catch (IndexOutOfRangeException e)
                                            {
                                                Interface.ChangeColor(e.Message + "\n\n", ConsoleColor.Red);
                                            }
                                            try
                                            {
                                                Console.WriteLine(arr[100]);
                                            }
                                            catch (IndexOutOfRangeException e)
                                            {
                                                Interface.ChangeColor(e.Message + "\n\n", ConsoleColor.Red);
                                            }
                                            break;
                                        }

                                    case 5:
                                        {
                                            Interface.PrintCountObjects(2);
                                            break;
                                        }

                                    case 6:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Interface.TypeError(2);
                                            break;
                                        }
                                }
                            } while (addAnswer != 6);
                            break;
                        }

                    case 4:
                        {
                            do
                            {
                                Interface.PrintExitMenu();
                                answer = Interface.GetInt();
                                Console.Clear();
                                switch (answer)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Interface.ExitProgramm();
                                            System.Environment.Exit(0);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Interface.TypeError(2);
                                            break;
                                        }
                                }
                            } while (answer != 2);
                            break;
                        }
                    default:
                        {
                            Interface.TypeError(2);
                            break;
                        }
                }
            } while (answer != 4);
        }
    }
}