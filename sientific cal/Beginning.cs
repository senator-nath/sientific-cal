namespace sientific_cal
{
    internal class Beginning
    {
        public string OperationSign { get; set; }
        public void OperatorSign()
        {
            var oper = new RootAndPowerOperation();
            {
                Console.WriteLine("select operation (select (1 for +),(2 for -),(3 for *),(4 for /),(5 for %),( 6 for log),(7 for sin),(8 for cos),(9 for tan),(10 for square),(11 for sqrt),(12 for cube),(13 for cuberoot),(14 for nthroot), (15 for nthpower)\n Enter a number:");
                OperationSign = Console.ReadLine();
                string operationSign = OperationSign;
                if (operationSign == "1" || operationSign == "2" || operationSign == "3" || operationSign == "4" || operationSign == "5")
                {
                    Method1();
                }
                else if (operationSign == "6" || operationSign == "7" || operationSign == "8" || operationSign == "9" || operationSign == "10" || operationSign == "11" || operationSign == "12")
                {
                    Method2();
                }
                else if (operationSign == "13" || operationSign == "14" || operationSign == "15")
                {
                    Method3();
                }
                else
                {
                    Console.WriteLine("Not a valid operator sign");
                    OperatorSign();

                }
            }
        }
        public void Method1()
        {
            double result;
            var res = Beginning.FirstNumberCheck();
            if (res != "")
            {
                var res2 = Beginning.LastNumberCheck();
                if (res2 != "")
                {
                    var operate = new BasicOpeartion();
                    switch (OperationSign)
                    {
                        case "1":
                            result = operate.SumOperation(Convert.ToDouble(res), Convert.ToDouble(res2)); break;
                        case "2":
                            result = operate.SubtractOperation(Convert.ToDouble(res), Convert.ToDouble(res2)); break;
                        case "3":
                            result = operate.MultiplyOperation(Convert.ToDouble(res), Convert.ToDouble(res2)); break;
                        case "4":
                            result = operate.DivideOperation(Convert.ToDouble(res), Convert.ToDouble(res2)); break;
                        case "5":
                            result = operate.RemaindeerOperation(Convert.ToDouble(res), Convert.ToDouble(res2)); break;

                        default:
                            Console.WriteLine("invalid operation"); return;
                    }
                    Console.WriteLine("Result = {0} ", result);
                }
                else
                {
                    Console.WriteLine("enter the correct number");
                    Beginning.LastNumberCheck();
                }
            }
            else
            {
                Method1();
            }
        }

        public void Method3()
        {
            while (true)
            {
                try
                {
                    double result;
                    Console.WriteLine("enter base number");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter root number");
                    double num2 = double.Parse(Console.ReadLine());

                    baseOperation operate = new baseOperation();

                    switch (OperationSign)
                    {
                        case "13":
                            result = operate.LogOfNumbers(num1, num2); break;
                        case "14":
                            result = operate.NthPowerOfNumbers(num1, num2); break;
                        case "15":
                            result = operate.NthRootOfNumbers(num1, num2); break;
                        default:
                            Console.WriteLine("invalid operation"); return;

                    }
                    Console.WriteLine("Result = {0} ", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press continue to continue or exit to abort:");
                    string z = Console.ReadLine();

                    if (z == "continue")
                    {
                        continue;
                    }

                    else if (z == "exit")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        public void Method2()
        {
            while (true)
            {
                try
                {
                    double result;
                    var res = Beginning.MethodTwoNumberCheck();
                    if (res != "")
                    {
                        operationOne operatee = new operationOne();
                        switch (OperationSign)
                        {
                            case "6":
                                result = operatee.CosOfNumbers(Convert.ToDouble(res)); break;
                            case "7":
                                result = operatee.SinOfNumbers(Convert.ToDouble(res)); break;
                            case "8":
                                result = operatee.TanOfNumbers(Convert.ToDouble(res)); break;
                            case "9":
                                result = operatee.SquareOfNumbers(Convert.ToDouble(res)); break;
                            case "10":
                                result = operatee.SqrtOfNumbers(Convert.ToDouble(res)); break;
                            case "11":
                                result = operatee.cubeOfNumbers(Convert.ToDouble(res)); break;
                            case "12":
                                result = operatee.CuberootOfNumbers(Convert.ToDouble(res)); break;
                            default:
                                Console.WriteLine("invalid operation"); return;
                        }

                        Console.WriteLine("Result = {0} ", result);
                    }

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press continue to continue or exit to abort:");
                    Console.WriteLine("enter e to exit");
                    var inp = Console.ReadLine();
                    if(inp != "e") 
                    {
                        Method2();
                    }
                    string y = Console.ReadLine();

                    if (y == "continue")
                    {
                        continue;
                    }

                    else if (y == "exit")
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
                finally
                {
                    // Console.WriteLine("input exit to close or input continue to continue");
                    //  Console.ReadKey();
                }
            }
        }
        public static string FirstNumberCheck()
        {
            string result = "";
            Console.WriteLine("enter first number");
            string num1 = Console.ReadLine();
            var isNumber = double.TryParse(num1, out double value);
            if (isNumber)
            {
                result = value.ToString();
            }
            return result;
        }

        public static string LastNumberCheck()
        {
            string result = "";
            Console.WriteLine("enter second number");
            string num2 = Console.ReadLine();
            bool isNumber = double.TryParse(num2, out double value);
            if (isNumber)
            {
                result = value.ToString();
            }
            return result;
        }
        public static  string MethodTwoNumberCheck()
        {
            string result = "";
            Console.WriteLine("enter main number");
            string num1 = Console.ReadLine();
            bool isNumber = double.TryParse(num1, out double value);
            if(isNumber)
            {
                result = value.ToString();
            }
            return result;
        }
    }
}