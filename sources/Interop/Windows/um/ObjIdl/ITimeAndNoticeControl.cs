// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC0BF6AE-8878-11D1-83E9-00C04FC2C6D4")]
    [NativeTypeName("struct ITimeAndNoticeControl : IUnknown")]
    public unsafe partial struct ITimeAndNoticeControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ITimeAndNoticeControl*, Guid*, void**, int>)(lpVtbl[0]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ITimeAndNoticeControl*, uint>)(lpVtbl[1]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ITimeAndNoticeControl*, uint>)(lpVtbl[2]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SuppressChanges([NativeTypeName("DWORD")] uint res1, [NativeTypeName("DWORD")] uint res2)
        {
            return ((delegate* unmanaged[Stdcall]<ITimeAndNoticeControl*, uint, uint, int>)(lpVtbl[3]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this), res1, res2);
        }
    }
}
