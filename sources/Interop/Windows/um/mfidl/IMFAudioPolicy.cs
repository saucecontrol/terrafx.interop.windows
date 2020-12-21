// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
    [NativeTypeName("struct IMFAudioPolicy : IUnknown")]
    public unsafe partial struct IMFAudioPolicy
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, uint>)(lpVtbl[1]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, uint>)(lpVtbl[2]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, Guid*, int>)(lpVtbl[3]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), rguidClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingParam([NativeTypeName("GUID *")] Guid* pguidClass)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, Guid*, int>)(lpVtbl[4]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pguidClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, ushort*, int>)(lpVtbl[5]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, ushort**, int>)(lpVtbl[6]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, ushort*, int>)(lpVtbl[7]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioPolicy*, ushort**, int>)(lpVtbl[8]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
        }
    }
}
