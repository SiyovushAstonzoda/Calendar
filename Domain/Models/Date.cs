using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models;

public class Date
{
    private int _month;
    private int _day;
    private int _year;

    public Date(int month, int day, int year)
    {
        _month = month;
        _day = day;
        _year = year;
    }

    public Date()
    {
        
    }

    public void setDate(int month, int day, int year)
    {
        _month = month;
        _day = day;
        _year = year;
    }

    public int getYear { get { return _year; } }
    public int getMonth { get { return _month; } }
    public int getDay { get { return _day; } }

    public int setYear { set { _year = value; } }
    public int setMonth { set { _month = value; } }
    public int setDay { set { _day = value; } }

    public int increaseDay { set { ++_day; } }
    public int increaseMonth { set { ++_month; } }
    public int increaseYear { set { ++_year; } }
}
