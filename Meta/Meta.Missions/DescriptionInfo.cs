using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200105F")]
	public class DescriptionInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17001704")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60084C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60084C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CDescription_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001705")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400437C")]
		public bool Completed
		{
			[Cpp2IlInjected.Token(Token = "0x60084C5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084C6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001706")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x400437D")]
		public bool HasObjective
		{
			[Cpp2IlInjected.Token(Token = "0x60084C7")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084C8")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001707")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400437E")]
		public int Indentation
		{
			[Cpp2IlInjected.Token(Token = "0x60084C9")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084CA")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001708")]
		public MissionObjective Objective
		{
			[Cpp2IlInjected.Token(Token = "0x60084CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CObjective_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60084CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CObjective_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001709")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4004380")]
		public float? CurrentAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60084CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084CE")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700170A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4004381")]
		public float? TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60084CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084D0")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700170B")]
		public bool HasProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60084D1")]
			[Cpp2IlInjected.Address(RVA = "0x1A29BA0", Offset = "0x1A285A0", VA = "0x181A29BA0")]
			get
			{
				if ((object)CurrentAmount != null && (object)TargetAmount != null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60084D2")]
		[Cpp2IlInjected.Address(RVA = "0x1A299D0", Offset = "0x1A283D0", VA = "0x181A299D0")]
		public DescriptionInfo(string description, bool completed, int indentation, [Optional] MissionObjective objective, [Optional] float? currentAmount, [Optional] float? targetAmount)
		{
			//IL_0022: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			Description = description;
			Completed = completed;
			Indentation = indentation;
			Objective = (MissionObjective)0;
			int num = 0;
			bool flag = default(bool);
			HasObjective = flag;
			if (flag)
			{
			}
			bool flag2 = num == 0;
			if (num != (flag2 ? 1 : 0))
			{
				int num2 = 0;
			}
			CurrentAmount = (float?)(object)num;
			if (num != 0)
			{
			}
			bool flag3 = num == 0;
			if (num != (flag3 ? 1 : 0))
			{
			}
			TargetAmount = (float?)(object)num;
			CurrentAmount = (float?)(object)0;
			TargetAmount = (float?)(object)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60084D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A29850", Offset = "0x1A28250", VA = "0x181A29850")]
		public void SetObjective(MissionObjective obj)
		{
			//IL_004b: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			Objective = obj;
			bool flag = obj != null;
			int num = 0;
			HasObjective = flag;
			if (obj != null)
			{
				MissionObjectiveData _003CData_003Ek__BackingField = obj.Data;
				if (_003CData_003Ek__BackingField != null)
				{
					bool hideProgressionCount_ = _003CData_003Ek__BackingField.hideProgressionCount_;
				}
				bool flag2 = num == 0;
				if (num != (flag2 ? 1 : 0))
				{
					int num2 = 0;
					float currentAmount = obj.CurrentAmount;
				}
			}
			CurrentAmount = (float?)(object)num;
			if (obj != null)
			{
				MissionObjectiveData _003CData_003Ek__BackingField2 = obj.Data;
				if (_003CData_003Ek__BackingField2 != null)
				{
					bool hideProgressionCount_2 = _003CData_003Ek__BackingField2.hideProgressionCount_;
				}
				bool flag3 = num == 0;
				if (num != (flag3 ? 1 : 0))
				{
					TargetAmount = (float?)(object)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60084D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A299C0", Offset = "0x1A283C0", VA = "0x181A299C0")]
		public void SetObjective()
		{
			HasObjective = true;
		}
	}
}
