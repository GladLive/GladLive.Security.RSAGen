using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GladLive.Security.RSAGen.Lib.Tests
{
	[TestFixture]
	public class RSAExportFormatterTests
	{
		[Test]
		public static void Test_Client_And_Server_Dont_Acccidently_Expose_RSA_Parameters()
		{
			//This test was hacked together really quick
			//It's just a security measure to check to make sure exported keys don't leak private key.
			//arrange
			RSAExportFormatter formatter = new RSAExportFormatter(new RSACryptoServiceProvider());

			using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
			{
				//act:
				provider.FromXmlString(formatter.ClientRSAXML);

				//Should be public only
				Assert.IsTrue(provider.PublicOnly);


				//act again
				provider.FromXmlString(formatter.ServerRSAXML);

				//Should be public and private.
				Assert.False(provider.PublicOnly);
			}
		}
	}
}
