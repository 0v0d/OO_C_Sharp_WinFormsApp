namespace OO_C_Sharp_WinFormsApp
{

    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /*
             * FatPerson
             */
            Application.Run(new FatPerson(
                // int id
                1,
                // String familyName
                "éOñÿ",
                // String name
                "êíçs",
                // int yearOfBirth
                1969,
                // int monthOfBirth
                12,
                // int dayOfBirth
                18,
                // Image image
                Properties.Resources.image_01_60x80));

        }

    }

}