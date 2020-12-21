// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E1D600A-C9F3-442D-8C51-A42D2D49452F")]
    [NativeTypeName("struct IMFMediaSourcePresentationProvider : IUnknown")]
    public unsafe partial struct IMFMediaSourcePresentationProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourcePresentationProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourcePresentationProvider*, uint>)(lpVtbl[1]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourcePresentationProvider*, uint>)(lpVtbl[2]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ForceEndOfPresentation([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourcePresentationProvider*, IMFPresentationDescriptor*, int>)(lpVtbl[3]))((IMFMediaSourcePresentationProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor);
        }
    }
}
