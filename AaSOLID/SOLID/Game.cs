using AaSOLID.Setting;
using AaSOLID.SOLID.BaseClasses;
using AaSOLID.SOLID.Main;

namespace AaSOLID.SOLID
{
    internal class Game : IGame
    {
#pragma warning disable IDE0044 // Добавить модификатор только для чтения
        private string[] args;
        private BaseSetting Setting; /* L — Принцип подстановки Барбары Лисков (Liskov Substitution Principle или LSP) */
        private bool Result = false;

        private IWriter Writer = new ConsoleWriter(); /* L — Принцип подстановки Барбары Лисков (Liskov Substitution Principle или LSP) */
        private  IWriter Logger;
#pragma warning restore IDE0044 // Добавить модификатор только для чтения

        public Game(string[] MainArgs, IWriter logger)
        {

            args = MainArgs;
            StartGame();
            Logger = logger;
            Setting = new SettingFromArgs(args);
            Int32 target = (Int32)(new GeneratorIntRandom(Setting).Generate());
            Logger.Write($"{TextResource.StartGame} {target}");

            Writer.Write(TextResource.GameWelcome);
            Writer.Write(TextResource.Input);
            for (int i = 0; i < Setting.NumberAttempts; i++)
            {
                int userNumber = (int)ConsoleUIntReader.Read();
                Logger.Write($" Попытка номер {i+1} число {userNumber}");
                if (userNumber == target)
                {
                    Result = true;
                    EndGame();
                    return;
                }
                else if (userNumber < target)
                {
                    Writer.Write(TextResource.TargetMore);
                }
                else if (userNumber > target)
                {
                    Writer.Write(TextResource.TargetLess);
                }
            }
            EndGame();
        }

        public  void StartGame()
        {
            Setting = new SettingFromArgs(args);
            Setting.Load();
        }


        public void EndGame()
        {
            var textResult = Result ? TextResource.WinnerText : TextResource.FailText;
            Writer.Write(textResult);
            Setting.Save();
            Logger.Write($" Результат игры : {textResult}");
        }
    }
}
