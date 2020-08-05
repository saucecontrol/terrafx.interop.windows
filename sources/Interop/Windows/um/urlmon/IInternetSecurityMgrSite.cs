// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9ED-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSecurityMgrSite : IUnknown")]
    public unsafe partial struct IInternetSecurityMgrSite
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetSecurityMgrSite*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetSecurityMgrSite*, uint>)(lpVtbl[1]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetSecurityMgrSite*, uint>)(lpVtbl[2]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* stdcall<IInternetSecurityMgrSite*, IntPtr*, int>)(lpVtbl[3]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IInternetSecurityMgrSite*, int, int>)(lpVtbl[4]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), fEnable);
        }
    }
}
