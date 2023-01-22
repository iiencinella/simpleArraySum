Console.WriteLine("Input a number of parameters to evaluate");
int countParameters = int.Parse(Console.ReadLine());
List<int> arrayParameters = new List<int>();

Console.WriteLine("Input a value for the parameters: ");
int count = 0;
while(count < countParameters) {
  Console.Write("{0}: ", count+1);
  arrayParameters.Add(int.Parse(Console.ReadLine()));
  count++;
}

int result = 0;

foreach (int item in arrayParameters)
{
  result += item;
}

Console.WriteLine("El resultado es {0}", result);