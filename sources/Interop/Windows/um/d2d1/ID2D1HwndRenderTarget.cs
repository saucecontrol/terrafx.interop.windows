// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_GAMMA;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("2CD90698-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1HwndRenderTarget : ID2D1RenderTarget")]
    public unsafe partial struct ID2D1HwndRenderTarget
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)(lpVtbl[1]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)(lpVtbl[2]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[4]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[5]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, Guid*, void*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[6]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush**, int>)(lpVtbl[7]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, DXGI_RGBA*, D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**, int>)(lpVtbl[8]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection**, int>)(lpVtbl[9]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)(lpVtbl[10]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)(lpVtbl[11]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_F*, D2D_SIZE_U*, D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget**, int>)(lpVtbl[12]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_F*, ID2D1Layer**, int>)(lpVtbl[13]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), size, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMesh([NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh**, int>)(lpVtbl[14]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), mesh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[15]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[16]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_RECT_F*, ID2D1Brush*, void>)(lpVtbl[17]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), rect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ROUNDED_RECT*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[18]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ROUNDED_RECT*, ID2D1Brush*, void>)(lpVtbl[19]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ELLIPSE*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[20]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ELLIPSE*, ID2D1Brush*, void>)(lpVtbl[21]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[22]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)(lpVtbl[23]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)(lpVtbl[24]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, D2D1_OPACITY_MASK_CONTENT, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[25]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, D2D_RECT_F*, void>)(lpVtbl[26]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void>)(lpVtbl[27]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, void>)(lpVtbl[28]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, DWRITE_MEASURING_MODE, void>)(lpVtbl[29]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[30]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[31]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[32]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_ANTIALIAS_MODE>)(lpVtbl[33]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_TEXT_ANTIALIAS_MODE, void>)(lpVtbl[34]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_TEXT_ANTIALIAS_MODE>)(lpVtbl[35]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams*, void>)(lpVtbl[36]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IDWriteRenderingParams**, void>)(lpVtbl[37]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong, ulong, void>)(lpVtbl[38]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, void>)(lpVtbl[39]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_LAYER_PARAMETERS*, ID2D1Layer*, void>)(lpVtbl[40]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopLayer()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)(lpVtbl[41]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)(lpVtbl[42]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SaveDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[43]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RestoreDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[44]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[45]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopAxisAlignedClip()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)(lpVtbl[46]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, DXGI_RGBA*, void>)(lpVtbl[47]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), clearColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginDraw()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, void>)(lpVtbl[48]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, ulong*, ulong*, int>)(lpVtbl[49]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[50]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float, float, void>)(lpVtbl[51]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, float*, float*, void>)(lpVtbl[52]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[53]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[54]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, uint>)(lpVtbl[55]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_RENDER_TARGET_PROPERTIES*, int>)(lpVtbl[56]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_WINDOW_STATE CheckWindowState()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D1_WINDOW_STATE>)(lpVtbl[57]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* pixelSize)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, D2D_SIZE_U*, int>)(lpVtbl[58]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this), pixelSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public IntPtr GetHwnd()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1HwndRenderTarget*, IntPtr>)(lpVtbl[59]))((ID2D1HwndRenderTarget*)Unsafe.AsPointer(ref this));
        }
    }
}
