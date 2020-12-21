// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AD-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IResourceConsumer : IUnknown")]
    public unsafe partial struct IResourceConsumer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceConsumer*, Guid*, void**, int>)(lpVtbl[0]))((IResourceConsumer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IResourceConsumer*, uint>)(lpVtbl[1]))((IResourceConsumer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IResourceConsumer*, uint>)(lpVtbl[2]))((IResourceConsumer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireResource([NativeTypeName("LONG")] int idResource)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceConsumer*, int, int>)(lpVtbl[3]))((IResourceConsumer*)Unsafe.AsPointer(ref this), idResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseResource([NativeTypeName("LONG")] int idResource)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceConsumer*, int, int>)(lpVtbl[4]))((IResourceConsumer*)Unsafe.AsPointer(ref this), idResource);
        }
    }
}
