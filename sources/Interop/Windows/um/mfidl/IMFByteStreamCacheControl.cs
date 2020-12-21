// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5042EA4-7A96-4A75-AA7B-2BE1EF7F88D5")]
    [NativeTypeName("struct IMFByteStreamCacheControl : IUnknown")]
    public unsafe partial struct IMFByteStreamCacheControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamCacheControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamCacheControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamCacheControl*, uint>)(lpVtbl[1]))((IMFByteStreamCacheControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamCacheControl*, uint>)(lpVtbl[2]))((IMFByteStreamCacheControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopBackgroundTransfer()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamCacheControl*, int>)(lpVtbl[3]))((IMFByteStreamCacheControl*)Unsafe.AsPointer(ref this));
        }
    }
}
