// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Print3DManagerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CA31010-1484-4587-B26B-DDDF9F9CAECD")]
    [NativeTypeName("struct IPrinting3DManagerInterop : IInspectable")]
    public unsafe partial struct IPrinting3DManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, uint>)(lpVtbl[1]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, uint>)(lpVtbl[2]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** printManager)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, printManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowPrintUIForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncOperation)
        {
            return ((delegate* unmanaged[Stdcall]<IPrinting3DManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncOperation);
        }
    }
}
