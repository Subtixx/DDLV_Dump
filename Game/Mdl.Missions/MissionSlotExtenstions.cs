using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Mdl.Systems;
using Meta.Missions;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200029F")]
	public static class MissionSlotExtenstions
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0xEF9BF0", Offset = "0xEF85F0", VA = "0x180EF9BF0")]
		public static string ResolveString(this MissionSlot missionSlot, string locId, [Optional] IResolver extraResolver)
		{
			//Discarded unreachable code: IL_004b
			if ((object)typeof(SystemRoot).TypeHandle == null)
			{
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				List<IResolver> list = (List<IResolver>)(object)new List<T>();
				((List<T>)(object)list).Add((T)extraResolver);
				MissionSlotStringResolver item = missionSlot.StringResolver(_003CLocalizator_003Ek__BackingField);
				((List<T>)(object)list).Add((T)item);
				MultiResolver multiResolver = new MultiResolver((IReadOnlyCollection<>)list);
				string text = default(string);
				return missionSlot.ResolveXml(text);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0xEF9B00", Offset = "0xEF8500", VA = "0x180EF9B00")]
		public static string ResolveLockedConditionString(this MissionSlot missionSlot)
		{
			//Discarded unreachable code: IL_004f
			//IL_0025: Expected O, but got I4
			MissionItemData data = missionSlot.Data;
			LockedInfo lockedInfo = data.unlockConditions_.GetLockedInfo(data);
			if (lockedInfo == null)
			{
				int num = 0;
				LockedInfo lockedInfo2 = LockedInfo.New("menu.Locked_KeepPlaying_Text", (Dictionary<, >)num);
			}
			Dictionary<string, object> _003CArgs_003Ek__BackingField = lockedInfo.Args;
			if (_003CArgs_003Ek__BackingField == null)
			{
			}
			DictionaryResolver extraResolver = new DictionaryResolver((IReadOnlyDictionary<, >)_003CArgs_003Ek__BackingField);
			string _003CStrId_003Ek__BackingField = lockedInfo.StrId;
			return missionSlot.ResolveString(_003CStrId_003Ek__BackingField, extraResolver);
		}
	}
}
