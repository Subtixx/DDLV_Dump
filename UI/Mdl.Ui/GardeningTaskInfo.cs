using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007A8")]
	public class GardeningTaskInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CFE")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CFF")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D00")]
		private TaskCompletionSource<bool> _mcIconTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D01")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002D02")]
		[SerializeField]
		private float _iconSize = 200f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002D03")]
		[SerializeField]
		private float _currencyIconSize = 84f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002D04")]
		[SerializeField]
		private float _fadeInDelay = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002D05")]
		[SerializeField]
		private float _fadeInDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002D06")]
		[SerializeField]
		private float _fadeOutDelay = 0.7f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4002D07")]
		[SerializeField]
		private float _fadeOutDuration = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002D08")]
		[SerializeField]
		private float _firstMoveDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4002D09")]
		[SerializeField]
		private float _secondMoveDelay = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002D0A")]
		[SerializeField]
		private float _secondMoveDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4002D0B")]
		private bool _isSoftCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x4002D0C")]
		private bool _isHardCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x4002D0D")]
		private bool _isCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002D0E")]
		private int _currencyAmount = -1;

		[Cpp2IlInjected.Token(Token = "0x60030FE")]
		[Cpp2IlInjected.Address(RVA = "0xE4EC80", Offset = "0xE4D680", VA = "0x180E4EC80", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_010c
			//IL_0009: Expected O, but got I8
			//IL_0019: Expected I4, but got I8
			_mcIconTCS = (TaskCompletionSource<bool>)0;
			_currencyAmount = -1;
			int num = 0;
			int num2 = 0;
			if (num == 0)
			{
				num++;
				_tfLabel.gameObject.SetActive(value: true);
				TextBase tfLabel = _tfLabel;
				num++;
			}
			ItemType itemType = default(ItemType);
			bool flag = (_isCurrency = itemType == ItemType.Currency);
			int num3 = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			bool isSoftCurrency = default(bool);
			_isSoftCurrency = isSoftCurrency;
			int num4 = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			AsyncAtlassedIcon mcIcon = _mcIcon;
			bool isHardCurrency = default(bool);
			_isHardCurrency = isHardCurrency;
			mcIcon.gameObject.SetActive(value: true);
			Transform transform = _mcIcon.transform;
			if ((object)transform != null)
			{
			}
			if (!_isCurrency || (object)transform != null)
			{
			}
			VerticalLayoutGroup component = _mcContent.GetComponent<VerticalLayoutGroup>();
			if (_isCurrency)
			{
			}
			component.spacing = -15f;
			AsyncAtlassedIcon mcIcon2 = _mcIcon;
			bool flag2 = default(bool);
			if (!flag2)
			{
				TaskCompletionSource<bool> taskCompletionSource = (_mcIconTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
				AsyncAtlassedIcon mcIcon3 = _mcIcon;
				AsyncAtlassedIcon.ImageLoaded value = OnImageLoaded;
				mcIcon3.OnImageLoaded += value;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60030FF")]
		[Cpp2IlInjected.Address(RVA = "0xE4F1D0", Offset = "0xE4DBD0", VA = "0x180E4F1D0")]
		private void OnImageLoaded(AsyncAtlassedIcon image)
		{
			//Discarded unreachable code: IL_0029
			//IL_0027: Expected O, but got I4
			AsyncAtlassedIcon mcIcon = _mcIcon;
			AsyncAtlassedIcon.ImageLoaded value = OnImageLoaded;
			mcIcon.OnImageLoaded -= value;
			bool flag = ((TaskCompletionSource<TResult>)(object)_mcIconTCS).TrySetResult((TResult)1);
		}

		[Cpp2IlInjected.Token(Token = "0x6003100")]
		[Cpp2IlInjected.Address(RVA = "0xE4F290", Offset = "0xE4DC90", VA = "0x180E4F290", Slot = "14")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__19))]
		public override Task Show(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003101")]
		[Cpp2IlInjected.Address(RVA = "0xE4EB70", Offset = "0xE4D570", VA = "0x180E4EB70", Slot = "16")]
		protected override void HideImpl()
		{
			//IL_0022: Expected O, but got I4
			TaskCompletionSource<bool> mcIconTCS = _mcIconTCS;
			if (mcIconTCS != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)mcIconTCS).TrySetCanceled();
			}
			GameObject gameObject = base.gameObject;
			int num = 0;
			if (gameObject != (Object)num && !Addressables.ReleaseInstance(base.gameObject))
			{
				Object.Destroy(base.gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003102")]
		[Cpp2IlInjected.Address(RVA = "0xE4F410", Offset = "0xE4DE10", VA = "0x180E4F410")]
		public GardeningTaskInfo()
		{
		}//IL_0073: Expected I4, but got I8

	}
}
