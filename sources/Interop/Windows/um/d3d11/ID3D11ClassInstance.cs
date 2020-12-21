// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6CD7FAA-B0B7-4A2F-9436-8662A65797CB")]
    [NativeTypeName("struct ID3D11ClassInstance : ID3D11DeviceChild")]
    public unsafe partial struct ID3D11ClassInstance
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, uint>)(lpVtbl[1]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, uint>)(lpVtbl[2]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetClassLinkage([NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)(lpVtbl[7]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc([NativeTypeName("D3D11_CLASS_INSTANCE_DESC *")] D3D11_CLASS_INSTANCE_DESC* pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, D3D11_CLASS_INSTANCE_DESC*, void>)(lpVtbl[8]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetInstanceName([NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, sbyte*, nuint*, void>)(lpVtbl[9]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pInstanceName, pBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTypeName([NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11ClassInstance*, sbyte*, nuint*, void>)(lpVtbl[10]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pTypeName, pBufferLength);
        }
    }
}
