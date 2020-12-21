// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7EC4B1BD-43FB-4763-85D2-64FCB5C5F4CB")]
    [NativeTypeName("struct IMFContentDecryptorContext : IUnknown")]
    public unsafe partial struct IMFContentDecryptorContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptorContext*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptorContext*, uint>)(lpVtbl[1]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptorContext*, uint>)(lpVtbl[2]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeHardwareKey([NativeTypeName("UINT")] uint InputPrivateDataByteCount, [NativeTypeName("const void *")] void* InputPrivateData, [NativeTypeName("UINT64 *")] ulong* OutputPrivateData)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptorContext*, uint, void*, ulong*, int>)(lpVtbl[3]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), InputPrivateDataByteCount, InputPrivateData, OutputPrivateData);
        }
    }
}
