//References

//Class Definiton
//Scope -- Type -- Name

public class Human
{
    //variables
    int age;
    float height;
    bool gender;
    string firstName, familyName;
    bool hungry;
    float energy;

        //constructor
	public Human(int _age, float _height, bool _gender, string _firstName,string _familyName)
	{
        age = _age;
        height = _height;
        gender = _gender;
        firstName = _firstName;
        familyName = _familyName;
        hungry = true;
        energy = 100;
	}

    //functions (methods)

    public void DayInLife()
    {
        Ageing();
        Eating();
        Sleeping();
    }

    public string  GetFirstName()
    {
        return firstName;
    }

    private void Ageing()
    {
        age = age + 1;
        energy = energy - 1;
    }

    public void Eating()
    {
        hungry = false;
        energy = energy - 1;
    }

    private void Sleeping()
    {
        hungry = true;
        energy = energy + 1;
    }
}
