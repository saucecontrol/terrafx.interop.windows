// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73881-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IAMStreamControl : IUnknown")]
    public unsafe partial struct IAMStreamControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMStreamControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, uint>)(lpVtbl[1]))((IAMStreamControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, uint>)(lpVtbl[2]))((IAMStreamControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartAt([NativeTypeName("const REFERENCE_TIME *")] long* ptStart, [NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, long*, uint, int>)(lpVtbl[3]))((IAMStreamControl*)Unsafe.AsPointer(ref this), ptStart, dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopAt([NativeTypeName("const REFERENCE_TIME *")] long* ptStop, [NativeTypeName("BOOL")] int bSendExtra, [NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, long*, int, uint, int>)(lpVtbl[4]))((IAMStreamControl*)Unsafe.AsPointer(ref this), ptStop, bSendExtra, dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("AM_STREAM_INFO *")] AM_STREAM_INFO* pInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStreamControl*, AM_STREAM_INFO*, int>)(lpVtbl[5]))((IAMStreamControl*)Unsafe.AsPointer(ref this), pInfo);
        }
    }
}
