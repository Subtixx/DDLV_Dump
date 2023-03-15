using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x20002A2")]
	[CreateAssetMenu]
	public class GameloftTrackingConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20002A3")]
		private class ClientIdInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001501")]
			public string StoreName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001502")]
			public string Platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001503")]
			public int Ggi;

			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClientIdInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40014FE")]
		[SerializeField]
		private string _gameAbreviation = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40014FF")]
		[SerializeField]
		private string _productId = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001500")]
		[SerializeField]
		private ClientIdInfo[] _clientIdsInfo;

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x8C1360", Offset = "0x8BFD60", VA = "0x1808C1360")]
		public string GetClientId(string store, string version)
		{
			//IL_008f: Expected O, but got I4
			while (true)
			{
				ClientIdInfo[] clientIdsInfo = _clientIdsInfo;
				Func<ClientIdInfo, bool> func = (Func<ClientIdInfo, bool>)(object)(Func<T, TResult>)delegate(ClientIdInfo c)
				{
					//Discarded unreachable code: IL_0014
					string b = store;
					return string.Equals(c.StoreName, b);
				};
				ClientIdInfo clientIdInfo = Enumerable.FirstOrDefault<ClientIdInfo>((IEnumerable<>)(object)clientIdsInfo, (Func<, >)(object)func);
				if (clientIdInfo == null)
				{
					break;
				}
				object[] array = new object[6];
				string gameAbreviation = _gameAbreviation;
				if (gameAbreviation != null && array == null)
				{
					continue;
				}
				array[0] = gameAbreviation;
				string productId = _productId;
				if (productId != null && array == null)
				{
					continue;
				}
				array[1] = productId;
				int ggi = clientIdInfo.Ggi;
				if (ggi != 0 && ggi == 0)
				{
					continue;
				}
				array[2] = ggi;
				if (version != null && ggi == 0)
				{
					continue;
				}
				array[3] = version;
				string platform = clientIdInfo.Platform;
				if (platform == null || ggi != 0)
				{
					array[4] = platform;
					string storeName = clientIdInfo.StoreName;
					if (storeName == null || ggi != 0)
					{
						array[5] = storeName;
						return string.Format("{0}:{1}:{2}:{3}:{4}:{5}", array);
					}
				}
			}
			string message = default(string);
			Debug.LogError(message);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x8C17D0", Offset = "0x8C01D0", VA = "0x1808C17D0")]
		internal bool TryGetClientId(string store, string version, out string clientId)
		{
			string clientId2 = GetClientId(store, version);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x8C1800", Offset = "0x8C0200", VA = "0x1808C1800")]
		public GameloftTrackingConfig()
		{
		}
	}
}
