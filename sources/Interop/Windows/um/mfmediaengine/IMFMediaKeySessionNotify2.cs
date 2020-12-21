// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3A9E92A-DA88-46B0-A110-6CF953026CB9")]
    [NativeTypeName("struct IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify")]
    public unsafe partial struct IMFMediaKeySessionNotify2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, uint>)(lpVtbl[1]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, uint>)(lpVtbl[2]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void KeyMessage([NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint cb)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, ushort*, byte*, uint, void>)(lpVtbl[3]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), destinationURL, message, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void KeyAdded()
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, void>)(lpVtbl[4]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void KeyError([NativeTypeName("USHORT")] ushort code, [NativeTypeName("DWORD")] uint systemCode)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, ushort, uint, void>)(lpVtbl[5]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), code, systemCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* pbMessage, [NativeTypeName("DWORD")] uint cbMessage)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, ushort*, byte*, uint, void>)(lpVtbl[6]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), eMessageType, destinationURL, pbMessage, cbMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void KeyStatusChange()
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify2*, void>)(lpVtbl[7]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
        }
    }
}
