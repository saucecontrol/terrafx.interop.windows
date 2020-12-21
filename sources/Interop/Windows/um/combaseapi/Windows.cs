// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.CLSCTX;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMalloc([NativeTypeName("DWORD")] uint dwMemContext, [NativeTypeName("LPMALLOC *")] IMalloc** ppMalloc);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateStreamOnHGlobal([NativeTypeName("HGLOBAL")] IntPtr hGlobal, [NativeTypeName("BOOL")] int fDeleteOnRelease, [NativeTypeName("LPSTREAM *")] IStream** ppstm);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetHGlobalFromStream([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HGLOBAL *")] IntPtr* phglobal);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void CoUninitialize();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CoGetCurrentProcess();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeEx([NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint dwCoInit);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallerTID([NativeTypeName("LPDWORD")] uint* lpdwTID);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetContextToken([NativeTypeName("ULONG_PTR *")] nuint* pToken);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetDefaultContext(APTTYPE aptType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType, [NativeTypeName("APTTYPEQUALIFIER *")] APTTYPEQUALIFIER* pAptQualifier);

        [DllImport("combase", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecodeProxy([NativeTypeName("DWORD")] uint dwClientPid, [NativeTypeName("UINT64")] ulong ui64ProxyAddress, [NativeTypeName("PServerInformation")] ServerInformation* pServerInformation);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoIncrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE *")] IntPtr* pCookie);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE")] IntPtr Cookie);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoAllowUnmarshalerCLSID([NativeTypeName("const IID &")] Guid* clsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetObjectContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpdwRegister);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevokeClassObject([NativeTypeName("DWORD")] uint dwRegister);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoResumeClassObjects();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSuspendClassObjects();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoAddRefServerProcess();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoReleaseServerProcess();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("CLSID *")] Guid* pClsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const IID &")] Guid* rclsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterSurrogate([NativeTypeName("LPSURROGATE")] ISurrogate* pSurrogate);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMarshalSizeMax([NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT")] int hresult);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT *")] int* phresult);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoReleaseMarshalData([NativeTypeName("LPSTREAM")] IStream* pStm);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectObject([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoLockObjectExternal([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockReleases);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStandardMarshal([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("LPMARSHAL *")] IMarshal** ppMarshal);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStdMarshalEx([NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint smexflags, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppUnkInner);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CoIsHandlerConnected([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterThreadInterfaceInStream([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("LPSTREAM *")] IStream** ppStm);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetInterfaceAndReleaseStream([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateFreeThreadedMarshaler([NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppunkMarshal);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void CoFreeUnusedLibraries();

        [DllImport("combase", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void CoFreeUnusedLibrariesEx([NativeTypeName("DWORD")] uint dwUnloadDelay, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectContext([NativeTypeName("DWORD")] uint dwTimeout);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecDesc, [NativeTypeName("LONG")] int cAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE *")] SOLE_AUTHENTICATION_SERVICE* asAuthSvc, [NativeTypeName("void *")] void* pReserved1, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("void *")] void* pAuthList, [NativeTypeName("DWORD")] uint dwCapabilities, [NativeTypeName("void *")] void* pReserved3);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppInterface);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pwAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCopyProxy([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("IUnknown **")] IUnknown** ppCopy);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryClientBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoImpersonateClient();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevertToSelf();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryAuthenticationServices([NativeTypeName("DWORD *")] uint* pcAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE **")] SOLE_AUTHENTICATION_SERVICE** asAuthSvc);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSwitchCallContext([NativeTypeName("IUnknown *")] IUnknown* pNewObject, [NativeTypeName("IUnknown **")] IUnknown** ppOldObject);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceEx([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("COSERVERINFO *")] COSERVERINFO* pServerInfo, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport("combase", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceFromApp([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("PVOID")] void* reserved, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterActivationFilter([NativeTypeName("IActivationFilter *")] IActivationFilter* pActivationFilter);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCancelObject([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppUnk);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetCancelObject([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCancelCall([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ULONG")] uint ulTimeout);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoTestCancel();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoEnableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromCLSID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPCLSID")] Guid* pclsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromIID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPIID")] Guid* lpiid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ProgIDFromCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPOLESTR *")] ushort** lplpszProgID);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgID([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int StringFromGUID2([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("LPOLESTR")] ushort* lpsz, int cchMax);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateGuid([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantCopy([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarDest, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSrc);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantClear([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvar);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FreePropVariantArray([NativeTypeName("ULONG")] uint cVariants, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgvars);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleHandles([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("LPHANDLE")] IntPtr* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport("combase", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleObjects([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("const HANDLE *")] IntPtr* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetTreatAsClass([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("LPCLSID")] Guid* pClsidNew);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInvalidateRemoteMachineBindings([NativeTypeName("LPOLESTR")] ushort* pszMachineName);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetAgileReference([NativeTypeName("enum AgileReferenceOptions")] AgileReferenceOptions options, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IAgileReference **")] IAgileReference** ppAgileReference);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllCanUnloadNow();

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemAlloc([NativeTypeName("SIZE_T")] nuint cb);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("SIZE_T")] nuint cb);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void CoTaskMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoFileTimeNow([NativeTypeName("FILETIME *")] FILETIME* lpFileTime);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgIDEx([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterDeviceCatalog([NativeTypeName("PCWSTR")] ushort* deviceInstanceId, [NativeTypeName("CO_DEVICE_CATALOG_COOKIE *")] IntPtr* cookie);

        [DllImport("Ole32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevokeDeviceCatalog([NativeTypeName("CO_DEVICE_CATALOG_COOKIE")] IntPtr cookie);

        [NativeTypeName("#define CLSCTX_INPROC (CLSCTX_INPROC_SERVER|CLSCTX_INPROC_HANDLER)")]
        public const int CLSCTX_INPROC = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER));

        [NativeTypeName("#define CLSCTX_ALL (CLSCTX_INPROC_SERVER| \\\r\n                                 CLSCTX_INPROC_HANDLER| \\\r\n                                 CLSCTX_LOCAL_SERVER| \\\r\n                                 CLSCTX_REMOTE_SERVER)")]
        public const int CLSCTX_ALL = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_REMOTE_SERVER));

        [NativeTypeName("#define CLSCTX_SERVER (CLSCTX_INPROC_SERVER|CLSCTX_LOCAL_SERVER|CLSCTX_REMOTE_SERVER)")]
        public const int CLSCTX_SERVER = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_REMOTE_SERVER));

        [NativeTypeName("#define _CRT_INTERNAL_COMBASE_SYMBOL_PREFIX \"_\"")]
        public static ReadOnlySpan<byte> _CRT_INTERNAL_COMBASE_SYMBOL_PREFIX => new byte[] { 0x5F, 0x00 };

        [NativeTypeName("#define COM_RIGHTS_EXECUTE 1")]
        public const int COM_RIGHTS_EXECUTE = 1;

        [NativeTypeName("#define COM_RIGHTS_EXECUTE_LOCAL 2")]
        public const int COM_RIGHTS_EXECUTE_LOCAL = 2;

        [NativeTypeName("#define COM_RIGHTS_EXECUTE_REMOTE 4")]
        public const int COM_RIGHTS_EXECUTE_REMOTE = 4;

        [NativeTypeName("#define COM_RIGHTS_ACTIVATE_LOCAL 8")]
        public const int COM_RIGHTS_ACTIVATE_LOCAL = 8;

        [NativeTypeName("#define COM_RIGHTS_ACTIVATE_REMOTE 16")]
        public const int COM_RIGHTS_ACTIVATE_REMOTE = 16;

        [NativeTypeName("#define COM_RIGHTS_RESERVED1 32")]
        public const int COM_RIGHTS_RESERVED1 = 32;

        [NativeTypeName("#define COM_RIGHTS_RESERVED2 64")]
        public const int COM_RIGHTS_RESERVED2 = 64;

        [NativeTypeName("#define CWMO_MAX_HANDLES 56")]
        public const int CWMO_MAX_HANDLES = 56;
    }
}
