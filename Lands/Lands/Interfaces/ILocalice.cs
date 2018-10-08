

namespace Lands.Interfaces
{
    using System.Globalization;
    
    public interface ILocalice
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
