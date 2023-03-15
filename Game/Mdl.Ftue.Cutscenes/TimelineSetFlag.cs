using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005DD")]
	public class TimelineSetFlag : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023D1")]
		[SerializeField]
		[ItemID]
		private int flag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023D2")]
		public bool triggerRequired = true;

		[Cpp2IlInjected.Token(Token = "0x6001A0E")]
		[Cpp2IlInjected.Address(RVA = "0x13D0690", Offset = "0x13CF090", VA = "0x1813D0690")]
		public void SetFlag()
		{
			//Discarded unreachable code: IL_000c, IL_0029
			//IL_0026: Expected O, but got I4
			Dictionary<int, bool> dictionary = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0F")]
		[Cpp2IlInjected.Address(RVA = "0x13D0570", Offset = "0x13CEF70", VA = "0x1813D0570")]
		public bool IsFlagSet()
		{
			//Discarded unreachable code: IL_0023
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			long num = Convert.ToInt64((uint)flag);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A10")]
		[Cpp2IlInjected.Address(RVA = "0x13D0300", Offset = "0x13CED00", VA = "0x1813D0300", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_003a, IL_005b
			//IL_0058: Expected O, but got I4
			if (triggerRequired)
			{
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				long num = Convert.ToInt64((uint)this.flag);
				bool flag = default(bool);
				if (!flag)
				{
					Dictionary<int, bool> dictionary = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A11")]
		[Cpp2IlInjected.Address(RVA = "0x13CD770", Offset = "0x13CC170", VA = "0x1813CD770")]
		public TimelineSetFlag()
		{
		}
	}
}
