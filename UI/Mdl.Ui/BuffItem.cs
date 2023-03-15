using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.WellKnownTypes;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000571")]
	public class BuffItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DBD")]
		[SerializeField]
		private AsyncAtlassedIcon _iconAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DBE")]
		[SerializeField]
		private GameObject _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DBF")]
		[SerializeField]
		private AsyncAtlassedIcon _iconCharacterAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DC0")]
		[SerializeField]
		private GameObject _iconCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DC1")]
		[SerializeField]
		private TextBase _iconAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DC2")]
		[SerializeField]
		private RectTransform _amountBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001DC3")]
		[SerializeField]
		private TextBase _time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001DC4")]
		[SerializeField]
		private TextBase _titleAndDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001DC5")]
		public Buff buff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001DC6")]
		internal BuffItemModel itemModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001DC7")]
		private int _amountLength = -1;

		[Cpp2IlInjected.Token(Token = "0x60023AB")]
		[Cpp2IlInjected.Address(RVA = "0xA66640", Offset = "0xA65040", VA = "0x180A66640")]
		public void RefreshVisual(Buff buff)
		{
			//Discarded unreachable code: IL_01ba, IL_01c0, IL_01c6, IL_01cc, IL_01d2, IL_01d8, IL_01de
			//IL_0053: Expected I4, but got I8
			//IL_0067: Expected I4, but got I8
			//IL_00c1: Expected O, but got I4
			//IL_00d0: Expected I4, but got I8
			int num = 0;
			this.buff = buff;
			if (buff.origin_ != BuffOrigin.Hangout)
			{
				AsyncAtlassedIcon iconAtlas = _iconAtlas;
				string iconAddress_ = itemModel.BuffDisplayData.iconAddress_;
				bool flag = iconAtlas.SetIcon(iconAddress_);
				GameObject iconCharacter = _iconCharacter;
				int active = 0;
				iconCharacter.SetActive((byte)active != 0);
				ulong num2 = default(ulong);
				_icon.SetActive((byte)num2 != 0);
			}
			int num3 = 0;
			ulong num4 = default(ulong);
			IEnumerable<CharacterManager.CharacterInstance> characterInstances = (IEnumerable<CharacterManager.CharacterInstance>)SystemRoot.Instance.GetSystem<CharacterManager>().GetCharacterInstances((byte)num4 != 0);
			Func<CharacterManager.CharacterInstance, bool> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
			if (_003C_003E9__11_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CharacterManager.CharacterInstance x)
				{
					//Discarded unreachable code: IL_0018
					if (x.MetaCharacter == null)
					{
					}
					return !x.MetaCharacter.InRealm;
				};
			}
			IEnumerable<CharacterManager.CharacterInstance> enumerable = (IEnumerable<CharacterManager.CharacterInstance>)Enumerable.Where<CharacterManager.CharacterInstance>((IEnumerable<>)characterInstances, (Func<, >)(object)_003C_003E9__11_);
			int num8 = default(int);
			if (enumerable != null)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					if (num == (int)num5)
					{
						goto IL_00e4;
					}
					num++;
				}
				int num6 = 0;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = _iconCharacterAtlas.SetIcon((string)num6);
				ulong num7 = default(ulong);
				_iconCharacter.SetActive((byte)num7 != 0);
				GameObject icon = _icon;
				num8 = 0;
				icon.SetActive((byte)num8 != 0);
				goto IL_00e4;
			}
			goto IL_00eb;
			IL_00eb:
			if (enumerable != null)
			{
			}
			ulong num9 = default(ulong);
			if (num9 == 0)
			{
			}
			string text = default(string);
			string text2 = text.ToUpper();
			string text3 = default(string);
			if (text3 != "")
			{
				string text4 = text2 + "\n" + text3;
			}
			SetSizeBasedOnChild setSizeBasedOnChild = default(SetSizeBasedOnChild);
			setSizeBasedOnChild.DoAdjustment();
			GameObject gameObject = default(GameObject);
			if ((object)setSizeBasedOnChild == null)
			{
				gameObject = setSizeBasedOnChild.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
			}
			if ((long)gameObject == 4 || (long)gameObject == 5)
			{
			}
			Timestamp timestamp = default(Timestamp);
			if (timestamp == null)
			{
				return;
			}
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = default(Timestamp);
				DateTime dateTime = timestamp3.ToDateTime();
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime dateTime2 = default(DateTime);
				TimeSpan timeSpan = dateTime - dateTime2;
			}
			TimeSpan zero = TimeSpan.Zero;
			int num10 = default(int);
			if (num10 != 0)
			{
				string text5 = default(string);
				string text6 = text5 + "h";
			}
			int num11 = default(int);
			if (num11 != 0)
			{
				string text7 = default(string);
				string text8 = text7 + "m";
			}
			string text9 = "" + "";
			throw new NullReferenceException();
			IL_00e4:
			num8 += num8;
			goto IL_00eb;
		}

		[Cpp2IlInjected.Token(Token = "0x60023AC")]
		[Cpp2IlInjected.Address(RVA = "0xA66E90", Offset = "0xA65890", VA = "0x180A66E90")]
		private void SetIcon()
		{
			//Discarded unreachable code: IL_0043
			BuffDisplayData _003CBuffDisplayData_003Ek__BackingField = itemModel.BuffDisplayData;
			AsyncAtlassedIcon iconAtlas = _iconAtlas;
			string iconAddress_ = _003CBuffDisplayData_003Ek__BackingField.iconAddress_;
			bool flag = iconAtlas.SetIcon(iconAddress_);
			GameObject iconCharacter = _iconCharacter;
			int active = 0;
			iconCharacter.SetActive((byte)active != 0);
			_icon.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60023AD")]
		[Cpp2IlInjected.Address(RVA = "0xA67090", Offset = "0xA65A90", VA = "0x180A67090")]
		private void UpdateAmount(Buff currentBuff)
		{
			//Discarded unreachable code: IL_007f
			int num = 0;
			if (currentBuff.NumberOfUsesLeft == 0)
			{
				if (currentBuff.percentageEffect_ != 0)
				{
					TextBase iconAmount = _iconAmount;
					string text = default(string);
					string text3 = (iconAmount.Text = text + "%");
					UpdateAmountBg();
				}
				return;
			}
			List<Buff> list = (List<Buff>)(object)Enumerable.ToList<Buff>(SystemRoot.Instance.MetaClient.profile.player_.GetAllBuffs());
			Predicate<Buff> predicate = (Predicate<Buff>)(object)(Predicate<T>)delegate(Buff element)
			{
				//Discarded unreachable code: IL_002a
				Buff buff = this.buff;
				BuffOrigin origin_ = buff.origin_;
				if (element.origin_ != origin_)
				{
					int num3 = 0;
				}
				BuffType type_ = buff.type_;
				return element.type_ == type_;
			};
			List<Buff> list2 = (List<Buff>)(object)((List<T>)(object)list).FindAll((Predicate<>)(object)predicate);
			bool flag = default(bool);
			if (flag)
			{
				int num2 = num2 + num;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023AE")]
		[Cpp2IlInjected.Address(RVA = "0xA66F40", Offset = "0xA65940", VA = "0x180A66F40")]
		private void UpdateAmountBg()
		{
			//Discarded unreachable code: IL_0074
			_amountBg.gameObject.SetActive(value: true);
			char[] array = _iconAmount._text.ToCharArray();
			RectTransform amountBg = _amountBg;
			int length = array.Length;
			Vector2 sizeDelta = amountBg.sizeDelta;
			if (length > 2)
			{
				int amountLength = _amountLength;
				if (length != amountLength)
				{
					if (amountLength == -1 || amountLength == -1)
					{
					}
					float fontSize = ((TMP_Text)_iconAmount.TextComponent).m_fontSize;
					RectTransform amountBg2 = _amountBg;
				}
			}
			_amountLength = length;
		}

		[Cpp2IlInjected.Token(Token = "0x60023AF")]
		[Cpp2IlInjected.Address(RVA = "0xA673B0", Offset = "0xA65DB0", VA = "0x180A673B0")]
		public BuffItem()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
