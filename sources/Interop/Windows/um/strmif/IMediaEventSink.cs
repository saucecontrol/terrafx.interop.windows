// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A2-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaEventSink : IUnknown")]
    public unsafe partial struct IMediaEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventSink*, uint>)(lpVtbl[1]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventSink*, uint>)(lpVtbl[2]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("long")] int EventCode, [NativeTypeName("LONG_PTR")] nint EventParam1, [NativeTypeName("LONG_PTR")] nint EventParam2)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventSink*, int, nint, nint, int>)(lpVtbl[3]))((IMediaEventSink*)Unsafe.AsPointer(ref this), EventCode, EventParam1, EventParam2);
        }
    }
}
