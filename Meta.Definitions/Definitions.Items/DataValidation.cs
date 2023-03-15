using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000636")]
	public static class DataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000637")]
		public class Context
		{
			[Cpp2IlInjected.Token(Token = "0x2000638")]
			private class StackScope<T> : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4002214")]
				private Stack<T> Stack;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4002215")]
				private List<DataValidationError> OverrideOwnerErrors;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4002216")]
				private int PrevErrorCount;

				[Cpp2IlInjected.Token(Token = "0x60049C3")]
				[Cpp2IlInjected.Address(RVA = "0x21DB5E0", Offset = "0x21D9FE0", VA = "0x1821DB5E0")]
				public StackScope(Stack<T> stack, T value, [Optional] List<DataValidationError> errors)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049C4")]
				[Cpp2IlInjected.Address(RVA = "0x21DB4F0", Offset = "0x21D9EF0", VA = "0x1821DB4F0", Slot = "4")]
				void IDisposable.Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002210")]
			private readonly List<DataValidationError> errors = (List<DataValidationError>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x170012F6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400220F")]
			public bool StopRecursion
			{
				[Cpp2IlInjected.Token(Token = "0x60049A5")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60049A6")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170012F7")]
			public IEnumerable<DataValidationError> Errors
			{
				[Cpp2IlInjected.Token(Token = "0x60049A7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get
				{
					List<DataValidationError> list = errors;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012F8")]
			public Stack<string> StackName
			{
				[Cpp2IlInjected.Token(Token = "0x60049B1")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CStackName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60049B2")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CStackName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Stack<string>)(object)new Stack<T>();


			[Cpp2IlInjected.Token(Token = "0x170012F9")]
			public Stack<object> Stack
			{
				[Cpp2IlInjected.Token(Token = "0x60049B3")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CStack_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60049B4")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CStack_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Stack<object>)(object)new Stack<T>();


			[Cpp2IlInjected.Token(Token = "0x170012FA")]
			public object Owner
			{
				[Cpp2IlInjected.Token(Token = "0x60049B5")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003COwner_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60049B6")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				private set
				{
					_003COwner_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012FB")]
			public string BaseItemName
			{
				[Cpp2IlInjected.Token(Token = "0x60049B7")]
				[Cpp2IlInjected.Address(RVA = "0x8EDA10", Offset = "0x8EC410", VA = "0x1808EDA10")]
				get
				{
					string text = default(string);
					if ("<none>" == null || text == null)
					{
					}
					return "<none>";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012FC")]
			public string MissionStepName
			{
				[Cpp2IlInjected.Token(Token = "0x60049B8")]
				[Cpp2IlInjected.Address(RVA = "0x8EDB90", Offset = "0x8EC590", VA = "0x1808EDB90")]
				get
				{
					MissionObjectiveData parentOfType = GetParentOfType<MissionObjectiveData>();
					if (parentOfType == null || parentOfType.stepName_ == null)
					{
						MissionStepData parentOfType2 = GetParentOfType<MissionStepData>();
						if (parentOfType2 != null && parentOfType2.stepName_ != null)
						{
						}
					}
					return "<none>";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012FD")]
			public bool IsMission
			{
				[Cpp2IlInjected.Token(Token = "0x60049B9")]
				[Cpp2IlInjected.Address(RVA = "0x8EDB50", Offset = "0x8EC550", VA = "0x1808EDB50")]
				get
				{
					return GetParentOfType<MissionItemData>() != null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012FE")]
			public bool IsMissionStep
			{
				[Cpp2IlInjected.Token(Token = "0x60049BA")]
				[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8EC510", VA = "0x1808EDB10")]
				get
				{
					return GetParentOfType<MissionStepData>() != null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170012FF")]
			public string TopName
			{
				[Cpp2IlInjected.Token(Token = "0x60049BB")]
				[Cpp2IlInjected.Address(RVA = "0x8EDC20", Offset = "0x8EC620", VA = "0x1808EDC20")]
				get
				{
					//Discarded unreachable code: IL_002e, IL_0030, IL_0039, IL_003f
					Stack<string> stack = StackName;
					string text = (string)((Stack<T>)(object)stack).Peek();
					char[] array = new char[1];
					array[0] = '!';
					return ((IEnumerable<>)(object)text.Split(array)).Last<string>();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001300")]
			public string FullStackName
			{
				[Cpp2IlInjected.Token(Token = "0x60049BC")]
				[Cpp2IlInjected.Address(RVA = "0x8EDA90", Offset = "0x8EC490", VA = "0x1808EDA90")]
				get
				{
					Stack<string> stack = StackName;
					if (stack != null)
					{
						IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Reverse<string>((IEnumerable<>)stack);
						return string.Join(".", (IEnumerable<>)enumerable);
					}
					return "";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60049A4")]
			[Cpp2IlInjected.Address(RVA = "0x8ED8F0", Offset = "0x8EC2F0", VA = "0x1808ED8F0")]
			public Context([Optional] object owner)
			{
				Owner = owner;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60049A8")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0E0", Offset = "0x8EBAE0", VA = "0x1808ED0E0")]
			private void AddError(DataValidationError error)
			{
				//Discarded unreachable code: IL_000d
				((List<T>)(object)errors).Add((T)error);
			}

			[Cpp2IlInjected.Token(Token = "0x60049A9")]
			[Cpp2IlInjected.Address(RVA = "0x8ED200", Offset = "0x8EBC00", VA = "0x1808ED200")]
			public void AddInvalidMemberError(string message, string memberName)
			{
				//Discarded unreachable code: IL_0020
				object owner = Owner;
				List<DataValidationError> list = errors;
				InvalidMemberError item = new InvalidMemberError(message, owner, memberName, this);
				((List<T>)(object)list).Add((T)item);
			}

			[Cpp2IlInjected.Token(Token = "0x60049AA")]
			[Cpp2IlInjected.Address(RVA = "0x8ED140", Offset = "0x8EBB40", VA = "0x1808ED140")]
			public void AddInvalidMemberError(string message, object owner, string memberName)
			{
				//Discarded unreachable code: IL_0019
				List<DataValidationError> list = errors;
				InvalidMemberError item = new InvalidMemberError(message, owner, memberName, this);
				((List<T>)(object)list).Add((T)item);
			}

			[Cpp2IlInjected.Token(Token = "0x60049AB")]
			[Cpp2IlInjected.Address(RVA = "0x20B67F0", Offset = "0x20B51F0", VA = "0x1820B67F0")]
			public void RequireEnum<TType>(TType value, string memberName, params TType[] invalidValues) where TType : Enum
			{
				//Discarded unreachable code: IL_002f
				if (invalidValues.Length == 0)
				{
					Array values = Enum.GetValues(typeof(Type));
					int num = 0;
					int index = 0;
					object value2 = values.GetValue(index);
				}
				string message = default(string);
				AddInvalidMemberError(message, memberName);
			}

			[Cpp2IlInjected.Token(Token = "0x60049AC")]
			[Cpp2IlInjected.Address(RVA = "0x20B6FB0", Offset = "0x20B59B0", VA = "0x1820B6FB0")]
			public void RequireGreater<TType>(TType value, TType refValue, string P_2) where TType : IComparable
			{
				//Discarded unreachable code: IL_0015
				//IL_000b: Expected O, but got I4
				int num = default(int);
				string message = $"Should be greather than {num}";
				AddInvalidMemberError(message, P_2);
			}

			[Cpp2IlInjected.Token(Token = "0x60049AD")]
			[Cpp2IlInjected.Address(RVA = "0x20B6D20", Offset = "0x20B5720", VA = "0x1820B6D20")]
			public void RequireGreaterOrEqual<TType>(TType value, TType refValue, string P_2) where TType : IComparable
			{
				//Discarded unreachable code: IL_0015
				//IL_000b: Expected O, but got I4
				int num = default(int);
				string message = $"Should be greather or equal than {num}";
				AddInvalidMemberError(message, P_2);
			}

			[Cpp2IlInjected.Token(Token = "0x60049AE")]
			[Cpp2IlInjected.Address(RVA = "0x20B7240", Offset = "0x20B5C40", VA = "0x1820B7240")]
			public void RequireNotEmpty<TType>(IEnumerable<> cpp2il__autoParamName__idx_0, string cpp2il__autoParamName__idx_1)
			{
				//Discarded unreachable code: IL_0015
				if ("Should not be empty" == null)
				{
					AddInvalidMemberError("Should not be empty", cpp2il__autoParamName__idx_1);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60049AF")]
			[Cpp2IlInjected.Address(RVA = "0x8ED020", Offset = "0x8EBA20", VA = "0x1808ED020")]
			public void AddError(string error)
			{
				//Discarded unreachable code: IL_001d
				object owner = Owner;
				DataValidationError item = new DataValidationError(error, owner, this);
				((List<T>)(object)errors).Add((T)item);
			}

			[Cpp2IlInjected.Token(Token = "0x60049B0")]
			[Cpp2IlInjected.Address(RVA = "0x8ED4A0", Offset = "0x8EBEA0", VA = "0x1808ED4A0")]
			public void ResetContext(out bool stopRecursion)
			{
				bool flag = (stopRecursion.m_value = StopRecursion);
				StopRecursion = false;
			}

			[Cpp2IlInjected.Token(Token = "0x60049BD")]
			[Cpp2IlInjected.Address(RVA = "0x20B67C0", Offset = "0x20B51C0", VA = "0x1820B67C0")]
			public bool HasParentOfType<T>() where T : class
			{
				//Discarded unreachable code: IL_0002
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60049BE")]
			[Cpp2IlInjected.Address(RVA = "0x20B6560", Offset = "0x20B4F60", VA = "0x1820B6560")]
			public T GetParentOfType<T>() where T : class
			{
				Func<object, bool> func = default(Func<object, bool>);
				object obj = Enumerable.FirstOrDefault<object>((IEnumerable<>)Stack, (Func<, >)(object)func);
				if (obj == null)
				{
				}
				if (obj != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			}

			[Cpp2IlInjected.Token(Token = "0x60049BF")]
			[Cpp2IlInjected.Address(RVA = "0x8ED2C0", Offset = "0x8EBCC0", VA = "0x1808ED2C0")]
			public static string GetContextName(FieldDescriptor field, object value, [Optional] string key)
			{
				if (field != null)
				{
					CustomOptions customOptions = field.CustomOptions;
					bool flag = default(bool);
					if (flag)
					{
						CustomOptions customOptions2 = field.CustomOptions;
						bool flag2 = default(bool);
						if (!flag2 || !flag2)
						{
						}
						string name = field.Name;
						if (name == null && name == null)
						{
							bool flag3 = default(bool);
							if (!flag3)
							{
								return name + "[" + key + "]";
							}
							string result = default(string);
							return result;
						}
						return name;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60049C0")]
			[Cpp2IlInjected.Address(RVA = "0x8ED4B0", Offset = "0x8EBEB0", VA = "0x1808ED4B0")]
			public IDisposable ScopeStackName(string value, bool ownerOverride = false)
			{
				//IL_0015: Expected O, but got I4
				Stack<string> stack = StackName;
				if (ownerOverride)
				{
				}
				int num = 0;
				StackScope<string> stackScope = (StackScope<string>)(object)new StackScope<T>((Stack<>)(object)stack, (T)value, (List<>)num);
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60049C1")]
			[Cpp2IlInjected.Address(RVA = "0x8ED550", Offset = "0x8EBF50", VA = "0x1808ED550")]
			public IDisposable ScopeStack(object value, bool ownerOverride = false)
			{
				//IL_0015: Expected O, but got I4
				Stack<object> stack = Stack;
				if (ownerOverride)
				{
				}
				int num = 0;
				StackScope<object> stackScope = (StackScope<object>)(object)new StackScope<T>((Stack<>)(object)stack, (T)value, (List<>)num);
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
