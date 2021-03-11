// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT).
// See third-party-notices in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

// <auto-generated />
#nullable enable
#pragma warning disable CS0649

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IXmlWriterLite" /> struct.</summary>
    public static unsafe class IXmlWriterLiteTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IXmlWriterLite" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IXmlWriterLite).GUID, Is.EqualTo(IID_IXmlWriterLite));
        }

        /// <summary>Validates that the <see cref="IXmlWriterLite" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IXmlWriterLite>(), Is.EqualTo(sizeof(IXmlWriterLite)));
        }

        /// <summary>Validates that the <see cref="IXmlWriterLite" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IXmlWriterLite).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IXmlWriterLite" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IXmlWriterLite), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IXmlWriterLite), Is.EqualTo(4));
            }
        }
    }
}
