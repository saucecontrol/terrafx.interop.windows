// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("19F68549-CA8A-4706-A4EF-481DBC95E12C")]
    [NativeTypeName("struct IMFCapturePhotoConfirmation : IUnknown")]
    public unsafe partial struct IMFCapturePhotoConfirmation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, Guid*, void**, int>)(lpVtbl[0]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, uint>)(lpVtbl[1]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, uint>)(lpVtbl[2]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPhotoConfirmationCallback([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pNotificationCallback)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, IMFAsyncCallback*, int>)(lpVtbl[3]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), pNotificationCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("GUID")] Guid subtype)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, Guid, int>)(lpVtbl[4]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), subtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("GUID *")] Guid* subtype)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCapturePhotoConfirmation*, Guid*, int>)(lpVtbl[5]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), subtype);
        }
    }
}
