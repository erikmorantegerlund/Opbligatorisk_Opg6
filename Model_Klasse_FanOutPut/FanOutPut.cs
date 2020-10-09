using System;

namespace Model_Klasse_FanOutPut
{
    public class FanOutPut
    {
        private int _id;
        private string _name;
        private int _temp;
        private int _moist;

        public FanOutPut(int id, string name, int temp, int moist)
        {
            _id = id;
            _name = name;
            _temp = temp;
            _moist = moist;
        }

        public FanOutPut()
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentOutOfRangeException("Input name must consist of 2 or more letters");

                }

                _name = value;
            }
        }

        public int Temp
        {
            get { return _temp; }
            set
            {
                if (value < 15 || value > 25)
                {
                    throw new ArgumentOutOfRangeException("Temp must be in between 15 and 25");
                }

                _temp = value;
            }
        }

        public int Moist
        {
            get { return _moist; }
            set
            {
                if (value < 30 || value > 80)
                {
                    throw new ArgumentOutOfRangeException("Moist must be in between 30 and 80");
                }

                _moist = value;
            }
        }
    }
}
