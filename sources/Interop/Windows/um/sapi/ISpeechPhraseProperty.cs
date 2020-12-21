// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE563D48-961E-4732-A2E1-378A42B430BE")]
    [NativeTypeName("struct ISpeechPhraseProperty : IDispatch")]
    public unsafe partial struct ISpeechPhraseProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, uint>)(lpVtbl[1]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, uint>)(lpVtbl[2]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, ushort**, int>)(lpVtbl[7]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, int*, int>)(lpVtbl[8]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Value([NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, int*, int>)(lpVtbl[10]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, int*, int>)(lpVtbl[11]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence([NativeTypeName("float *")] float* Confidence)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, float*, int>)(lpVtbl[12]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Confidence([NativeTypeName("SpeechEngineConfidence *")] SpeechEngineConfidence* Confidence)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, SpeechEngineConfidence*, int>)(lpVtbl[13]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Parent([NativeTypeName("ISpeechPhraseProperty **")] ISpeechPhraseProperty** ParentProperty)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, ISpeechPhraseProperty**, int>)(lpVtbl[14]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), ParentProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Children([NativeTypeName("ISpeechPhraseProperties **")] ISpeechPhraseProperties** Children)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechPhraseProperty*, ISpeechPhraseProperties**, int>)(lpVtbl[15]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Children);
        }
    }
}
