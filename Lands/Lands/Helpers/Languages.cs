

namespace Lands.Helpers
{
    using Lands.Interfaces;
    using Lands.Resources;  
    using Xamarin.Forms;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalice>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalice>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string EmailPlaceHolder
        {
            get { return Resource.EmailPlaceHolder; }
        }

        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }

        //public static string passwordvalidation
        //{
        //    get { return resource.passwordvalidation; }
        //}

        //public static string somethingwrong
        //{
        //    get { return resource.somethingwrong; }
        //}

        //public static string login
        //{
        //    get { return resource.login; }
        //}

        //public static string email
        //{
        //    get { return resource.email; }
        //}

        //public static string password
        //{
        //    get { return resource.password; }
        //}

        //public static string passwordplaceholder
        //{
        //    get { return resource.passwordplaceholder; }
        //}

        //public static string forgot
        //{
        //    get { return resource.forgot; }
        //}

        //public static string register
        //{
        //    get { return resource.register; }
        //}

        //public static string countries
        //{
        //    get { return resource.countries; }
        //}

        //public static string search
        //{
        //    get { return resource.search; }
        //}

        //public static string country
        //{
        //    get { return resource.country; }
        //}

        //public static string information
        //{
        //    get { return resource.information; }
        //}

        //public static string capital
        //{
        //    get { return resource.capital; }
        //}

        //public static string population
        //{
        //    get { return resource.population; }
        //}

        //public static string area
        //{
        //    get { return resource.area; }
        //}

        //public static string alphacode2
        //{
        //    get { return resource.alphacode2; }
        //}

        //public static string alphacode3
        //{
        //    get { return resource.alphacode3; }
        //}

        //public static string region
        //{
        //    get { return resource.region; }
        //}

        //public static string subregion
        //{
        //    get { return resource.subregion; }
        //}

        //public static string demonym
        //{
        //    get { return resource.demonym; }
        //}

        //public static string gini
        //{
        //    get { return resource.gini; }
        //}

        //public static string nativename
        //{
        //    get { return resource.nativename; }
        //}

        //public static string numericcode
        //{
        //    get { return resource.numericcode; }
        //}

        //public static string cioc
        //{
        //    get { return resource.cioc; }
        //}

        //public static string borders
        //{
        //    get { return resource.borders; }
        //}

        //public static string currencies
        //{
        //    get { return resource.currencies; }
        //}

        //public static string mylanguages
        //{
        //    get { return resource.mylanguages; }
        //}
    }
}
