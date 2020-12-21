// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("65219584-F9CB-4AE3-81F9-A28A6CA450D9")]
    [NativeTypeName("struct IAppServiceConnectionExtendedExecution : IUnknown")]
    public unsafe partial struct IAppServiceConnectionExtendedExecution
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAppServiceConnectionExtendedExecution*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAppServiceConnectionExtendedExecution*, uint>)(lpVtbl[1]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAppServiceConnectionExtendedExecution*, uint>)(lpVtbl[2]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenForExtendedExecutionAsync([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** operation)
        {
            return ((delegate* unmanaged[Stdcall]<IAppServiceConnectionExtendedExecution*, Guid*, void**, int>)(lpVtbl[3]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this), riid, operation);
        }
    }
}
