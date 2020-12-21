// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3E8C4BE1-A8C2-4528-90DE-2851BDE5FEAD")]
    [NativeTypeName("struct IMFSensorActivityReport : IUnknown")]
    public unsafe partial struct IMFSensorActivityReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, uint>)(lpVtbl[1]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, uint>)(lpVtbl[2]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("LPWSTR")] ushort* FriendlyName, [NativeTypeName("ULONG")] uint cchFriendlyName, [NativeTypeName("ULONG *")] uint* pcchWritten)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, ushort*, uint, uint*, int>)(lpVtbl[3]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), FriendlyName, cchFriendlyName, pcchWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("ULONG")] uint cchSymbolicLink, [NativeTypeName("ULONG *")] uint* pcchWritten)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, ushort*, uint, uint*, int>)(lpVtbl[4]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), SymbolicLink, cchSymbolicLink, pcchWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcessCount([NativeTypeName("ULONG *")] uint* pcCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, uint*, int>)(lpVtbl[5]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcessActivity([NativeTypeName("ULONG")] uint Index, [NativeTypeName("IMFSensorProcessActivity **")] IMFSensorProcessActivity** ppProcessActivity)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivityReport*, uint, IMFSensorProcessActivity**, int>)(lpVtbl[6]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), Index, ppProcessActivity);
        }
    }
}
