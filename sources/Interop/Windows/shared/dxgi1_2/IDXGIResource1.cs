// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30961379-4609-4A41-998E-54FE567EE0C1")]
    [NativeTypeName("struct IDXGIResource1 : IDXGIResource")]
    public unsafe partial struct IDXGIResource1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIResource1*, uint>)(lpVtbl[1]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIResource1*, uint>)(lpVtbl[2]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return ((delegate* stdcall<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedHandle([NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* stdcall<IDXGIResource1*, IntPtr*, int>)(lpVtbl[8]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pSharedHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage)
        {
            return ((delegate* stdcall<IDXGIResource1*, uint*, int>)(lpVtbl[9]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pUsage);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            return ((delegate* stdcall<IDXGIResource1*, uint, int>)(lpVtbl[10]))((IDXGIResource1*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvictionPriority([NativeTypeName("UINT *")] uint* pEvictionPriority)
        {
            return ((delegate* stdcall<IDXGIResource1*, uint*, int>)(lpVtbl[11]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pEvictionPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSubresourceSurface([NativeTypeName("UINT")] uint index, [NativeTypeName("IDXGISurface2 **")] IDXGISurface2** ppSurface)
        {
            return ((delegate* stdcall<IDXGIResource1*, uint, IDXGISurface2**, int>)(lpVtbl[12]))((IDXGIResource1*)Unsafe.AsPointer(ref this), index, ppSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* stdcall<IDXGIResource1*, SECURITY_ATTRIBUTES*, uint, ushort*, IntPtr*, int>)(lpVtbl[13]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
        }
    }
}
