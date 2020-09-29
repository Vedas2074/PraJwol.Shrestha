class People
{
    internal string name;
    int number = 23;

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            if (value > 0 && value < 10)
                number = value;
        }
    }   
        // Autoimplemented property
        public string Name { get; set; }

        // ReadONly property
        public string Address{ get ;}

}