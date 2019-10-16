// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D11_MESSAGE_CATEGORY
    {
        D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED = 0,
        D3D11_MESSAGE_CATEGORY_MISCELLANEOUS = (D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED + 1),
        D3D11_MESSAGE_CATEGORY_INITIALIZATION = (D3D11_MESSAGE_CATEGORY_MISCELLANEOUS + 1),
        D3D11_MESSAGE_CATEGORY_CLEANUP = (D3D11_MESSAGE_CATEGORY_INITIALIZATION + 1),
        D3D11_MESSAGE_CATEGORY_COMPILATION = (D3D11_MESSAGE_CATEGORY_CLEANUP + 1),
        D3D11_MESSAGE_CATEGORY_STATE_CREATION = (D3D11_MESSAGE_CATEGORY_COMPILATION + 1),
        D3D11_MESSAGE_CATEGORY_STATE_SETTING = (D3D11_MESSAGE_CATEGORY_STATE_CREATION + 1),
        D3D11_MESSAGE_CATEGORY_STATE_GETTING = (D3D11_MESSAGE_CATEGORY_STATE_SETTING + 1),
        D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION = (D3D11_MESSAGE_CATEGORY_STATE_GETTING + 1),
        D3D11_MESSAGE_CATEGORY_EXECUTION = (D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION + 1),
        D3D11_MESSAGE_CATEGORY_SHADER = (D3D11_MESSAGE_CATEGORY_EXECUTION + 1),
    }
}
