using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000670")]
	public class GenericMessage : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000671")]
		public struct MessageTransactionScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400241B")]
			private readonly GenericMessage message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400241C")]
			private readonly string key;

			[Cpp2IlInjected.Token(Token = "0x60029AF")]
			[Cpp2IlInjected.Address(RVA = "0xC26790", Offset = "0xC25190", VA = "0x180C26790")]
			public MessageTransactionScope(GenericMessage message, string key, string text)
			{
				//Discarded unreachable code: IL_0016
				this.message = message;
				this.key = key;
				string materialAddress = ((ITrimmingData)message).MaterialAddress;
			}

			[Cpp2IlInjected.Token(Token = "0x60029B0")]
			[Cpp2IlInjected.Address(RVA = "0xC26760", Offset = "0xC25160", VA = "0x180C26760", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002419")]
		[SerializeField]
		private TextBase _text;

		[Cpp2IlInjected.Token(Token = "0x1700062F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400241A")]
		private List<(string key, string text)> _messages
		{
			[Cpp2IlInjected.Token(Token = "0x60029A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		} = (List<(string key, string text)>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x60029AA")]
		[Cpp2IlInjected.Address(RVA = "0xE53B60", Offset = "0xE52560", VA = "0x180E53B60", Slot = "4")]
		public virtual void TransactionBegin(string key, string text)
		{
			//Discarded unreachable code: IL_0017
			//IL_0010: Expected O, but got I4
			List<(string, string)> list = _messages;
			int num = 0;
			((List<T>)(object)list).Add((T)num);
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x60029AB")]
		[Cpp2IlInjected.Address(RVA = "0xE53C20", Offset = "0xE52620", VA = "0x180E53C20", Slot = "5")]
		public virtual void TransactionEnd(string key)
		{
			//Discarded unreachable code: IL_0030
			List<(string, string)> list = _messages;
			Predicate<(string, string)> predicate = (Predicate<(string, string)>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x60029AC")]
		[Cpp2IlInjected.Address(RVA = "0xE53DD0", Offset = "0xE527D0", VA = "0x180E53DD0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_0036
			int size = ((List<>)(object)_messages)._size;
			GameObject gameObject = base.gameObject;
			bool active = size > 0;
			gameObject.SetActive(active);
			TextBase text = _text;
			if (size > 0)
			{
			}
			text.StringID = "";
		}

		[Cpp2IlInjected.Token(Token = "0x60029AD")]
		[Cpp2IlInjected.Address(RVA = "0xE53D20", Offset = "0xE52720", VA = "0x180E53D20")]
		public MessageTransactionScope TransactionScope(string text)
		{
			Guid guid = Guid.NewGuid();
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029AE")]
		[Cpp2IlInjected.Address(RVA = "0xE53EA0", Offset = "0xE528A0", VA = "0x180E53EA0")]
		public GenericMessage()
		{
		}
	}
}
