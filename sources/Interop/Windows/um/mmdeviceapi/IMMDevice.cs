// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D666063F-1587-4E43-81F1-B948E807363F")]
    [NativeTypeName("struct IMMDevice : IUnknown")]
    public unsafe partial struct IMMDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, Guid*, void**, int>)(lpVtbl[0]))((IMMDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, uint>)(lpVtbl[1]))((IMMDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, uint>)(lpVtbl[2]))((IMMDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pActivationParams, [NativeTypeName("void **")] void** ppInterface)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, Guid*, uint, PROPVARIANT*, void**, int>)(lpVtbl[3]))((IMMDevice*)Unsafe.AsPointer(ref this), iid, dwClsCtx, pActivationParams, ppInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, [NativeTypeName("IPropertyStore **")] IPropertyStore** ppProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, uint, IPropertyStore**, int>)(lpVtbl[4]))((IMMDevice*)Unsafe.AsPointer(ref this), stgmAccess, ppProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("LPWSTR *")] ushort** ppstrId)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, ushort**, int>)(lpVtbl[5]))((IMMDevice*)Unsafe.AsPointer(ref this), ppstrId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return ((delegate* unmanaged[Stdcall]<IMMDevice*, uint*, int>)(lpVtbl[6]))((IMMDevice*)Unsafe.AsPointer(ref this), pdwState);
        }
    }
}
