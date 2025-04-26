using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using MauiWindow = Microsoft.Maui.Controls.Window;
using AndroidWindow = Android.Views.Window;

#if ANDROID
using Android.Views;
using Android.OS;
using Microsoft.Maui.Platform;
#endif

namespace prueba1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#FFF5E1"), // El color que quieras para la "franja"
            BarTextColor = Colors.Black         // El color del texto (por ejemplo, negro para texto claro)
        };
#if ANDROID
        if (OperatingSystem.IsAndroidVersionAtLeast(21))
        {
            AndroidWindow? androidStatusBarWindow = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window;
            if (androidStatusBarWindow != null)
            {
                androidStatusBarWindow.SetStatusBarColor(Colors.Beige.ToPlatform());
            }
        }

        if (OperatingSystem.IsAndroidVersionAtLeast(23))
        {
            AndroidWindow? androidStatusBarIconWindow = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window;
            if (androidStatusBarIconWindow != null)
            {
                // Para iconos claros en fondo oscuro
                androidStatusBarIconWindow.DecorView.SystemUiVisibility &= ~(StatusBarVisibility)SystemUiFlags.LightStatusBar;
            }
        }
#endif
    }

    protected override MauiWindow CreateWindow(IActivationState activationState)
    {
        MauiWindow mauiWindow = base.CreateWindow(activationState);

        mauiWindow.HandlerChanged += (sender, e) =>
        {
#if ANDROID
            if (OperatingSystem.IsAndroidVersionAtLeast(21))
            {
                AndroidWindow? androidWindow = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window;
                if (androidWindow != null)
                {
                    androidWindow.SetStatusBarColor(Colors.Beige.ToPlatform());
                    androidWindow.SetNavigationBarColor(Colors.Beige.ToPlatform());

                    if (OperatingSystem.IsAndroidVersionAtLeast(23))
                    {
                        androidWindow.DecorView.SystemUiVisibility &= ~(StatusBarVisibility)SystemUiFlags.LightStatusBar;
                    }

                    var insetsController = androidWindow.InsetsController;
                    if (insetsController != null)
                    {
                        insetsController.SetSystemBarsAppearance(0, (int)WindowInsetsControllerAppearance.LightNavigationBars);
                    }

                }
            }
#endif
        };

        return mauiWindow;
    }
}
