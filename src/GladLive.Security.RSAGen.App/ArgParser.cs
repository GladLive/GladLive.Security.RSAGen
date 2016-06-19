using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GladLive.Security.RSAGen.App
{
	/// <summary>
	/// Parses the incoming application arguments into a strong-typed form.
	/// </summary>
	public class ArgParser
	{
		/// <summary>
		/// Name of the incoming certificate.
		/// </summary>
		public string CertName { get; }

		public ArgParser(string[] args)
		{
			if (args == null)
				throw new ArgumentNullException(nameof(args), "Must provide valid cert name to load.");

			if (args.Count() < 1)
				throw new ArgumentException("Must provide valid cert name as first arg to application.");

			CertName = args.First();
		}
	}
}
