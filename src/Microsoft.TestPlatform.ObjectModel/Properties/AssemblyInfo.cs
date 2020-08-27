// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: AssemblyProduct("Microsoft.TestPlatfrom.ObjectModel")]
[assembly: AssemblyTrademark("")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("8a200cda-4813-43a1-aa18-9faedc31d2af")]


// Type forwarding utility classes defined earlier in object model to a core utilities assembly.
[assembly: TypeForwardedTo(typeof(EqtTrace))]
[assembly: TypeForwardedTo(typeof(ValidateArg))]
[assembly: TypeForwardedTo(typeof(ValidateArgProperty))]
[assembly: TypeForwardedTo(typeof(ValidatedNotNullAttribute))]

// Type forwarding to Primitives assembly
[assembly: TypeForwardedTo(typeof(AttachmentSet))]
[assembly: TypeForwardedTo(typeof(UriDataAttachment))]
[assembly: TypeForwardedTo(typeof(ILazyPropertyValue))]
[assembly: TypeForwardedTo(typeof(LazyPropertyValue<>))]
[assembly: TypeForwardedTo(typeof(TestCase))]
[assembly: TypeForwardedTo(typeof(TestCaseProperties))]
[assembly: TypeForwardedTo(typeof(TestObject))]
[assembly: TypeForwardedTo(typeof(TestOutcome))]
[assembly: TypeForwardedTo(typeof(TestOutcomeHelper))]
[assembly: TypeForwardedTo(typeof(TestResult))]
[assembly: TypeForwardedTo(typeof(TestResultMessage))]
[assembly: TypeForwardedTo(typeof(TestResultProperties))]
[assembly: TypeForwardedTo(typeof(Trait))]
[assembly: TypeForwardedTo(typeof(TraitCollection))]
[assembly: TypeForwardedTo(typeof(EqtHash))]
[assembly: TypeForwardedTo(typeof(CustomKeyValueConverter))]
[assembly: TypeForwardedTo(typeof(CustomStringArrayConverter))]
[assembly: TypeForwardedTo(typeof(TestProperty))]
[assembly: TypeForwardedTo(typeof(ValidateValueCallback))]
[assembly: TypeForwardedTo(typeof(TestPropertyAttributes))]
[assembly: TypeForwardedTo(typeof(TestMessageLevel))]
[assembly: TypeForwardedTo(typeof(IMessageLogger))]
[assembly: TypeForwardedTo(typeof(TestPlatformFormatException))]
[assembly: TypeForwardedTo(typeof(TestCanceledException))]

[assembly: TypeForwardedTo(typeof(IDiscoveryContext))]
[assembly: TypeForwardedTo(typeof(IFrameworkHandle))]
[assembly: TypeForwardedTo(typeof(IFrameworkHandle2))]
[assembly: TypeForwardedTo(typeof(IRunContext))]
[assembly: TypeForwardedTo(typeof(IRunSettings))]
[assembly: TypeForwardedTo(typeof(ISettingsProvider))]
[assembly: TypeForwardedTo(typeof(ITestCaseDiscoverySink))]
[assembly: TypeForwardedTo(typeof(ITestCaseFilterExpression))]
[assembly: TypeForwardedTo(typeof(ITestDiscoverer))]
[assembly: TypeForwardedTo(typeof(ITestExecutor))]
[assembly: TypeForwardedTo(typeof(ITestExecutor2))]
[assembly: TypeForwardedTo(typeof(ITestExecutionRecorder))]
