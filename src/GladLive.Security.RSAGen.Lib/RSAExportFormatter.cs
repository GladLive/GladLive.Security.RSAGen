using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GladLive.Security.RSAGen.Lib
{
	/// <summary>
	/// Formats the <see cref="RSACryptoServiceProvider"/> exported keys in the form of
	/// XML string data.
	/// </summary>
	public class RSAExportFormatter
	{
		/// <summary>
		/// Client RSA keypair in XML format.
		/// Only exposes public key.
		/// </summary>
		public string ClientRSAXML { get; }

		/// <summary>
		/// Server RSA keypair in XML format.
		/// Exposes both public and private key.
		/// </summary>
		public string ServerRSAXML { get; }

		public RSAExportFormatter(RSACryptoServiceProvider provider)
		{
			//Just export the keys
			ClientRSAXML = provider.ToXmlString(false);
			ServerRSAXML = provider.ToXmlString(true);
		}
	}
}
