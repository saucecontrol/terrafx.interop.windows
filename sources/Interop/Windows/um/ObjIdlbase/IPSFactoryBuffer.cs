// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F569D0-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IPSFactoryBuffer : IUnknown")]
    public unsafe partial struct IPSFactoryBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPSFactoryBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPSFactoryBuffer*, uint>)(lpVtbl[1]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPSFactoryBuffer*, uint>)(lpVtbl[2]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateProxy([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IRpcProxyBuffer **")] IRpcProxyBuffer** ppProxy, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPSFactoryBuffer*, IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)(lpVtbl[3]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppProxy, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStub([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pUnkServer, [NativeTypeName("IRpcStubBuffer **")] IRpcStubBuffer** ppStub)
        {
            return ((delegate* unmanaged[Stdcall]<IPSFactoryBuffer*, Guid*, IUnknown*, IRpcStubBuffer**, int>)(lpVtbl[4]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), riid, pUnkServer, ppStub);
        }
    }
}
