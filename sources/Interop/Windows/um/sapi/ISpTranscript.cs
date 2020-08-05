// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("10F63BCE-201A-11D3-AC70-00C04F8EE6C0")]
    [NativeTypeName("struct ISpTranscript : IUnknown")]
    public unsafe partial struct ISpTranscript
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpTranscript*, Guid*, void**, int>)(lpVtbl[0]))((ISpTranscript*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpTranscript*, uint>)(lpVtbl[1]))((ISpTranscript*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpTranscript*, uint>)(lpVtbl[2]))((ISpTranscript*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTranscript([NativeTypeName("LPWSTR *")] ushort** ppszTranscript)
        {
            return ((delegate* stdcall<ISpTranscript*, ushort**, int>)(lpVtbl[3]))((ISpTranscript*)Unsafe.AsPointer(ref this), ppszTranscript);
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendTranscript([NativeTypeName("LPCWSTR")] ushort* pszTranscript)
        {
            return ((delegate* stdcall<ISpTranscript*, ushort*, int>)(lpVtbl[4]))((ISpTranscript*)Unsafe.AsPointer(ref this), pszTranscript);
        }
    }
}
