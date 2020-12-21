// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6E022BA-BFF3-42EC-9033-E073F33E83C3")]
    [NativeTypeName("struct IUIAnimationManagerEventHandler2 : IUnknown")]
    public unsafe partial struct IUIAnimationManagerEventHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManagerEventHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManagerEventHandler2*, uint>)(lpVtbl[1]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManagerEventHandler2*, uint>)(lpVtbl[2]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManagerEventHandler2*, UI_ANIMATION_MANAGER_STATUS, UI_ANIMATION_MANAGER_STATUS, int>)(lpVtbl[3]))((IUIAnimationManagerEventHandler2*)Unsafe.AsPointer(ref this), newStatus, previousStatus);
        }
    }
}
