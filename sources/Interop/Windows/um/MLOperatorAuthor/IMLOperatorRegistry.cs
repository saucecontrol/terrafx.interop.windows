// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2AF9DD2D-B516-4672-9AB5-530C208493AD")]
    [NativeTypeName("struct IMLOperatorRegistry : IUnknown")]
    public unsafe partial struct IMLOperatorRegistry
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorRegistry*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorRegistry*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorRegistry*, uint>)(lpVtbl[1]))((IMLOperatorRegistry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorRegistry*, uint>)(lpVtbl[2]))((IMLOperatorRegistry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterOperatorSetSchema([NativeTypeName("const MLOperatorSetId *")] MLOperatorSetId* operatorSetId, [NativeTypeName("int32_t")] int baselineVersion, [NativeTypeName("const MLOperatorSchemaDescription *const *")] MLOperatorSchemaDescription** schema, [NativeTypeName("uint32_t")] uint schemaCount, [NativeTypeName("IMLOperatorTypeInferrer *")] IMLOperatorTypeInferrer* typeInferrer, [NativeTypeName("IMLOperatorShapeInferrer *")] IMLOperatorShapeInferrer* shapeInferrer)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorRegistry*, MLOperatorSetId*, int, MLOperatorSchemaDescription**, uint, IMLOperatorTypeInferrer*, IMLOperatorShapeInferrer*, int>)(lpVtbl[3]))((IMLOperatorRegistry*)Unsafe.AsPointer(ref this), operatorSetId, baselineVersion, schema, schemaCount, typeInferrer, shapeInferrer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterOperatorKernel([NativeTypeName("const MLOperatorKernelDescription *")] MLOperatorKernelDescription* operatorKernel, [NativeTypeName("IMLOperatorKernelFactory *")] IMLOperatorKernelFactory* operatorKernelFactory, [NativeTypeName("IMLOperatorShapeInferrer *")] IMLOperatorShapeInferrer* shapeInferrer)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorRegistry*, MLOperatorKernelDescription*, IMLOperatorKernelFactory*, IMLOperatorShapeInferrer*, int>)(lpVtbl[4]))((IMLOperatorRegistry*)Unsafe.AsPointer(ref this), operatorKernel, operatorKernelFactory, shapeInferrer);
        }
    }
}
