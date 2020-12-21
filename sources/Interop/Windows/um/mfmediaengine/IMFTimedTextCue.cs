// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E560447-9A2B-43E1-A94C-B0AAABFBFBC9")]
    [NativeTypeName("struct IMFTimedTextCue : IUnknown")]
    public unsafe partial struct IMFTimedTextCue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)(lpVtbl[1]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)(lpVtbl[2]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetId()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)(lpVtbl[3]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOriginalId([NativeTypeName("LPWSTR *")] ushort** originalId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, ushort**, int>)(lpVtbl[4]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), originalId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_TIMED_TEXT_TRACK_KIND GetCueKind()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, MF_TIMED_TEXT_TRACK_KIND>)(lpVtbl[5]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetStartTime()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)(lpVtbl[6]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetDuration()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)(lpVtbl[7]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetTrackId()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)(lpVtbl[8]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("IMFTimedTextBinary **")] IMFTimedTextBinary** data)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextBinary**, int>)(lpVtbl[9]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegion([NativeTypeName("IMFTimedTextRegion **")] IMFTimedTextRegion** region)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextRegion**, int>)(lpVtbl[10]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), region);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyle([NativeTypeName("IMFTimedTextStyle **")] IMFTimedTextStyle** style)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextStyle**, int>)(lpVtbl[11]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), style);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLineCount()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)(lpVtbl[12]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLine([NativeTypeName("DWORD")] uint index, [NativeTypeName("IMFTimedTextFormattedText **")] IMFTimedTextFormattedText** line)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)(lpVtbl[13]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), index, line);
        }
    }
}
