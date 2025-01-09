class Student
{
    private int _id;
    private string _name;
    private string _surName;
    private int _class;
    private decimal _rating;

    public int ID 
    { 
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        } 
    }

    public string Name 
    { 
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        } 
    }

    public string SurName 
    { 
        get
        {
            return _surName;
        }
        set
        {
            _surName = value;
        } 
    }

    public int Class 
    { 
        get
        {
            return _class;
        }
        set
        {
            _class = value;
        } 
    }

    public decimal Rating 
    { 
        get
        {
            return _rating;
        }
        set
        {
            _rating = value;
        } 
    }


    public Student(int id, string name, string surName, int classes, decimal rating)
    {
        ID = id;
        Name = name;
        SurName = surName;
        Class = classes;
        Rating = rating;
    }

     public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Surname: {SurName}, Class: {Class}, Rating: {Rating}");
        }

     public void BaxoDarajalari(int rating)
        {
            if (rating >= 90)
            {
                Console.WriteLine("Sizning darajangiz A!");
            }
            else if (rating >= 80)
            {
                Console.WriteLine("Sizning darajangiz B!");
            }
            else if (rating >= 70)
            {
                Console.WriteLine("Sizning darajangiz C!");
            }
            else if (rating >= 55)
            {
                Console.WriteLine("Sizning darajangiz D!");
            }
            else
            {
                Console.WriteLine("Siz qayta imtihon topshirishingiz kerak!");
            }
        }
    


}