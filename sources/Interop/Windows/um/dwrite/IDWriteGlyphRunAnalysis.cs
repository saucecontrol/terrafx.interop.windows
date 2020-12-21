// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D97DBF7-E085-42D4-81E3-6A883BDED118")]
    [NativeTypeName("struct IDWriteGlyphRunAnalysis : IUnknown")]
    public unsafe partial struct IDWriteGlyphRunAnalysis
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[1]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[2]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("RECT *")] RECT* textureBounds)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, int>)(lpVtbl[3]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("const RECT *")] RECT* textureBounds, [NativeTypeName("BYTE *")] byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, byte*, uint, int>)(lpVtbl[4]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds, alphaValues, bufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBlendParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("FLOAT *")] float* blendGamma, [NativeTypeName("FLOAT *")] float* blendEnhancedContrast, [NativeTypeName("FLOAT *")] float* blendClearTypeLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)(lpVtbl[5]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        }
    }
}
