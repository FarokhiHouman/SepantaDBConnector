namespace SepantaDBConnector;

internal static class Program
{
#region Mthods
#region Other
	/// <summary>
	///     The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(mainForm: new FrmMain());
	}
#endregion
#endregion
}