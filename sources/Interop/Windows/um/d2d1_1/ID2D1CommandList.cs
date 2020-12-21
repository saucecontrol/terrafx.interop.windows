// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4F34A19-2383-4D76-94F6-EC343657C3DC")]
    [NativeTypeName("struct ID2D1CommandList : ID2D1Image")]
    public unsafe partial struct ID2D1CommandList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1CommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, uint>)(lpVtbl[1]))((ID2D1CommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, uint>)(lpVtbl[2]))((ID2D1CommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1CommandList*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stream([NativeTypeName("ID2D1CommandSink *")] ID2D1CommandSink* sink)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, ID2D1CommandSink*, int>)(lpVtbl[4]))((ID2D1CommandList*)Unsafe.AsPointer(ref this), sink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1CommandList*, int>)(lpVtbl[5]))((ID2D1CommandList*)Unsafe.AsPointer(ref this));
        }
    }
}
