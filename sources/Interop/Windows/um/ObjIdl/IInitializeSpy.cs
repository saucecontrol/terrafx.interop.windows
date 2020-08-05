// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000034-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IInitializeSpy : IUnknown")]
    public unsafe partial struct IInitializeSpy
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInitializeSpy*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInitializeSpy*, uint>)(lpVtbl[1]))((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInitializeSpy*, uint>)(lpVtbl[2]))((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PreInitialize([NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return ((delegate* stdcall<IInitializeSpy*, uint, uint, int>)(lpVtbl[3]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCoInit, dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostInitialize([NativeTypeName("HRESULT")] int hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return ((delegate* stdcall<IInitializeSpy*, int, uint, uint, int>)(lpVtbl[4]))((IInitializeSpy*)Unsafe.AsPointer(ref this), hrCoInit, dwCoInit, dwNewThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return ((delegate* stdcall<IInitializeSpy*, uint, int>)(lpVtbl[5]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return ((delegate* stdcall<IInitializeSpy*, uint, int>)(lpVtbl[6]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwNewThreadAptRefs);
        }
    }
}
