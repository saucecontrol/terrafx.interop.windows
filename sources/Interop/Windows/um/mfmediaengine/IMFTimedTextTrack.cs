// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8822C32D-654E-4233-BF21-D7F2E67D30D4")]
    [NativeTypeName("struct IMFTimedTextTrack : IUnknown")]
    public unsafe partial struct IMFTimedTextTrack
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)(lpVtbl[1]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)(lpVtbl[2]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetId()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)(lpVtbl[3]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLabel([NativeTypeName("LPWSTR *")] ushort** label)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[4]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLabel([NativeTypeName("LPCWSTR")] ushort* label)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, ushort*, int>)(lpVtbl[5]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguage([NativeTypeName("LPWSTR *")] ushort** language)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[6]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_TIMED_TEXT_TRACK_KIND GetTrackKind()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_KIND>)(lpVtbl[7]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsInBand()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, int>)(lpVtbl[8]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInBandMetadataTrackDispatchType([NativeTypeName("LPWSTR *")] ushort** dispatchType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[9]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), dispatchType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsActive()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, int>)(lpVtbl[10]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_TIMED_TEXT_ERROR_CODE GetErrorCode()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, MF_TIMED_TEXT_ERROR_CODE>)(lpVtbl[11]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtendedErrorCode()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, int>)(lpVtbl[12]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataFormat([NativeTypeName("GUID *")] Guid* format)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, int>)(lpVtbl[13]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_READY_STATE>)(lpVtbl[14]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCueList([NativeTypeName("IMFTimedTextCueList **")] IMFTimedTextCueList** cues)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)(lpVtbl[15]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), cues);
        }
    }
}
