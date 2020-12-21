// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3F675D5-6119-4F7F-A100-1D8B280F0EFB")]
    [NativeTypeName("struct IMFVideoProcessorControl : IUnknown")]
    public unsafe partial struct IMFVideoProcessorControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("MFARGB *")] MFARGB* pBorderColor)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceRectangle([NativeTypeName("RECT *")] RECT* pSrcRect)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationRectangle([NativeTypeName("RECT *")] RECT* pDstRect)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eMirror);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConstrictionSize([NativeTypeName("SIZE *")] SIZE* pConstrictionSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoProcessorControl*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }
    }
}
