using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002EE")]
	[RequiredAllNotNull]
	public class CollectionMemoryShards : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E3C")]
		[SerializeField]
		private MemoryShardMaskData _noMaskMemoryShardMaskData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E3D")]
		[SerializeField]
		private Image _mcShards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E3E")]
		private bool _isCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E3F")]
		private Image _mcMaskReveal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E40")]
		private MemoryShardItemData _memoryShardItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E41")]
		private MemoryShardMaskData memoryShardMaskData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E42")]
		private Texture2D backgroundTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000E45")]
		[SerializeField]
		[Header("Animation config")]
		private float _pieceRevealDuration = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000E46")]
		[SerializeField]
		private float _completeRevealDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000E47")]
		public UnityEvent OnDisplayRefresh;

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6001306")]
			[Cpp2IlInjected.Address(RVA = "0x10073D0", Offset = "0x1005DD0", VA = "0x1810073D0")]
			get
			{
				if (!_isCompleted)
				{
					int num = 0;
				}
				int num2 = PieceToReveal;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001307")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				_isCompleted = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		public MemoryShardItemData MemoryShardItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001308")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _memoryShardItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6001309")]
			[Cpp2IlInjected.Address(RVA = "0x10073E0", Offset = "0x1005DE0", VA = "0x1810073E0")]
			set
			{
				//IL_0020: Expected O, but got I4
				//IL_0037: Expected O, but got I8
				//IL_0047: Expected O, but got I4
				if (_memoryShardItemData != value)
				{
					_memoryShardItemData = value;
					MemoryShardMaskData memoryShardMaskData = this.memoryShardMaskData;
					int num = 0;
					if (memoryShardMaskData != (UnityEngine.Object)num)
					{
						Addressables.Release(this.memoryShardMaskData);
						this.memoryShardMaskData = (MemoryShardMaskData)0;
					}
					Texture2D texture2D = backgroundTexture;
					int num2 = 0;
					if (texture2D != (UnityEngine.Object)num2)
					{
						Addressables.Release(texture2D);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000352")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4000E43")]
		public int NumPieces
		{
			[Cpp2IlInjected.Token(Token = "0x600130A")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600130B")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000353")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x54"), Cpp2IlInjected.Token(Token = "0x4000E44")]
		public int PieceToReveal
		{
			[Cpp2IlInjected.Token(Token = "0x600130C")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600130D")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set;
		} = -1;


		[Cpp2IlInjected.Token(Token = "0x600130E")]
		[Cpp2IlInjected.Address(RVA = "0x1006CB0", Offset = "0x10056B0", VA = "0x181006CB0")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00d7
			//IL_005d: Expected I4, but got O
			if ((long)_memoryShardItemData == 0)
			{
				return;
			}
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)_memoryShardItemData.shards_).Count;
			Client client = default(Client);
			MapField<int, int> memoryShards_ = client.profile.player_.memoryShards_;
			Func<KeyValuePair<int, int>, bool> func = (Func<KeyValuePair<int, int>, bool>)(object)(Func<T, TResult>)delegate(KeyValuePair<int, int> x)
			{
				//Discarded unreachable code: IL_0011
				int iD2 = _memoryShardItemData.ID;
				return (IntPtr)x == (IntPtr)iD2;
			};
			KeyValuePair<int, int> keyValuePair = Enumerable.FirstOrDefault<KeyValuePair<int, int>>((IEnumerable<>)(object)memoryShards_, (Func<, >)(object)func);
			NumPieces = (int)keyValuePair;
			int num2 = 0;
			if (count > 0)
			{
				Client client2 = default(Client);
				Profile profile = client2.profile;
				MemoryShardItemData memoryShardItemData = _memoryShardItemData;
				ProfilePlayer player_ = profile.player_;
				int iD = memoryShardItemData.ID;
				count--;
				bool flag = default(bool);
				if (flag)
				{
					num2++;
				}
			}
			int count2 = ((RepeatedField<T>)(object)_memoryShardItemData.shards_).Count;
			UnityEvent onDisplayRefresh = OnDisplayRefresh;
			bool flag2 = (_isCompleted = num2 == count2);
			onDisplayRefresh?.Invoke();
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600130F")]
		[Cpp2IlInjected.Address(RVA = "0x1006A20", Offset = "0x1005420", VA = "0x181006A20")]
		[AsyncStateMachine(typeof(_003CLoadTextureAsync_003Ed__25))]
		private Task LoadTextureAsync(MemoryShardItemData shardItemData)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001310")]
		[Cpp2IlInjected.Address(RVA = "0x1006670", Offset = "0x1005070", VA = "0x181006670")]
		private void AnimateNewPiece(int currentIndex)
		{
			//IL_0078: Expected F4, but got I4
			//IL_0088: Expected I4, but got I8
			//IL_00b4: Expected F4, but got I4
			int count = ((RepeatedField<T>)(object)_memoryShardItemData.shards_).Count;
			int isCompleted = 0;
			Image mcShards = _mcShards;
			int value = NumPieces;
			_isCompleted = (byte)isCompleted != 0;
			mcShards.material.SetInt("_Pieces", value);
			_mcMaskReveal.material.SetInt("_Pieces", 1);
			Image mcMaskReveal = _mcMaskReveal;
			if ((object)mcMaskReveal != null)
			{
				Material material = mcMaskReveal.material;
				int num = 0;
				material.SetFloat("_Alpha", num);
			}
			PieceToReveal = -1;
			DOSetter<float> dOSetter = (DOSetter<float>)(object)new DOSetter<T>(CurrentImageAlpha);
			float pieceRevealDuration = _pieceRevealDuration;
			int num2 = 0;
			int num3 = 0;
			Tweener tweener = DOTween.To((DOSetter<>)(object)dOSetter, (float)num3, 1f, pieceRevealDuration).SetDelay(1f);
			TweenCallback tweenCallback = delegate
			{
				Material material2 = _mcShards.material;
				int value2 = NumPieces;
				material2.SetInt("_Pieces", value2);
				if (!_isCompleted)
				{
				}
				if (PieceToReveal == 0)
				{
					GameObject obj = _mcMaskReveal.gameObject;
					UnityEngine.Object.Destroy(obj);
					return;
				}
				int num4 = 0;
				int num5 = 0;
				if (num4 != 0)
				{
				}
				if (num4 != 0)
				{
				}
				DOSetter<float> dOSetter2 = (DOSetter<float>)(object)new DOSetter<T>(CurrentImageAlpha);
				Tweener tweener2 = default(Tweener);
				TweenCallback tweenCallback2 = (tweener2.onComplete = delegate
				{
					GameObject CS_0024_003C_003E8__locals0 = default(GameObject);
					((CollectionMemoryShards)(object)CS_0024_003C_003E8__locals0).OnDisplayRefresh?.Invoke();
				});
				throw new NullReferenceException();
			};
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				tweener.onComplete = (TweenCallback)@delegate;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001311")]
		[Cpp2IlInjected.Address(RVA = "0x10069A0", Offset = "0x10053A0", VA = "0x1810069A0")]
		private void CurrentImageAlpha(float alpha)
		{
			//Discarded unreachable code: IL_001d
			_mcMaskReveal?.material.SetFloat("_Alpha", alpha);
		}

		[Cpp2IlInjected.Token(Token = "0x6001312")]
		[Cpp2IlInjected.Address(RVA = "0x1006B40", Offset = "0x1005540", VA = "0x181006B40")]
		private void OnDestroy()
		{
			//IL_001b: Expected O, but got I4
			//IL_0032: Expected O, but got I8
			//IL_0042: Expected O, but got I4
			//IL_0059: Expected O, but got I8
			if ((long)_memoryShardItemData != 0)
			{
				MemoryShardMaskData memoryShardMaskData = this.memoryShardMaskData;
				int num = 0;
				if (memoryShardMaskData != (UnityEngine.Object)num)
				{
					Addressables.Release(this.memoryShardMaskData);
					this.memoryShardMaskData = (MemoryShardMaskData)0;
				}
				Texture2D texture2D = backgroundTexture;
				int num2 = 0;
				if (texture2D != (UnityEngine.Object)num2)
				{
					Addressables.Release(backgroundTexture);
					backgroundTexture = (Texture2D)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001313")]
		[Cpp2IlInjected.Address(RVA = "0x10073B0", Offset = "0x1005DB0", VA = "0x1810073B0")]
		public CollectionMemoryShards()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
