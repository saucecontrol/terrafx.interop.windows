// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("829B6CF1-4F3A-4412-AE09-B243EB4C6B58")]
    [NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler2 : IUnknown")]
    public unsafe partial struct IUIAnimationVariableIntegerChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnIntegerValueChanged([NativeTypeName("IUIAnimationStoryboard2 *")] IUIAnimationStoryboard2* storyboard, [NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int>)(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
        }
    }
}
