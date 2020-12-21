// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F03340-547D-101B-8E65-08002B2BD119")]
    [NativeTypeName("struct ICreateErrorInfo : IUnknown")]
    public unsafe partial struct ICreateErrorInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, uint>)(lpVtbl[1]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, uint>)(lpVtbl[2]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, Guid*, int>)(lpVtbl[3]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, ushort*, int>)(lpVtbl[4]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, ushort*, int>)(lpVtbl[5]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, ushort*, int>)(lpVtbl[6]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateErrorInfo*, uint, int>)(lpVtbl[7]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }
    }
}
