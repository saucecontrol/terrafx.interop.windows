// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F3744D80-21F7-42EB-B35D-995BC72FC223")]
    [NativeTypeName("struct IDWriteFactory6 : IDWriteFactory5")]
    public unsafe partial struct IDWriteFactory6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)(lpVtbl[1]))((IDWriteFactory6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)(lpVtbl[2]))((IDWriteFactory6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, int, int>)(lpVtbl[3]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontCollection([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontCollectionLoader([NativeTypeName("IDWriteFontCollectionLoader *")] IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollectionLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, FILETIME*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), monitor, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFontFileLoader([NativeTypeName("IDWriteFontFileLoader *")] IDWriteFontFileLoader* fontFileLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat **")] IDWriteTextFormat** textFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTypography([NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), typography);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiInterop([NativeTypeName("IDWriteGdiInterop **")] IDWriteGdiInterop** gdiInterop)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gdiInterop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float maxWidth, [NativeTypeName("FLOAT")] float maxHeight, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("FLOAT")] float layoutWidth, [NativeTypeName("FLOAT")] float layoutHeight, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("IDWriteTextLayout **")] IDWriteTextLayout** textLayout)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, int, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEllipsisTrimmingSign([NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextAnalyzer([NativeTypeName("IDWriteTextAnalyzer **")] IDWriteTextAnalyzer** textAnalyzer)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), textAnalyzer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, int, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEudcFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, int, int>)(lpVtbl[24]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float enhancedContrastGrayscale, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, [NativeTypeName("IDWriteRenderingParams1 **")] IDWriteRenderingParams1** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFallbackBuilder([NativeTypeName("IDWriteFontFallbackBuilder **")] IDWriteFontFallbackBuilder** fontFallbackBuilder)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateColorGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldToDeviceTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator **")] IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams2 **")] IDWriteRenderingParams2** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, [NativeTypeName("IDWriteGlyphRunAnalysis **")] IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[31]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCustomRenderingParams([NativeTypeName("FLOAT")] float gamma, [NativeTypeName("FLOAT")] float enhancedContrast, [NativeTypeName("FLOAT")] float grayscaleEnhancedContrast, [NativeTypeName("FLOAT")] float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [NativeTypeName("IDWriteRenderingParams3 **")] IDWriteRenderingParams3** renderingParams)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3**, int>)(lpVtbl[32]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, FILETIME*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int>)(lpVtbl[33]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int>)(lpVtbl[34]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet**, int>)(lpVtbl[35]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontSetBuilder([NativeTypeName("IDWriteFontSetBuilder **")] IDWriteFontSetBuilder** fontSetBuilder)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder**, int>)(lpVtbl[36]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontCollectionFromFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)(lpVtbl[37]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("BOOL")] int includeDownloadableFonts, [NativeTypeName("IDWriteFontCollection1 **")] IDWriteFontCollection1** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, int, IDWriteFontCollection1**, int, int>)(lpVtbl[38]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontDownloadQueue([NativeTypeName("IDWriteFontDownloadQueue **")] IDWriteFontDownloadQueue** fontDownloadQueue)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontDownloadQueue**, int>)(lpVtbl[39]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontDownloadQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateColorGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("IDWriteColorGlyphRunEnumerator1 **")] IDWriteColorGlyphRunEnumerator1** colorLayers)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator1**, int>)(lpVtbl[40]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_POINT_2F, DWRITE_MATRIX*, D2D_POINT_2F*, int>)(lpVtbl[41]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_GLYPH_RUN*, D2D_POINT_2F, D2D_POINT_2F*, int>)(lpVtbl[42]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontSetBuilder([NativeTypeName("IDWriteFontSetBuilder1 **")] IDWriteFontSetBuilder1** fontSetBuilder)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder1**, int>)(lpVtbl[43]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInMemoryFontFileLoader([NativeTypeName("IDWriteInMemoryFontFileLoader **")] IDWriteInMemoryFontFileLoader** newLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteInMemoryFontFileLoader**, int>)(lpVtbl[44]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), newLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHttpFontFileLoader([NativeTypeName("const wchar_t *")] ushort* referrerUrl, [NativeTypeName("const wchar_t *")] ushort* extraHeaders, [NativeTypeName("IDWriteRemoteFontFileLoader **")] IDWriteRemoteFontFileLoader** newLoader)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int>)(lpVtbl[45]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), referrerUrl, extraHeaders, newLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_CONTAINER_TYPE AnalyzeContainerType([NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, DWRITE_CONTAINER_TYPE>)(lpVtbl[46]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fileData, fileDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnpackFontFile(DWRITE_CONTAINER_TYPE containerType, [NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** unpackedFontStream)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, DWRITE_CONTAINER_TYPE, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[47]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), containerType, fileData, fileDataSize, unpackedFontStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontFaceReference1 **")] IDWriteFontFaceReference1** fontFaceReference)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[48]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontResource([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, [NativeTypeName("IDWriteFontResource **")] IDWriteFontResource** fontResource)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)(lpVtbl[49]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontSet([NativeTypeName("BOOL")] int includeDownloadableFonts, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, int, IDWriteFontSet1**, int>)(lpVtbl[50]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSystemFontCollection([NativeTypeName("BOOL")] int includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [NativeTypeName("IDWriteFontCollection2 **")] IDWriteFontCollection2** fontCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, int, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int>)(lpVtbl[51]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontFamilyModel, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontCollectionFromFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [NativeTypeName("IDWriteFontCollection2 **")] IDWriteFontCollection2** fontCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int>)(lpVtbl[52]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet, fontFamilyModel, fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontSetBuilder([NativeTypeName("IDWriteFontSetBuilder2 **")] IDWriteFontSetBuilder2** fontSetBuilder)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder2**, int>)(lpVtbl[53]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("FLOAT")] float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("IDWriteTextFormat3 **")] IDWriteTextFormat3** textFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, IDWriteFontCollection*, DWRITE_FONT_AXIS_VALUE*, uint, float, ushort*, IDWriteTextFormat3**, int>)(lpVtbl[54]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontAxisValues, fontAxisValueCount, fontSize, localeName, textFormat);
        }
    }
}
