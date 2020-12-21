// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
    [NativeTypeName("struct IDXCoreAdapterList : IUnknown")]
    public unsafe partial struct IDXCoreAdapterList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, uint>)(lpVtbl[1]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, uint>)(lpVtbl[2]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, uint, Guid*, void**, int>)(lpVtbl[3]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), index, riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, uint>)(lpVtbl[4]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsStale()
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, byte>)(lpVtbl[5]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, Guid*, void**, int>)(lpVtbl[6]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, uint, DXCoreAdapterPreference*, int>)(lpVtbl[7]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), numPreferences, preferences);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
        {
            return ((delegate* unmanaged[Stdcall]<IDXCoreAdapterList*, DXCoreAdapterPreference, byte>)(lpVtbl[8]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), preference) != 0;
        }
    }
}
