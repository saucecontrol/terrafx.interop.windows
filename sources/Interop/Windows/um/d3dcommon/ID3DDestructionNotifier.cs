// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    [NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID)
#else
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged[Stdcall]<void*, void> callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<ID3DDestructionNotifier*, delegate* unmanaged<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
#else
            return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, delegate* unmanaged[Stdcall]<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback([NativeTypeName("UINT")] uint callbackID)
        {
            return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
        }
    }
}
