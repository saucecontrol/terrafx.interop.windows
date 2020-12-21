// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8D22AFC-BC47-4BDF-9B04-787E49CE3F58")]
    [NativeTypeName("struct IMFTimedTextRegion : IUnknown")]
    public unsafe partial struct IMFTimedTextRegion
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)(lpVtbl[1]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)(lpVtbl[2]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("double *")] double* pX, [NativeTypeName("double *")] double* pY, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[4]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pX, pY, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("double *")] double* pWidth, [NativeTypeName("double *")] double* pHeight, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[5]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pWidth, pHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("MFARGB *")] MFARGB* bgColor)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, MFARGB*, int>)(lpVtbl[6]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), bgColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWritingMode([NativeTypeName("MF_TIMED_TEXT_WRITING_MODE *")] MF_TIMED_TEXT_WRITING_MODE* writingMode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, MF_TIMED_TEXT_WRITING_MODE*, int>)(lpVtbl[7]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), writingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayAlignment([NativeTypeName("MF_TIMED_TEXT_DISPLAY_ALIGNMENT *")] MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, MF_TIMED_TEXT_DISPLAY_ALIGNMENT*, int>)(lpVtbl[8]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), displayAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineHeight([NativeTypeName("double *")] double* pLineHeight, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[9]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pLineHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipOverflow([NativeTypeName("BOOL *")] int* clipOverflow)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)(lpVtbl[10]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), clipOverflow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPadding([NativeTypeName("double *")] double* before, [NativeTypeName("double *")] double* start, [NativeTypeName("double *")] double* after, [NativeTypeName("double *")] double* end, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[11]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), before, start, after, end, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrap([NativeTypeName("BOOL *")] int* wrap)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)(lpVtbl[12]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), wrap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZIndex([NativeTypeName("INT32 *")] int* zIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)(lpVtbl[13]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), zIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScrollMode([NativeTypeName("MF_TIMED_TEXT_SCROLL_MODE *")] MF_TIMED_TEXT_SCROLL_MODE* scrollMode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, MF_TIMED_TEXT_SCROLL_MODE*, int>)(lpVtbl[14]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), scrollMode);
        }
    }
}
