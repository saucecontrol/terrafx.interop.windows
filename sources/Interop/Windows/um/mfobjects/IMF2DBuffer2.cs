// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33AE5EA6-4316-436F-8DDD-D73D22F829EC")]
    [NativeTypeName("struct IMF2DBuffer2 : IMF2DBuffer")]
    public unsafe partial struct IMF2DBuffer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, Guid*, void**, int>)(lpVtbl[0]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, uint>)(lpVtbl[1]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, uint>)(lpVtbl[2]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock2D([NativeTypeName("BYTE **")] byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, byte**, int*, int>)(lpVtbl[3]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), ppbScanline0, plPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock2D()
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, int>)(lpVtbl[4]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanline0AndPitch([NativeTypeName("BYTE **")] byte** pbScanline0, [NativeTypeName("LONG *")] int* plPitch)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, byte**, int*, int>)(lpVtbl[5]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbScanline0, plPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsContiguousFormat([NativeTypeName("BOOL *")] int* pfIsContiguous)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, int*, int>)(lpVtbl[6]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pfIsContiguous);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContiguousLength([NativeTypeName("DWORD *")] uint* pcbLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, uint*, int>)(lpVtbl[7]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pcbLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContiguousCopyTo([NativeTypeName("BYTE *")] byte* pbDestBuffer, [NativeTypeName("DWORD")] uint cbDestBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, byte*, uint, int>)(lpVtbl[8]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbDestBuffer, cbDestBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContiguousCopyFrom([NativeTypeName("const BYTE *")] byte* pbSrcBuffer, [NativeTypeName("DWORD")] uint cbSrcBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, byte*, uint, int>)(lpVtbl[9]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbSrcBuffer, cbSrcBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock2DSize(MF2DBuffer_LockFlags lockFlags, [NativeTypeName("BYTE **")] byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch, [NativeTypeName("BYTE **")] byte** ppbBufferStart, [NativeTypeName("DWORD *")] uint* pcbBufferLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, MF2DBuffer_LockFlags, byte**, int*, byte**, uint*, int>)(lpVtbl[10]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), lockFlags, ppbScanline0, plPitch, ppbBufferStart, pcbBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Copy2DTo([NativeTypeName("IMF2DBuffer2 *")] IMF2DBuffer2* pDestBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMF2DBuffer2*, IMF2DBuffer2*, int>)(lpVtbl[11]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pDestBuffer);
        }
    }
}
