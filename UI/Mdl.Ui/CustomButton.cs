using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[ExecuteInEditMode]
	public class CustomButton : TemplateButton, IHasDynamicView
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		[HideInInspector]
		[SerializeField]
		protected bool _isSaved;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		[SerializeField]
		public CustomButtonTemplate Template = new CustomButtonTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		[SerializeField]
		private ButtonViewDefault _view;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AssetReference[] Assets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		[HideInInspector]
		public AssetAddress[] AssetAddresses;

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public CustomButtonModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public ButtonViewDefault View
		{
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x111CFB0", Offset = "0x111B9B0", VA = "0x18111CFB0")]
			get
			{
				//Discarded unreachable code: IL_00c6
				//IL_0010: Expected O, but got I4
				//IL_001f: Expected O, but got I4
				//IL_006a: Expected O, but got I4
				//IL_006a: Expected O, but got I4
				//IL_009f: Expected O, but got I4
				//IL_00b8: Expected O, but got I4
				RectTransform content = _content;
				int num = 0;
				if (content != (UnityEngine.Object)num)
				{
					int num2 = 0;
					if (content == (UnityEngine.Object)num2)
					{
						int num3 = 0;
						int num4 = 0;
						if (Application.isPlaying)
						{
							int num5 = 0;
							RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
							Type typeFromHandle = typeof(ButtonViewDefault);
							RectTransform content2 = _content;
							GameObject gameObject = miscRecycleBin.FindReusableOrNew(typeFromHandle, content2);
						}
						int num6 = 0;
						if ((UnityEngine.Object)num3 != (UnityEngine.Object)num6)
						{
							Transform transform = default(Transform);
							if ((object)transform != null)
							{
							}
							int num7 = 0;
							Vector2 zero = Vector2.zero;
							float z = Vector3.one.z;
						}
						if (num3 != 0)
						{
						}
						ButtonViewDefault view = default(ButtonViewDefault);
						_view = view;
					}
					int num8 = 0;
					if (content != (UnityEngine.Object)num8 && _isSaved)
					{
						Template.Load((ButtonViewDefault)num8);
						_isSaved = false;
					}
				}
				return _view;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x111C9A0", Offset = "0x111B3A0", VA = "0x18111C9A0", Slot = "12")]
		protected override void OnEnable()
		{
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			RectTransform content = _content;
			int num = 0;
			if (content != (UnityEngine.Object)num)
			{
				ButtonViewDefault view = _view;
				int num2 = 0;
				if (view == (UnityEngine.Object)num2)
				{
					ButtonViewDefault buttonViewDefault = (_view = View);
				}
			}
			Model?.Init(this);
			RefreshDisplay();
			base.OnEnable();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x111C960", Offset = "0x111B360", VA = "0x18111C960", Slot = "13")]
		protected override void OnDisable()
		{
			ReleaseView();
			Release();
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x111CF00", Offset = "0x111B900", VA = "0x18111CF00", Slot = "16")]
		internal override void Release()
		{
			Model?.Release();
			base.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x111CAB0", Offset = "0x111B4B0", VA = "0x18111CAB0", Slot = "19")]
		public virtual void RefreshDisplay()
		{
			Model?.UpdateDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x111C7C0", Offset = "0x111B1C0", VA = "0x18111C7C0", Slot = "17")]
		public GameObject GetView()
		{
			//IL_0044: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (Application.isPlaying)
			{
				int num3 = 0;
				RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
				Type typeFromHandle = typeof(ButtonViewDefault);
				RectTransform content = _content;
				GameObject gameObject = miscRecycleBin.FindReusableOrNew(typeFromHandle, content);
			}
			int num4 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num4)
			{
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
				}
				int num5 = 0;
				Vector2 zero = Vector2.zero;
				float z = Vector3.one.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x111CAD0", Offset = "0x111B4D0", VA = "0x18111CAD0", Slot = "18")]
		public unsafe void ReleaseView()
		{
			//Discarded unreachable code: IL_00a2
			//IL_004c: Expected O, but got I4
			//IL_005a: Expected F4, but got I4
			//IL_0055: Expected native int or pointer, but got O
			//IL_006f: Expected F4, but got I4
			//IL_006a: Expected native int or pointer, but got O
			//IL_00a1: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				ButtonViewDefault view = default(ButtonViewDefault);
				Template.Save(view);
				int num = 0;
				_isSaved = true;
				bool isPlaying = Application.isPlaying;
				int num2 = 0;
				if (isPlaying)
				{
					int num3 = 0;
					num += 32;
					((int*)num)->m_value = num2;
					Color white = Color.white;
					int num4 = 0;
					Image image = default(Image);
					image.sprite = (Sprite)num4;
					((Color*)(IntPtr)((UnityEngine.UI.Graphic)image).m_Color)->r = num2;
					Color white2 = Color.white;
					Image image2 = default(Image);
					((Color*)(IntPtr)((UnityEngine.UI.Graphic)image2).m_Color)->b = num2;
					int num5 = 0;
					bool skipLayoutUpdate = ((UnityEngine.UI.Graphic)image2).m_SkipLayoutUpdate;
					int num6 = 0;
					Color white3 = Color.white;
					int num7 = 0;
					GameObject trash = default(GameObject);
					UiRoot.Instance._miscRecycleBin.SendToBin(trash);
				}
				_view = (ButtonViewDefault)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x111CF40", Offset = "0x111B940", VA = "0x18111CF40")]
		public CustomButton()
		{
		}
	}
}
