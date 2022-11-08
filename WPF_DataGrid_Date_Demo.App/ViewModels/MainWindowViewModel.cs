using System;
using System.Collections.ObjectModel;
using WPF_DataGrid_Date_Demo.App.Models;

namespace WPF_DataGrid_Date_Demo.App.ViewModels;

public class MainWindowViewModel : BaseNotify
{
    public ObservableCollection<User> Users { get; set; }

    private User _user;

    public User SelectedUser
    {
        get => _user;
        set => SetField(ref _user, value);
    }

    public BaseCommand AddCommand { get; set; }
    public BaseCommand DelCommand { get; set; }

    public MainWindowViewModel()
    {
        Users = new ObservableCollection<User>
        {
            new() { LastName = "Users", FirstName = "User 1", DateOfBirth = new DateTime(2000, 1, 1) },
            new() { LastName = "Users", FirstName = "User 2", DateOfBirth = new DateTime(1000, 1, 1) }
        };

        AddCommand = new BaseCommand(_ => true, _ => Add());
        DelCommand = new BaseCommand(_ => Users.Count > 1, _ => Del());
    }

    private void Add()
    {
        Users.Add(SelectedUser);
    }

    private void Del()
    {
        Users.Remove(SelectedUser);
    }
}
