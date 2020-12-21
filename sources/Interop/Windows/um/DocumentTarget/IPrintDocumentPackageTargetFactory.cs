// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2959BF7-B31B-4A3D-9600-712EB1335BA4")]
    [NativeTypeName("struct IPrintDocumentPackageTargetFactory : IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPrintDocumentPackageTargetFactory*, uint>)(lpVtbl[1]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPrintDocumentPackageTargetFactory*, uint>)(lpVtbl[2]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, [NativeTypeName("IStream *")] IStream* jobOutputStream, [NativeTypeName("IStream *")] IStream* jobPrintTicketStream, [NativeTypeName("IPrintDocumentPackageTarget **")] IPrintDocumentPackageTarget** docPackageTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IPrintDocumentPackageTargetFactory*, ushort*, ushort*, IStream*, IStream*, IPrintDocumentPackageTarget**, int>)(lpVtbl[3]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }
    }
}
