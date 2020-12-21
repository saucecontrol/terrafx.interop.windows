// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56A34-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcProxyBuffer : IUnknown")]
    public unsafe partial struct IRpcProxyBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRpcProxyBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IRpcProxyBuffer*, uint>)(lpVtbl[1]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IRpcProxyBuffer*, uint>)(lpVtbl[2]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* pRpcChannelBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IRpcProxyBuffer*, IRpcChannelBuffer*, int>)(lpVtbl[3]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Disconnect()
        {
            ((delegate* unmanaged[Stdcall]<IRpcProxyBuffer*, void>)(lpVtbl[4]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
