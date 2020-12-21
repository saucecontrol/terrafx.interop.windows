// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF0B3D60-548F-101B-8E65-08002B2BD119")]
    [NativeTypeName("struct ISupportErrorInfo : IUnknown")]
    public unsafe partial struct ISupportErrorInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISupportErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISupportErrorInfo*, uint>)(lpVtbl[1]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISupportErrorInfo*, uint>)(lpVtbl[2]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InterfaceSupportsErrorInfo([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged[Stdcall]<ISupportErrorInfo*, Guid*, int>)(lpVtbl[3]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this), riid);
        }
    }
}
