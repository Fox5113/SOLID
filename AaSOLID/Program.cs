using AaSOLID.Setting;

int min = default(int);
int max = 20;
int numberNumberAttempt = 10;
int? userNumber = null;
bool result = false;

if(args.Length >= 3)
{
    int.TryParse(args[0].ToString(), out min);
    int.TryParse(args[1].ToString(), out max);
    int.TryParse(args[2].ToString(), out numberNumberAttempt);
}

var setting = new Setting(min, max, numberNumberAttempt);

var random = new Random();
var target = random.Next(setting.Min, setting.Max);
Console.WriteLine("Игра угадай число привествует вас");
Console.WriteLine("Введите число");
for (int i = 0; i < setting.NumberAttempts; i++)
{
    userNumber = null;
    while (userNumber == null)
    {
        try
        {
            userNumber = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ой вы ввели что-то не то");
        }
    }
    if (userNumber == target)
    {
        Console.WriteLine("Ура вы выйграли");
        result = true;
        break;
    }
    else if(userNumber < target)
    {
        Console.WriteLine("Увы но не повезло ваше число меньше");
    }
    else if (userNumber > target)
    {
        Console.WriteLine("Увы но не повезло ваше число больше");
    }


}

if (!result)
{
    Console.WriteLine("Вы проиграли");
}



