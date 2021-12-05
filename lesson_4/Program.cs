class Program
{
    static void Main(string[] args)
    {
        Building bulding1 = new Building(12, 27, 9, 4, 9);
        Building bulding2 = new Building(7, 9, 2, 3, 2);
        Building bulding3 = new Building(136, 15, 6, 2, 25);

        Console.WriteLine(bulding1.ToString());
       
    }
}

class Building
{
    //поля
    public int number;
    private int height;
    private int floor;
    private int apartment;//количество квартир на этаже
    private int entrance;

    //свойства
    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    public int Height
    {
        get { return height; }
        set { height = value; }
    }
    public int Floor
    {
        get { return floor; }
        set { floor = value; }
    }
    public int Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    } 
    public int Entrance
    {
        get { return entrance; }
        set { entrance = value; }
    }

    //конструктор
    public Building(
        int number,
        int height,
        int floor,
        int apartment,
        int entrance)
    {
        this.number = number;
        this.height = height;
        this.floor = floor;
        this.apartment = apartment;
        this.entrance = entrance;

    }

    //методы
    public int ApartmentInEntrance()
    {
        return Apartment * Floor;
    }

    public int ApartmentInBuilding()
    {
        return ApartmentInEntrance() * Entrance;
    }
    public int FloorHeight()
    {
        return Height / Floor;
    }

    public override string ToString()
    {
        return string.Format(
            "Номер здания: {0}\n" +
            "Количество подъездов: {1} \n" +
            "Количество квартир(всего): {2}",
            Number, Entrance, ApartmentInBuilding());
    }
}
