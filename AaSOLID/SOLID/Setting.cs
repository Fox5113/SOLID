namespace AaSOLID.Setting
{
    internal class Setting
    {
        #region private field
 
        #endregion

        #region constructor
        public Setting(int min, int max, int numberAttempts)
        {
            Min = min;
            Max = max;
            NumberAttempts = numberAttempts;
        }

        public int Min { get; private set; }
        public int Max { get; private set; }
        public int NumberAttempts { get; private set; }
        #endregion

    }
}
