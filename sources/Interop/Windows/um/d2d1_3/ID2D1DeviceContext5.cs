// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ALPHA_MODE;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION;
using static TerraFX.Interop.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.D2D1_COMPOSITE_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_GAMMA;
using static TerraFX.Interop.D2D1_IMAGE_SOURCE_LOADING_OPTIONS;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_SPRITE_OPTIONS;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("7836D248-68CC-4DF6-B9E8-DE991BF62EB7")]
    [NativeTypeName("struct ID2D1DeviceContext5 : ID2D1DeviceContext4")]
    public unsafe partial struct ID2D1DeviceContext5
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const D2D1_BITMAP_PROPERTIES &")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES &")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return CreateSolidColorBrush(color, null, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return CreateGradientStopCollection(gradientStops, gradientStopsCount, D2D1_GAMMA_2_2, D2D1_EXTEND_MODE_CLAMP, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES &")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES &")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(null, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(&size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(null, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES &")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 &")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ID2D1Image* output = null;

            effect->GetOutput(&output);
            DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
            output->Release();
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset)
        {
            DrawGdiMetafile(gdiMetafile, &targetOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, loadingOptions, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        public void DrawSpriteBatch([NativeTypeName("ID2D1SpriteBatch *")] ID2D1SpriteBatch* spriteBatch, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE)
        {
            DrawSpriteBatch(spriteBatch, 0, spriteBatch->GetSpriteCount(), bitmap, interpolationMode, spriteOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)(lpVtbl[1]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)(lpVtbl[2]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[4]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[5]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[6]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush**, int>)(lpVtbl[7]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DXGI_RGBA*, D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**, int>)(lpVtbl[8]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection**, int>)(lpVtbl[9]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)(lpVtbl[10]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)(lpVtbl[11]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_F*, D2D_SIZE_U*, D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget**, int>)(lpVtbl[12]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_F*, ID2D1Layer**, int>)(lpVtbl[13]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMesh([NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh**, int>)(lpVtbl[14]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), mesh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[15]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[16]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_RECT_F*, ID2D1Brush*, void>)(lpVtbl[17]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), rect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ROUNDED_RECT*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[18]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ROUNDED_RECT*, ID2D1Brush*, void>)(lpVtbl[19]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ELLIPSE*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[20]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ELLIPSE*, ID2D1Brush*, void>)(lpVtbl[21]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[22]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)(lpVtbl[23]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh*, ID2D1Brush*, void>)(lpVtbl[24]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, D2D1_OPACITY_MASK_CONTENT, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[25]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, D2D_RECT_F*, void>)(lpVtbl[26]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void>)(lpVtbl[27]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, void>)(lpVtbl[28]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, DWRITE_MEASURING_MODE, void>)(lpVtbl[29]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[30]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[31]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[32]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_ANTIALIAS_MODE>)(lpVtbl[33]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_TEXT_ANTIALIAS_MODE, void>)(lpVtbl[34]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_TEXT_ANTIALIAS_MODE>)(lpVtbl[35]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams*, void>)(lpVtbl[36]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams**, void>)(lpVtbl[37]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong, ulong, void>)(lpVtbl[38]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, void>)(lpVtbl[39]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_LAYER_PARAMETERS*, ID2D1Layer*, void>)(lpVtbl[40]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopLayer()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)(lpVtbl[41]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)(lpVtbl[42]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SaveDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)(lpVtbl[43]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RestoreDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)(lpVtbl[44]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[45]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopAxisAlignedClip()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)(lpVtbl[46]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DXGI_RGBA*, void>)(lpVtbl[47]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), clearColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginDraw()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)(lpVtbl[48]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)(lpVtbl[49]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[50]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float, float, void>)(lpVtbl[51]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float*, float*, void>)(lpVtbl[52]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[53]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[54]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)(lpVtbl[55]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_RENDER_TARGET_PROPERTIES*, int>)(lpVtbl[56]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* sourceData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[57]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), size, sourceData, pitch, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[58]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[59]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[60]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[61]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromDxgiSurface([NativeTypeName("IDXGISurface *")] IDXGISurface* surface, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDXGISurface*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[62]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), surface, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, ID2D1Effect**, int>)(lpVtbl[63]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, [NativeTypeName("ID2D1GradientStopCollection1 **")] ID2D1GradientStopCollection1** gradientStopCollection1)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_GRADIENT_STOP*, uint, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1**, int>)(lpVtbl[64]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, gradientStopCollection1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, D2D1_IMAGE_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1ImageBrush**, int>)(lpVtbl[65]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, imageBrushProperties, brushProperties, imageBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES1*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush1**, int>)(lpVtbl[66]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** commandList)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1CommandList**, int>)(lpVtbl[67]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), commandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsDxgiFormatSupported(DXGI_FORMAT format)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DXGI_FORMAT, int>)(lpVtbl[68]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_BUFFER_PRECISION, int>)(lpVtbl[69]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bufferPrecision);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageLocalBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, D2D_RECT_F*, int>)(lpVtbl[70]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, localBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageWorldBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, D2D_RECT_F*, int>)(lpVtbl[71]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, worldBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunWorldBounds([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_RECT_F*, int>)(lpVtbl[72]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, measuringMode, bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID2D1Device **")] ID2D1Device** device)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Device**, void>)(lpVtbl[73]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTarget([NativeTypeName("ID2D1Image *")] ID2D1Image* image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, void>)(lpVtbl[74]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTarget([NativeTypeName("ID2D1Image **")] ID2D1Image** image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image**, void>)(lpVtbl[75]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetRenderingControls([NativeTypeName("const D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_RENDERING_CONTROLS*, void>)(lpVtbl[76]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderingControls);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetRenderingControls([NativeTypeName("D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_RENDERING_CONTROLS*, void>)(lpVtbl[77]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderingControls);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_PRIMITIVE_BLEND, void>)(lpVtbl[78]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_PRIMITIVE_BLEND>)(lpVtbl[79]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_UNIT_MODE, void>)(lpVtbl[80]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), unitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_UNIT_MODE GetUnitMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_UNIT_MODE>)(lpVtbl[81]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, void>)(lpVtbl[82]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, void>)(lpVtbl[83]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, D2D_POINT_2F*, void>)(lpVtbl[84]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, void>)(lpVtbl[85]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, void>)(lpVtbl[86]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateEffectInputRectangle([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint, D2D_RECT_F*, int>)(lpVtbl[87]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, input, inputRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangleCount([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32 *")] uint* rectangleCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint*, int>)(lpVtbl[88]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, rectangleCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, D2D_RECT_F*, uint, int>)(lpVtbl[89]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), effect, rectangles, rectanglesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectRequiredInputRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* renderEffect, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle, [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")] D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, D2D_RECT_F*, D2D1_EFFECT_INPUT_DESCRIPTION*, D2D_RECT_F*, uint, int>)(lpVtbl[90]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[91]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFilledGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)(lpVtbl[92]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, geometryRealization);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStrokedGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)(lpVtbl[93]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGeometryRealization([NativeTypeName("ID2D1GeometryRealization *")] ID2D1GeometryRealization* geometryRealization, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GeometryRealization*, ID2D1Brush*, void>)(lpVtbl[94]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), geometryRealization, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInk([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint, [NativeTypeName("ID2D1Ink **")] ID2D1Ink** ink)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_INK_POINT*, ID2D1Ink**, int>)(lpVtbl[95]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), startPoint, ink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInkStyle([NativeTypeName("const D2D1_INK_STYLE_PROPERTIES *")] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, [NativeTypeName("ID2D1InkStyle **")] ID2D1InkStyle** inkStyle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_INK_STYLE_PROPERTIES*, ID2D1InkStyle**, int>)(lpVtbl[96]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), inkStyleProperties, inkStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGradientMesh([NativeTypeName("const D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, [NativeTypeName("ID2D1GradientMesh **")] ID2D1GradientMesh** gradientMesh)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_GRADIENT_MESH_PATCH*, uint, ID2D1GradientMesh**, int>)(lpVtbl[97]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), patches, patchesCount, gradientMesh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, D2D1_IMAGE_SOURCE_LOADING_OPTIONS, D2D1_ALPHA_MODE, ID2D1ImageSourceFromWic**, int>)(lpVtbl[98]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), wicBitmapSource, loadingOptions, alphaMode, imageSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_BUFFER_PRECISION, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)(lpVtbl[99]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), precision, extents, data, dataCount, strides, lookupTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromDxgi([NativeTypeName("IDXGISurface **")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, [NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDXGISurface**, uint, DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, ID2D1ImageSource**, int>)(lpVtbl[100]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), surfaces, surfaceCount, colorSpace, options, imageSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGradientMeshWorldBounds([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* pBounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, D2D_RECT_F*, int>)(lpVtbl[101]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientMesh, pBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawInk([NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)(lpVtbl[102]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), ink, brush, inkStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGradientMesh([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, void>)(lpVtbl[103]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gradientMesh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[104]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), gdiMetafile, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedImageSource([NativeTypeName("ID2D1ImageSource *")] ID2D1ImageSource* imageSource, [NativeTypeName("const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, [NativeTypeName("ID2D1TransformedImageSource **")] ID2D1TransformedImageSource** transformedImageSource)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, ID2D1TransformedImageSource**, int>)(lpVtbl[105]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), imageSource, properties, transformedImageSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSpriteBatch([NativeTypeName("ID2D1SpriteBatch **")] ID2D1SpriteBatch** spriteBatch)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch**, int>)(lpVtbl[106]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), spriteBatch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawSpriteBatch([NativeTypeName("ID2D1SpriteBatch *")] ID2D1SpriteBatch* spriteBatch, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, D2D1_BITMAP_INTERPOLATION_MODE, D2D1_SPRITE_OPTIONS, void>)(lpVtbl[107]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSvgGlyphStyle([NativeTypeName("ID2D1SvgGlyphStyle **")] ID2D1SvgGlyphStyle** svgGlyphStyle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgGlyphStyle**, int>)(lpVtbl[108]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), svgGlyphStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void>)(lpVtbl[109]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, options, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, D2D1_DRAW_TEXT_OPTIONS, void>)(lpVtbl[110]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawColorBitmapGlyphRun(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption = D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DWRITE_GLYPH_IMAGE_FORMATS, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION, void>)(lpVtbl[111]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphImageFormat, baselineOrigin, glyphRun, measuringMode, bitmapSnapOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawSvgGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush = null, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle = null, [NativeTypeName("UINT32")] uint colorPaletteIndex = 0, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DWRITE_MEASURING_MODE, void>)(lpVtbl[112]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1Image **")] ID2D1Image** glyphImage)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DWRITE_GLYPH_IMAGE_FORMATS, D2D_POINT_2F, IDWriteFontFace*, float, ushort, int, D2D_MATRIX_3X2_F*, float, float, D2D_MATRIX_3X2_F*, ID2D1Image**, int>)(lpVtbl[113]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSvgGlyphImage([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("UINT16")] ushort glyphIndex, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, [NativeTypeName("ID2D1SvgGlyphStyle *")] ID2D1SvgGlyphStyle* svgGlyphStyle, [NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform, [NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** glyphImage)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D_POINT_2F, IDWriteFontFace*, float, ushort, int, D2D_MATRIX_3X2_F*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, D2D_MATRIX_3X2_F*, ID2D1CommandList**, int>)(lpVtbl[114]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSvgDocument([NativeTypeName("IStream *")] IStream* inputXmlStream, [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize, [NativeTypeName("ID2D1SvgDocument **")] ID2D1SvgDocument** svgDocument)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IStream*, D2D_SIZE_F, ID2D1SvgDocument**, int>)(lpVtbl[115]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), inputXmlStream, viewportSize, svgDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawSvgDocument([NativeTypeName("ID2D1SvgDocument *")] ID2D1SvgDocument* svgDocument)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgDocument*, void>)(lpVtbl[116]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), svgDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DXGI_COLOR_SPACE_TYPE, ID2D1ColorContext1**, int>)(lpVtbl[117]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), colorSpace, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromSimpleColorProfile([NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile, [NativeTypeName("ID2D1ColorContext1 **")] ID2D1ColorContext1** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, D2D1_SIMPLE_COLOR_PROFILE*, ID2D1ColorContext1**, int>)(lpVtbl[118]))((ID2D1DeviceContext5*)Unsafe.AsPointer(ref this), simpleProfile, colorContext);
        }
    }
}
