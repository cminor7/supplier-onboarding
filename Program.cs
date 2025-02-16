namespace ONBOARDING
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
			//ApplicationConfiguration.Initialize();

			// ***this line is added***
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDPIAware();
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());

		}

		// ***also dllimport of that function***
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}