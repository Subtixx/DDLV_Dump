using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F1C")]
	public class GlobalStorage : BaseStorage<GlobalStorageData>
	{
		[Cpp2IlInjected.Token(Token = "0x4003DB0")]
		private static GlobalStorage _instance;

		[Cpp2IlInjected.Token(Token = "0x1700159D")]
		public static GlobalStorage Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6007C61")]
			[Cpp2IlInjected.Address(RVA = "0x1D05D50", Offset = "0x1D04750", VA = "0x181D05D50")]
			get
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159E")]
		public override string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6007C63")]
			[Cpp2IlInjected.Address(RVA = "0x1D06020", Offset = "0x1D04A20", VA = "0x181D06020", Slot = "4")]
			get
			{
				return "global_storage.json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159F")]
		private string CurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6007C67")]
			[Cpp2IlInjected.Address(RVA = "0x1D05D10", Offset = "0x1D04710", VA = "0x181D05D10")]
			get
			{
				return App.StorePlatform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A0")]
		public string LastUserKeyByPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6007C68")]
			[Cpp2IlInjected.Address(RVA = "0x1D05E60", Offset = "0x1D04860", VA = "0x181D05E60")]
			get
			{
				//Discarded unreachable code: IL_005a
				bool flag = default(bool);
				ulong num = default(ulong);
				do
				{
					if (string.IsNullOrEmpty(App.StorePlatform))
					{
						continue;
					}
					Dictionary<string, string> _003CLastUserKeyPlatform_003Ek__BackingField = ((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastUserKeyPlatform;
					if (!flag)
					{
						GlobalStorageData globalStorageData = (GlobalStorageData)((BaseStorage<DataType>)(object)this).Data;
						string _003CLastUserKey_003Ek__BackingField = globalStorageData.LastUserKey;
						if (globalStorageData != null && App.StorePlatform != "epic")
						{
							return ((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastUserKey;
						}
					}
				}
				while (num != 0);
				return string.Empty;
			}
			[Cpp2IlInjected.Token(Token = "0x6007C69")]
			[Cpp2IlInjected.Address(RVA = "0x1D06050", Offset = "0x1D04A50", VA = "0x181D06050")]
			set
			{
				//Discarded unreachable code: IL_0012, IL_003c
				Dictionary<string, string> _003CLastUserKeyPlatform_003Ek__BackingField = ((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastUserKeyPlatform;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C62")]
		[Cpp2IlInjected.Address(RVA = "0x1D05A70", Offset = "0x1D04470", VA = "0x181D05A70")]
		public static void DeleteInstance()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007C64")]
		[Cpp2IlInjected.Address(RVA = "0x1D05C70", Offset = "0x1D04670", VA = "0x181D05C70")]
		private GlobalStorage()
		{
			//IL_0010: Expected O, but got I4
			((BaseStorage<DataType>)(object)this)._002Ector(FileSystem.SaveGlobal, (Client)0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C65")]
		[Cpp2IlInjected.Address(RVA = "0x1D05AB0", Offset = "0x1D044B0", VA = "0x181D05AB0", Slot = "6")]
		protected override void PostLoad()
		{
			//Discarded unreachable code: IL_0007
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007C66")]
		[Cpp2IlInjected.Address(RVA = "0x1D05BC0", Offset = "0x1D045C0", VA = "0x181D05BC0")]
		public void SetOnlineIds(string titleId, string playFabId)
		{
			//Discarded unreachable code: IL_0020
			((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastTitleId = titleId;
			((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastPlayFabId = playFabId;
			((BaseStorage<DataType>)(object)this).Save(isForced: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C6A")]
		[Cpp2IlInjected.Address(RVA = "0x1D05B40", Offset = "0x1D04540", VA = "0x181D05B40")]
		public void SetLastLanguage(string lang)
		{
			//Discarded unreachable code: IL_0014
			((GlobalStorageData)((BaseStorage<DataType>)(object)this).Data).LastLanguage = lang;
			((BaseStorage<DataType>)(object)this).Save(isForced: true);
		}
	}
}
