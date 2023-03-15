using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public class AddDevInboxMessageOnEveryContinueGame : OnlineProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		protected override int GetRequiredFragmentCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "5")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x11654E0", Offset = "0x1163EE0", VA = "0x1811654E0")]
		public AddDevInboxMessageOnEveryContinueGame()
		{
			base.Name = "AddDevInboxMessageOnEveryContinueGame";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1164FD0", Offset = "0x11639D0", VA = "0x181164FD0", Slot = "4")]
		protected override List<PreGameLoad.DataFragments> ListRequiredDataFragments()
		{
			//Discarded unreachable code: IL_0029
			List<PreGameLoad.DataFragments> list = (List<PreGameLoad.DataFragments>)(object)new List<T>();
			PreGameLoad.DataFragments dataFragments = new PreGameLoad.DataFragments();
			dataFragments.jsonSelectToken = (string)(object)(dataFragments.FileInfo = OnlineDataFileInfo.ClientProfileFileInfo);
			((List<T>)(object)list).Add((T)dataFragments);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1165120", Offset = "0x1163B20", VA = "0x181165120", Slot = "6")]
		protected override PreGameLoad.DataFragments.ImplProcessingResult ProcessRequiredDataFragments(List<PreGameLoad.DataFragments> dataFragments)
		{
			//Discarded unreachable code: IL_009e, IL_00a4, IL_00aa
			string json = default(string);
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			uint num6 = default(uint);
			ulong num7 = default(ulong);
			while (true)
			{
				int num = 0;
				PreGameLoad.DataFragments dataFragments2 = Enumerable.First<PreGameLoad.DataFragments>((IEnumerable<>)dataFragments);
				if (dataFragments2 == null)
				{
					break;
				}
				JToken _003CCachedJToken_003Ek__BackingField = dataFragments2.CachedJToken;
				if (_003CCachedJToken_003Ek__BackingField == null)
				{
					break;
				}
				int num2 = 0;
				JToken jToken;
				if (_003CCachedJToken_003Ek__BackingField != null)
				{
					int num3 = 0;
					DateTime utcNow = DateTime.UtcNow;
					int num4 = 0;
					jToken = JToken.Parse(json);
					int num5 = 0;
					if (enumerator != null)
					{
						if (num < (int)num6)
						{
							num += num;
							if (num == (int)num6)
							{
								goto IL_0063;
							}
							num++;
						}
						if (jToken["FriendlyName"] == null)
						{
							continue;
						}
						goto IL_0063;
					}
					goto IL_006a;
				}
				goto IL_008f;
				IL_0063:
				jToken = (object)jToken + (object)jToken;
				goto IL_006a;
				IL_006a:
				if (enumerator != null)
				{
				}
				if (num7 == 0)
				{
				}
				JToken _003CCachedJToken_003Ek__BackingField2 = dataFragments2.CachedJToken;
				dataFragments2.FromJToken(_003CCachedJToken_003Ek__BackingField2);
				PreGameLoad.DataFragments.ImplProcessingResult implProcessingResult = dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.FixToApply);
				goto IL_008f;
				IL_008f:
				PreGameLoad.DataFragments.ImplProcessingResult implProcessingResult2 = dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.DataError);
				break;
			}
			throw new NullReferenceException();
		}
	}
}
