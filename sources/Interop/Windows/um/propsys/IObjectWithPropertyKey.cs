// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC0CA0A7-C316-4FD2-9031-3E628E6D4F23")]
    [NativeTypeName("struct IObjectWithPropertyKey : IUnknown")]
    public unsafe partial struct IObjectWithPropertyKey
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IObjectWithPropertyKey*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IObjectWithPropertyKey*, uint>)(lpVtbl[1]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IObjectWithPropertyKey*, uint>)(lpVtbl[2]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged[Stdcall]<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[3]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged[Stdcall]<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[4]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), pkey);
        }
    }
}
