// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("78EE5945-C36E-4B13-A669-005DD11C0F06")]
    [NativeTypeName("struct IDXCoreAdapterFactory : IUnknown")]
    public unsafe partial struct IDXCoreAdapterFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, uint>)(lpVtbl[1]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, uint>)(lpVtbl[2]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapterList)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, uint, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, LUID*, Guid*, void**, int>)(lpVtbl[4]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, DXCoreNotificationType, byte>)(lpVtbl[5]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), notificationType) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int RegisterEventNotification([NativeTypeName("IUnknown *")] IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void> callbackFunction, [NativeTypeName("void *")] void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
#else
        public int RegisterEventNotification([NativeTypeName("IUnknown *")] IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged[Stdcall]<DXCoreNotificationType, IUnknown*, void*, void> callbackFunction, [NativeTypeName("void *")] void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<IDXCoreAdapterFactory*, IUnknown*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int>)(lpVtbl[6]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
#else
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, IUnknown*, DXCoreNotificationType, delegate* unmanaged[Stdcall]<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int>)(lpVtbl[6]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterFactory*, uint, int>)(lpVtbl[7]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), eventCookie);
        }
    }
}
