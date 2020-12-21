// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB3E1550-356E-44B0-99DA-85AC6017865E")]
    [NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler : IUnknown")]
    public unsafe partial struct IUIAnimationVariableIntegerChangeHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler*, uint>)(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler*, uint>)(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnIntegerValueChanged([NativeTypeName("IUIAnimationStoryboard *")] IUIAnimationStoryboard* storyboard, [NativeTypeName("IUIAnimationVariable *")] IUIAnimationVariable* variable, [NativeTypeName("INT32")] int newValue, [NativeTypeName("INT32")] int previousValue)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableIntegerChangeHandler*, IUIAnimationStoryboard*, IUIAnimationVariable*, int, int, int>)(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue);
        }
    }
}
