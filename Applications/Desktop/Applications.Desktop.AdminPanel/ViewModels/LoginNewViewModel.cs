using Applications.Desktop.AdminPanel;
using ProjectC.Applications.Desktop.AdminPanel.Commands;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectC.Applications.Desktop.AdminPanel.ViewModels;

public class LoginNewViewModel : INotifyPropertyChanged, ILoginViewModal
{

    #region Properties
    private string _loginField;
    public string LoginField
    {
        get
        {
            return _loginField;
        }
        set
        {
            _loginField = value;
            OnPropertyChanged(nameof(LoginField));
        }
    }
    private string _passwordField;
    public string PasswordField
    {
        get
        {
            return _passwordField;
        }
        set
        {
            _passwordField = value;
            OnPropertyChanged(nameof(PasswordField));
        }
    }




    #endregion

    #region Commands
    private ButtonCommand _loginCommand;
    public ButtonCommand LoginCommand
    {
        get
        {
            if (_loginCommand == null)
            {
                _loginCommand = new ButtonCommand(LoginMethod);
            }
            return _loginCommand;
        }

    }

    private void LoginMethod(object? obj)
    {
        if (!string.IsNullOrEmpty(LoginField) && !string.IsNullOrEmpty(PasswordField))
        {
            MessageBoxYesNo?.Invoke("Work", "Test");

            //MessageBox.Show("Work"); // отсюда лучше не вызывать уведомление

            LoginField = "LoginField";
            PasswordField = "PasswordField";
        }
        else
        {
            MessageBoxYesNo?.Invoke("Login or Password dont correct", "Info");
        }

    }
    #endregion

    #region Implement INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    #endregion

    #region Implement IViewModel
    public Func<string, string, bool> MessageBoxYesNo { get; set; }

    #endregion
}
