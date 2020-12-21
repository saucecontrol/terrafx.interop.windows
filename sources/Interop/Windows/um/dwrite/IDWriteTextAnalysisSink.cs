// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5810CD44-0CA0-4701-B3FA-BEC5182AE4F6")]
    [NativeTypeName("struct IDWriteTextAnalysisSink : IUnknown")]
    public unsafe partial struct IDWriteTextAnalysisSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)(lpVtbl[1]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)(lpVtbl[2]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScriptAnalysis([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, DWRITE_SCRIPT_ANALYSIS*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, scriptAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineBreakpoints([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")] DWRITE_LINE_BREAKPOINT* lineBreakpoints)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, DWRITE_LINE_BREAKPOINT*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, lineBreakpoints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBidiLevel([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT8")] byte explicitLevel, [NativeTypeName("UINT8")] byte resolvedLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, byte, byte, int>)(lpVtbl[5]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, explicitLevel, resolvedLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteNumberSubstitution *")] IDWriteNumberSubstitution* numberSubstitution)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)(lpVtbl[6]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }
    }
}
