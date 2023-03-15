using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004AF")]
	public class BodyShapePresetItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400188C")]
		[SerializeField]
		private Image _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400188D")]
		[SerializeField]
		private BaseButton _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400188F")]
		public int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001890")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170004EF")]
		public BaseButton Button
		{
			[Cpp2IlInjected.Token(Token = "0x6001E6F")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _button;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F0")]
		public AvatarAppearance.BodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6001E70")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CBodyType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E71")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			private set
			{
				_003CBodyType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E72")]
		[Cpp2IlInjected.Address(RVA = "0xA62900", Offset = "0xA61300", VA = "0x180A62900")]
		public void Init(AvatarAppearance.BodyType data)
		{
			//Discarded unreachable code: IL_001c
			BodyType = data;
			CancellationToken token = cancellationTokenSource.Token;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E73")]
		[Cpp2IlInjected.Address(RVA = "0xA62B10", Offset = "0xA61510", VA = "0x180A62B10")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0016
			_button.ButtonComponent.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E74")]
		[Cpp2IlInjected.Address(RVA = "0xA62AB0", Offset = "0xA614B0", VA = "0x180A62AB0")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_0028
			BaseButton button = _button;
			if (button._isActive)
			{
				AK.Wwise.Event sfxEvent = button._sfxEvent;
				GameObject gameObject = button.gameObject;
				uint num = sfxEvent.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E75")]
		[Cpp2IlInjected.Address(RVA = "0xA62BA0", Offset = "0xA615A0", VA = "0x180A62BA0")]
		[AsyncStateMachine(typeof(_003CSetSprite_003Ed__13))]
		private Task SetSprite(AvatarAppearance.BodyType data, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E76")]
		[Cpp2IlInjected.Address(RVA = "0xA62CD0", Offset = "0xA616D0", VA = "0x180A62CD0")]
		public BodyShapePresetItem()
		{
			ShowSelected = true;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
