using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.ImageRendering;
using Meta.Customization;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[RequireComponent(typeof(RawImage))]
	public class DesignIcon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public Color startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public Color loadedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private RenderTexture texture;

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public RawImage RawImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x12B8690", Offset = "0x12B7090", VA = "0x1812B8690")]
			get
			{
				return GetComponent<RawImage>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public Design Design
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDesign_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CDesign_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x12B8370", Offset = "0x12B6D70", VA = "0x1812B8370")]
		private void Awake()
		{
			//Discarded unreachable code: IL_004c
			int num = 0;
			RenderTexture renderTexture = default(RenderTexture);
			renderTexture.name = "Design icon render texture";
			renderTexture.antiAliasing = 8;
			this.texture = renderTexture;
			RawImage component = GetComponent<RawImage>();
			Color color2 = (component.color = startColor);
			RawImage component2 = GetComponent<RawImage>();
			RenderTexture renderTexture2 = (RenderTexture)(component2.texture = this.texture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x12B8610", Offset = "0x12B7010", VA = "0x1812B8610")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001f
			//IL_0010: Expected O, but got I4
			RenderTexture renderTexture = texture;
			int num = 0;
			if (renderTexture != (Object)num)
			{
				texture.Release();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x12B84C0", Offset = "0x12B6EC0", VA = "0x1812B84C0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__11))]
		public Task Init(Design design, ClothingDesignsRenderer renderer)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x882130", Offset = "0x880B30", VA = "0x180882130")]
		public DesignIcon()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
