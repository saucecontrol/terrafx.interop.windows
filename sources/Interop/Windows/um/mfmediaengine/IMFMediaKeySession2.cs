// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9707E05-6D55-4636-B185-3DE21210BD75")]
    [NativeTypeName("struct IMFMediaKeySession2 : IMFMediaKeySession")]
    public unsafe partial struct IMFMediaKeySession2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)(lpVtbl[1]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)(lpVtbl[2]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("USHORT *")] ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)(lpVtbl[3]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), code, systemCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), keySystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort**, int>)(lpVtbl[5]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), sessionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const BYTE *")] byte* key, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)(lpVtbl[6]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), key, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)(lpVtbl[7]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyStatuses([NativeTypeName("MFMediaKeyStatus **")] MFMediaKeyStatus** pKeyStatusesArray, [NativeTypeName("UINT *")] uint* puSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)(lpVtbl[8]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), pKeyStatusesArray, puSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("BSTR")] ushort* bstrSessionId, [NativeTypeName("BOOL *")] int* pfLoaded)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, int*, int>)(lpVtbl[9]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), bstrSessionId, pfLoaded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GenerateRequest([NativeTypeName("BSTR")] ushort* initDataType, [NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, byte*, uint, int>)(lpVtbl[10]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), initDataType, pbInitData, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Expiration([NativeTypeName("double *")] double* dblExpiration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, double*, int>)(lpVtbl[11]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), dblExpiration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)(lpVtbl[12]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)(lpVtbl[13]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
        }
    }
}
