// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9EDA967-F50E-4A33-B358-206F6EF3086D")]
    [NativeTypeName("struct IBindHttpSecurity : IUnknown")]
    public unsafe partial struct IBindHttpSecurity
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IBindHttpSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IBindHttpSecurity*, uint>)(lpVtbl[1]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IBindHttpSecurity*, uint>)(lpVtbl[2]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIgnoreCertMask([NativeTypeName("DWORD *")] uint* pdwIgnoreCertMask)
        {
            return ((delegate* unmanaged[Stdcall]<IBindHttpSecurity*, uint*, int>)(lpVtbl[3]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this), pdwIgnoreCertMask);
        }
    }
}
