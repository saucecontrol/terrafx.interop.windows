// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A853D1F4-E2A0-4303-9EDC-F1A68EE43136")]
    [NativeTypeName("struct IMFContentDecryptionModuleAccess : IUnknown")]
    public unsafe partial struct IMFContentDecryptionModuleAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContentDecryptionModule([NativeTypeName("IPropertyStore *")] IPropertyStore* contentDecryptionModuleProperties, [NativeTypeName("IMFContentDecryptionModule **")] IMFContentDecryptionModule** contentDecryptionModule)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, IPropertyStore*, IMFContentDecryptionModule**, int>)(lpVtbl[3]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), contentDecryptionModuleProperties, contentDecryptionModule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConfiguration([NativeTypeName("IPropertyStore **")] IPropertyStore** configuration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, IPropertyStore**, int>)(lpVtbl[4]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeySystem([NativeTypeName("LPWSTR *")] ushort** keySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFContentDecryptionModuleAccess*, ushort**, int>)(lpVtbl[5]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), keySystem);
        }
    }
}
