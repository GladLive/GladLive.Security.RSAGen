using GladLive.Security.Common;
using GladLive.Security.RSAGen.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GladLive.Security.RSAGen.App
{
	public class Program
	{
		public static void Main(string[] args)
		{
			GenerateRSA(args, SerializeRSAThenSave);
		}

		public static void GenerateRSA(string[] args, Action<string, string> saveAction)
		{
			//Grab the incoming args.
			//Should contain cert name as first arg
			ArgParser appArgs = new ArgParser(args);

			//This will load the cert file with the provided path.
			CertLoader loader = new CertLoader(appArgs.CertName);

			//Once we've loaded the cert we need to pull the RSA data from it.
			//We want to also load it with the private key.
			RSACryptoServiceProvider provider = new CertToRSAProviderConverter(loader.Certificate, true).Provider;
			RSAExportFormatter formatter = new RSAExportFormatter(provider);

			try
			{
				saveAction(formatter.ClientRSAXML, $"{appArgs.CertName.Replace(".pfx", "")}Client.rsa");

				saveAction(formatter.ServerRSAXML, $"{appArgs.CertName.Replace(".pfx", "")}Server.rsa");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				Console.ReadKey();
			}
		}

		private static void SerializeRSAThenSave(string parameters, string path)
		{
			Console.WriteLine("Serializing RSA parameters.");

			File.WriteAllText(path, parameters);
		}
	}
}
