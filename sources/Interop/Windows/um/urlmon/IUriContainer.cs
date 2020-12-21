// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A158A630-ED6F-45FB-B987-F68676F57752")]
    [NativeTypeName("struct IUriContainer : IUnknown")]
    public unsafe partial struct IUriContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUriContainer*, Guid*, void**, int>)(lpVtbl[0]))((IUriContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUriContainer*, uint>)(lpVtbl[1]))((IUriContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUriContainer*, uint>)(lpVtbl[2]))((IUriContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIUri([NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return ((delegate* unmanaged[Stdcall]<IUriContainer*, IUri**, int>)(lpVtbl[3]))((IUriContainer*)Unsafe.AsPointer(ref this), ppIUri);
        }
    }
}
