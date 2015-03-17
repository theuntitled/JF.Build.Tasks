using System.Reflection;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace JF.Build.Tasks {

	public class GetVersionNumber : Task {

		[Required]
		public string FileName { get; set; }

		[Output]
		public string VersionString { get; set; }

		public override bool Execute() {
			var assemblyName = AssemblyName.GetAssemblyName( FileName );

			VersionString = assemblyName.Version.ToString( 3 );

			return true;
		}

	}

}
