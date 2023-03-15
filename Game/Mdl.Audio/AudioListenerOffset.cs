using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Ftue.Cutscenes;
using Mdl.Ui;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AED")]
	public class AudioListenerOffset : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C8E")]
		[SerializeField]
		private float transitionDuration = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003C8F")]
		[SerializeField]
		private List<string> noOffsetMenus = (List<string>)(object)new List<T>
		{
			(T)"PhotoMenu",
			(T)"GiftMenu",
			(T)"DialogueMenu",
			(T)"InventoryMenu",
			(T)"PresentPopUp",
			(T)"WardrobeMenu",
			(T)"DecalMenu",
			(T)"CookingMenu",
			(T)"NewRecipePopup",
			(T)"CraftingMenu",
			(T)"RemiShopMenu",
			(T)"GardeningStallMenu",
			(T)"MoanaBoatPopup"
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003C90")]
		private Vector3 originalLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003C91")]
		private bool doTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003C92")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003C93")]
		private Vector3 startPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003C94")]
		private Vector3 endPos;

		[Cpp2IlInjected.Token(Token = "0x600323A")]
		[Cpp2IlInjected.Address(RVA = "0xA4F750", Offset = "0xA4E150", VA = "0x180A4F750")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0059
			//IL_0015: Expected native int or pointer, but got O
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)originalLocalPosition)->z = z;
			Cutscene.OnStartedPlaying += Cutscene_OnStartedPlaying;
			Cutscene.OnFinishedPlaying += Cutscene_OnFinishedPlaying;
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			BaseUiRoot.MenuChanged value = UiRoot_OnMenuChanged;
			_003CInstance_003Ek__BackingField.OnMenuChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600323B")]
		[Cpp2IlInjected.Address(RVA = "0xA4F500", Offset = "0xA4DF00", VA = "0x180A4F500")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_004f
			//IL_0031: Expected O, but got I4
			Cutscene.OnStartedPlaying -= Cutscene_OnStartedPlaying;
			Cutscene.OnFinishedPlaying -= Cutscene_OnFinishedPlaying;
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				BaseUiRoot _003CInstance_003Ek__BackingField2 = BaseUiRoot.Instance;
				BaseUiRoot.MenuChanged value = UiRoot_OnMenuChanged;
				_003CInstance_003Ek__BackingField2.OnMenuChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600323C")]
		[Cpp2IlInjected.Address(RVA = "0xA4FC70", Offset = "0xA4E670", VA = "0x180A4FC70")]
		private void Update()
		{
			//Discarded unreachable code: IL_005e
			//IL_005d: Expected I4, but got F4
			if (doTransition)
			{
				int num = 0;
				float num2 = (timer = Time.deltaTime);
				Transform transform = base.transform;
				float value = timer;
				float z = endPos.z;
				float z2 = startPos.z;
				float num3 = Mathf.Clamp01(Mathf.Clamp01(value));
				float num4 = transitionDuration;
				doTransition = (byte)(int)z != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600323D")]
		[Cpp2IlInjected.Address(RVA = "0xA4F920", Offset = "0xA4E320", VA = "0x180A4F920")]
		private unsafe void TransiteTo(Vector3 newPos)
		{
			//IL_0027: Expected native int or pointer, but got O
			//IL_0033: Expected native int or pointer, but got O
			Transform transform = base.transform;
			if (!doTransition)
			{
				if ((doTransition ? 1 : 0) <= (false ? 1 : 0))
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
					((Vector3*)(IntPtr)startPos)->z = z;
					((Vector3*)(IntPtr)endPos)->z = z;
					doTransition = true;
					timer = 0f;
				}
				return;
			}
			while ((doTransition ? 1 : 0) > (false ? 1 : 0))
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600323E")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4B0", Offset = "0xA4DEB0", VA = "0x180A4F4B0")]
		private void MoveTo(Vector3 newPos)
		{
			//Discarded unreachable code: IL_0016
			doTransition = false;
			Transform transform = base.transform;
			float z = newPos.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600323F")]
		[Cpp2IlInjected.Address(RVA = "0xA4F440", Offset = "0xA4DE40", VA = "0x180A4F440")]
		private void Cutscene_OnStartedPlaying(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_001a
			float z = Vector3.zero.z;
			doTransition = false;
			Transform transform = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003240")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3F0", Offset = "0xA4DDF0", VA = "0x180A4F3F0")]
		private void Cutscene_OnFinishedPlaying(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_001b
			float z = originalLocalPosition.z;
			doTransition = false;
			Transform transform = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003241")]
		[Cpp2IlInjected.Address(RVA = "0xA4FB30", Offset = "0xA4E530", VA = "0x180A4FB30")]
		private void UiRoot_OnMenuChanged(string menuName)
		{
			//Discarded unreachable code: IL_004b
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals0.menuName = menuName;
			string menuName2 = CS_0024_003C_003E8__locals0.menuName;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				List<string> cpp2il__autoParamName__idx_ = noOffsetMenus;
				Func<string, bool> cpp2il__autoParamName__idx_2 = (Func<string, bool>)(object)(Func<T, TResult>)((string x) => CS_0024_003C_003E8__locals0.menuName.StartsWith(x));
				if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<string>((Func<, >)(object)cpp2il__autoParamName__idx_2))
				{
					Vector3 zero = Vector3.zero;
				}
			}
			float z = originalLocalPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003242")]
		[Cpp2IlInjected.Address(RVA = "0xA4FDA0", Offset = "0xA4E7A0", VA = "0x180A4FDA0")]
		public AudioListenerOffset()
		{
		}//Discarded unreachable code: IL_00ae

	}
}
