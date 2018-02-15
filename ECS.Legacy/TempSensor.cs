namespace ECS.Legacy
{
    internal class TempSensor : ITempSensor
    {
        private int temperatur;

        public int GetTemp()
        {
            return temperatur;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public void SetTemp(int temp)
        {
            temperatur = temp;
        }

        public void WasItCalled(bool status)
        {
            throw new System.NotImplementedException();
        }

        public int Temp { get; set; }
        public bool Status { get; set; }
    }
}