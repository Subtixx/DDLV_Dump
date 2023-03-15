using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Assets.Scripts.Requests.Actions;
using Cpp2IlInjected;
using Definitions.Items;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[Description("Fade out and in inside a dialogue\nDuration are in seconds, eg: 1.5\nFlags are changed during fade (optional)")]
	[Category("Mdl")]
	public class FadeOutIn : MdlActionTaskAsync, IDataValidation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public BBParameter<float> fadeOutDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public BBParameter<float> fadePauseDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public BBParameter<float> fadeInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public BBParameter<ItemFlagFiltering> flagToEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public List<SetDialogueFlags.Config> flags;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x136D630", Offset = "0x136C030", VA = "0x18136D630", Slot = "9")]
			get
			{
				string text = SetDialogueFlags.Config.GetInfo((List<>)(object)flags);
				string prefix = "FadeOutIn\n\n" + text;
				return AddErrors(prefix);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x136D490", Offset = "0x136BE90", VA = "0x18136D490")]
		private bool HasFlagToEnable()
		{
			BBParameter<ItemFlagFiltering> bBParameter = flagToEnable;
			if (bBParameter == null)
			{
				int num = 0;
			}
			ItemFlagFiltering value = (ItemFlagFiltering)((BBParameter<T>)(object)bBParameter).value;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x136D390", Offset = "0x136BD90", VA = "0x18136D390", Slot = "18")]
		[AsyncStateMachine(typeof(_003CDoActionAsync_003Ed__8))]
		protected override System.Threading.Tasks.Task DoActionAsync()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x136CFE0", Offset = "0x136B9E0", VA = "0x18136CFE0", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			BBParameter<ItemFlagFiltering> bBParameter = flagToEnable;
			if (bBParameter != null)
			{
				ItemFlagFiltering value = (ItemFlagFiltering)((BBParameter<T>)(object)bBParameter).value;
				bool flag = default(bool);
				if (flag)
				{
					context.AddInvalidMemberError("Deprecated, please use 'Flags'", "flagToEnable");
				}
			}
			List<SetDialogueFlags.Config> list = flags;
			if (list == null)
			{
				return;
			}
			Func<SetDialogueFlags.Config, bool> cpp2il__autoParamName__idx_ = default(Func<SetDialogueFlags.Config, bool>);
			if (_003C_003Ec._003C_003E9__9_0 == null)
			{
				cpp2il__autoParamName__idx_ = (Func<SetDialogueFlags.Config, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SetDialogueFlags.Config x) => (byte)(int)typeof(Item).TypeHandle != 0));
			}
			if (!((IEnumerable<>)list).Any<SetDialogueFlags.Config>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				List<SetDialogueFlags.Config> list2 = flags;
				Func<SetDialogueFlags.Config, Item> func = default(Func<SetDialogueFlags.Config, Item>);
				if (_003C_003Ec._003C_003E9__9_1 == null)
				{
					func = (Func<SetDialogueFlags.Config, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SetDialogueFlags.Config x)
					{
						ItemFlagFiltering flag2 = x.flag;
						throw new NullReferenceException();
					});
				}
				int num = Enumerable.Count<Item>(Enumerable.Distinct<Item>(Enumerable.Select<SetDialogueFlags.Config, Item>((IEnumerable<>)list2, (Func<, >)(object)func)));
				List<SetDialogueFlags.Config> list3 = flags;
				context.AddInvalidMemberError("Contain duplicate items", "flags");
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x136D530", Offset = "0x136BF30", VA = "0x18136D530")]
		public FadeOutIn()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			fadeOutDuration = (BBParameter<float>)(object)bBParameter;
			BBParameter<> bBParameter2 = default(BBParameter<>);
			fadePauseDuration = (BBParameter<float>)(object)bBParameter2;
			BBParameter<> bBParameter3 = default(BBParameter<>);
			fadeInDuration = (BBParameter<float>)(object)bBParameter3;
			flags = (List<SetDialogueFlags.Config>)(object)new List<T>();
			((MdlActionTask)this)._002Ector();
		}
	}
}
