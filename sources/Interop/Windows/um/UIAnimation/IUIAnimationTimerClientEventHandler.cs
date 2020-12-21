// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEDB4DB6-94FA-4BFB-A47F-EF2D9E408C25")]
    [NativeTypeName("struct IUIAnimationTimerClientEventHandler : IUnknown")]
    public unsafe partial struct IUIAnimationTimerClientEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationTimerClientEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationTimerClientEventHandler*, uint>)(lpVtbl[1]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationTimerClientEventHandler*, uint>)(lpVtbl[2]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTimerClientStatusChanged(UI_ANIMATION_TIMER_CLIENT_STATUS newStatus, UI_ANIMATION_TIMER_CLIENT_STATUS previousStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationTimerClientEventHandler*, UI_ANIMATION_TIMER_CLIENT_STATUS, UI_ANIMATION_TIMER_CLIENT_STATUS, int>)(lpVtbl[3]))((IUIAnimationTimerClientEventHandler*)Unsafe.AsPointer(ref this), newStatus, previousStatus);
        }
    }
}
