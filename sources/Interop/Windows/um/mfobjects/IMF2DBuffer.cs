// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7DC9D5F9-9ED9-44EC-9BBF-0600BB589FBB")]
    [NativeTypeName("struct IMF2DBuffer : IUnknown")]
    public unsafe partial struct IMF2DBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, uint>)(lpVtbl[1]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, uint>)(lpVtbl[2]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock2D([NativeTypeName("BYTE **")] byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, byte**, int*, int>)(lpVtbl[3]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), ppbScanline0, plPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock2D()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, int>)(lpVtbl[4]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanline0AndPitch([NativeTypeName("BYTE **")] byte** pbScanline0, [NativeTypeName("LONG *")] int* plPitch)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, byte**, int*, int>)(lpVtbl[5]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbScanline0, plPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsContiguousFormat([NativeTypeName("BOOL *")] int* pfIsContiguous)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, int*, int>)(lpVtbl[6]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pfIsContiguous);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContiguousLength([NativeTypeName("DWORD *")] uint* pcbLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, uint*, int>)(lpVtbl[7]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pcbLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContiguousCopyTo([NativeTypeName("BYTE *")] byte* pbDestBuffer, [NativeTypeName("DWORD")] uint cbDestBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, byte*, uint, int>)(lpVtbl[8]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbDestBuffer, cbDestBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContiguousCopyFrom([NativeTypeName("const BYTE *")] byte* pbSrcBuffer, [NativeTypeName("DWORD")] uint cbSrcBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer*, byte*, uint, int>)(lpVtbl[9]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbSrcBuffer, cbSrcBuffer);
        }
    }
}
