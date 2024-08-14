using AaSOLID.SOLID.BaseClasses;
using AaSOLID.SOLID.Main;
using System.Text.Json;

namespace AaSOLID.Setting
{
    internal class SettingFromArgs: BaseSetting
    {
        #region private field

        int min = default;
        int max = 20;
        int numberNumberAttempt = 10;
        string[] Args;

        #endregion

        #region constructor

        public SettingFromArgs(string[] args)
        {
            Args = args;
            Min = min;
            Max = max;
            NumberAttempts = numberNumberAttempt;
            Save();
        }
        

        public override (int, int, int) GetSettings()
        {
            return (Min, Max, NumberAttempts);
        }


        public override void Save()
        {
            var settings = (BaseSetting)this;
            string jsonString = JsonSerializer.Serialize(settings);
            WriteFile file = new("Setting.txt");
            file.Write(jsonString);
        }

        public override void Load()
        {
            if (Args.Length >= 3)
            {
                int.TryParse(Args[0].ToString(), out min);
                int.TryParse(Args[1].ToString(), out max);
                int.TryParse(Args[2].ToString(), out numberNumberAttempt);
            }

            Min = min;
            Max = max;
            NumberAttempts = numberNumberAttempt;
        }
        #endregion

    }
}
