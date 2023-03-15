using Cpp2IlInjected;
using UnityEngine;

namespace EpicSdk.Configuration
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CreateAssetMenu]
	public class EpicServiceConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		[SerializeField]
		private string _productName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		[SerializeField]
		private string _version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		[SerializeField]
		private string _productId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		[SerializeField]
		private string _sandboxId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		[SerializeField]
		private string _clientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		[SerializeField]
		private string _clientSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		[SerializeField]
		private string _deploymentEnvironmentId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[SerializeField]
		private string _deploymentReleaseId;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string ProductName
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _productName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _version;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string ProductId
		{
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _productId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public string SandboxId
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _sandboxId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public string DeploymentEnvironmentId
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _deploymentEnvironmentId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public string DeploymentReleaseId
		{
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _deploymentReleaseId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public string ClientId
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _clientId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _clientSecret;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public static bool IsReleaseDeployment
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x1367850", Offset = "0x1366250", VA = "0x181367850")]
		public string GetDeploymentId()
		{
			return _deploymentReleaseId;
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public EpicServiceConfig()
		{
		}
	}
}
