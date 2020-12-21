// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("38E33520-FCA1-4845-A27A-68B7C6AB3789")]
    [NativeTypeName("struct IMFExtendedCameraControl : IUnknown")]
    public unsafe partial struct IMFExtendedCameraControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, uint>)(lpVtbl[1]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, uint>)(lpVtbl[2]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONGLONG")]
        public ulong GetCapabilities()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, ulong>)(lpVtbl[3]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("ULONGLONG")] ulong ulFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, ulong, int>)(lpVtbl[4]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), ulFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONGLONG")]
        public ulong GetFlags()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, ulong>)(lpVtbl[5]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockPayload([NativeTypeName("BYTE **")] byte** ppPayload, [NativeTypeName("ULONG *")] uint* pulPayload)
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, byte**, uint*, int>)(lpVtbl[6]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), ppPayload, pulPayload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockPayload()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, int>)(lpVtbl[7]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitSettings()
        {
            return ((delegate* unmanaged[Stdcall]<IMFExtendedCameraControl*, int>)(lpVtbl[8]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
        }
    }
}
