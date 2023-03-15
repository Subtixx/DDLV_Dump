using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000314")]
	public class CollectionTooltipCritterModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public CritterItemData CritterItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013DB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCritterItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCritterItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013DD")]
		[Cpp2IlInjected.Address(RVA = "0x1149590", Offset = "0x1147F90", VA = "0x181149590", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_00d3, IL_00ed, IL_00f3, IL_0111, IL_0129, IL_012f, IL_016f
			//IL_00a2: Expected I4, but got I8
			//IL_00a9: Expected I4, but got I8
			//IL_014c: Expected O, but got I4
			if ((long)CritterItemData == 0)
			{
				IItemData itemData = base.ItemData;
				CritterItemData critterItemData = default(CritterItemData);
				CritterItemData = critterItemData;
			}
			if ((object)viewBase == null)
			{
			}
			int num = 0;
			List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)new List<T>());
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			DayOfWeek dayOfWeek = default(DayOfWeek);
			int num2 = (int)dayOfWeek;
			CritterItemData.Types.DailyScheduleData dailyScheduleData = default(CritterItemData.Types.DailyScheduleData);
			RepeatedField<CritterItemData.Types.DailyScheduleData.Types.Data> schedule_ = dailyScheduleData.schedule_;
			if (schedule_ != null && ((RepeatedField<T>)(object)schedule_).Count > 0)
			{
				int index = 0;
				CritterItemData.Types.DailyScheduleData.Types.Data data = (CritterItemData.Types.DailyScheduleData.Types.Data)((RepeatedField<T>)(object)schedule_)[index];
				int start_ = data.start_;
				if (start_ != 0 || data.end_ == 24)
				{
				}
				int end_ = data.end_;
				ulong num3 = num3 + num3;
				ulong num4 = num4 + num4;
				start_ = (int)((long)start_ - (long)num4);
				end_ = (int)((long)end_ - (long)num3);
				uint num5 = default(uint);
				if (start_ == 24 || start_ < (int)num5)
				{
				}
				string text = "menu.common_time_" + "am";
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			int num6 = 0;
			string text2 = LocalizationManager.FromStringID("collection.label_not_here_today", (IResolver)num6);
			int num7 = 0;
			Transform transform = viewBase.transform;
			Transform transform2 = viewBase.transform.transform;
			Transform transform3 = viewBase.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60013DE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipCritterModel()
		{
		}
	}
}
