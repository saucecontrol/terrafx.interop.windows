// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("23FF334C-442C-445F-BCCC-EDC438AA11E2")]
    [NativeTypeName("struct IMFTimedTextTrackList : IUnknown")]
    public unsafe partial struct IMFTimedTextTrackList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)(lpVtbl[1]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)(lpVtbl[2]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)(lpVtbl[3]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrack([NativeTypeName("DWORD")] uint index, [NativeTypeName("IMFTimedTextTrack **")] IMFTimedTextTrack** track)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)(lpVtbl[4]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), index, track);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrackById([NativeTypeName("DWORD")] uint trackId, [NativeTypeName("IMFTimedTextTrack **")] IMFTimedTextTrack** track)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)(lpVtbl[5]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), trackId, track);
        }
    }
}
