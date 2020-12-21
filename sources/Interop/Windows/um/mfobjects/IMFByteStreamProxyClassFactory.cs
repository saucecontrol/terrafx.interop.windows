// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6B43F84-5C0A-42E8-A44D-B1857A76992F")]
    [NativeTypeName("struct IMFByteStreamProxyClassFactory : IUnknown")]
    public unsafe partial struct IMFByteStreamProxyClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamProxyClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[1]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[2]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateByteStreamProxy([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamProxyClassFactory*, IMFByteStream*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[3]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), pByteStream, pAttributes, riid, ppvObject);
        }
    }
}
