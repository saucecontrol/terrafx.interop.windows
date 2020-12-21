// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("725B77C7-CA9F-4FE5-9D72-9946BF9B3C70")]
    [NativeTypeName("struct IMFVideoCaptureSampleAllocator : IMFVideoSampleAllocator")]
    public unsafe partial struct IMFVideoCaptureSampleAllocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, uint>)(lpVtbl[1]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, uint>)(lpVtbl[2]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDirectXManager([NativeTypeName("IUnknown *")] IUnknown* pManager)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), pManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UninitializeSampleAllocator()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, int>)(lpVtbl[4]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, uint, IMFMediaType*, int>)(lpVtbl[5]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllocateSample([NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, IMFSample**, int>)(lpVtbl[6]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeCaptureSampleAllocator([NativeTypeName("DWORD")] uint cbSampleSize, [NativeTypeName("DWORD")] uint cbCaptureMetadataSize, [NativeTypeName("DWORD")] uint cbAlignment, [NativeTypeName("DWORD")] uint cMinimumSamples, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoCaptureSampleAllocator*, uint, uint, uint, uint, IMFAttributes*, IMFMediaType*, int>)(lpVtbl[7]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), cbSampleSize, cbCaptureMetadataSize, cbAlignment, cMinimumSamples, pAttributes, pMediaType);
        }
    }
}
