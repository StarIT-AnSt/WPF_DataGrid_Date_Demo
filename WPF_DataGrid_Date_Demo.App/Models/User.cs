using System;

namespace WPF_DataGrid_Date_Demo.App.Models;

public class User : BaseNotify
{
    private string _first;

    public string FirstName
    {
        get => _first;
        set => SetField(ref _first, value);
    }

    private string _last;

    public string LastName
    {
        get => _last;
        set => SetField(ref _last, value);
    }

    private DateTime _birth;

    public DateTime DateOfBirth
    {
        get => _birth;
        set => SetField(ref _birth, value);
    }
}
