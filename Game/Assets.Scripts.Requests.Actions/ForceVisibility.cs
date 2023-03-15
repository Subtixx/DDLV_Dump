using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[Icon("Eye", false, "")]
	[Description("Force BlinkMode to a specified visibility")]
	[Category("Mdl")]
	public class ForceVisibility : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public BBParameter<Item> characterItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public BBParameter<bool> forceVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public BBParameter<bool> isVisible;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		private string characterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x14643C0", Offset = "0x1462DC0", VA = "0x1814643C0")]
			get
			{
				//Discarded unreachable code: IL_0016
				BBParameter<Item> bBParameter = characterItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item value = (Item)((BBParameter<T>)(object)bBParameter).value;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		private string isVisibleStr
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x1464600", Offset = "0x1463000", VA = "0x181464600")]
			get
			{
				//Discarded unreachable code: IL_001f
				//IL_000c: Expected I4, but got O
				bool flag = (byte)(int)((BBParameter<T>)(object)isVisible).value != 0;
				string result = "OFF";
				if (flag)
				{
					result = "ON";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x14644D0", Offset = "0x1462ED0", VA = "0x1814644D0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0055
				//IL_0021: Expected I4, but got O
				if (((BBParameter<T>)(object)forceVisibility).value != null)
				{
					string text = characterName;
					bool flag = (byte)(int)((BBParameter<T>)(object)isVisible).value != 0;
					string text2 = " visibility to ";
					if (flag)
					{
						text2 = "ON";
					}
					return "Force " + text + " visibility to " + text2;
				}
				return characterName + " visibility is not forced anymore";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x14641C0", Offset = "0x1462BC0", VA = "0x1814641C0", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0054: Expected I4, but got O
			((object)this)._002Ector();
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num = 0;
			if ((object)system != null)
			{
				Item value = (Item)((BBParameter<T>)(object)characterItem).value;
			}
			int num2 = 0;
			if (!((UnityEngine.Object)num != (UnityEngine.Object)num2) || ((BBParameter<T>)(object)forceVisibility).value == null)
			{
				EndAction(success: true);
				return;
			}
			bool flag = (byte)(int)((BBParameter<T>)(object)isVisible).value != 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public ForceVisibility()
		{
		}
	}
}
