using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006F9")]
	[CreateAssetMenu]
	public class WatchViewConfig : PointOfInterestActionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40028DA")]
		[Tooltip("If running, the character will start walking at this distance from their destination")]
		public float slowDownDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40028DB")]
		[Tooltip("The vantage point types that are allowed")]
		public List<VantagePointType> validTypes = (List<VantagePointType>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000471")]
		public override Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x6001EFF")]
			[Cpp2IlInjected.Address(RVA = "0xD4DED0", Offset = "0xD4C8D0", VA = "0x180D4DED0", Slot = "4")]
			get
			{
				return typeof(VantagePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F00")]
		[Cpp2IlInjected.Address(RVA = "0xD4DE50", Offset = "0xD4C850", VA = "0x180D4DE50")]
		public WatchViewConfig()
		{
		}
	}
}
