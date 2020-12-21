// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C6C44BF-1DB6-435B-9249-E8CD10FDEC96")]
    [NativeTypeName("struct IMFPluginControl : IUnknown")]
    public unsafe partial struct IMFPluginControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFPluginControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint>)(lpVtbl[1]))((IMFPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint>)(lpVtbl[2]))((IMFPluginControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, ushort*, Guid*, int>)(lpVtbl[3]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("LPWSTR *")] ushort** selector, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, uint, ushort**, Guid*, int>)(lpVtbl[4]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, index, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] ushort* selector, [NativeTypeName("const CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, ushort*, Guid*, int>)(lpVtbl[5]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, Guid*, int>)(lpVtbl[6]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisabledByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, uint, Guid*, int>)(lpVtbl[7]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, index, clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("BOOL")] int disabled)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPluginControl*, uint, Guid*, int, int>)(lpVtbl[8]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, clsid, disabled);
        }
    }
}
