// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C004F646-BE2C-48F3-93A2-A0983EBA1108")]
    [NativeTypeName("struct IMFPMPClientApp : IUnknown")]
    public unsafe partial struct IMFPMPClientApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClientApp*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClientApp*, uint>)(lpVtbl[1]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClientApp*, uint>)(lpVtbl[2]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPMPHost([NativeTypeName("IMFPMPHostApp *")] IMFPMPHostApp* pPMPHost)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClientApp*, IMFPMPHostApp*, int>)(lpVtbl[3]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this), pPMPHost);
        }
    }
}
