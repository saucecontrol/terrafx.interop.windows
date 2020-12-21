// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CAFD1DB1-41D1-4A06-9863-E2E81DA17A9A")]
    [NativeTypeName("struct ISpeechGrammarRuleStateTransition : IDispatch")]
    public unsafe partial struct ISpeechGrammarRuleStateTransition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SpeechGrammarRuleStateTransitionType *")] SpeechGrammarRuleStateTransitionType* Type)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, SpeechGrammarRuleStateTransitionType*, int>)(lpVtbl[7]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Text([NativeTypeName("BSTR *")] ushort** Text)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[8]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rule([NativeTypeName("ISpeechGrammarRule **")] ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRule**, int>)(lpVtbl[9]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Weight([NativeTypeName("VARIANT *")] VARIANT* Weight)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[10]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[11]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PropertyId([NativeTypeName("long *")] int* PropertyId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, int*, int>)(lpVtbl[12]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PropertyValue([NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[13]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NextState([NativeTypeName("ISpeechGrammarRuleState **")] ISpeechGrammarRuleState** NextState)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRuleState**, int>)(lpVtbl[14]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), NextState);
        }
    }
}
