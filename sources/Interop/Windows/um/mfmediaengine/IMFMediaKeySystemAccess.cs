// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AEC63FDA-7A97-4944-B35C-6C6DF8085CC3")]
    [NativeTypeName("struct IMFMediaKeySystemAccess : IUnknown")]
    public unsafe partial struct IMFMediaKeySystemAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)(lpVtbl[1]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)(lpVtbl[2]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaKeys([NativeTypeName("IPropertyStore *")] IPropertyStore* pCdmCustomConfig, [NativeTypeName("IMFMediaKeys2 **")] IMFMediaKeys2** ppKeys)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)(lpVtbl[3]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), pCdmCustomConfig, ppKeys);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedConfiguration([NativeTypeName("IPropertyStore **")] IPropertyStore** ppSupportedConfiguration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore**, int>)(lpVtbl[4]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), ppSupportedConfiguration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** pKeySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, ushort**, int>)(lpVtbl[5]))((IMFMediaKeySystemAccess*)Unsafe.AsPointer(ref this), pKeySystem);
        }
    }
}
