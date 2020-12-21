// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13343-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMVideoCompression : IUnknown")]
    public unsafe partial struct IAMVideoCompression
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, uint>)(lpVtbl[1]))((IAMVideoCompression*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, uint>)(lpVtbl[2]))((IAMVideoCompression*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_KeyFrameRate([NativeTypeName("long")] int KeyFrameRate)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int, int>)(lpVtbl[3]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), KeyFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyFrameRate([NativeTypeName("long *")] int* pKeyFrameRate)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int*, int>)(lpVtbl[4]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), pKeyFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PFramesPerKeyFrame([NativeTypeName("long")] int PFramesPerKeyFrame)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int, int>)(lpVtbl[5]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), PFramesPerKeyFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PFramesPerKeyFrame([NativeTypeName("long *")] int* pPFramesPerKeyFrame)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int*, int>)(lpVtbl[6]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), pPFramesPerKeyFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Quality(double Quality)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, double, int>)(lpVtbl[7]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), Quality);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Quality([NativeTypeName("double *")] double* pQuality)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, double*, int>)(lpVtbl[8]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), pQuality);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WindowSize([NativeTypeName("DWORDLONG")] ulong WindowSize)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, ulong, int>)(lpVtbl[9]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), WindowSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowSize([NativeTypeName("DWORDLONG *")] ulong* pWindowSize)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, ulong*, int>)(lpVtbl[10]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), pWindowSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("LPWSTR")] ushort* pszVersion, [NativeTypeName("int *")] int* pcbVersion, [NativeTypeName("LPWSTR")] ushort* pszDescription, [NativeTypeName("int *")] int* pcbDescription, [NativeTypeName("long *")] int* pDefaultKeyFrameRate, [NativeTypeName("long *")] int* pDefaultPFramesPerKey, [NativeTypeName("double *")] double* pDefaultQuality, [NativeTypeName("long *")] int* pCapabilities)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, ushort*, int*, ushort*, int*, int*, int*, double*, int*, int>)(lpVtbl[11]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), pszVersion, pcbVersion, pszDescription, pcbDescription, pDefaultKeyFrameRate, pDefaultPFramesPerKey, pDefaultQuality, pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OverrideKeyFrame([NativeTypeName("long")] int FrameNumber)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int, int>)(lpVtbl[12]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), FrameNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OverrideFrameSize([NativeTypeName("long")] int FrameNumber, [NativeTypeName("long")] int Size)
        {
            return ((delegate* unmanaged[Stdcall]<IAMVideoCompression*, int, int, int>)(lpVtbl[13]))((IAMVideoCompression*)Unsafe.AsPointer(ref this), FrameNumber, Size);
        }
    }
}
