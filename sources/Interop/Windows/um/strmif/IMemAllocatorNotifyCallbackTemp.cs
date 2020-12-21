// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92980B30-C1DE-11D2-ABF5-00A0C905F375")]
    [NativeTypeName("struct IMemAllocatorNotifyCallbackTemp : IUnknown")]
    public unsafe partial struct IMemAllocatorNotifyCallbackTemp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMemAllocatorNotifyCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease()
        {
            return ((delegate* unmanaged[Stdcall]<IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[3]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }
    }
}
