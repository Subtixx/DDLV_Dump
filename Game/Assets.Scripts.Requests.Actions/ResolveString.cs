using Cpp2IlInjected;
using Localization.Formatter.Resolvers;
using Mdl;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class ResolveString : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public BBParameter<string> locId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		[BlackboardOnly]
		public BBParameter<string> result;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0xCC1B90", Offset = "0xCC0590", VA = "0x180CC1B90", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0018
				string value = (string)((BBParameter<T>)(object)locId).value;
				return "Resolve string " + value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xCC19B0", Offset = "0xCC03B0", VA = "0x180CC19B0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0056
			//IL_004e: Expected O, but got I4
			BBParameter<string> bBParameter = result;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				LocalizationManager localizationManager = _003CInstance_003Ek__BackingField._localizationManager;
				if ((object)localizationManager != null && localizationManager.Localizator != null)
				{
					string value = (string)((BBParameter<T>)(object)locId).value;
					CharacterResolver characterResolver = new CharacterResolver(base.CharacterComponent.MetaCharacter);
				}
			}
			int num = 0;
			((BBParameter<T>)(object)bBParameter).value = (T)num;
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public ResolveString()
		{
		}
	}
}
