using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000847")]
	public class HighlightHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030C1")]
		[SerializeField]
		protected GameObject FullBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030C2")]
		[SerializeField]
		protected Transform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030C3")]
		[SerializeField]
		protected CustomButton CustomButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030C4")]
		[SerializeField]
		protected GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030C5")]
		protected float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40030C6")]
		protected float _oX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40030C7")]
		private bool _init;

		[Cpp2IlInjected.Token(Token = "0x600348F")]
		[Cpp2IlInjected.Address(RVA = "0xAE8ED0", Offset = "0xAE78D0", VA = "0x180AE8ED0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_003b
			//IL_0019: Expected O, but got I4
			if (!_init)
			{
				Transform animatedContent = AnimatedContent;
				int num = 0;
				if (animatedContent != (Object)num)
				{
					Transform animatedContent2 = AnimatedContent;
					_init = true;
					Transform animatedContent3 = AnimatedContent;
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003490")]
		[Cpp2IlInjected.Address(RVA = "0xAE8AB0", Offset = "0xAE74B0", VA = "0x180AE8AB0", Slot = "4")]
		public virtual void AddHighlightBaseItem()
		{
			//Discarded unreachable code: IL_006f
			//IL_0010: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(AnimatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (Object)num4)
			{
				Decoration.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003491")]
		[Cpp2IlInjected.Address(RVA = "0xAE9110", Offset = "0xAE7B10", VA = "0x180AE9110", Slot = "5")]
		public virtual void RemoveHighlightBaseItem()
		{
			//Discarded unreachable code: IL_009e
			//IL_0010: Expected O, but got I4
			//IL_0048: Expected F4, but got I4
			//IL_0063: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				Transform animatedContent3 = AnimatedContent;
				int num4 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent3, oY, (float)num4, (byte)num3 != 0)).Play();
			}
			GameObject decoration = Decoration;
			int num5 = 0;
			if (decoration != (Object)num5)
			{
				GameObject decoration2 = Decoration;
				int active = 0;
				decoration2.SetActive((byte)active != 0);
			}
			GameObject decoration3 = Decoration;
			int num6 = 0;
			if (decoration3 != (Object)num6)
			{
				Decoration.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003492")]
		[Cpp2IlInjected.Address(RVA = "0xAE8BF0", Offset = "0xAE75F0", VA = "0x180AE8BF0", Slot = "6")]
		public virtual void AddHighlightHideBgCustomButton()
		{
			//Discarded unreachable code: IL_0070
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			CustomButton customButton = CustomButton;
			int num = 0;
			if (!(customButton != (Object)num))
			{
				return;
			}
			ButtonViewDefault view = CustomButton.View;
			int num2 = 0;
			if (view != (Object)num2)
			{
				ImageHelper background = CustomButton.View.Background;
				int num3 = 0;
				if (background != (Object)num3)
				{
					GameObject gameObject = CustomButton.View.Background.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003493")]
		[Cpp2IlInjected.Address(RVA = "0xAE9280", Offset = "0xAE7C80", VA = "0x180AE9280", Slot = "7")]
		public virtual void RemoveHighlightHideBgCustomButton()
		{
			//Discarded unreachable code: IL_0068
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			CustomButton customButton = CustomButton;
			int num = 0;
			if (!(customButton != (Object)num))
			{
				return;
			}
			ButtonViewDefault view = CustomButton.View;
			int num2 = 0;
			if (view != (Object)num2)
			{
				ImageHelper background = CustomButton.View.Background;
				int num3 = 0;
				if (background != (Object)num3)
				{
					CustomButton.View.Background.gameObject.SetActive(value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003494")]
		[Cpp2IlInjected.Address(RVA = "0xAE8D30", Offset = "0xAE7730", VA = "0x180AE8D30", Slot = "8")]
		public virtual void AddHighlightSideButton()
		{
			//Discarded unreachable code: IL_0085
			//IL_0010: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				Transform animatedContent3 = AnimatedContent;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.Play();
			}
			GameObject fullBg = FullBg;
			int num3 = 0;
			if (fullBg != (Object)num3)
			{
				GameObject fullBg2 = FullBg;
				int active = 0;
				fullBg2.SetActive((byte)active != 0);
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (Object)num4)
			{
				Decoration.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003495")]
		[Cpp2IlInjected.Address(RVA = "0xAE8FA0", Offset = "0xAE79A0", VA = "0x180AE8FA0", Slot = "9")]
		public virtual void RemoveHighlighSideButton()
		{
			//Discarded unreachable code: IL_009e
			//IL_0010: Expected O, but got I4
			//IL_0048: Expected F4, but got I4
			//IL_0063: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oX = _oX;
				int num3 = 0;
				Transform animatedContent3 = AnimatedContent;
				int num4 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(animatedContent3, oX, (float)num4, (byte)num3 != 0)).Play();
			}
			GameObject fullBg = FullBg;
			int num5 = 0;
			if (fullBg != (Object)num5)
			{
				FullBg.SetActive(value: true);
			}
			GameObject decoration = Decoration;
			int num6 = 0;
			if (decoration != (Object)num6)
			{
				GameObject decoration2 = Decoration;
				int active = 0;
				decoration2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003496")]
		[Cpp2IlInjected.Address(RVA = "0xA82CD0", Offset = "0xA816D0", VA = "0x180A82CD0")]
		public void ForceRefreshYPos(float y = -128f)
		{
			_oY = y;
		}

		[Cpp2IlInjected.Token(Token = "0x6003497")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HighlightHelper()
		{
		}
	}
}
