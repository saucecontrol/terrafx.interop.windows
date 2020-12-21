// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/MemoryBuffer.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B0D3235-4DBA-4D44-865E-8F1D0E4FD04D")]
    [NativeTypeName("struct IMemoryBufferByteAccess : IUnknown")]
    public unsafe partial struct IMemoryBufferByteAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMemoryBufferByteAccess*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMemoryBufferByteAccess*, uint>)(lpVtbl[1]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMemoryBufferByteAccess*, uint>)(lpVtbl[2]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** value, [NativeTypeName("UINT32 *")] uint* capacity)
        {
            return ((delegate* unmanaged[Stdcall]<IMemoryBufferByteAccess*, byte**, uint*, int>)(lpVtbl[3]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this), value, capacity);
        }
    }
}
