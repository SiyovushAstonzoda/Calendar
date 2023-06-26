using Domain.Models;

namespace Infrastructure.Services;

public class DateService
{
    Date _date = new Date();
    public DateService(Date date)
    {
        _date = date;
    }

    public DateService()
    {
        
    }

    public string toString()
    {
        if(_date.getDay > 0 && _date.getDay < 10 && _date.getMonth > 0 && _date.getMonth < 10)
        {
            return $"0{_date.getMonth}/0{_date.getDay}/{_date.getYear}";
        }
        else if(_date.getDay > 0 && _date.getDay < 10)
        {
            return $"{_date.getMonth}/0{_date.getDay}/{_date.getYear}";
        }
        else if (_date.getMonth > 0 && _date.getMonth < 10)
        {
            return $"0{_date.getMonth}/{_date.getDay}/{_date.getYear}";
        }
        else
        {
            return $"{_date.getMonth}/{_date.getDay}/{_date.getYear}";
        }
    }

    public DateService nextDay()
    {
        _date.increaseDay = _date.getDay;
        if(_date.getDay > 31)
        {
            _date.setDay = 0;
            _date.increaseMonth = _date.getMonth;
            if( _date.getMonth > 12)
            {
                _date.setMonth = 0;
                _date.increaseYear = _date.getYear;
            }
        }
        return this;
    }
}
