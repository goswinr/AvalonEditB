
// added by goswinr for using an external logging function during debugging
using System;

namespace AvalonEditB.Utils
{
	/// <summary>
	/// A  static class for logging ,intended for debuging 
	/// </summary>
	public static class Logging
	{
		/// <summary>
		/// The logging action that can be set
		/// </summary>
		public static Action<string> LogAction = new Action<string>(message => { });

		/// <summary>
		/// This function uses the logging Action 'logAction' of the same static class.
		/// </summary>
		public static void Log(string message) { LogAction.Invoke(message); }
	
	}

}
		

