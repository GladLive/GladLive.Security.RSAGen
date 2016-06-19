using GladLive.Security.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GladLive.Security.RSAGen.App
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Grab the incoming args.
			//Should contain cert name as first arg
			ArgParser appArgs = new ArgParser(args);

			//This will load the cert file with the provided path.
			CertLoader loader = new CertLoader(appArgs.CertName);
		}
	}
}
