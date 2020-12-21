// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/robuffer.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("905A0FEF-BC53-11DF-8C49-001E4FC686DA")]
    [NativeTypeName("struct IBufferByteAccess : IUnknown")]
    public unsafe partial struct IBufferByteAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IBufferByteAccess*, Guid*, void**, int>)(lpVtbl[0]))((IBufferByteAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IBufferByteAccess*, uint>)(lpVtbl[1]))((IBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IBufferByteAccess*, uint>)(lpVtbl[2]))((IBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Buffer([NativeTypeName("byte **")] byte** value)
        {
            return ((delegate* unmanaged[Stdcall]<IBufferByteAccess*, byte**, int>)(lpVtbl[3]))((IBufferByteAccess*)Unsafe.AsPointer(ref this), value);
        }
    }
}
