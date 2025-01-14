﻿using SimpleIdServer.Mobile.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SimpleIdServer.Mobile.ViewModels;

public class EnrollViewModel : INotifyPropertyChanged
{
    private bool _isDeveloperModeEnabled = false;

    public EnrollViewModel(SettingsPageViewModel settings)
    {
        Settings = settings;
        SubmitQRCodeCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync("enrollsubmitqrcode");
        });
        ScanQRCodeCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync("enrollscanqrcode");
        });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public bool IsDeveloperModeEnabled
    {
        get => _isDeveloperModeEnabled;
        set
        {
            if (_isDeveloperModeEnabled != value)
            {
                _isDeveloperModeEnabled = value;
                OnPropertyChanged();
            }
        }
    }

    public SettingsPageViewModel Settings { get; private set; }

    public ICommand SubmitQRCodeCommand { get; private set; }

    public ICommand ScanQRCodeCommand { get; private set; }

    public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void Init()
    {
        MobileSettings mobileSettings = null;
        Task.Run(async () =>
        {
            mobileSettings = await App.Database.GetMobileSettings();
        }).Wait();
        IsDeveloperModeEnabled = mobileSettings.IsDeveloperModeEnabled;
    }
}
