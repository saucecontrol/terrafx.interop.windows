// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDxcCompiler3" /> struct.</summary>
    public static unsafe class IDxcCompiler3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcCompiler3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDxcCompiler3).GUID, Is.EqualTo(IID_IDxcCompiler3));
        }

        /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDxcCompiler3>(), Is.EqualTo(sizeof(IDxcCompiler3)));
        }

        /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDxcCompiler3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDxcCompiler3), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDxcCompiler3), Is.EqualTo(4));
            }
        }
    }
}
