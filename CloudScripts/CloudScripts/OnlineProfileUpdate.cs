using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public abstract class OnlineProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private int UniqueIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string UniqueName;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40005C7")]
		public int FixInClientVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int OnlineVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005C9")]
		public bool BreakApplyChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Func<OnlineProfileUpdater.ClientContext, bool> ClientContextCondFunc
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CClientContextCondFunc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CClientContextCondFunc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		protected virtual int GetRequiredFragmentCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x116F240", Offset = "0x116DC40", VA = "0x18116F240", Slot = "5")]
			get
			{
				List<PreGameLoad.DataFragments> list;
				do
				{
					list = (List<PreGameLoad.DataFragments>)(object)this.ListRequiredDataFragments();
				}
				while (list == null);
				return ((List<>)(object)list)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x116F1D0", Offset = "0x116DBD0", VA = "0x18116F1D0")]
		protected OnlineProfileUpdate(string name)
		{
			Name = name;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x116F140", Offset = "0x116DB40", VA = "0x18116F140")]
		public void SetUniqueIndex(int index)
		{
			string name = Name;
			UniqueIndex = index;
			string text = (UniqueName = string.Format("{0}_{1}", name, "{0}_{1}"));
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x116ED90", Offset = "0x116D790", VA = "0x18116ED90")]
		public PreGameLoad.OnlineProfileUpdaterTransferData ListRequiredData()
		{
			//Discarded unreachable code: IL_0024
			PreGameLoad.OnlineProfileUpdaterTransferData onlineProfileUpdaterTransferData = new PreGameLoad.OnlineProfileUpdaterTransferData();
			string text = (onlineProfileUpdaterTransferData.Name = UniqueName);
			List<PreGameLoad.DataFragments> list = (onlineProfileUpdaterTransferData.Data = (List<PreGameLoad.DataFragments>)(object)this.ListRequiredDataFragments());
			return onlineProfileUpdaterTransferData;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract List<PreGameLoad.DataFragments> ListRequiredDataFragments();

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x116EE20", Offset = "0x116D820", VA = "0x18116EE20")]
		public PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult ProcessRequiredData(PreGameLoad.OnlineProfileUpdaterTransferData data)
		{
			//Discarded unreachable code: IL_0072, IL_0078, IL_007e, IL_0084, IL_008a
			bool flag = default(bool);
			PreGameLoad.DataFragments.ProcessingResult processingResult = default(PreGameLoad.DataFragments.ProcessingResult);
			PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult processingResult3 = default(PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult);
			bool flag3 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (data == null)
				{
					break;
				}
				if (data.Data != null)
				{
					string name = data.Name;
					string uniqueName = UniqueName;
					if (name.Equals(uniqueName))
					{
						List<PreGameLoad.DataFragments> data2 = data.Data;
						if (flag)
						{
							if (processingResult == PreGameLoad.DataFragments.ProcessingResult.ReceivedDataOk)
							{
								continue;
							}
							PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult processingResult2 = data.WithProcessResult(PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.DataFragmentError);
						}
						if (processingResult3 == PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.NameMismatch)
						{
						}
						bool flag2 = processingResult3 == PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.NoDataFragments;
						if (flag3)
						{
						}
						if (!flag2)
						{
						}
					}
					PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult processingResult4 = data.WithProcessResult(PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.NameMismatch);
				}
				PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult processingResult5 = data.WithProcessResult(PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.NoDataFragments);
				break;
			}
			return PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.NullData;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract PreGameLoad.DataFragments.ImplProcessingResult ProcessRequiredDataFragments(List<PreGameLoad.DataFragments> dataFragments);

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x116ED30", Offset = "0x116D730", VA = "0x18116ED30")]
		public bool IsSupportedForThisClientContext(OnlineProfileUpdater.ClientContext clientContext)
		{
			//IL_0015: Expected I4, but got O
			Func<OnlineProfileUpdater.ClientContext, bool> func = ClientContextCondFunc;
			if (func == null)
			{
				return true;
			}
			return (byte)(int)func((T)clientContext) != 0;
		}
	}
}
