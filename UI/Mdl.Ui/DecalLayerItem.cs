using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200040D")]
	public class DecalLayerItem : DecalBaseItem
	{
		[Cpp2IlInjected.Token(Token = "0x200040E")]
		public delegate void SelectDecal(DecalLayerItem decal);

		[Cpp2IlInjected.Token(Token = "0x200040F")]
		public delegate void DeleteDecal(DecalLayerItem decal);

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400143E")]
		[SerializeField]
		private RectTransform _decalHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001441")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001442")]
		[SerializeField]
		private Button _deleteButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001443")]
		internal Decal decal;

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		public Button DeleteButton
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3E")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return _deleteButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000033")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3A")]
			[Cpp2IlInjected.Address(RVA = "0x12AFFD0", Offset = "0x12AE9D0", VA = "0x1812AFFD0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001A3B")]
			[Cpp2IlInjected.Address(RVA = "0x12B0110", Offset = "0x12AEB10", VA = "0x1812B0110")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000034")]
		public event DeleteDecal OnDecalDeleted
		{
			[Cpp2IlInjected.Token(Token = "0x6001A3C")]
			[Cpp2IlInjected.Address(RVA = "0x12AFF30", Offset = "0x12AE930", VA = "0x1812AFF30")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001A3D")]
			[Cpp2IlInjected.Address(RVA = "0x12B0070", Offset = "0x12AEA70", VA = "0x1812B0070")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3F")]
		[Cpp2IlInjected.Address(RVA = "0x12AFBB0", Offset = "0x12AE5B0", VA = "0x1812AFBB0", Slot = "4")]
		public override void Init(DecalItemData decalData, Color color, int layer)
		{
			//Discarded unreachable code: IL_0063
			_button.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick = _button.m_OnClick;
			UnityAction call = SelectCurrent;
			onClick.AddListener(call);
			_deleteButton.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick2 = _deleteButton.m_OnClick;
			UnityAction call2 = DeleteCurrent;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A40")]
		[Cpp2IlInjected.Address(RVA = "0x12AFD30", Offset = "0x12AE730", VA = "0x1812AFD30")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			_button.m_OnClick.RemoveAllListeners();
			_deleteButton.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A41")]
		[Cpp2IlInjected.Address(RVA = "0x12AFE50", Offset = "0x12AE850", VA = "0x1812AFE50")]
		public RectTransform TakeIcon(RectTransform newParent)
		{
			//Discarded unreachable code: IL_002b
			_decal.transform.parentInternal = newParent;
			Transform transform = _decal.transform;
			int num = 0;
			return _decal.GetComponent<RectTransform>();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A42")]
		[Cpp2IlInjected.Address(RVA = "0x12AFD90", Offset = "0x12AE790", VA = "0x1812AFD90")]
		public void PutBackIcon(RectTransform icon)
		{
			//Discarded unreachable code: IL_0036
			RectTransform rectTransform = (RectTransform)(((Transform)icon).parentInternal = _decalHolder);
			float z = UnityEngine.Vector3.one.z;
			float z2 = UnityEngine.Vector3.zero.z;
			int num = 0;
			Vector2 vector = (icon.sizeDelta = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A43")]
		[Cpp2IlInjected.Address(RVA = "0x12AFE30", Offset = "0x12AE830", VA = "0x1812AFE30")]
		private void SelectCurrent()
		{
			this.OnDecalSelected?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A44")]
		[Cpp2IlInjected.Address(RVA = "0x12AFB90", Offset = "0x12AE590", VA = "0x1812AFB90")]
		private void DeleteCurrent()
		{
			this.OnDecalDeleted?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A45")]
		[Cpp2IlInjected.Address(RVA = "0x12AFF20", Offset = "0x12AE920", VA = "0x1812AFF20")]
		public DecalLayerItem()
		{
		}
	}
}
