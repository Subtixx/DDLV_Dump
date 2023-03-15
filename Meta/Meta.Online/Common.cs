using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F03")]
	public class Common
	{
		[Cpp2IlInjected.Token(Token = "0x6007BDC")]
		[Cpp2IlInjected.Address(RVA = "0x167FD40", Offset = "0x167E740", VA = "0x18167FD40")]
		public static void SetupHttp()
		{
			ServicePointManager.DefaultConnectionLimit = 10;
			RemoteCertificateValidationCallback _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true);
			}
			ServicePointManager.ServerCertificateValidationCallback = _003C_003E9__0_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BDD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Common()
		{
		}
	}
}
