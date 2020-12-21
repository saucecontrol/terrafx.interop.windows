// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C081FE77-2FD1-41AC-A5A3-34983C4BA61A")]
    [NativeTypeName("struct IDWriteFontFaceReference1 : IDWriteFontFaceReference")]
    public unsafe partial struct IDWriteFontFaceReference1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[1]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[2]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)(lpVtbl[3]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int>)(lpVtbl[4]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, int>)(lpVtbl[5]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[6]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[7]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetLocalFileSize()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)(lpVtbl[9]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetFileSize()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)(lpVtbl[10]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileTime([NativeTypeName("FILETIME *")] FILETIME* lastWriteTime)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FILETIME*, int>)(lpVtbl[11]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, DWRITE_LOCALITY>)(lpVtbl[12]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnqueueFontDownloadRequest()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, int>)(lpVtbl[13]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[14]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), characters, characterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)(lpVtbl[15]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong, ulong, int>)(lpVtbl[16]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace5**, int>)(lpVtbl[17]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)(lpVtbl[18]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[19]))((IDWriteFontFaceReference1*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }
    }
}
