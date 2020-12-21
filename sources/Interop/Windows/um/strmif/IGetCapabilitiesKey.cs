// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8809222-07BB-48EA-951C-33158100625B")]
    [NativeTypeName("struct IGetCapabilitiesKey : IUnknown")]
    public unsafe partial struct IGetCapabilitiesKey
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IGetCapabilitiesKey*, Guid*, void**, int>)(lpVtbl[0]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IGetCapabilitiesKey*, uint>)(lpVtbl[1]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IGetCapabilitiesKey*, uint>)(lpVtbl[2]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilitiesKey([NativeTypeName("HKEY *")] IntPtr* pHKey)
        {
            return ((delegate* unmanaged[Stdcall]<IGetCapabilitiesKey*, IntPtr*, int>)(lpVtbl[3]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), pHKey);
        }
    }
}
