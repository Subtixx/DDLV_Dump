using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Audio;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000534")]
	public class WeatherVolume : WeatherInfluencer
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000535")]
		public class WeatherOverrideInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400205B")]
			public WeatherTimeline Timeline;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400205C")]
			[SerializeField]
			[ItemID]
			private int Condition;

			[Cpp2IlInjected.Token(Token = "0x170002F4")]
			public Item ConditionItem
			{
				[Cpp2IlInjected.Token(Token = "0x60016D4")]
				[Cpp2IlInjected.Address(RVA = "0xF9AD00", Offset = "0xF99700", VA = "0x180F9AD00")]
				get
				{
					long num = Convert.ToInt64((uint)Condition);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60016D5")]
			[Cpp2IlInjected.Address(RVA = "0xF9AAC0", Offset = "0xF994C0", VA = "0x180F9AAC0")]
			public bool EvaluateCondition()
			{
				//IL_0010: Expected O, but got I4
				WeatherTimeline timeline = Timeline;
				int num = 0;
				bool flag = timeline != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				long num2 = Convert.ToInt64((uint)Condition);
				int num3 = 0;
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Client client = _003CInstance_003Ek__BackingField.Client;
					if ((object)client != null && client.MetaClient == null)
					{
					}
				}
				SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField2 != null)
				{
					Client client2 = _003CInstance_003Ek__BackingField2.Client;
					if ((object)client2 != null && client2.MetaClient == null)
					{
					}
				}
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60016D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public WeatherOverrideInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002054")]
		public WeatherTimeline timeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002055")]
		public List<WeatherOverrideInfo> weatherConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002056")]
		public float transitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002057")]
		private float transitionStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002058")]
		private WeatherTimeline ActiveTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002059")]
		private WeatherTimeline PreviousTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400205A")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x60016CA")]
		[Cpp2IlInjected.Address(RVA = "0x840470", Offset = "0x83EE70", VA = "0x180840470", Slot = "4")]
		public override void AddInfluences(Vector3 position, WeatherInfluences influences)
		{
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0050: Expected O, but got I8
			//IL_007c: Expected O, but got I4
			WeatherTimeline activeTimeline = ActiveTimeline;
			int num = 0;
			if (!(activeTimeline != (UnityEngine.Object)num))
			{
				return;
			}
			WeatherTimeline previousTimeline = PreviousTimeline;
			int num2 = 0;
			if (previousTimeline != (UnityEngine.Object)num2 && !(transitionDuration <= float.Epsilon))
			{
				int num3 = 0;
				float time = Time.time;
				if (transitionStartTime > time)
				{
					int num4 = 0;
					float time2 = Time.time;
					influences.Add((WeatherTimeline)num, 1f);
					throw new NullReferenceException();
				}
				PreviousTimeline = (WeatherTimeline)0;
			}
			WeatherTimeline activeTimeline2 = ActiveTimeline;
			influences.Add(activeTimeline2, 1f);
		}

		[Cpp2IlInjected.Token(Token = "0x60016CB")]
		[Cpp2IlInjected.Address(RVA = "0x8405D0", Offset = "0x83EFD0", VA = "0x1808405D0", Slot = "5")]
		public override void AddTimelines(List<WeatherTimeline> timelines)
		{
			//Discarded unreachable code: IL_0022
			//IL_0010: Expected O, but got I4
			WeatherTimeline activeTimeline = ActiveTimeline;
			int num = 0;
			if (activeTimeline != (UnityEngine.Object)num)
			{
				WeatherTimeline activeTimeline2 = ActiveTimeline;
				((List<T>)(object)timelines).Add((T)activeTimeline2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016CC")]
		[Cpp2IlInjected.Address(RVA = "0x840BC0", Offset = "0x83F5C0", VA = "0x180840BC0")]
		private void OnEnable()
		{
			SelectActiveTimeline();
			CreateEventHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x60016CD")]
		[Cpp2IlInjected.Address(RVA = "0x840B70", Offset = "0x83F570", VA = "0x180840B70")]
		private void OnDisable()
		{
			//IL_0009: Expected O, but got I8
			//IL_0023: Expected O, but got I8
			ActiveTimeline = (WeatherTimeline)0;
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016CE")]
		[Cpp2IlInjected.Address(RVA = "0x840BE0", Offset = "0x83F5E0", VA = "0x180840BE0")]
		private void SelectActiveTimeline()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016CF")]
		[Cpp2IlInjected.Address(RVA = "0x840970", Offset = "0x83F370", VA = "0x180840970")]
		private WeatherTimeline EvaluateActiveWeather()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016D0")]
		[Cpp2IlInjected.Address(RVA = "0x840670", Offset = "0x83F070", VA = "0x180840670")]
		private void CreateEventHandler()
		{
			//Discarded unreachable code: IL_008e
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			List<WeatherOverrideInfo> list = weatherConditions;
			if (list == null || !Enumerable.Any<WeatherOverrideInfo>((IEnumerable<>)list))
			{
				return;
			}
			List<WeatherOverrideInfo> list2 = weatherConditions;
			Func<WeatherOverrideInfo, Item> func = default(Func<WeatherOverrideInfo, Item>);
			if (_003C_003Ec._003C_003E9__14_0 == null)
			{
				func = (Func<WeatherOverrideInfo, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(WeatherOverrideInfo x)
				{
					//Discarded unreachable code: IL_000d
					int condition = x.Condition;
					return (Item)typeof(Item).TypeHandle;
				});
			}
			ConditionListener mask = ConditionItemData.GetMask(Enumerable.Select<WeatherOverrideInfo, Item>((IEnumerable<>)list2, (Func<, >)(object)func));
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
		}

		[Cpp2IlInjected.Token(Token = "0x60016D1")]
		[Cpp2IlInjected.Address(RVA = "0x840940", Offset = "0x83F340", VA = "0x180840940")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016D2")]
		[Cpp2IlInjected.Address(RVA = "0x840A80", Offset = "0x83F480", VA = "0x180840A80")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0020
			SelectActiveTimeline();
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			WeatherTimeline activeTimeline = ActiveTimeline;
			system.UpdateWeather(activeTimeline);
		}

		[Cpp2IlInjected.Token(Token = "0x60016D3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WeatherVolume()
		{
		}
	}
}
