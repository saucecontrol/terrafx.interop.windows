// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0C012799-1B61-4C10-BDA9-04445BE5F561")]
    [NativeTypeName("struct IMFDLNASinkInit : IUnknown")]
    public unsafe partial struct IMFDLNASinkInit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDLNASinkInit*, Guid*, void**, int>)(lpVtbl[0]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDLNASinkInit*, uint>)(lpVtbl[1]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDLNASinkInit*, uint>)(lpVtbl[2]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("BOOL")] int fPal)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDLNASinkInit*, IMFByteStream*, int, int>)(lpVtbl[3]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this), pByteStream, fPal);
        }
    }
}
