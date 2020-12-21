// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6857A76-2E3E-4FDD-BFF4-5D2BA10FB453")]
    [NativeTypeName("struct IDMLCommandRecorder : IDMLDeviceChild")]
    public unsafe partial struct IDMLCommandRecorder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[0]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, uint>)(lpVtbl[1]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, uint>)(lpVtbl[2]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, ushort*, int>)(lpVtbl[6]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[7]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RecordDispatch([NativeTypeName("ID3D12CommandList *")] ID3D12CommandList* commandList, [NativeTypeName("IDMLDispatchable *")] IDMLDispatchable* dispatchable, [NativeTypeName("IDMLBindingTable *")] IDMLBindingTable* bindings)
        {
            ((delegate* unmanaged[Stdcall]<IDMLCommandRecorder*, ID3D12CommandList*, IDMLDispatchable*, IDMLBindingTable*, void>)(lpVtbl[8]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), commandList, dispatchable, bindings);
        }
    }
}
