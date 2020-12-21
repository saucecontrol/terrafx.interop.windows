// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A792CDBE-C374-4E89-8335-278E7B9956A4")]
    [NativeTypeName("struct IMFVideoSampleAllocatorNotify : IUnknown")]
    public unsafe partial struct IMFVideoSampleAllocatorNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotify*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotify*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotify*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
