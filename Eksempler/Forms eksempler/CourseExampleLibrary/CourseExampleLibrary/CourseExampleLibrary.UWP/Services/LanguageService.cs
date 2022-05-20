using CourseExampleLibrary.Services;
using System.Globalization;
using System.Threading;
using Windows.Globalization;

namespace CourseExampleLibrary.UWP.Services
{
    public class LanguageService : ILanguageService
    {
        public void ChangeLanguage(string language)
        {
            // Tror ikke dette er nødvendigt for UWP (men nok for andre platforme)
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            // Men det her er...
            ApplicationLanguages.PrimaryLanguageOverride = language;
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();
        }
    }
}
